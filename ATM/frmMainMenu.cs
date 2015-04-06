using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ATM
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area. 
            this.ControlBox = false;
        }

        private void tiUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            var frm = new Forms.frmUser();
            frm.Show();
        }

        private void tiClose_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DialogResult closeMsg = XtraMessageBox.Show("Apakah Anda ingin Keluar dari Aplikasi", "Keluar Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (closeMsg == DialogResult.Yes)
            {
                this.Hide();
                var frm = new Forms.frmLogin();
                frm.Show();
            }
        }

        private void tiSetting_ItemClick(object sender, TileItemEventArgs e)
        {
            var frm = new Forms.frmSetting();
            frm.Show();
        }

       
        private void tiOffice_ItemClick(object sender, TileItemEventArgs e)
        {
            var frm = new Forms.frmOffice();
            frm.Show();
        }
    }
}
