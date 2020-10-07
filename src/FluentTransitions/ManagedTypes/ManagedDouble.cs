using System;

namespace FluentTransitions.ManagedTypes
{
	/// <summary>
	/// Manages transitions for double properties.
	/// </summary>
	internal class ManagedDouble : IManagedType
	{
		/// <summary>
		///  Returns the type managed by this class.
		/// </summary>
		public Type GetManagedType() => typeof(double);

		/// <summary>
		/// Returns a copy of the double passed in.
		/// </summary>
		public object Copy(object o) => (double)o;

		/// <summary>
		/// Returns the value between start and end for the percentage passed in.
		/// </summary>
		public object GetIntermediateValue(object start, object end, double percentage)
		{
			return Utility.Interpolate((double)start, (double)end, percentage);
		}
	}
}
