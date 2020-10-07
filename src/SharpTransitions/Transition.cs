using System;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;

namespace SharpTransitions
{
    /// <summary>
    /// Lets you perform animated transitions of properties on arbitrary objects. These 
    /// will often be transitions of UI properties, for example an animated fade-in of 
    /// a UI object, or an animated move of a UI object from one position to another.
    /// 
    /// Each transition can simulataneously change multiple properties, including properties
    /// across multiple objects.
    /// 
    /// Example transition
    /// ------------------
    /// a.      Transition t = new Transition(new TransitionMethod_Linear(500));
    /// b.      t.add(form1, "Width", 500);
    /// c.      t.add(form1, "BackColor", Color.Red);
    /// d.      t.run();
    ///   
    /// Line a:         Creates a new transition. You specify the transition method.
    ///                 
    /// Lines b. and c: Set the destination values of the properties you are animating.
    /// 
    /// Line d:         Starts the transition.
    /// 
    /// Transition methods
    /// ------------------
    /// TransitionMethod objects specify how the transition is made. Examples include
    /// linear transition, ease-in-ease-out and so on. Different transition methods may
    /// need different parameters.
    /// 
    /// </summary>
    public class Transition
	{
		/// <summary>
        /// You should register all managed-types here.
        /// </summary>
        static Transition()
        {
            RegisterType(new ManagedInt());
            RegisterType(new ManagedFloat());
			RegisterType(new ManagedDouble());
            RegisterType(new ManagedColor());
            RegisterType(new ManagedString());
        }

        /// <summary>
        /// Args passed with the TransitionCompletedEvent.
        /// </summary>
        public class Args : EventArgs
        {
        }

        /// <summary>
        /// Event raised when the transition hass completed.
        /// </summary>
        public event EventHandler<Args> TransitionCompletedEvent;

        /// <summary>
        /// Creates and immediately runs a transition on the property passed in.
        /// </summary>
        public static void Run(object target, string strPropertyName, object destinationValue, ITransitionType transitionMethod)
        {
            var transition = new Transition(transitionMethod);
            transition.Add(target, strPropertyName, destinationValue);
            transition.Run();
        }

        /// <summary>
        /// Sets the property passed in to the initial value passed in, then creates and 
        /// immediately runs a transition on it.
        /// </summary>
        public static void Run(object target, string strPropertyName, object initialValue, object destinationValue, ITransitionType transitionMethod)
        {
            Utility.SetValue(target, strPropertyName, initialValue);
            Run(target, strPropertyName, destinationValue, transitionMethod);
        }

        /// <summary>
        /// Creates a TransitionChain and runs it.
        /// </summary>
        public static void RunChain(params Transition[] transitions)
        {
            TransitionChain chain = new TransitionChain(transitions);
        }

        /// <summary>
        /// Constructor. You pass in the object that holds the properties 
        /// that you are performing transitions on.
        /// </summary>
        public Transition(ITransitionType effect)
        {
			_effect = effect;
        }

		/// <summary>
		/// Adds a property that should be animated as part of this transition.
		/// </summary>
		public void Add(object target, string strPropertyName, object destinationValue)
		{
			// We get the property info...
			Type targetType = target.GetType();
			PropertyInfo propertyInfo = targetType.GetProperty(strPropertyName);
			if (propertyInfo == null)
			{
				throw new Exception("Object: " + target.ToString() + " does not have the property: " + strPropertyName);
			}

			// We check that we support the property type...
			Type propertyType = propertyInfo.PropertyType;
			if (_mapManagedTypes.ContainsKey(propertyType) == false)
			{
				throw new Exception("Transition does not handle properties of type: " + propertyType.ToString());
			}

            // We can only transition properties that are both getable and setable...
            if (propertyInfo.CanRead == false || propertyInfo.CanWrite == false)
            {
                throw new Exception("Property is not both getable and setable: " + strPropertyName);
            }

            IManagedType managedType = _mapManagedTypes[propertyType];
            
            // We can manage this type, so we store the information for the
			// transition of this property...
			TransitionedPropertyInfo info = new TransitionedPropertyInfo();
			info.endValue = destinationValue;
			info.target = target;
			info.propertyInfo = propertyInfo;
			info.managedType = managedType;

            lock (_lock)
            {
                _listTransitionedProperties.Add(info);
            }
		}

