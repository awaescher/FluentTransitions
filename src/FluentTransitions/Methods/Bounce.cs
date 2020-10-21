using System;
using System.Collections.Generic;

namespace FluentTransitions.Methods
{
	/// <summary>
	/// This transition bounces the property to a destination value and back to the
	/// original value. It is accelerated to the destination and then decelerated back
	/// as if being dropped with gravity and bouncing back against gravity.
	/// </summary>
	public class Bounce : UserDefined
	{
		/// <summary>
		/// Bounces the property values to their destination values and back to the original ones.
		/// They are accelerated to the destination and then decelerated back as if being dropped with gravity and bouncing back against gravity.
		/// </summary>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public Bounce(TimeSpan duration) : this((int)duration.TotalMilliseconds)
		{
		}

		/// <summary>
		/// Bounces the property values to their destination values and back to the original ones.
		/// They are accelerated to the destination and then decelerated back as if being dropped with gravity and bouncing back against gravity.
		/// </summary>
		/// <param name="duration">The duration in milliseconds until the properties should have reached their destination values</param>
		public Bounce(int duration)
		{
			// We create a custom "user-defined" transition to do the work...
			var elements = new List<TransitionElement>
			{
				new TransitionElement(50, 100, InterpolationMethod.Accleration),
				new TransitionElement(100, 0, InterpolationMethod.Deceleration)
			};
			base.Setup(elements, duration);
		}
	}
}
