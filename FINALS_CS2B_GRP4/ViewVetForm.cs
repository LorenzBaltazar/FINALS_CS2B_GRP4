using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALS_CS2B_GRP4
{
    public partial class frmVetView : Form
    {
        private Form parentForm;
        private int vetID;

        // Constructor
        public frmVetView(Form parentForm, int vetID, string fName, string lName, string specialization, string phoneNum, string email)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            // Fills up the corresponding data to the textboxes
            this.vetID = vetID;
            txtVetID.Text = vetID.ToString();
            txtFName.Text = fName;
            txtLName.Text = lName;
            txtSpecialization.Text = specialization;
            txtPhoneNum.Text = phoneNum;
            txtEmail.Text = email;
            Veterinarian vet = new Veterinarian()
            {
                VetId = vetID,
                FirstName = fName,
                LastName = lName,
                Specialization = specialization,
                PhoneNumber = phoneNum,
                Email = email
            };
        }

        // Event handler for the Update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editFName = txtFName.Text;
            string editLName = txtLName.Text;
            string editSpecialization = txtSpecialization.Text;
            string editPhoneNum = txtPhoneNum.Text;
            string editEmail = txtEmail.Text;

            Veterinarian editVet = new Veterinarian()
            {
                VetId = vetID,
                FirstName = editFName,
                LastName = editLName,
                Specialization = editSpecialization,
                PhoneNumber = editPhoneNum,
                Email = editEmail
            };
            DatabaseHelper.UpdateVeterinarian(editVet);
            MessageBox.Show("Successfully Updated.");

            // Refresh the parent form's datagrid if it implements the IRefreshable interface
            if (parentForm is IRefreshable)
                ((IRefreshable)parentForm).refreshDatagrid();

            this.Close();
        }

        // Event handler for the Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? (This will delete related appointments)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DatabaseHelper.DeleteAppointmentsByVeterinarian(vetID);
                DatabaseHelper.DeleteVeterinarian(vetID);
                MessageBox.Show("Successfully Deleted.");

                // Refresh the parent form's datagrid if it implements the IRefreshable interface
                if (parentForm is IRefreshable)
                    ((IRefreshable)parentForm).refreshDatagrid();

                this.Close();
            }
        }

    }
}
