using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Studio_Money.Classes;

namespace Studio_Money.Forms
{
    public partial class frmCadastreBank : Form
    {

        private Form frmFather;
        clsStudioMoney clsGeneral = new clsStudioMoney();
        clsSounds clsSounds = new clsSounds();

        public frmCadastreBank()
        {
            InitializeComponent();

            // Set caption controls
            clsGeneral.fnGetControlsCaptions(this);

        }

        public frmCadastreBank(Form oForm)
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