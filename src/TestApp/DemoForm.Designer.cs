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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
			this.cmdRipple = new System.Windows.Forms.Button();
			this.cmdThrowAndCatch = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblTextTransition2 = new System.Windows.Forms.Label();
			this.lblTextTransition1 = new System.Windows.Forms.Label();
			this.cmdTextTransition = new System.Windows.Forms.Button();
			this.gbThrowAndCatch = new System.Windows.Forms.GroupBox();
			this.gbRipple = new System.Windows.Forms.GroupBox();
			this.ctrlRipple = new TestApp.RippleControl();
			this.cmdMore = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdSwapPictures = new System.Windows.Forms.Button();
			this.ctrlPictures = new TestApp.KittenPuppyControl();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.buttonDemo = new System.Windows.Forms.Button();
			this.gpEasing = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonThrowAndCatch = new System.Windows.Forms.Button();
			this.buttonLinear = new System.Windows.Forms.Button();
			this.buttonFlash = new System.Windows.Forms.Button();
			this.buttonEaseInEaseOut = new System.Windows.Forms.Button();
			this.buttonDecelerate = new System.Windows.Forms.Button();
			this.buttonCriticalDamp = new System.Windows.Forms.Button();
			this.buttonBounce = new System.Windows.Forms.Button();
			this.buttonAccelerate = new System.Windows.Forms.Button();
			this.buttonSineEaseOut = new System.Windows.Forms.Button();
			this.buttonQuintEaseOut = new System.Windows.Forms.Button();
			this.buttonQuartEaseOut = new System.Windows.Forms.Button();
			this.buttonQuadEaseOut = new System.Windows.Forms.Button();
			this.buttonExpoEaseOut = new System.Windows.Forms.Button();
			this.buttonElasticEaseOut = new System.Windows.Forms.Button();
			this.buttonCubicEaseOut = new System.Windows.Forms.Button();
			this.buttonCircEaseOut = new System.Windows.Forms.Button();
			this.buttonBounceEaseOut = new System.Windows.Forms.Button();
			this.buttonBackEaseOut = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblTargetLine = new System.Windows.Forms.Label();
			this.buttonSprings = new System.Windows.Forms.Button();
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
			this.cmdRipple.Location = new System.Drawing.Point(9, 29);
			this.cmdRipple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmdRipple.Name = "cmdRipple";
			this.cmdRipple.Size = new System.Drawing.Size(290, 57);
			this.cmdRipple.TabIndex = 9;
			this.cmdRipple.Text = "Ripple";
			this.cmdRipple.UseVisualStyleBackColor = true;
			this.cmdRipple.Click += new System.EventHandler(this.cmdRipple_Click);
			// 
			// cmdThrowAndCatch
			// 
			this.cmdThrowAndCatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdThrowAndCatch.Location = new System.Drawing.Point(9, 1226);
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
			this.groupBox1.Location = new System.Drawing.Point(949, 478);
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
			// gbThrowAndCatch
			// 
			this.gbThrowAndCatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gbThrowAndCatch.Controls.Add(this.cmdThrowAndCatch);
			this.gbThrowAndCatch.Location = new System.Drawing.Point(-316, 77);
			this.gbThrowAndCatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbThrowAndCatch.Name = "gbThrowAndCatch";
			this.gbThrowAndCatch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbThrowAndCatch.Size = new System.Drawing.Size(316, 1287);
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
			this.gbRipple.Location = new System.Drawing.Point(949, 643);
			this.gbRipple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbRipple.Name = "gbRipple";
			this.gbRipple.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbRipple.Size = new System.Drawing.Size(316, 713);
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
			// cmdMore
			// 
			this.cmdMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdMore.Location = new System.Drawing.Point(1242, 25);
			this.cmdMore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmdMore.Name = "cmdMore";
			this.cmdMore.Size = new System.Drawing.Size(120, 41);
			this.cmdMore.TabIndex = 21;
			this.cmdMore.Text = "More »";
			this.cmdMore.UseVisualStyleBackColor = true;
			this.cmdMore.Click += new System.EventHandler(this.cmdMore_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmdSwapPictures);
			this.groupBox2.Controls.Add(this.ctrlPictures);
			this.groupBox2.Location = new System.Drawing.Point(949, 278);
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.txtPassword);
			this.groupBox3.Location = new System.Drawing.Point(949, 86);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox3.Size = new System.Drawing.Size(316, 183);
			this.groupBox3.TabIndex = 23;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "macOS like password box";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 55);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Enter the secret password\r\nand hit [Return]";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(40, 112);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '●';
			this.txtPassword.Size = new System.Drawing.Size(235, 26);
			this.txtPassword.TabIndex = 0;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			// 
			// buttonDemo
			// 
			this.buttonDemo.Location = new System.Drawing.Point(18, 25);
			this.buttonDemo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDemo.Name = "buttonDemo";
			this.buttonDemo.Size = new System.Drawing.Size(195, 41);
			this.buttonDemo.TabIndex = 24;
			this.buttonDemo.Text = "Animate all && get back";
			this.buttonDemo.UseVisualStyleBackColor = true;
			this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
			// 
			// gpEasing
			// 
			this.gpEasing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gpEasing.Controls.Add(this.label9);
			this.gpEasing.Controls.Add(this.label8);
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
			this.gpEasing.Controls.Add(this.label5);
			this.gpEasing.Controls.Add(this.label3);
			this.gpEasing.Controls.Add(this.label2);
			this.gpEasing.Controls.Add(this.label7);
			this.gpEasing.Controls.Add(this.lblTargetLine);
			this.gpEasing.Controls.Add(this.label6);
			this.gpEasing.Controls.Add(this.label4);
			this.gpEasing.Location = new System.Drawing.Point(18, 86);
			this.gpEasing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gpEasing.Name = "gpEasing";
			this.gpEasing.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gpEasing.Size = new System.Drawing.Size(923, 1270);
			this.gpEasing.TabIndex = 24;
			this.gpEasing.TabStop = false;
			this.gpEasing.Text = "Animation showcase";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.BackColor = System.Drawing.Color.NavajoWhite;
			this.label9.Location = new System.Drawing.Point(19, 484);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(8, 772);
			this.label9.TabIndex = 32;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label8.Location = new System.Drawing.Point(19, 46);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(8, 405);
			this.label8.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(224, 650);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 20);
			this.label6.TabIndex = 30;
			this.label6.Text = "= Rubber band";
			// 
			// buttonThrowAndCatch
			// 
			this.buttonThrowAndCatch.Location = new System.Drawing.Point(44, 416);
			this.buttonThrowAndCatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThrowAndCatch.Name = "buttonThrowAndCatch";
			this.buttonThrowAndCatch.Size = new System.Drawing.Size(172, 35);
			this.buttonThrowAndCatch.TabIndex = 25;
			this.buttonThrowAndCatch.Text = "ThrowAndCatch";
			this.buttonThrowAndCatch.UseVisualStyleBackColor = true;
			this.buttonThrowAndCatch.Click += new System.EventHandler(this.buttonThrowAndCatch_Click);
			// 
			// buttonLinear
			// 
			this.buttonLinear.Location = new System.Drawing.Point(44, 371);
			this.buttonLinear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonLinear.Name = "buttonLinear";
			this.buttonLinear.Size = new System.Drawing.Size(172, 35);
			this.buttonLinear.TabIndex = 25;
			this.buttonLinear.Text = "Linear";
			this.buttonLinear.UseVisualStyleBackColor = true;
			this.buttonLinear.Click += new System.EventHandler(this.buttonLinear_Click);
			// 
			// buttonFlash
			// 
			this.buttonFlash.Location = new System.Drawing.Point(44, 326);
			this.buttonFlash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonFlash.Name = "buttonFlash";
			this.buttonFlash.Size = new System.Drawing.Size(172, 35);
			this.buttonFlash.TabIndex = 25;
			this.buttonFlash.Text = "Flash";
			this.buttonFlash.UseVisualStyleBackColor = true;
			this.buttonFlash.Click += new System.EventHandler(this.buttonFlash_Click);
			// 
			// buttonEaseInEaseOut
			// 
			this.buttonEaseInEaseOut.Location = new System.Drawing.Point(44, 282);
			this.buttonEaseInEaseOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonEaseInEaseOut.Name = "buttonEaseInEaseOut";
			this.buttonEaseInEaseOut.Size = new System.Drawing.Size(172, 35);
			this.buttonEaseInEaseOut.TabIndex = 25;
			this.buttonEaseInEaseOut.Text = "EaseInEaseOut";
			this.buttonEaseInEaseOut.UseVisualStyleBackColor = true;
			this.buttonEaseInEaseOut.Click += new System.EventHandler(this.buttonEaseInEaseOut_Click);
			// 
			// buttonDecelerate
			// 
			this.buttonDecelerate.Location = new System.Drawing.Point(44, 237);
			this.buttonDecelerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDecelerate.Name = "buttonDecelerate";
			this.buttonDecelerate.Size = new System.Drawing.Size(172, 35);
			this.buttonDecelerate.TabIndex = 25;
			this.buttonDecelerate.Text = "Decelerate";
			this.buttonDecelerate.UseVisualStyleBackColor = true;
			this.buttonDecelerate.Click += new System.EventHandler(this.buttonDecelerate_Click);
			// 
			// buttonCriticalDamp
			// 
			this.buttonCriticalDamp.Location = new System.Drawing.Point(44, 193);
			this.buttonCriticalDamp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCriticalDamp.Name = "buttonCriticalDamp";
			this.buttonCriticalDamp.Size = new System.Drawing.Size(172, 35);
			this.buttonCriticalDamp.TabIndex = 25;
			this.buttonCriticalDamp.Text = "CriticalDamp";
			this.buttonCriticalDamp.UseVisualStyleBackColor = true;
			this.buttonCriticalDamp.Click += new System.EventHandler(this.buttonCriticalDamp_Click);
			// 
			// buttonBounce
			// 
			this.buttonBounce.Location = new System.Drawing.Point(44, 148);
			this.buttonBounce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBounce.Name = "buttonBounce";
			this.buttonBounce.Size = new System.Drawing.Size(172, 35);
			this.buttonBounce.TabIndex = 25;
			this.buttonBounce.Text = "Bounce";
			this.buttonBounce.UseVisualStyleBackColor = true;
			this.buttonBounce.Click += new System.EventHandler(this.buttonBounce_Click);
			// 
			// buttonAccelerate
			// 
			this.buttonAccelerate.Location = new System.Drawing.Point(44, 103);
			this.buttonAccelerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAccelerate.Name = "buttonAccelerate";
			this.buttonAccelerate.Size = new System.Drawing.Size(172, 35);
			this.buttonAccelerate.TabIndex = 25;
			this.buttonAccelerate.Text = "Accelerate";
			this.buttonAccelerate.UseVisualStyleBackColor = true;
			this.buttonAccelerate.Click += new System.EventHandler(this.buttonAccelerate_Click);
			// 
			// buttonSineEaseOut
			// 
			this.buttonSineEaseOut.Location = new System.Drawing.Point(44, 1044);
			this.buttonSineEaseOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSineEaseOut.Name = "buttonSineEaseOut";
			this.buttonSineEaseOut.Size = new System.Drawing.Size(172, 35);
			this.buttonSineEaseOut.TabIndex = 25;
			this.buttonSineEaseOut.Text = "SineEaseOut";
			this.buttonSineEaseOut.UseVisualStyleBackColor = true;
			this.buttonSineEaseOut.Click += new System.EventHandler(this.buttonSineEaseOut_Click);
			// 
			// buttonQuintEaseOut
			// 
			this.buttonQuintEaseOut.Location = new System.Drawing.Point(44, 1000);
			this.buttonQuintEaseOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonQuintEaseOut.Name = "buttonQuintEaseOut";
			this.buttonQuintEaseOut.Size = new System.Drawing.Size(172, 35);
			this.buttonQuintEaseOut.TabIndex = 25;
			this.buttonQuintEaseOut.Text = "QuintEaseOut";
			this.buttonQuintEaseOut.UseVisualStyleBackColor = true;
			this.buttonQuintEaseOut.Click += new System.EventHandler(this.buttonQuintEaseOut_Click);
			// 
			// buttonQuartEaseOut
			// 
			this.buttonQuartEaseOut.Location = new System.Drawing.Point(44, 955);
			this.buttonQuartEaseOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonQuartEaseOut.Name = "buttonQuartEaseOut";
			this.buttonQuartEaseOut.Size = new System.Drawing.Size(172, 35);
			this.buttonQuartEaseOut.TabIndex = 25;
			this.buttonQuartEaseOut.Text = "QuartEaseOut";
			this.buttonQuartEaseOut.UseVisualStyleBackColor = true;
			this.buttonQuartEaseOut.Click += new System.EventHandler(this.buttonQuartEaseOut_Click);
			// 
			// buttonQuadEaseOut
			// 
			this.buttonQuadEaseOut.Location = new System.Drawing.Point(44, 911);
			this.buttonQuadEaseOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonQuadEaseOut.Name = "buttonQuadEaseOut";
			this.buttonQuadEaseOut.Size = new System.Drawing.Size(172, 35);
			this.buttonQuadEaseOut.TabIndex = 25;
			this.buttonQuadEaseOut.Text = "QuadEaseOut";
			this.buttonQuadEaseOut.UseVisualStyleBackColor = true;
			this.buttonQuadEaseOut.Click += new System.EventHandler(this.buttonQuadEaseOut_Click);
			// 
			// buttonExpoEaseOut
			// 
			this.buttonExpoEaseOut.Location = new System.Drawing.Point(44, 866);
			this.buttonExpoEaseOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonExpoEaseOut.Name = "buttonExpoEaseOut";
			this.buttonExpoEaseOut.Size = new System.Drawing.Size(172, 35);
			this.buttonExpoEaseOut.TabIndex = 25;
			this.buttonExpoEaseOut.Text = "ExpoEaseOut";
			this.buttonExpoEaseOut.UseVisualStyleBackColor = true;
			this.buttonExpoEaseOut.Click += new System.EventHandler(this.buttonExpoEaseOut_Click);
			// 
			// buttonElasticEaseOut
			// 
			this.buttonElasticEaseOut.Location = new System.Drawing.Point(44, 821);
			this.buttonElasticEaseOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonElasticEaseOut.Name = "buttonElasticEaseOut";
			this.buttonElasticEaseOut.Size = new System.Drawing.Size(172, 35);
			this.buttonElasticEaseOut.TabIndex = 25;
			this.buttonElasticEaseOut.Text = "ElasticEaseOut";
			this.buttonElasticEaseOut.UseVisualStyleBackColor = true;
			this.buttonElasticEaseOut.Click += new System.EventHandler(this.buttonElasticEaseOut_Click);
			// 
			// buttonCubicEaseOut
			// 
			this.buttonCubicEaseOut.Location = new System.Drawing.Point(44, 777);
			this.buttonCubicEaseOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCubicEaseOut.Name = "buttonCubicEaseOut";
			this.buttonCubicEaseOut.Size = new System.Drawing.Size(172, 35);
			this.buttonCubicEaseOut.TabIndex = 25;
			this.buttonCubicEaseOut.Text = "CubicEaseOut";
			this.buttonCubicEaseOut.UseVisualStyleBackColor = true;
			this.buttonCubicEaseOut.Click += new System.EventHandler(this.buttonCubicEaseOut_Click);
			// 
			// buttonCircEaseOut
			// 
			this.buttonCircEaseOut.Location = new System.Drawing.Point(44, 732);
			this.buttonCircEaseOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCircEaseOut.Name = "buttonCircEaseOut";
			this.buttonCircEaseOut.Size = new System.Drawing.Size(172, 35);
			this.buttonCircEaseOut.TabIndex = 25;
			this.buttonCircEaseOut.Text = "CircEaseOut";
			this.buttonCircEaseOut.UseVisualStyleBackColor = true;
			this.buttonCircEaseOut.Click += new System.EventHandler(this.buttonCircEaseOut_Click);
			// 
			// buttonBounceEaseOut
			// 
			this.buttonBounceEaseOut.Location = new System.Drawing.Point(44, 688);
			this.buttonBounceEaseOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBounceEaseOut.Name = "buttonBounceEaseOut";
			this.buttonBounceEaseOut.Size = new System.Drawing.Size(172, 35);
			this.buttonBounceEaseOut.TabIndex = 25;
			this.buttonBounceEaseOut.Text = "BounceEaseOut";
			this.buttonBounceEaseOut.UseVisualStyleBackColor = true;
			this.buttonBounceEaseOut.Click += new System.EventHandler(this.buttonBounceEaseOut_Click);
			// 
			// buttonBackEaseOut
			// 
			this.buttonBackEaseOut.Location = new System.Drawing.Point(44, 643);
			this.buttonBackEaseOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBackEaseOut.Name = "buttonBackEaseOut";
			this.buttonBackEaseOut.Size = new System.Drawing.Size(172, 35);
			this.buttonBackEaseOut.TabIndex = 25;
			this.buttonBackEaseOut.Text = "BackEaseOut";
			this.buttonBackEaseOut.UseVisualStyleBackColor = true;
			this.buttonBackEaseOut.Click += new System.EventHandler(this.buttonBackEaseOut_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 1096);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(654, 160);
			this.label5.TabIndex = 29;
			this.label5.Text = resources.GetString("label5.Text");
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(224, 828);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 20);
			this.label4.TabIndex = 28;
			this.label4.Text = "= Spring";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 483);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(756, 140);
			this.label3.TabIndex = 27;
			this.label3.Text = resources.GetString("label3.Text");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 46);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(838, 40);
			this.label2.TabIndex = 2;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.BackColor = System.Drawing.Color.DarkGray;
			this.label7.Location = new System.Drawing.Point(619, 643);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(1, 436);
			this.label7.TabIndex = 26;
			// 
			// lblTargetLine
			// 
			this.lblTargetLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTargetLine.BackColor = System.Drawing.Color.DarkGray;
			this.lblTargetLine.Location = new System.Drawing.Point(619, 103);
			this.lblTargetLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTargetLine.Name = "lblTargetLine";
			this.lblTargetLine.Size = new System.Drawing.Size(1, 348);
			this.lblTargetLine.TabIndex = 26;
			// 
			// buttonSprings
			// 
			this.buttonSprings.Location = new System.Drawing.Point(0, 0);
			this.buttonSprings.Name = "buttonSprings";
			this.buttonSprings.Size = new System.Drawing.Size(75, 23);
			this.buttonSprings.TabIndex = 0;
			// 
			// DemoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1377, 1373);
			this.Controls.Add(this.gpEasing);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.cmdMore);
			this.Controls.Add(this.gbRipple);
			this.Controls.Add(this.gbThrowAndCatch);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonDemo);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "DemoForm";
			this.Text = "FluentTransitions TestApp";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbThrowAndCatch.ResumeLayout(false);
			this.gbRipple.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.gpEasing.ResumeLayout(false);
			this.gpEasing.PerformLayout();
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
	}
}

