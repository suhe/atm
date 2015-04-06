using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;
using ATM.Vendor.Vileosoft.Forms;

namespace ATM.Forms.OfficeForm
{
    public partial class frmForm : Form
    {
        public delegate void DoEvent();
        public event DoEvent loadData;

        public static int BankID;
        public static string BankCode;
       
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
            this.txtOfficeCode.Focus();
            //if is Edit = TRUE binding Data
            if (isEdit == true)
            {
                Office model = new Office();
                model.DataReader();
                this.txtOfficeCode.Text = Office.OfficeCode;
                this.txtBankCode.Text = Office.BankCode;
                this.txtOfficeName.Text = Office.OfficeName;
                this.txtAddress.Text = Office.Address;
                this.txtCityKey.Text = Office.CityKey;
                this.txtProvinceKey.Text = Office.ProvinceKey;
                this.txtSatkerKey.Text = Office.SetKerKey;
                this.txtKliringKey.Text = Office.KliringKey;
                this.txtContactPhone.Text = Office.ContactPhone;
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
            bool FirstName = validate.isRequired(txtOfficeCode.Text, "* First Name : Required Do Not Empty");
            bool LastName = validate.isRequired(txtBankCode.Text, "* Last Name : Required Do Not Empty");
            bool UserName = validate.isRequired(txtOfficeName.Text, "* User Name : Required Do Not Empty");
            bool Password = validate.isRequired(txtAddress.Text, "* Password : Required Do Not Empty");
     
            if (FirstName && LastName && UserName && Password)
                return true;
            else
                return false;
        }

        private void InsertUser()
        {
            User model = new User();
            User.FirstName = txtOfficeCode.Text;
            User.LastName = txtBankCode.Text;
            User.UserName = txtOfficeName.Text;
            User.Password = txtAddress.Text;
            User.Title = txtCityKey.Text;
            User.Address = txtProvinceKey.Text;
            User.City = txtSatkerKey.Text;
            User.PostalCode = txtKliringKey.Text;
            model.Insert();
        }

        private void UpdateUser()
        {
            User model = new User();
            User.FirstName = txtOfficeCode.Text;
            User.LastName = txtBankCode.Text;
            User.UserName = txtOfficeName.Text;
            User.Password = txtAddress.Text;
            User.Title = txtCityKey.Text;
            User.Address = txtProvinceKey.Text;
            User.City = txtSatkerKey.Text;
            User.PostalCode = txtKliringKey.Text;
            model.Update();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmModalBank frm = new frmModalBank();
            frm.loadBankData += new frmModalBank.DoEvent(loadBankData);
            frm.ShowDialog();
        }

        private void loadBankData()
        {
            txtBankCode.Text = BankCode;
        }

    }
}
