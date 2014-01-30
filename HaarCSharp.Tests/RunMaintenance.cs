using ApprovalTests.Maintenance;
using Xunit;

namespace HaarCSharp.Tests
{
    public class RunMaintenance
    {
        [Fact]
        public void EnsureNoAbandonedFiles()
        {
            ApprovalMaintenance.CleanUpAbandonedFiles();
            ApprovalMaintenance.VerifyNoAbandonedFiles();
        }
    }
}