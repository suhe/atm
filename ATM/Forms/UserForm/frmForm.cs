using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;
using ATM.Vendor.Vileosoft.Forms;

namespace ATM.Forms.UserForm
{
    public partial class frmForm : Form
    {
        public delegate void DoEvent();
        public event DoEvent loadData;
       
        public static string formName = null;
        public static bool isEdit = false;

        public frmForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area. 
            this.ControlBox = false;
            this.lblFormName.Text = formName;
            this.txtFirstName.Focus();
            //if is Edit = TRUE binding Data
            if (isEdit == true)
            {
                User model = new User();
                model.DataReader();
                this.txtFirstName.Text = User.FirstName;
                this.txtLastName.Text = User.LastName;
                this.txtUserName.Text = User.UserName;
                this.txtPassword.Text = User.Password;
                this.txtTitle.Text = User.Title;
                this.txtAddress.Text = User.Address;
                this.txtCity.Text = User.City;
                this.txtPostalCode.Text = User.PostalCode;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Validation())
            {
                if (isEdit == false)
                    this.InsertUser(); // call insert function 
                else
                    this.UpdateUser();

                MessageBox.Show("Save Has been sucessfully !");
                this.loadData(); // load data after insert
                this.Close(); // close form
            }
        }

        private bool Validation()
        {
            Validation validate = new Validation();
            //required
            bool FirstName = validate.isRequired(txtFirstName.Text, "* First Name : Required Do Not Empty");
            bool LastName = validate.isRequired(txtLastName.Text, "* Last Name : Required Do Not Empty");
            bool UserName = validate.isRequired(txtUserName.Text, "* User Name : Required Do Not Empty");
            bool Password = validate.isRequired(txtPassword.Text, "* Password : Required Do Not Empty");
     
            if (FirstName && LastName && UserName && Password)
                return true;
            else
                return false;
        }

        private void InsertUser()
        {
            User model = new User();
            User.FirstName = txtFirstName.Text;
            User.LastName = txtLastName.Text;
            User.UserName = txtUserName.Text;
            User.Password = txtPassword.Text;
            User.Title = txtTitle.Text;
            User.Address = txtAddress.Text;
            User.City = txtCity.Text;
            User.PostalCode = txtPostalCode.Text;
            model.Insert();
        }

        private void UpdateUser()
        {
            User model = new User();
            User.FirstName = txtFirstName.Text;
            User.LastName = txtLastName.Text;
            User.UserName = txtUserName.Text;
            User.Password = txtPassword.Text;
            User.Title = txtTitle.Text;
            User.Address = txtAddress.Text;
            User.City = txtCity.Text;
            User.PostalCode = txtPostalCode.Text;
            model.Update();
        }

    }
}
