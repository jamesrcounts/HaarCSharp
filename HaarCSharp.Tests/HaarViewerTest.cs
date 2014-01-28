using System.Drawing.Imaging;
using System.IO;
using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalTests.WinForms;
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
                viewer.ApplyHaarTransform(true, true, "1");
                Stream imageStream = new MemoryStream();
                viewer.pictureBox1.Image.Save(imageStream, ImageFormat.Bmp);
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