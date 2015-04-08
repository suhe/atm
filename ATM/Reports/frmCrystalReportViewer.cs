using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using ATM.Models;
using CrystalDecisions.CrystalReports.Engine;

namespace ATM.Reports
{
    public partial class frmCrystalReportViewer : Form
    {
        public static DataSet ds;
       

        public frmCrystalReportViewer()
        {
            InitializeComponent();
            ReportDocument report = new ReportDocument();
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            report.Load(directory + "/Reports/Office/crList.rpt");
            report.SetDataSource(ds);
            report.SetParameterValue("@OfficeCode", ATM.Models.Office.OfficeCode);
            report.SetParameterValue("@BankCode", ATM.Models.Office.BankCode);
            report.SetParameterValue("@OfficeName", "KBI");
            report.SetParameterValue("@BankName", ATM.Models.Office.BankName);
            report.SetParameterValue("@Address", ATM.Models.Office.Address);
            crViewer.ReportSource = report;
            
        }
    }
}
