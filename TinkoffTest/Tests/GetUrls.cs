using TinkoffTest.Controllers;
using Xunit;

namespace TinkoffTest.Tests
{
    public class GetUrls
    {
        [Fact()]
        public void PassingTest()
        {
            var dbService = new DbService();
            var allUrls = dbService.GetAllUrls();
            Assert.NotNull(allUrls);
        }
    }
}