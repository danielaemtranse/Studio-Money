using System;
using System.Collections.Generic;
using System.Text;

namespace StudioByte.StudioMoney.Main.Data
{
    static class SMain
    {
        public static IMain GetDataClass(Object _oConnection)
        {

            return new MainSQL();

        }

    }
}
