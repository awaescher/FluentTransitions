using System;
using System.Text;

namespace SharpTransitions
{
    /// <summary>
    /// This transition animates with an exponential decay. This has a damping effect
    /// similar to the motion of a needle on an electomagnetically controlled dial.
    /// </summary>
	public class CriticalDamping : ITransitionType
	{
		/// <summary>
		/// Constructor. You pass in the time that the transition 
		/// will take (in milliseconds).
		/// </summary>
		public CriticalDamping(int transitionTime)
		{
			if (transitionTime <= 0)
			{
				throw new Exception("Transition time must be greater than zero.");
			}
			_transitionTime = transitionTime;
		}

		/// <summary>
		/// </summary>
		public void OnTimer(int time, out double percentage, out bool completed)
		{
			// We find the percentage time elapsed...
			double elapsed = time / _transitionTime;
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

		private double _transitionTime = 0.0;
	}
}
