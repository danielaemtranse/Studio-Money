 using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using StudioByte.StudioMoney.Configuration.BE;
using StudioByte.StudioMoney.Configuration.Data;
using StudioByte.StudioMoney.Configuration.Business;
using Studio_Money.Forms;

namespace Studio_Money.Classes
{

    class clsStudioMoney
    {
        public static void Main()
        {
            String sRegisteredUser = null;
            String sLanguage = null;

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            // Execute Business class method

            // Get current language
            sLanguage = objBusiness.fnGetCurrentLanguage();

            // Get registered user
            sRegisteredUser = objBusiness.fnGetRegisteredUser();

            // Verify if language is defined
            if (sLanguage.Equals(""))
            {

                // If language isn't defined
                // instantiate and open the form to register language
                frmLanguage _frmLanguage = new frmLanguage();
                _frmLanguage.ShowDialog();

            }

            // If language is defined
            // verify if application is registered
            if (sRegisteredUser.Equals(""))
            {

                // If application isn't registered
                // instantiate and open the form to register user
                frmRegister _frmRegister = new frmRegister();
                _frmRegister.ShowDialog();

            }

            else
            {

                // If application is registered     
                // instantiate splash form
                frmSplash _frmSplash = new frmSplash();

                // Define register user 
                _frmSplash.lblUser.Text = sRegisteredUser;

                // Open splash form
                _frmSplash.Show();
                _frmSplash.Refresh();

                // Execute a delay about 2 seconds
                Thread.Sleep(2100);

                // Instantiate main form
                frmMain _frmMain = new frmMain();

                _frmSplash.Close();

                // Open main form
                _frmMain.ShowDialog();

            }

        }

        public void fnGetControlsCaptions(Form oForm)
        {

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            // Define Window caption
            oForm.Text = objBusiness.fnGetObjectCaption(oForm.Name.ToString(), oForm.Name.ToString());

            // Define caption of each Control in the Window
            foreach (Control oControl in oForm.Controls)
            {

                // Define Window caption
                oControl.Text = objBusiness.fnGetObjectCaption(oForm.Name.ToString(), oControl.Name.ToString());

                // Define each caption for each control in the window
                fnGetControlsCaptionsIterator(oForm, oControl);
            }

        }

        public void fnGetControlCaption(Form oForm, Control oControl)
        {

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            // Define Window caption
            oControl.Text = objBusiness.fnGetObjectCaption(oForm.Name.ToString(), oControl.Name.ToString());

        }

        public String fnGetControlCaption(Form oForm, String oControl)
        {

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            // Define Object caption
            return objBusiness.fnGetObjectCaption(oForm.Name.ToString(), oControl);

        }

        public String fnGetControlCaption(String oForm, String oControl)
        {

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            // Define Object caption
            return objBusiness.fnGetObjectCaption(oForm, oControl);

        }

        public void fnGetControlsCaptionsIterator(Form oForm, Control oControl) {

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            oControl.Text = objBusiness.fnGetObjectCaption(oForm.Name.ToString(), oControl.Name.ToString());

            if (oControl.HasChildren==true)
            {
                // Recursively call this method for each child control.
                foreach (Control oChildControl in oControl.Controls)
                {
                    fnGetControlsCaptionsIterator(oForm, oChildControl);
                }
            }

        }

        public String fnGetObjectPicturePath(String sObjectName)
        {

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            // Define Object caption
            return objBusiness.fnGetObjectPicturePath(sObjectName);

        }

        public String fnGetOptionValue(String sOption)
        {

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            // Define Object caption
            return objBusiness.fnGetOptionValue(sOption);

        }

        public String fnGetDatabase(String sKey)
        {

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            return objBusiness.fnGetDatabase(sKey);
            
        }

        public void fnMessageBox(string sMessage, string sCaption, MessageBoxButtons oButtons, MessageBoxIcon oIcon)
        {

            String sWindowsSystemSound;

            // Delete Windows System Sound temporarily            
            sWindowsSystemSound = (String)Registry.GetValue("HKEY_CURRENT_USER\\AppEvents\\Schemes\\Apps\\.Default\\SystemHand\\.Current", "", "");
            Registry.SetValue("HKEY_CURRENT_USER\\AppEvents\\Schemes\\Apps\\.Default\\SystemHand\\.Current", "", "");
            Registry.SetValue("HKEY_CURRENT_USER\\AppEvents\\Schemes\\Apps\\.Default\\SystemHand\\.Default", "", "");

            MessageBox.Show(sMessage, sCaption, oButtons, oIcon);

            // Undelete Windows System Sound
            Registry.SetValue("HKEY_CURRENT_USER\\AppEvents\\Schemes\\Apps\\.Default\\SystemHand\\.Current","", sWindowsSystemSound, RegistryValueKind.String);
            Registry.SetValue("HKEY_CURRENT_USER\\AppEvents\\Schemes\\Apps\\.Default\\SystemHand\\.Default","", sWindowsSystemSound, RegistryValueKind.String);

        }

        public void fnException(Form oForm, Exception ex)
        {

            fnMessageBox(fnGetControlCaption(oForm, "msgError.Message") + "\n\n" +
                         fnGetControlCaption(oForm, "msgError.Details") + ":\n" + 
                         ex.Message + "\n\n" +
                         fnGetControlCaption(oForm, "msgError.Source") + ":\n" + 
                         ex.Source + "\n\n" +
                         fnGetControlCaption(oForm, "msgError.InnerException") + ":\n" +
                         ex.InnerException + "\n\n" +
                         fnGetControlCaption(oForm, "msgError.StrackTrace") + ":\n" +
                         ex.StackTrace + "\n\n",
                         fnGetControlCaption(oForm, "msgError.Header"), MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
