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
    public partial class frmManageOwner : Form
    {
        public frmManageOwner()
        {
            InitializeComponent();
        }

        public void refreshDatagrid()
        {
            DataTable dtVet = DatabaseHelper.SelectAllOwners();
            dgOwnerList.DataSource = dtVet;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateOwner addOwner = new frmCreateOwner();
            if (addOwner.ShowDialog() == DialogResult.OK)
                this.refreshDatagrid();
            addOwner.Dispose();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgOwnerList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgOwnerList.SelectedRows[0];
                int ownerID = Convert.ToInt32(row.Cells["owner_id"].Value);
                string fName = row.Cells["first_name"].Value.ToString();
                string lName = row.Cells["last_name"].Value.ToString();
                string address = row.Cells["address"].Value.ToString();
                string phoneNum = row.Cells["phone_number"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();

                frmOwnerView ownerView = new frmOwnerView(this, ownerID, fName, lName, address, phoneNum, email);
                ownerView.Show();
            }
        }

        private void frmManageOwner_Load(object sender, EventArgs e)
        {
            refreshDatagrid();
        }
    }
}
