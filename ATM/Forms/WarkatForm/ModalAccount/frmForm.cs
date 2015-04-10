using System;
using System.Collections.Generic;
using System.Linq;
using ATM.Models;
using System.Windows.Forms;
using ATM.Vendor.Vileosoft.Forms;

namespace ATM.Forms.WarkatForm.ModalAccount
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
            this.txtAccountNo.Focus();
            //if is Edit = TRUE binding Data
            if (isEdit == true)
            {
                //disabled code
                this.txtAccountNo.Enabled = false;
                this.txtAccountName.Select();
                Account model = new Account();
                model.DataReader();
                this.txtAccountNo.Text = Account.AccountNo;
                this.txtAccountName.Text = Account.AccountName;
            }
            else
            {
                this.txtAccountNo.Select();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Validation())
            {
                if (isEdit == false)
                    this.InsertAccount(); // call insert function 
                else
                    this.UpdateAccount();

                MessageBox.Show("Save Has been sucessfully !");
                this.loadData(); // load data after insert
                this.Close(); // close form
            }
        }

        private void InsertAccount()
        {
            Account model = new Account();
            Account.AccountNo = txtAccountNo.Text;
            Account.AccountName = txtAccountName.Text;
            model.Insert();
        }

        private void UpdateAccount()
        {
            Account model = new Account();
            Account.AccountName = txtAccountName.Text;
            model.Update();
        }

        private bool Validation()
        {
            Validation validate = new Validation();
            //required
            bool AccountNo = validate.isRequired(txtAccountNo.Text, "* Account No : Required Do Not Empty");
            bool AccountName = validate.isRequired(txtAccountName.Text, "* Account Name : Required Do Not Empty");
           
            if (AccountNo && AccountName)
            {
                Account model = new Account();
                if (model.FindByCode(txtAccountNo.Text) == true && isEdit == false)
                {
                    MessageBox.Show("Account No Has been Available Please Put Other Code !");
                    return false;
                }
                return true;
            }

            else
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAccountNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAccountName.Focus();
            }
        }

        private void txtAccountName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

    }
}
