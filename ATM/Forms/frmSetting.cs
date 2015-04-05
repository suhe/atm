using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;
using ATM.Vendor.Vileosoft.Forms;

namespace ATM.Forms
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
            ProfileForm model = new ProfileForm();
            if (model.MyProfile())
            {
                this.txtFirstName.Text = ProfileForm.FirstName;
                this.txtLastName.Text = ProfileForm.LastName;
                this.txtTitle.Text = ProfileForm.Title;
                this.txtAddress.Text = ProfileForm.Address;
                this.txtCity.Text = ProfileForm.City;
                this.txtPostalCode.Text = ProfileForm.PostalCode;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidationProfile())
            {
                if (this.UpdateProfile() == true)
                {
                    MessageBox.Show("Update Profile Has been sucessfully !");
                }
                
            }
        }

        private bool ValidationProfile()
        {
            Validation validate = new Validation();
            //required
            bool FirstName = validate.isRequired(txtFirstName.Text, "* First Name : Required Do Not Empty");
            bool LastName = validate.isRequired(txtLastName.Text, "* Last Name : Required Do Not Empty");
            
            if (FirstName && LastName)
                return true;
            else
                return false;
        }

        private bool UpdateProfile()
        {
            ProfileForm model = new ProfileForm();
            ProfileForm.FirstName = txtFirstName.Text;
            ProfileForm.LastName = txtLastName.Text;
            ProfileForm.Title = txtTitle.Text;
            ProfileForm.Address = txtAddress.Text;
            ProfileForm.City = txtCity.Text;
            ProfileForm.PostalCode = txtPostalCode.Text;
            model.Update();
            return true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (this.ValidationChangePassword())
            {
                if (this.ChangePassword() == true)
                {
                    MessageBox.Show("Change Password Has been sucessfully !");
                }

            }
        }

        private bool ValidationChangePassword()
        {
            Validation validate = new Validation();
            //required
            bool Password = validate.isRequired(txtNewPassword.Text, "* New Password : Required Do Not Empty");
            bool CPassword = validate.isRequired(txtConfirmPassword.Text, "* Confirm : Required Do Not Empty");
            bool EPassword = validate.isEqual(txtNewPassword.Text,txtConfirmPassword.Text, "* Confirm : Password & Confirm Do Not Match");

            if (Password && CPassword && EPassword)
                return true;
            else
                return false;
        }

        private bool ChangePassword()
        {
            ProfileForm model = new ProfileForm();
            ProfileForm.Password = txtNewPassword.Text;
            model.ChangePassword();
            return true;
        }


    }
}
