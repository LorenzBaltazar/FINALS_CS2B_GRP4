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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        // Event handler for lblAppointment click
        private void lblAppointment_Click(object sender, EventArgs e)
        {
            frmManageAppointment manageAppointment = new frmManageAppointment();
            manageAppointment.Show();
        }

        // Event handler for lblOwners click
        private void lblOwners_Click(object sender, EventArgs e)
        {
            frmManageOwner manageOwner = new frmManageOwner();
            manageOwner.Show();
        }

        // Event handler for lblPets click
        private void lblPets_Click(object sender, EventArgs e)
        {
            frmManagePet managePet = new frmManagePet();
            managePet.Show();
        }

        // Event handler for lblVet click
        private void lblVet_Click(object sender, EventArgs e)
        {
            frmManageVet manageVet = new frmManageVet();
            manageVet.Show();
        }

        // Event handler for lblAppointment mouse enter
        private void lblAppointment_MouseEnter(object sender, EventArgs e)
        {
            lblAppointment.Font = new Font(lblAppointment.Font, FontStyle.Underline);
        }

        // Event handler for lblAppointment mouse leave
        private void lblAppointment_MouseLeave(object sender, EventArgs e)
        {
            lblAppointment.Font = new Font(lblAppointment.Font, FontStyle.Regular);
        }

        // Event handler for lblVet mouse enter
        private void lblVet_MouseEnter(object sender, EventArgs e)
        {
            lblVet.Font = new Font(lblVet.Font, FontStyle.Underline);
        }

        // Event handler for lblVet mouse leave
        private void lblVet_MouseLeave(object sender, EventArgs e)
        {
            lblVet.Font = new Font(lblVet.Font, FontStyle.Regular);
        }

        // Event handler for lblOwners mouse enter
        private void lblOwners_MouseEnter(object sender, EventArgs e)
        {
            lblOwners.Font = new Font(lblOwners.Font, FontStyle.Underline);
        }

        // Event handler for lblOwners mouse leave
        private void lblOwners_MouseLeave(object sender, EventArgs e)
        {
            lblOwners.Font = new Font(lblOwners.Font, FontStyle.Regular);
        }

        // Event handler for lblPets mouse enter
        private void lblPets_MouseEnter(object sender, EventArgs e)
        {
            lblPets.Font = new Font(lblPets.Font, FontStyle.Underline);
        }

        // Event handler for lblPets mouse leave
        private void lblPets_MouseLeave(object sender, EventArgs e)
        {
            lblPets.Font = new Font(lblPets.Font, FontStyle.Regular);
        }

        // Event handler for lblLogout mouse enter
        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogout.Font = new Font(lblLogout.Font, FontStyle.Underline);
        }

        // Event handler for lblLogout mouse leave
        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.Font = new Font(lblLogout.Font, FontStyle.Regular);
        }

        // Event handler for lblLogout click
        private void lblLogout_Click(object sender, EventArgs e)
        {
            // Shows a message box that confirms if the user wants to logout
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If user confirms, it will hide the dashboard form and goes back to login form
            if (result == DialogResult.Yes)
            {
                this.Hide();

                if (new frmLogin().ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
