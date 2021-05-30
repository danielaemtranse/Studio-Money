using System;

namespace StudioMoney.DAL.Main
{
    static class SMain
    {
        public static IMain GetDataClass(Object _oConnection)
        {
            return new MainSQL();
        }
    }
}
