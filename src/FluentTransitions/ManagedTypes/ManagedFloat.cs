using System;

namespace FluentTransitions.ManagedTypes
{
	internal class ManagedFloat : IManagedType
	{
		/// <summary>
		/// Returns the type we're managing.
		/// </summary>
		public Type GetManagedType() => typeof(float);

		/// <summary>
		/// Returns a copy of the float passed in.
		/// </summary>
		public object Copy(object o) => (float)o;

		/// <summary>
		/// Returns the interpolated value for the percentage passed in.
		/// </summary>
		public object GetIntermediateValue(object start, object end, double percentage)
		{
			return Utility.Interpolate((float)start, (float)end, percentage);
		}
	}
}
