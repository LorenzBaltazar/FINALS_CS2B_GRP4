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
    public partial class frmSelectPet : Form, IRefreshable
    {
        public Pet selectedPet;
        public frmSelectPet()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            CancelButton = btnCancel;
        }

        private void frmSelectPet_Load(object sender, EventArgs e)
        {
            refreshDatagrid();
        }
        public void refreshDatagrid()
        {
            DataTable dtPet = DatabaseHelper.SelectAllPets();

            dtPet.Columns.Add("owner_name");

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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgPetList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPetList.SelectedRows[0];
                int petID = Convert.ToInt32(row.Cells["pet_id"].Value);

                selectedPet = DatabaseHelper.ReadPet(petID);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("There was no selected pets to view.");
            }
        }
    }
}
