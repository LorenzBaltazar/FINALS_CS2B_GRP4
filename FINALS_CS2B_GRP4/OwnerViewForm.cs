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
    public partial class frmOwnerView : Form
    {
        public frmOwnerView()
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
    }
}
