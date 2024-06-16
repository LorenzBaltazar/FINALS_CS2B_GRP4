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
    public partial class frmOwnerView : Form
    {
        private Form parentForm;
        private int ownerID;
        public frmOwnerView(Form parentForm, int ownerId, string fName, string lName, string address, string phoneNum, string email)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            txtOwnerID.Text = ownerID.ToString();
            ownerID = ownerId;
            txtAddress.Text = address;
            txtEmail.Text = email;
            txtFName.Text = fName;
            txtLName.Text = lName;
            txtPhoneNum.Text = phoneNum;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editAddress = txtAddress.Text;
            string editEmail = txtEmail.Text;
            string editFName = txtFName.Text;
            string editLName = txtLName.Text;
            string editPhoneNum = txtPhoneNum.Text;

            Owner editOwner = new Owner()
            {
                OwnerId = ownerID,
                Address = editAddress,
                Email = editEmail,
                FirstName = editFName,
                LastName = editLName,
                PhoneNumber = editPhoneNum
            };

            DatabaseHelper.UpdateOwner(editOwner);
            MessageBox.Show("Successfully Edited.");
            if (parentForm is IRefreshable)
                ((IRefreshable) parentForm).refreshDatagrid();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DatabaseHelper.DeleteOwner(ownerID);
                MessageBox.Show("Successfully Deleted.");
                if (parentForm is IRefreshable)
                    ((IRefreshable) parentForm).refreshDatagrid();
                this.Close();
            }
        }
    }
}
