using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Studio_Money.Classes;

using Infragistics.Shared;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTree;
using Infragistics.Win.UltraWinToolbars;
using Infragistics.Win.UltraWinEditors;

using FirebirdSql.Data.FirebirdClient;

using StudioByte.StudioMoney.Bank.BE;
using StudioByte.StudioMoney.Bank.Data;
using StudioByte.StudioMoney.Bank.Business;

using StudioByte.StudioMoney.Global.BE;

using StudioByte.Database.Business;

namespace Studio_Money.Forms
{
    public partial class frmMain : Form
    {

        private Form _form;

        clsStudioMoney clsGeneral = new clsStudioMoney();
        clsSounds clsSounds = new clsSounds();
        private clsListViewColumnSorter lvwColumnSorter;
        protected Object oConnection;
        public String sOpenedMenuItem = "";
        DataTable dtGrid;
        int nRecordsOnPage;
        int nTotalRecords;
        int nTotalPages;
        int nCurrentPage = 0;
        enum Navigation : int { First = 0, Previous = -1, Next = 1, Last = 2, Same = 3 };

        public frmMain(Form oForm)
        {
            this._form = oForm;
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

        }

        public frmMain()
        {

            try
            {
                InitializeComponent();

                // Get total records to show in grid
                nRecordsOnPage = int.Parse(clsGeneral.fnGetOptionValue("GridRecords").ToString());

                // Set caption controls
                clsGeneral.fnGetControlsCaptions(this);

                // Set caption to first panel in statusbar
                usbStatus.Panels[0].Text = clsGeneral.fnGetControlCaption(this, "usbStatus.Ready");
                usbStatus.Refresh();

                // Set database directory information to last panel in statusbar
                usbStatus.Panels[2].Text = clsGeneral.fnGetDatabasePath();

                // Set grid information
                //((UltraGridBase)(ugrGrid)).DisplayLayout.GroupByBox.Prompt = clsGeneral.fnGetControlCaption(this, "ugrGrid.Group");

                // Clear images of ImageList
                imlTreeView.Images.Clear();

                // Get image and caption to nodes
                foreach (TreeNode nNode in tvwTreeView.Nodes)
                {
                    nNode.Text = clsGeneral.fnGetControlCaption(this, nNode.Name);

                    if (File.Exists(clsGeneral.fnGetObjectPicturePath(nNode.Name))) {

                        imlTreeView.Images.Add(nNode.Name, ((Image)(System.Drawing.Bitmap.FromFile(clsGeneral.fnGetObjectPicturePath(nNode.Name)))));
                        nNode.ImageKey = nNode.Name;
                        nNode.SelectedImageKey = nNode.Name;
                    
                    }

                    fnSetNodeCaptionPicture(nNode);
                }

                foreach(UltraToolbar utbToolbar in utmToolbar.Toolbars) {

                    utbToolbar.Text = clsGeneral.fnGetControlCaption(this, utbToolbar.Key);

                }

                // Get all toolbars
                foreach (KeyedSubObjectBase oObject in utmToolbar.Toolbars.ToolbarsManager.Tools.All)
                {

                    // Set captions, pictures and tooltip to menu or button toolbar
                    fnSetToolbarProperties(oObject);

                }

                pnlBottom.Height = 25 * nRecordsOnPage;

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }
        }

