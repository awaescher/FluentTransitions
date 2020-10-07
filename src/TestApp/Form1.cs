using System;
using System.Windows.Forms;
using SharpTransitions;
using System.Drawing;
using System.Collections.Generic;
using SharpTransitions.Methods;

namespace TestApp
{
	/// <summary>
	/// This form demonstrates a number of animated transitions using the Transitions
	/// library. Each event handler (form-load, button click) demonstrates a different
	/// transition.
	/// </summary>
	public partial class Form1 : Form
	{
		// Colors used by the change-form-color transition...
		private readonly Color BACKCOLOR_PINK = Color.FromArgb(255, 220, 220);
		private readonly Color BACK_COLOR_YELLOW = Color.FromArgb(255, 255, 220);

		// The left point of the 'bounce' and 'throw-and-catch' group boxes...
		private const int GROUP_BOX_LEFT = 12;

		// Strings used for the text transition...
		private const string STRING_SHORT = "Hello, World!";
		private const string STRING_LONG = "A longer piece of text.";

		/// <summary>
		/// Constructor.
		/// </summary>
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Called when the "Swap" button is pressed.
		/// </summary>
		private void cmdSwap_Click(object sender, EventArgs e)
		{
			// We swap over the group-boxes that show the "Bounce" and 
			// "Throw and Catch" transitions. The active one is animated 
			// left off the screen and the inactive one is animated right
			// onto the screen...

			// We work out which box is currently on screen and
			// which is off screen...
			Control controlOnScreen, controlOffScreen;
			if (gbBounce.Left == GROUP_BOX_LEFT)
			{
				controlOnScreen = gbBounce;
				controlOffScreen = gbThrowAndCatch;
			}
			else
			{
				controlOnScreen = gbThrowAndCatch;
				controlOffScreen = gbBounce;
			}
			controlOnScreen.SendToBack();
			controlOffScreen.BringToFront();

			// We create a transition to animate the two boxes simultaneously. One is
			// animated onto the screen, the other off the screen.

			// The ease-in-ease-out transition acclerates the rate of change for the 
			// first half of the animation, and decelerates during the second half.

			Transition
				.With(controlOnScreen, "Left", -1 * controlOnScreen.Width)
				.With(controlOffScreen, "Left", GROUP_BOX_LEFT)
				.EaseInEaseOut(TimeSpan.FromSeconds(1));
		}

		/// <summary>
		/// Called when the "Bounce Me!" button is pressed.
		/// </summary>
		private void cmdBounceMe_Click(object sender, EventArgs e)
		{
			// We bounce the button down to the bottom of the group box it is in, and 
			// back up again.

			// The Bounce transition accelerates the property to its destination value
			// (as if with gravity) and decelerates it back  to its original value (as
			// if against gravity).

			int destination = gbBounce.Height - cmdBounceMe.Height;
			Transition.Run(cmdBounceMe, "Top", destination, new Bounce(1500));
		}

		/// <summary>
		/// Called when the "Throw and Catch" button is pressed.
		/// </summary>
		private void cmdThrowAndCatch_Click(object sender, EventArgs e)
		{
			// The button is 'thrown' up to the top of the group-box it is in
			// and then falls back down again. 

			// The throw-and-catch transition starts the animation at a high rate and
			// decelerates to zero (as if against gravity) at the destination value. It 
			// then accelerates the value (as if with gravity) back to the original value.

			Transition.Run(cmdThrowAndCatch, "Top", 12, new ThrowAndCatch(1500));
		}

		/// <summary>
		/// Called when the "Flash Me!" button is pressed.
		/// </summary>
		private void cmdFlashMe_Click(object sender, EventArgs e)
		{
			// The Flash transition animates the property to the destination value
			// and back again. You specify how many flashes to show and the length
			// of each flash...
			Transition.Run(cmdFlashMe, "BackColor", Color.Pink, new Flash(2, 300));
		}

		/// <summary>
		/// Called when the "Ripple" button is pressed.
		/// </summary>
		private void cmdRipple_Click(object sender, EventArgs e)
		{
			// The ripple is handled by the RippleControl user-control.
			// This performs 100 simultaneous animations to create the 
			// ripple effect...
			ctrlRipple.Ripple();
		}

		/// <summary>
		/// Called when the "Swap Pictures" button is pressed.
		/// </summary>
		private void cmdSwapPictures_Click(object sender, EventArgs e)
		{
			// The transition is handled by the KittenPuppyControl...
			ctrlPictures.TransitionPictures();
		}

