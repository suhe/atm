using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Vendor.Vileosoft.Forms;
using ATM.Models;
using DevExpress.XtraEditors;

namespace ATM.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area. 
            this.ControlBox = false;
            this.txtUsername.Select();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.Validation())
            {
                LoginForm.UserName = this.txtUsername.Text;
                LoginForm.Password = this.txtPassword.Text;
                LoginForm model = new LoginForm();
                if (model.isLogin() == true)
                {
                    //MessageBox Before Login
                    Warkat model2 = new Warkat();
                    int total = model2.CountDataSourceByExpired();
                    if (total > 0)
                    {
                        DialogResult WarningMsg = XtraMessageBox.Show("Expired Due Date Total is " + total + " Data, Your must Login for Preview ?", "Due Date Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (WarningMsg == DialogResult.No)
                        {
                            frmMainMenu.isExpired = false;
                        }
                        else
                        {
                            frmMainMenu.isExpired = true;
                        }
                    }

                    this.Hide();
                    frmMainMenu frm = new frmMainMenu();
                    frm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Username or Password Incorrect Please try again !");
                }
            }
        }

        private bool Validation()
        {
            Validation validate = new Validation();
            //required
            bool UserName = validate.isRequired(txtUsername.Text, "* First Name : Required Do Not Empty");
            bool Password = validate.isRequired(txtPassword.Text, "* Last Name : Required Do Not Empty");
          
            if (UserName && Password)
                return true;
            else
                return false;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //MessageBox Before Login
            Warkat model2 = new Warkat();
            int total = model2.CountDataSourceByExpired();
            if (total > 0)
            {
                DialogResult WarningMsg = XtraMessageBox.Show("Expired Due Date Total is " + total + " Data, Your must Login for Preview ?", "Due Date Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (WarningMsg == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

    }
}
