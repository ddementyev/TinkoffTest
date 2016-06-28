using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TinkoffTest.Interfaces;

namespace TinkoffTest.Controllers
{
    public class DbService : IDbService
    {
        public void WriteUrlData(int id, string url, string shortUrl)
        {
            using (var db = new UrlsModel())
            {
                var urlData = new UrlsData()
                {
                    Id = id,
                    InitialUrl = url,
                    ShortUrl = shortUrl,
                    CreationDate = DateTime.Now,
                    Clicks = 100500
                };
                db.UrlsData.Add(urlData);
                db.SaveChanges();
            }
        }

        public string GetInitialUrl(string shortUrl)
        {
            using (var db = new UrlsModel())
            {
                var res = db.UrlsData.Where(a => a.ShortUrl.Contains(shortUrl)).Select(b => b.InitialUrl).ToList().FirstOrDefault();
                return res;
            }
        }
    }
}