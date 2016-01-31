using System;
using System.Collections.Generic;
using System.Text;

namespace StudioByte.StudioMoney.Configuration.BE
{
    public class ConfigurationBE
    {
        private Object _oConnection;
        private String _sLanguage;
        private String _sRegisteredUser;
        private String _sConfigurationINIFile;
        private String _sApplicationDirectory;

        public ConfigurationBE()
        {

            // Fill BE Properties
            if (System.Reflection.Assembly.GetExecutingAssembly().Location.IndexOf("bin") > 0)
            {
                sApplicationDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location.Remove(System.Reflection.Assembly.GetExecutingAssembly().Location.IndexOf("bin"), System.Reflection.Assembly.GetExecutingAssembly().Location.Length - System.Reflection.Assembly.GetExecutingAssembly().Location.IndexOf("bin"));
            }

            else
            {
                sApplicationDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
            }

            sConfigurationINIFile = sApplicationDirectory + "Configuration\\StudioMoney.ini";

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

        public String sLanguage
        {
            get
            {
                return _sLanguage;
            }
            set
            {
                _sLanguage = value;
            }
        }

        public String sRegisteredUser
        {
            get
            {
                return _sRegisteredUser;
            }
            set
            {
                _sRegisteredUser = value;
            }
        }

        public String sConfigurationINIFile
        {
            get
            {
                return _sConfigurationINIFile;
            }
            set
            {
                _sConfigurationINIFile = value;
            }
        }

        public String sApplicationDirectory
        {
            get
            {
                return _sApplicationDirectory;
            }
            set
            {
                _sApplicationDirectory = value;
            }
        }

    }

}
