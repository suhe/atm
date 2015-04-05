using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Forms;

namespace ATM.Forms.UserForm
{
    public partial class frmSearch : Form
    {
        public delegate void DoEvent();
        public event DoEvent loadData;

        public frmSearch()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area. 
            this.ControlBox = false;

            this.txtFirstName.Text = frmUser.firstName;
            this.txtLastName.Text = frmUser.lastName;
            this.txtUserName.Text = frmUser.userName;
            this.txtCity.Text = frmUser.city;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmUser.firstName = this.txtFirstName.Text;
            frmUser.lastName = this.txtLastName.Text;
            frmUser.userName = this.txtUserName.Text;
            frmUser.city = this.txtCity.Text;
            this.loadData();
            this.Close();
        }
    }
}
