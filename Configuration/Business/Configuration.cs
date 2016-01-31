using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudioByte.StudioMoney.Configuration.BE;
using StudioByte.StudioMoney.Configuration.Data;

namespace StudioByte.StudioMoney.Configuration.Business
{
    public class Configuration
    {
        private ConfigurationBE objConfigurationBE;

        public Configuration()
        {

        }

        public virtual void Dispose()
        {

        }

        public ConfigurationBE ObjConfigurationBE
        {
            get
            {
                return objConfigurationBE;
            }
            set
            {
                objConfigurationBE = value;
            }

        }

        public String fnGetCurrentLanguage()
        {

            // Determine what data class will be used according to connection type
            IConfiguration objData = SConfiguration.GetDataClass(ObjConfigurationBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjConfigurationBE = this.ObjConfigurationBE;

            // Execute data class method
            return objData.fnGetCurrentLanguage();

        }

        public void fnSetCurrentLanguage(String sLanguage)
        {

            // Determine what data class will be used according to connection type
            IConfiguration objData = SConfiguration.GetDataClass(ObjConfigurationBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjConfigurationBE = this.ObjConfigurationBE;

            // Execute data class method
            objData.fnSetCurrentLanguage(sLanguage);

        }

        public void fnSetRegisteredUser(String sRegisteredUser, String sRegisteredUserEMail)
        {

            // Determine what data class will be used according to connection type
            IConfiguration objData = SConfiguration.GetDataClass(ObjConfigurationBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjConfigurationBE = this.ObjConfigurationBE;

            // Execute data class method
            objData.fnSetRegisteredUser(sRegisteredUser, sRegisteredUserEMail);

        }

        public DataTable fnGetExistentLanguages()
        {

            // Determine what data class will be used according to connection type
            IConfiguration objData = SConfiguration.GetDataClass(ObjConfigurationBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjConfigurationBE = this.ObjConfigurationBE;

            // Execute data class method
            return objData.fnGetExistentLanguages();

        }

        public String fnGetSoundFile(string sEventName)
        {

            // Determine what data class will be used according to connection type
            IConfiguration objData = SConfiguration.GetDataClass(ObjConfigurationBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjConfigurationBE = this.ObjConfigurationBE;

            // Execute data class method
            return objData.fnGetSoundFile(sEventName);

        }

        public String fnGetDatabasePath()
        {

            // Determine what data class will be used according to connection type
            IConfiguration objData = SConfiguration.GetDataClass(ObjConfigurationBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjConfigurationBE = this.ObjConfigurationBE;

            // Execute data class method
            return objData.fnGetDatabasePath();

        }

        public String fnGetObjectCaption(String sFormName, String sObjectName)
        {

            // Determine what data class will be used according to connection type
            IConfiguration objData = SConfiguration.GetDataClass(ObjConfigurationBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjConfigurationBE = this.ObjConfigurationBE;

            // Execute data class method
            return objData.fnGetObjectCaption(sFormName, sObjectName);

        }

        public String fnGetObjectPicturePath(String sObjectName)
        {

            // Determine what data class will be used according to connection type
            IConfiguration objData = SConfiguration.GetDataClass(ObjConfigurationBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjConfigurationBE = this.ObjConfigurationBE;

            // Execute data class method
            return objData.fnGetObjectPicturePath(sObjectName);

        }

        public String fnGetOptionValue(String sOption)
        {

            // Determine what data class will be used according to connection type
            IConfiguration objData = SConfiguration.GetDataClass(ObjConfigurationBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjConfigurationBE = this.ObjConfigurationBE;

            // Execute data class method
            return objData.fnGetOptionValue(sOption);

        }

        public String fnGetRegisteredUser()
        {

            // Determine what data class will be used according to connection type
            IConfiguration objData = SConfiguration.GetDataClass(ObjConfigurationBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjConfigurationBE = this.ObjConfigurationBE;

            // Execute data class method
            return objData.fnGetRegisteredUser();

        }
    }
}
