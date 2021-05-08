using System;
using System.Data;
using StudioMoney.BE;

namespace StudioMoney.DAL.Configuration
{
    interface IConfiguration
    {

        ConfigurationBE ObjConfigurationBE
        {
            get;
            set;
        }

        String fnGetCurrentLanguage();
        void fnSetCurrentLanguage(String sLanguage);
        DataTable fnGetExistentLanguages();
        String fnGetSoundFile(String sEventName);
        Boolean fnGetIfSoundIsOn();
        String fnGetObjectCaption(String sFormName, String sObjectName);
        String fnGetObjectPicturePath(String sObjectName);
        String fnGetOptionValue(String sOption);
        String fnGetDatabase(string sKey);
        void fnSetRegisteredUser(String sRegisteredUser, String sRegisteredUserEMail);
        String fnGetRegisteredUser();
    }
}
