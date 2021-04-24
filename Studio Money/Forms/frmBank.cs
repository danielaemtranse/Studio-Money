using System;
using System.Drawing;
using System.Windows.Forms;
using StudioMoney.Classes;

namespace StudioMoney.Forms
{
    public partial class frmBank : Form
    {

        private Form frmFather;
        clsStudioMoney clsGeneral = new clsStudioMoney();
        clsSounds clsSounds = new clsSounds();

        public frmBank()
        {
            InitializeComponent();

            // Set caption controls
            clsGeneral.fnGetControlsCaptions(this);

        }

        public frmBank(Form oForm)
        {
            this.frmFather = oForm;
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // Set caption controls
            clsGeneral.fnGetControlsCaptions(this);

            Int32 iIndex = 0;

            foreach(Infragistics.Win.UltraWinTabControl.UltraTab utsTab in utsMainBank.Tabs) {

                utsTab.Text = clsGeneral.fnGetControlCaption(this, "utsMainBank.Tabs[" + iIndex.ToString() + "]");
                iIndex++;

            }

        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.Appearance.BackColor = Color.Empty;
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            txtDescription.Appearance.BackColor = Color.Empty;
        }

    }
}