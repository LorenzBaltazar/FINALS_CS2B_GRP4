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
    public partial class frmManageAppointment : Form, IRefreshable
    {
        public frmManageAppointment()
        {
            InitializeComponent();
        }

        private void frmManageAppointment_Load(object sender, EventArgs e)
        {
            refreshDatagrid();
        }

        public void refreshDatagrid()
        {
            DataTable dtAppointments = DatabaseHelper.SelectAllAppointments();

            dtAppointments.Columns.Add("owner_name", typeof(String));
            dtAppointments.Columns.Add("pet_name", typeof(String));
            dtAppointments.Columns.Add("vet_name", typeof(String));

            foreach (DataRow row in dtAppointments.Rows)
            {
                if (row["owner_id"].Equals(DBNull.Value))
                {
                    row["owner_name"] = "No Owner";
                }
                else
                {
                    int ownerId = Convert.ToInt32(row["owner_id"]);
                    Owner owner = DatabaseHelper.ReadOwner(ownerId);

                    if (owner == null)
                        row["owner_name"] = "No Owner";
                    else
                        row["owner_name"] = owner.LastName + ", " + owner.FirstName;
                }

                if (row["pet_id"].Equals(DBNull.Value))
                {
                    row["pet_name"] = "No Pet";
                }
                else
                {
                    int petId = Convert.ToInt32(row["pet_id"]);
                    Pet pet = DatabaseHelper.ReadPet(petId);

                    if (pet == null)
                        row["pet_name"] = "No Pet";
                    else
                        row["pet_name"] = pet.Name;
                }

                if (row["vet_id"].Equals(DBNull.Value))
                {
                    row["vet_name"] = "No Vet";
                }
                else
                {
                    int vetId = Convert.ToInt32(row["vet_id"]);
                    Veterinarian vet = DatabaseHelper.ReadVeterinarian(vetId);

                    if (vet == null)
                        row["vet_name"] = "No Vet";
                    else
                        row["vet_name"] = vet.LastName + ", " + vet.FirstName;
                }
            }

            dgAppointmentList.DataSource = dtAppointments;
            dgAppointmentList.Columns["appointment_id"].Visible = false;
            dgAppointmentList.Columns["owner_id"].Visible = false;
            dgAppointmentList.Columns["pet_id"].Visible = false;
            dgAppointmentList.Columns["vet_id"].Visible = false;
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            CreateAppointmentForm createAppointment = new CreateAppointmentForm(this);
            createAppointment.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgAppointmentList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgAppointmentList.SelectedRows[0];
                int appointmentId = Convert.ToInt32(row.Cells["appointment_id"].Value);

                Appointment appointment = DatabaseHelper.ReadAppointment(appointmentId);

                frmViewAppointment appointmentView = new frmViewAppointment(this, appointment);
                appointmentView.Show();
            }

        }
    }
}
