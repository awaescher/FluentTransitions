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
		public Type GetManagedType()
		{
			return typeof(int);
		}

		/// <summary>
		/// Returns a copy of the int passed in.
		/// </summary>
		public object Copy(object o)
		{
			int value = (int)o;
			return value;
		}

		/// <summary>
		/// Returns the value between the start and end for the percentage passed in.
		/// </summary>
		public object GetIntermediateValue(object start, object end, double dPercentage)
		{
			int iStart = (int)start;
			int iEnd = (int)end;
			return Utility.Interpolate(iStart, iEnd, dPercentage);
		}
	}
}
