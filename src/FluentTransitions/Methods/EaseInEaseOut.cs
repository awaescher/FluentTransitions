using System;

namespace FluentTransitions.Methods
{
	/// <summary>
	/// Manages an ease-in-ease-out transition. This accelerates during the first 
	/// half of the transition, and then decelerates during the second half.
	/// </summary>
	public class EaseInEaseOut : IMethod
	{
		private readonly double _duration = 0.0;

		/// <summary>
		/// Alters the property values in an ease-in-ease-out transition.
		/// This accelerates during the first half of the transition, and then decelerates during the second half.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public EaseInEaseOut(TimeSpan duration) : this((int)duration.TotalMilliseconds)
		{
		}

		/// <summary>
		/// Alters the property values in an ease-in-ease-out transition.
		/// This accelerates during the first half of the transition, and then decelerates during the second half.
		/// </summary>
		/// <param name="duration">The duration in milliseconds until the properties should have reached their destination values</param>
		public EaseInEaseOut(int duration)
		{
			if (duration <= 0)
				throw new ArgumentOutOfRangeException(nameof(duration), "Transition time must be greater than zero.");
			
			_duration = duration;
		}

		/// <summary>
		/// Works out the percentage completed given the time passed in.
		/// This uses the formula:
		///   s = ut + 1/2at^2
		/// We accelerate as at the rate needed (a=4) to get to 0.5 at t=0.5, and
		/// then decelerate at the same rate to end up at 1.0 at t=1.0.
		/// </summary>
		public void OnTimer(int time, out double percentage, out bool completed)
		{
			// We find the percentage time elapsed...
			double elapsed = time / _duration;
			percentage = Utility.ConvertLinearToEaseInEaseOut(elapsed);

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
