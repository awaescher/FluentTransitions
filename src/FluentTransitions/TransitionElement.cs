namespace FluentTransitions
{
	/// <summary>
	/// An individual part of a transition defining the method to interpolate towards a desitination value and how log this should take.
	/// </summary>
	public class TransitionElement
	{
		/// <summary>
		/// Creates a new transition element
		/// </summary>
		/// <param name="endTime">The percentage of elapsed time, expressed as (for example) 75 for 75%.</param>
		/// <param name="endValue">The value of the animated properties at the EndTime. 
		/// This is the percentage movement of the properties between their start and end values. 
		/// This should be expressed as (for example) 75 for 75%.</param>
		/// <param name="interpolationMethod">The interpolation method to use when moving between the previous value and the current one.</param>
		public TransitionElement(double endTime, double endValue, InterpolationMethod interpolationMethod)
		{
			EndTime = endTime;
			EndValue = endValue;
			InterpolationMethod = interpolationMethod;
		}

		/// <summary>
		/// The percentage of elapsed time, expressed as (for example) 75 for 75%.
		/// </summary>
		public double EndTime { get; set; }

		/// <summary>
		/// The value of the animated properties at the EndTime. This is the percentage 
		/// movement of the properties between their start and end values. This should
		/// be expressed as (for example) 75 for 75%.
		/// </summary>
		public double EndValue { get; set; }

		/// <summary>
		/// The interpolation method to use when moving between the previous value
		/// and the current one.
		/// </summary>
		public InterpolationMethod InterpolationMethod { get; set; }
	}
}
