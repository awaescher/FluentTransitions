using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FluentTransitions;

namespace TestApp
{
	/// <summary>
	/// This control shows a color-rippling effect when you call its ripple()
	/// method. It holds a grid of 10x10 label controls with an initial white 
	/// background color. The ripple method uses a separate transition on each
	/// label to move it to pink and back again.
	/// 
	/// The code to set up the labels (in the Load method) is a bit complicated, 
	/// but the ripple transition itself is very simple.
	/// </summary>
	public partial class RippleControl : UserControl
	{
		// A collection of cell-infos, i.e. info on each label on the control...
		private readonly IList<CellInfo> _cellInfos = new List<CellInfo>();

		/// <summary>
		/// Constructor.
		/// </summary>
		public RippleControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Starts the ripple effect.
		/// </summary>
		public void Ripple()
		{
			// We run a transition on each of the labels shown on the control.
			// This means that we will be running 100 simulataneous transitions...
			foreach (var info in _cellInfos)
			{
				Transition
					.With(info.Control, nameof(BackColor), Color.Pink)
					.Flash(1, TimeSpan.FromMilliseconds(info.TransitionInterval));
			}
		}

		/// <summary>
		/// Called when the control is first loaded.
		/// </summary>
		private void RippleControl_Load(object sender, EventArgs e)
		{
			double cellWidth = Width / 10.0;
			double cellHeight = Height / 10.0;

			// We set up a 10x10 grid of labels...
			double top = 0;
			for (int row = 0; row < 10; ++row)
			{
				double left = 0;
				double bottom = top + cellHeight;

				for (int col = 0; col < 10; ++col)
				{
					// We work out the size of this label...
					double right = left + cellWidth;
					int leftInt = (int)left;
					int topInt = (int)top;
					int rightInt = (int)right;
					int bottomInt = (int)bottom;
					int width = rightInt - leftInt;
					int height = bottomInt - topInt;

					// We create the label...
					var label = new Label
					{
						Left = leftInt,
						Top = topInt,
						Width = width,
						Height = height,
						BackColor = Color.White
					};

					// And add it to the control...
					Controls.Add(label);

					// We work out a transition time for it, and store the information
					// to use when we do the ripple effect...
					int transitionInterval = row * 100 + col * 100;
					_cellInfos.Add(new CellInfo { Control = label, TransitionInterval = transitionInterval });

					// The left for the next column is the right for this one...
					left = right;
				}

				// The top of the next row is the bottom of this one...
				top = bottom;
			}
		}

		// A small class that holds information about one of the labels on the control.
		private class CellInfo
		{
			public Control Control { get; set; }

			public int TransitionInterval { get; set; }
		}
	}
}
