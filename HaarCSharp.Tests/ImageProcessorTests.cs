namespace HaarCSharp.Tests
{
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;

    using ApprovalTests;

    using ApprovalUtilities.Utilities;

    using TestHaarCSharp;

    using Xunit;

    using BinaryWriter = ApprovalTests.Writers.BinaryWriter;

    public class ImageProcessorTests
    {
        private static readonly string DecomposedFilename = PathUtilities.GetAdjacentFile("full.bmp");

        private static readonly string OneStepFileName = PathUtilities.GetAdjacentFile("one_step.bmp");

        private static readonly string OriginalFilename = PathUtilities.GetAdjacentFile("lena.png");

        [Fact]
        public void DecomposeWithSafeCode()
        {
            using (var originalImage = new Bitmap(OriginalFilename))
            {
                var transform = new ForwardWaveletTransform(1);
                var channels = new SafeColorChannels(originalImage.Width, originalImage.Height);
                var imageProcessor = new ImageProcessor(channels, transform);
                imageProcessor.ApplyTransform(originalImage);

                VerifyAsImage(originalImage);
            }
        }

        [Fact]
        public void DecomposeWithUnsafeCode()
        {
            using (var originalImage = new Bitmap(OriginalFilename))
            {
                var transform = new ForwardWaveletTransform(1);
                var channels = new UnsafeColorChannels(originalImage.Width, originalImage.Height);
                var imageProcessor = new ImageProcessor(channels, transform);
                imageProcessor.ApplyTransform(originalImage);

                VerifyAsImage(originalImage);
            }
        }

        [Fact]
        public void FullDecomposeWithSafeCode()
        {
            using (var originalImage = new Bitmap(OriginalFilename))
            {
                var height = originalImage.Height;
                var width = originalImage.Width;
                var transform = new ForwardWaveletTransform(width, height);
                var channels = new SafeColorChannels(width, height);
                var imageProcessor = new ImageProcessor(channels, transform);
                imageProcessor.ApplyTransform(originalImage);

                VerifyAsImage(originalImage);
            }
        }

        [Fact]
        public void FullDecomposeWithUnsafeCode()
        {
            using (var originalImage = new Bitmap(OriginalFilename))
            {
                var width = originalImage.Width;
                var height = originalImage.Height;

                WaveletTransform transform = new ForwardWaveletTransform(width, height);
                ColorChannels channels = new UnsafeColorChannels(width, height);
                var imageProcessor = new ImageProcessor(channels, transform);
                imageProcessor.ApplyTransform(originalImage);

                VerifyAsImage(originalImage);
            }
        }

        [Fact]
        public void FullRecomposeWithSafeCode()
        {
            using (var originalImage = new Bitmap(DecomposedFilename))
            {
                var width = originalImage.Width;
                var height = originalImage.Height;
                var transform = new InverseWaveletTransform(width, height);
                var channels = new SafeColorChannels(width, height);
                var imageProcessor = new ImageProcessor(channels, transform);
                imageProcessor.ApplyTransform(originalImage);

                VerifyAsImage(originalImage);
            }
        }

        [Fact]
        public void RecomposeWithSafeCode()
        {
            using (var originalImage = new Bitmap(OneStepFileName))
            {
                WaveletTransform transform = new InverseWaveletTransform(1);
                ColorChannels channels = new SafeColorChannels(originalImage.Width, originalImage.Height);
                var imageProcessor = new ImageProcessor(channels, transform);
                imageProcessor.ApplyTransform(originalImage);

                VerifyAsImage(originalImage);
            }
        }

        [Fact]
        public void ResizeImage()
        {
            using (var originalImage = new Bitmap(OriginalFilename))
            {
                Bitmap resized = ImageProcessor.ToNormalSize(originalImage);
                VerifyAsImage(resized);
            }
        }

        private static void VerifyAsImage(Image value)
        {
            using (Stream imageStream = new MemoryStream())
            {
                value.Save(imageStream, ImageFormat.Bmp);
                imageStream.Flush();
                imageStream.Seek(0, 0);
                Approvals.Verify(new BinaryWriter(imageStream, "bmp"));
            }
        }
    }
}