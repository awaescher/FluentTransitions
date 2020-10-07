using System;
using System.Text;

namespace SharpTransitions
{
    /// <summary>
    /// Manages transitions for strings. This doesn't make as much sense as transitions
    /// on other types, but I like the way it looks!
    /// </summary>
    internal class ManagedString : IManagedType
    {
        /// <summary>
        /// Returns the type we're managing.
        /// </summary>
        public Type GetManagedType() => typeof(string);

        /// <summary>
        /// Returns a copy of the string passed in.
        /// </summary>
        public object Copy(object o) => new string(((string)o).ToCharArray());

        /// <summary>
        /// Returns an "interpolated" string.
        /// </summary>
        public object GetIntermediateValue(object start, object end, double percentage)
        {
            string startString = (string)start;
            string endString = (string)end;

            // We find the length of the interpolated string...
            int startLength = startString.Length;
            int endLength = endString.Length;
            int length = Utility.Interpolate(startLength, endLength, percentage);
            char[] result = new char[length];

            // Now we assign the letters of the results by interpolating the
            // letters from the start and end strings...
            for (int i = 0; i < length; ++i)
            {
                // We get the start and end chars at this position...
                char startChar = 'a';
                if(i < startLength)
                {
                    startChar = startString[i];
                }
                char cEnd = 'a';
                if(i < endLength)
                {
                    cEnd = endString[i];
                }

                // We interpolate them...
				char interpolatedChar;
				if (cEnd == ' ')
				{
					// If the end character is a space we just show a space 
					// regardless of interpolation. It looks better this way...
					interpolatedChar = ' ';
				}
				else
				{
					// The end character is not a space, so we interpolate...
					int startCharValue = Convert.ToInt32(startChar);
					int endCharValue = Convert.ToInt32(cEnd);
					int interpolatedValue = Utility.Interpolate(startCharValue, endCharValue, percentage);
					interpolatedChar = Convert.ToChar(interpolatedValue);
				}

                result[i] = interpolatedChar;
            }

            return new string(result);
        }
    }
}
