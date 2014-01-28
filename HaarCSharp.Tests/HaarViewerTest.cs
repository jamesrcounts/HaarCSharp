using ApprovalTests.Reporters;
using ApprovalTests.WinForms;
using TestHaarCSharp;
using Xunit;

namespace HaarCSharp.Tests
{
    public class HaarViewerTest
    {
        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void ShowHaarViewer()
        {
            using (var viewer = new HaarViewer())
            {
                WinFormsApprovals.Verify(viewer);
            }
        }
    }
}