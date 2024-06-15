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

        private void btnView_Click(object sender, EventArgs e)
        {

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

        private void dgVetList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgVetList.Rows[e.RowIndex];
                int vetID = Convert.ToInt32(row.Cells["vet_id"].Value);
                string fName = row.Cells["first_name"].Value.ToString();
                string lName = row.Cells["last_name"].Value.ToString();
                string specialization = row.Cells["specialization"].Value.ToString();
                string phoneNum = row.Cells["phone_number"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();

                new frmVetView(this, vetID, fName, lName, specialization, phoneNum).Show(); 
            }
        }
        public void refreshDatagrid()
        {
            DataTable dtVet = DatabaseHelper.SelectAllVeterinarians();
            dgVetList.DataSource = dtVet;
        }
    }
}