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