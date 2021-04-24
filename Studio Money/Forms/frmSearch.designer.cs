namespace StudioMoney.Forms
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.ubtClose = new Infragistics.Win.Misc.UltraButton();
            this.ubtSearch = new Infragistics.Win.Misc.UltraButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSub = new Infragistics.Win.Misc.UltraLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pcbHeader = new System.Windows.Forms.PictureBox();
            this.lblField = new System.Windows.Forms.Label();
            this.pcbField = new System.Windows.Forms.PictureBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.pcbOperation = new System.Windows.Forms.PictureBox();
            this.txtValue = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblValue = new System.Windows.Forms.Label();
            this.pcbValue = new System.Windows.Forms.PictureBox();
            this.ubtRemove = new Infragistics.Win.Misc.UltraButton();
            this.ubtAdd = new Infragistics.Win.Misc.UltraButton();
            this.uceOperation = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.uceField = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.lvwGrid = new System.Windows.Forms.ListView();
            this.pnlButtons.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uceOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uceField)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.BackgroundImage = global::StudioMoney.Properties.Resources.degrade_fd;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.ubtClose);
            this.pnlButtons.Controls.Add(this.ubtSearch);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 269);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(673, 45);
            this.pnlButtons.TabIndex = 24;
            // 
            // ubtClose
            // 
            appearance34.Image = ((object)(resources.GetObject("appearance34.Image")));
            this.ubtClose.Appearance = appearance34;
            this.ubtClose.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubtClose.ImageSize = new System.Drawing.Size(20, 20);
            this.ubtClose.Location = new System.Drawing.Point(12, 5);
            this.ubtClose.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ubtClose.Name = "ubtClose";
            this.ubtClose.Padding = new System.Drawing.Size(7, 5);
            this.ubtClose.Size = new System.Drawing.Size(103, 35);
            this.ubtClose.TabIndex = 7;
            this.ubtClose.Text = "&Fechar";
            this.ubtClose.Click += new System.EventHandler(this.ubtClose_Click);
            // 
            // ubtSearch
            // 
            appearance5.Image = ((object)(resources.GetObject("appearance5.Image")));
            this.ubtSearch.Appearance = appearance5;
            this.ubtSearch.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubtSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.ubtSearch.Location = new System.Drawing.Point(556, 5);
            this.ubtSearch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ubtSearch.Name = "ubtSearch";
            this.ubtSearch.Padding = new System.Drawing.Size(7, 5);
            this.ubtSearch.Size = new System.Drawing.Size(103, 35);
            this.ubtSearch.TabIndex = 6;
            this.ubtSearch.Text = "Pes&quisar";
            this.ubtSearch.Click += new System.EventHandler(this.ubtSearch_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = global::StudioMoney.Properties.Resources.backBlue;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.pcbHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(673, 77);
            this.pnlHeader.TabIndex = 23;
            // 
            // lblHeaderSub
            // 
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderSub.Appearance = appearance2;
            this.lblHeaderSub.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderSub.Location = new System.Drawing.Point(79, 32);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(505, 40);
            this.lblHeaderSub.TabIndex = 21;
            this.lblHeaderSub.Text = "Utilize os campos abaixo para definir qual (is) o(s) critério(s) para que o Studi" +
                "o Money possa realizar a sua pesquisa ";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(75, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(81, 22);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "Pesquisar";
            // 
            // pcbHeader
            // 
            this.pcbHeader.BackColor = System.Drawing.Color.Transparent;
            this.pcbHeader.Image = ((System.Drawing.Image)(resources.GetObject("pcbHeader.Image")));
            this.pcbHeader.Location = new System.Drawing.Point(12, 12);
            this.pcbHeader.Name = "pcbHeader";
            this.pcbHeader.Size = new System.Drawing.Size(44, 50);
            this.pcbHeader.TabIndex = 3;
            this.pcbHeader.TabStop = false;
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField.Location = new System.Drawing.Point(41, 94);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(48, 18);
            this.lblField.TabIndex = 27;
            this.lblField.Text = "&Campo";
            // 
            // pcbField
            // 
            this.pcbField.Image = ((System.Drawing.Image)(resources.GetObject("pcbField.Image")));
            this.pcbField.Location = new System.Drawing.Point(12, 90);
            this.pcbField.Name = "pcbField";
            this.pcbField.Size = new System.Drawing.Size(22, 22);
            this.pcbField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbField.TabIndex = 26;
            this.pcbField.TabStop = false;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(264, 94);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(63, 18);
            this.lblOperation.TabIndex = 30;
            this.lblOperation.Text = "&Operação";
            // 
            // pcbOperation
            // 
            this.pcbOperation.Image = ((System.Drawing.Image)(resources.GetObject("pcbOperation.Image")));
            this.pcbOperation.Location = new System.Drawing.Point(235, 90);
            this.pcbOperation.Name = "pcbOperation";
            this.pcbOperation.Size = new System.Drawing.Size(22, 22);
            this.pcbOperation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbOperation.TabIndex = 29;
            this.pcbOperation.TabStop = false;
            // 
            // txtValue
            // 
            this.txtValue.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.txtValue.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.txtValue.Location = new System.Drawing.Point(451, 118);
            this.txtValue.MaxLength = 33;
            this.txtValue.Name = "txtValue";
            this.txtValue.ShowOverflowIndicator = true;
            this.txtValue.Size = new System.Drawing.Size(210, 24);
            this.txtValue.TabIndex = 2;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(486, 94);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(37, 18);
            this.lblValue.TabIndex = 33;
            this.lblValue.Text = "&Valor";
            // 
            // pcbValue
            // 
            this.pcbValue.Image = ((System.Drawing.Image)(resources.GetObject("pcbValue.Image")));
            this.pcbValue.Location = new System.Drawing.Point(457, 90);
            this.pcbValue.Name = "pcbValue";
            this.pcbValue.Size = new System.Drawing.Size(22, 22);
            this.pcbValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbValue.TabIndex = 32;
            this.pcbValue.TabStop = false;
            // 
            // ubtRemove
            // 
            appearance6.Image = global::StudioMoney.Properties.Resources.delete_16;
            this.ubtRemove.Appearance = appearance6;
            this.ubtRemove.AutoSize = true;
            this.ubtRemove.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubtRemove.ImageSize = new System.Drawing.Size(20, 20);
            this.ubtRemove.Location = new System.Drawing.Point(631, 197);
            this.ubtRemove.Margin = new System.Windows.Forms.Padding(0);
            this.ubtRemove.Name = "ubtRemove";
            this.ubtRemove.Size = new System.Drawing.Size(30, 30);
            this.ubtRemove.TabIndex = 4;
            this.ubtRemove.Click += new System.EventHandler(this.ubtRemove_Click);
            // 
            // ubtAdd
            // 
            appearance4.Image = global::StudioMoney.Properties.Resources.add_16;
            this.ubtAdd.Appearance = appearance4;
            this.ubtAdd.AutoSize = true;
            this.ubtAdd.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubtAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.ubtAdd.Location = new System.Drawing.Point(631, 157);
            this.ubtAdd.Margin = new System.Windows.Forms.Padding(0);
            this.ubtAdd.Name = "ubtAdd";
            this.ubtAdd.Size = new System.Drawing.Size(30, 30);
            this.ubtAdd.TabIndex = 3;
            this.ubtAdd.Click += new System.EventHandler(this.ubtAdd_Click);
            // 
            // uceOperation
            // 
            this.uceOperation.AutoSize = false;
            this.uceOperation.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.uceOperation.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.uceOperation.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uceOperation.Location = new System.Drawing.Point(235, 118);
            this.uceOperation.Name = "uceOperation";
            this.uceOperation.Size = new System.Drawing.Size(210, 24);
            this.uceOperation.TabIndex = 34;
            // 
            // uceField
            // 
            this.uceField.AutoSize = false;
            this.uceField.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.uceField.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.uceField.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uceField.Location = new System.Drawing.Point(13, 118);
            this.uceField.Name = "uceField";
            this.uceField.Size = new System.Drawing.Size(216, 24);
            this.uceField.TabIndex = 35;
            // 
            // lvwGrid
            // 
            this.lvwGrid.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwGrid.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwGrid.FullRowSelect = true;
            this.lvwGrid.Location = new System.Drawing.Point(13, 157);
            this.lvwGrid.MultiSelect = false;
            this.lvwGrid.Name = "lvwGrid";
            this.lvwGrid.Size = new System.Drawing.Size(607, 98);
            this.lvwGrid.TabIndex = 36;
            this.lvwGrid.UseCompatibleStateImageBehavior = false;
            this.lvwGrid.View = System.Windows.Forms.View.Details;
            this.lvwGrid.SelectedIndexChanged += new System.EventHandler(this.lvwGrid_SelectedIndexChanged);
            this.lvwGrid.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwGrid_ColumnClick);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(673, 314);
            this.Controls.Add(this.lvwGrid);
            this.Controls.Add(this.uceField);
            this.Controls.Add(this.uceOperation);
            this.Controls.Add(this.ubtAdd);
            this.Controls.Add(this.ubtRemove);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.pcbValue);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.pcbOperation);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.pcbField);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ":: Pesquisar";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uceOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uceField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            lvwColumnSorter = new clsListViewColumnSorter();
            this.lvwGrid.ListViewItemSorter = lvwColumnSorter;
        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlHeader;
        private Infragistics.Win.Misc.UltraLabel lblHeaderSub;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pcbHeader;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.PictureBox pcbField;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.PictureBox pcbOperation;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.PictureBox pcbValue;
        private Infragistics.Win.Misc.UltraButton ubtClose;
        private Infragistics.Win.Misc.UltraButton ubtSearch;
        private Infragistics.Win.Misc.UltraButton ubtRemove;
        private Infragistics.Win.Misc.UltraButton ubtAdd;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor uceOperation;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor uceField;
        private System.Windows.Forms.ListView lvwGrid;
    }
}