namespace FINALS_CS2B_GRP4
{
    partial class frmPetView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClearOwner = new System.Windows.Forms.Button();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblPetName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.txtPetID = new System.Windows.Forms.TextBox();
            this.lblPetID = new System.Windows.Forms.Label();
            this.btnViewAppointment = new System.Windows.Forms.Button();
            this.dgAppointmentList = new System.Windows.Forms.DataGridView();
            this.lblAppointment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearOwner
            // 
            this.btnClearOwner.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClearOwner.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOwner.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClearOwner.Location = new System.Drawing.Point(169, 136);
            this.btnClearOwner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearOwner.Name = "btnClearOwner";
            this.btnClearOwner.Size = new System.Drawing.Size(29, 25);
            this.btnClearOwner.TabIndex = 62;
            this.btnClearOwner.Text = "X";
            this.btnClearOwner.UseVisualStyleBackColor = false;
            this.btnClearOwner.Click += new System.EventHandler(this.btnClearOwner_Click);
            // 
            // txtOwner
            // 
            this.txtOwner.Enabled = false;
            this.txtOwner.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwner.Location = new System.Drawing.Point(202, 138);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(241, 22);
            this.txtOwner.TabIndex = 61;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSelect.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelect.Location = new System.Drawing.Point(112, 136);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(53, 25);
            this.btnSelect.TabIndex = 60;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(112, 113);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 59;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(390, 171);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 25);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBreed
            // 
            this.txtBreed.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreed.Location = new System.Drawing.Point(112, 86);
            this.txtBreed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(331, 22);
            this.txtBreed.TabIndex = 50;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecies.Location = new System.Drawing.Point(112, 62);
            this.txtSpecies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(331, 22);
            this.txtSpecies.TabIndex = 49;
            // 
            // txtPetName
            // 
            this.txtPetName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetName.Location = new System.Drawing.Point(112, 38);
            this.txtPetName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(331, 22);
            this.txtPetName.TabIndex = 48;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(21, 142);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(45, 14);
            this.lblOwner.TabIndex = 55;
            this.lblOwner.Text = "Owner:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(21, 114);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(65, 14);
            this.lblBirthDate.TabIndex = 54;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreed.Location = new System.Drawing.Point(21, 90);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(42, 14);
            this.lblBreed.TabIndex = 53;
            this.lblBreed.Text = "Breed:";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(21, 65);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(52, 14);
            this.lblSpecies.TabIndex = 52;
            this.lblSpecies.Text = "Species:";
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.Location = new System.Drawing.Point(21, 41);
            this.lblPetName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(62, 14);
            this.lblPetName.TabIndex = 51;
            this.lblPetName.Text = "Pet Name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Location = new System.Drawing.Point(312, 171);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 25);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImage = global::FINALS_CS2B_GRP4.Properties.Resources.logo;
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblogo.Location = new System.Drawing.Point(24, 163);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(58, 33);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 57;
            this.pblogo.TabStop = false;
            // 
            // txtPetID
            // 
            this.txtPetID.Enabled = false;
            this.txtPetID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetID.Location = new System.Drawing.Point(112, 12);
            this.txtPetID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(331, 22);
            this.txtPetID.TabIndex = 63;
            // 
            // lblPetID
            // 
            this.lblPetID.AutoSize = true;
            this.lblPetID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetID.Location = new System.Drawing.Point(21, 15);
            this.lblPetID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPetID.Name = "lblPetID";
            this.lblPetID.Size = new System.Drawing.Size(42, 14);
            this.lblPetID.TabIndex = 64;
            this.lblPetID.Text = "Pet ID:";
            // 
            // btnViewAppointment
            // 
            this.btnViewAppointment.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewAppointment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAppointment.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnViewAppointment.Location = new System.Drawing.Point(305, 239);
            this.btnViewAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAppointment.Name = "btnViewAppointment";
            this.btnViewAppointment.Size = new System.Drawing.Size(141, 28);
            this.btnViewAppointment.TabIndex = 66;
            this.btnViewAppointment.Text = "View Appointment";
            this.btnViewAppointment.UseVisualStyleBackColor = false;
            this.btnViewAppointment.Click += new System.EventHandler(this.btnViewAppointment_Click);
            // 
            // dgAppointmentList
            // 
            this.dgAppointmentList.AllowUserToAddRows = false;
            this.dgAppointmentList.AllowUserToDeleteRows = false;
            this.dgAppointmentList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppointmentList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgAppointmentList.Location = new System.Drawing.Point(11, 271);
            this.dgAppointmentList.Margin = new System.Windows.Forms.Padding(2);
            this.dgAppointmentList.Name = "dgAppointmentList";
            this.dgAppointmentList.ReadOnly = true;
            this.dgAppointmentList.RowHeadersWidth = 51;
            this.dgAppointmentList.RowTemplate.Height = 24;
            this.dgAppointmentList.Size = new System.Drawing.Size(445, 198);
            this.dgAppointmentList.TabIndex = 65;
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.Location = new System.Drawing.Point(18, 248);
            this.lblAppointment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(87, 14);
            this.lblAppointment.TabIndex = 67;
            this.lblAppointment.Text = "Appointments:";
            // 
            // frmPetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 480);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.btnViewAppointment);
            this.Controls.Add(this.dgAppointmentList);
            this.Controls.Add(this.txtPetID);
            this.Controls.Add(this.lblPetID);
            this.Controls.Add(this.btnClearOwner);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.lblPetName);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmPetView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Pet";
            this.Load += new System.EventHandler(this.frmPetView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearOwner;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPetID;
        private System.Windows.Forms.Label lblPetID;
        private System.Windows.Forms.Button btnViewAppointment;
        private System.Windows.Forms.DataGridView dgAppointmentList;
        private System.Windows.Forms.Label lblAppointment;
    }
}