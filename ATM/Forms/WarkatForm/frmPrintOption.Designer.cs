namespace ATM.Forms.WarkatForm
{
    partial class frmPrintOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintOption));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDueDateTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDueDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chAllAccount = new DevExpress.XtraEditors.CheckEdit();
            this.txtFromAccountID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnFindAccountFromID = new DevExpress.XtraEditors.SimpleButton();
            this.btnFindAccountToID = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtToAccountID = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.chAllAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToAccountID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(421, 37);
            this.panelControl1.TabIndex = 6;
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
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Print Preview";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnClose);
            this.panelControl2.Controls.Add(this.btnPreview);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 195);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(421, 44);
            this.panelControl2.TabIndex = 7;
            // 
            // btnPreview
            // 
            this.btnPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.Image")));
            this.btnPreview.Location = new System.Drawing.Point(193, 6);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(104, 30);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "&Print Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(303, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnFindAccountToID);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.txtToAccountID);
            this.panelControl3.Controls.Add(this.btnFindAccountFromID);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.txtFromAccountID);
            this.panelControl3.Controls.Add(this.chAllAccount);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.txtDueDateTo);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Controls.Add(this.txtDueDateFrom);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 37);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(421, 158);
            this.panelControl3.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Due Date";
            // 
            // txtDueDateTo
            // 
            this.txtDueDateTo.EditValue = null;
            this.txtDueDateTo.Location = new System.Drawing.Point(211, 12);
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
            this.txtDueDateTo.TabIndex = 29;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(195, 15);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(4, 13);
            this.labelControl7.TabIndex = 28;
            this.labelControl7.Text = "-";
            // 
            // txtDueDateFrom
            // 
            this.txtDueDateFrom.EditValue = null;
            this.txtDueDateFrom.Location = new System.Drawing.Point(86, 12);
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
            this.txtDueDateFrom.TabIndex = 27;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Account";
            // 
            // chAllAccount
            // 
            this.chAllAccount.EditValue = true;
            this.chAllAccount.Location = new System.Drawing.Point(84, 48);
            this.chAllAccount.Name = "chAllAccount";
            this.chAllAccount.Properties.Caption = "All Account";
            this.chAllAccount.Size = new System.Drawing.Size(75, 19);
            this.chAllAccount.TabIndex = 31;
            // 
            // txtFromAccountID
            // 
            this.txtFromAccountID.Enabled = false;
            this.txtFromAccountID.Location = new System.Drawing.Point(164, 78);
            this.txtFromAccountID.Name = "txtFromAccountID";
            this.txtFromAccountID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtFromAccountID.Size = new System.Drawing.Size(210, 20);
            this.txtFromAccountID.TabIndex = 32;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(86, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "From Account";
            // 
            // btnFindAccountFromID
            // 
            this.btnFindAccountFromID.Enabled = false;
            this.btnFindAccountFromID.Image = ((System.Drawing.Image)(resources.GetObject("btnFindAccountFromID.Image")));
            this.btnFindAccountFromID.Location = new System.Drawing.Point(378, 77);
            this.btnFindAccountFromID.Name = "btnFindAccountFromID";
            this.btnFindAccountFromID.Size = new System.Drawing.Size(29, 23);
            this.btnFindAccountFromID.TabIndex = 34;
            // 
            // btnFindAccountToID
            // 
            this.btnFindAccountToID.Enabled = false;
            this.btnFindAccountToID.Image = ((System.Drawing.Image)(resources.GetObject("btnFindAccountToID.Image")));
            this.btnFindAccountToID.Location = new System.Drawing.Point(378, 105);
            this.btnFindAccountToID.Name = "btnFindAccountToID";
            this.btnFindAccountToID.Size = new System.Drawing.Size(29, 23);
            this.btnFindAccountToID.TabIndex = 37;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(86, 109);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 13);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "To Account";
            // 
            // txtToAccountID
            // 
            this.txtToAccountID.Enabled = false;
            this.txtToAccountID.Location = new System.Drawing.Point(164, 106);
            this.txtToAccountID.Name = "txtToAccountID";
            this.txtToAccountID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtToAccountID.Size = new System.Drawing.Size(210, 20);
            this.txtToAccountID.TabIndex = 35;
            // 
            // frmPrintOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 239);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrintOption";
            this.Text = "Print Option";
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
            ((System.ComponentModel.ISupportInitialize)(this.chAllAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToAccountID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit txtDueDateTo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit txtDueDateFrom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chAllAccount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFromAccountID;
        private DevExpress.XtraEditors.SimpleButton btnFindAccountToID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtToAccountID;
        private DevExpress.XtraEditors.SimpleButton btnFindAccountFromID;
    }
}