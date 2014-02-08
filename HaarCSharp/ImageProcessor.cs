namespace TestHaarCSharp
{
    using System.Drawing;

    public class ImageProcessor
    {
        private readonly ColorChannels channels;

        private readonly WaveletTransform transform;

        public ImageProcessor(ColorChannels channels, WaveletTransform transform)
        {
            this.channels = channels;
            this.transform = transform;
        }

        public void ApplyTransform(Bitmap bmp)
        {
            this.channels.SeparateColors(bmp);
            this.transform.Transform(this.channels);
            this.channels.MergeColors(bmp);
        }
    }
}