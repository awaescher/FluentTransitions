namespace FluentTransitions
{
	/// <summary>
	/// Interpolation methods to 
	/// </summary>
	public enum InterpolationMethod
	{
		/// <summary>
		/// Alters values in a linear way until they reach their destination values.
		/// </summary>
		Linear,

		/// <summary>
		/// Alters values to their destination values from a standing start with accelerating intervals.
		/// </summary>
		Accleration,

		/// <summary>
		/// Alters values starting from a high speed and decelerating to zero by the end of the transition.
		/// </summary>
		Deceleration,

		/// <summary>
		/// Alters values in an ease-in-ease-out transition.
		/// This accelerates during the first half of the transition, and then decelerates during the second half.
		/// </summary>
		EaseInEaseOut
	}
}
