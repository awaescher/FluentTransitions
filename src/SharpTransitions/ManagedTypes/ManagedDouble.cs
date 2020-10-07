using System;
using System.Text;

namespace SharpTransitions
{
	/// <summary>
	/// Manages transitions for double properties.
	/// </summary>
	internal class ManagedDouble
		: IManagedType
	{
		/// <summary>
		///  Returns the type managed by this class.
		/// </summary>
		public Type GetManagedType()
		{
			return typeof(double);
		}

		/// <summary>
		/// Returns a copy of the double passed in.
		/// </summary>
		public object Copy(object o)
		{
			double d = (double)o;
			return d;
		}

		/// <summary>
		/// Returns the value between start and end for the percentage passed in.
		/// </summary>
		public object GetIntermediateValue(object start, object end, double dPercentage)
		{
			double dStart = (double)start;
			double dEnd = (double)end;
			return Utility.Interpolate(dStart, dEnd, dPercentage);
		}
	}
}
