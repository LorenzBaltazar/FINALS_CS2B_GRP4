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
    public partial class frmPetView : Form, IRefreshable
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

        private void frmPetView_Load(object sender, EventArgs e)
        {
            refreshDatagrid();
        }
        public void refreshDatagrid()
        {
            DataTable dtAppointments = DatabaseHelper.SelectAllAppointments();

            dtAppointments.Columns.Add("owner_name", typeof(String));
            dtAppointments.Columns.Add("pet_name", typeof(String));
            dtAppointments.Columns.Add("vet_name", typeof(String));

            foreach (DataRow row in dtAppointments.Rows)
            {
                if (row["owner_id"].Equals(DBNull.Value))
                {
                    row["owner_name"] = "No Owner";
                }
                else
                {
                    int ownerId = Convert.ToInt32(row["owner_id"]);
                    Owner owner = DatabaseHelper.ReadOwner(ownerId);

                    if (owner == null)
                        row["owner_name"] = "No Owner";
                    else
                        row["owner_name"] = owner.LastName + ", " + owner.FirstName;
                }

                if (row["pet_id"].Equals(DBNull.Value))
                {
                    row["pet_name"] = "No Pet";
                }
                else
                {
                    int petId = Convert.ToInt32(row["pet_id"]);
                    Pet pet = DatabaseHelper.ReadPet(petId);

                    if (pet == null)
                        row["pet_name"] = "No Pet";
                    else
                        row["pet_name"] = pet.Name;
                }

                if (row["vet_id"].Equals(DBNull.Value))
                {
                    row["vet_name"] = "No Vet";
                }
                else
                {
                    int vetId = Convert.ToInt32(row["vet_id"]);
                    Veterinarian vet = DatabaseHelper.ReadVeterinarian(vetId);

                    if (vet == null)
                        row["vet_name"] = "No Vet";
                    else
                        row["vet_name"] = vet.LastName + ", " + vet.FirstName;
                }
            }

            dgAppointmentList.DataSource = dtAppointments;
            dgAppointmentList.Columns["appointment_id"].Visible = false;
            dgAppointmentList.Columns["owner_id"].Visible = false;
            dgAppointmentList.Columns["pet_id"].Visible = false;
            dgAppointmentList.Columns["vet_id"].Visible = false;
            dgAppointmentList.Columns["owner_name"].Visible = false;
            dgAppointmentList.Columns["pet_name"].Visible = false;
        }

        private void btnViewAppointment_Click(object sender, EventArgs e)
        {
            if (dgAppointmentList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgAppointmentList.SelectedRows[0];
                int appointmentId = Convert.ToInt32(row.Cells["appointment_id"].Value);
                string owner_name = row.Cells["owner_name"].Value.ToString();
                string pet_name = row.Cells["pet_name"].Value.ToString();
                string vet_name = row.Cells["vet_name"].Value.ToString();

                Appointment appointment = DatabaseHelper.ReadAppointment(appointmentId);

                frmViewAppointment appointmentView = new frmViewAppointment(this, appointment, owner_name, pet_name, vet_name);
                appointmentView.Show();
            }
            else
            {
                MessageBox.Show("There was no selected appointments to view.");
            }
        }
    }
}
