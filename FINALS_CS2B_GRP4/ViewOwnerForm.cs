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
    public partial class frmOwnerView : Form, IRefreshable
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
                ((IRefreshable)parentForm).refreshDatagrid();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? (This will delete related pets and appointments)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DatabaseHelper.DeleteAppointmentsByOwner(ownerID);
                DatabaseHelper.DeletePetsByOwner(ownerID);
                DatabaseHelper.DeleteOwner(ownerID);
                MessageBox.Show("Successfully Deleted.");
                if (parentForm is IRefreshable)
                    ((IRefreshable)parentForm).refreshDatagrid();
                this.Close();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgPetList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPetList.SelectedRows[0];
                int petId = Convert.ToInt32(row.Cells["pet_id"].Value);
                string name = row.Cells["name"].Value.ToString();
                string species = row.Cells["species"].Value.ToString();
                string breed = row.Cells["breed"].Value.ToString();

                DateTime? birthDate;
                if (row.Cells["birth_date"].Value.Equals(DBNull.Value))
                    birthDate = null;
                else
                    birthDate = Convert.ToDateTime(row.Cells["birth_date"].Value);

                int? ownerId;
                string ownerName = ""; 
                if (row.Cells["owner_id"].Value.Equals(DBNull.Value))
                {
                    ownerId = null;
                }
                else
                {
                    ownerId = Convert.ToInt32(row.Cells["owner_id"].Value);
                    Owner owner = DatabaseHelper.ReadOwner((int)ownerId);
                    ownerName = owner.LastName + ", " + owner.FirstName;
                }

                new frmPetView(this, petId, name, species, breed, birthDate, ownerId, ownerName).Show();
            }
            else
            {
                MessageBox.Show("There was no selected pets to view.");
            }

        }

        private void frmOwnerView_Load(object sender, EventArgs e)
        {
            refreshDatagrid();
        }
        public void refreshDatagrid()
        {
            DataTable dtPet = DatabaseHelper.SelectPetsByOwner(ownerID);
            dgPetList.DataSource = dtPet;
            dgPetList.Columns["owner_id"].Visible = false;
        }
    }
}
