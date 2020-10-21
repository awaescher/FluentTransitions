using System;
using System.Collections.Generic;

namespace FluentTransitions.Methods
{
	/// <summary>
	/// This transition bounces the property to a destination value and back to the
	/// original value. It is decelerated to the destination and then acclerated back
	/// as if being thrown against gravity and then descending back with gravity.
	/// </summary>
	public class ThrowAndCatch : UserDefined
	{
		/// <summary>
		/// Bounces the property values to their destination values and back to the original ones.
		/// They are decelerated to the destination and then acclerated back as if being thrown against gravity and then descending back with gravity.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public ThrowAndCatch(TimeSpan duration) : this((int)duration.TotalMilliseconds)
		{
		}

		/// <summary>
		/// Bounces the property values to their destination values and back to the original ones.
		/// They are decelerated to the destination and then acclerated back as if being thrown against gravity and then descending back with gravity.
		/// </summary>
		/// <param name="duration">The duration in milliseconds until the properties should have reached their destination values</param>
		public ThrowAndCatch(int duration)
		{
			// We create a custom "user-defined" transition to do the work...
			var elements = new List<TransitionElement>
			{
				new TransitionElement(50, 100, InterpolationMethod.Deceleration),
				new TransitionElement(100, 0, InterpolationMethod.Accleration)
			};
			base.Setup(elements, duration);
		}
	}
}
