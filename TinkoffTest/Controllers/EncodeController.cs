using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TinkoffTest.Controllers
{
    public class EncodeController : Controller
    {
        private string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private int baseType = 62;

        public ActionResult Index()
        {
            //test
            var gb = Guid.NewGuid().ToByteArray();
            int i = BitConverter.ToInt32(gb, 0);

            var encoded = Encode(i);
            var decoded = Decode(encoded);

            return View();
        }


        public string Encode(int num)
        {
            var sb = new StringBuilder();

            while (num > 0)
            {
                sb.Append(alphabet[(num % baseType)]);
                num /= baseType;
            }

            var builder = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                builder.Append(sb[i]);
            }

            return builder.ToString();
        }

        public int Decode(String str)
        {
            int num = 0;

            for (int i = 0, len = str.Length; i < len; i++)
            {
                num = num * baseType + alphabet.IndexOf(str[(i)]);
            }

            return num;
        }  
    }
}