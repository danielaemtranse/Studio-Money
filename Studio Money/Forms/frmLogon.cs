using System;
using System.Windows.Forms;
using StudioMoney.Classes;

namespace StudioMoney.Forms
{
    public partial class frmLogon : Form
    {

        clsStudioMoney clsGeneral = new clsStudioMoney();

        public frmLogon()
        {
            InitializeComponent();
            clsGeneral.fnGetControlsCaptions(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}