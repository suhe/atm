using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATM.Models;
using CrystalDecisions.CrystalReports.Engine;
using ATM.Vendor.Vileosoft.Database;

namespace ATM.Forms.WarkatForm
{
    public partial class frmPrintOption : Form
    {
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
            //set model 
            Warkat Model = new Warkat();
            ReportDocument report = new ReportDocument();
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            report.Load(directory + "/Reports/Warkat/crAccountDueDate.rpt");
            report.DataSourceConnections[0].SetConnection(Connection.server + "\\" + Connection.instance, Connection.database, Connection.uid, Connection.password);
            report.SetDataSource(Model.findByAccount("01/01/2015","12/12/2015", 1, 1000));
            report.SetParameterValue("@DateFrom", "01/01/2015");
            report.SetParameterValue("@DateTo", "12/12/2015");
            report.SetParameterValue("@AccountFromID", 1);
            report.SetParameterValue("@AccountToID", 10000);
            Reports.frmCrystalReportViewer.report = report;
            Reports.frmCrystalReportViewer.ds = Model.findByAccount("01/01/2015", "12/12/2015", 1, 1000);
            Reports.frmCrystalReportViewer frm = new Reports.frmCrystalReportViewer();
            this.Close();
            frm.Show();
        }

   
    }
}
