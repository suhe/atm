using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;
using DevExpress.XtraEditors;

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
            this.txtSearch.Select();
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
            txtSearch.Text = "";
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AccountID").ToString());
            string no = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AccountNo").ToString());
            frmForm.AccountID = id;
            frmForm.AccountNo = no;
            //for foregin key 
            Warkat.AccountID = id;
            this.loadAccountData();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModalAccount.frmForm.formName = "New Account";
            ModalAccount.frmForm frm = new ModalAccount.frmForm();
            frm.loadData += new ModalAccount.frmForm.DoEvent(loadData);
            ModalAccount.frmForm.isEdit = false;
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AccountID").ToString());
            if (id > 0)
            {
                ModalAccount.frmForm.isEdit = true;
                Account.AccountID = id;
                ModalAccount.frmForm.formName = "Edit Account";
                ModalAccount.frmForm frm = new ModalAccount.frmForm();
                frm.loadData += new ModalAccount.frmForm.DoEvent(loadData);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Data Have Been Binding for this form !");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AccountNo").ToString();
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AccountID").ToString();

            DialogResult delMsg = XtraMessageBox.Show("Are You sure want to Delete Account No : " + name, "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delMsg == DialogResult.Yes)
            {
                if (id != null)
                {
                    Account account = new Account();
                    bool Del = account.Delete(id);
                    if (Del == true)
                    {
                        MessageBox.Show("Delete Has been sucessfully !");
                        this.loadData();
                    }
                }
            }
        }

       
        
    }
}
