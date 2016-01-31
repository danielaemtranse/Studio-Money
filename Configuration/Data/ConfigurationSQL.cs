using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Data;
using System.IO;
using Microsoft.Win32;
using FirebirdSql.Data.FirebirdClient;
using System.Runtime.InteropServices;
using StudioByte.StudioMoney.Configuration.BE;
using StudioByte.StudioMoney.Configuration.Data;

namespace StudioByte.StudioMoney.Configuration.Data
{
    public class ConfigurationSQL : IConfiguration
    {
        private ConfigurationBE objConfigurationBE;
        private FbDataAdapter da;
        private FbCommand cm;
        private DataTable dt;
        public string sLanguageINIFile;
        public string sConfigurationINIFile;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public ConfigurationSQL()
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
            return fnGetINIValue(ObjConfigurationBE.sConfigurationINIFile, "Register", "Language");
        }

        public void fnSetCurrentLanguage(String sLanguage)
        {
            fnSetINIValue(ObjConfigurationBE.sConfigurationINIFile, "Register", "Language", sLanguage);
            ObjConfigurationBE.sLanguage = sLanguage;
        }

        public DataTable fnGetExistentLanguages()
        {

            // Get existent languages in the specified directory
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(fnGetINIFileDirectory());

            // Create dataset of language tables
            DataSet dsLanguage = new DataSet("Language");

            // Create table of language and its properties
            DataTable dtLanguage = new DataTable("tbLanguage");
            dsLanguage.Tables.Add(dtLanguage);

            // Create columns
            dtLanguage.Columns.Add("sLanguage");
            dtLanguage.Columns.Add("sIcon");
            dtLanguage.Columns.Add("sFile");
            dtLanguage.Columns.Add("sKey");

            if (dir.GetFiles("*.ini").Length > 0)
            {
                foreach (System.IO.FileInfo f in dir.GetFiles("*.ini"))
                {

                    // Get language file directory and name
                    sLanguageINIFile = f.FullName.ToString();

                    // Add register about current language
                    DataRow drLanguage = dtLanguage.NewRow();
                    drLanguage["sLanguage"] = fnGetINIValue(sLanguageINIFile, "Configuration", "Description");
                    drLanguage["sIcon"] = ObjConfigurationBE.sApplicationDirectory + "Languages\\" + fnGetINIValue(sLanguageINIFile, "Configuration", "Icon");
                    drLanguage["sKey"] = fnGetINIValue(sLanguageINIFile, "Configuration", "Icon");
                    drLanguage["sFile"] = f.Name.ToString();

                    dtLanguage.Rows.Add(drLanguage);

                }

            }

            else
            {

                // Add register about current language
                DataRow drLanguage = dtLanguage.NewRow();
                drLanguage["sLanguage"] = "No language files found.";
                drLanguage["sIcon"] = "";
                drLanguage["sFile"] = "";

                dtLanguage.Rows.Add(drLanguage);

            }

            return dtLanguage;

        }

        public String fnGetSoundFile(String sEventName)
        {
            return ObjConfigurationBE.sApplicationDirectory + "Sounds\\" + fnGetINIValue(ObjConfigurationBE.sConfigurationINIFile, "Sounds", sEventName);
        }

        public String fnGetRegisteredUser()
        {
            return fnGetINIValue(ObjConfigurationBE.sConfigurationINIFile, "Register", "User");
        }

        public void fnSetRegisteredUser(String sRegisteredUser, String sRegisteredUserEMail)
        {
            fnSetINIValue(ObjConfigurationBE.sConfigurationINIFile, "Register", "User", sRegisteredUser);
            fnSetINIValue(ObjConfigurationBE.sConfigurationINIFile, "Register", "EMail", sRegisteredUserEMail);
            ObjConfigurationBE.sRegisteredUser = sRegisteredUser;
        }

        public string fnGetINIFileDirectory()
        {
            return System.IO.Path.GetDirectoryName(ObjConfigurationBE.sApplicationDirectory) + "\\Languages";
        }

        public bool fnGetExistentFile()
        {
            return File.Exists(fnGetINIFileDirectory());
        }

        public String fnGetObjectCaption(String sFormName, String sObjectName)
        {
            return fnGetINIValue(fnGetINIFileDirectory() + "\\" + fnGetCurrentLanguage(), sFormName, sObjectName);
        }

        public String fnGetObjectPicturePath(String sObjectName)
        {
            return System.IO.Path.GetDirectoryName(ObjConfigurationBE.sApplicationDirectory) + "\\Images\\" + fnGetINIValue(ObjConfigurationBE.sConfigurationINIFile, "Pictures", sObjectName);
        }

        public String fnGetOptionValue(String sOption)
        {
            return fnGetINIValue(ObjConfigurationBE.sConfigurationINIFile, "Options", sOption);
        }

        public String fnGetDatabasePath()
        {
            return ObjConfigurationBE.sApplicationDirectory + fnGetINIValue(ObjConfigurationBE.sConfigurationINIFile, "Database", "Path");
        }

        /// <summary>
        /// Save INI file data
        /// </summary>
        /// <PARAM name="sSection"></PARAM>
        /// Section name
        /// <PARAM name="sKey"></PARAM>
        /// Key name
        /// <PARAM name="sValue"></PARAM>
        /// Value
        public void fnSetINIValue(string sINIFile, string sSection, string sKey, string sValue)
        {
            WritePrivateProfileString(sSection, sKey, sValue, sINIFile);
        }

        /// <summary>
        /// Get INI file data
        /// </summary>
        /// <PARAM name="sSection"></PARAM>
        /// <PARAM name="sKey"></PARAM>
        /// <returns></returns>
        public string fnGetINIValue(string sINIFile, string sSection, string sKey)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(sSection, sKey, "", temp, 255, sINIFile);
            return temp.ToString();
        }

    }
}
