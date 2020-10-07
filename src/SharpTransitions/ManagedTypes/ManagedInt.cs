using System;
using System.Text;

namespace SharpTransitions
{
	/// <summary>
	/// Manages transitions for int properties.
	/// </summary>
	internal class ManagedInt : IManagedType
	{
		/// <summary>
		/// Returns the type we are managing.
		/// </summary>
		public Type GetManagedType() => typeof(int);

		/// <summary>
		/// Returns a copy of the int passed in.
		/// </summary>
		public object Copy(object o) => (int)o;

		/// <summary>
		/// Returns the value between the start and end for the percentage passed in.
		/// </summary>
		public object GetIntermediateValue(object start, object end, double percentage)
		{
			return Utility.Interpolate((int)start, (int)end, percentage);
		}
	}
}
