using System;
using System.Windows.Forms;
using StudioMoney.Classes;

namespace StudioMoney.Forms
{
    public partial class frmSplash : Form
    {

        clsStudioMoney clsGeneral = new clsStudioMoney();

        public frmSplash()
        {
            InitializeComponent();
            clsGeneral.fnGetControlsCaptions(this);
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}