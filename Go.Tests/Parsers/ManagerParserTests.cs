using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class ManagerParserTests
    {
        private readonly string _managerPage = TestDataLoader.Load("ManagerProfile.html");

        [Fact]
        public void GetManager_SupporterPage_SetsIsSupporterTrue()
        {
            var manager = ManagerParser.GetManager(_managerPage);
            Assert.True(manager.isSupporter);
        }

        [Fact]
        public void GetManager_NonSupporterPage_SetsIsSupporterFalse()
        {
            var page = "<html><body><div>No special status here</div></body></html>";
            var manager = ManagerParser.GetManager(page);
            Assert.False(manager.isSupporter);
        }

        [Fact]
        public void GetManager_EmptyPage_SetsIsSupporterFalse()
        {
            var manager = ManagerParser.GetManager(string.Empty);
            Assert.False(manager.isSupporter);
        }
    }
}
