namespace Studio_Money.Forms
{
    partial class frmCard
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCard));
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.utsMainBank = new Infragistics.Win.UltraWinTabControl.UltraTabStripControl();
            this.utsBank = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.pnlBank = new System.Windows.Forms.Panel();
            this.txtDescription = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ubtPrevious = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton2 = new Infragistics.Win.Misc.UltraButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.utsMainBank)).BeginInit();
            this.utsMainBank.SuspendLayout();
            this.utsBank.SuspendLayout();
            this.pnlBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            ultraTab3.Text = "Card";
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
            this.pnlBank.Controls.Add(this.groupBox3);
            this.pnlBank.Controls.Add(this.ultraButton1);
            this.pnlBank.Controls.Add(this.ubtPrevious);
            this.pnlBank.Controls.Add(this.groupBox2);
            this.pnlBank.Controls.Add(this.groupBox1);
            this.pnlBank.Controls.Add(this.comboBox2);
            this.pnlBank.Controls.Add(this.label2);
            this.pnlBank.Controls.Add(this.comboBox1);
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
            this.txtDescription.Location = new System.Drawing.Point(128, 33);
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
            this.lblDescription.Location = new System.Drawing.Point(125, 12);
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
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bank";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 26);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(298, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 26);
            this.comboBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(295, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Card Enterprise";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ultraButton2);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 99);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "If is an additional card";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(19, 49);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(231, 26);
            this.comboBox3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Card Master";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(263, 49);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(231, 26);
            this.comboBox4.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(260, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Additional User";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(187, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 126);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Limits";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(22, 41);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(138, 23);
            this.maskedTextBox2.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(19, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Payment Limit";
            // 
            // ubtPrevious
            // 
            appearance2.Image = ((object)(resources.GetObject("appearance2.Image")));
            appearance2.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle;
            this.ubtPrevious.Appearance = appearance2;
            this.ubtPrevious.Enabled = false;
            this.ubtPrevious.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubtPrevious.ImageSize = new System.Drawing.Size(10, 12);
            this.ubtPrevious.Location = new System.Drawing.Point(253, 81);
            this.ubtPrevious.Name = "ubtPrevious";
            this.ubtPrevious.Size = new System.Drawing.Size(32, 24);
            this.ubtPrevious.TabIndex = 30;
            // 
            // ultraButton1
            // 
            appearance1.Image = ((object)(resources.GetObject("appearance1.Image")));
            appearance1.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance1.ImageVAlign = Infragistics.Win.VAlign.Middle;
            this.ultraButton1.Appearance = appearance1;
            this.ultraButton1.Enabled = false;
            this.ultraButton1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraButton1.ImageSize = new System.Drawing.Size(10, 12);
            this.ultraButton1.Location = new System.Drawing.Point(535, 81);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(32, 24);
            this.ultraButton1.TabIndex = 31;
            // 
            // ultraButton2
            // 
            appearance3.Image = ((object)(resources.GetObject("appearance3.Image")));
            appearance3.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance3.ImageVAlign = Infragistics.Win.VAlign.Middle;
            this.ultraButton2.Appearance = appearance3;
            this.ultraButton2.Enabled = false;
            this.ultraButton2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraButton2.ImageSize = new System.Drawing.Size(10, 12);
            this.ultraButton2.Location = new System.Drawing.Point(500, 49);
            this.ultraButton2.Name = "ultraButton2";
            this.ultraButton2.Size = new System.Drawing.Size(32, 24);
            this.ultraButton2.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(16, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 126);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dates";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 23);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(17, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Expiry Date";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(19, 41);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(41, 23);
            this.maskedTextBox1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(16, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pay Day";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(22, 90);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(138, 23);
            this.maskedTextBox3.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(19, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Cash Limit";
            // 
            // frmCadastreCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.utsMainBank);
            this.Name = "frmCadastreCard";
            this.ShowIcon = false;
            this.Text = "Card";
            ((System.ComponentModel.ISupportInitialize)(this.utsMainBank)).EndInit();
            this.utsMainBank.ResumeLayout(false);
            this.utsBank.ResumeLayout(false);
            this.pnlBank.ResumeLayout(false);
            this.pnlBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox4;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.Label label5;
        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private Infragistics.Win.Misc.UltraButton ubtPrevious;
        private Infragistics.Win.Misc.UltraButton ultraButton2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        public System.Windows.Forms.Label label8;
    }
}