using System.Collections.Generic;

namespace FluentTransitions.Methods
{
	/// <summary>
	/// This transition type 'flashes' the properties a specified number of times, ending
	/// up by reverting them to their initial values. You specify the number of bounces and
	/// the length of each bounce. 
	/// </summary>
	public class Flash : UserDefined
	{
		/// <summary>
		/// You specify the number of bounces and the time taken for each bounce.
		/// </summary>
		public Flash(int numberOfFlashes, int flashTime)
		{
			// This class is derived from the user-defined transition type.
			// Here we set up a custom "user-defined" transition for the 
			// number of flashes passed in...
			double flashInterval = 100.0 / numberOfFlashes;

			// We set up the elements of the user-defined transition...
			IList<TransitionElement> elements = new List<TransitionElement>();
			for (int i = 0; i < numberOfFlashes; ++i)
			{
				// Each flash consists of two elements: one going to the destination value, 
				// and another going back again...
				double flashStartTime = i * flashInterval;
				double flashEndTime = flashStartTime + flashInterval;
				double flashMidPoint = (flashStartTime + flashEndTime) / 2.0;
				elements.Add(new TransitionElement(flashMidPoint, 100, InterpolationMethod.EaseInEaseOut));
				elements.Add(new TransitionElement(flashEndTime, 0, InterpolationMethod.EaseInEaseOut));
			}

			base.Setup(elements, flashTime * numberOfFlashes);
		}
	}
}
