using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TinkoffTest.Services;

namespace TinkoffTest.Controllers
{
    public class UrlsController : Controller
    {  
        public ActionResult MyList(string url)
        {
            return View();
        }

        public ActionResult Encode(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                var encodeService = new EncodeService();
                var dbService = new DbService();
                var urlId = GetUniqueId();
                var shortUrl = "http://" + Request.Url.Authority + "/" + encodeService.Encode(urlId);
                dbService.WriteUrlData(urlId, url, shortUrl);
                return View("MyList");
            }
            return View();
        }

        public JsonResult GetUrls(string url)
        {
            var dbService = new DbService();
            var allUrls = dbService.GetAllUrls();

            return Json(allUrls, JsonRequestBehavior.AllowGet);
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