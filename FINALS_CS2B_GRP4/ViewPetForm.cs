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
    public partial class frmPetView : Form
    {
        private Form parentForm;
        private int petId;
        private int? ownerId;
        public frmPetView(Form parentForm, int petId, string petName, string species, string breed, DateTime? birthDate, int? ownerId, string ownerName)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            this.petId = petId;
            this.ownerId = ownerId;

            txtPetName.Text = petName;
            txtSpecies.Text = species;
            txtBreed.Text = breed;
            dtpBirthDate.Value = birthDate ?? DateTime.Now;
            txtOwner.Text = ownerName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet {
                PetId = petId,
                BirthDate = dtpBirthDate.Value.Date,
                Breed = txtBreed.Text,
                Name = txtPetName.Text,
                OwnerId = ownerId,
                Species = txtSpecies.Text
            };

            DatabaseHelper.UpdatePet(pet);
            MessageBox.Show("Successfully Updated.");
            if (parentForm is IRefreshable)
                ((IRefreshable) parentForm).refreshDatagrid();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? (This will delete related appointments)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DatabaseHelper.DeleteAppointmentsByPet(petId);
                DatabaseHelper.DeletePet(petId);
                MessageBox.Show("Successfully Deleted.");
                if (parentForm is IRefreshable)
                    ((IRefreshable) parentForm).refreshDatagrid();
                this.Close();
            }
        }

        private void btnClearOwner_Click(object sender, EventArgs e)
        {
            ownerId = null;
            txtOwner.Text = "";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectOwner selectOwner = new frmSelectOwner();
            if (selectOwner.ShowDialog() == DialogResult.OK)
            {
                Owner selectedOwner = selectOwner.selectedOwner;
                txtOwner.Text = selectedOwner.LastName + ", " + selectedOwner.FirstName ;
                ownerId = selectedOwner.OwnerId;
            }
            selectOwner.Dispose();
        }
    }
}
