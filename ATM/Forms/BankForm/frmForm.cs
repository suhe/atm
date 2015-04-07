using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Models;
using ATM.Vendor.Vileosoft.Forms;

namespace ATM.Forms.BankForm
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
            this.txtCode.Focus();
            //if is Edit = TRUE binding Data
            if (isEdit == true)
            {
                //disabled code
                txtCode.Enabled = false;
                Bank model = new Bank();
                model.DataReader();
                this.txtCode.Text = Bank.BankCode;
                this.txtName.Text = Bank.BankName;
                this.txtInitial.Text = Bank.BankInitial;
                this.txtTypeKey.Text = Bank.TypeKey;
                this.txtStatus.Text = Bank.Status.ToString();
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
                    this.InsertBank(); // call insert function 
                else
                    this.UpdateBank();

                MessageBox.Show("Save Has been sucessfully !");
                this.loadData(); // load data after insert
                this.Close(); // close form
            }
        }

        private bool Validation()
        {
            Validation validate = new Validation();
            //required
            bool BankCode = validate.isRequired(txtCode.Text, "* Bank Code : Required Do Not Empty");
            bool bankName = validate.isRequired(txtName.Text, "* Bank Name : Required Do Not Empty");
            bool bankInitial = validate.isRequired(txtInitial.Text, "* Bank Initial : Required Do Not Empty");
            bool TypeKey = validate.isRequired(txtTypeKey.Text, "* Type Key : Required Do Not Empty");
            bool Status = validate.isRequired(txtStatus.Text, "* Status : Required Do Not Empty");
            
            if (BankCode && bankName && bankInitial && TypeKey && Status)
            {
                Bank model = new Bank();
                if (model.FindByCode(txtCode.Text)==true && isEdit==false)
                {
                    MessageBox.Show("Bank Code Has been Available Please Put Other Code !");
                    return false;
                }
                return true;
            }

            else
            {
                return false;
            }
        }

        private void InsertBank()
        {
            Bank model = new Bank();
            Bank.BankCode = txtCode.Text;
            Bank.BankName = txtName.Text;
            Bank.BankInitial = txtInitial.Text;
            Bank.TypeKey = txtTypeKey.Text;
            Bank.Status = int.Parse(txtStatus.Text);
            model.Insert();
        }

        private void UpdateBank()
        {
            Bank model = new Bank();
            Bank.BankCode = txtCode.Text;
            Bank.BankName = txtName.Text;
            Bank.BankInitial = txtInitial.Text;
            Bank.TypeKey = txtTypeKey.Text;
            Bank.Status = int.Parse(txtStatus.Text);
            model.Update();
        }

        

        private void txtStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
