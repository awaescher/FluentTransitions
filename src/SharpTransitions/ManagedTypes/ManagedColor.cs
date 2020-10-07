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
		public Type GetManagedType() => typeof(Color);

		/// <summary>
		/// Returns a copy of the color object passed in.
		/// </summary>
		public object Copy(object o) => Color.FromArgb(((Color)o).ToArgb());

		/// <summary>
		/// Creates an intermediate value for the colors depending on the percentage passed in.
		/// </summary>
		public object GetIntermediateValue(object start, object end, double percentage)
		{
			Color startColor = (Color)start;
			Color endColor = (Color)end;

			// We interpolate the R, G, B and A components separately...
			int start_R = startColor.R;
			int start_G = startColor.G;
			int start_B = startColor.B;
			int start_A = startColor.A;

			int end_R = endColor.R;
			int end_G = endColor.G;
			int end_B = endColor.B;
			int end_A = endColor.A;

			int new_R = Utility.Interpolate(start_R, end_R, percentage);
			int new_G = Utility.Interpolate(start_G, end_G, percentage);
			int new_B = Utility.Interpolate(start_B, end_B, percentage);
			int new_A = Utility.Interpolate(start_A, end_A, percentage);

			return Color.FromArgb(new_A, new_R, new_G, new_B);
		}
	}
}
