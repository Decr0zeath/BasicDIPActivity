using ImageProcessingActivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicDIPActivity
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap processedImage;

        private Bitmap imageLoad;
        private Bitmap imageBackground;
        private Bitmap imageResult;
        public Form1()
        {

            InitializeComponent();

            this.Size = new Size(1215, 680); 
            this.StartPosition = FormStartPosition.CenterScreen;
            labelThreshold.Text = sliderThreshold.Value.ToString();
        }

        // Slider
        private void sliderThreshold_ValueChanged(object sender, EventArgs e)
        {
            labelThreshold.Text = sliderThreshold.Value.ToString();
        }


        // Code for coloring the edges for PictureBox
        private void colorEdgesPictureBox(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            if (pb != null)
            {
                int borderWidth = 3;
                Color borderColor = Color.FromArgb(44,44,48);
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, pb.Width - 1, pb.Height - 1);
                }
            }

        }

        private void pictureBoxOriginal_Paint(object sender, PaintEventArgs e)
        {
            colorEdgesPictureBox(sender, e);
        }

        private void pictureBoxProcessed_Paint(object sender, PaintEventArgs e)
        {
            colorEdgesPictureBox(sender, e);
        }

        private void pictureBoxLoadImage_Paint(object sender, PaintEventArgs e)
        {
            colorEdgesPictureBox(sender, e);
        }

        private void pictureBoxLoadBackground_Paint(object sender, PaintEventArgs e)
        {
            colorEdgesPictureBox(sender, e);
        }

        private void pictureBoxSubtract_Paint(object sender, PaintEventArgs e)
        {
            colorEdgesPictureBox(sender, e);
        }

        
        //Open and Save Dialogs
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            originalImage = new Bitmap(openFileDialog1.FileName);
            pictureBoxOriginal.Image = originalImage;
        }

        private void openFileDialogLoadImage_FileOk(object sender, CancelEventArgs e)
        {
            imageLoad = new Bitmap(openFileDialogLoadImage.FileName);
            pictureBoxLoadImage.Image = imageLoad;
        }

        private void openFileDialogLoadBackground_FileOk(object sender, CancelEventArgs e)
        {
            imageBackground = new Bitmap(openFileDialogLoadBackground.FileName);
            pictureBoxLoadBackground.Image = imageBackground;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            processedImage.Save(saveFileDialog1.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog1.Title = "Save Processed Image";
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.FileName = "output_image";
            saveFileDialog1.ShowDialog();
        }

        private void imageButtonLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialogLoadImage.ShowDialog();
        }

        private void imageButtonLoadBackground_Click(object sender, EventArgs e)
        {
            openFileDialogLoadBackground.ShowDialog();
        }

        
        // DIP Menu Strip - Part 1
        private void imageCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.BasicCopy(originalImage);
            pictureBoxProcessed.Image = processedImage;
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.Greyscale(originalImage);
            pictureBoxProcessed.Image = processedImage;
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.ColorInversion(originalImage);
            pictureBoxProcessed.Image = processedImage;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(256, 800);
            processedImage = BasicDIP.Histogram(originalImage);
            pictureBoxProcessed.Image = processedImage;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.Sepia(originalImage);
            pictureBoxProcessed.Image = processedImage;
        }

        // Subtract -- Part 2
        private void imageButtonSubtract_Click(object sender, EventArgs e)
        {
            imageResult = new Bitmap(imageLoad.Width, imageLoad.Height);
            int threshold = sliderThreshold.Value; // Gets the value of the slider threshold
            Color myGreen = Color.FromArgb(0, 255, 0);
            int greyGreen = (myGreen.R + myGreen.G + myGreen.B) / 3;

            for (int x = 0; x < imageLoad.Width; x++)
            {
                for (int y = 0; y < imageLoad.Height; y++)
                {
                    Color pixel = imageLoad.GetPixel(x, y);
                    Color backpixel = imageBackground.GetPixel(x, y);

                    // Convert both pixels and reference green to grayscale
                    int greyPixel = (pixel.R + pixel.G + pixel.B) / 3;
                    int greyBack = (backpixel.R + backpixel.G + backpixel.B) / 3;

                    // Compute the difference between the foreground and background
                    int diff = Math.Abs(greyPixel - greyBack);
                    int greenDiff = Math.Abs(greyPixel - greyGreen);

                    // If the pixel is close to green OR it's similar to the background, replace it
                    if (greenDiff < threshold || diff < threshold) imageResult.SetPixel(x, y, backpixel);
                    else imageResult.SetPixel(x, y, pixel);
                }
            }

            pictureBoxSubtract.Image = imageResult;
        }
    }
}
