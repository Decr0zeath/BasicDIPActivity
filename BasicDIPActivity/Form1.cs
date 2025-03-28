using ImageProcessingActivity;
using System;
using System.ComponentModel;
using System.Drawing;
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

        
        // Open and Save Dialogs & Button Clicks
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

        
        // Part 1 -- Basic DIP process
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

        // Part 2 -- Image Subtraction
        private void imageButtonSubtract_Click(object sender, EventArgs e)
        {
            int threshold = sliderThreshold.Value; // Get the threshold from UI slider
            imageResult = BasicDIP.SubtractImage(imageLoad, imageBackground, threshold);
            pictureBoxSubtract.Image = imageResult;
        }

        // Part 3 -- Convolution Process
        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.ConvolutionFilter(originalImage, Filters.Smooth);
            pictureBoxProcessed.Image = processedImage;
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.ConvolutionFilter(originalImage, Filters.GaussianBlur);
            pictureBoxProcessed.Image = processedImage;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.ConvolutionFilter(originalImage, Filters.Sharpen);
            pictureBoxProcessed.Image = processedImage;
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.ConvolutionFilter(originalImage, Filters.MeanRemoval);
            pictureBoxProcessed.Image = processedImage;
        }

        private void embossLaplascianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.ConvolutionFilter(originalImage, Filters.EmbossLaplacian);
            pictureBoxProcessed.Image = processedImage;
        }

        private void horzVertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.ConvolutionFilter(originalImage, Filters.HorzVert);
            pictureBoxProcessed.Image = processedImage;
        }

        private void allDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.ConvolutionFilter(originalImage, Filters.AllDirection);
            pictureBoxProcessed.Image = processedImage;
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.ConvolutionFilter(originalImage, Filters.Lossy);
            pictureBoxProcessed.Image = processedImage;
        }

        private void horizontalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.ConvolutionFilter(originalImage, Filters.HorzOnly);
            pictureBoxProcessed.Image = processedImage;
        }

        private void verticalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            processedImage = BasicDIP.ConvolutionFilter(originalImage, Filters.VertOnly);
            pictureBoxProcessed.Image = processedImage;
        }
    }
}
