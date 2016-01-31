using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using StudioByte.StudioMoney.Configuration.BE;
using StudioByte.StudioMoney.Configuration.Data;
using StudioByte.StudioMoney.Configuration.Business;
using Studio_Money.Classes;

namespace Studio_Money.Forms
{
    public partial class frmLanguage : Form
    {

        clsStudioMoney clsGeneral = new clsStudioMoney();

        public frmLanguage()
        {
            InitializeComponent();

            // Instantiate BE
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            // Execute Business class method

            if (objBusiness.fnGetCurrentLanguage() != "")
            {
                clsGeneral.fnGetControlsCaptions(this);
            }

        }

        private void frmLanguage_Load(object sender, EventArgs e)
        {

            // Instantiate BE
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate Business class
            Configuration objBusiness = new Configuration();

            // Fill Business class properties
            objBusiness.ObjConfigurationBE = objBE;

            // Execute Business class method

            // Get dataset contenting existents languages
            DataTable dtLanguages = objBusiness.fnGetExistentLanguages();

            // Clean language list of existents languages
            lvwLanguages.Items.Clear();
            lvwLanguages.View = View.Details;
            lvwLanguages.AllowColumnReorder = true;
            lvwLanguages.FullRowSelect = true;

            // Clean image list
            imlImagens.Images.Clear();

            // Associate Listview to Imagelist
            lvwLanguages.SmallImageList = imlImagens;

            // Fill list of exitents languages
            foreach (DataRow dr in dtLanguages.Rows)
            {

                try
                {
                    // Add language icon to ImageList
                    imlImagens.Images.Add(Image.FromFile(dr["sIcon"].ToString()));
                }
                catch
                {
                }

                lvwLanguages.Columns.Add("Languages", -2, HorizontalAlignment.Left);

                ListViewItem oItem = new ListViewItem(dr["sLanguage"].ToString(), imlImagens.Images.Count-1);

                // Define tag 
                oItem.Tag = dr["sFile"].ToString();

                lvwLanguages.Items.Add(oItem);

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            // Save language information

            // Instantiate BE
            ConfigurationBE objBE = new ConfigurationBE();

            // Instantiate business class
            Configuration objBusiness = new Configuration();

            // Fill properties of business class
            objBusiness.ObjConfigurationBE = objBE;

            // Instantiate sound class
            clsSounds clsSounds = new clsSounds();

            // Play defined sound
            clsSounds.fnPlay("Click");

            // Get selected language
            ListView.SelectedListViewItemCollection oSelectedItems = lvwLanguages.SelectedItems;

            if (oSelectedItems.Count.Equals(0))
            {

                // Play defined sound
                clsSounds.fnPlay("Attention");

                // Show message about problem with no selected language
                String sMessage = objBusiness.fnGetObjectCaption(this.Name.ToString(), "sMsg01");
                String sMessageCaption = objBusiness.fnGetObjectCaption(this.Name.ToString(), "sMsgAttentionCaption");

                if (sMessage.ToString().Equals(""))
                {
                    sMessage = "Select a language to continue.";
                    sMessageCaption = "Attention";
                }

                clsGeneral.fnMessageBox(sMessage, sMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                // Set language
                objBusiness.fnSetCurrentLanguage(oSelectedItems[0].Tag.ToString());

                // Close form
                this.Close();
            }

        }

    }
}