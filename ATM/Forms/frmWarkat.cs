using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATM.Models;
using ATM.Forms.WarkatForm;

namespace ATM.Forms
{
    public partial class frmWarkat : Form
    {
        
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
            gridControl1.DataSource = model.dataSource();
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

    }
}
