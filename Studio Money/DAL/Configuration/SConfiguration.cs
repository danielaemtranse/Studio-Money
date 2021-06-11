using System;

namespace StudioMoney.DAL.Configuration
{
    static class SConfiguration
    {
        public static IConfiguration GetDataClass(Object _oConnection)
        {

            return new ConfigurationSQL();

        }
    }
}
