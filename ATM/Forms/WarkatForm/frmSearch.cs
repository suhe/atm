using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATM.Vendor.Vileosoft.Forms;

namespace ATM.Forms.WarkatForm
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
            this.txtTransactionCode.Select();
            this.txtTransactionCode.Text = frmWarkat.transactionCode;
            this.txtWarkatNo.Text = frmWarkat.warkatNo;
            this.txtDueDateFrom.Text = frmWarkat.dateFrom;
            this.txtDueDateTo.Text = frmWarkat.dateTo;
            this.txtBankCode.Text = frmWarkat.bankCode;
            this.txtAccountNo.Text = frmWarkat.accountNo;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.Validation() == true)
            {
                frmWarkat.transactionCode = this.txtTransactionCode.Text;
                frmWarkat.warkatNo = this.txtWarkatNo.Text;
                frmWarkat.dateFrom = this.txtDueDateFrom.Text;
                frmWarkat.dateTo = this.txtDueDateTo.Text;
                frmWarkat.bankCode = this.txtBankCode.Text;
                frmWarkat.accountNo = this.txtAccountNo.Text;
                this.loadData();
                this.Close();
            }
        }

        private bool Validation()
        {
            Validation validate = new Validation();
            //required
            bool dateFrom = validate.isRequired(txtDueDateFrom.Text, "* Date From : Required Do Not Empty");
            bool dateTo = validate.isRequired(txtDueDateTo.Text, "* Date To : Required Do Not Empty");
            
            if (dateFrom && dateTo)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private void txtTransactionCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtWarkatNo.Focus();
            }
        }

        private void txtWarkatNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDueDateFrom.Focus();
            }
        }

        private void txtDueDateFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDueDateTo.Focus();
            }
        }

        private void txtDueDateTo_KeyDown(object sender, KeyEventArgs e)
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
                txtAccountNo.Focus();
            }
        }

        private void txtAccountNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
            }
        }

    }
}
