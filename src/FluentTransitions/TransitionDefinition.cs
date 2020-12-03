using FluentTransitions.Methods;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace FluentTransitions
{
	/// <summary>
	/// The transition definition providing fluent syntax to build and run transitions
	/// </summary>
	public class TransitionDefinition
	{
		private readonly List<TargetPropertyDestination> _targetPropertyDestinations = new List<TargetPropertyDestination>();
		private Action _completionHook;

		/// <summary>
		/// Includes a target object and interpolates its property value to the destination value
		/// </summary>
		/// <param name="target">The target object to include to the transition</param>
		/// <param name="propertyName">The name of the property to animate</param>
		/// <param name="destinationValue">The destination value which should be reached at the end of the transition</param>
		/// <returns></returns>
		public TransitionDefinition With(object target, string propertyName, object destinationValue)
		{
			_targetPropertyDestinations.Add(new TargetPropertyDestination 
			{
				Target = target,
				PropertyName = propertyName,
				DestinationValue = destinationValue
			});

			return this;
		}


		/// <summary>
		/// Defines a hook that gets called as soon as the transition completes
		/// </summary>
		/// <param name="hookDelegate">A delegate which gets called as soon as the transition did complete</param>
		public TransitionDefinition HookOnCompletion(Action hookDelegate)
		{
			_completionHook = hookDelegate;
			return this;
		}

		/// <summary>
		/// Defines a hook that gets called as soon as the transition completes
		/// </summary>
		/// <param name="controlToInvoke">Any control to be used to invoke the hookDelegate to the UI thread</param>
		/// <param name="hookDelegate">A delegate which gets called as soon as the transition did complete</param>
		public TransitionDefinition HookOnCompletionInUiThread(Control controlToInvoke, Action hookDelegate)
		{
			if (hookDelegate is object)
				_completionHook = () => controlToInvoke.BeginInvoke((Action)(() => hookDelegate.Invoke()));
			else
				_completionHook = null;

			return this;
		}

		/// <summary>
		/// Defines a hook that gets called as soon as the transition completes
		/// </summary>
		/// <param name="synchronizationContext">The synchronization context used to invoke the hookDelegate to the UI thread</param>
		/// <param name="hookDelegate">A delegate which gets called as soon as the transition did complete</param>
		public TransitionDefinition HookOnCompletionInUiThread(SynchronizationContext synchronizationContext, Action hookDelegate)
		{
			if (hookDelegate is object)
				_completionHook = () => synchronizationContext.Post(_ => hookDelegate.Invoke(), null);
			else
				_completionHook = null;

			return this;
		}

		/// <summary>
		/// Alters the property values to their destination values from a standing start with accelerating intervals.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public void Accelerate(TimeSpan duration)
		{
			BuildAndRun(new Acceleration(duration));
		}

		/// <summary>
		/// Bounces the property values to their destination values and back to the original ones.
		/// They are accelerated to the destination and then decelerated back as if being dropped with gravity and bouncing back against gravity.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public void Bounce(TimeSpan duration)
		{
			BuildAndRun(new Bounce(duration));
		}

		/// <summary>
		/// Alters the property values with an exponential decay.
		/// This has a damping effect similar to the motion of a needle on an electomagnetically controlled dial.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public void CriticalDamp(TimeSpan duration)
		{
			BuildAndRun(new CriticalDamping(duration));
		}

		/// <summary>
		/// Alters the property values starting from a high speed and decelerating to zero by the end of the transition.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public void Decelerate(TimeSpan duration)
		{
			BuildAndRun(new Deceleration(duration));
		}

		/// <summary>
		/// Alters the property values in an ease-in-ease-out transition.
		/// This accelerates during the first half of the transition, and then decelerates during the second half.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public void EaseInEaseOut(TimeSpan duration)
		{
			BuildAndRun(new EaseInEaseOut(duration));
		}

		/// <summary>
		/// Flashes the property values a specified number of times, ending up by reverting them to their initial values.
		/// </summary>
		/// <param name="numberOfFlashes">The number of flashes to animate</param>
		/// <param name="durationOfEachFlash">The duration of each flash</param>
		public void Flash(int numberOfFlashes, TimeSpan durationOfEachFlash)
		{
			BuildAndRun(new Flash(numberOfFlashes, durationOfEachFlash));
		}

		/// <summary>
		/// Alters the property values in a linear way until they reach their destination values.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public void Linear(TimeSpan duration)
		{
			BuildAndRun(new Linear(duration));
		}

		/// <summary>
		/// Bounces the property values to their destination values and back to the original ones.
		/// They are decelerated to the destination and then acclerated back as if being thrown against gravity and then descending back with gravity.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public void ThrowAndCatch(TimeSpan duration)
		{
			BuildAndRun(new ThrowAndCatch(duration));
		}

		/// <summary>
		/// Allows the creation of user-defined transition methods, specified by a list of individual transition elements.
		/// 
		/// Each of these defines: 
		/// End time, End value, Interpolation method
		/// 
		/// For example, say you want to make a bouncing effect with a decay:
		/// 
		/// EndTime%    EndValue%   Interpolation
		/// --------    ---------   -------------
		/// 50          100         Acceleration 
		/// 75          50          Deceleration
		/// 85          100         Acceleration
		/// 91          75          Deceleration
		/// 95          100         Acceleration
		/// 98          90          Deceleration
		/// 100         100         Acceleration
		/// 
		/// The time values are expressed as a percentage of the overall transition time. This 
		/// means that you can create a user-defined transition-type and then use it for transitions
		/// of different lengths.
		/// 
		/// The values are percentages of the values between the start and end values of the properties
		/// being animated in the transitions. 0% is the start value and 100% is the end value.
		/// 
		/// The interpolation is one of the values from the InterpolationMethod enum.
		/// 
		/// So the example above accelerates to the destination (as if under gravity) by
		/// t=50%, then bounces back up to half the initial height by t=75%, slowing down 
		/// (as if against gravity) before falling down again and bouncing to decreasing 
		/// heights each time.
		/// 
		/// </summary>
		/// <param name="elements">The elements to process during the transition</param>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public void Sequence(IList<TransitionElement> elements, TimeSpan duration)
		{
			BuildAndRun(new Sequence(elements, duration));
		}

		/// <summary>
		/// Interpolates values with EasingFunctions.ElasticEaseOut to mimic the behavior of a loaded spring.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public void Spring(TimeSpan duration)
		{
			BuildAndRun(new Spring(duration));
		}

		/// <summary>
		/// Allows natural transitions with custom or predefined easing functions.
		/// Easing functions are mathematical functions that are used to interpolate values between two endpoints
		/// usually with non-linear results.
		/// </summary>
		/// <param name="easingFunction">
		/// The function to interpolate values with. See "<see cref="FluentTransitions.Methods.EasingFunctions"/>" for prebuilt easing functions.
		/// Based on Mauro Sampietro's article on CodeProject: https://www.codeproject.com/Articles/827808/Control-Animation-in-Winforms
		/// </param>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public void EaseWithFunction(EasingFunction easingFunction, TimeSpan duration)
		{
			BuildAndRun(new EaseWithFunction(easingFunction, duration));
		}

		/// <summary>
		/// Builds a transition with a given method and runs it immediately
		/// </summary>
		/// <param name="method">The method the transition should be built with</param>
		private void BuildAndRun(IMethod method)
		{
			Build(method).Run();
		}

		/// <summary>
		/// Builds and returns a transition with a given method
		/// </summary>
		/// <param name="method">The method the transition should be built with</param>
		public Transition Build(IMethod method)
		{
			var transition = new Transition(method);

			foreach (var item in _targetPropertyDestinations)
				transition.Add(item.Target, item.PropertyName, item.DestinationValue);

			if (_completionHook is object)
			{
				void SelfRemovingCompletionHandler(object s, EventArgs e)
				{
					transition.TransitionCompleted -= SelfRemovingCompletionHandler;
					_completionHook.Invoke();
				}

				transition.TransitionCompleted += SelfRemovingCompletionHandler;
			}

			return transition;
		}

		internal class TargetPropertyDestination
		{ 
			public object Target { get; set; }

			public string PropertyName { get; set; }

			public object DestinationValue { get; set; }
		}
	}
}
