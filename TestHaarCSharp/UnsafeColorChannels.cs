using System.Drawing;
using System.Drawing.Imaging;

namespace TestHaarCSharp
{
    public class UnsafeColorChannels : ColorChannels
    {
        private const int PixelSize = 3;
        private BitmapData _bitmapData;

        public UnsafeColorChannels(int width, int height)
            : base(width, height)
        {
        }

        public override void MergeColors(Bitmap bmp)
        {
            unsafe
            {
                for (var j = 0; j < _bitmapData.Height; j++)
                {
                    var row = (byte*)_bitmapData.Scan0 + (j * _bitmapData.Stride);
                    for (var i = 0; i < _bitmapData.Width; i++)
                    {
                        row[i * PixelSize + 2] = (byte)Scale(-1, 1, 0, 255, Red[i, j]);
                        row[i * PixelSize + 1] = (byte)Scale(-1, 1, 0, 255, Green[i, j]);
                        row[i * PixelSize] = (byte)Scale(-1, 1, 0, 255, Blue[i, j]);
                    }
                }
            }

            bmp.UnlockBits(_bitmapData);
        }

        public override void SeparateColors(Bitmap bmp)
        {
            _bitmapData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            unsafe
            {
                for (var j = 0; j < _bitmapData.Height; j++)
                {
                    var row = (byte*)_bitmapData.Scan0 + (j * _bitmapData.Stride);
                    for (var i = 0; i < _bitmapData.Width; i++)
                    {
                        Red[i, j] = Scale(0, 255, -1, 1, row[i * PixelSize + 2]);
                        Green[i, j] = Scale(0, 255, -1, 1, row[i * PixelSize + 1]);
                        Blue[i, j] = Scale(0, 255, -1, 1, row[i * PixelSize]);
                    }
                }
            }
        }
    }
}