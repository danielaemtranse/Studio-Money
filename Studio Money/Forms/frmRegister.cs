using System;
using System.Drawing;
using System.Windows.Forms;
using StudioMoney.BE;
using StudioMoney.BLL;
using StudioMoney.Classes;

namespace StudioMoney.Forms
{
    public partial class frmRegister : Form
    {

        clsStudioMoney clsGeneral = new clsStudioMoney();
        clsValidate clsValidate = new clsValidate();
        clsSounds clsSounds = new clsSounds();
        Color oInitialBackColor;

        public frmRegister()
        {
            InitializeComponent();
            clsGeneral.fnGetControlsCaptions(this);
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

            oInitialBackColor = txtUser.Appearance.BackColor;
            
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Appearance.BackColor = oInitialBackColor;
        }

        private void txtEMail_Enter(object sender, EventArgs e)
        {
            txtEMail.Appearance.BackColor = oInitialBackColor;
        }

        private void frmRegister_KeyDown(object sender, KeyEventArgs e)
        {
            bool bFocusedControl = false;

            foreach (Control oControl in this.Controls)
            {
                if (oControl.Text.Contains("&") == true && (oControl.GetType() == typeof(Infragistics.Win.UltraWinEditors.UltraTextEditor) || oControl.GetType() == typeof(Label)))
                {
                    string sKey="";

                    for (int x = 0; x <= oControl.Text.Length; x++)
                    {

                        if (oControl.Text.Substring(x, 1) == "&")
                        {
                            sKey = oControl.Text.Substring(x+1, 1).ToString();
                            break;
                        }

                    }

                    if (e.Alt && e.KeyCode.ToString() == sKey.ToString())
                    {
                        foreach (Control oControl2 in this.Controls)
                        {
                            if (oControl2.Tag != null)
                            {
                                if (oControl2.Tag.ToString() == oControl.Name.ToString())
                                {

                                    Application.DoEvents();
                                    oControl2.Focus();
                                    bFocusedControl = true;
                                    break;
                                }
                            }
                        }
                    }
                }

                if (bFocusedControl == true) { break; }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            // Play defined sound
            clsSounds.fnPlay("Click");
            this.Close();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            // Instantiate BE class
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            // Play defined sound
            clsSounds.fnPlay("Click");

            // Validate mandatory fields
            if (clsValidate.fnValidateMandatoryFields(this, txtUser, txtEMail) == true)
            {

                // Validate e-mail field
                if (clsValidate.fnIsValidEmailAddress(txtEMail.Text) == false)
                {

                    // Play defined sound
                    clsSounds.fnPlay("Error");

                    // Show message about problem with mandatory field 
                    clsGeneral.fnMessageBox(objBusiness.fnGetObjectCaption(this.Name.ToString(), "sValidateEMail"), objBusiness.fnGetObjectCaption(this.Name.ToString(), "sMsgErrorCaption"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {

                    objBusiness.fnSetRegisteredUser(txtUser.Text, txtEMail.Text);
                    this.Close();

                }

            }
        }

    }
}