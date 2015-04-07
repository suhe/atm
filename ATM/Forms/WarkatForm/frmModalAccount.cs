using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;

namespace ATM.Forms.WarkatForm
{
    public partial class frmModalAccount : Form
    {
        public delegate void DoEvent();
        public event DoEvent loadAccountData;
        public static string accountNo = "";
        public static string accountName = "";

        public frmModalAccount()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area. 
            this.ControlBox = false;
            //load data
            this.loadData();
        }

        private void loadData()
        {
            Account model = new Account();
            gridControl1.DataSource = model.dataSource(accountNo,accountName);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbType.Text = "Account No";
            accountNo = "";
            accountName = "";
            this.loadData();
        }

        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            switch (cmbType.Text)
            {
                case "Account No":
                    accountNo = txtSearch.Text;
                    accountName = "";
                    break;
                case "Bank Name":
                    accountNo = "";
                    accountName = txtSearch.Text;
                    break;
                default:
                    accountNo = "";
                    accountName = "";
                    break;
            }
            this.loadData();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AccountID").ToString());
            string no = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AccountNo").ToString());
            frmForm.AccountID = id;
            frmForm.AccountNo = no;
            //for foregin key 
            Account.AccountID = id;
            this.loadAccountData();
            this.Close();
        }

        

       
        
    }
}
