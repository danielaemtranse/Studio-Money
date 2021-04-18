using System;
using System.Data;
using System.Windows.Forms;
using Studio_Money.Classes;
using StudioByte.StudioMoney.Main.BE;
using StudioByte.Database.Business;

namespace Studio_Money.Forms
{
    public partial class frmSearch : Form
    {

        private Form frmFather;
        clsStudioMoney clsGeneral = new clsStudioMoney();
        clsSounds clsSounds = new clsSounds();
        private clsListViewColumnSorter lvwColumnSorter;

        protected Object oConnection;

        public frmSearch()
        {
            InitializeComponent();

            // Set caption controls
            clsGeneral.fnGetControlsCaptions(this);

        }

        public frmSearch(Form oForm)
        {
            this.frmFather = oForm;
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // Set caption controls
            clsGeneral.fnGetControlsCaptions(this);

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            String sItem = "";

            // Bind datatable to listview
            lvwGrid.Items.Clear();
            lvwGrid.Columns.Clear();

            // Create header columns
            for (int iCol = 0; iCol < 3; iCol++)
            {
                System.Windows.Forms.ColumnHeader ch = new System.Windows.Forms.ColumnHeader();

                switch (iCol)
                {
                    case 0: ch.Text = clsGeneral.fnGetControlCaption(this, "lvwGrid-Field"); break;
                    case 1: ch.Text = clsGeneral.fnGetControlCaption(this, "lvwGrid-Operation"); break;
                    case 2: ch.Text = clsGeneral.fnGetControlCaption(this, "lvwGrid-Value"); break;
                }

                lvwGrid.Columns.Add(ch);

            }

            Database objDatabase = new Database();
            oConnection = (Object)objDatabase.oConnection;

            // Instantiate BE class
            MainBE objBE = new MainBE();

            // Fill BE class properties
            objBE.oConnection  = oConnection;
            objBE.sItem = GlobalBE.sOpenedItem;

            // Instantiate Business class
            StudioByte.StudioMoney.Main.Business.Main objBusiness = new StudioByte.StudioMoney.Main.Business.Main();

            // Fill Business class properties
            objBusiness.ObjMainBE = objBE;
            
            // Fill field combobox
            uceField.Items.Add(0, clsGeneral.fnGetControlCaption(this, "uceField"));

            switch (GlobalBE.sOpenedItem)
            {

                case "utsMainBank":
                    {
                        sItem = "-Bank"; break;
                    }

            }

            foreach (DataRow dr in objBusiness.fnGetFields().Rows) {

                uceField.Items.Add(dr["W_NOBJECT"].ToString(), clsGeneral.fnGetControlCaption("frmMain", "lbl" + dr["W_SOBJECT"].ToString().Substring(3) + sItem));

            }

            uceField.SelectedIndex = 0;

            // Fill operation combobox
            uceOperation.Items.Add(0, clsGeneral.fnGetControlCaption(this, "uceOperation"));
            uceOperation.Items.Add(1, clsGeneral.fnGetControlCaption(this, "uceOperation.Equals"));
            uceOperation.Items.Add(2, clsGeneral.fnGetControlCaption(this, "uceOperation.Content"));
            uceOperation.Items.Add(3, clsGeneral.fnGetControlCaption(this, "uceOperation.Greater"));
            uceOperation.Items.Add(4, clsGeneral.fnGetControlCaption(this, "uceOperation.Smaller"));
            uceOperation.Items.Add(5, clsGeneral.fnGetControlCaption(this, "uceOperation.Different"));
            uceOperation.Items.Add(6, clsGeneral.fnGetControlCaption(this, "uceOperation.Beginning"));
            uceOperation.Items.Add(7, clsGeneral.fnGetControlCaption(this, "uceOperation.Finishing"));

            uceOperation.SelectedIndex = 0;

            lvwGrid.Columns[lvwGrid.Columns.Count - 1].Width = -2;

        }

        private void ubtClose_Click(object sender, EventArgs e)
        {
            clsSounds.fnPlay("Click");
            this.Close();
        }

         private void ubtAdd_Click(object sender, EventArgs e)
        {

            clsSounds.fnPlay("Click");

            // If any field don't have value
            if (uceField.SelectedIndex == 0 || uceOperation.SelectedIndex == 0 || txtValue.Text.Trim() == "")
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                clsGeneral.fnMessageBox(clsGeneral.fnGetControlCaption(this, "msgSearch.NoValue"), clsGeneral.fnGetControlCaption(this, "msgSearch.Header"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {

                // Field
                ListViewItem lvwItem = new ListViewItem(uceField.Text);
                lvwGrid.Items.Add(lvwItem);
                lvwGrid.Columns[0].Width = -2;

                // Operation
                ListViewItem.ListViewSubItem lvwSubItemOperation = new ListViewItem.ListViewSubItem(lvwItem, uceOperation.Text);
                lvwItem.SubItems.Add(lvwSubItemOperation);
                lvwGrid.Columns[1].Width = -1;

                // Value
                ListViewItem.ListViewSubItem lvwSubItemValue = new ListViewItem.ListViewSubItem(lvwItem, txtValue.Text);
                lvwItem.SubItems.Add(lvwSubItemValue);
                lvwGrid.Columns[2].Width = -1;

            }
        }

        private void ubtRemove_Click(object sender, EventArgs e)
        {
            clsSounds.fnPlay("Click");

            if (lvwGrid.SelectedItems.Count == 0)
            {

                // Play defined sound
                clsSounds.fnPlay("Error");

                clsGeneral.fnMessageBox(clsGeneral.fnGetControlCaption(this, "msgSearch.NoItemSelected"), clsGeneral.fnGetControlCaption(this, "msgSearch.Header"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {
                foreach (ListViewItem oItem in lvwGrid.SelectedItems)
                {
                    lvwGrid.Items.Remove(oItem);
                }
            }
        }

        private void ubtSearch_Click(object sender, EventArgs e)
        {
            clsSounds.fnPlay("Click");

            frmMain _frmMain = (frmMain)this.frmFather;
            _frmMain.ubtSearch.Visible = false;
            _frmMain.ubtUndo.Visible = true;

            foreach (ListViewItem lvwItem in lvwGrid.Items)
            {


            }

            _frmMain.fnGridPopulate(_frmMain.sOpenedMenuItem);

            this.Close();

        }

        private void lvwGrid_ColumnClick(object sender, ColumnClickEventArgs e)
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

        private void lvwGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
