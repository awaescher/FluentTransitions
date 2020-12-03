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
			this.buttonDemo = new System.Windows.Forms.Button();
			this.gpEasing = new System.Windows.Forms.GroupBox();
			this.lblTargetLine = new System.Windows.Forms.Label();
			this.buttonThrowAndCatch = new System.Windows.Forms.Button();
			this.buttonLinear = new System.Windows.Forms.Button();
			this.buttonFlash = new System.Windows.Forms.Button();
			this.buttonEaseInEaseOut = new System.Windows.Forms.Button();
			this.buttonDecelerate = new System.Windows.Forms.Button();
			this.buttonCriticalDamp = new System.Windows.Forms.Button();
			this.buttonBounce = new System.Windows.Forms.Button();
			this.buttonAccelerate = new System.Windows.Forms.Button();
			this.buttonBackEaseOut = new System.Windows.Forms.Button();
			this.buttonSprings = new System.Windows.Forms.Button();
			this.buttonBounceEaseOut = new System.Windows.Forms.Button();
			this.buttonCircEaseOut = new System.Windows.Forms.Button();
			this.buttonCubicEaseOut = new System.Windows.Forms.Button();
			this.buttonElasticEaseOut = new System.Windows.Forms.Button();
			this.buttonExpoEaseOut = new System.Windows.Forms.Button();
			this.buttonQuadEaseOut = new System.Windows.Forms.Button();
			this.buttonQuartEaseOut = new System.Windows.Forms.Button();
			this.buttonQuintEaseOut = new System.Windows.Forms.Button();
			this.buttonSineEaseOut = new System.Windows.Forms.Button();
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
			this.cmdThrowAndCatch.Location = new System.Drawing.Point(6, 592);
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
			this.gbThrowAndCatch.Size = new System.Drawing.Size(211, 632);
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
			this.gbRipple.Size = new System.Drawing.Size(211, 259);
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
			// buttonDemo
			// 
			this.buttonDemo.Location = new System.Drawing.Point(12, 16);
			this.buttonDemo.Name = "buttonDemo";
			this.buttonDemo.Size = new System.Drawing.Size(130, 34);
			this.buttonDemo.TabIndex = 24;
			this.buttonDemo.Text = "Animate all && get back";
			this.buttonDemo.UseVisualStyleBackColor = true;
			this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
			// 
			// gpEasing
			// 
			this.gpEasing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gpEasing.Controls.Add(this.lblTargetLine);
			this.gpEasing.Controls.Add(this.buttonThrowAndCatch);
			this.gpEasing.Controls.Add(this.buttonLinear);
			this.gpEasing.Controls.Add(this.buttonFlash);
			this.gpEasing.Controls.Add(this.buttonEaseInEaseOut);
			this.gpEasing.Controls.Add(this.buttonDecelerate);
			this.gpEasing.Controls.Add(this.buttonCriticalDamp);
			this.gpEasing.Controls.Add(this.buttonBounce);
			this.gpEasing.Controls.Add(this.buttonAccelerate);
			this.gpEasing.Controls.Add(this.buttonSineEaseOut);
			this.gpEasing.Controls.Add(this.buttonQuintEaseOut);
			this.gpEasing.Controls.Add(this.buttonQuartEaseOut);
			this.gpEasing.Controls.Add(this.buttonQuadEaseOut);
			this.gpEasing.Controls.Add(this.buttonExpoEaseOut);
			this.gpEasing.Controls.Add(this.buttonElasticEaseOut);
			this.gpEasing.Controls.Add(this.buttonCubicEaseOut);
			this.gpEasing.Controls.Add(this.buttonCircEaseOut);
			this.gpEasing.Controls.Add(this.buttonBounceEaseOut);
			this.gpEasing.Controls.Add(this.buttonBackEaseOut);
			this.gpEasing.Location = new System.Drawing.Point(12, 56);
			this.gpEasing.Name = "gpEasing";
			this.gpEasing.Size = new System.Drawing.Size(559, 621);
			this.gpEasing.TabIndex = 24;
			this.gpEasing.TabStop = false;
			this.gpEasing.Text = "Easings";
			// 
			// lblTargetLine
			// 
			this.lblTargetLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTargetLine.BackColor = System.Drawing.Color.DarkGray;
			this.lblTargetLine.Location = new System.Drawing.Point(412, 16);
			this.lblTargetLine.Name = "lblTargetLine";
			this.lblTargetLine.Size = new System.Drawing.Size(1, 588);
			this.lblTargetLine.TabIndex = 26;
			// 
			// buttonThrowAndCatch
			// 
			this.buttonThrowAndCatch.Location = new System.Drawing.Point(15, 263);
			this.buttonThrowAndCatch.Name = "buttonThrowAndCatch";
			this.buttonThrowAndCatch.Size = new System.Drawing.Size(115, 23);
			this.buttonThrowAndCatch.TabIndex = 25;
			this.buttonThrowAndCatch.Text = "ThrowAndCatch";
			this.buttonThrowAndCatch.UseVisualStyleBackColor = true;
			this.buttonThrowAndCatch.Click += new System.EventHandler(this.buttonThrowAndCatch_Click);
			// 
			// buttonLinear
			// 
			this.buttonLinear.Location = new System.Drawing.Point(15, 234);
			this.buttonLinear.Name = "buttonLinear";
			this.buttonLinear.Size = new System.Drawing.Size(115, 23);
			this.buttonLinear.TabIndex = 25;
			this.buttonLinear.Text = "Linear";
			this.buttonLinear.UseVisualStyleBackColor = true;
			this.buttonLinear.Click += new System.EventHandler(this.buttonLinear_Click);
			// 
			// buttonFlash
			// 
			this.buttonFlash.Location = new System.Drawing.Point(15, 205);
			this.buttonFlash.Name = "buttonFlash";
			this.buttonFlash.Size = new System.Drawing.Size(115, 23);
			this.buttonFlash.TabIndex = 25;
			this.buttonFlash.Text = "Flash";
			this.buttonFlash.UseVisualStyleBackColor = true;
			this.buttonFlash.Click += new System.EventHandler(this.buttonFlash_Click);
			// 
			// buttonEaseInEaseOut
			// 
			this.buttonEaseInEaseOut.Location = new System.Drawing.Point(15, 176);
			this.buttonEaseInEaseOut.Name = "buttonEaseInEaseOut";
			this.buttonEaseInEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonEaseInEaseOut.TabIndex = 25;
			this.buttonEaseInEaseOut.Text = "EaseInEaseOut";
			this.buttonEaseInEaseOut.UseVisualStyleBackColor = true;
			this.buttonEaseInEaseOut.Click += new System.EventHandler(this.buttonEaseInEaseOut_Click);
			// 
			// buttonDecelerate
			// 
			this.buttonDecelerate.Location = new System.Drawing.Point(15, 147);
			this.buttonDecelerate.Name = "buttonDecelerate";
			this.buttonDecelerate.Size = new System.Drawing.Size(115, 23);
			this.buttonDecelerate.TabIndex = 25;
			this.buttonDecelerate.Text = "Decelerate";
			this.buttonDecelerate.UseVisualStyleBackColor = true;
			this.buttonDecelerate.Click += new System.EventHandler(this.buttonDecelerate_Click);
			// 
			// buttonCriticalDamp
			// 
			this.buttonCriticalDamp.Location = new System.Drawing.Point(15, 118);
			this.buttonCriticalDamp.Name = "buttonCriticalDamp";
			this.buttonCriticalDamp.Size = new System.Drawing.Size(115, 23);
			this.buttonCriticalDamp.TabIndex = 25;
			this.buttonCriticalDamp.Text = "CriticalDamp";
			this.buttonCriticalDamp.UseVisualStyleBackColor = true;
			this.buttonCriticalDamp.Click += new System.EventHandler(this.buttonCriticalDamp_Click);
			// 
			// buttonBounce
			// 
			this.buttonBounce.Location = new System.Drawing.Point(15, 89);
			this.buttonBounce.Name = "buttonBounce";
			this.buttonBounce.Size = new System.Drawing.Size(115, 23);
			this.buttonBounce.TabIndex = 25;
			this.buttonBounce.Text = "Bounce";
			this.buttonBounce.UseVisualStyleBackColor = true;
			this.buttonBounce.Click += new System.EventHandler(this.buttonBounce_Click);
			// 
			// buttonAccelerate
			// 
			this.buttonAccelerate.Location = new System.Drawing.Point(15, 60);
			this.buttonAccelerate.Name = "buttonAccelerate";
			this.buttonAccelerate.Size = new System.Drawing.Size(115, 23);
			this.buttonAccelerate.TabIndex = 25;
			this.buttonAccelerate.Text = "Accelerate";
			this.buttonAccelerate.UseVisualStyleBackColor = true;
			this.buttonAccelerate.Click += new System.EventHandler(this.buttonAccelerate_Click);
			// 
			// buttonBackEaseOut
			// 
			this.buttonBackEaseOut.Location = new System.Drawing.Point(15, 310);
			this.buttonBackEaseOut.Name = "buttonBackEaseOut";
			this.buttonBackEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonBackEaseOut.TabIndex = 25;
			this.buttonBackEaseOut.Text = "BackEaseOut";
			this.buttonBackEaseOut.UseVisualStyleBackColor = true;
			this.buttonBackEaseOut.Click += new System.EventHandler(this.buttonBackEaseOut_Click);
			// 
			// buttonSprings
			// 
			this.buttonSprings.Location = new System.Drawing.Point(0, 0);
			this.buttonSprings.Name = "buttonSprings";
			this.buttonSprings.Size = new System.Drawing.Size(75, 23);
			this.buttonSprings.TabIndex = 0;
			// 
			// buttonBounceEaseOut
			// 
			this.buttonBounceEaseOut.Location = new System.Drawing.Point(15, 339);
			this.buttonBounceEaseOut.Name = "buttonBounceEaseOut";
			this.buttonBounceEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonBounceEaseOut.TabIndex = 25;
			this.buttonBounceEaseOut.Text = "BounceEaseOut";
			this.buttonBounceEaseOut.UseVisualStyleBackColor = true;
			this.buttonBounceEaseOut.Click += new System.EventHandler(this.buttonBounceEaseOut_Click);
			// 
			// buttonCircEaseOut
			// 
			this.buttonCircEaseOut.Location = new System.Drawing.Point(15, 368);
			this.buttonCircEaseOut.Name = "buttonCircEaseOut";
			this.buttonCircEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonCircEaseOut.TabIndex = 25;
			this.buttonCircEaseOut.Text = "CircEaseOut";
			this.buttonCircEaseOut.UseVisualStyleBackColor = true;
			this.buttonCircEaseOut.Click += new System.EventHandler(this.buttonCircEaseOut_Click);
			// 
			// buttonCubicEaseOut
			// 
			this.buttonCubicEaseOut.Location = new System.Drawing.Point(15, 397);
			this.buttonCubicEaseOut.Name = "buttonCubicEaseOut";
			this.buttonCubicEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonCubicEaseOut.TabIndex = 25;
			this.buttonCubicEaseOut.Text = "CubicEaseOut";
			this.buttonCubicEaseOut.UseVisualStyleBackColor = true;
			this.buttonCubicEaseOut.Click += new System.EventHandler(this.buttonCubicEaseOut_Click);
			// 
			// buttonElasticEaseOut
			// 
			this.buttonElasticEaseOut.Location = new System.Drawing.Point(15, 426);
			this.buttonElasticEaseOut.Name = "buttonElasticEaseOut";
			this.buttonElasticEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonElasticEaseOut.TabIndex = 25;
			this.buttonElasticEaseOut.Text = "ElasticEaseOut";
			this.buttonElasticEaseOut.UseVisualStyleBackColor = true;
			this.buttonElasticEaseOut.Click += new System.EventHandler(this.buttonElasticEaseOut_Click);
			// 
			// buttonExpoEaseOut
			// 
			this.buttonExpoEaseOut.Location = new System.Drawing.Point(15, 455);
			this.buttonExpoEaseOut.Name = "buttonExpoEaseOut";
			this.buttonExpoEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonExpoEaseOut.TabIndex = 25;
			this.buttonExpoEaseOut.Text = "ExpoEaseOut";
			this.buttonExpoEaseOut.UseVisualStyleBackColor = true;
			this.buttonExpoEaseOut.Click += new System.EventHandler(this.buttonExpoEaseOut_Click);
			// 
			// buttonQuadEaseOut
			// 
			this.buttonQuadEaseOut.Location = new System.Drawing.Point(15, 484);
			this.buttonQuadEaseOut.Name = "buttonQuadEaseOut";
			this.buttonQuadEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonQuadEaseOut.TabIndex = 25;
			this.buttonQuadEaseOut.Text = "QuadEaseOut";
			this.buttonQuadEaseOut.UseVisualStyleBackColor = true;
			this.buttonQuadEaseOut.Click += new System.EventHandler(this.buttonQuadEaseOut_Click);
			// 
			// buttonQuartEaseOut
			// 
			this.buttonQuartEaseOut.Location = new System.Drawing.Point(15, 513);
			this.buttonQuartEaseOut.Name = "buttonQuartEaseOut";
			this.buttonQuartEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonQuartEaseOut.TabIndex = 25;
			this.buttonQuartEaseOut.Text = "QuartEaseOut";
			this.buttonQuartEaseOut.UseVisualStyleBackColor = true;
			this.buttonQuartEaseOut.Click += new System.EventHandler(this.buttonQuartEaseOut_Click);
			// 
			// buttonQuintEaseOut
			// 
			this.buttonQuintEaseOut.Location = new System.Drawing.Point(15, 542);
			this.buttonQuintEaseOut.Name = "buttonQuintEaseOut";
			this.buttonQuintEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonQuintEaseOut.TabIndex = 25;
			this.buttonQuintEaseOut.Text = "QuintEaseOut";
			this.buttonQuintEaseOut.UseVisualStyleBackColor = true;
			this.buttonQuintEaseOut.Click += new System.EventHandler(this.buttonQuintEaseOut_Click);
			// 
			// buttonSineEaseOut
			// 
			this.buttonSineEaseOut.Location = new System.Drawing.Point(15, 571);
			this.buttonSineEaseOut.Name = "buttonSineEaseOut";
			this.buttonSineEaseOut.Size = new System.Drawing.Size(115, 23);
			this.buttonSineEaseOut.TabIndex = 25;
			this.buttonSineEaseOut.Text = "SineEaseOut";
			this.buttonSineEaseOut.UseVisualStyleBackColor = true;
			this.buttonSineEaseOut.Click += new System.EventHandler(this.buttonSineEaseOut_Click);
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
			this.ClientSize = new System.Drawing.Size(918, 688);
			this.Controls.Add(this.gpEasing);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.cmdMore);
			this.Controls.Add(this.gbRipple);
			this.Controls.Add(this.gbThrowAndCatch);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonDemo);
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
		private System.Windows.Forms.Button buttonDemo;
		private System.Windows.Forms.GroupBox gpEasing;
		private System.Windows.Forms.Button buttonBackEaseOut;
		private System.Windows.Forms.Label lblTargetLine;
		private System.Windows.Forms.Button buttonSprings;
		private System.Windows.Forms.Button buttonLinear;
		private System.Windows.Forms.Button buttonFlash;
		private System.Windows.Forms.Button buttonEaseInEaseOut;
		private System.Windows.Forms.Button buttonDecelerate;
		private System.Windows.Forms.Button buttonCriticalDamp;
		private System.Windows.Forms.Button buttonAccelerate;
		private System.Windows.Forms.Button buttonThrowAndCatch;
		private System.Windows.Forms.Button buttonBounce;
		private System.Windows.Forms.Button buttonExpoEaseOut;
		private System.Windows.Forms.Button buttonElasticEaseOut;
		private System.Windows.Forms.Button buttonCubicEaseOut;
		private System.Windows.Forms.Button buttonCircEaseOut;
		private System.Windows.Forms.Button buttonBounceEaseOut;
		private System.Windows.Forms.Button buttonQuintEaseOut;
		private System.Windows.Forms.Button buttonQuartEaseOut;
		private System.Windows.Forms.Button buttonQuadEaseOut;
		private System.Windows.Forms.Button buttonSineEaseOut;
	}
}

