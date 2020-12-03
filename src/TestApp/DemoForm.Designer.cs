namespace TestApp
{
    partial class DemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.cmdRipple = new System.Windows.Forms.Button();
			this.cmdThrowAndCatch = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblTextTransition2 = new System.Windows.Forms.Label();
			this.lblTextTransition1 = new System.Windows.Forms.Label();
			this.cmdTextTransition = new System.Windows.Forms.Button();
			this.gbThrowAndCatch = new System.Windows.Forms.GroupBox();
			this.gbRipple = new System.Windows.Forms.GroupBox();
			this.cmdMore = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdSwapPictures = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.buttonEasing = new System.Windows.Forms.Button();
			this.gpEasing = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonThrowAndCatch = new System.Windows.Forms.Button();
			this.buttonSpring = new System.Windows.Forms.Button();
			this.buttonLinear = new System.Windows.Forms.Button();
			this.buttonFlash = new System.Windows.Forms.Button();
			this.buttonEaseInEaseOut = new System.Windows.Forms.Button();
			this.buttonDecelerate = new System.Windows.Forms.Button();
			this.buttonCriticalDamp = new System.Windows.Forms.Button();
			this.buttonAccelerate = new System.Windows.Forms.Button();
			this.buttonSprings = new System.Windows.Forms.Button();
			this.buttonBounce = new System.Windows.Forms.Button();
			this.ctrlPictures = new TestApp.KittenPuppyControl();
			this.ctrlRipple = new TestApp.RippleControl();
			this.groupBox1.SuspendLayout();
			this.gbThrowAndCatch.SuspendLayout();
			this.gbRipple.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.gpEasing.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdRipple
			// 
			this.cmdRipple.Location = new System.Drawing.Point(6, 19);
			this.cmdRipple.Name = "cmdRipple";
			this.cmdRipple.Size = new System.Drawing.Size(193, 37);
			this.cmdRipple.TabIndex = 9;
			this.cmdRipple.Text = "Ripple";
			this.cmdRipple.UseVisualStyleBackColor = true;
			this.cmdRipple.Click += new System.EventHandler(this.cmdRipple_Click);
			// 
			// cmdThrowAndCatch
			// 
			this.cmdThrowAndCatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdThrowAndCatch.Location = new System.Drawing.Point(6, 544);
			this.cmdThrowAndCatch.Name = "cmdThrowAndCatch";
			this.cmdThrowAndCatch.Size = new System.Drawing.Size(199, 34);
			this.cmdThrowAndCatch.TabIndex = 11;
			this.cmdThrowAndCatch.Text = "Throw and Catch";
			this.cmdThrowAndCatch.UseVisualStyleBackColor = true;
			this.cmdThrowAndCatch.Click += new System.EventHandler(this.cmdThrowAndCatch_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblTextTransition2);
			this.groupBox1.Controls.Add(this.lblTextTransition1);
			this.groupBox1.Controls.Add(this.cmdTextTransition);
			this.groupBox1.Location = new System.Drawing.Point(587, 311);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(211, 101);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Text transition";
			// 
			// lblTextTransition2
			// 
			this.lblTextTransition2.AutoSize = true;
			this.lblTextTransition2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTextTransition2.ForeColor = System.Drawing.Color.Crimson;
			this.lblTextTransition2.Location = new System.Drawing.Point(7, 75);
			this.lblTextTransition2.Name = "lblTextTransition2";
			this.lblTextTransition2.Size = new System.Drawing.Size(192, 16);
			this.lblTextTransition2.TabIndex = 15;
			this.lblTextTransition2.Text = "A longer piece of text.";
			// 
			// lblTextTransition1
			// 
			this.lblTextTransition1.AutoSize = true;
			this.lblTextTransition1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTextTransition1.ForeColor = System.Drawing.Color.Blue;
			this.lblTextTransition1.Location = new System.Drawing.Point(6, 59);
			this.lblTextTransition1.Name = "lblTextTransition1";
			this.lblTextTransition1.Size = new System.Drawing.Size(112, 16);
			this.lblTextTransition1.TabIndex = 14;
			this.lblTextTransition1.Text = "Hello, World!";
			// 
			// cmdTextTransition
			// 
			this.cmdTextTransition.Location = new System.Drawing.Point(6, 19);
			this.cmdTextTransition.Name = "cmdTextTransition";
			this.cmdTextTransition.Size = new System.Drawing.Size(193, 37);
			this.cmdTextTransition.TabIndex = 13;
			this.cmdTextTransition.Text = "Text Transition";
			this.cmdTextTransition.UseVisualStyleBackColor = true;
			this.cmdTextTransition.Click += new System.EventHandler(this.cmdTextTransition_Click);
			// 
			// gbThrowAndCatch
			// 
			this.gbThrowAndCatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gbThrowAndCatch.Controls.Add(this.cmdThrowAndCatch);
			this.gbThrowAndCatch.Location = new System.Drawing.Point(-211, 50);
			this.gbThrowAndCatch.Name = "gbThrowAndCatch";
			this.gbThrowAndCatch.Size = new System.Drawing.Size(211, 584);
			this.gbThrowAndCatch.TabIndex = 15;
			this.gbThrowAndCatch.TabStop = false;
			this.gbThrowAndCatch.Text = "Throw and Catch";
			// 
			// gbRipple
			// 
			this.gbRipple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gbRipple.Controls.Add(this.cmdRipple);
			this.gbRipple.Controls.Add(this.ctrlRipple);
			this.gbRipple.Location = new System.Drawing.Point(587, 418);
			this.gbRipple.Name = "gbRipple";
			this.gbRipple.Size = new System.Drawing.Size(211, 211);
			this.gbRipple.TabIndex = 18;
			this.gbRipple.TabStop = false;
			this.gbRipple.Text = "Ripple";
			// 
			// cmdMore
			// 
			this.cmdMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdMore.Location = new System.Drawing.Point(828, 16);
			this.cmdMore.Name = "cmdMore";
			this.cmdMore.Size = new System.Drawing.Size(80, 34);
			this.cmdMore.TabIndex = 21;
			this.cmdMore.Text = "More »";
			this.cmdMore.UseVisualStyleBackColor = true;
			this.cmdMore.Click += new System.EventHandler(this.cmdMore_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmdSwapPictures);
			this.groupBox2.Controls.Add(this.ctrlPictures);
			this.groupBox2.Location = new System.Drawing.Point(587, 181);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(211, 124);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Picture transition";
			// 
			// cmdSwapPictures
			// 
			this.cmdSwapPictures.Location = new System.Drawing.Point(10, 19);
			this.cmdSwapPictures.Name = "cmdSwapPictures";
			this.cmdSwapPictures.Size = new System.Drawing.Size(73, 90);
			this.cmdSwapPictures.TabIndex = 1;
			this.cmdSwapPictures.Text = "Swap Pictures";
			this.cmdSwapPictures.UseVisualStyleBackColor = true;
			this.cmdSwapPictures.Click += new System.EventHandler(this.cmdSwapPictures_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.txtPassword);
			this.groupBox3.Location = new System.Drawing.Point(587, 56);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(211, 119);
			this.groupBox3.TabIndex = 23;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "macOS like password box";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Enter the secret password\r\nand hit [Return]";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(27, 73);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '●';
			this.txtPassword.Size = new System.Drawing.Size(158, 20);
			this.txtPassword.TabIndex = 0;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			// 
			// buttonEasing
			// 
			this.buttonEasing.Location = new System.Drawing.Point(12, 16);
			this.buttonEasing.Name = "buttonEasing";
			this.buttonEasing.Size = new System.Drawing.Size(75, 34);
			this.buttonEasing.TabIndex = 24;
			this.buttonEasing.Text = "Demo";
			this.buttonEasing.UseVisualStyleBackColor = true;
			this.buttonEasing.Click += new System.EventHandler(this.button1_Click);
			// 
			// gpEasing
			// 
			this.gpEasing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gpEasing.Controls.Add(this.label2);
			this.gpEasing.Controls.Add(this.buttonThrowAndCatch);
			this.gpEasing.Controls.Add(this.buttonLinear);
			this.gpEasing.Controls.Add(this.buttonFlash);
			this.gpEasing.Controls.Add(this.buttonEaseInEaseOut);
			this.gpEasing.Controls.Add(this.buttonDecelerate);
			this.gpEasing.Controls.Add(this.buttonCriticalDamp);
			this.gpEasing.Controls.Add(this.buttonBounce);
			this.gpEasing.Controls.Add(this.buttonAccelerate);
			this.gpEasing.Controls.Add(this.buttonSpring);
			this.gpEasing.Location = new System.Drawing.Point(12, 56);
			this.gpEasing.Name = "gpEasing";
			this.gpEasing.Size = new System.Drawing.Size(559, 573);
			this.gpEasing.TabIndex = 24;
			this.gpEasing.TabStop = false;
			this.gpEasing.Text = "Easings";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.BackColor = System.Drawing.Color.DarkGray;
			this.label2.Location = new System.Drawing.Point(412, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1, 540);
			this.label2.TabIndex = 26;
			// 
			// buttonThrowAndCatch
			// 
			this.buttonThrowAndCatch.Location = new System.Drawing.Point(15, 289);
			this.buttonThrowAndCatch.Name = "buttonThrowAndCatch";
			this.buttonThrowAndCatch.Size = new System.Drawing.Size(115, 23);
			this.buttonThrowAndCatch.TabIndex = 25;
			this.buttonThrowAndCatch.Text = "ThrowAndCatch";
			this.buttonThrowAndCatch.UseVisualStyleBackColor = true;
			// 
			// buttonSpring
			// 
			this.buttonSpring.Location = new System.Drawing.Point(15, 260);
			this.buttonSpring.Name = "buttonSpring";
			this.buttonSpring.Size = new System.Drawing.Size(115, 23);
			this.buttonSpring.TabIndex = 25;
			this.buttonSpring.Text = "Spring";
			this.buttonSpring.UseVisualStyleBackColor = true;
			// 
			// buttonLinear
			// 
			this.buttonLinear.Location = new System.Drawing.Point(15, 231);
			this.buttonLinear.Name = "buttonLinear";
			this.buttonLinear.Size = new System.Drawing.Size(115, 23);
			this.buttonLinear.TabIndex = 25;
			this.buttonLinear.Text = "Linear";
			this.buttonLinear.UseVisualStyleBackColor = true;
			// 
			// buttonFlash
			// 
			this.buttonFlash.Location = new System.Drawing.Point(15, 202);
			this.buttonFlash.Name = "buttonFlash";
			this.buttonFlash.Size = new System.Drawing.Size(115, 23);
			this.buttonFlash.TabIndex = 25;
			this.buttonFlash.Text = "Flash";
			this.buttonFlash.UseVisualStyleBackColor = true;
			// 
			// buttonEaseInEaseOut
			// 
			this.buttonEaseInEaseOut.Location = new System.Drawing.Point(15, 173);
			this.buttonEaseInEaseOut.Name = "buttonEaseInEaseOut";
			this.buttonEaseInEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonEaseInEaseOut.TabIndex = 25;
			this.buttonEaseInEaseOut.Text = "EaseInEaseOut";
			this.buttonEaseInEaseOut.UseVisualStyleBackColor = true;
			// 
			// buttonDecelerate
			// 
			this.buttonDecelerate.Location = new System.Drawing.Point(15, 147);
			this.buttonDecelerate.Name = "buttonDecelerate";
			this.buttonDecelerate.Size = new System.Drawing.Size(115, 23);
			this.buttonDecelerate.TabIndex = 25;
			this.buttonDecelerate.Text = "Decelerate";
			this.buttonDecelerate.UseVisualStyleBackColor = true;
			// 
			// buttonCriticalDamp
			// 
			this.buttonCriticalDamp.Location = new System.Drawing.Point(15, 118);
			this.buttonCriticalDamp.Name = "buttonCriticalDamp";
			this.buttonCriticalDamp.Size = new System.Drawing.Size(115, 23);
			this.buttonCriticalDamp.TabIndex = 25;
			this.buttonCriticalDamp.Text = "CriticalDamp";
			this.buttonCriticalDamp.UseVisualStyleBackColor = true;
			// 
			// buttonAccelerate
			// 
			this.buttonAccelerate.Location = new System.Drawing.Point(15, 60);
			this.buttonAccelerate.Name = "buttonAccelerate";
			this.buttonAccelerate.Size = new System.Drawing.Size(115, 23);
			this.buttonAccelerate.TabIndex = 25;
			this.buttonAccelerate.Text = "Accelerate";
			this.buttonAccelerate.UseVisualStyleBackColor = true;
			// 
			// buttonSprings
			// 
			this.buttonSprings.Location = new System.Drawing.Point(0, 0);
			this.buttonSprings.Name = "buttonSprings";
			this.buttonSprings.Size = new System.Drawing.Size(75, 23);
			this.buttonSprings.TabIndex = 0;
			// 
			// buttonBounce
			// 
			this.buttonBounce.Location = new System.Drawing.Point(15, 89);
			this.buttonBounce.Name = "buttonBounce";
			this.buttonBounce.Size = new System.Drawing.Size(115, 23);
			this.buttonBounce.TabIndex = 25;
			this.buttonBounce.Text = "Bounce";
			this.buttonBounce.UseVisualStyleBackColor = true;
			// 
			// ctrlPictures
			// 
			this.ctrlPictures.Location = new System.Drawing.Point(95, 19);
			this.ctrlPictures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctrlPictures.Name = "ctrlPictures";
			this.ctrlPictures.Size = new System.Drawing.Size(103, 90);
			this.ctrlPictures.TabIndex = 0;
			// 
			// ctrlRipple
			// 
			this.ctrlRipple.Location = new System.Drawing.Point(6, 62);
			this.ctrlRipple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctrlRipple.Name = "ctrlRipple";
			this.ctrlRipple.Size = new System.Drawing.Size(193, 140);
			this.ctrlRipple.TabIndex = 8;
			// 
			// DemoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(918, 640);
			this.Controls.Add(this.gpEasing);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.cmdMore);
			this.Controls.Add(this.gbRipple);
			this.Controls.Add(this.gbThrowAndCatch);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonEasing);
			this.Name = "DemoForm";
			this.Text = "Transitions TestApp";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbThrowAndCatch.ResumeLayout(false);
			this.gbRipple.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.gpEasing.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private RippleControl ctrlRipple;
        private System.Windows.Forms.Button cmdRipple;
        private System.Windows.Forms.Button cmdThrowAndCatch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTextTransition2;
        private System.Windows.Forms.Label lblTextTransition1;
        private System.Windows.Forms.Button cmdTextTransition;
        private System.Windows.Forms.GroupBox gbThrowAndCatch;
        private System.Windows.Forms.GroupBox gbRipple;
        private System.Windows.Forms.Button cmdMore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdSwapPictures;
        private KittenPuppyControl ctrlPictures;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button buttonEasing;
		private System.Windows.Forms.GroupBox gpEasing;
		private System.Windows.Forms.Button buttonSpring;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonSprings;
		private System.Windows.Forms.Button buttonLinear;
		private System.Windows.Forms.Button buttonFlash;
		private System.Windows.Forms.Button buttonEaseInEaseOut;
		private System.Windows.Forms.Button buttonDecelerate;
		private System.Windows.Forms.Button buttonCriticalDamp;
		private System.Windows.Forms.Button buttonAccelerate;
		private System.Windows.Forms.Button buttonThrowAndCatch;
		private System.Windows.Forms.Button buttonBounce;
	}
}

