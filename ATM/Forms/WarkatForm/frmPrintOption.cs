using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;
using CrystalDecisions.CrystalReports.Engine;
using ATM.Vendor.Vileosoft.Database;
using ATM.Vendor.Vileosoft.Forms;

namespace ATM.Forms.WarkatForm
{
    public partial class frmPrintOption : Form
    {
        public static int AccountFromID = 1;
        public static int AccountToID = 100000;
        public static string AccountFromNo = "";
        public static string AccountToNo = "";
       
        public frmPrintOption()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Validation validate = new Validation();
            bool isDateFrom = validate.isRequired(txtDueDateFrom.Text," * Required : Due Date From is Can't Blank !");
            bool isDateTo = validate.isRequired(txtDueDateTo.Text, " * Required : Due Date To is Can't Blank !");
            bool isAccountFrom = true;
            bool isAccountTo = true;
            //validation if checbox all account is false
            if (chAllAccount.Checked == false)
            {
                isAccountFrom = validate.isRequired(txtFromAccountID.Text, " * Required : Account From is Can't Blank !");
                isAccountTo = validate.isRequired(txtToAccountID.Text, " * Required : Account To is Can't Blank !");
            }
            else
            {
                AccountFromID = 1;
                AccountToID = 10000;
                AccountFromNo = "Account A";
                AccountToNo = "Account Z";
            }

            if (isDateFrom && isDateTo && isAccountFrom && isAccountTo)
            {
                
                //set model 
                Warkat Model = new Warkat();
                ReportDocument report = new ReportDocument();
                string directory = AppDomain.CurrentDomain.BaseDirectory;
                report.Load(directory + "/Reports/Warkat/crAccountDueDate.rpt");
                report.DataSourceConnections[0].SetConnection(Connection.server + "\\" + Connection.instance, Connection.database, Connection.uid, Connection.password);
                report.SetDataSource(Model.findByAccount(txtDueDateFrom.Text, txtDueDateTo.Text, AccountFromID, AccountToID));
                report.SetParameterValue("@DateFrom", txtDueDateFrom.Text);
                report.SetParameterValue("@DateTo", txtDueDateTo.Text);
                report.SetParameterValue("@AccountFromID", AccountFromID);
                report.SetParameterValue("@AccountToID",AccountToID);
                report.SetParameterValue("@AccountFromNo", AccountFromNo!=""?AccountFromNo:"Account A");
                report.SetParameterValue("@AccountToNo", AccountToNo != "" ? AccountToNo : "Account Z");
                Reports.frmCrystalReportViewer.report = report;
                Reports.frmCrystalReportViewer.ds = Model.findByAccount(txtDueDateFrom.Text, txtDueDateTo.Text, AccountFromID, AccountToID);
                Reports.frmCrystalReportViewer frm = new Reports.frmCrystalReportViewer();
                this.Close();
                frm.Show();
            }
        }

        private void chAllAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (chAllAccount.Checked == false)
            {
                btnFindAccountFromID.Enabled = true;
                btnFindAccountToID.Enabled = true;
            }
            else
            {
                btnFindAccountFromID.Enabled =false;
                btnFindAccountToID.Enabled = false;
            }
        }

        private void btnFindAccountFromID_Click(object sender, EventArgs e)
        {
            PrintOptionForm.frmModalAccount frm = new PrintOptionForm.frmModalAccount();
            PrintOptionForm.frmModalAccount.isAccountFrom = true;
            PrintOptionForm.frmModalAccount.isAccountTo = false;
            frm.loadAccountFrom += new PrintOptionForm.frmModalAccount.DoEvent(loadAccountFrom);
            frm.ShowDialog();
        }

        private void loadAccountFrom()
        {
            txtFromAccountID.Text = AccountFromNo;
        }

        private void btnFindAccountToID_Click(object sender, EventArgs e)
        {
            PrintOptionForm.frmModalAccount frm = new PrintOptionForm.frmModalAccount();
            PrintOptionForm.frmModalAccount.isAccountFrom = false;
            PrintOptionForm.frmModalAccount.isAccountTo = true;
            frm.loadAccountTo += new PrintOptionForm.frmModalAccount.DoEvent(loadAccountTo);
            frm.ShowDialog();
        }

        private void loadAccountTo()
        {
            txtToAccountID.Text = AccountToNo;
        }
   
    }
}
