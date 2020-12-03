/*
 * 
 *	This class was originally taken from Mauro Sampietro's article on "Control Animation in Winforms"
 *	on CodeProject: https://www.codeproject.com/Articles/827808/Control-Animation-in-Winforms
 * 
 * 
*/

using System;

namespace FluentTransitions.Methods
{
	/// <summary>
	/// Defines the signature of an easing function. Use <see cref="EasingFunctions"/> for prebuilt easing functions matching this signature.
	/// </summary>
	/// <param name="currentTime">The current time to interpolate values with.</param>
	/// <param name="minValue">The starting value for the interpolation.</param>
	/// <param name="maxValue">The end value for the interpolation.</param>
	/// <param name="duration">The total duration of the interpolation.</param>
	public delegate double EasingFunction(double currentTime, double minValue, double maxValue, double duration);

	/// <summary>
	/// Defines a set of predefined easing functions to choose from when using <see cref="EaseWithFunction"/>.
	/// Thanks to Mauro Sampietro who wrote about those on CodeProject: https://www.codeproject.com/Articles/827808/Control-Animation-in-Winforms
	/// </summary>
	public static class EasingFunctions
	{
		#region Linear

		/// <summary>
		/// Easing equation function for a simple linear tweening, with no easing.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double Linear(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue * currentTime / duration + minValue;
		}

		#endregion

		#region Expo

		/// <summary>
		/// Easing equation function for an exponential (2^currentTime) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double ExpoEaseOut(double currentTime, double minValue, double maxValue, double duration)
		{
			return (currentTime == duration) ? minValue + maxValue : maxValue * (-Math.Pow(2, -10 * currentTime / duration) + 1) + minValue;
		}

		/// <summary>
		/// Easing equation function for an exponential (2^currentTime) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double ExpoEaseIn(double currentTime, double minValue, double maxValue, double duration)
		{
			return (currentTime == 0) ? minValue : maxValue * Math.Pow(2, 10 * (currentTime / duration - 1)) + minValue;
		}

		/// <summary>
		/// Easing equation function for an exponential (2^currentTime) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double ExpoEaseInOut(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime == 0)
				return minValue;

			if (currentTime == duration)
				return minValue + maxValue;

			if ((currentTime /= duration / 2) < 1)
				return maxValue / 2 * Math.Pow(2, 10 * (currentTime - 1)) + minValue;

