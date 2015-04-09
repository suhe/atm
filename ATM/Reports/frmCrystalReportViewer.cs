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
        public static ReportDocument report;

        public frmCrystalReportViewer()
        {
            InitializeComponent();
            crViewer.ReportSource = report;
            
        }
    }
}
