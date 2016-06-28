using System;
using System.Web.Mvc;
using TinkoffTest.Services;

namespace TinkoffTest.Controllers
{
    public class CodeController : Controller
    {
        public ActionResult Encode(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                var encodeService = new EncodeService();
                var dbService = new DbService();
                var urlId = GetUniqueId();
                var shortUrl = Request.Url.Authority + "/" + encodeService.Encode(urlId);

                dbService.WriteUrlData(urlId, url, shortUrl);
            }

            return View();
        }

        public ActionResult Decode(string url)
        {
            var dbService = new DbService();
            var shortUrl = Request.Url.AbsolutePath;
            var urlData = dbService.GetUrlData(shortUrl);

            return View("Decode", urlData);
        }

        public void UrlRedirect(string url)
        {
            var dbService = new DbService();
            var shortUrl = Request.Url.AbsolutePath;
            var urlData = dbService.GetUrlData(shortUrl);
            dbService.UpdateClicks(shortUrl);
            Response.Redirect(urlData.InitialUrl);
        }

        public int GetUniqueId()
        {
            var rnd = new Random();
            return rnd.Next(10000000, 99999999);
        }
    }
}