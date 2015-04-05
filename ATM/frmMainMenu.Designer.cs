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
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            this.tiControl = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tiSetting = new DevExpress.XtraEditors.TileItem();
            this.tiUser = new DevExpress.XtraEditors.TileItem();
            this.tiClose = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
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
            this.tiControl.Size = new System.Drawing.Size(1457, 575);
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
            this.tileGroup3.Items.Add(this.tileItem3);
            this.tileGroup3.Items.Add(this.tileItem4);
            this.tileGroup3.Items.Add(this.tileItem5);
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
            tileItemElement7.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement7.Image")));
            tileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement7.Text = "SETTING";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tiSetting.Elements.Add(tileItemElement7);
            this.tiSetting.Id = 1;
            this.tiSetting.Name = "tiSetting";
            this.tiSetting.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tiSetting_ItemClick);
            // 
            // tiUser
            // 
            this.tiUser.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tiUser.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement8.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement8.Image")));
            tileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement8.Text = "SYSTEM USER";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tiUser.Elements.Add(tileItemElement8);
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
            tileItemElement9.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement9.Image")));
            tileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement9.Text = "EXIT SYSTEM";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tiClose.Elements.Add(tileItemElement9);
            this.tiClose.Id = 7;
            this.tiClose.Name = "tiClose";
            this.tiClose.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tiClose_ItemClick);
            // 
            // tileItem3
            // 
            this.tileItem3.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem3.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tileItem3.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem3.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement10.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement10.Image")));
            tileItemElement10.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement10.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement10.Text = "REKAP WARKAT";
            this.tileItem3.Elements.Add(tileItemElement10);
            this.tileItem3.Id = 3;
            this.tileItem3.IsLarge = true;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem4
            // 
            this.tileItem4.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem4.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tileItem4.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem4.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement11.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement11.Image")));
            tileItemElement11.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement11.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement11.Text = "MASTER BANK    ";
            this.tileItem4.Elements.Add(tileItemElement11);
            this.tileItem4.Id = 4;
            this.tileItem4.IsLarge = true;
            this.tileItem4.Name = "tileItem4";
            // 
            // tileItem5
            // 
            this.tileItem5.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem5.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tileItem5.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem5.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement12.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement12.Image")));
            tileItemElement12.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileItemElement12.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement12.Text = "MASTER OFFICE";
            this.tileItem5.Elements.Add(tileItemElement12);
            this.tileItem5.Id = 5;
            this.tileItem5.IsLarge = true;
            this.tileItem5.Name = "tileItem5";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1457, 575);
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
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem tiClose;

    }
}

