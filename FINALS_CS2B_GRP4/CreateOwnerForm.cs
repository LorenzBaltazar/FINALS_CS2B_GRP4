using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALS_CS2B_GRP4
{
    public partial class frmCreateOwner : Form
    {
        IRefreshable refreshable;
        public frmCreateOwner(IRefreshable refreshable = null)
        {
            this.refreshable = refreshable;
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all input text in text box
            txtFName.Text = "";
            txtLName.Text = "";
            txtAddress.Text = "";
            txtPhoneNum.Text = "";
            txtEmail.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string address = txtAddress.Text;
            string phoneNum = txtPhoneNum.Text;
            string email = txtEmail.Text;

            Owner owner = new Owner()
            {
                FirstName = fName,
                LastName = lName,
                Address = address,
                PhoneNumber = phoneNum,
                Email = email,
            };

            DatabaseHelper.CreateOwner(owner);
            MessageBox.Show("Successfully Created.");
            if (!(refreshable is null))
                refreshable.refreshDatagrid();
            this.Close();           
        }
    }
}
