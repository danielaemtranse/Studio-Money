using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using StudioByte.StudioMoney.Configuration.BE;
using StudioByte.StudioMoney.Configuration.Data;
using StudioByte.StudioMoney.Configuration.Business;
using Studio_Money.Classes;

namespace Studio_Money.Classes
{
    class clsValidate
    {

        clsStudioMoney clsGeneral = new clsStudioMoney();
        clsSounds clsSounds = new clsSounds();

        public bool fnValidateMandatoryFields(params Control[] aControl)
        {
            int x;
            bool bRedField = false;

            // Loop through all controls passed by
            for (x = 1; x <= aControl.Length - 1; x++)
            {
                // If control in the form is equal control passed by
                // and is a mandatory field with no data
                if (aControl[x].Text.Equals(""))
                {

                    // Set background color of control to red 
                    aControl[x].BackColor = System.Drawing.Color.Tomato;
                    bRedField = true;
                }

            }

            // if there are problems with mandatory fields
            if (bRedField == true)
            {

                // Instantiate BE class
                ConfigurationBE objBE = new ConfigurationBE();

                // Instantiate Business class
                Configuration objBusiness = new Configuration();

                // Fill Business class properties
                objBusiness.ObjConfigurationBE = objBE;

                // Execute Business class method

                // Play defined sound
                clsSounds.fnPlay("Attention");

                // Show message about problem with mandatory field 
                clsGeneral.fnMessageBox (objBusiness.fnGetObjectCaption(aControl[0].Name.ToString(), "sMsg01"), objBusiness.fnGetObjectCaption(aControl[0].Name.ToString(), "sMsgAttentionCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return !bRedField;
        }

        public bool fnIsValidEmailAddress(string sEmail)
        {
            if (sEmail == null)
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(sEmail, @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|[a-zA-Z]{2})$", RegexOptions.IgnorePatternWhitespace);
            }
        }

    }
}
