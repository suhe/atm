using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ATM.Models;
using ATM.Forms.UserForm;

namespace ATM.Forms
{
    public partial class frmUser : Form
    {
        public static string firstName = "";
        public static string lastName = "";
        public static string userName = "";
        public static string city = "";

        public frmUser()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area. 
            this.ControlBox = false;
            this.loadData();
            //User user = new User();
            //gridControl1.DataSource = user.dataSource(firstName,lastName,userName);
        }

        
        private void btnFind_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.loadData += new frmSearch.DoEvent(loadData);
            frm.ShowDialog();
        }

        private void loadData()
        {
            User user = new User();
            gridControl1.DataSource = user.dataSource(firstName, lastName, userName,city);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            firstName = "";
            lastName = "";
            userName = "";
            city = "";
            //load data
            this.loadData();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //MessageBox.Show("text");
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FirstName").ToString() + " " + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LastName").ToString();
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UserID").ToString();

            DialogResult delMsg = XtraMessageBox.Show("Are You sure want to Delete Name " + name , "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delMsg == DialogResult.Yes)
            {
                if (id!=null)
                {
                    User user = new User();
                    bool Del = user.Delete(id);
                    if (Del==true)
                    {
                        MessageBox.Show("Delete Has been sucessfully !");
                        this.loadData();
                    }
                }
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmForm.formName = "New User";
            frmForm frm = new frmForm();
            frm.loadData += new frmForm.DoEvent(loadData);
            frmForm.isEdit = false;
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UserID").ToString());
            if (id > 0)
            {
                frmForm.isEdit = true;
                User.UserID = id;
                frmForm.formName = "Edit User";
                frmForm frm = new frmForm();
                frm.loadData += new frmForm.DoEvent(loadData);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Data Have Been Binding for this form !");
            }
            
        }

        
    }
}
