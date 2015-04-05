using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Vendor.Vileosoft.Forms;
using ATM.Models;

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
                    this.Hide();
                    var frm = new frmMainMenu();
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

    }
}
