using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalTests.WinForms;
using ApprovalUtilities.Utilities;
using TestHaarCSharp;
using Xunit;
using BinaryWriter = ApprovalTests.Writers.BinaryWriter;

namespace HaarCSharp.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class HaarViewerTest
    {
        [Fact]
        public void DecomposeWithSafeCode()
        {
            using (var viewer = new HaarViewer())
            {
                viewer.ApplyHaarTransform(true, true, 1, viewer.OriginalImage);
                Stream imageStream = new MemoryStream();
                viewer.TransformedImage.Save(imageStream, ImageFormat.Bmp);
                imageStream.Flush();
                imageStream.Seek(0, 0);
                Approvals.Verify(new BinaryWriter(imageStream, "bmp"));
            }
        }

        [Fact]
        public void DecomposeWithUnsafeCode()
        {
            using (var viewer = new HaarViewer())
            {
                viewer.ApplyHaarTransform(true, false, 1, viewer.OriginalImage);
                Stream imageStream = new MemoryStream();
                viewer.TransformedImage.Save(imageStream, ImageFormat.Bmp);
                imageStream.Flush();
                imageStream.Seek(0, 0);
                Approvals.Verify(new BinaryWriter(imageStream, "bmp"));
            }
        }

        [Fact]
        public void FullDecomposeWithSafeCode()
        {
            using (var viewer = new HaarViewer())
            {
                viewer.ApplyHaarTransform(true, true, viewer.OriginalImage);
                Stream imageStream = new MemoryStream();
                viewer.TransformedImage.Save(imageStream, ImageFormat.Bmp);
                imageStream.Flush();
                imageStream.Seek(0, 0);
                Approvals.Verify(new BinaryWriter(imageStream, "bmp"));
            }
        }

        [Fact]
        public void FullDecomposeWithUnsafeCode()
        {
            using (var viewer = new HaarViewer())
            {
                viewer.ApplyHaarTransform(true, false, viewer.OriginalImage);
                Stream imageStream = new MemoryStream();
                viewer.TransformedImage.Save(imageStream, ImageFormat.Bmp);
                imageStream.Flush();
                imageStream.Seek(0, 0);
                Approvals.Verify(new BinaryWriter(imageStream, "bmp"));
            }
        }

        [Fact]
        public void FullRecomposeWithSafeCode()
        {
            using (var viewer = new HaarViewer())
            {
                string filename = PathUtilities.GetAdjacentFile("full.bmp");
                Bitmap originalImage = new Bitmap(filename);
                Bitmap transform = viewer.ApplyHaarTransform(false, true, originalImage);
                Stream imageStream = new MemoryStream();
                transform.Save(imageStream, ImageFormat.Bmp);
                imageStream.Flush();
                imageStream.Seek(0, 0);
                Approvals.Verify(new BinaryWriter(imageStream, "bmp"));
            }
        }

        [Fact]
        public void RecomposeWithSafeCode()
        {
            using (var viewer = new HaarViewer())
            {
                string filename = PathUtilities.GetAdjacentFile("one_step.bmp");
                Bitmap originalImage = new Bitmap(filename);
                Bitmap transform = viewer.ApplyHaarTransform(false, true, 1, originalImage);
                Stream imageStream = new MemoryStream();
                transform.Save(imageStream, ImageFormat.Bmp);
                imageStream.Flush();
                imageStream.Seek(0, 0);
                Approvals.Verify(new BinaryWriter(imageStream, "bmp"));
            }
        }

        [Fact]
        public void ShowHaarViewer()
        {
            using (var viewer = new HaarViewer())
            {
                WinFormsApprovals.Verify(viewer);
            }
        }
    }
}