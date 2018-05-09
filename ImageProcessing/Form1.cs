using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
	public partial class Form1 : Form
	{
		private Bitmap image;
		private Bitmap customImage;

		public Form1()
		{
			InitializeComponent();
			this.enlightScrollbar.Minimum = -255;
			this.enlightScrollbar.Maximum = 255;

			this.negativeScrollbar.Minimum = 0;
			this.negativeScrollbar.Maximum = 255;

			this.contrastReductionR1Scrollbar.Minimum = 0;
			this.contrastReductionR1Scrollbar.Maximum = 255;

			this.contrastReductionR2Scrollbar.Minimum = 0;
			this.contrastReductionR2Scrollbar.Maximum = 255;

			this.gammaCorrectionScrollbar.Minimum = 0;
			this.gammaCorrectionScrollbar.Maximum = 500; // from 0.00 to 5
		}

		private void buttonLoadImage_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Title = "Choose an image";
				dlg.Filter = "Image files | *.bmp;*.jpg;*.png";

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					image = new Bitmap(dlg.FileName);
					this.originalImagePictureBox.Size = new Size(image.Width, image.Height);
					this.originalImagePictureBox.Image = image;

					int x = this.originalImagePictureBox.Location.X;
					int y = this.originalImagePictureBox.Location.Y;
					int margin = 10;

					this.customImage = new Bitmap(image);
					this.customImagePictureBox.Location = new Point(x + image.Width + margin, y);
					this.customImagePictureBox.Size = new Size(customImage.Width, customImage.Height);
					this.customImagePictureBox.Image = this.customImage;
				}
			}
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			this.customImage = new Bitmap(this.image);
			this.customImagePictureBox.Image = this.customImage;
		}

		private void buttonEnlightment_Click(object sender, EventArgs e)
		{
			int enlightRate = this.enlightScrollbar.Value;
			for (int i = 0; i < customImage.Width; i++)
			{
				for (int j = 0; j < customImage.Height; j++)
				{
					Color pixel = this.customImage.GetPixel(i, j);
					this.customImage.SetPixel(i, j, Color.FromArgb(
						Math.Max(0, Math.Min(pixel.R + enlightRate, 255)),
						Math.Max(0, Math.Min(pixel.G + enlightRate, 255)),
						Math.Max(0, Math.Min(pixel.B + enlightRate, 255))
					));

				}
			}
			this.customImagePictureBox.Image = this.customImage;
		}

		private void buttonNegative_Click(object sender, EventArgs e)
		{
			int negativeRate = this.negativeScrollbar.Value;
			for (int i = 0; i < customImage.Width; i++)
			{
				for (int j = 0; j < customImage.Height; j++)
				{
					Color pixel = this.customImage.GetPixel(i, j);
					int r = pixel.R > negativeRate ? Math.Max(0, 255 - pixel.R) : pixel.R;
					int g = pixel.G > negativeRate ? Math.Max(0, 255 - pixel.G) : pixel.G;
					int b = pixel.B > negativeRate ? Math.Max(0, 255 - pixel.B) : pixel.B;

					this.customImage.SetPixel(i, j, Color.FromArgb(r, g, b));
				}
			}
			this.customImagePictureBox.Image = this.customImage;
		}

		private void buttonBinarization_Click(object sender, EventArgs e)
		{
			int binarizationRate = this.binarizationScrollbar.Value;
			for (int i = 0; i < customImage.Width; i++)
			{
				for (int j = 0; j < customImage.Height; j++)
				{
					Color pixel = this.customImage.GetPixel(i, j);
					int greyPixel = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
					int binaryPixel = greyPixel < binarizationRate ? 0 : 255;
					this.customImage.SetPixel(i, j, Color.FromArgb(binaryPixel, binaryPixel, binaryPixel));
				}
			}
			this.customImagePictureBox.Image = this.customImage;
		}

		private int contrastColorGeneration(int r1, int r2, int color)
		{
			return r1 + color * (r2 - r1) / 255;
		}
		private void contrastReductionButton_Click(object sender, EventArgs e)
		{
			int r1 = this.contrastReductionR1Scrollbar.Value;
			int r2 = this.contrastReductionR2Scrollbar.Value;

			if (r1 >= r2)
			{
				return;
			}

			for (int i = 0; i < customImage.Width; i++)
			{
				for (int j = 0; j < customImage.Height; j++)
				{
					Color pixel = this.customImage.GetPixel(i, j);
					int r = contrastColorGeneration(r1, r2, pixel.R);
					int g = contrastColorGeneration(r1, r2, pixel.G);
					int b = contrastColorGeneration(r1, r2, pixel.B);
					this.customImage.SetPixel(i, j, Color.FromArgb(r, g, b));
				}
			}
			this.customImagePictureBox.Image = this.customImage;
		}

		private int gammaCorrectionColor(double gamma, double color)
		{
			return (int)(255 * Math.Pow(color / 255, gamma));
		}
		private void gammaCorrectionButton_Click(object sender, EventArgs e)
		{
			double gamma = (double)this.gammaCorrectionScrollbar.Value / 100;
			for (int i = 0; i < customImage.Width; i++)
			{
				for (int j = 0; j < customImage.Height; j++)
				{
					Color pixel = this.customImage.GetPixel(i, j);
					int r = gammaCorrectionColor(gamma, pixel.R);
					int g = gammaCorrectionColor(gamma, pixel.G);
					int b = gammaCorrectionColor(gamma, pixel.B);
					this.customImage.SetPixel(i, j, Color.FromArgb(r, g, b));
				}
			}
			this.customImagePictureBox.Image = this.customImage;
		}

		private Color getColorAfterMatrix(Bitmap image, int x, int y, double[,] matrix)
		{
			double r = 0, g = 0, b = 0;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Color pixel = image.GetPixel(x - 1 + i, y - 1 + j);
					r += pixel.R * matrix[i, j];
					g += pixel.G * matrix[i, j];
					b += pixel.B * matrix[i, j];
				}
			}
			int newR = Math.Max(0, Math.Min((int)r, 255));
			int newG = Math.Max(0, Math.Min((int)g, 255));
			int newB = Math.Max(0, Math.Min((int)b, 255));
			return Color.FromArgb(newR, newG, newB);
		}
		private void SmoothingButton_Click(object sender, EventArgs e)
		{
			double a = (double)1 / 9;
			double[,] matrix = { { a, a, a }, { a, a, a }, { a, a, a } };
			Bitmap currImage = new Bitmap(this.customImage);
			for (int i = 1; i < customImage.Width - 1; i++)
			{
				for (int j = 1; j < customImage.Height - 1; j++)
				{
					this.customImage.SetPixel(i, j, this.getColorAfterMatrix(currImage, i, j, matrix));
				}
			}
			this.customImagePictureBox.Image = this.customImage;
		}

		private void gaussSmoothingButton_Click(object sender, EventArgs e)
		{
			double[,] matrix = {
				{ (double)1 / 16, (double)1 / 8, (double)1 / 16 },
				{  (double)1 / 8,  (double)1 / 4,  (double)1 / 8 },
				{ (double)1 / 16, (double)1 / 8, (double)1 / 16 }
			};
			Bitmap currImage = new Bitmap(this.customImage);
			for (int i = 1; i < customImage.Width - 1; i++)
			{
				for (int j = 1; j < customImage.Height - 1; j++)
				{
					this.customImage.SetPixel(i, j, this.getColorAfterMatrix(currImage, i, j, matrix));
				}
			}
			this.customImagePictureBox.Image = this.customImage;
		}

		private void sharpnessButton_Click(object sender, EventArgs e)
		{
			double[,] matrix = { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } };
			Bitmap currImage = new Bitmap(this.customImage);
			for (int i = 1; i < customImage.Width - 1; i++)
			{
				for (int j = 1; j < customImage.Height - 1; j++)
				{
					this.customImage.SetPixel(i, j, this.getColorAfterMatrix(currImage, i, j, matrix));
				}
			}
			this.customImagePictureBox.Image = this.customImage;
		}

		private Color setMedianColor(Bitmap image, int x, int y)
		{
			int[] rArr = new int[9];
			int[] gArr = new int[9];
			int[] bArr = new int[9];
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Color pixel = image.GetPixel(x - 1 + i, y - 1 + j);
					rArr[i * 3 + j] = pixel.R;
					gArr[i * 3 + j] = pixel.G;
					bArr[i * 3 + j] = pixel.B;
				}
			}
			Array.Sort(rArr);
			Array.Sort(gArr);
			Array.Sort(bArr);
			return Color.FromArgb(rArr[4], gArr[4], bArr[4]);

		}
		private void medianFilterButton_Click(object sender, EventArgs e)
		{
			Bitmap currImage = new Bitmap(this.customImage);
			for (int i = 1; i < customImage.Width - 1; i++)
			{
				for (int j = 1; j < customImage.Height - 1; j++)
				{
					this.customImage.SetPixel(i, j, this.setMedianColor(currImage, i, j));
				}
			}
			this.customImagePictureBox.Image = this.customImage;
		}

		private void addError(Bitmap image, int x, int y, int error)
		{
			Color pixel = image.GetPixel(x, y);
			Color newPixel = Color.FromArgb(
				Math.Max(0, Math.Min(pixel.R + error, 255)),
				Math.Max(0, Math.Min(pixel.G + error, 255)),
				Math.Max(0, Math.Min(pixel.B + error, 255))
			);
			image.SetPixel(x, y, newPixel);
		}
		private void applyStohastAlign(Bitmap image, int x, int y)
		{
			Color pixel = image.GetPixel(x, y);
			int grayScale = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
			int newValue = grayScale < 128 ? 0 : 255;
			int error = grayScale - newValue;
			image.SetPixel(x, y, Color.FromArgb(newValue, newValue, newValue));
			this.addError(image, x + 1, y, error * 7 / 16);
			this.addError(image, x - 1, y + 1, error * 3 / 16);
			this.addError(image, x, y + 1, error * 5 / 16);
			this.addError(image, x + 1, y + 1, error * 7 / 16);
		}

		private void stohastAlignButton_Click(object sender, EventArgs e)
		{
			for (int i = 1; i < customImage.Width - 1; i++)
			{
				for (int j = 1; j < customImage.Height - 1; j++)
				{
					this.applyStohastAlign(customImage, i, j);
				}
			}
			this.customImagePictureBox.Image = this.customImage;
		}
	}
}
