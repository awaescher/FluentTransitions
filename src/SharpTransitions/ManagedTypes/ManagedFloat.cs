using System;
using System.Text;

namespace SharpTransitions
{
    internal class ManagedFloat : IManagedType
    {
        /// <summary>
        /// Returns the type we're managing.
        /// </summary>
        public Type GetManagedType()
        {
            return typeof(float);
        }

        /// <summary>
        /// Returns a copy of the float passed in.
        /// </summary>
        public object Copy(object o)
        {
            float f = (float)o;
            return f;
        }

        /// <summary>
        /// Returns the interpolated value for the percentage passed in.
        /// </summary>
        public object GetIntermediateValue(object start, object end, double dPercentage)
        {
            float fStart = (float)start;
            float fEnd = (float)end;
            return Utility.Interpolate(fStart, fEnd, dPercentage);
        }
    }
}
