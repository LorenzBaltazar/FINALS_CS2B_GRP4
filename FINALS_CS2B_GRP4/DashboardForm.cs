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
    public partial class S : Form
    {
        public S()
        {
            InitializeComponent();
        }

        private void lblAppointment_Click(object sender, EventArgs e)
        {

        }

        private void lblOwners_Click(object sender, EventArgs e)
        {

        }

        private void lblPets_Click(object sender, EventArgs e)
        {

        }

        private void lblVet_Click(object sender, EventArgs e)
        {

        }

        private void lblAppointment_MouseEnter(object sender, EventArgs e)
        {
            lblAppointment.Font = new Font (lblAppointment.Font, FontStyle.Underline);
        }

        private void lblAppointment_MouseLeave(object sender, EventArgs e)
        {
            lblAppointment.Font = new Font(lblAppointment.Font, FontStyle.Regular);
        }

        private void lblVet_MouseEnter(object sender, EventArgs e)
        {
            lblVet.Font = new Font(lblVet.Font, FontStyle.Underline);
        }

        private void lblVet_MouseLeave(object sender, EventArgs e)
        {
            lblVet.Font = new Font(lblVet.Font, FontStyle.Regular);
        }

        private void lblOwners_MouseEnter(object sender, EventArgs e)
        {
            lblOwners.Font = new Font(lblOwners.Font, FontStyle.Underline);
        }

        private void lblOwners_MouseLeave(object sender, EventArgs e)
        {
            lblOwners.Font = new Font(lblOwners.Font, FontStyle.Regular);
        }

        private void lblPets_MouseEnter(object sender, EventArgs e)
        {
            lblPets.Font = new Font(lblPets.Font, FontStyle.Underline);
        }

        private void lblPets_MouseLeave(object sender, EventArgs e)
        {
            lblPets.Font = new Font(lblPets.Font, FontStyle.Regular);
        }

        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogout.Font = new Font(lblLogout.Font, FontStyle.Underline);
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.Font = new Font(lblLogout.Font, FontStyle.Regular);
        }
    }
}
