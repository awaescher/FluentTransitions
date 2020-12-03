using System;

namespace FluentTransitions.Methods
{
	/// <summary>
	/// Allows natural transitions with custom or predefined easing functions.
	/// Easing functions are mathematical functions that are used to interpolate values between two endpoints
	/// usually with non-linear results.
	/// Thanks to Mauro Sampietro for providing the easing functions on https://www.codeproject.com/Articles/827808/Control-Animation-in-Winforms.
	/// </summary>
	public class EaseWithFunction : IMethod
	{
		private readonly double _duration = 0.0;

		/// <summary>
		/// Allows natural transitions with custom or predefined easing functions.
		/// Easing functions are mathematical functions that are used to interpolate values between two endpoints
		/// usually with non-linear results.
		/// </summary>
		/// <param name="easingFunction">
		/// The function to interpolate values with. See "<seealso cref="FluentTransitions.Methods.EasingFunctions"/>" for prebuilt easing functions.
		/// Powererd by Mauro Sampietro (https://www.codeproject.com/Articles/827808/Control-Animation-in-Winforms).
		/// </param>
		/// <param name="duration">The duration until the properties should have reached their destination values</param>
		public EaseWithFunction(EasingFunction easingFunction, TimeSpan duration) : this(easingFunction, (int)duration.TotalMilliseconds)
		{
			EasingFunction = easingFunction ?? throw new ArgumentNullException(nameof(easingFunction));
		}

		/// <summary>
		/// Allows natural transitions with custom or predefined easing functions.
		/// Easing functions are mathematical functions that are used to interpolate values between two endpoints
		/// usually with non-linear results.
		/// </summary>
		/// <param name="easingFunction">
		/// The function to interpolate values with. See "<seealso cref="FluentTransitions.Methods.EasingFunctions"/>" for prebuilt easing functions.
		/// Powererd by Mauro Sampietro (https://www.codeproject.com/Articles/827808/Control-Animation-in-Winforms).
		/// </param>
		/// <param name="duration">The duration in milliseconds until the properties should have reached their destination values</param>
		public EaseWithFunction(EasingFunction easingFunction, int duration)
		{
			if (duration <= 0)
				throw new ArgumentOutOfRangeException(nameof(duration), "Transition time must be greater than zero.");

			EasingFunction = easingFunction ?? throw new ArgumentNullException(nameof(easingFunction));

			_duration = duration;
		}

		/// <summary>
		/// Works out the percentage completed given the time passed in.
		/// </summary>
		public void OnTimer(int time, out double percentage, out bool completed)
		{
			percentage = EasingFunction(time, 0, 100, _duration) / 100;
			completed = time >= _duration;
		}

		/// <summary>
		/// Gets the easing function to interpolate values with
		/// </summary>
		public EasingFunction EasingFunction { get; }
	}
}
