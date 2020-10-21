using System;
using System.Windows.Forms;
using FluentTransitions;
using System.Drawing;
using System.Collections.Generic;
using FluentTransitions.Methods;
using System.Threading;

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
		private readonly Color BACKCOLOR_GRAY = Color.FromArgb(80, 80, 80);
		private readonly Color BACKCOLOR_WHITE = Color.FromArgb(255, 255, 255);

		// The left point of the 'bounce' and 'throw-and-catch' group boxes...
		private const int GROUP_BOX_LEFT = 12;

		// Strings used for the text transition...
		private const string STRING_SHORT1 = "I've got two tickets";
		private const string STRING_LONG1 = "to Iron Maiden, baby.";
		private const string STRING_SHORT2 = "Come with me friday";
		private const string STRING_LONG2 = "don't say maybe!";

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
				.With(controlOnScreen, nameof(Left), -1 * controlOnScreen.Width)
				.With(controlOffScreen, nameof(Left), GROUP_BOX_LEFT)
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

			Transition
				.With(cmdBounceMe, nameof(Top), destination)
				.Bounce(TimeSpan.FromSeconds(0.5));
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

			Transition
				.With(cmdThrowAndCatch, nameof(Top), 12)
				.ThrowAndCatch(TimeSpan.FromSeconds(1.5));
		}

		/// <summary>
		/// Called when the "Flash Me!" button is pressed.
		/// </summary>
		private void cmdFlashMe_Click(object sender, EventArgs e)
		{
			// The Flash transition animates the property to the destination value
			// and back again. You specify how many flashes to show and the length
			// of each flash...
			Transition
				.With(cmdFlashMe, nameof(BackColor), Color.Pink)
				.Flash(2, TimeSpan.FromSeconds(0.3));
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
			if (lblTextTransition1.Text == STRING_SHORT1)
			{
				text1 = STRING_SHORT2;
				color1 = Color.Red;
				text2 = STRING_LONG2;
				color2 = Color.Blue;
			}
			else
			{
				text1 = STRING_SHORT1;
				color1 = Color.Blue;
				text2 = STRING_LONG1;
				color2 = Color.Red;
			}

			// We create a transition to animate all four properties at the same time...
			Transition
				.With(lblTextTransition1, nameof(Text), text1)
				.With(lblTextTransition1, nameof(ForeColor), color1)
				.With(lblTextTransition2, nameof(Text), text2)
				.With(lblTextTransition2, nameof(ForeColor), color2)
				.EaseInEaseOut(TimeSpan.FromSeconds(1));
		}

		/// <summary>
		/// Called when the "Change Form Color" button is pressed.
		/// </summary>
		private void ctrlChangeFormColor_Click(object sender, EventArgs e)
		{
			// We alternate the form's background color...
			var destination = (BackColor == BACKCOLOR_GRAY) ? BACKCOLOR_WHITE : BACKCOLOR_GRAY;
			Transition
				.With(this, nameof(BackColor), destination)
				.Linear(TimeSpan.FromSeconds(1));
		}

		/// <summary>
		/// Called when the "More" or "Less" button is pressed.
		/// </summary>
		private void cmdMore_Click(object sender, EventArgs e)
		{
			// We either show more screen or less screen depending on the current state.
			// We find out whether we need to make the screen wider or narrower...
			int formWidth;
			if (cmdMore.Text == "More »")
			{
				formWidth = 984;
				cmdMore.Text = "« Less";
			}
			else
			{
				formWidth = 452;
				cmdMore.Text = "More »";
			}

			// We animate it with an ease-in-ease-out transition...
			Transition
				.With(this, nameof(Width), formWidth)
				.EaseInEaseOut(TimeSpan.FromSeconds(1));
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

			Transition
				.With(cmdDropAndBounce, nameof(Top), destination)
				.UserDefined(elements, TimeSpan.FromSeconds(2));

			// The transition above just animates the vertical bounce of the button, but not
			// the left-to-right movement. This can't use the same transition, as otherwise the
			// left-to-right movement would bounce back and forth.

			// We run the left-to-right animation as a second, simultaneous transition. 
			// In fact, we run a transition chain, with the animation of the button back
			// to its starting position as the second item in the chain. The second 
			// transition starts as soon as the first is complete...

			var originalText = cmdDropAndBounce.Text;

			Transition.RunChain(
				Transition
					.With(cmdDropAndBounce, nameof(Left), cmdDropAndBounce.Left + 400)
					.HookOnCompletionInUiThread(SynchronizationContext.Current, () => cmdDropAndBounce.Text = "Going home ...")
					.Build(new Linear(TimeSpan.FromSeconds(2))),
				Transition
					.With(cmdDropAndBounce, nameof(Top), 19)
					.With(cmdDropAndBounce, nameof(Left), 6)
					.HookOnCompletionInUiThread(SynchronizationContext.Current, () => cmdDropAndBounce.Text = originalText)
					.Build(new Linear(TimeSpan.FromSeconds(2)))
				);
		}
	}
}
