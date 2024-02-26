using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace CMYK
{
    public static class Statics
    {
        public static Bitmap ResizeImage(Image image, int dim)
        {
            var destRect = new Rectangle(0, 0, dim, dim);
            var destImage = new Bitmap(dim, dim);
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        public static (int, int, int, int) RGBtoCMYK(Color color)
        {
            int C = 255 - color.R, M = 255 - color.G, Y = 255 - color.B;
            int K = Math.Min(C, Math.Min(M, Y));
            if (K == 255) return (0, 0, 0, 255);
            return (C - K, M - K, Y - K, K);
        }

        public static Bitmap MakeGrayscale(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            Color originalColor, newColor;
            int grayScale;

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    originalColor = original.GetPixel(i, j);
                    grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));
                    newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    newBitmap.SetPixel(i, j, newColor);
                }
            }

            return newBitmap;
        }
    }
}