        /// <summary>
        /// Starts the transition.
        /// </summary>
        public void Run()
        {
            // We find the current start values for the properties we 
            // are animating...
            foreach (TransitionedPropertyInfo info in _listTransitionedProperties)
            {
                object value = info.propertyInfo.GetValue(info.target, null);
                info.startValue = info.managedType.Copy(value);
            }

			// We start the stopwatch. We use this when the timer ticks to measure 
			// how long the transition has been runnning for...
			_stopwatch.Reset();
			_stopwatch.Start();

            // We register this transition with the transition manager...
            TransitionManager.GetInstance().Register(this);
		}

        /// <summary>
        /// Property that returns a list of information about each property managed
        /// by this transition.
        /// </summary>
        internal IList<TransitionedPropertyInfo> TransitionedProperties
        {
            get { return _listTransitionedProperties; }
        }

        /// <summary>
        /// We remove the property with the info passed in from the transition.
        /// </summary>
        internal void RemoveProperty(TransitionedPropertyInfo info)
        {
            lock (_lock)
            {
                _listTransitionedProperties.Remove(info);
            }
        }

        /// <summary>
        /// Called when the transition timer ticks.
        /// </summary>
        internal void OnTimer()
        {
            // When the timer ticks we:
            // a. Find the elapsed time since the transition started.
            // b. Work out the percentage movement for the properties we're managing.
            // c. Find the actual values of each property, and set them.

            // a.
            int iElapsedTime = (int)_stopwatch.ElapsedMilliseconds;

            // b.
            double dPercentage;
            bool bCompleted;
            _effect.OnTimer(iElapsedTime, out dPercentage, out bCompleted);

            // We take a copy of the list of properties we are transitioning, as
            // they can be changed by another thread while this method is running...
            IList<TransitionedPropertyInfo> listTransitionedProperties = new List<TransitionedPropertyInfo>();
            lock (_lock)
            {
                foreach (TransitionedPropertyInfo info in _listTransitionedProperties)
                {
                    listTransitionedProperties.Add(info.Copy());
                }
            }

            // c. 
            foreach (TransitionedPropertyInfo info in listTransitionedProperties)
            {
                // We get the current value for this property...
                object value = info.managedType.GetIntermediateValue(info.startValue, info.endValue, dPercentage);

                // We set it...
                PropertyUpdateArgs args = new PropertyUpdateArgs(info.target, info.propertyInfo, value);
                SetProperty(this, args);
            }

            // Has the transition completed?
            if (bCompleted == true)
            {
                // We stop the stopwatch and the timer...
                _stopwatch.Stop();

                // We raise an event to notify any observers that the transition has completed...
                Utility.RaiseEvent(TransitionCompletedEvent, this, new Args());
            }
        }

