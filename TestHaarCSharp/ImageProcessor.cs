using System.Drawing;

namespace TestHaarCSharp
{
    public class ImageProcessor
    {
        public static void ApplyTransform(Bitmap bmp, ColorChannels channels, WaveletTransform transform)
        {
            channels.SeparateColors(bmp);
            transform.Transform(channels);
            channels.MergeColors(bmp);
        }
    }
}