using System;

namespace FluentTransitions.Methods
{
	/// <summary>
	/// Manages transitions under constant acceleration from a standing start.
	/// </summary>
	public class Acceleration : IMethod
	{
		private readonly double _duration = 0.0;

		/// <summary>
		/// Alters the property values to their destination values from a standing start with accelerating intervals.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public Acceleration(TimeSpan duration) : this((int)duration.TotalMilliseconds)
		{
		}

		/// <summary>
		/// Alters the property values to their destination values from a standing start with accelerating intervals.
		/// </summary>
		/// <param name="duration">The duration in milliseconds until the properties should have reached their destination values</param>
		public Acceleration(int duration)
		{
			if (duration <= 0)
				throw new ArgumentOutOfRangeException("Transition time must be greater than zero.");

			_duration = duration;
		}

		/// <summary>
		/// Works out the percentage completed given the time passed in.
		/// This uses the formula:
		///   s = ut + 1/2at^2
		/// The initial velocity is 0, and the acceleration to get to 1.0
		/// at t=1.0 is 2, so the formula just becomes:
		///   s = t^2
		/// </summary>
		public void OnTimer(int time, out double percentage, out bool completed)
		{
			// We find the percentage time elapsed...
			double elapsed = time / _duration;
			percentage = elapsed * elapsed;
			if (elapsed >= 1.0)
			{
				percentage = 1.0;
				completed = true;
			}
			else
			{
				completed = false;
			}
		}
	}
}