        private void fnSetToolbarProperties(KeyedSubObjectBase oToolbar)
        {

            try
            {

                // Get all tools
                switch (oToolbar.GetType().ToString())
                {

                    // Get all menu tools
                    case "Infragistics.Win.UltraWinToolbars.PopupMenuTool":
                        {

                            // Define menu
                            PopupMenuTool oMenu = (PopupMenuTool)oToolbar;

                            // Set caption
                            oMenu.SharedProps.Caption = clsGeneral.fnGetControlCaption(this, oMenu.Key + "-Caption");

                            // Set tooltiptext
                            oMenu.SharedProps.ToolTipText = clsGeneral.fnGetControlCaption(this, oMenu.Key + "-ToolTipText");

                            foreach (KeyedSubObjectBase oTool in oMenu.Tools.All)
                            {
                                fnSetToolbarProperties(((Infragistics.Win.UltraWinToolbars.ToolBase)(oTool)));
                            }

                            break;

                        }

                    // Get all button tools
                    case "Infragistics.Win.UltraWinToolbars.ButtonTool":
                        {

                            // Define button
                            ButtonTool oButton = (ButtonTool)oToolbar;

                            // Set caption
                            oButton.SharedProps.Caption = clsGeneral.fnGetControlCaption(this, oButton.Key + "-Caption");

                            // Set tooltiptext
                            oButton.SharedProps.ToolTipText = clsGeneral.fnGetControlCaption(this, oButton.Key + "-ToolTipText");

                            // Define appearance 
                            Infragistics.Win.Appearance oButtonAppearance = new Infragistics.Win.Appearance();

                            if (System.IO.File.Exists(clsGeneral.fnGetObjectPicturePath(oButton.Key)) == true)
                            {
                                oButtonAppearance.Image = System.Drawing.Bitmap.FromFile(clsGeneral.fnGetObjectPicturePath(oButton.Key));
                            }

                            // Set image
                            oButton.SharedProps.AppearancesSmall.Appearance = oButtonAppearance;

                            break;

                        }

                }

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

        private void fnSetNodeCaptionPicture(TreeNode nNode)
        {

            try
            {

                foreach (TreeNode nNextNode in nNode.Nodes)
                {
                    
                    nNextNode.Text = clsGeneral.fnGetControlCaption(this, nNextNode.Name);

                    if (File.Exists(clsGeneral.fnGetObjectPicturePath(nNextNode.Name)))
                    {

                        imlTreeView.Images.Add(nNextNode.Name, ((Image)(System.Drawing.Bitmap.FromFile(clsGeneral.fnGetObjectPicturePath(nNextNode.Name)))));
                        nNextNode.ImageKey = nNextNode.Name;
                        nNextNode.SelectedImageKey = nNextNode.Name;

                    }

                    fnSetNodeCaptionPicture(nNextNode);

                }
            }

            catch(Exception ex) 
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }
        }

        private void mnuCadastreBank_Click(object sender, EventArgs e)
        {
            clsSounds.fnPlay("Click");
            fnOpenMenuItem("CadastreBank");
        }

        private void fnOpenMenuItem(String sCaption)
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor; 

                // Set caption to fist panel in statusbar
                usbStatus.Panels[0].Text = clsGeneral.fnGetControlCaption(this, "usbStatus.Grid.Loading");
                usbStatus.Refresh();
                
                switch (sCaption.Substring(3, sCaption.Length - 3))
                {

                    case "CadastreBank":

                        frmCadastreBank _frmCadastreBank = new frmCadastreBank();
                        _frmCadastreBank.MdiParent = this;

                        sOpenedMenuItem = "CadastreBank";

                        //spcRight.Visible = true;

                        lblCurrentHeader.Text = clsGeneral.fnGetControlCaption(this, "lblCurrentHeader-Bank");
                        lblCurrentHeaderSub.Text = clsGeneral.fnGetControlCaption(this, "lblCurrentHeaderSub-Bank");

                        _frmCadastreBank.Dock = DockStyle.Fill;
                        _frmCadastreBank.Show();

                        pcbCurrentPicture.ImageLocation = clsGeneral.fnGetObjectPicturePath("Bank-Large");

                        fnGridPopulate(sCaption);

                        break;
                }

                usbStatus.Panels[0].Text = clsGeneral.fnGetControlCaption(this, "usbStatus.Ready");
                usbStatus.Refresh();

                Cursor.Current = Cursors.Default;

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsSounds.fnPlay("Logon");

            fnShowHideHome(true);

        }

        private void utmToolbar_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            clsSounds.fnPlay("Click");
            fnOpenMenuItem(((UltraToolbarsManager)(sender)).ActiveTool.Key);
        }

