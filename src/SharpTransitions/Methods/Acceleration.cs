using System;

namespace SharpTransitions.Methods
{
	/// <summary>
	/// Manages transitions under constant acceleration from a standing start.
	/// </summary>
	public class Acceleration : IMethod
	{
		/// <summary>
		/// Constructor. You pass in the time that the transition 
		/// will take (in milliseconds).
		/// </summary>
		public Acceleration(int transitionTime)
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
		/// The initial velocity is 0, and the acceleration to get to 1.0
		/// at t=1.0 is 2, so the formula just becomes:
		///   s = t^2
		/// </summary>
		public void OnTimer(int time, out double percentage, out bool completed)
		{
			// We find the percentage time elapsed...
			double elapsed = time / _transitionTime;
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

		private readonly double _transitionTime = 0.0;
	}
}
