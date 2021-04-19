namespace Studio_Money.Forms
{
    partial class frmLanguage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLanguage));
            this.lvwLanguages = new System.Windows.Forms.ListView();
            this.imlImagens = new System.Windows.Forms.ImageList(this.components);
            this.pnlLogon = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlLogon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwLanguages
            // 
            this.lvwLanguages.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLanguages.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvwLanguages.Location = new System.Drawing.Point(12, 93);
            this.lvwLanguages.Name = "lvwLanguages";
            this.lvwLanguages.Size = new System.Drawing.Size(195, 253);
            this.lvwLanguages.TabIndex = 0;
            this.lvwLanguages.UseCompatibleStateImageBehavior = false;
            this.lvwLanguages.View = System.Windows.Forms.View.Details;
            // 
            // imlImagens
            // 
            this.imlImagens.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlImagens.ImageSize = new System.Drawing.Size(16, 16);
            this.imlImagens.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlLogon
            // 
            this.pnlLogon.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogon.BackgroundImage = global::Studio_Money.Properties.Resources.backBlue;
            this.pnlLogon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogon.Controls.Add(this.label1);
            this.pnlLogon.Controls.Add(this.lblHeaderSub);
            this.pnlLogon.Controls.Add(this.pictureBox4);
            this.pnlLogon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogon.Location = new System.Drawing.Point(0, 0);
            this.pnlLogon.Name = "pnlLogon";
            this.pnlLogon.Size = new System.Drawing.Size(219, 77);
            this.pnlLogon.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Regional";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.lblHeaderSub.Location = new System.Drawing.Point(79, 44);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(131, 18);
            this.lblHeaderSub.TabIndex = 2;
            this.lblHeaderSub.Text = "Choose your language";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Studio_Money.Properties.Resources.web;
            this.pictureBox4.Location = new System.Drawing.Point(12, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pnlSub
            // 
            this.pnlSub.BackColor = System.Drawing.Color.Transparent;
            this.pnlSub.BackgroundImage = global::Studio_Money.Properties.Resources.degrade_fd;
            this.pnlSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSub.Controls.Add(this.btnOK);
            this.pnlSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSub.Location = new System.Drawing.Point(0, 364);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(219, 43);
            this.pnlSub.TabIndex = 17;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Image = global::Studio_Money.Properties.Resources.accept22;
            this.btnOK.Location = new System.Drawing.Point(104, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "  &OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(219, 407);
            this.Controls.Add(this.pnlLogon);
            this.Controls.Add(this.lvwLanguages);
            this.Controls.Add(this.pnlSub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLanguage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Language";
            this.Load += new System.EventHandler(this.frmLanguage_Load);
            this.pnlLogon.ResumeLayout(false);
            this.pnlLogon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlSub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.ListView lvwLanguages;
        private System.Windows.Forms.ImageList imlImagens;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlLogon;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
    }
}