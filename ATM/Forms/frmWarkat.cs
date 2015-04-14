using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;
using ATM.Forms.WarkatForm;
using DevExpress.XtraEditors;

namespace ATM.Forms
{
    public partial class frmWarkat : Form
    {
        public static string transactionCode = "";
        public static string warkatNo = "";
        public static string dateFrom = "01/01/2015";
        public static string dateTo = "12/31/2017";
        public static string bankCode= "";
        public static string accountNo = "";
        
        public frmWarkat()
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
            Warkat model = new Warkat();
            gridControl1.DataSource = model.dataSource(transactionCode,warkatNo,dateFrom,dateTo,bankCode,accountNo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmForm.formName = "New Warkat";
            frmForm frm = new frmForm();
            frm.loadData += new frmForm.DoEvent(loadData);
            frmForm.isEdit = false;
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "#").ToString());
            if (id > 0)
            {
                frmForm.isEdit = true;
                Warkat.WarkatID = id;
                frmForm.formName = "Edit Warkat";
                frmForm frm = new frmForm();
                frm.loadData += new frmForm.DoEvent(loadData);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Data Have Been Binding for this form !");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            transactionCode = "";
            warkatNo = "";
            dateFrom = "01/01/2015";
            dateTo = "12/31/2017";
            bankCode = "";
            accountNo = "";
            this.loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TransactionCode").ToString();
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "#").ToString();

            DialogResult delMsg = XtraMessageBox.Show("Are You sure want to Delete Transaction Code : " + name, "Delete Warkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delMsg == DialogResult.Yes)
            {
                if (id != null)
                {
                    Warkat Warkat = new Warkat();
                    bool Del = Warkat.Delete(id);
                    if (Del == true)
                    {
                        MessageBox.Show("Delete Has been sucessfully !");
                        this.loadData();
                    }
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.loadData += new frmSearch.DoEvent(loadData);
            frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrintOption frm = new frmPrintOption();
            frm.ShowDialog();
        }

    }
}
