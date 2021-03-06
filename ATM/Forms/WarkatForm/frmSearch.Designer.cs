﻿namespace ATM.Forms.WarkatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtDueDateTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDueDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtWarkatNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransactionCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarkatNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(540, 37);
            this.panelControl1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(29, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Search Form";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSearch);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 186);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(540, 53);
            this.panelControl2.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(300, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 43);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(410, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txtDueDateTo);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Controls.Add(this.txtDueDateFrom);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Controls.Add(this.txtAccountNo);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.txtBankCode);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.txtWarkatNo);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.txtTransactionCode);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 37);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(540, 149);
            this.panelControl3.TabIndex = 7;
            // 
            // txtDueDateTo
            // 
            this.txtDueDateTo.EditValue = null;
            this.txtDueDateTo.Location = new System.Drawing.Point(237, 58);
            this.txtDueDateTo.Name = "txtDueDateTo";
            this.txtDueDateTo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDueDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDueDateTo.Properties.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.txtDueDateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDueDateTo.Properties.EditFormat.FormatString = "MM/dd/yyyy";
            this.txtDueDateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDueDateTo.Properties.Mask.EditMask = "MM/dd/yyyy";
            this.txtDueDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDueDateTo.Size = new System.Drawing.Size(100, 20);
            this.txtDueDateTo.TabIndex = 3;
            this.txtDueDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDueDateTo_KeyDown);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(221, 61);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(4, 13);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "-";
            // 
            // txtDueDateFrom
            // 
            this.txtDueDateFrom.EditValue = null;
            this.txtDueDateFrom.Location = new System.Drawing.Point(112, 58);
            this.txtDueDateFrom.Name = "txtDueDateFrom";
            this.txtDueDateFrom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDueDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDueDateFrom.Properties.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.txtDueDateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDueDateFrom.Properties.EditFormat.FormatString = "MM/dd/yyyy";
            this.txtDueDateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDueDateFrom.Properties.Mask.EditMask = "MM/dd/yyyy";
            this.txtDueDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDueDateFrom.Size = new System.Drawing.Size(100, 20);
            this.txtDueDateFrom.TabIndex = 2;
            this.txtDueDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDueDateFrom_KeyDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 113);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Account No";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(112, 110);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(402, 20);
            this.txtAccountNo.TabIndex = 5;
            this.txtAccountNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountNo_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 87);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Bank Code";
            // 
            // txtBankCode
            // 
            this.txtBankCode.Location = new System.Drawing.Point(112, 84);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(402, 20);
            this.txtBankCode.TabIndex = 4;
            this.txtBankCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankCode_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Due Date";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Warkat No";
            // 
            // txtWarkatNo
            // 
            this.txtWarkatNo.Location = new System.Drawing.Point(112, 32);
            this.txtWarkatNo.Name = "txtWarkatNo";
            this.txtWarkatNo.Size = new System.Drawing.Size(402, 20);
            this.txtWarkatNo.TabIndex = 1;
            this.txtWarkatNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWarkatNo_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Transaction Code";
            // 
            // txtTransactionCode
            // 
            this.txtTransactionCode.Location = new System.Drawing.Point(112, 6);
            this.txtTransactionCode.Name = "txtTransactionCode";
            this.txtTransactionCode.Size = new System.Drawing.Size(402, 20);
            this.txtTransactionCode.TabIndex = 0;
            this.txtTransactionCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTransactionCode_KeyDown);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 239);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarkatNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtAccountNo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBankCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtWarkatNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTransactionCode;
        private DevExpress.XtraEditors.DateEdit txtDueDateTo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit txtDueDateFrom;
    }
}