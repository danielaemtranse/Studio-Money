namespace Studio_Money.Forms
{
    partial class frmBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBank));
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab3 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            this.utsMainBank = new Infragistics.Win.UltraWinTabControl.UltraTabStripControl();
            this.utsBank = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.pnlBank = new System.Windows.Forms.Panel();
            this.txtDescription = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblCode = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.utsMainBank, "utsMainBank");
            this.utsMainBank.Controls.Add(this.utsBank);
            this.utsMainBank.Name = "utsMainBank";
            this.utsMainBank.SharedControls.AddRange(new System.Windows.Forms.Control[] {
            this.pnlBank});
            this.utsMainBank.SharedControlsPage = this.utsBank;
            resources.ApplyResources(appearance31.FontData, "appearance31.FontData");
            ultraTab3.Appearance = appearance31;
            resources.ApplyResources(ultraTab3, "ultraTab3");
            this.utsMainBank.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab3});
            // 
            // utsBank
            // 
            this.utsBank.Controls.Add(this.pnlBank);
            resources.ApplyResources(this.utsBank, "utsBank");
            this.utsBank.Name = "utsBank";
            // 
            // pnlBank
            // 
            this.pnlBank.Controls.Add(this.txtDescription);
            this.pnlBank.Controls.Add(this.lblDescription);
            this.pnlBank.Controls.Add(this.txtCode);
            this.pnlBank.Controls.Add(this.lblCode);
            resources.ApplyResources(this.pnlBank, "pnlBank");
            this.pnlBank.Name = "pnlBank";
            // 
            // txtDescription
            // 
            this.txtDescription.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.MaxLength = 33;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ShowOverflowIndicator = true;
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.Name = "lblDescription";
            // 
            // txtCode
            // 
            this.txtCode.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            resources.ApplyResources(this.txtCode, "txtCode");
            this.txtCode.MaxLength = 33;
            this.txtCode.Name = "txtCode";
            this.txtCode.ShowOverflowIndicator = true;
            this.txtCode.Tag = "First Control";
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            // 
            // lblCode
            // 
            resources.ApplyResources(this.lblCode, "lblCode");
            this.lblCode.Name = "lblCode";
            // 
            // frmBank
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.utsMainBank);
            this.Name = "frmBank";
            this.ShowIcon = false;
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
    }
}