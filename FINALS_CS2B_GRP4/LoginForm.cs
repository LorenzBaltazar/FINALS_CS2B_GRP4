using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINALS_CS2B_GRP4
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Watermark text for username and password textbox
            txtUser.Text = "Username";
            txtPass.Text = "Password";
            txtUser.ForeColor = Color.Gray;
            txtPass.ForeColor = Color.Gray;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            // Removes the watermark on the textbox if clicked
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            // Removes the watermark on the textbox if clicked
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            // Brings back the watermark if textbox is left empty
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            // Brings back the watermark if textbox is left empty
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Text = "Password";
                txtPass.PasswordChar = '\0';
                txtPass.ForeColor = Color.Gray;
            }
        }

        // Goes to the dashboard if the credentials are correct
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Username and Password = admin
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user.Equals("admin", StringComparison.OrdinalIgnoreCase) && pass.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Succesfully logged in.");
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
                // Clears the textboxes and put the watermark back
                txtUser.Text = "Username";
                txtPass.Text = "Password";
                txtPass.PasswordChar = '\0';
                txtUser.ForeColor = Color.Gray;
                txtPass.ForeColor = Color.Gray;
            }
        }
    }
}
