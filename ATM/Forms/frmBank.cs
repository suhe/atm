using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;
using ATM.Forms.BankForm;
using DevExpress.XtraEditors;
using ATM.Vendor.Vileosoft.Database;
using CrystalDecisions.CrystalReports.Engine;

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            bankCode = "";
            bankName = "";
            bankInitial = "";
            typeKey = "";
            //load data
            this.loadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //adding crystal report
            //set model 
            Bank Model = new Bank();
            ReportDocument report = new ReportDocument();
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            report.Load(directory + "/Reports/Bank/crList.rpt");
            report.DataSourceConnections[0].SetConnection(Connection.server + "\\" + Connection.instance, Connection.database, Connection.uid, Connection.password);
            report.SetDataSource(Model.dataSet(bankCode,bankName,bankInitial,typeKey));
            report.SetParameterValue("@BankCode", bankCode);
            report.SetParameterValue("@BankName", bankName);
            report.SetParameterValue("@Initial", bankInitial);
            report.SetParameterValue("@TypeKey", typeKey);
            Reports.frmCrystalReportViewer.report = report;
            Reports.frmCrystalReportViewer.ds = Model.dataSet(bankCode, bankName,bankInitial,typeKey);
            Reports.frmCrystalReportViewer frm = new Reports.frmCrystalReportViewer();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BankName").ToString();
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BankID").ToString();

            DialogResult delMsg = XtraMessageBox.Show("Are You sure want to Delete Bank Name : " + name, "Delete Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delMsg == DialogResult.Yes)
            {
                if (id != null)
                {
                    Bank bank = new Bank();
                    bool Del = bank.Delete(id);
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
