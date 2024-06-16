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

        private void frmManagePet_Load(object sender, EventArgs e)
        {
            refreshDatagrid();
        }

        public void refreshDatagrid()
        {
            Console.WriteLine("REFRESHED");
            DataTable dtPet = DatabaseHelper.SelectAllPets();
            dtPet.Columns.Add("owner_name", typeof(String));

            foreach (DataRow row in dtPet.Rows) {
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

            dgPetList.DataSource = dtPet;
        }

        private void btnCreatePet_Click(object sender, EventArgs e)
        {
            CreatePetForm createPet = new CreatePetForm();
            if (createPet.ShowDialog() == DialogResult.OK)
                this.refreshDatagrid();
            createPet.Dispose();
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
                if (row.Cells["owner_id"].Value.Equals(DBNull.Value))
                    ownerId = null;
                else
                    ownerId = Convert.ToInt32(row.Cells["owner_id"].Value);

                string ownerName = row.Cells["owner_name"].Value.ToString();

                new frmPetView(this, petId, name, species, breed, birthDate, ownerId, ownerName).Show();
            }
            else
            {
                MessageBox.Show("There was no selected pets to view.");
            }
        }
    }
}
