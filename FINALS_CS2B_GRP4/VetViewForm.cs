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
        public frmVetView(int vetID, string fName, string lName, string specialization, string phoneNum)
        {
            InitializeComponent();

            // Fills up the corresponding data to the textboxes
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

        }

    }
}
