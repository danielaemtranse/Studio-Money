namespace Studio_Money.Forms
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.txtEMail = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtUser = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.pcbMail = new System.Windows.Forms.PictureBox();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtWelcomeSub = new Infragistics.Win.Misc.UltraLabel();
            this.pcbHeader = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMail)).BeginInit();
            this.pnlSub.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.lblUser.Location = new System.Drawing.Point(40, 90);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 18);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "&Usuário";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.lblEMail.Location = new System.Drawing.Point(40, 146);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(44, 18);
            this.lblEMail.TabIndex = 17;
            this.lblEMail.Text = "&E-Mail";
            // 
            // txtEMail
            // 
            this.txtEMail.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.txtEMail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.txtEMail.Location = new System.Drawing.Point(12, 170);
            this.txtEMail.MaxLength = 30;
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(293, 24);
            this.txtEMail.TabIndex = 1;
            this.txtEMail.Tag = "lblEMail";
            this.txtEMail.Enter += new System.EventHandler(this.txtEMail_Enter);
            // 
            // txtUser
            // 
            this.txtUser.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.txtUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.txtUser.Location = new System.Drawing.Point(12, 111);
            this.txtUser.MaxLength = 30;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(428, 24);
            this.txtUser.TabIndex = 0;
            this.txtUser.Tag = "lblUser";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            // 
            // pcbMail
            // 
            this.pcbMail.Image = global::Studio_Money.Properties.Resources.mail22;
            this.pcbMail.Location = new System.Drawing.Point(12, 142);
            this.pcbMail.Name = "pcbMail";
            this.pcbMail.Size = new System.Drawing.Size(22, 22);
            this.pcbMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMail.TabIndex = 19;
            this.pcbMail.TabStop = false;
            // 
            // pnlSub
            // 
            this.pnlSub.BackColor = System.Drawing.Color.Transparent;
            this.pnlSub.BackgroundImage = global::Studio_Money.Properties.Resources.degrade_fd;
            this.pnlSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSub.Controls.Add(this.btnCancel);
            this.pnlSub.Controls.Add(this.btnNext);
            this.pnlSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSub.Location = new System.Drawing.Point(0, 204);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(452, 43);
            this.pnlSub.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::Studio_Money.Properties.Resources.close221;
            this.btnCancel.Location = new System.Drawing.Point(228, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "  &Cancelar";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::Studio_Money.Properties.Resources.next221;
            this.btnNext.Location = new System.Drawing.Point(337, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 30);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "  &Próximo";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BackgroundImage = global::Studio_Money.Properties.Resources.backBlue;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.txtWelcomeSub);
            this.pnlHeader.Controls.Add(this.pcbHeader);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(452, 77);
            this.pnlHeader.TabIndex = 15;
            // 
            // txtWelcomeSub
            // 
            this.txtWelcomeSub.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcomeSub.Location = new System.Drawing.Point(82, 33);
            this.txtWelcomeSub.Name = "txtWelcomeSub";
            this.txtWelcomeSub.Size = new System.Drawing.Size(341, 40);
            this.txtWelcomeSub.TabIndex = 20;
            this.txtWelcomeSub.Text = "Informe os dados abaixo para registro de sua cópia do Studio Money";
            // 
            // pcbHeader
            // 
            this.pcbHeader.Image = global::Studio_Money.Properties.Resources.register;
            this.pcbHeader.Location = new System.Drawing.Point(12, 9);
            this.pcbHeader.Name = "pcbHeader";
            this.pcbHeader.Size = new System.Drawing.Size(49, 56);
            this.pcbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHeader.TabIndex = 13;
            this.pcbHeader.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(79, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(221, 22);
            this.lblWelcome.TabIndex = 12;
            this.lblWelcome.Text = "Bem-Vindo ao Studio Money";
            // 
            // pcbUser
            // 
            this.pcbUser.Image = global::Studio_Money.Properties.Resources.user22;
            this.pcbUser.Location = new System.Drawing.Point(12, 86);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(22, 22);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbUser.TabIndex = 11;
            this.pcbUser.TabStop = false;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(452, 247);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.pcbMail);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.pnlSub);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pcbUser);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Register";
            this.Text = ":: Registro ";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMail)).EndInit();
            this.pnlSub.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pcbHeader;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.PictureBox pcbMail;
        private System.Windows.Forms.Label lblEMail;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtEMail;
        private Infragistics.Win.Misc.UltraLabel txtWelcomeSub;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtUser;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
    }
}