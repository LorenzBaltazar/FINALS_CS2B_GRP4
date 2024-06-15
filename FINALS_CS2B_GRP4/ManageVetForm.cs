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
    public partial class frmManageVet : Form
    {
        public frmManageVet()
        {
            InitializeComponent();
        }

        private void btnCreateVet_Click(object sender, EventArgs e)
        {
            frmCreateVet createVet = new frmCreateVet(this);
            createVet.Show();
        }

        private void frmManageVet_Load(object sender, EventArgs e)
        {
            DataTable dtVet = DatabaseHelper.SelectAllVeterinarians();
            dgVetList.DataSource = dtVet;
        }

        public void refreshDatagrid()
        {
            DataTable dtVet = DatabaseHelper.SelectAllVeterinarians();
            dgVetList.DataSource = dtVet;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgVetList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgVetList.SelectedRows[0];
                int vetID = Convert.ToInt32(row.Cells["vet_id"].Value);
                string fName = row.Cells["first_name"].Value.ToString();
                string lName = row.Cells["last_name"].Value.ToString();
                string specialization = row.Cells["specialization"].Value.ToString();
                string phoneNum = row.Cells["phone_number"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();

                new frmVetView(this, vetID, fName, lName, specialization, phoneNum, email).Show();
            }
            else
            {
                MessageBox.Show("There was no selected veterinarian to view.");
            }
        }

    }
}