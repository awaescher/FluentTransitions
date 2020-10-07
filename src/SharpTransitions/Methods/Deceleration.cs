using System;

namespace SharpTransitions.Methods
{
	/// <summary>
	/// Manages a transition starting from a high speed and decelerating to zero by
	/// the end of the transition.
	/// </summary>
	public class Deceleration : IMethod
	{
		private readonly double _transitionTime = 0.0;

		/// <summary>
		/// Constructor. You pass in the time that the transition 
		/// will take (in milliseconds).
		/// </summary>
		public Deceleration(int transitionTime)
		{
			if (transitionTime <= 0)
				throw new Exception("Transition time must be greater than zero.");
			
			_transitionTime = transitionTime;
		}

		/// <summary>
		/// Works out the percentage completed given the time passed in.
		/// This uses the formula:
		///   s = ut + 1/2at^2
		/// The initial velocity is 2, and the acceleration to get to 1.0
		/// at t=1.0 is -2, so the formula becomes:
		///   s = t(2-t)
		/// </summary>
		public void OnTimer(int time, out double percentage, out bool completed)
		{
			// We find the percentage time elapsed...
			double elapsed = time / _transitionTime;
			percentage = elapsed * (2.0 - elapsed);
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
