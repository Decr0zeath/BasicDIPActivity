using System;
using System.Drawing;

namespace ImageProcessingActivity
{
    internal class BasicDIP
    {
        public static Bitmap BasicCopy(Bitmap original)
        {
            Bitmap copy = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    copy.SetPixel(x, y, original.GetPixel(x, y));
                }
            }

            return copy;
        }

        public static Bitmap Greyscale(Bitmap original)
        {
            Bitmap greyImage = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    var pixel = original.GetPixel(x, y);
                    int avg = (pixel.R + pixel.G + pixel.B) / 3;
                    greyImage.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }

            return greyImage;
        }

        public static Bitmap ColorInversion(Bitmap original)
        {
            Bitmap invertedImage = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    var pixel = original.GetPixel(x, y);
                    invertedImage.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }

            return invertedImage;
        }

        public static Bitmap Histogram(Bitmap original)
        {
            int[] histdata = new int[256];

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    var sample = original.GetPixel(x, y);
                    var graydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    histdata[graydata]++;
                }
            }

            Bitmap histogramImage = new Bitmap(256, 800);

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    histogramImage.SetPixel(x, y, Color.White);
                }
            }

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x] / 5, histogramImage.Height - 1); y++)
                {
                    histogramImage.SetPixel(x, (histogramImage.Height - 1) - y, Color.Black);
                }
            }

            return histogramImage;
        }

        public static Bitmap Sepia(Bitmap original)
        {
            Bitmap sepiaImage = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    var pixel = original.GetPixel(x, y);
                    int sepiaR = Math.Min(255, (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B));
                    int sepiaG = Math.Min(255, (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B));
                    int sepiaB = Math.Min(255, (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B));
                    sepiaImage.SetPixel(x, y, Color.FromArgb(pixel.A, sepiaR, sepiaG, sepiaB));
                }
            }

            return sepiaImage;
        }
    }
}
