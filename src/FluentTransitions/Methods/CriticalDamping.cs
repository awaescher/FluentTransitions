using System;

namespace FluentTransitions.Methods
{
	/// <summary>
	/// This transition animates with an exponential decay. This has a damping effect
	/// similar to the motion of a needle on an electomagnetically controlled dial.
	/// </summary>
	public class CriticalDamping : IMethod
	{
		private readonly double _duration = 0.0;

		/// <summary>
		/// Alters the property values with an exponential decay.
		/// This has a damping effect similar to the motion of a needle on an electomagnetically controlled dial.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public CriticalDamping(TimeSpan duration) : this((int)duration.TotalMilliseconds)
		{
		}

		/// <summary>
		/// Alters the property values with an exponential decay.
		/// This has a damping effect similar to the motion of a needle on an electomagnetically controlled dial.
		/// </summary>
		/// <param name="duration">The duration in milliseconds until the properties should have reached their destination values</param>
		public CriticalDamping(int duration)
		{
			if (duration <= 0)
				throw new ArgumentOutOfRangeException("Transition time must be greater than zero.");
			
			_duration = duration;
		}

		/// <summary>
		/// Works out the percentage completed given the time passed in.
		/// </summary>
		public void OnTimer(int time, out double percentage, out bool completed)
		{
			// We find the percentage time elapsed...
			double elapsed = time / _duration;
			percentage = (1.0 - Math.Exp(-1.0 * elapsed * 5)) / 0.993262053;

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
