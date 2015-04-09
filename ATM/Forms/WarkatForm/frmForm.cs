using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Vendor.Vileosoft.Forms;
using ATM.Models;

namespace ATM.Forms.WarkatForm
{
    public partial class frmForm : Form
    {
        public static string formName = null;
        public static bool isEdit = false;
        public static int BankID = 0;
        public static string BankCode="";
        public static int AccountID = 0;
        public static string AccountNo="";

        public delegate void DoEvent();
        public event DoEvent loadData;

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
            this.txtWarkatNo.Focus();
            //if is Edit = TRUE binding Data
            Warkat model = new Warkat();
            if (isEdit == true)
            {
                //disabled code
                txtTransactionCode.Enabled = false;
                model.DataReader();
                this.txtTransactionCode.Text = Warkat.TransactionCode;
                this.txtWarkatNo.Text = Warkat.WarkatNo;
                this.txtDueDate.EditValue = Warkat.DueDate;
                this.txtBankCode.Text = Warkat.BankCode;
                this.txtAccountNo.Text = Warkat.AccountNo;
                this.txtNominal.Text = Warkat.Nominal.ToString();
            }
            else
            {
                txtTransactionCode.Enabled = false; //set to false
                txtTransactionCode.Text = model.AutoTransactionCode();
            }
        }

        private void btnFindBankCode_Click(object sender, EventArgs e)
        {
            frmModalBank frm = new frmModalBank();
            frm.loadBankData += new frmModalBank.DoEvent(loadBankData);
            frm.ShowDialog();
        }

        private void loadBankData()
        {
            txtBankCode.Text = BankCode;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindAccountNo_Click(object sender, EventArgs e)
        {
            frmModalAccount frm = new frmModalAccount();
            frm.loadAccountData += new frmModalAccount.DoEvent(loadAccountData);
            frm.ShowDialog();
        }

        private void loadAccountData()
        {
            txtAccountNo.Text = AccountNo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Validation())
            {
                if (isEdit == false)
                    this.InsertWarkat(); // call insert function 
                else
                    this.UpdateWarkat();

                MessageBox.Show("Save Has been sucessfully !");
                this.loadData(); // load data after insert
                this.Close(); // close form
            }
        }



        private bool Validation()
        {
            Validation validate = new Validation();
            //required
            bool transactionNo = validate.isRequired(txtTransactionCode.Text, "* Transaction Code : Required Do Not Empty");
            bool WarkatNo = validate.isRequired(txtWarkatNo.Text, "* Warkat No : Required Do Not Empty");
            bool DueDate = validate.isRequired(txtDueDate.Text, "* Due Date : Required Do Not Empty");
            bool BankCode = validate.isRequired(txtBankCode.Text, "* Bank Code : Required Do Not Empty");
            bool AccountNo = validate.isRequired(txtAccountNo.Text, "* Account No : Required Do Not Empty");
            bool Nominal = validate.isRequired(txtNominal.Text, "* Nominal : Required Do Not Empty");
            if (transactionNo && WarkatNo && DueDate && BankCode && AccountNo && Nominal)
            {
                Warkat model = new Warkat();
                if (model.FindByCode(txtTransactionCode.Text) == true && isEdit == false)
                {
                    MessageBox.Show("Transaction Code Has been Available Please Put Other Code !");
                    return false;
                }
                return true;
            }

            else
            {
                return false;
            }
        }

        private void InsertWarkat()
        {
            Warkat model = new Warkat();
            Warkat.TransactionCode = txtTransactionCode.Text;
            Warkat.WarkatNo = txtWarkatNo.Text;
            Warkat.DueDate = txtDueDate.Text;
            Warkat.Nominal = double.Parse(txtNominal.Text);
            model.Insert();
        }

        private void UpdateWarkat()
        {
            Warkat model = new Warkat();
            Warkat.TransactionCode = txtTransactionCode.Text;
            Warkat.WarkatNo = txtWarkatNo.Text;
            Warkat.DueDate = txtDueDate.Text;
            Warkat.Nominal = Double.Parse(txtNominal.Text);
            model.Update();
        }

        private void txtNominal_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }
    }
}
