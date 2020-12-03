using System;

namespace FluentTransitions.Methods
{
	/// <summary>
	/// This transition interpolates values with EasingFunctions.ElasticEaseOut to mimic the behavior of a loaded spring.
	/// </summary>
	public class Spring : EaseWithFunction
	{
		/// <summary>
		/// Interpolates values with EasingFunctions.ElasticEaseOut to mimic the behavior of a loaded spring.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public Spring(TimeSpan duration) : this((int)duration.TotalMilliseconds)
		{
		}

		/// <summary>
		/// Interpolates values with EasingFunctions.ElasticEaseOut to mimic the behavior of a loaded spring.
		/// </summary>
		/// <param name="duration">The duration in milliseconds until the properties should have reached their destination values</param>
		public Spring(int duration) : base(EasingFunctions.ElasticEaseOut, duration)
		{
		}
	}
}