        public void fnGridPopulate(params object[] args)
        {

            try
            {
                String sCaption = "";
                String sParameters = "";

                for (int i = 1; i < args.GetLength(0) + 1; i++)
                {

                    if (i == 1)
                    {
                        sCaption = (String)args[i - 1];
                    }

                    else
                    {
                        sParameters += (String)args[i - 1];
                    }

                }

                switch (sCaption.Substring(3, sCaption.Length - 3))
                {

                    case "CadastreBank":

                        Database objDatabase = new Database();
                        oConnection = (Object)objDatabase.oConnection;

                        // Instantiate BE class
                        BankBE objBE = new BankBE();

                        // Fill BE class properties
                        objBE.oConnection = oConnection;

                        if (sParameters != "")
                        {
                            objBE.sSearchCommand = sParameters;
                        }

                        // Instantiate Business class
                        Bank objBusiness = new Bank();

                        // Fill Business class properties
                        objBusiness.ObjBankBE = objBE;

                        // Fill Grid

                        // Create datatable with same structure of returned datatable by fill grid function

                        if (sParameters == "")
                        {
                            dtGrid = objBusiness.fnGetBank();
                        }
                        else
                        {
                            dtGrid = objBusiness.fnSearchBank();
                        }

                        fnPaginateGrid(Navigation.First);

                        break;

                }

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

        private void fnPaginateGrid(params object[] args)
        {

            try
            {

                int nPage = 0;
                int nFirstRecord = 0;
                int nLastRecord = 0;
                int nCurrentRecord = 0;

                usbStatus.Panels[0].Text = clsGeneral.fnGetControlCaption(this, "usbStatus.Grid.Loading");
                usbStatus.Refresh();

                for (int i = 1; i < args.GetLength(0) + 1; i++)
                {
                    switch (i)
                    {
                        case 1: nPage = (int)args[i - 1]; break;
                        case 2: nFirstRecord = (int)args[i - 1]; break;
                        case 3: nLastRecord = (int)args[i - 1]; break;
                    }
                }

                // First page
                if (nPage == Navigation.First.GetHashCode()) { nCurrentPage = 1; };
                // Previous page
                if (nPage == Navigation.Previous.GetHashCode()) { nCurrentPage = int.Parse(txtCurrentRecord.Text) - 1; };
                // Next page
                if (nPage == Navigation.Next.GetHashCode()) { nCurrentPage = int.Parse(txtCurrentRecord.Text) + 1; };
                // Last page
                if (nPage == Navigation.Last.GetHashCode()) { nCurrentPage = nTotalPages; };
                // Same page
                if (nPage == Navigation.Same.GetHashCode()) { nCurrentPage = int.Parse(txtCurrentRecord.Text); };

                nTotalRecords = dtGrid.Rows.Count;
                nTotalPages = nTotalRecords / nRecordsOnPage;

                if (nTotalRecords % nRecordsOnPage > 0)
                {
                    nTotalPages += 1;
                }

                if ((nCurrentPage < 1 || nCurrentPage > nTotalPages) && nTotalPages > 0)
                {
                    nCurrentPage = 1;
                }

                if (nFirstRecord <= 0 && nFirstRecord <= 1)
                {
                    nFirstRecord = nRecordsOnPage * (nCurrentPage - 1);
                    nLastRecord = nFirstRecord + nRecordsOnPage - 1;
                }
                else
                {
                    nCurrentPage = (nFirstRecord / nRecordsOnPage) + 1;
                }

                if (nLastRecord > nTotalRecords - 1)
                {
                    nLastRecord = nTotalRecords - 1;
                }

                ubtFirst.Enabled = true;
                ubtPrevious.Enabled = true;
                ubtNext.Enabled = true;
                ubtLast.Enabled = true;

                if (nCurrentPage == 1)
                {
                    ubtFirst.Enabled = false;
                    ubtPrevious.Enabled = false;
                }
                else if (nCurrentPage == nTotalPages)
                {
                    ubtNext.Enabled = false;
                    ubtLast.Enabled = false;
                }

                txtCurrentRecord.Text = nCurrentPage.ToString().Trim();
                lblNavigator.Text = clsGeneral.fnGetControlCaption(this, "lblNavigator") + " " + nTotalPages.ToString().Trim();

                DataTable dt = dtGrid.Clone();

                // Fill datatable
                for (int nRecord = nFirstRecord; nRecord <= nLastRecord; nRecord++)
                {
                    dt.ImportRow(dtGrid.Rows[nRecord]);
                }

                // Bind datatable to listview
                lvwGrid.Items.Clear();
                lvwGrid.Columns.Clear();

                // Create header columns
                for (int iCol = 0; iCol < dtGrid.Columns.Count; iCol++)
                {
                    System.Windows.Forms.ColumnHeader ch = new System.Windows.Forms.ColumnHeader();

                    switch (sOpenedMenuItem)
                    {
                        case "CadastreBank":
                            {
                                switch (iCol)
                                {
                                    case 0: ch.Text = clsGeneral.fnGetControlCaption(this, "ugrGrid-Bank-Code"); break;
                                    case 1: ch.Text = clsGeneral.fnGetControlCaption(this, "ugrGrid-Bank-Description"); break;
                                }
                                break;

                            }

                    }

                    lvwGrid.Columns.Add(ch);

                }

                // Create first column 
                if (dtGrid.Rows.Count > 0)
                {

                    for (nCurrentRecord = nFirstRecord; nCurrentRecord < nLastRecord + 1; nCurrentRecord++)
                    {

                        DataRow dr = dtGrid.Rows[nCurrentRecord];

                        ListViewItem lvwItem = new ListViewItem(dr[dtGrid.Columns[0]].ToString());
                        lvwGrid.Items.Add(lvwItem);
                        lvwGrid.Columns[0].Width = -2;

                        for (int iCol = 1; iCol <= dtGrid.Columns.Count - 1; iCol++)
                        {

                            // Create other columns
                            ListViewItem.ListViewSubItem lvwSubItem = new ListViewItem.ListViewSubItem(lvwItem, dr[dtGrid.Columns[iCol]].ToString());
                            lvwItem.SubItems.Add(lvwSubItem);
                            lvwGrid.Columns[iCol].Width = -1;

                        }

                    }

                }

                lvwGrid.Columns[lvwGrid.Columns.Count - 1].Width = -2;

                usbStatus.Panels[0].Text = clsGeneral.fnGetControlCaption(this, "usbStatus.Ready");
                usbStatus.Refresh();

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

        private void ubtNew_Click(object sender, EventArgs e)
        {

            try
            {
                clsSounds.fnPlay("Click");

                if (!sOpenedMenuItem.Equals(""))
                {
                    foreach (Control oControl in this.Controls)
                    {
                        if (oControl.Visible == true)
                        {

                            if (oControl.Tag != null)
                            {
                                if (oControl.Tag.ToString().ToLower() == "first control") { oControl.Focus(); }
                            }

                            fnFocusFirstControl(oControl);
                        }

                    }

                }

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

        private void fnFocusFirstControl(Control oControl)
        {

            try
            {
                fnSetEmptyCaption(oControl);

                foreach (Control oChildControl in oControl.Controls)
                {

                    if (oChildControl.Tag != null)
                    {
                        if (oChildControl.Tag.ToString().ToLower() == "first control") { oChildControl.Focus(); }
                    }

                    if (oChildControl.Controls.Count > 0) { fnFocusFirstControl(oChildControl); }

                }

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

        private void fnSetEmptyCaption(Control oControl)
        {

            try
            {
                if (oControl.Name.Length > 3)
                {
                    if (oControl.Name.Substring(0, 3) == "txt")
                    {
                        oControl.Text = "";
                    }
                }

                foreach (Control oChildControl in oControl.Controls)
                {
                    fnSetEmptyCaption(oChildControl);
                }

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

        private void ubtFirst_Click(object sender, EventArgs e)
        {
            clsSounds.fnPlay("Click");
            fnPaginateGrid(Navigation.First);
        }

        private void ubtLast_Click(object sender, EventArgs e)
        {
            clsSounds.fnPlay("Click");
            fnPaginateGrid(Navigation.Last);
        }

        private void ubtNext_Click(object sender, EventArgs e)
        {
            clsSounds.fnPlay("Click");
            fnPaginateGrid(Navigation.Next);
        }

        private void ubtPrevious_Click(object sender, EventArgs e)
        {
            clsSounds.fnPlay("Click");
            fnPaginateGrid(Navigation.Previous);
        }

        private void ubtDelete_Click(object sender, EventArgs e)
        {

            try
            {
                clsSounds.fnPlay("Click");
                usbStatus.Panels[0].Text = clsGeneral.fnGetControlCaption(this, "usbStatus.Deleting");
                usbStatus.Refresh();

                if (lvwGrid.SelectedItems.Count > 0)
                {

                    // Play defined sound
                    clsSounds.fnPlay("Attention");

                    if (MessageBox.Show(clsGeneral.fnGetControlCaption(this, "msgDelete.Confirm"), clsGeneral.fnGetControlCaption(this, "msgDelete.Header"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Database objDatabase = new Database();
                        oConnection = (Object)objDatabase.oConnection;

                        // Instantiate BE class
                        BankBE objBE = new BankBE();

                        // Fill BE class properties
                        objBE.oConnection = oConnection;
                        objBE.nBank = Int32.Parse(lvwGrid.SelectedItems[0].Text);

                        // Instantiate Business class
                        Bank objBusiness = new Bank();

                        // Fill Business class properties
                        objBusiness.ObjBankBE = objBE;

                        // Fill Grid

                        // Try delete record
                        // If there wasn't an error
                        if (objBusiness.fnDeleteBank() == 0)
                        {
                            // Get selected index on datatable and listview to delete
                            int nSelectedIndex = lvwGrid.SelectedItems[0].Index;
                            int nSelectedRecord = nSelectedIndex + (nRecordsOnPage * (nCurrentPage - 1));

                            // Get DataTable records
                            DataRowCollection rc = dtGrid.Rows;

                            // Delete record from datatable
                            rc[nSelectedRecord].Delete();
                            dtGrid.AcceptChanges();

                            // Remove record from listview
                            lvwGrid.Items.Remove(lvwGrid.SelectedItems[0]);

                            // If there aren't record on listview
                            if (lvwGrid.Items.Count == 0)
                            {
                                // Return to previous page
                                fnPaginateGrid(Navigation.Previous);
                            }
                            else
                            {
                                // Stand on same page
                                fnPaginateGrid(Navigation.Same);
                            }

                            // If there are record on listview
                            if (lvwGrid.Items.Count > 0)
                            {
                                // Select next record on listview
                                lvwGrid.Items[nSelectedIndex - 1].Selected = true;
                                lvwGrid.Select();
                                lvwGrid.Focus();
                                lvwGrid_Click(null, null);
                            }
                            else
                            {
                                // Clean all fields on screen
                                ubtNew_Click(null, null);
                            }

                            clsSounds.fnPlay("Deleted");

                        }

                    }

                    else
                    {
                        lvwGrid.Items[lvwGrid.SelectedItems[0].Index].Selected = true;
                        lvwGrid.Select();
                        lvwGrid.Focus();
                    }
                }
                else
                {
                    // Play defined sound
                    clsSounds.fnPlay("Error");

                    clsGeneral.fnMessageBox(clsGeneral.fnGetControlCaption(this, "msgDelete.NoRecord"), clsGeneral.fnGetControlCaption(this, "msgDelete.Header"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                usbStatus.Panels[0].Text = clsGeneral.fnGetControlCaption(this, "usbStatus.Ready");

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

         private void ubtSave_Click(object sender, EventArgs e)
        {

            try
            {
                clsSounds.fnPlay("Click");
                usbStatus.Panels[0].Text = clsGeneral.fnGetControlCaption(this, "usbStatus.Saving");
                usbStatus.Refresh();

                int nSelectedRecord = 0;
                int nSelectedIndex = 0;

                // Case edit item
                if (lvwGrid.SelectedItems.Count > 0)
                {
                    // Get selected index on datatable and listview to delete
                    nSelectedIndex = lvwGrid.SelectedItems[0].Index;
                    nSelectedRecord = nSelectedIndex + (nRecordsOnPage * (nCurrentPage - 1));
                }

                switch (sOpenedMenuItem)
                {

                    case "CadastreBank":
                        {

                            frmCadastreBank _frmCadastreBank = (frmCadastreBank)this._form;

                            if (fnValidateEmpty(_frmCadastreBank.txtCode, _frmCadastreBank.txtDescription) == true)
                            {
                                Database objDatabase = new Database();
                                oConnection = (Object)objDatabase.oConnection;

                                // Instantiate BE class
                                BankBE objBE = new BankBE();

                                // Fill BE class properties
                                objBE.oConnection = oConnection;
                                objBE.nBank = Int32.Parse(_frmCadastreBank.txtCode.Text);
                                objBE.sBank = _frmCadastreBank.txtDescription.Text;

                                // Instantiate Business class
                                Bank objBusiness = new Bank();

                                // Fill Business class properties
                                objBusiness.ObjBankBE = objBE;

                                // Fill Grid

                                // Try delete record
                                // If there wasn't an error
                                Int32 nResult = objBusiness.fnSaveBank();

                                if (nResult > 1)
                                {

                                    // Get datatable records
                                    switch (nResult)
                                    {
                                        // Added
                                        case 3:
                                            {
                                                DataRow dr = dtGrid.NewRow();

                                                dr[0] = objBE.nBank;
                                                dr[1] = objBE.sBank;

                                                // Add record to datatable
                                                dtGrid.Rows.Add(dr);

                                                // Go to last page
                                                fnPaginateGrid(Navigation.Last);

                                                // Select last register - added register
                                                lvwGrid.Items[lvwGrid.Items.Count - 1].Selected = true;
                                                lvwGrid.Select();

                                                clsSounds.fnPlay("Added");

                                                break;
                                            }

                                        // Updated
                                        case 2:
                                            {

                                                DataRow dr = dtGrid.Rows[nSelectedRecord];

                                                // Update datatable
                                                dr[0] = objBE.nBank;
                                                dr[1] = objBE.sBank;

                                                // Update record on datatable
                                                dtGrid.AcceptChanges();

                                                // Update listview
                                                lvwGrid.Items[nSelectedIndex].SubItems[1].Text = objBE.sBank;

                                                // Select updated record
                                                lvwGrid.Items[nSelectedIndex].Selected = true;
                                                lvwGrid.Select();

                                                clsSounds.fnPlay("Updated");

                                                break;
                                            }

                                        // Error
                                        default:
                                            {
                                                // Play defined sound
                                                clsSounds.fnPlay("Error");

                                                clsGeneral.fnMessageBox(clsGeneral.fnGetControlCaption(this, "msgSave.Error"), clsGeneral.fnGetControlCaption(this, "msgSave.Header"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                                                break;
                                            }
                                    }


                                }

                            }

                            break;

                        }

                }

                usbStatus.Panels[0].Text = clsGeneral.fnGetControlCaption(this, "usbStatus.Ready");

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

        private bool fnValidateEmpty(params object[] args)
        {

            bool bValidate = true;

            try
            {

                for (int i = 0; i < args.GetLength(0); i++)
                {
                    if (args[i].GetType().ToString() == "Infragistics.Win.UltraWinEditors.UltraTextEditor")
                    {
                        if (((UltraTextEditor)(args[i])).Text == "")
                        {
                            ((UltraTextEditor)(args[i])).Appearance.BackColor = Color.Salmon;
                            bValidate = false;
                        }
                    }
                }

                if (bValidate == false)
                {
                    clsGeneral.fnMessageBox(clsGeneral.fnGetControlCaption(this, "msgMandatoryField"), clsGeneral.fnGetControlCaption(this, "msgMandatoryField.Header"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

            return bValidate;

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsSounds.fnPlay("Logout");
        }

        private void ubtSearch_Click(object sender, EventArgs e)
        {

            try
            {
                clsSounds.fnPlay("Click");

                switch (sOpenedMenuItem)
                {

                    case "CadastreBank":
                        {
                            // Instantiate BE class
                            GlobalBE.sOpenedItem = "utsMainBank";
                            break;
                        }

                }

                // Instantiate and open the form to search
                frmSearch _frmSearch = new frmSearch(this);
                _frmSearch.Show();

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

        private void tvwTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            clsSounds.fnPlay("Click");

            if (tvwTreeView.SelectedNode.Name != "tvwHome")
            {

                fnShowHideHome(false);
                fnOpenMenuItem(tvwTreeView.SelectedNode.Name);

            }

            else
            {
                fnShowHideHome(true);
            }

        }

        private void lvwGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwGrid_Click(object sender, EventArgs e)
        {

            try
            {
                clsSounds.fnPlay("Click");

                switch (sOpenedMenuItem)
                {

                    case "CadastreBank":
                        {

                            if (lvwGrid.SelectedItems.Count > 0)
                            {
                                frmCadastreBank _frmCadastreBank = (frmCadastreBank)this._form;

                                _frmCadastreBank.txtCode.Text = lvwGrid.SelectedItems[0].Text;
                                _frmCadastreBank.txtDescription.Text = lvwGrid.SelectedItems[0].SubItems[1].Text;
                            }
                            break;
                        }
                }
            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

        private void lvwGrid_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            try
            {
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    if (lvwColumnSorter.Order == SortOrder.Ascending)
                    {
                        lvwColumnSorter.Order = SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorter.Order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                this.lvwGrid.Sort();

            }

            catch (Exception ex)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                // Show exception in a message box
                clsGeneral.fnException(this, ex);

            }

        }

        private void lvwGrid_KeyUp(object sender, KeyEventArgs e)
        {
            lvwGrid_Click(null, null);
        }

        private void fnShowHideHome(bool bShow)
        {

            if (bShow == true)
            {
                pnlHeader.Visible = false;
                pnlBottom.Visible = false;
                splHorizontal.Visible = false;

                frmHome _frmHome = new frmHome();
                _frmHome.MdiParent = this;
                _frmHome.Show();
                _frmHome.WindowState = FormWindowState.Maximized;
            }

            else
            {

                this.ActiveMdiChild.Close();

                pnlHeader.Visible = true;
                pnlBottom.Visible = true;
                splHorizontal.Visible = true;

            }
        }

     }

}