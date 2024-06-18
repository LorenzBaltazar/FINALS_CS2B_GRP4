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
    public partial class frmViewAppointment : Form
    {
        // Declare variables
        IRefreshable refreshable;
        int appointmentId;
        int? ownerId;
        int? petId;
        int? vetId;

        // Constructor
        public frmViewAppointment(IRefreshable refreshable, Appointment appointment, string owner_name, string pet_name, string vet_name)
        {
            this.refreshable = refreshable;
            InitializeComponent();

            // Initialize variables
            appointmentId = appointment.AppointmentId;
            ownerId = appointment.OwnerId;
            petId = appointment.PetId;
            vetId = appointment.VetId;

            // Set initial values for text boxes and date/time pickers
            txtAppoinmentID.Text = appointment.AppointmentId.ToString();
            txtOwner.Text = owner_name;
            txtPet.Text = pet_name;
            txtVet.Text = vet_name;
            txtReason.Text = appointment.Reason;
            txtStatus.Text = appointment.Status;
            dtpDate.Value = appointment.AppointmentDate ?? DateTime.Now;
            if (appointment.AppointmentTime is null)
                dtpTime.Value = DateTime.Now;
            else
                dtpTime.Value = DateTime.Now.Date + (TimeSpan)appointment.AppointmentTime;
        }

        // Event handler for selecting owner
        private void btnSelectOwner_Click(object sender, EventArgs e)
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

        // Event handler for selecting pet
        private void btnSelectPet_Click(object sender, EventArgs e)
        {
            frmSelectPet selectPet = new frmSelectPet();
            if (selectPet.ShowDialog() == DialogResult.OK)
            {
                Pet selectedPet = selectPet.selectedPet;
                txtPet.Text = selectedPet.Name;
                petId = selectedPet.PetId;
            }
            selectPet.Dispose();
        }

        // Event handler for selecting veterinarian
        private void btnSelectVet_Click(object sender, EventArgs e)
        {
            frmSelectVet selectVet = new frmSelectVet();
            if (selectVet.ShowDialog() == DialogResult.OK)
            {
                Veterinarian selectedVet = selectVet.selectedVet;
                txtVet.Text = selectedVet.LastName + ", " + selectedVet.FirstName;
                vetId = selectedVet.VetId;
            }
            selectVet.Dispose();
        }

        // Event handler for clearing owner
        private void btnClearOwner_Click(object sender, EventArgs e)
        {
            txtOwner.Text = "";
            ownerId = null;
        }

        // Event handler for clearing pet
        private void btnClearPet_Click(object sender, EventArgs e)
        {
            txtPet.Text = "";
            petId = null;
        }

        // Event handler for clearing veterinarian
        private void btnClearVet_Click(object sender, EventArgs e)
        {
            txtVet.Text = "";
            vetId = null;
        }

        // Event handler for deleting appointment
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Delete appointment from database
                DatabaseHelper.DeleteAppointment(appointmentId);
                MessageBox.Show("Successfully Deleted.");

                // Refresh data grid if refreshable interface is implemented
                if (!(refreshable is null))
                    refreshable.refreshDatagrid();

                // Close the form
                this.Close();
            }
        }

        // Event handler for updating appointment
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Create new appointment object with updated values
            Appointment appointment = new Appointment
            {
                AppointmentId = appointmentId,
                AppointmentDate = dtpDate.Value.Date,
                AppointmentTime = dtpTime.Value - dtpTime.Value.Date, // Get time by subtracting its original value by date
                Reason = txtReason.Text,
                OwnerId = ownerId,
                PetId = petId,
                VetId = vetId,
                Status = txtStatus.Text
            };

            // Update appointment in database
            DatabaseHelper.UpdateAppointment(appointment);
            MessageBox.Show("Successfully Updated.");

            // Refresh data grid if refreshable interface is implemented
            if (!(refreshable is null))
                refreshable.refreshDatagrid();

            // Close the form
            this.Close();
        }
    }
}
