namespace StudioMoney.Forms
{
    partial class frmCategory
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
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab3 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            this.utsMainBank = new Infragistics.Win.UltraWinTabControl.UltraTabStripControl();
            this.utsBank = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.pnlBank = new System.Windows.Forms.Panel();
            this.txtDescription = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMasterCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.utsMainBank)).BeginInit();
            this.utsMainBank.SuspendLayout();
            this.utsBank.SuspendLayout();
            this.pnlBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            this.SuspendLayout();
            // 
            // utsMainBank
            // 
            this.utsMainBank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.utsMainBank.Controls.Add(this.utsBank);
            this.utsMainBank.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.utsMainBank.Location = new System.Drawing.Point(8, 8);
            this.utsMainBank.Name = "utsMainBank";
            this.utsMainBank.SharedControls.AddRange(new System.Windows.Forms.Control[] {
            this.pnlBank});
            this.utsMainBank.SharedControlsPage = this.utsBank;
            this.utsMainBank.Size = new System.Drawing.Size(797, 434);
            this.utsMainBank.TabIndex = 27;
            appearance31.FontData.Name = "Trebuchet MS";
            ultraTab3.Appearance = appearance31;
            ultraTab3.Text = "Category";
            this.utsMainBank.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab3});
            // 
            // utsBank
            // 
            this.utsBank.Controls.Add(this.pnlBank);
            this.utsBank.Location = new System.Drawing.Point(1, 24);
            this.utsBank.Name = "utsBank";
            this.utsBank.Size = new System.Drawing.Size(793, 407);
            // 
            // pnlBank
            // 
            this.pnlBank.Controls.Add(this.cmbMasterCategory);
            this.pnlBank.Controls.Add(this.label1);
            this.pnlBank.Controls.Add(this.txtDescription);
            this.pnlBank.Controls.Add(this.lblDescription);
            this.pnlBank.Controls.Add(this.txtCode);
            this.pnlBank.Controls.Add(this.lblCode);
            this.pnlBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBank.Location = new System.Drawing.Point(0, 0);
            this.pnlBank.Name = "pnlBank";
            this.pnlBank.Size = new System.Drawing.Size(793, 407);
            this.pnlBank.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.txtDescription.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.txtDescription.Location = new System.Drawing.Point(16, 82);
            this.txtDescription.MaxLength = 33;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ShowOverflowIndicator = true;
            this.txtDescription.Size = new System.Drawing.Size(626, 24);
            this.txtDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.lblDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescription.Location = new System.Drawing.Point(13, 61);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(74, 18);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // txtCode
            // 
            this.txtCode.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.txtCode.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.txtCode.Location = new System.Drawing.Point(16, 33);
            this.txtCode.MaxLength = 33;
            this.txtCode.Name = "txtCode";
            this.txtCode.ShowOverflowIndicator = true;
            this.txtCode.Size = new System.Drawing.Size(92, 24);
            this.txtCode.TabIndex = 0;
            this.txtCode.Tag = "First Control";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.lblCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCode.Location = new System.Drawing.Point(13, 12);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(37, 18);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Master Category";
            // 
            // cmbMasterCategory
            // 
            this.cmbMasterCategory.FormattingEnabled = true;
            this.cmbMasterCategory.Location = new System.Drawing.Point(16, 132);
            this.cmbMasterCategory.Name = "cmbMasterCategory";
            this.cmbMasterCategory.Size = new System.Drawing.Size(626, 26);
            this.cmbMasterCategory.TabIndex = 14;
            // 
            // frmCadastreCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.utsMainBank);
            this.Name = "frmCadastreCategory";
            this.ShowIcon = false;
            this.Text = "Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.utsMainBank)).EndInit();
            this.utsMainBank.ResumeLayout(false);
            this.utsBank.ResumeLayout(false);
            this.pnlBank.ResumeLayout(false);
            this.pnlBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Infragistics.Win.UltraWinTabControl.UltraTabStripControl utsMainBank;
        public Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage utsBank;
        public System.Windows.Forms.Panel pnlBank;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtDescription;
        public System.Windows.Forms.Label lblDescription;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtCode;
        public System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cmbMasterCategory;
        public System.Windows.Forms.Label label1;


    }
}