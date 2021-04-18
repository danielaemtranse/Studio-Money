using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using StudioByte.StudioMoney.Configuration.BE;
using StudioByte.StudioMoney.Configuration.Business;

namespace StudioByte.Database.Business
{
    public class Database
    {
        private Object _oConnection;

        public Database()
        {
            FbConnection _oConnection = new FbConnection($"ServerType=1;Dialect=3;Port=3050;User=SYSDBA;Password=masterkey;Database={fnGetDatabase("Path")}");
            oConnection = _oConnection;
        }

        public virtual void Dispose()
        {

        }

        public Object oConnection
        {
            get
            {
                return _oConnection;
            }
            set
            {
                _oConnection = value;
            }
        }

        private String fnGetDatabase(String sKey)
        {

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            return objBusiness.fnGetDatabase(sKey);

        }

    }
}
