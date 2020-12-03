using System;

namespace FluentTransitions.Methods
{
	/// <summary>
	/// This transition interpolates values with EasingFunctions.BackEaseOut to mimic the behavior of a rubber band stopping a movement and pulling it back.
	/// </summary>
	public class Rubberband : EaseWithFunction
	{
		/// <summary>
		/// Interpolates values with EasingFunctions.BackEaseOut to mimic the behavior of a rubber band stopping a movement and pulling it back.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public Rubberband(TimeSpan duration) : this((int)duration.TotalMilliseconds)
		{
		}

		/// <summary>
		/// Interpolates values with EasingFunctions.BackEaseOut to mimic the behavior of a rubber band stopping a movement and pulling it back.
		/// </summary>
		/// <param name="duration">The duration in milliseconds until the properties should have reached their destination values</param>
		public Rubberband(int duration) : base(EasingFunctions.BackEaseOut, duration)
		{
		}
	}
}