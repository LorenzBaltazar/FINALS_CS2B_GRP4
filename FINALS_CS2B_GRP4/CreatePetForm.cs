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
        public CreatePetForm()
        {
            DialogResult = DialogResult.Cancel;
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectOwner selectOwner = new frmSelectOwner();
            if (selectOwner.ShowDialog() == DialogResult.OK)
            {
                Owner selectedOwner = selectOwner.selectedOwner;
                txtOwner.Text = selectedOwner.OwnerId.ToString() + " : " + selectedOwner.LastName + ", " + selectedOwner.FirstName ;
                ownerId = selectedOwner.OwnerId;
            }
            selectOwner.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ownerId = null;
            txtOwner.Text = "";
            txtBreed.Text = "";
            txtPetName.Text = "";
            txtSpecies.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Pet pet = new Pet { 
                BirthDate = dtpBirthDate.Value.Date,
                Breed = txtBreed.Text,
                Name = txtPetName.Text,
                OwnerId = ownerId,
                Species = txtSpecies.Text 
            };

            DatabaseHelper.CreatePet(pet);
            MessageBox.Show("Successfully Created.");
            this.Close();           
        }

        private void btnClearOwner_Click(object sender, EventArgs e)
        {
            txtOwner.Text = "";
            ownerId = null;

        }
    }
}