		/// <summary>
		/// Sets a property on the object passed in to the value passed in. This method
		/// invokes itself on the GUI thread if the property is being invoked on a GUI 
		/// object.
		/// </summary>
		private void SetProperty(object sender, PropertyUpdateArgs args)
		{
            try
            {
                // If the target is a control that has been disposed then we don't 
                // try to update its properties. This can happen if the control is
                // on a form that has been closed while the transition is running...
                if (IsDisposed(args.target) == true)
                {
                    return;
                }

                ISynchronizeInvoke invokeTarget = args.target as ISynchronizeInvoke;
                if (invokeTarget != null && invokeTarget.InvokeRequired)
                {
                    // There is some history behind the next two lines, which is worth
                    // going through to understand why they are the way they are.

                    // Initially we used BeginInvoke without the subsequent WaitOne for
                    // the result. A transition could involve a large number of updates
                    // to a property, and as this call was asynchronous it would send a 
                    // large number of updates to the UI thread. These would queue up at
                    // the GUI thread and mean that the UI could be some way behind where
                    // the transition was.

                    // The line was then changed to the blocking Invoke call instead. This 
                    // meant that the transition only proceded at the pace that the GUI 
                    // could process it, and the UI was not overloaded with "old" updates.

                    // However, in some circumstances Invoke could block and lock up the
                    // Transitions background thread. In particular, this can happen if the
                    // control that we are trying to update is in the process of being 
                    // disposed - for example, it is on a form that is being closed. See
                    // here for details: 
                    // http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/7d2c941a-0016-431a-abba-67c5d5dac6a5
                    
                    // To solve this, we use a combination of the two earlier approaches. 
                    // We use BeginInvoke as this does not block and lock up, even if the
                    // underlying object is being disposed. But we do want to wait to give
                    // the UI a chance to process the update. So what we do is to do the
                    // asynchronous BeginInvoke, but then wait (with a short timeout) for
                    // it to complete.
                    IAsyncResult asyncResult = invokeTarget.BeginInvoke(new EventHandler<PropertyUpdateArgs>(SetProperty), new object[] { sender, args });
                    asyncResult.AsyncWaitHandle.WaitOne(50);
                }
                else
                {
                    // We are on the correct thread, so we update the property...
                    args.propertyInfo.SetValue(args.target, args.value, null);
                }
            }
            catch (Exception)
            {
                // We silently catch any exceptions. These could be things like 
                // bounds exceptions when setting properties.
            }
		}

        /// <summary>
        /// Returns true if the object passed in is a Control and is disposed
        /// or in the process of disposing. (If this is the case, we don't want
        /// to make any changes to its properties.)
        /// </summary>
        private bool IsDisposed(object target)
        {
            // Is the object passed in a Control?
            Control controlTarget = target as Control;
            if (controlTarget == null)
            {
                return false;
            }

            // Is it disposed or disposing?
            if (controlTarget.IsDisposed == true || controlTarget.Disposing)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		/// <summary>
		/// Registers a transition-type. We hold them in a map.
		/// </summary>
		private static void RegisterType(IManagedType transitionType)
		{
			Type type = transitionType.GetManagedType();
			_mapManagedTypes[type] = transitionType;
		}

		// A map of Type info to IManagedType objects. These are all the types that we
        // know how to perform transitions on...
        private static IDictionary<Type, IManagedType> _mapManagedTypes = new Dictionary<Type, IManagedType>();

		// The transition method used by this transition...
		private ITransitionType _effect = null;

		// Holds information about one property on one taregt object that we are performing
		// a transition on...
		internal class TransitionedPropertyInfo
		{
			public object startValue;
			public object endValue;
			public object target;
			public PropertyInfo propertyInfo;
			public IManagedType managedType;

            public TransitionedPropertyInfo Copy()
            {
                TransitionedPropertyInfo info = new TransitionedPropertyInfo();
                info.startValue = startValue;
                info.endValue = endValue;
                info.target = target;
                info.propertyInfo = propertyInfo;
                info.managedType = managedType;
                return info;
            }
		}

		// The collection of properties that the current transition is animating...
		private IList<TransitionedPropertyInfo> _listTransitionedProperties = new List<TransitionedPropertyInfo>();

		// Helps us find the time interval from the time the transition starts to each timer tick...
		private Stopwatch _stopwatch = new Stopwatch();

        // Event args used for the event we raise when updating a property...
		private class PropertyUpdateArgs : EventArgs
		{
			public PropertyUpdateArgs(object t, PropertyInfo pi, object v)
			{
				target = t;
				propertyInfo = pi;
				value = v;
			}
			public object target;
			public PropertyInfo propertyInfo;
			public object value;
		}

        // An object used to lock the list of transitioned properties, as it can be 
        // accessed by multiple threads...
        private object _lock = new object();
	}
}
