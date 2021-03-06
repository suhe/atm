﻿using System;
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
                //disabled code
                txtOfficeCode.Enabled = false;
                txtOfficeName.Select();
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
            else
            {
                txtOfficeCode.Select();
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
                    this.InsertOffice(); // call insert function 
                else
                    this.UpdateOffice();

                MessageBox.Show("Save Has been sucessfully !");
                this.loadData(); // load data after insert
                this.Close(); // close form
            }
        }

        private bool Validation()
        {
            Validation validate = new Validation();
            //required
            bool OfficeCode = validate.isRequired(txtOfficeCode.Text, "* Office Code : Required Do Not Empty");
            bool BankCode = validate.isRequired(txtBankCode.Text, "* Bank Code : Required Do Not Empty");
            bool OfficeName = validate.isRequired(txtOfficeName.Text, "* Office Name : Required Do Not Empty");
            bool Address = validate.isRequired(txtAddress.Text, "* Address : Required Do Not Empty");
            bool CityKey = validate.isRequired(txtCityKey.Text, "* City Key : Required Do Not Empty");
            bool ProvKey = validate.isRequired(txtProvinceKey.Text, "* Province Key : Required Do Not Empty");
            bool satKerKey = validate.isRequired(txtSatkerKey.Text, "* Sat Key : Required Do Not Empty");
            bool kliringKey = validate.isRequired(txtKliringKey.Text, "* Kliring Key : Required Do Not Empty");
            bool contactPhone = validate.isRequired(txtContactPhone.Text, "* Contact Phone : Required Do Not Empty");

            if (OfficeCode && BankCode && OfficeName && Address && CityKey && ProvKey && satKerKey && kliringKey && contactPhone)
            {
                Office model = new Office();
                if (model.FindByCode(txtOfficeCode.Text)==true && isEdit==false)
                {
                    MessageBox.Show("Office Code Has been Available Please Put Other Code !");
                    return false;
                }
                return true;
            }

            else
            {
                return false;
            }
        }

        private void InsertOffice()
        {
            Office model = new Office();
            Office.OfficeCode = txtOfficeCode.Text;
            Office.OfficeName = txtOfficeName.Text;
            Office.Address = txtAddress.Text;
            Office.CityKey = txtCityKey.Text;
            Office.ProvinceKey = txtProvinceKey.Text;
            Office.SetKerKey = txtSatkerKey.Text;
            Office.KliringKey = txtKliringKey.Text;
            Office.ContactPhone = txtContactPhone.Text;
            model.Insert();
        }

        private void UpdateOffice()
        {
            Office model = new Office();
            Office.OfficeCode = txtOfficeCode.Text;
            Office.OfficeName = txtOfficeName.Text;
            Office.Address = txtAddress.Text;
            Office.CityKey = txtCityKey.Text;
            Office.ProvinceKey = txtProvinceKey.Text;
            Office.SetKerKey = txtSatkerKey.Text;
            Office.KliringKey = txtKliringKey.Text;
            Office.ContactPhone = txtContactPhone.Text;
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

        private void txtOfficeCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBankCode.Focus();
            }
        }

        private void txtBankCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOfficeName.Focus();
            }
        }

        private void txtOfficeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCityKey.Focus();
            }
        }

        private void txtCityKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProvinceKey.Focus();
            }
        }

        private void txtProvinceKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSatkerKey.Focus();
            }
        }

        private void txtSatkerKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtKliringKey.Focus();
            }
        }

        private void txtKliringKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContactPhone.Focus();
            }
        }

        private void txtContactPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

    }
}
