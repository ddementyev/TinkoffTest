using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using TinkoffTest.Interfaces;

namespace TinkoffTest.Services
{
    public class EncodeService : IEncodeService
    {
        private string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private int baseType = 62;

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
    }
}