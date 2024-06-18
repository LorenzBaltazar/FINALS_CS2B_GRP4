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
    public partial class frmSelectOwner : Form, IRefreshable
    {
        public Owner selectedOwner;

        public frmSelectOwner()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            CancelButton = btnCancel;
        }

        private void frmSelectOwner_Load(object sender, EventArgs e)
        {
            refreshDatagrid();
        }

        public void refreshDatagrid()
        {
            // Retrieve all owners from the database
            DataTable dtOwner = DatabaseHelper.SelectAllOwners();

            // Bind the owners to the data grid view
            dgOwnerList.DataSource = dtOwner;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgOwnerList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgOwnerList.SelectedRows[0];

                // Retrieve the selected owner's information from the data grid view
                int ownerID = Convert.ToInt32(row.Cells["owner_id"].Value);
                string fName = row.Cells["first_name"].Value.ToString();
                string lName = row.Cells["last_name"].Value.ToString();
                string address = row.Cells["address"].Value.ToString();
                string phoneNum = row.Cells["phone_number"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();

                // Create an Owner object with the retrieved information
                Owner owner = new Owner { Address = address, Email = email, FirstName = fName, LastName = lName, OwnerId = ownerID, PhoneNumber = phoneNum };

                // Set the selected owner
                selectedOwner = owner;

                // Set the dialog result to OK and close the form
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("There was no selected owners to view.");
            }
        }
    }
}
