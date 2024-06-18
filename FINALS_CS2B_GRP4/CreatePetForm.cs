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
    public partial class CreatePetForm : Form
    {
        private int? ownerId = null;
        private IRefreshable refreshable;

        // Constructor
        public CreatePetForm(IRefreshable refreshable = null)
        {
            this.refreshable = refreshable;
            DialogResult = DialogResult.Cancel;
            InitializeComponent();
        }

        // Event handler for selecting owner
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectOwner selectOwner = new frmSelectOwner();
            if (selectOwner.ShowDialog() == DialogResult.OK)
            {
                Owner selectedOwner = selectOwner.selectedOwner;
                txtOwner.Text = selectedOwner.LastName + ", " + selectedOwner.FirstName;
                ownerId = selectedOwner.OwnerId;
            }
            selectOwner.Dispose();
        }

        // Event handler for clearing form fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ownerId = null;
            dtpBirthDate.Value = DateTime.Now.Date;
            txtOwner.Text = "";
            txtBreed.Text = "";
            txtPetName.Text = "";
            txtSpecies.Text = "";
        }

        // Event handler for creating a pet
        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Pet pet = new Pet
            {
                BirthDate = dtpBirthDate.Value.Date,
                Breed = txtBreed.Text,
                Name = txtPetName.Text,
                OwnerId = ownerId,
                Species = txtSpecies.Text
            };

            DatabaseHelper.CreatePet(pet);
            MessageBox.Show("Successfully Created.");
            if (!(refreshable is null))
                refreshable.refreshDatagrid();
            this.Close();
        }

        // Event handler for clearing owner field
        private void btnClearOwner_Click(object sender, EventArgs e)
        {
            txtOwner.Text = "";
            ownerId = null;
        }
    }
}
