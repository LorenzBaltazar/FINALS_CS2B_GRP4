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
    public partial class CreateAppointmentForm : Form
    {
        IRefreshable refreshable;
        int? ownerId;
        int? petId;
        int? vetId;

        public CreateAppointmentForm(IRefreshable refreshable)
        {
            this.refreshable = refreshable;
            InitializeComponent();
        }

        private void btnSelectOwner_Click(object sender, EventArgs e)
        {
            // Open the select owner form
            frmSelectOwner selectOwner = new frmSelectOwner();
            if (selectOwner.ShowDialog() == DialogResult.OK)
            {
                Owner selectedOwner = selectOwner.selectedOwner;
                txtOwner.Text = selectedOwner.LastName + ", " + selectedOwner.FirstName;
                ownerId = selectedOwner.OwnerId;
            }
            selectOwner.Dispose();
        }

        private void btnSelectPet_Click(object sender, EventArgs e)
        {
            // Open the select pet form
            frmSelectPet selectPet = new frmSelectPet();
            if (selectPet.ShowDialog() == DialogResult.OK)
            {
                Pet selectedPet = selectPet.selectedPet;
                txtPet.Text = selectedPet.Name;
                petId = selectedPet.PetId;
            }
            selectPet.Dispose();
        }

        private void btnSelectVet_Click(object sender, EventArgs e)
        {
            // Open the select veterinarian form
            frmSelectVet selectVet = new frmSelectVet();
            if (selectVet.ShowDialog() == DialogResult.OK)
            {
                Veterinarian selectedVet = selectVet.selectedVet;
                txtVet.Text = selectedVet.LastName + ", " + selectedVet.FirstName;
                vetId = selectedVet.VetId;
            }
            selectVet.Dispose();

        }

        private void btnClearOwner_Click(object sender, EventArgs e)
        {
            // Clear the owner text box and reset the owner ID
            txtOwner.Text = "";
            ownerId = null;
        }

        private void btnClearPet_Click(object sender, EventArgs e)
        {
            // Clear the pet text box and reset the pet ID
            txtPet.Text = "";
            petId = null;

        }

        private void btnClearVet_Click(object sender, EventArgs e)
        {
            // Clear the veterinarian text box and reset the veterinarian ID
            txtVet.Text = "";
            vetId = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all input fields and reset all IDs
            txtReason.Text = "";
            txtOwner.Text = "";
            ownerId = null;
            txtPet.Text = "";
            petId = null;
            txtVet.Text = "";
            vetId = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Create a new appointment object with the selected values
            Appointment appointment = new Appointment
            {
                AppointmentDate = dtpDate.Value.Date,
                AppointmentTime = dtpTime.Value - dtpTime.Value.Date, // Get time by subtracting its original value by date
                Reason = txtReason.Text,
                OwnerId = ownerId,
                PetId = petId,
                VetId = vetId,
                Status = "Scheduled"
            };

            // Call the CreateAppointment method in the DatabaseHelper class
            DatabaseHelper.CreateAppointment(appointment);

            // Show a success message
            MessageBox.Show("Successfully Created.");

            // Refresh the data grid if the refreshable object is not null
            if (!(refreshable is null))
                refreshable.refreshDatagrid();

            // Close the form
            this.Close();
        }
    }
}
