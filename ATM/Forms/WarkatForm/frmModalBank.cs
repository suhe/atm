using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;

namespace ATM.Forms.WarkatForm
{
    public partial class frmModalBank : Form
    {
        public delegate void DoEvent();
        public event DoEvent loadBankData;

        public static string bankCode = "";
        public static string bankName = "";
        public static string initial = "";
        public static string typeKey = "";

        public frmModalBank()
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
            Bank model = new Bank();
            gridControl1.DataSource = model.dataSource(bankCode, bankName, initial,typeKey);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BankID").ToString());
            string code = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BankCode").ToString());
            frmForm.BankID = id;
            frmForm.BankCode = code;
            //for foregin key 
            Warkat.BankID = id;
            this.loadBankData();
            this.Close();
        }

        private void frmModalBank_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            switch (cmbType.Text)
            {
                case "Bank Code" :
                    bankCode = txtSearch.Text;
                    bankName = "";
                    break;
                case "Bank Name" :
                    bankCode = "";
                    bankName = txtSearch.Text;
                    break;
                default:
                    bankCode = "";
                    bankName = "";
                    break;
            }
            this.loadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbType.Text = "Bank Code";
            bankCode = "";
            bankName = "";
            this.loadData();
        }

        

        
       
    }
}
