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
        private frmManageVet vet;
        private int vetID;
        public frmVetView(frmManageVet vet, int vetID, string fName, string lName, string specialization, string phoneNum, string email)
        {
            InitializeComponent();
            this.vet = vet;

            // Fills up the corresponding data to the textboxes
            this.vetID = vetID;
            txtVetID.Text = vetID.ToString();
            txtFName.Text = fName;
            txtLName.Text = lName;
            txtSpecialization.Text = specialization;
            txtPhoneNum.Text = phoneNum;
            txtEmail.Text = email;
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
            MessageBox.Show("Successfully Edited.");
            vet.refreshDatagrid();
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DatabaseHelper.DeleteVeterinarian(vetID);
                MessageBox.Show("Successfully Deleted.");
                vet.refreshDatagrid();
                this.Close();
            }
        }

    }
}
