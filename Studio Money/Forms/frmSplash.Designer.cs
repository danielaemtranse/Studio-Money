namespace StudioMoney.Forms
{
    partial class frmSplash
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.grbMaster = new System.Windows.Forms.GroupBox();
            this.lblUser = new Infragistics.Win.Misc.UltraLabel();
            this.lblLicense = new Infragistics.Win.Misc.UltraLabel();
            this.pnlMaster.SuspendLayout();
            this.grbMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMaster
            // 
            this.pnlMaster.BackgroundImage = global::StudioMoney.Properties.Resources.background;
            this.pnlMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMaster.Controls.Add(this.grbMaster);
            this.pnlMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMaster.Location = new System.Drawing.Point(0, 0);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(450, 266);
            this.pnlMaster.TabIndex = 0;
            // 
            // grbMaster
            // 
            this.grbMaster.BackColor = System.Drawing.Color.Transparent;
            this.grbMaster.Controls.Add(this.lblUser);
            this.grbMaster.Controls.Add(this.lblLicense);
            this.grbMaster.Location = new System.Drawing.Point(11, 5);
            this.grbMaster.Name = "grbMaster";
            this.grbMaster.Size = new System.Drawing.Size(426, 249);
            this.grbMaster.TabIndex = 8;
            this.grbMaster.TabStop = false;
            // 
            // lblUser
            // 
            appearance1.ForeColor = System.Drawing.SystemColors.Window;
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.lblUser.Appearance = appearance1;
            this.lblUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(16, 191);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(398, 23);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW";
            // 
            // lblLicense
            // 
            appearance2.ForeColor = System.Drawing.SystemColors.Window;
            appearance2.TextHAlignAsString = "Center";
            appearance2.TextVAlignAsString = "Middle";
            this.lblLicense.Appearance = appearance2;
            this.lblLicense.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(16, 211);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(398, 23);
            this.lblLicense.TabIndex = 15;
            this.lblLicense.Text = "Este programa é um software livre. Para mais informações acesse o menu Ajuda e So" +
    "bre.";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(450, 266);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Splash";
            this.Text = "Studio Money";
            this.TopMost = true;
            this.pnlMaster.ResumeLayout(false);
            this.grbMaster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlMaster;
        public System.Windows.Forms.GroupBox grbMaster;
        public Infragistics.Win.Misc.UltraLabel lblLicense;
        public Infragistics.Win.Misc.UltraLabel lblUser;
    }
}