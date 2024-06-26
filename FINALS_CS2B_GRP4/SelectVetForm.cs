﻿using System;
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

        // Event handler for form load
        private void frmSelectVet_Load(object sender, EventArgs e)
        {
            refreshDatagrid();
        }

        // Refreshes the datagrid with all veterinarians
        public void refreshDatagrid()
        {
            DataTable dtVet = DatabaseHelper.SelectAllVeterinarians();
            dgVetList.DataSource = dtVet;
        }

        // Event handler for select button click
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgVetList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgVetList.SelectedRows[0];
                int vetID = Convert.ToInt32(row.Cells["vet_id"].Value);

                // Read the selected veterinarian from the database
                selectedVet = DatabaseHelper.ReadVeterinarian(vetID);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("There was no selected veterinarians to view.");
            }
        }
    }
}
