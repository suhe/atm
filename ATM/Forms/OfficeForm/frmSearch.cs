using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Forms;

namespace ATM.Forms.OfficeForm
{
    public partial class frmSearch : Form
    {
        public delegate void DoEvent();
        public event DoEvent loadData;

        public frmSearch()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area. 
            this.ControlBox = false;
            this.txtOfficeCode.Select();
            this.txtOfficeCode.Text = frmOffice.officeCode;
            this.txtBankCode.Text = frmOffice.bankCode;
            this.txtBankName.Text = frmOffice.bankName;
            this.txtOfficeName.Text = frmOffice.officeName;
            this.txtAddress.Text = frmOffice.address;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmOffice.officeCode = this.txtOfficeCode.Text;
            frmOffice.bankCode = this.txtBankCode.Text;
            frmOffice.bankName = this.txtBankName.Text;
            frmOffice.officeName = this.txtOfficeName.Text;
            frmOffice.address = this.txtAddress.Text;

            this.loadData();
            this.Close();
        }

        private void txtOfficeCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBankCode.Focus();
            }
        }

        private void txtBankCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBankName.Focus();
            }
        }

        private void txtBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOfficeName.Focus();
            }
        }

        private void txtOfficeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
            }
        }
    }
}