		/// <summary>
		/// Called when the "Text Transition" button is pressed.
		/// </summary>
		private void cmdTextTransition_Click(object sender, EventArgs e)
		{
			// We transition four properties simulataneously here:
			// - The two labels' text is changed.
			// - The two labels' colors are changed.

			// We work out the new text and colors to transition to...
			string text1, text2;
			Color color1, color2;
			if (lblTextTransition1.Text == STRING_SHORT)
			{
				text1 = STRING_LONG;
				color1 = Color.Red;
				text2 = STRING_SHORT;
				color2 = Color.Blue;
			}
			else
			{
				text1 = STRING_SHORT;
				color1 = Color.Blue;
				text2 = STRING_LONG;
				color2 = Color.Red;
			}

			// We create a transition to animate all four properties at the same time...
			Transition
				.With(lblTextTransition1, "Text", text1)
				.With(lblTextTransition1, "ForeColor", color1)
				.With(lblTextTransition2, "Text", text2)
				.With(lblTextTransition2, "ForeColor", color2)
				.EaseInEaseOut(TimeSpan.FromSeconds(1));
		}

		/// <summary>
		/// Called when the "Change Form Color" button is pressed.
		/// </summary>
		private void ctrlChangeFormColor_Click(object sender, EventArgs e)
		{
			// We alternate the form's background color...
			var destination = (BackColor == BACKCOLOR_PINK) ? BACK_COLOR_YELLOW : BACKCOLOR_PINK;
			Transition.Run(this, "BackColor", destination, new Linear(1000));
		}

		/// <summary>
		/// Called when the "More" or "Less" button is pressed.
		/// </summary>
		private void cmdMore_Click(object sender, EventArgs e)
		{
			// We either show more screen or less screen depending on the current state.
			// We find out whether we need to make the screen wider or narrower...
			int formWidth;
			if (cmdMore.Text == "More >>")
			{
				formWidth = 984;
				cmdMore.Text = "<< Less";
			}
			else
			{
				formWidth = 452;
				cmdMore.Text = "More >>";
			}

			// We animate it with an ease-in-ease-out transition...
			Transition.Run(this, "Width", formWidth, new EaseInEaseOut(1000));
		}

		/// <summary>
		/// Called when the "Drop and Bounce" button is pressed.
		/// </summary>
		private void cmdDropAndBounce_Click(object sender, EventArgs e)
		{
			// We animate the button to drop and bounce twice with bounces
			// of diminishing heights. While it does this, it is moving to 
			// the right, as if thrown to the right. When this animation has
			// finished, the button moves back to its original position.

			// The diminishing-bounce is not one of the built-in transition types,
			// so we create it here as a user-defined transition type. You define 
			// these as a collection of TransitionElements. These define how far the
			// animated properties will have moved at various times, and how the 
			// transition between different elements is to be done.

			// So in the example below:
			//  0% - 40%    The button acclerates to 100% distance (i.e. the bottom of the screen)
			// 40% - 65%    The button bounces back (decelerating) to 70% distance.
			// etc...

			var elements = new List<TransitionElement>
			{
				new TransitionElement(40, 100, InterpolationMethod.Accleration),
				new TransitionElement(65, 70, InterpolationMethod.Deceleration),
				new TransitionElement(80, 100, InterpolationMethod.Accleration),
				new TransitionElement(90, 92, InterpolationMethod.Deceleration),
				new TransitionElement(100, 100, InterpolationMethod.Accleration)
			};

			int destination = gbDropAndBounce.Height - cmdDropAndBounce.Height - 10;
			Transition.Run(cmdDropAndBounce, "Top", destination, new UserDefined(elements, 2000));

			// The transition above just animates the vertical bounce of the button, but not
			// the left-to-right movement. This can't use the same transition, as otherwise the
			// left-to-right movement would bounce back and forth.

			// We run the left-to-right animation as a second, simultaneous transition. 
			// In fact, we run a transition chain, with the animation of the button back
			// to its starting position as the second item in the chain. The second 
			// transition starts as soon as the first is complete...

			var transition1 = Transition
				.With(cmdDropAndBounce, "Left", cmdDropAndBounce.Left + 400)
				.Build(new Linear(2000));

			var transition2 = Transition
				.With(cmdDropAndBounce, "Top", 19)
				.With(cmdDropAndBounce, "Left", 6)
				.Build(new EaseInEaseOut(2000));

			Transition.RunChain(transition1, transition2);
		}
	}
}
