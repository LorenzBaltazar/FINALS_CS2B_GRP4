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
        private frmManageVet del;
        private int vetID;
        public frmVetView(frmManageVet del, int vetID, string fName, string lName, string specialization, string phoneNum)
        {
            InitializeComponent();
            this.del = del;

            // Fills up the corresponding data to the textboxes
            this.vetID = vetID;
            txtVetID.Text = vetID.ToString();
            txtFName.Text = fName;
            txtLName.Text = lName;
            txtSpecialization.Text = specialization;
            txtPhoneNum.Text = phoneNum;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DatabaseHelper.DeleteVeterinarian(vetID);
                MessageBox.Show("Successfully Deleted.");
                del.refreshDatagrid();
                this.Close();
            }
        }

    }
}
