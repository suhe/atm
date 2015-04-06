namespace ATM
{
    partial class frmMainMenu
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.tiControl = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tiSetting = new DevExpress.XtraEditors.TileItem();
            this.tiUser = new DevExpress.XtraEditors.TileItem();
            this.tiClose = new DevExpress.XtraEditors.TileItem();
            this.tiRekapWarkat = new DevExpress.XtraEditors.TileItem();
            this.tiBank = new DevExpress.XtraEditors.TileItem();
            this.tiOffice = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tiControl
            // 
            this.tiControl.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiControl.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tiControl.AppearanceItem.Normal.Options.UseFont = true;
            this.tiControl.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tiControl.BackColor = System.Drawing.Color.Indigo;
            this.tiControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tiControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tiControl.Groups.Add(this.tileGroup2);
            this.tiControl.Groups.Add(this.tileGroup3);
            this.tiControl.Location = new System.Drawing.Point(0, 0);
            this.tiControl.MaxId = 8;
            this.tiControl.Name = "tiControl";
            this.tiControl.Size = new System.Drawing.Size(1370, 575);
            this.tiControl.TabIndex = 0;
            this.tiControl.Text = "SETTING";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tiSetting);
            this.tileGroup2.Items.Add(this.tiUser);
            this.tileGroup2.Items.Add(this.tiClose);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = null;
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tiRekapWarkat);
            this.tileGroup3.Items.Add(this.tiBank);
            this.tileGroup3.Items.Add(this.tiOffice);
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = null;
            // 
            // tiSetting
            // 
            this.tiSetting.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkMagenta;
            this.tiSetting.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiSetting.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tiSetting.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tiSetting.AppearanceItem.Normal.Options.UseFont = true;
            this.tiSetting.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tiSetting.AppearanceItem.Selected.BackColor = System.Drawing.Color.ForestGreen;
            this.tiSetting.AppearanceItem.Selected.Options.UseBackColor = true;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement1.Text = "SETTING";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tiSetting.Elements.Add(tileItemElement1);
            this.tiSetting.Id = 1;
            this.tiSetting.Name = "tiSetting";
            this.tiSetting.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tiSetting_ItemClick);
            // 
            // tiUser
            // 
            this.tiUser.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tiUser.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement2.Text = "SYSTEM USER";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tiUser.Elements.Add(tileItemElement2);
            this.tiUser.Id = 2;
            this.tiUser.Name = "tiUser";
            this.tiUser.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tiUser_ItemClick);
            // 
            // tiClose
            // 
            this.tiClose.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiClose.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tiClose.AppearanceItem.Normal.Options.UseFont = true;
            this.tiClose.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement3.Text = "EXIT SYSTEM";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tiClose.Elements.Add(tileItemElement3);
            this.tiClose.Id = 7;
            this.tiClose.Name = "tiClose";
            this.tiClose.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tiClose_ItemClick);
            // 
            // tiRekapWarkat
            // 
            this.tiRekapWarkat.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiRekapWarkat.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tiRekapWarkat.AppearanceItem.Normal.Options.UseFont = true;
            this.tiRekapWarkat.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "REKAP WARKAT";
            this.tiRekapWarkat.Elements.Add(tileItemElement4);
            this.tiRekapWarkat.Id = 3;
            this.tiRekapWarkat.IsLarge = true;
            this.tiRekapWarkat.Name = "tiRekapWarkat";
            // 
            // tiBank
            // 
            this.tiBank.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiBank.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tiBank.AppearanceItem.Normal.Options.UseFont = true;
            this.tiBank.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement5.Text = "MASTER BANK    ";
            this.tiBank.Elements.Add(tileItemElement5);
            this.tiBank.Id = 4;
            this.tiBank.IsLarge = true;
            this.tiBank.Name = "tiBank";
      
            // 
            // tiOffice
            // 
            this.tiOffice.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiOffice.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tiOffice.AppearanceItem.Normal.Options.UseFont = true;
            this.tiOffice.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement6.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement6.Image")));
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement6.Text = "MASTER OFFICE";
            this.tiOffice.Elements.Add(tileItemElement6);
            this.tiOffice.Id = 5;
            this.tiOffice.IsLarge = true;
            this.tiOffice.Name = "tiOffice";
            this.tiOffice.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tiOffice_ItemClick);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 575);
            this.Controls.Add(this.tiControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tiControl;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tiSetting;
        private DevExpress.XtraEditors.TileItem tiUser;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tiRekapWarkat;
        private DevExpress.XtraEditors.TileItem tiBank;
        private DevExpress.XtraEditors.TileItem tiOffice;
        private DevExpress.XtraEditors.TileItem tiClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}

