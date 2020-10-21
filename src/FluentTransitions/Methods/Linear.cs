using System;

namespace FluentTransitions.Methods
{
	/// <summary>
	/// This class manages a linear transition. The percentage complete for the transition
	/// increases linearly with time.
	/// </summary>
	public class Linear : IMethod
	{
		private readonly double _duration = 0.0;

		/// <summary>
		/// Alters the property values in a linear way until they reach their destination values.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public Linear(TimeSpan duration) : this((int)duration.TotalMilliseconds)
		{
		}

		/// <summary>
		/// Alters the property values in a linear way until they reach their destination values.
		/// </summary>
		/// <param name="duration">The duration in milliseconds until the properties should have reached their destination values</param>
		public Linear(int duration)
		{
			if (duration <= 0)
				throw new ArgumentOutOfRangeException(nameof(duration), "Transition time must be greater than zero.");

			_duration = duration;
		}

		/// <summary>
		/// Works out the percentage completed given the time passed in.
		/// </summary>
		public void OnTimer(int time, out double percentage, out bool completed)
		{
			percentage = (time / _duration);
			if (percentage >= 1.0)
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
