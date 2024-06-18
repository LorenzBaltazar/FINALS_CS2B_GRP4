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
    public partial class frmManageOwner : Form, IRefreshable
    {
        public frmManageOwner()
        {
            InitializeComponent();
        }

        // Refreshes the datagrid with the latest owner data
        public void refreshDatagrid()
        {
            // Select all owners from the database
            DataTable dtOwner = DatabaseHelper.SelectAllOwners();

            // Set the data source of the datagrid to the retrieved owner data
            dgOwnerList.DataSource = dtOwner;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Open the create owner form
            frmCreateOwner createOwner = new frmCreateOwner(this);
            createOwner.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgOwnerList.SelectedRows.Count > 0)
            {
                // Get the selected row from the datagrid
                DataGridViewRow row = dgOwnerList.SelectedRows[0];

                // Extract the owner details from the selected row
                int ownerID = Convert.ToInt32(row.Cells["owner_id"].Value);
                string fName = row.Cells["first_name"].Value.ToString();
                string lName = row.Cells["last_name"].Value.ToString();
                string address = row.Cells["address"].Value.ToString();
                string phoneNum = row.Cells["phone_number"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();

                // Open the owner view form with the extracted owner details
                frmOwnerView ownerView = new frmOwnerView(this, ownerID, fName, lName, address, phoneNum, email);
                ownerView.Show();
            }
            else
            {
                MessageBox.Show("There was no selected owners to view.");
            }
        }

        private void frmManageOwner_Load(object sender, EventArgs e)
        {
            // Refresh the datagrid with the latest owner data
            refreshDatagrid();
        }
    }
}
