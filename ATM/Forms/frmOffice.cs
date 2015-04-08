using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;
using DevExpress.XtraEditors;
using ATM.Forms.OfficeForm;
using CrystalDecisions.CrystalReports.Engine;

namespace ATM.Forms
{
    public partial class frmOffice : Form
    {
        public static string officeCode = "";
        public static string bankCode = "";
        public static string officeName = "";
        public static string bankName = "";
        public static string address = "";


        public frmOffice()
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
            Office model = new Office();
            gridControl1.DataSource = model.dataSource(officeCode, bankCode, officeName, bankName, address);
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmForm.formName = "New Office";
            frmForm frm = new frmForm();
            frm.loadData += new frmForm.DoEvent(loadData);
            frmForm.isEdit = false;
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "OfficeName").ToString();
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "OfficeID").ToString();

            DialogResult delMsg = XtraMessageBox.Show("Are You sure want to Delete Office Name : " + name, "Delete Office", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delMsg == DialogResult.Yes)
            {
                if (id != null)
                {
                    Office office = new Office();
                    bool Del = office.Delete(id);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "OfficeID").ToString());
            if (id > 0)
            {
                frmForm.isEdit = true;
                Office.OfficeID = id;
                frmForm.formName = "Edit Office";
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
            officeCode = "";
            officeName = "";
            bankCode = "";
            bankName = "";
            address = "";
            //load data
            this.loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //set model 
            Office Model = new Office();
            Reports.frmCrystalReportViewer.ds = Model.dataSet(officeCode, bankCode, officeName, bankName, address);
            Reports.frmCrystalReportViewer frm = new Reports.frmCrystalReportViewer();
            frm.Show();
        }
        
    }
}