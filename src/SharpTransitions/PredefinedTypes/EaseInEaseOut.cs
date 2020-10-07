using System;
using System.Text;

namespace SharpTransitions
{
	/// <summary>
	/// Manages an ease-in-ease-out transition. This accelerates during the first 
	/// half of the transition, and then decelerates during the second half.
	/// </summary>
	public class EaseInEaseOut : ITransitionType
	{
		/// <summary>
		/// Constructor. You pass in the time that the transition 
		/// will take (in milliseconds).
		/// </summary>
		public EaseInEaseOut(int transitionTime)
		{
			if (transitionTime <= 0)
			{
				throw new Exception("Transition time must be greater than zero.");
			}
			_transitionTime = transitionTime;
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
			double elapsed = time / _transitionTime;
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

		private double _transitionTime = 0.0;
	}
}
