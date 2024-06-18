using System;
using System.CodeDom;
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
        IRefreshable refreshable;

        // Constructor
        public frmCreateVet(IRefreshable refreshable = null)
        {
            this.refreshable = refreshable;
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

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

            // Create veterinarian in the database
            DatabaseHelper.CreateVeterinarian(veterinarian);
            MessageBox.Show("Successfully Created.");

            // Refresh the datagrid if refreshable is not null
            if (!(refreshable is null))
                refreshable.refreshDatagrid();

            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            txtFName.Text = "";
            txtLName.Text = "";
            txtSpecialization.Text = "";
            txtPhoneNum.Text = "";
            txtEmail.Text = "";
        }
    }
}
