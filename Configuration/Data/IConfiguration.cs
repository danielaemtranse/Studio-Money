using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudioByte.StudioMoney.Configuration.BE;

namespace StudioByte.StudioMoney.Configuration.Data
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
        String fnGetObjectCaption(String sFormName, String sObjectName);
        String fnGetObjectPicturePath(String sObjectName);
        String fnGetOptionValue(String sOption);
        String fnGetDatabasePath();
        void fnSetRegisteredUser(String sRegisteredUser, String sRegisteredUserEMail);
        String fnGetRegisteredUser();
    }
}
