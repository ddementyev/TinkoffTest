using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinkoffTest.Interfaces
{
    public interface IEncodeService
    {
        string Encode(int num);
        int DecodeData(string str);
    }
}