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
    public partial class frmAddOwner : Form
    {
        public frmAddOwner()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            // Open Manage Owner Form
            frmManageOwner manageOwner = new frmManageOwner();
            manageOwner.Show();
            // hide owner add form
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear all input text in text box
            tbfname.Text = "";
            tblname.Text = "";
            tbaddress.Text = "";
            tbpnumber.Text = "";
            tbemail.Text = "";
        }
    }
}
