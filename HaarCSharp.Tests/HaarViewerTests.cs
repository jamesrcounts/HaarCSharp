namespace HaarCSharp.Tests
{
    using ApprovalTests.Reporters;
    using ApprovalTests.WinForms;

    using TestHaarCSharp;

    using Xunit;

    [UseReporter(typeof(DiffReporter))]
    public class HaarViewerTests
    {
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