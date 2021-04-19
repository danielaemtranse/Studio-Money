namespace Studio_Money.Forms
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.spcVertical = new System.Windows.Forms.SplitContainer();
            this.pnlGridAccount = new System.Windows.Forms.Panel();
            this.lvwAccountsValue = new System.Windows.Forms.ListView();
            this.pnlAccountsValueBottom = new System.Windows.Forms.Panel();
            this.lblAccountsValueDebt = new System.Windows.Forms.Label();
            this.lblAccountsValueValue = new System.Windows.Forms.Label();
            this.pnlAccountsValueHeader = new System.Windows.Forms.Panel();
            this.lblAccountsValueSubHeader = new System.Windows.Forms.Label();
            this.lblAccountsValueHeader = new System.Windows.Forms.Label();
            this.pcbAccountsValue = new System.Windows.Forms.PictureBox();
            this.spcHorizontal = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvwBill = new System.Windows.Forms.ListView();
            this.pnlBillHeader = new System.Windows.Forms.Panel();
            this.lblBillSubHeader = new System.Windows.Forms.Label();
            this.lblBillHeader = new System.Windows.Forms.Label();
            this.pcbBill = new System.Windows.Forms.PictureBox();
            this.pnlBillBottom = new System.Windows.Forms.Panel();
            this.lblBillValue = new System.Windows.Forms.Label();
            this.pnlGraphicHeader = new System.Windows.Forms.Panel();
            this.lblGraphicSubHeader = new System.Windows.Forms.Label();
            this.lblGraphicHeader = new System.Windows.Forms.Label();
            this.pcbGraphic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spcVertical.Panel1.SuspendLayout();
            this.spcVertical.Panel2.SuspendLayout();
            this.spcVertical.SuspendLayout();
            this.pnlGridAccount.SuspendLayout();
            this.pnlAccountsValueBottom.SuspendLayout();
            this.pnlAccountsValueHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAccountsValue)).BeginInit();
            this.spcHorizontal.Panel1.SuspendLayout();
            this.spcHorizontal.Panel2.SuspendLayout();
            this.spcHorizontal.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlBillHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBill)).BeginInit();
            this.pnlBillBottom.SuspendLayout();
            this.pnlGraphicHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // spcVertical
            // 
            this.spcVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcVertical.Location = new System.Drawing.Point(0, 0);
            this.spcVertical.Name = "spcVertical";
            // 
            // spcVertical.Panel1
            // 
            this.spcVertical.Panel1.Controls.Add(this.pnlGridAccount);
            this.spcVertical.Panel1.Controls.Add(this.pnlAccountsValueBottom);
            this.spcVertical.Panel1.Controls.Add(this.pnlAccountsValueHeader);
            this.spcVertical.Panel1.Padding = new System.Windows.Forms.Padding(4, 5, 0, 5);
            // 
            // spcVertical.Panel2
            // 
            this.spcVertical.Panel2.Controls.Add(this.spcHorizontal);
            this.spcVertical.Panel2.Controls.Add(this.pnlBillBottom);
            this.spcVertical.Panel2.Controls.Add(this.pnlGraphicHeader);
            this.spcVertical.Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.spcVertical.Size = new System.Drawing.Size(742, 633);
            this.spcVertical.SplitterDistance = 251;
            this.spcVertical.TabIndex = 0;
            // 
            // pnlGridAccount
            // 
            this.pnlGridAccount.Controls.Add(this.lvwAccountsValue);
            this.pnlGridAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridAccount.Location = new System.Drawing.Point(4, 59);
            this.pnlGridAccount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pnlGridAccount.Name = "pnlGridAccount";
            this.pnlGridAccount.Size = new System.Drawing.Size(247, 539);
            this.pnlGridAccount.TabIndex = 62;
            // 
            // lvwAccountsValue
            // 
            this.lvwAccountsValue.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwAccountsValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwAccountsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAccountsValue.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAccountsValue.FullRowSelect = true;
            this.lvwAccountsValue.Location = new System.Drawing.Point(0, 0);
            this.lvwAccountsValue.MultiSelect = false;
            this.lvwAccountsValue.Name = "lvwAccountsValue";
            this.lvwAccountsValue.Scrollable = false;
            this.lvwAccountsValue.Size = new System.Drawing.Size(247, 539);
            this.lvwAccountsValue.TabIndex = 59;
            this.lvwAccountsValue.UseCompatibleStateImageBehavior = false;
            this.lvwAccountsValue.View = System.Windows.Forms.View.Details;
            // 
            // pnlAccountsValueBottom
            // 
            this.pnlAccountsValueBottom.BackgroundImage = global::Studio_Money.Properties.Resources.degrade_fd;
            this.pnlAccountsValueBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccountsValueBottom.Controls.Add(this.lblAccountsValueDebt);
            this.pnlAccountsValueBottom.Controls.Add(this.lblAccountsValueValue);
            this.pnlAccountsValueBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAccountsValueBottom.Location = new System.Drawing.Point(4, 598);
            this.pnlAccountsValueBottom.Name = "pnlAccountsValueBottom";
            this.pnlAccountsValueBottom.Size = new System.Drawing.Size(247, 30);
            this.pnlAccountsValueBottom.TabIndex = 61;
            // 
            // lblAccountsValueDebt
            // 
            this.lblAccountsValueDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAccountsValueDebt.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountsValueDebt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.lblAccountsValueDebt.ForeColor = System.Drawing.Color.Red;
            this.lblAccountsValueDebt.Location = new System.Drawing.Point(6, 5);
            this.lblAccountsValueDebt.Name = "lblAccountsValueDebt";
            this.lblAccountsValueDebt.Size = new System.Drawing.Size(104, 18);
            this.lblAccountsValueDebt.TabIndex = 7;
            this.lblAccountsValueDebt.Text = "Devedor";
            this.lblAccountsValueDebt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountsValueValue
            // 
            this.lblAccountsValueValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountsValueValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountsValueValue.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.lblAccountsValueValue.Location = new System.Drawing.Point(86, 5);
            this.lblAccountsValueValue.Name = "lblAccountsValueValue";
            this.lblAccountsValueValue.Size = new System.Drawing.Size(151, 18);
            this.lblAccountsValueValue.TabIndex = 6;
            this.lblAccountsValueValue.Text = "999.999.999.999,99";
            this.lblAccountsValueValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlAccountsValueHeader
            // 
            this.pnlAccountsValueHeader.BackgroundImage = global::Studio_Money.Properties.Resources.backBlue;
            this.pnlAccountsValueHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccountsValueHeader.Controls.Add(this.lblAccountsValueSubHeader);
            this.pnlAccountsValueHeader.Controls.Add(this.lblAccountsValueHeader);
            this.pnlAccountsValueHeader.Controls.Add(this.pcbAccountsValue);
            this.pnlAccountsValueHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccountsValueHeader.Location = new System.Drawing.Point(4, 5);
            this.pnlAccountsValueHeader.Name = "pnlAccountsValueHeader";
            this.pnlAccountsValueHeader.Size = new System.Drawing.Size(247, 54);
            this.pnlAccountsValueHeader.TabIndex = 59;
            // 
            // lblAccountsValueSubHeader
            // 
            this.lblAccountsValueSubHeader.AutoSize = true;
            this.lblAccountsValueSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountsValueSubHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.lblAccountsValueSubHeader.Location = new System.Drawing.Point(59, 26);
            this.lblAccountsValueSubHeader.Name = "lblAccountsValueSubHeader";
            this.lblAccountsValueSubHeader.Size = new System.Drawing.Size(177, 18);
            this.lblAccountsValueSubHeader.TabIndex = 7;
            this.lblAccountsValueSubHeader.Text = "Saldo atual de todas as contas";
            // 
            // lblAccountsValueHeader
            // 
            this.lblAccountsValueHeader.AutoSize = true;
            this.lblAccountsValueHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountsValueHeader.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountsValueHeader.Location = new System.Drawing.Point(57, 3);
            this.lblAccountsValueHeader.Name = "lblAccountsValueHeader";
            this.lblAccountsValueHeader.Size = new System.Drawing.Size(129, 22);
            this.lblAccountsValueHeader.TabIndex = 6;
            this.lblAccountsValueHeader.Text = "Saldo de Contas";
            // 
            // pcbAccountsValue
            // 
            this.pcbAccountsValue.BackColor = System.Drawing.Color.Transparent;
            this.pcbAccountsValue.Image = ((System.Drawing.Image)(resources.GetObject("pcbAccountsValue.Image")));
            this.pcbAccountsValue.Location = new System.Drawing.Point(15, 9);
            this.pcbAccountsValue.Name = "pcbAccountsValue";
            this.pcbAccountsValue.Size = new System.Drawing.Size(36, 34);
            this.pcbAccountsValue.TabIndex = 5;
            this.pcbAccountsValue.TabStop = false;
            // 
            // spcHorizontal
            // 
            this.spcHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcHorizontal.Location = new System.Drawing.Point(0, 59);
            this.spcHorizontal.Name = "spcHorizontal";
            this.spcHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcHorizontal.Panel1
            // 
            this.spcHorizontal.Panel1.Controls.Add(this.panel1);
            // 
            // spcHorizontal.Panel2
            // 
            this.spcHorizontal.Panel2.Controls.Add(this.panel4);
            this.spcHorizontal.Panel2.Controls.Add(this.pnlBillHeader);
            this.spcHorizontal.Size = new System.Drawing.Size(482, 539);
            this.spcHorizontal.SplitterDistance = 141;
            this.spcHorizontal.TabIndex = 63;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvwBill);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 340);
            this.panel4.TabIndex = 62;
            // 
            // lvwBill
            // 
            this.lvwBill.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBill.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBill.FullRowSelect = true;
            this.lvwBill.Location = new System.Drawing.Point(0, 0);
            this.lvwBill.MultiSelect = false;
            this.lvwBill.Name = "lvwBill";
            this.lvwBill.Scrollable = false;
            this.lvwBill.Size = new System.Drawing.Size(482, 340);
            this.lvwBill.TabIndex = 61;
            this.lvwBill.UseCompatibleStateImageBehavior = false;
            this.lvwBill.View = System.Windows.Forms.View.Details;
            // 
            // pnlBillHeader
            // 
            this.pnlBillHeader.BackgroundImage = global::Studio_Money.Properties.Resources.backBlue;
            this.pnlBillHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBillHeader.Controls.Add(this.lblBillSubHeader);
            this.pnlBillHeader.Controls.Add(this.lblBillHeader);
            this.pnlBillHeader.Controls.Add(this.pcbBill);
            this.pnlBillHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBillHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlBillHeader.Name = "pnlBillHeader";
            this.pnlBillHeader.Size = new System.Drawing.Size(482, 54);
            this.pnlBillHeader.TabIndex = 61;
            // 
            // lblBillSubHeader
            // 
            this.lblBillSubHeader.AutoSize = true;
            this.lblBillSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblBillSubHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.lblBillSubHeader.Location = new System.Drawing.Point(59, 26);
            this.lblBillSubHeader.Name = "lblBillSubHeader";
            this.lblBillSubHeader.Size = new System.Drawing.Size(212, 18);
            this.lblBillSubHeader.TabIndex = 6;
            this.lblBillSubHeader.Text = "Contas a pagar nos próximos 30 dias";
            // 
            // lblBillHeader
            // 
            this.lblBillHeader.AutoSize = true;
            this.lblBillHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblBillHeader.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillHeader.Location = new System.Drawing.Point(57, 3);
            this.lblBillHeader.Name = "lblBillHeader";
            this.lblBillHeader.Size = new System.Drawing.Size(123, 22);
            this.lblBillHeader.TabIndex = 4;
            this.lblBillHeader.Text = "Contas a Pagar";
            // 
            // pcbBill
            // 
            this.pcbBill.BackColor = System.Drawing.Color.Transparent;
            this.pcbBill.Image = ((System.Drawing.Image)(resources.GetObject("pcbBill.Image")));
            this.pcbBill.Location = new System.Drawing.Point(15, 9);
            this.pcbBill.Name = "pcbBill";
            this.pcbBill.Size = new System.Drawing.Size(36, 34);
            this.pcbBill.TabIndex = 1;
            this.pcbBill.TabStop = false;
            // 
            // pnlBillBottom
            // 
            this.pnlBillBottom.BackgroundImage = global::Studio_Money.Properties.Resources.degrade_fd;
            this.pnlBillBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBillBottom.Controls.Add(this.lblBillValue);
            this.pnlBillBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBillBottom.Location = new System.Drawing.Point(0, 598);
            this.pnlBillBottom.Name = "pnlBillBottom";
            this.pnlBillBottom.Size = new System.Drawing.Size(482, 30);
            this.pnlBillBottom.TabIndex = 62;
            // 
            // lblBillValue
            // 
            this.lblBillValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBillValue.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.lblBillValue.Location = new System.Drawing.Point(342, 5);
            this.lblBillValue.Name = "lblBillValue";
            this.lblBillValue.Size = new System.Drawing.Size(132, 18);
            this.lblBillValue.TabIndex = 7;
            this.lblBillValue.Text = "999.999.999.999,99";
            this.lblBillValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlGraphicHeader
            // 
            this.pnlGraphicHeader.BackgroundImage = global::Studio_Money.Properties.Resources.backBlue;
            this.pnlGraphicHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraphicHeader.Controls.Add(this.lblGraphicSubHeader);
            this.pnlGraphicHeader.Controls.Add(this.lblGraphicHeader);
            this.pnlGraphicHeader.Controls.Add(this.pcbGraphic);
            this.pnlGraphicHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGraphicHeader.Location = new System.Drawing.Point(0, 5);
            this.pnlGraphicHeader.Name = "pnlGraphicHeader";
            this.pnlGraphicHeader.Size = new System.Drawing.Size(482, 54);
            this.pnlGraphicHeader.TabIndex = 60;
            // 
            // lblGraphicSubHeader
            // 
            this.lblGraphicSubHeader.AutoSize = true;
            this.lblGraphicSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblGraphicSubHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.lblGraphicSubHeader.Location = new System.Drawing.Point(59, 26);
            this.lblGraphicSubHeader.Name = "lblGraphicSubHeader";
            this.lblGraphicSubHeader.Size = new System.Drawing.Size(217, 18);
            this.lblGraphicSubHeader.TabIndex = 5;
            this.lblGraphicSubHeader.Text = "Gráfico de gastos nos últimos 30 dias";
            // 
            // lblGraphicHeader
            // 
            this.lblGraphicHeader.AutoSize = true;
            this.lblGraphicHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblGraphicHeader.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphicHeader.Location = new System.Drawing.Point(57, 3);
            this.lblGraphicHeader.Name = "lblGraphicHeader";
            this.lblGraphicHeader.Size = new System.Drawing.Size(145, 22);
            this.lblGraphicHeader.TabIndex = 4;
            this.lblGraphicHeader.Text = "Gráfico de Gastos";
            // 
            // pcbGraphic
            // 
            this.pcbGraphic.BackColor = System.Drawing.Color.Transparent;
            this.pcbGraphic.Image = ((System.Drawing.Image)(resources.GetObject("pcbGraphic.Image")));
            this.pcbGraphic.Location = new System.Drawing.Point(15, 9);
            this.pcbGraphic.Name = "pcbGraphic";
            this.pcbGraphic.Size = new System.Drawing.Size(36, 34);
            this.pcbGraphic.TabIndex = 1;
            this.pcbGraphic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 141);
            this.panel1.TabIndex = 0;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(742, 633);
            this.Controls.Add(this.spcVertical);
            this.Name = "frmHome";
            this.ShowIcon = false;
            this.Text = "Home";
            this.spcVertical.Panel1.ResumeLayout(false);
            this.spcVertical.Panel2.ResumeLayout(false);
            this.spcVertical.ResumeLayout(false);
            this.pnlGridAccount.ResumeLayout(false);
            this.pnlAccountsValueBottom.ResumeLayout(false);
            this.pnlAccountsValueHeader.ResumeLayout(false);
            this.pnlAccountsValueHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAccountsValue)).EndInit();
            this.spcHorizontal.Panel1.ResumeLayout(false);
            this.spcHorizontal.Panel2.ResumeLayout(false);
            this.spcHorizontal.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlBillHeader.ResumeLayout(false);
            this.pnlBillHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBill)).EndInit();
            this.pnlBillBottom.ResumeLayout(false);
            this.pnlGraphicHeader.ResumeLayout(false);
            this.pnlGraphicHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGraphic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcVertical;
        private System.Windows.Forms.Panel pnlAccountsValueHeader;
        private System.Windows.Forms.Panel pnlGraphicHeader;
        private System.Windows.Forms.Panel pnlAccountsValueBottom;
        private System.Windows.Forms.Panel pnlGridAccount;
        private System.Windows.Forms.ListView lvwAccountsValue;
        private System.Windows.Forms.SplitContainer spcHorizontal;
        private System.Windows.Forms.Panel pnlBillBottom;
        private System.Windows.Forms.PictureBox pcbGraphic;
        private System.Windows.Forms.Label lblAccountsValueHeader;
        private System.Windows.Forms.PictureBox pcbAccountsValue;
        private System.Windows.Forms.Label lblGraphicHeader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvwBill;
        private System.Windows.Forms.Panel pnlBillHeader;
        private System.Windows.Forms.Label lblBillHeader;
        private System.Windows.Forms.PictureBox pcbBill;
        private System.Windows.Forms.Label lblGraphicSubHeader;
        private System.Windows.Forms.Label lblAccountsValueSubHeader;
        private System.Windows.Forms.Label lblBillSubHeader;
        private System.Windows.Forms.Label lblAccountsValueValue;
        private System.Windows.Forms.Label lblAccountsValueDebt;
        private System.Windows.Forms.Label lblBillValue;
        private System.Windows.Forms.Panel panel1;
    }
}