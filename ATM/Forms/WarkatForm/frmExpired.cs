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
    public partial class frmExpired : Form
    {
        public frmExpired()
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
            gridControl1.DataSource = model.dataSourceByExpired();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //adding crystal report
            //set model 
            Warkat Model = new Warkat();
            ReportDocument report = new ReportDocument();
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            report.Load(directory + "/Reports/Warkat/crExpiredDueDate.rpt");
            report.DataSourceConnections[0].SetConnection(Connection.server + "\\" + Connection.instance, Connection.database, Connection.uid, Connection.password);
            report.SetDataSource(Model.findByExpired());
            Reports.frmCrystalReportViewer.report = report;
            Reports.frmCrystalReportViewer.ds = Model.findByExpired();
            Reports.frmCrystalReportViewer frm = new Reports.frmCrystalReportViewer();
            frm.Show();
        }

        
    }
}
