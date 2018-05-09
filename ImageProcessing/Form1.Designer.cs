namespace ImageProcessing
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
			this.buttonLoadImage = new System.Windows.Forms.Button();
			this.originalImagePictureBox = new System.Windows.Forms.PictureBox();
			this.buttonEnlightment = new System.Windows.Forms.Button();
			this.customImagePictureBox = new System.Windows.Forms.PictureBox();
			this.buttonReset = new System.Windows.Forms.Button();
			this.enlightScrollbar = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonNegative = new System.Windows.Forms.Button();
			this.negativeScrollbar = new System.Windows.Forms.HScrollBar();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonBinarization = new System.Windows.Forms.Button();
			this.binarizationScrollbar = new System.Windows.Forms.HScrollBar();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.contrastReductionButton = new System.Windows.Forms.Button();
			this.contrastReductionR1Scrollbar = new System.Windows.Forms.HScrollBar();
			this.contrastReductionR2Scrollbar = new System.Windows.Forms.HScrollBar();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.gammaCorrectionButton = new System.Windows.Forms.Button();
			this.gammaCorrectionScrollbar = new System.Windows.Forms.HScrollBar();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.SmoothingButton = new System.Windows.Forms.Button();
			this.sharpnessButton = new System.Windows.Forms.Button();
			this.gaussSmoothingButton = new System.Windows.Forms.Button();
			this.medianFilterButton = new System.Windows.Forms.Button();
			this.stohastAlignButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.originalImagePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customImagePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonLoadImage
			// 
			this.buttonLoadImage.Location = new System.Drawing.Point(12, 12);
			this.buttonLoadImage.Name = "buttonLoadImage";
			this.buttonLoadImage.Size = new System.Drawing.Size(120, 23);
			this.buttonLoadImage.TabIndex = 0;
			this.buttonLoadImage.Text = "Load Image";
			this.buttonLoadImage.UseVisualStyleBackColor = true;
			this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
			// 
			// originalImagePictureBox
			// 
			this.originalImagePictureBox.Location = new System.Drawing.Point(376, 12);
			this.originalImagePictureBox.Name = "originalImagePictureBox";
			this.originalImagePictureBox.Size = new System.Drawing.Size(100, 100);
			this.originalImagePictureBox.TabIndex = 1;
			this.originalImagePictureBox.TabStop = false;
			// 
			// buttonEnlightment
			// 
			this.buttonEnlightment.Location = new System.Drawing.Point(12, 89);
			this.buttonEnlightment.Name = "buttonEnlightment";
			this.buttonEnlightment.Size = new System.Drawing.Size(120, 23);
			this.buttonEnlightment.TabIndex = 2;
			this.buttonEnlightment.Text = "Enlightment";
			this.buttonEnlightment.UseVisualStyleBackColor = true;
			this.buttonEnlightment.Click += new System.EventHandler(this.buttonEnlightment_Click);
			// 
			// customImagePictureBox
			// 
			this.customImagePictureBox.Location = new System.Drawing.Point(482, 12);
			this.customImagePictureBox.Name = "customImagePictureBox";
			this.customImagePictureBox.Size = new System.Drawing.Size(100, 100);
			this.customImagePictureBox.TabIndex = 3;
			this.customImagePictureBox.TabStop = false;
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(12, 51);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(120, 23);
			this.buttonReset.TabIndex = 4;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// enlightScrollbar
			// 
			this.enlightScrollbar.Location = new System.Drawing.Point(183, 89);
			this.enlightScrollbar.Name = "enlightScrollbar";
			this.enlightScrollbar.Size = new System.Drawing.Size(148, 23);
			this.enlightScrollbar.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(152, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "-255";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(334, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "255";
			// 
			// buttonNegative
			// 
			this.buttonNegative.Location = new System.Drawing.Point(12, 127);
			this.buttonNegative.Name = "buttonNegative";
			this.buttonNegative.Size = new System.Drawing.Size(120, 23);
			this.buttonNegative.TabIndex = 8;
			this.buttonNegative.Text = "Negative";
			this.buttonNegative.UseVisualStyleBackColor = true;
			this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
			// 
			// negativeScrollbar
			// 
			this.negativeScrollbar.Location = new System.Drawing.Point(183, 128);
			this.negativeScrollbar.Name = "negativeScrollbar";
			this.negativeScrollbar.Size = new System.Drawing.Size(148, 22);
			this.negativeScrollbar.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(167, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(334, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "255";
			// 
			// buttonBinarization
			// 
			this.buttonBinarization.Location = new System.Drawing.Point(12, 166);
			this.buttonBinarization.Name = "buttonBinarization";
			this.buttonBinarization.Size = new System.Drawing.Size(120, 23);
			this.buttonBinarization.TabIndex = 12;
			this.buttonBinarization.Text = "Binarization";
			this.buttonBinarization.UseVisualStyleBackColor = true;
			this.buttonBinarization.Click += new System.EventHandler(this.buttonBinarization_Click);
			// 
			// binarizationScrollbar
			// 
			this.binarizationScrollbar.Location = new System.Drawing.Point(183, 166);
			this.binarizationScrollbar.Name = "binarizationScrollbar";
			this.binarizationScrollbar.Size = new System.Drawing.Size(148, 23);
			this.binarizationScrollbar.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(167, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(334, 171);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(25, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "255";
			// 
			// contrastReductionButton
			// 
			this.contrastReductionButton.Location = new System.Drawing.Point(12, 206);
			this.contrastReductionButton.Name = "contrastReductionButton";
			this.contrastReductionButton.Size = new System.Drawing.Size(120, 60);
			this.contrastReductionButton.TabIndex = 16;
			this.contrastReductionButton.Text = "ContrastReduction";
			this.contrastReductionButton.UseVisualStyleBackColor = true;
			this.contrastReductionButton.Click += new System.EventHandler(this.contrastReductionButton_Click);
			// 
			// contrastReductionR1Scrollbar
			// 
			this.contrastReductionR1Scrollbar.Location = new System.Drawing.Point(183, 206);
			this.contrastReductionR1Scrollbar.Name = "contrastReductionR1Scrollbar";
			this.contrastReductionR1Scrollbar.Size = new System.Drawing.Size(148, 23);
			this.contrastReductionR1Scrollbar.TabIndex = 17;
			// 
			// contrastReductionR2Scrollbar
			// 
			this.contrastReductionR2Scrollbar.Location = new System.Drawing.Point(183, 243);
			this.contrastReductionR2Scrollbar.Name = "contrastReductionR2Scrollbar";
			this.contrastReductionR2Scrollbar.Size = new System.Drawing.Size(148, 23);
			this.contrastReductionR2Scrollbar.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(167, 211);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(167, 248);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "0";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(334, 211);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 13);
			this.label9.TabIndex = 15;
			this.label9.Text = "255";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(334, 248);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 13);
			this.label10.TabIndex = 15;
			this.label10.Text = "255";
			// 
			// gammaCorrectionButton
			// 
			this.gammaCorrectionButton.Location = new System.Drawing.Point(12, 281);
			this.gammaCorrectionButton.Name = "gammaCorrectionButton";
			this.gammaCorrectionButton.Size = new System.Drawing.Size(120, 23);
			this.gammaCorrectionButton.TabIndex = 20;
			this.gammaCorrectionButton.Text = "GammaCorrection";
			this.gammaCorrectionButton.UseVisualStyleBackColor = true;
			this.gammaCorrectionButton.Click += new System.EventHandler(this.gammaCorrectionButton_Click);
			// 
			// gammaCorrectionScrollbar
			// 
			this.gammaCorrectionScrollbar.Location = new System.Drawing.Point(183, 281);
			this.gammaCorrectionScrollbar.Name = "gammaCorrectionScrollbar";
			this.gammaCorrectionScrollbar.Size = new System.Drawing.Size(148, 23);
			this.gammaCorrectionScrollbar.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(167, 286);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(13, 13);
			this.label11.TabIndex = 19;
			this.label11.Text = "0";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(334, 286);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(13, 13);
			this.label12.TabIndex = 15;
			this.label12.Text = "5";
			// 
			// SmoothingButton
			// 
			this.SmoothingButton.Location = new System.Drawing.Point(12, 322);
			this.SmoothingButton.Name = "SmoothingButton";
			this.SmoothingButton.Size = new System.Drawing.Size(120, 23);
			this.SmoothingButton.TabIndex = 22;
			this.SmoothingButton.Text = "Smoothing";
			this.SmoothingButton.UseVisualStyleBackColor = true;
			this.SmoothingButton.Click += new System.EventHandler(this.SmoothingButton_Click);
			// 
			// sharpnessButton
			// 
			this.sharpnessButton.Location = new System.Drawing.Point(12, 403);
			this.sharpnessButton.Name = "sharpnessButton";
			this.sharpnessButton.Size = new System.Drawing.Size(120, 23);
			this.sharpnessButton.TabIndex = 23;
			this.sharpnessButton.Text = "Sharpness";
			this.sharpnessButton.UseVisualStyleBackColor = true;
			this.sharpnessButton.Click += new System.EventHandler(this.sharpnessButton_Click);
			// 
			// gaussSmoothingButton
			// 
			this.gaussSmoothingButton.Location = new System.Drawing.Point(12, 363);
			this.gaussSmoothingButton.Name = "gaussSmoothingButton";
			this.gaussSmoothingButton.Size = new System.Drawing.Size(120, 23);
			this.gaussSmoothingButton.TabIndex = 24;
			this.gaussSmoothingButton.Text = "gaussSmoothing";
			this.gaussSmoothingButton.UseVisualStyleBackColor = true;
			this.gaussSmoothingButton.Click += new System.EventHandler(this.gaussSmoothingButton_Click);
			// 
			// medianFilterButton
			// 
			this.medianFilterButton.Location = new System.Drawing.Point(12, 443);
			this.medianFilterButton.Name = "medianFilterButton";
			this.medianFilterButton.Size = new System.Drawing.Size(120, 23);
			this.medianFilterButton.TabIndex = 25;
			this.medianFilterButton.Text = "medianFilter";
			this.medianFilterButton.UseVisualStyleBackColor = true;
			this.medianFilterButton.Click += new System.EventHandler(this.medianFilterButton_Click);
			// 
			// stohastAlignButton
			// 
			this.stohastAlignButton.Location = new System.Drawing.Point(12, 481);
			this.stohastAlignButton.Name = "stohastAlignButton";
			this.stohastAlignButton.Size = new System.Drawing.Size(120, 23);
			this.stohastAlignButton.TabIndex = 26;
			this.stohastAlignButton.Text = "stohastAlign";
			this.stohastAlignButton.UseVisualStyleBackColor = true;
			this.stohastAlignButton.Click += new System.EventHandler(this.stohastAlignButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1391, 541);
			this.Controls.Add(this.stohastAlignButton);
			this.Controls.Add(this.medianFilterButton);
			this.Controls.Add(this.gaussSmoothingButton);
			this.Controls.Add(this.sharpnessButton);
			this.Controls.Add(this.SmoothingButton);
			this.Controls.Add(this.gammaCorrectionScrollbar);
			this.Controls.Add(this.gammaCorrectionButton);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.contrastReductionR2Scrollbar);
			this.Controls.Add(this.contrastReductionR1Scrollbar);
			this.Controls.Add(this.contrastReductionButton);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.binarizationScrollbar);
			this.Controls.Add(this.buttonBinarization);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.negativeScrollbar);
			this.Controls.Add(this.buttonNegative);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.enlightScrollbar);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.customImagePictureBox);
			this.Controls.Add(this.buttonEnlightment);
			this.Controls.Add(this.originalImagePictureBox);
			this.Controls.Add(this.buttonLoadImage);
			this.Name = "Form1";
			this.Text = "ImageProcessing";
			((System.ComponentModel.ISupportInitialize)(this.originalImagePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customImagePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLoadImage;
		private System.Windows.Forms.PictureBox originalImagePictureBox;
		private System.Windows.Forms.Button buttonEnlightment;
		private System.Windows.Forms.PictureBox customImagePictureBox;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.HScrollBar enlightScrollbar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonNegative;
		private System.Windows.Forms.HScrollBar negativeScrollbar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonBinarization;
		private System.Windows.Forms.HScrollBar binarizationScrollbar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button contrastReductionButton;
		private System.Windows.Forms.HScrollBar contrastReductionR1Scrollbar;
		private System.Windows.Forms.HScrollBar contrastReductionR2Scrollbar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button gammaCorrectionButton;
		private System.Windows.Forms.HScrollBar gammaCorrectionScrollbar;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button SmoothingButton;
		private System.Windows.Forms.Button sharpnessButton;
		private System.Windows.Forms.Button gaussSmoothingButton;
		private System.Windows.Forms.Button medianFilterButton;
		private System.Windows.Forms.Button stohastAlignButton;
	}
}

