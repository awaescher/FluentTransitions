using System;
using System.ComponentModel;

namespace SharpTransitions
{
	/// <summary>
	/// A class holding static utility functions.
	/// </summary>
	internal class Utility
	{
		/// <summary>
		/// Returns the value of the property passed in.
		/// </summary>
		public static object GetValue(object target, string propertyName)
		{
			var targetType = target.GetType();
			var propertyInfo = targetType.GetProperty(propertyName);
			if (propertyInfo == null)
				throw new InvalidOperationException($"Object: {target} does not have the property: {propertyName}");

			return propertyInfo.GetValue(target, null);
		}

		/// <summary>
		/// Sets the value of the property passed in.
		/// </summary>
		public static void SetValue(object target, string propertyName, object value)
		{
			var targetType = target.GetType();
			var propertyInfo = targetType.GetProperty(propertyName);
			if (propertyInfo == null)
				throw new InvalidOperationException($"Object: {target} does not have the property: {propertyName}");

			propertyInfo.SetValue(target, value, null);
		}

		/// <summary>
		/// Returns a value between d1 and d2 for the percentage passed in.
		/// </summary>
		public static double Interpolate(double value1, double value2, double percentage)
		{
			double difference = value2 - value1;
			double distance = difference * percentage;
			double result = value1 + distance;

			return result;
		}

		/// <summary>
		/// Returns a value betweeen i1 and i2 for the percentage passed in.
		/// </summary>
		public static int Interpolate(int value1, int value2, double percentage)
		{
			return (int)Interpolate((double)value1, (double)value2, percentage);
		}

		/// <summary>
		/// Returns a value betweeen f1 and f2 for the percentage passed in.
		/// </summary>
		public static float Interpolate(float value1, float value2, double percentage)
		{
			return (float)Interpolate((double)value1, (double)value2, percentage);
		}

		/// <summary>
		/// Converts a fraction representing linear time to a fraction representing
		/// the distance traveled under an ease-in-ease-out transition.
		/// </summary>
		public static double ConvertLinearToEaseInEaseOut(double elapsed)
		{
			// The distance traveled is made up of two parts: the initial acceleration,
			// and then the subsequent deceleration...
			double firstHalfTime = (elapsed > 0.5) ? 0.5 : elapsed;
			double secondHalfTime = (elapsed > 0.5) ? elapsed - 0.5 : 0.0;
			double result = 2 * firstHalfTime * firstHalfTime + 2 * secondHalfTime * (1.0 - secondHalfTime);
			return result;
		}

		/// <summary>
		/// Converts a fraction representing linear time to a fraction representing
		/// the distance traveled under a constant acceleration transition.
		/// </summary>
		public static double ConvertLinearToAcceleration(double elapsed)
		{
			return elapsed * elapsed;
		}

		/// <summary>
		/// Converts a fraction representing linear time to a fraction representing
		/// the distance traveled under a constant deceleration transition.
		/// </summary>
		public static double ConvertLinearToDeceleration(double elapsed)
		{
			return elapsed * (2.0 - elapsed);
		}

		/// <summary>
		/// Fires the event passed in in a thread-safe way. 
		/// </summary><remarks>
		/// This method loops through the targets of the event and invokes each in turn. If the
		/// target supports ISychronizeInvoke (such as forms or controls) and is set to run 
		/// on a different thread, then we call BeginInvoke to marshal the event to the target
		/// thread. If the target does not support this interface (such as most non-form classes)
		/// or we are on the same thread as the target, then the event is fired on the same
		/// thread as this is called from.
		/// </remarks>
		public static void RaiseEvent<T>(EventHandler<T> theEvent, object sender, T args) where T : System.EventArgs
		{
			if (theEvent == null)
				return;

			// We loop through each of the delegate handlers for this event. For each of 
			// them we need to decide whether to invoke it on the current thread or to
			// make a cross-thread invocation...
			foreach (EventHandler<T> handler in theEvent.GetInvocationList())
			{
				try
				{
					if (!(handler.Target is ISynchronizeInvoke target) || !target.InvokeRequired)
					{
						// Either the target is not a form or control, or we are already
						// on the right thread for it. Either way we can just fire the
						// event as normal...
						handler(sender, args);
					}
					else
					{
						// The target is most likely a form or control that needs the
						// handler to be invoked on its own thread...
						target.BeginInvoke(handler, new object[] { sender, args });
					}
				}
				catch (Exception)
				{
					// The event handler may have been detached while processing the events.
					// We just ignore this and invoke the remaining handlers.
				}
			}
		}
	}
}