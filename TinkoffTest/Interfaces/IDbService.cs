using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinkoffTest.Interfaces
{
    public interface IDbService
    {
        void WriteUrlData(int id, string url, string shortUrl);
        UrlsData GetUrlData(string shortUrl);
        List<UrlsData> GetAllUrls();
    }
}