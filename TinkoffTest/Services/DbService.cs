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
                    Clicks = 0
                };
                db.UrlsData.Add(urlData);
                db.SaveChanges();
            }
        }

        public UrlsData GetUrlData(string shortUrl)
        {
            using (var db = new UrlsModel())
            {
                return db.UrlsData.Where(a => a.ShortUrl.Contains(shortUrl)).FirstOrDefault() as UrlsData;
            }
        }

        public List<UrlsData> GetAllUrls()
        {
            using (var db = new UrlsModel())
            {
                return db.UrlsData.ToList();
            }
        }

        public void UpdateClicks(string shortUrl)
        {
            using (var db = new UrlsModel())
            {
                var data = db.UrlsData.Where(a => a.ShortUrl.Contains(shortUrl)).FirstOrDefault() as UrlsData;
                if (data != null)
                {
                    db.Entry(data).Property(a => a.Clicks).CurrentValue += 1;
                    db.SaveChanges();
                }
            }
        }
    }
}