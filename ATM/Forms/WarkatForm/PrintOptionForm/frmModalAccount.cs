using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;
using DevExpress.XtraEditors;

namespace ATM.Forms.WarkatForm.PrintOptionForm
{
    public partial class frmModalAccount : Form
    {
        public delegate void DoEvent();
        public event DoEvent loadAccountFrom;
        public event DoEvent loadAccountTo;
        public static string accountNo = "";
        public static string accountName = "";
        public static bool isAccountFrom = false;
        public static bool isAccountTo = false;

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
            gridControl1.DataSource = model.dataSource(accountNo, accountName);
        }

        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            switch (cmbType.Text)
            {
                case "Account No":
                    accountNo = txtSearch.Text;
                    accountName = "";
                    break;
                case "Account Name":
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbType.Text = "Account No";
            txtSearch.Text = "";
            accountNo = "";
            accountName = "";
            this.loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AccountID").ToString());
            string no = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AccountNo").ToString());
            if (isAccountFrom == true && isAccountTo == false)
            {
                frmPrintOption.AccountFromID = id;
                frmPrintOption.AccountFromNo = no;
                this.loadAccountFrom();//for foregin key 
            }
            else
            {
                frmPrintOption.AccountToID = id;
                frmPrintOption.AccountToNo = no;
                this.loadAccountTo();//for foregin key 
            }
            
            this.Close();
        }

    }
}
