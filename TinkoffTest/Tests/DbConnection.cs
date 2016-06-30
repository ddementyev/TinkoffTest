using Xunit;

namespace TinkoffTest.Tests
{
    public class DbConnection
    {
        [Fact()]
        public void CheckConnection()
        {
            using (var db = new UrlsModel())
            {
                bool isConnectionExist;
                var connection = db.Database.Connection;

                try
                {
                    connection.Open();
                    isConnectionExist = true;
                }
                catch
                {
                    isConnectionExist = false;
                }

                Assert.True(isConnectionExist);
            }
        }
    }
}