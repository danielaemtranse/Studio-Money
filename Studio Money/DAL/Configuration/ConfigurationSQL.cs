using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using StudioMoney.BE;

namespace StudioMoney.DAL.Configuration
{
    public class ConfigurationSQL : IConfiguration
    {
        private ConfigurationBE objConfigurationBE;
        public string SLanguageIniFile;
        public string SConfigurationIniFile;

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
            return fnGetIniValue(ObjConfigurationBE.sConfigurationINIFile, "Register", "Language");
        }

        public void fnSetCurrentLanguage(String sLanguage)
        {
            fnSetIniValue(ObjConfigurationBE.sConfigurationINIFile, "Register", "Language", sLanguage);
            ObjConfigurationBE.sLanguage = sLanguage;
        }

        public DataTable fnGetExistentLanguages()
        {
            // Get existent languages in the specified directory
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(fnGetIniFileDirectory());

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
                    SLanguageIniFile = f.FullName.ToString();

                    // Add register about current language
                    DataRow drLanguage = dtLanguage.NewRow();
                    drLanguage["sLanguage"] = fnGetIniValue(SLanguageIniFile, "Configuration", "Description");
                    drLanguage["sIcon"] = ObjConfigurationBE.sApplicationDirectory + "Languages\\" + fnGetIniValue(SLanguageIniFile, "Configuration", "Icon");
                    drLanguage["sKey"] = fnGetIniValue(SLanguageIniFile, "Configuration", "Icon");
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
            return ObjConfigurationBE.sApplicationDirectory + "Sounds\\" + fnGetIniValue(ObjConfigurationBE.sConfigurationINIFile, "Sounds", sEventName);
        }

        public Boolean fnGetIfSoundIsOn()
        {
            return (fnGetIniValue(ObjConfigurationBE.sConfigurationINIFile, "Sounds", "OnOff") == "1" ? true : false);
        }

        public String fnGetRegisteredUser()
        {
            return fnGetIniValue(ObjConfigurationBE.sConfigurationINIFile, "Register", "User");
        }

        public void fnSetRegisteredUser(String sRegisteredUser, String sRegisteredUserEMail)
        {
            fnSetIniValue(ObjConfigurationBE.sConfigurationINIFile, "Register", "User", sRegisteredUser);
            fnSetIniValue(ObjConfigurationBE.sConfigurationINIFile, "Register", "EMail", sRegisteredUserEMail);
            ObjConfigurationBE.sRegisteredUser = sRegisteredUser;
        }

        public string fnGetIniFileDirectory()
        {
            return System.IO.Path.GetDirectoryName(ObjConfigurationBE.sApplicationDirectory) + "\\Languages";
        }

        public bool fnGetExistentFile()
        {
            return File.Exists(fnGetIniFileDirectory());
        }

        public String fnGetObjectCaption(String sFormName, String sObjectName)
        {
            return fnGetIniValue(fnGetIniFileDirectory() + "\\" + fnGetCurrentLanguage(), sFormName, sObjectName);
        }

        public String fnGetObjectPicturePath(String sObjectName)
        {
            return System.IO.Path.GetDirectoryName(ObjConfigurationBE.sApplicationDirectory) + "\\Images\\" + fnGetIniValue(ObjConfigurationBE.sConfigurationINIFile, "Pictures", sObjectName);
        }

        public String fnGetOptionValue(String sOption)
        {
            return fnGetIniValue(ObjConfigurationBE.sConfigurationINIFile, "Options", sOption);
        }

        public String fnGetDatabase(String sKey)
        {
            return ObjConfigurationBE.sApplicationDirectory + fnGetIniValue(ObjConfigurationBE.sConfigurationINIFile, "Database", sKey);
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
        public void fnSetIniValue(string sINIFile, string sSection, string sKey, string sValue)
        {
            WritePrivateProfileString(sSection, sKey, sValue, sINIFile);
        }

        /// <summary>
        /// Get INI file data
        /// </summary>
        /// <PARAM name="sSection"></PARAM>
        /// <PARAM name="sKey"></PARAM>
        /// <returns></returns>
        public string fnGetIniValue(string sINIFile, string sSection, string sKey)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(sSection, sKey, "", temp, 255, sINIFile);
            return temp.ToString();
        }

    }
}
