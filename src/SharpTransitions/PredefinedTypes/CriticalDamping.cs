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
		public CriticalDamping(int iTransitionTime)
		{
			if (iTransitionTime <= 0)
			{
				throw new Exception("Transition time must be greater than zero.");
			}
			_transitionTime = iTransitionTime;
		}

		/// <summary>
		/// </summary>
		public void OnTimer(int iTime, out double dPercentage, out bool bCompleted)
		{
			// We find the percentage time elapsed...
			double dElapsed = iTime / _transitionTime;
			dPercentage = (1.0 - Math.Exp(-1.0 * dElapsed * 5)) / 0.993262053;

			if (dElapsed >= 1.0)
			{
				dPercentage = 1.0;
				bCompleted = true;
			}
			else
			{
				bCompleted = false;
			}
		}

		private double _transitionTime = 0.0;
	}
}
