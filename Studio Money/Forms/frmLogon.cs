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