using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Web.Http;
using TinkoffTest.Services;

namespace TinkoffTest.Controllers
{
    public class CodeController : Controller
    {
        public ActionResult Encode(string url)
        {
            if (url != null)
            {
                var encodeService = new EncodeService();
                var dbService = new DbService();
                var urlId = GetUniqueId();
                var shortUrl = Request.Url.Authority + "/" + encodeService.Encode(urlId);

                dbService.WriteUrlData(urlId, url, shortUrl);
            }

            return View();
        }

        public ActionResult Decode()
        {
            var dbService = new DbService();
            var queryValues = Request.Url.AbsolutePath;
            var initialUrl = dbService.GetInitialUrl(queryValues);

            return View();
        }

        public int GetUniqueId()
        {
            var rnd = new Random();
            return rnd.Next(10000000, 99999999);
        }
    }
}