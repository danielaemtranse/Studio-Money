using System;
using System.Collections.Generic;
using System.Text;

namespace StudioByte.StudioMoney.Configuration.Data
{
    static class SConfiguration
    {
        public static IConfiguration GetDataClass(Object _oConnection)
        {

            return new ConfigurationSQL();

        }

    }
}
