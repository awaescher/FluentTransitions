using System;
using System.Windows.Forms;
using FluentTransitions;
using System.Drawing;
using System.Threading.Tasks;

namespace TestApp
{
	/// <summary>
	/// This form demonstrates a number of animated transitions using the Transitions
	/// library. Each event handler (form-load, button click) demonstrates a different
	/// transition.
	/// </summary>
	public partial class DemoForm : Form
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
		public DemoForm()
		{
			InitializeComponent();

			Width = MinimizedFormWidth;
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			_initialEasingButtonLeft = buttonAccelerate.Left;
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			Center();
		}

		protected override void OnResizeEnd(EventArgs e)
		{
			base.OnResizeEnd(e);

			Center();

			if (Width <= MinimizedFormWidth)
				cmdMore.Text = "More »";
			else
				cmdMore.Text = "« Less";
		}

		private void Center()
		{
			if (_moving)
				return;

			_moving = true;

			Task.Delay(10).ContinueWith(_ =>
			{
				BeginInvoke(new MethodInvoker(() =>
				{

					var area = Screen.FromControl(this).WorkingArea;
					var targetX = (area.Width / 2) - (Width / 2);
					var targetY = (area.Height / 2) - (Height / 2);

					Transition
						.With(this, nameof(Left), targetX)
						.With(this, nameof(Top), targetY)
						.HookOnCompletion(() => _moving = false)
						.Spring(TimeSpan.FromSeconds(0.75));
				}));
			});
		}

		private bool _moving = false;
		private int _initialEasingButtonLeft;


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
			if (Width > MinimizedFormWidth)
			{
				formWidth = MinimizedFormWidth;
				cmdMore.Text = "« Less";
			}
			else
			{
				formWidth = groupBox1.Right + gpEasing.Left + gpEasing.Left;
				cmdMore.Text = "More »";
			}
			_moving = true;
			// We animate it with an ease-in-ease-out transition...
			Transition
				.With(this, nameof(Width), formWidth)
				.HookOnCompletion(() => 
				{
					_moving = false;
					Center();
				})
				.Spring(TimeSpan.FromSeconds(1));
		}

		private int MinimizedFormWidth => gpEasing.Right + gpEasing.Left + ((Width - ClientSize.Width) / 1);

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				Transition
					.With(txtPassword, nameof(Left), txtPassword.Left - 15)
					.Flash(4, TimeSpan.FromMilliseconds(120));
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (buttonAccelerate.Left == _initialEasingButtonLeft)
				Ease();
			else
				EaseBack();

			//Task.Run(async () => 
			//{
			//	await Task.Delay(TimeSpan.FromSeconds(3));
			//	BeginInvoke((Action)(() => 
			//	{
			//		EaseBack();
			//	}));
			//});
		}

		private void Ease()
		{
			var targetLeft = label2.Left;
			var duration = TimeSpan.FromSeconds(1);

			Transition
				.With(buttonAccelerate, nameof(Left), targetLeft)
				.Accelerate(duration);

			Transition
				.With(buttonBounce, nameof(Left), targetLeft)
				.Bounce(duration);

			Transition
				.With(buttonCriticalDamp, nameof(Left), targetLeft)
				.CriticalDamp(duration);

			Transition
				.With(buttonDecelerate, nameof(Left), targetLeft)
				.Decelerate(duration);

			Transition
				.With(buttonEaseInEaseOut, nameof(Left), targetLeft)
				.EaseInEaseOut(duration);

			Transition
				.With(buttonFlash, nameof(Left), targetLeft)
				.Flash(5, TimeSpan.FromMilliseconds(duration.TotalMilliseconds / 5));

			Transition
				.With(buttonLinear, nameof(Left), targetLeft)
				.Linear(duration);

			Transition
				.With(buttonSpring, nameof(Left), targetLeft)
				.Spring(duration);

			Transition
				.With(buttonThrowAndCatch, nameof(Left), targetLeft)
				.ThrowAndCatch(duration);
		}

		private void EaseBack()
		{
			Transition
				.With(buttonAccelerate, nameof(Left), _initialEasingButtonLeft)
				.With(buttonBounce, nameof(Left), _initialEasingButtonLeft)
				.With(buttonCriticalDamp, nameof(Left), _initialEasingButtonLeft)
				.With(buttonDecelerate, nameof(Left), _initialEasingButtonLeft)
				.With(buttonEaseInEaseOut, nameof(Left), _initialEasingButtonLeft)
				.With(buttonFlash, nameof(Left), _initialEasingButtonLeft)
				.With(buttonLinear, nameof(Left), _initialEasingButtonLeft)
				.With(buttonSpring, nameof(Left), _initialEasingButtonLeft)
				.With(buttonThrowAndCatch, nameof(Left), _initialEasingButtonLeft)
				.EaseInEaseOut(TimeSpan.FromSeconds(1));
		}

	}
}