			return maxValue / 2 * (-Math.Pow(2, -10 * --currentTime) + 2) + minValue;
		}

		/// <summary>
		/// Easing equation function for an exponential (2^currentTime) easing out/in: 
		/// deceleration until halfway, then acceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double ExpoEaseOutIn(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime < duration / 2)
				return ExpoEaseOut(currentTime * 2, minValue, maxValue / 2, duration);

			return ExpoEaseIn((currentTime * 2) - duration, minValue + maxValue / 2, maxValue / 2, duration);
		}

		#endregion

		#region Circular

		/// <summary>
		/// Easing equation function for a circular (sqrt(1-currentTime^2)) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double CircEaseOut(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue * Math.Sqrt(1 - (currentTime = currentTime / duration - 1) * currentTime) + minValue;
		}

		/// <summary>
		/// Easing equation function for a circular (sqrt(1-currentTime^2)) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double CircEaseIn(double currentTime, double minValue, double maxValue, double duration)
		{
			var sqrt = Math.Sqrt(1 - (currentTime /= duration) * currentTime);

			if (Double.IsNaN(sqrt))
				sqrt = 0;

			return -maxValue * (sqrt - 1) + minValue;
		}

		/// <summary>
		/// Easing equation function for a circular (sqrt(1-currentTime^2)) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double CircEaseInOut(double currentTime, double minValue, double maxValue, double duration)
		{
			if ((currentTime /= duration / 2) < 1)
				return -maxValue / 2 * (Math.Sqrt(1 - currentTime * currentTime) - 1) + minValue;

			return maxValue / 2 * (Math.Sqrt(1 - (currentTime -= 2) * currentTime) + 1) + minValue;
		}

		/// <summary>
		/// Easing equation function for a circular (sqrt(1-currentTime^2)) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double CircEaseOutIn(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime < duration / 2)
				return CircEaseOut(currentTime * 2, minValue, maxValue / 2, duration);

			return CircEaseIn((currentTime * 2) - duration, minValue + maxValue / 2, maxValue / 2, duration);
		}

		#endregion

		#region Quad

		/// <summary>
		/// Easing equation function for a quadratic (currentTime^2) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuadEaseOut(double currentTime, double minValue, double maxValue, double duration)
		{
			return -maxValue * (currentTime /= duration) * (currentTime - 2) + minValue;
		}

		/// <summary>
		/// Easing equation function for a quadratic (currentTime^2) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuadEaseIn(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue * (currentTime /= duration) * currentTime + minValue;
		}

		/// <summary>
		/// Easing equation function for a quadratic (currentTime^2) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuadEaseInOut(double currentTime, double minValue, double maxValue, double duration)
		{
			if ((currentTime /= duration / 2) < 1)
				return maxValue / 2 * currentTime * currentTime + minValue;

			return -maxValue / 2 * ((--currentTime) * (currentTime - 2) - 1) + minValue;
		}

		/// <summary>
		/// Easing equation function for a quadratic (currentTime^2) easing out/in: 
		/// deceleration until halfway, then acceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuadEaseOutIn(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime < duration / 2)
				return QuadEaseOut(currentTime * 2, minValue, maxValue / 2, duration);

			return QuadEaseIn((currentTime * 2) - duration, minValue + maxValue / 2, maxValue / 2, duration);
		}

		#endregion

		#region Sine

		/// <summary>
		/// Easing equation function for a sinusoidal (sin(currentTime)) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double SineEaseOut(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue * Math.Sin(currentTime / duration * (Math.PI / 2)) + minValue;
		}

		/// <summary>
		/// Easing equation function for a sinusoidal (sin(currentTime)) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double SineEaseIn(double currentTime, double minValue, double maxValue, double duration)
		{
			return -maxValue * Math.Cos(currentTime / duration * (Math.PI / 2)) + maxValue + minValue;
		}

		/// <summary>
		/// Easing equation function for a sinusoidal (sin(currentTime)) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double SineEaseInOut(double currentTime, double minValue, double maxValue, double duration)
		{
			if ((currentTime /= duration / 2) < 1)
				return maxValue / 2 * (Math.Sin(Math.PI * currentTime / 2)) + minValue;

			return -maxValue / 2 * (Math.Cos(Math.PI * --currentTime / 2) - 2) + minValue;
		}

		/// <summary>
		/// Easing equation function for a sinusoidal (sin(currentTime)) easing in/out: 
		/// deceleration until halfway, then acceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double SineEaseOutIn(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime < duration / 2)
				return SineEaseOut(currentTime * 2, minValue, maxValue / 2, duration);

			return SineEaseIn((currentTime * 2) - duration, minValue + maxValue / 2, maxValue / 2, duration);
		}

		#endregion

		#region Cubic

		/// <summary>
		/// Easing equation function for a cubic (currentTime^3) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double CubicEaseOut(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue * ((currentTime = currentTime / duration - 1) * currentTime * currentTime + 1) + minValue;
		}

		/// <summary>
		/// Easing equation function for a cubic (currentTime^3) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double CubicEaseIn(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue * (currentTime /= duration) * currentTime * currentTime + minValue;
		}

		/// <summary>
		/// Easing equation function for a cubic (currentTime^3) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double CubicEaseInOut(double currentTime, double minValue, double maxValue, double duration)
		{
			if ((currentTime /= duration / 2) < 1)
				return maxValue / 2 * currentTime * currentTime * currentTime + minValue;

			return maxValue / 2 * ((currentTime -= 2) * currentTime * currentTime + 2) + minValue;
		}

		/// <summary>
		/// Easing equation function for a cubic (currentTime^3) easing out/in: 
		/// deceleration until halfway, then acceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double CubicEaseOutIn(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime < duration / 2)
				return CubicEaseOut(currentTime * 2, minValue, maxValue / 2, duration);

			return CubicEaseIn((currentTime * 2) - duration, minValue + maxValue / 2, maxValue / 2, duration);
		}

		#endregion

		#region Quartic

		/// <summary>
		/// Easing equation function for a quartic (currentTime^4) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuartEaseOut(double currentTime, double minValue, double maxValue, double duration)
		{
			return -maxValue * ((currentTime = currentTime / duration - 1) * currentTime * currentTime * currentTime - 1) + minValue;
		}

		/// <summary>
		/// Easing equation function for a quartic (currentTime^4) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuartEaseIn(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue * (currentTime /= duration) * currentTime * currentTime * currentTime + minValue;
		}

		/// <summary>
		/// Easing equation function for a quartic (currentTime^4) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuartEaseInOut(double currentTime, double minValue, double maxValue, double duration)
		{
			if ((currentTime /= duration / 2) < 1)
				return maxValue / 2 * currentTime * currentTime * currentTime * currentTime + minValue;

			return -maxValue / 2 * ((currentTime -= 2) * currentTime * currentTime * currentTime - 2) + minValue;
		}

		/// <summary>
		/// Easing equation function for a quartic (currentTime^4) easing out/in: 
		/// deceleration until halfway, then acceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuartEaseOutIn(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime < duration / 2)
				return QuartEaseOut(currentTime * 2, minValue, maxValue / 2, duration);

			return QuartEaseIn((currentTime * 2) - duration, minValue + maxValue / 2, maxValue / 2, duration);
		}

		#endregion

		#region Quintic

		/// <summary>
		/// Easing equation function for a quintic (currentTime^5) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuintEaseOut(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue * ((currentTime = currentTime / duration - 1) * currentTime * currentTime * currentTime * currentTime + 1) + minValue;
		}

		/// <summary>
		/// Easing equation function for a quintic (currentTime^5) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuintEaseIn(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue * (currentTime /= duration) * currentTime * currentTime * currentTime * currentTime + minValue;
		}

		/// <summary>
		/// Easing equation function for a quintic (currentTime^5) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuintEaseInOut(double currentTime, double minValue, double maxValue, double duration)
		{
			if ((currentTime /= duration / 2) < 1)
				return maxValue / 2 * currentTime * currentTime * currentTime * currentTime * currentTime + minValue;
			return maxValue / 2 * ((currentTime -= 2) * currentTime * currentTime * currentTime * currentTime + 2) + minValue;
		}

		/// <summary>
		/// Easing equation function for a quintic (currentTime^5) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double QuintEaseOutIn(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime < duration / 2)
				return QuintEaseOut(currentTime * 2, minValue, maxValue / 2, duration);
			return QuintEaseIn((currentTime * 2) - duration, minValue + maxValue / 2, maxValue / 2, duration);
		}

		#endregion

		#region Elastic

		/// <summary>
		/// Easing equation function for an elastic (exponentially decaying sine wave) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double ElasticEaseOut(double currentTime, double minValue, double maxValue, double duration)
		{
			if ((currentTime /= duration) == 1)
				return minValue + maxValue;

			double p = duration * .3;
			double s = p / 4;

			return (maxValue * Math.Pow(2, -10 * currentTime) * Math.Sin((currentTime * duration - s) * (2 * Math.PI) / p) + maxValue + minValue);
		}

		/// <summary>
		/// Easing equation function for an elastic (exponentially decaying sine wave) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double ElasticEaseIn(double currentTime, double minValue, double maxValue, double duration)
		{
			if ((currentTime /= duration) == 1)
				return minValue + maxValue;

			double p = duration * .3;
			double s = p / 4;

			return -(maxValue * Math.Pow(2, 10 * (currentTime -= 1)) * Math.Sin((currentTime * duration - s) * (2 * Math.PI) / p)) + minValue;
		}

		/// <summary>
		/// Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double ElasticEaseInOut(double currentTime, double minValue, double maxValue, double duration)
		{
			if ((currentTime /= duration / 2) == 2)
				return minValue + maxValue;

			double p = duration * (.3 * 1.5);
			double s = p / 4;

			if (currentTime < 1)
				return -.5 * (maxValue * Math.Pow(2, 10 * (currentTime -= 1)) * Math.Sin((currentTime * duration - s) * (2 * Math.PI) / p)) + minValue;
			return maxValue * Math.Pow(2, -10 * (currentTime -= 1)) * Math.Sin((currentTime * duration - s) * (2 * Math.PI) / p) * .5 + maxValue + minValue;
		}

		/// <summary>
		/// Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: 
		/// deceleration until halfway, then acceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double ElasticEaseOutIn(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime < duration / 2)
				return ElasticEaseOut(currentTime * 2, minValue, maxValue / 2, duration);
			return ElasticEaseIn((currentTime * 2) - duration, minValue + maxValue / 2, maxValue / 2, duration);
		}

		#endregion

		#region Bounce

		/// <summary>
		/// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double BounceEaseOut(double currentTime, double minValue, double maxValue, double duration)
		{
			if ((currentTime /= duration) < (1 / 2.75))
				return maxValue * (7.5625 * currentTime * currentTime) + minValue;

			if (currentTime < (2 / 2.75))
				return maxValue * (7.5625 * (currentTime -= (1.5 / 2.75)) * currentTime + .75) + minValue;

			if (currentTime < (2.5 / 2.75))
				return maxValue * (7.5625 * (currentTime -= (2.25 / 2.75)) * currentTime + .9375) + minValue;

			return maxValue * (7.5625 * (currentTime -= (2.625 / 2.75)) * currentTime + .984375) + minValue;
		}

		/// <summary>
		/// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double BounceEaseIn(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue - BounceEaseOut(duration - currentTime, 0, maxValue, duration) + minValue;
		}

		/// <summary>
		/// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double BounceEaseInOut(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime < duration / 2)
				return BounceEaseIn(currentTime * 2, 0, maxValue, duration) * .5 + minValue;

			return BounceEaseOut(currentTime * 2 - duration, 0, maxValue, duration) * .5 + maxValue * .5 + minValue;
		}

		/// <summary>
		/// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: 
		/// deceleration until halfway, then acceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double BounceEaseOutIn(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime < duration / 2)
				return BounceEaseOut(currentTime * 2, minValue, maxValue / 2, duration);

			return BounceEaseIn((currentTime * 2) - duration, minValue + maxValue / 2, maxValue / 2, duration);
		}

		#endregion

		#region Back

		/// <summary>
		/// Easing equation function for a back (overshooting cubic easing: (s+1)*currentTime^3 - s*currentTime^2) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double BackEaseOut(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue * ((currentTime = currentTime / duration - 1) * currentTime * ((1.70158 + 1) * currentTime + 1.70158) + 1) + minValue;
		}

		/// <summary>
		/// Easing equation function for a back (overshooting cubic easing: (s+1)*currentTime^3 - s*currentTime^2) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double BackEaseIn(double currentTime, double minValue, double maxValue, double duration)
		{
			return maxValue * (currentTime /= duration) * currentTime * ((1.70158 + 1) * currentTime - 1.70158) + minValue;
		}

		/// <summary>
		/// Easing equation function for a back (overshooting cubic easing: (s+1)*currentTime^3 - s*currentTime^2) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double BackEaseInOut(double currentTime, double minValue, double maxValue, double duration)
		{
			double s = 1.70158;
			if ((currentTime /= duration / 2) < 1)
				return maxValue / 2 * (currentTime * currentTime * (((s *= (1.525)) + 1) * currentTime - s)) + minValue;
			return maxValue / 2 * ((currentTime -= 2) * currentTime * (((s *= (1.525)) + 1) * currentTime + s) + 2) + minValue;
		}

		/// <summary>
		/// Easing equation function for a back (overshooting cubic easing: (s+1)*currentTime^3 - s*currentTime^2) easing out/in: 
		/// deceleration until halfway, then acceleration.
		/// </summary>
		/// <param name="currentTime">The current time to interpolate values with.</param>
		/// <param name="minValue">The starting value for the interpolation.</param>
		/// <param name="maxValue">The end value for the interpolation.</param>
		/// <param name="duration">The total duration of the interpolation.</param>
		public static double BackEaseOutIn(double currentTime, double minValue, double maxValue, double duration)
		{
			if (currentTime < duration / 2)
				return BackEaseOut(currentTime * 2, minValue, maxValue / 2, duration);
			return BackEaseIn((currentTime * 2) - duration, minValue + maxValue / 2, maxValue / 2, duration);
		}

		#endregion
	}
}