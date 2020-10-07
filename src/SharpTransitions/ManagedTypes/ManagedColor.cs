using System;
using System.Drawing;

namespace SharpTransitions
{
	/// <summary>
	/// Class that manages transitions for Color properties. For these we
	/// need to transition the R, G, B and A sub-properties independently.
	/// </summary>
	internal class ManagedColor : IManagedType
	{
		/// <summary>
		/// Returns the type we are managing.
		/// </summary>
		public Type GetManagedType()
		{
			return typeof(Color);
		}

		/// <summary>
		/// Returns a copy of the color object passed in.
		/// </summary>
		public object Copy(object o)
		{
			Color c = (Color)o;
			Color result = Color.FromArgb(c.ToArgb());
			return result;
		}

		/// <summary>
		/// Creates an intermediate value for the colors depending on the percentage passed in.
		/// </summary>
		public object GetIntermediateValue(object start, object end, double dPercentage)
		{
			Color startColor = (Color)start;
			Color endColor = (Color)end;

			// We interpolate the R, G, B and A components separately...
			int iStart_R = startColor.R;
			int iStart_G = startColor.G;
			int iStart_B = startColor.B;
			int iStart_A = startColor.A;

			int iEnd_R = endColor.R;
			int iEnd_G = endColor.G;
			int iEnd_B = endColor.B;
			int iEnd_A = endColor.A;

			int new_R = Utility.Interpolate(iStart_R, iEnd_R, dPercentage);
			int new_G = Utility.Interpolate(iStart_G, iEnd_G, dPercentage);
			int new_B = Utility.Interpolate(iStart_B, iEnd_B, dPercentage);
			int new_A = Utility.Interpolate(iStart_A, iEnd_A, dPercentage);

			return Color.FromArgb(new_A, new_R, new_G, new_B);
		}
	}
}
