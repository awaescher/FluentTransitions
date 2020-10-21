namespace TestApp
{
    partial class Form1
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
			this.cmdBounceMe = new System.Windows.Forms.Button();
			this.cmdFlashMe = new System.Windows.Forms.Button();
			this.cmdRipple = new System.Windows.Forms.Button();
			this.cmdDropAndBounce = new System.Windows.Forms.Button();
			this.cmdThrowAndCatch = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblTextTransition2 = new System.Windows.Forms.Label();
			this.lblTextTransition1 = new System.Windows.Forms.Label();
			this.cmdTextTransition = new System.Windows.Forms.Button();
			this.gbBounce = new System.Windows.Forms.GroupBox();
			this.gbThrowAndCatch = new System.Windows.Forms.GroupBox();
			this.cmdSwap = new System.Windows.Forms.Button();
			this.ctrlChangeFormColor = new System.Windows.Forms.Button();
			this.gbRipple = new System.Windows.Forms.GroupBox();
			this.ctrlRipple = new TestApp.RippleControl();
			this.gbFlash = new System.Windows.Forms.GroupBox();
			this.gbDropAndBounce = new System.Windows.Forms.GroupBox();
			this.cmdMore = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdSwapPictures = new System.Windows.Forms.Button();
			this.ctrlPictures = new TestApp.KittenPuppyControl();
			this.groupBox1.SuspendLayout();
			this.gbBounce.SuspendLayout();
			this.gbThrowAndCatch.SuspendLayout();
			this.gbRipple.SuspendLayout();
			this.gbFlash.SuspendLayout();
			this.gbDropAndBounce.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdBounceMe
			// 
			this.cmdBounceMe.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cmdBounceMe.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.cmdBounceMe.Location = new System.Drawing.Point(9, 29);
			this.cmdBounceMe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmdBounceMe.Name = "cmdBounceMe";
			this.cmdBounceMe.Size = new System.Drawing.Size(298, 52);
			this.cmdBounceMe.TabIndex = 5;
			this.cmdBounceMe.Text = "Bounce Me!";
			this.cmdBounceMe.UseVisualStyleBackColor = false;
			this.cmdBounceMe.Click += new System.EventHandler(this.cmdBounceMe_Click);
			// 
			// cmdFlashMe
			// 
			this.cmdFlashMe.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.cmdFlashMe.Location = new System.Drawing.Point(9, 29);
			this.cmdFlashMe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmdFlashMe.Name = "cmdFlashMe";
			this.cmdFlashMe.Size = new System.Drawing.Size(290, 57);
			this.cmdFlashMe.TabIndex = 6;
			this.cmdFlashMe.Text = "Flash Me!";
			this.cmdFlashMe.UseVisualStyleBackColor = false;
			this.cmdFlashMe.Click += new System.EventHandler(this.cmdFlashMe_Click);
			// 
			// cmdRipple
			// 
			this.cmdRipple.Location = new System.Drawing.Point(9, 29);
			this.cmdRipple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmdRipple.Name = "cmdRipple";
			this.cmdRipple.Size = new System.Drawing.Size(290, 57);
			this.cmdRipple.TabIndex = 9;
			this.cmdRipple.Text = "Ripple";
			this.cmdRipple.UseVisualStyleBackColor = true;
			this.cmdRipple.Click += new System.EventHandler(this.cmdRipple_Click);
			// 
			// cmdDropAndBounce
			// 
			this.cmdDropAndBounce.Location = new System.Drawing.Point(9, 29);
			this.cmdDropAndBounce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmdDropAndBounce.Name = "cmdDropAndBounce";
			this.cmdDropAndBounce.Size = new System.Drawing.Size(290, 57);
			this.cmdDropAndBounce.TabIndex = 10;
			this.cmdDropAndBounce.Text = "Drop and bounce";
			this.cmdDropAndBounce.UseVisualStyleBackColor = true;
			this.cmdDropAndBounce.Click += new System.EventHandler(this.cmdDropAndBounce_Click);
			// 
			// cmdThrowAndCatch
			// 
			this.cmdThrowAndCatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdThrowAndCatch.Location = new System.Drawing.Point(9, 731);
			this.cmdThrowAndCatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmdThrowAndCatch.Name = "cmdThrowAndCatch";
			this.cmdThrowAndCatch.Size = new System.Drawing.Size(298, 52);
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
			this.groupBox1.Location = new System.Drawing.Point(344, 611);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(316, 155);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Text transition";
			// 
			// lblTextTransition2
			// 
			this.lblTextTransition2.AutoSize = true;
			this.lblTextTransition2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTextTransition2.ForeColor = System.Drawing.Color.Crimson;
			this.lblTextTransition2.Location = new System.Drawing.Point(10, 115);
			this.lblTextTransition2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTextTransition2.Name = "lblTextTransition2";
			this.lblTextTransition2.Size = new System.Drawing.Size(286, 22);
			this.lblTextTransition2.TabIndex = 15;
			this.lblTextTransition2.Text = "A longer piece of text.";
			// 
			// lblTextTransition1
			// 
			this.lblTextTransition1.AutoSize = true;
			this.lblTextTransition1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTextTransition1.ForeColor = System.Drawing.Color.Blue;
			this.lblTextTransition1.Location = new System.Drawing.Point(9, 91);
			this.lblTextTransition1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTextTransition1.Name = "lblTextTransition1";
			this.lblTextTransition1.Size = new System.Drawing.Size(166, 22);
			this.lblTextTransition1.TabIndex = 14;
			this.lblTextTransition1.Text = "Hello, World!";
			// 
			// cmdTextTransition
			// 
			this.cmdTextTransition.Location = new System.Drawing.Point(9, 29);
			this.cmdTextTransition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmdTextTransition.Name = "cmdTextTransition";
			this.cmdTextTransition.Size = new System.Drawing.Size(290, 57);
			this.cmdTextTransition.TabIndex = 13;
			this.cmdTextTransition.Text = "Text Transition";
			this.cmdTextTransition.UseVisualStyleBackColor = true;
			this.cmdTextTransition.Click += new System.EventHandler(this.cmdTextTransition_Click);
			// 
			// gbBounce
			// 
			this.gbBounce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gbBounce.Controls.Add(this.cmdBounceMe);
			this.gbBounce.Location = new System.Drawing.Point(18, 77);
			this.gbBounce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbBounce.Name = "gbBounce";
			this.gbBounce.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbBounce.Size = new System.Drawing.Size(316, 792);
			this.gbBounce.TabIndex = 14;
			this.gbBounce.TabStop = false;
			this.gbBounce.Text = "Bounce";
			// 
			// gbThrowAndCatch
			// 
			this.gbThrowAndCatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gbThrowAndCatch.Controls.Add(this.cmdThrowAndCatch);
			this.gbThrowAndCatch.Location = new System.Drawing.Point(-316, 77);
			this.gbThrowAndCatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbThrowAndCatch.Name = "gbThrowAndCatch";
			this.gbThrowAndCatch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbThrowAndCatch.Size = new System.Drawing.Size(316, 792);
			this.gbThrowAndCatch.TabIndex = 15;
			this.gbThrowAndCatch.TabStop = false;
			this.gbThrowAndCatch.Text = "Throw and Catch";
			// 
			// cmdSwap
			// 
			this.cmdSwap.Location = new System.Drawing.Point(18, 15);
			this.cmdSwap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmdSwap.Name = "cmdSwap";
			this.cmdSwap.Size = new System.Drawing.Size(124, 52);
			this.cmdSwap.TabIndex = 16;
			this.cmdSwap.Text = "« Swap";
			this.cmdSwap.UseVisualStyleBackColor = true;
			this.cmdSwap.Click += new System.EventHandler(this.cmdSwap_Click);
			// 
			// ctrlChangeFormColor
			// 
			this.ctrlChangeFormColor.Location = new System.Drawing.Point(152, 15);
			this.ctrlChangeFormColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctrlChangeFormColor.Name = "ctrlChangeFormColor";
			this.ctrlChangeFormColor.Size = new System.Drawing.Size(183, 52);
			this.ctrlChangeFormColor.TabIndex = 17;
			this.ctrlChangeFormColor.Text = "Change Form Color";
			this.ctrlChangeFormColor.UseVisualStyleBackColor = true;
			this.ctrlChangeFormColor.Click += new System.EventHandler(this.ctrlChangeFormColor_Click);
			// 
			// gbRipple
			// 
			this.gbRipple.Controls.Add(this.cmdRipple);
			this.gbRipple.Controls.Add(this.ctrlRipple);
			this.gbRipple.Location = new System.Drawing.Point(344, 77);
			this.gbRipple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbRipple.Name = "gbRipple";
			this.gbRipple.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbRipple.Size = new System.Drawing.Size(316, 325);
			this.gbRipple.TabIndex = 18;
			this.gbRipple.TabStop = false;
			this.gbRipple.Text = "Ripple";
			// 
			// ctrlRipple
			// 
			this.ctrlRipple.Location = new System.Drawing.Point(9, 95);
			this.ctrlRipple.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.ctrlRipple.Name = "ctrlRipple";
			this.ctrlRipple.Size = new System.Drawing.Size(290, 215);
			this.ctrlRipple.TabIndex = 8;
			// 
			// gbFlash
			// 
			this.gbFlash.Controls.Add(this.cmdFlashMe);
			this.gbFlash.Location = new System.Drawing.Point(344, 775);
			this.gbFlash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbFlash.Name = "gbFlash";
			this.gbFlash.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbFlash.Size = new System.Drawing.Size(316, 94);
			this.gbFlash.TabIndex = 19;
			this.gbFlash.TabStop = false;
			this.gbFlash.Text = "Flash the Button";
			// 
			// gbDropAndBounce
			// 
			this.gbDropAndBounce.Controls.Add(this.cmdDropAndBounce);
			this.gbDropAndBounce.Location = new System.Drawing.Point(669, 77);
			this.gbDropAndBounce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbDropAndBounce.Name = "gbDropAndBounce";
			this.gbDropAndBounce.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbDropAndBounce.Size = new System.Drawing.Size(784, 792);
			this.gbDropAndBounce.TabIndex = 20;
			this.gbDropAndBounce.TabStop = false;
			this.gbDropAndBounce.Text = "Drop and Bounce";
			// 
			// cmdMore
			// 
			this.cmdMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdMore.Location = new System.Drawing.Point(540, 15);
			this.cmdMore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmdMore.Name = "cmdMore";
			this.cmdMore.Size = new System.Drawing.Size(120, 52);
			this.cmdMore.TabIndex = 21;
			this.cmdMore.Text = "More »";
			this.cmdMore.UseVisualStyleBackColor = true;
			this.cmdMore.Click += new System.EventHandler(this.cmdMore_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmdSwapPictures);
			this.groupBox2.Controls.Add(this.ctrlPictures);
			this.groupBox2.Location = new System.Drawing.Point(344, 411);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Size = new System.Drawing.Size(316, 191);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Picture transition";
			// 
			// cmdSwapPictures
			// 
			this.cmdSwapPictures.Location = new System.Drawing.Point(15, 29);
			this.cmdSwapPictures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmdSwapPictures.Name = "cmdSwapPictures";
			this.cmdSwapPictures.Size = new System.Drawing.Size(110, 138);
			this.cmdSwapPictures.TabIndex = 1;
			this.cmdSwapPictures.Text = "Swap Pictures";
			this.cmdSwapPictures.UseVisualStyleBackColor = true;
			this.cmdSwapPictures.Click += new System.EventHandler(this.cmdSwapPictures_Click);
			// 
			// ctrlPictures
			// 
			this.ctrlPictures.Location = new System.Drawing.Point(142, 29);
			this.ctrlPictures.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.ctrlPictures.Name = "ctrlPictures";
			this.ctrlPictures.Size = new System.Drawing.Size(154, 138);
			this.ctrlPictures.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(668, 878);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.cmdMore);
			this.Controls.Add(this.gbDropAndBounce);
			this.Controls.Add(this.gbFlash);
			this.Controls.Add(this.gbRipple);
			this.Controls.Add(this.ctrlChangeFormColor);
			this.Controls.Add(this.cmdSwap);
			this.Controls.Add(this.gbThrowAndCatch);
			this.Controls.Add(this.gbBounce);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Transitions TestApp";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbBounce.ResumeLayout(false);
			this.gbThrowAndCatch.ResumeLayout(false);
			this.gbRipple.ResumeLayout(false);
			this.gbFlash.ResumeLayout(false);
			this.gbDropAndBounce.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBounceMe;
        private System.Windows.Forms.Button cmdFlashMe;
        private RippleControl ctrlRipple;
        private System.Windows.Forms.Button cmdRipple;
        private System.Windows.Forms.Button cmdDropAndBounce;
        private System.Windows.Forms.Button cmdThrowAndCatch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTextTransition2;
        private System.Windows.Forms.Label lblTextTransition1;
        private System.Windows.Forms.Button cmdTextTransition;
        private System.Windows.Forms.GroupBox gbBounce;
        private System.Windows.Forms.GroupBox gbThrowAndCatch;
        private System.Windows.Forms.Button cmdSwap;
        private System.Windows.Forms.Button ctrlChangeFormColor;
        private System.Windows.Forms.GroupBox gbRipple;
        private System.Windows.Forms.GroupBox gbFlash;
        private System.Windows.Forms.GroupBox gbDropAndBounce;
        private System.Windows.Forms.Button cmdMore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdSwapPictures;
        private KittenPuppyControl ctrlPictures;
    }
}

