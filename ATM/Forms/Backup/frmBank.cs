using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATM.Models;
using ATM.Forms.BankForm;

namespace ATM.Forms
{
    public partial class frmBank : Form
    {
        public static string bankCode = "";
        public static string bankName = "";
        public static string bankInitial = "";
        public static string typeKey = "";
        public static int status = 0;
       

        public frmBank()
        {
            InitializeComponent();
             this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area. 
            this.ControlBox = false;
            this.loadData();
        }

        private void loadData()
        {
            Bank model = new Bank();
            gridControl1.DataSource = model.dataSource(bankCode, bankName, bankInitial,typeKey);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmForm.formName = "New Bank";
            frmForm frm = new frmForm();
            frm.loadData += new frmForm.DoEvent(loadData);
            frmForm.isEdit = false;
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BankID").ToString());
            if (id > 0)
            {
                frmForm.isEdit = true;
                Bank.BankID = id;
                frmForm.formName = "Edit Bank";
                frmForm frm = new frmForm();
                frm.loadData += new frmForm.DoEvent(loadData);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Data Have Been Binding for this form !");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.loadData += new frmSearch.DoEvent(loadData);
            frm.ShowDialog();
        }

    }
}
