namespace HaarCSharp.Tests
{
    using ApprovalTests.Maintenance;

    using Xunit;

    /// <summary>
    /// The run maintenance "test" cleans up abandoned .approved. files and verifies they
    /// are all gone.
    /// </summary>
    public class RunMaintenance
    {
        /// <summary>
        /// Ensure no abandoned files.
        /// </summary>
        [Fact]
        public void EnsureNoAbandonedFiles()
        {
            ApprovalMaintenance.CleanUpAbandonedFiles();
            ApprovalMaintenance.VerifyNoAbandonedFiles();
        }
    }
}