using System;
using System.Windows.Forms;
using SharpTransitions;
using SharpTransitions.Methods;

namespace TestApp
{
	/// <summary>
	/// This is a simple user-control that hosts two picture-boxes (one showing
	/// a kitten and the other showing a puppy). The transitionPictures method
	/// performs a random animated transition between the two pictures.
	/// </summary>
	public partial class KittenPuppyControl : UserControl
	{
		private PictureBox _activePicture = null;
		private PictureBox _inactivePicture = null;
		private readonly Random _random = new Random();

		/// <summary>
		/// Constructor.
		/// </summary>
		public KittenPuppyControl()
		{
			InitializeComponent();
			_activePicture = ctrlPuppy;
			_inactivePicture = ctrlKitten;
		}

		/// <summary>
		/// Performs a random tarnsition between the two pictures.
		/// </summary>
		public void TransitionPictures()
		{
			// We randomly choose where the current image is going to 
			// slide off to (and where we are going to slide the inactive
			// image in from)...
			int destinationLeft = (_random.Next(2) == 0) ? Width : -Width;
			int destinationTop = (_random.Next(3) - 1) * Height;

			// We move the inactive image to this location...
			SuspendLayout();
			_inactivePicture.Top = destinationTop;
			_inactivePicture.Left = destinationLeft;
			_inactivePicture.BringToFront();
			ResumeLayout();

			// We perform the transition which moves the active image off the
			// screen, and the inactive one onto the screen...
			Transition
				.With(_inactivePicture, "Left", 0)
				.With(_inactivePicture, "Top", 0)
				.With(_activePicture, "Left", destinationLeft)
				.With(_activePicture, "Top", destinationTop)
				.EaseInEaseOut(TimeSpan.FromSeconds(1));

			// We swap over which image is active and inactive for next time
			// the function is called...
			var temp = _activePicture;
			_activePicture = _inactivePicture;
			_inactivePicture = temp;
		}
	}
}
