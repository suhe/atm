using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM.Forms.BankForm
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
            this.txtCode.Text = frmBank.bankCode;
            this.txtInitial.Text = frmBank.bankName;
            this.txtTypeKey.Text = frmBank.typeKey;
           
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmBank.bankCode = txtCode.Text;
            frmBank.bankName = txtInitial.Text;
            frmBank.bankInitial = txtInitial.Text;
            frmBank.typeKey = txtTypeKey.Text;
            this.loadData();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
