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
    public partial class frmManagePet : Form, IRefreshable
    {
        public frmManagePet()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        // Load event handler for the form
        private void frmManagePet_Load(object sender, EventArgs e)
        {
            refreshDatagrid();
        }

        // Refresh the datagrid with pet information
        public void refreshDatagrid()
        {
            // Retrieve all pets from the database
            DataTable dtPet = DatabaseHelper.SelectAllPets();
            dtPet.Columns.Add("owner_name", typeof(String));

            foreach (DataRow row in dtPet.Rows)
            {
                if (row["owner_id"].Equals(DBNull.Value))
                {
                    row["owner_name"] = "No Owner";
                    continue;
                }
                int ownerId = Convert.ToInt32(row["owner_id"]);
                Owner owner = DatabaseHelper.ReadOwner(ownerId);

                if (owner == null)
                    row["owner_name"] = "No Owner";
                else
                    row["owner_name"] = owner.LastName + ", " + owner.FirstName;
            }

            // Bind the pet data to the datagrid
            dgPetList.DataSource = dtPet;
        }

        // Click event handler for the "Create Pet" button
        private void btnCreatePet_Click(object sender, EventArgs e)
        {
            // Open the create pet form
            CreatePetForm createPet = new CreatePetForm(this);
            createPet.Show();
        }

        // Click event handler for the "View" button
        private void btnView_Click(object sender, EventArgs e)
        {
            // Check if any pet is selected
            if (dgPetList.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow row = dgPetList.SelectedRows[0];

                // Extract the necessary information from the selected row
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
                if (row.Cells["owner_id"].Value.Equals(DBNull.Value))
                    ownerId = null;
                else
                    ownerId = Convert.ToInt32(row.Cells["owner_id"].Value);

                string ownerName = row.Cells["owner_name"].Value.ToString();

                // Open the pet view form with the selected pet's information
                new frmPetView(this, petId, name, species, breed, birthDate, ownerId, ownerName).Show();
            }
            else
            {
                // Display a message if no pet is selected
                MessageBox.Show("There was no selected pets to view.");
            }
        }
    }
}
