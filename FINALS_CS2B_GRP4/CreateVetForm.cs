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
    public partial class frmCreateVet : Form
    {
        private frmManageVet vet;
        public frmCreateVet(frmManageVet v)
        {
            InitializeComponent();
            this.vet = v;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Getting the data from the textboxes
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string specialization = txtSpecialization.Text;
            string phoneNum = txtPhoneNum.Text;
            string email = txtEmail.Text;

            Veterinarian veterinarian = new Veterinarian()
            {
                FirstName = fName,
                LastName = lName,
                Specialization = specialization,
                PhoneNumber = phoneNum,
                Email = email,
            };

            DatabaseHelper.CreateVeterinarian(veterinarian);
            MessageBox.Show("Successfully Created.");
            vet.refreshDatagrid();
            this.Close();           
        }
    }
}
