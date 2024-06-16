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
    public partial class frmSelectVet : Form, IRefreshable
    {
        public Veterinarian selectedVet;
        public frmSelectVet()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            CancelButton = btnCancel;
        }

        private void frmSelectVet_Load(object sender, EventArgs e)
        {
            refreshDatagrid();
        }
        public void refreshDatagrid()
        {
            DataTable dtVet = DatabaseHelper.SelectAllVeterinarians();
            dgVetList.DataSource = dtVet;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgVetList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgVetList.SelectedRows[0];
                int vetID = Convert.ToInt32(row.Cells["vet_id"].Value);

                selectedVet = DatabaseHelper.ReadVeterinarian(vetID);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
