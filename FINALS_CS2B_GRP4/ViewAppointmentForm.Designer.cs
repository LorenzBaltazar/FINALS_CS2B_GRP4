﻿namespace FINALS_CS2B_GRP4
{
    partial class frmViewAppointment
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
            this.btnClearVet = new System.Windows.Forms.Button();
            this.btnClearPet = new System.Windows.Forms.Button();
            this.btnClearOwner = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtVet = new System.Windows.Forms.TextBox();
            this.btnSelectVet = new System.Windows.Forms.Button();
            this.txtPet = new System.Windows.Forms.TextBox();
            this.btnSelectPet = new System.Windows.Forms.Button();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.btnSelectOwner = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblReason = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblVet = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.txtAppoinmentID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearVet
            // 
            this.btnClearVet.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClearVet.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearVet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClearVet.Location = new System.Drawing.Point(159, 144);
            this.btnClearVet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearVet.Name = "btnClearVet";
            this.btnClearVet.Size = new System.Drawing.Size(29, 25);
            this.btnClearVet.TabIndex = 68;
            this.btnClearVet.Text = "X";
            this.btnClearVet.UseVisualStyleBackColor = false;
            this.btnClearVet.Click += new System.EventHandler(this.btnClearVet_Click);
            // 
            // btnClearPet
            // 
            this.btnClearPet.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClearPet.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClearPet.Location = new System.Drawing.Point(159, 118);
            this.btnClearPet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearPet.Name = "btnClearPet";
            this.btnClearPet.Size = new System.Drawing.Size(29, 25);
            this.btnClearPet.TabIndex = 67;
            this.btnClearPet.Text = "X";
            this.btnClearPet.UseVisualStyleBackColor = false;
            this.btnClearPet.Click += new System.EventHandler(this.btnClearPet_Click);
            // 
            // btnClearOwner
            // 
            this.btnClearOwner.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClearOwner.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOwner.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClearOwner.Location = new System.Drawing.Point(159, 92);
            this.btnClearOwner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearOwner.Name = "btnClearOwner";
            this.btnClearOwner.Size = new System.Drawing.Size(29, 25);
            this.btnClearOwner.TabIndex = 66;
            this.btnClearOwner.Text = "X";
            this.btnClearOwner.UseVisualStyleBackColor = false;
            this.btnClearOwner.Click += new System.EventHandler(this.btnClearOwner_Click);
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(102, 172);
            this.txtReason.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(386, 228);
            this.txtReason.TabIndex = 65;
            // 
            // txtVet
            // 
            this.txtVet.Enabled = false;
            this.txtVet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVet.Location = new System.Drawing.Point(192, 146);
            this.txtVet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVet.Name = "txtVet";
            this.txtVet.Size = new System.Drawing.Size(296, 22);
            this.txtVet.TabIndex = 64;
            // 
            // btnSelectVet
            // 
            this.btnSelectVet.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSelectVet.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectVet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelectVet.Location = new System.Drawing.Point(102, 144);
            this.btnSelectVet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectVet.Name = "btnSelectVet";
            this.btnSelectVet.Size = new System.Drawing.Size(53, 25);
            this.btnSelectVet.TabIndex = 60;
            this.btnSelectVet.Text = "Select";
            this.btnSelectVet.UseVisualStyleBackColor = false;
            this.btnSelectVet.Click += new System.EventHandler(this.btnSelectVet_Click);
            // 
            // txtPet
            // 
            this.txtPet.Enabled = false;
            this.txtPet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPet.Location = new System.Drawing.Point(192, 120);
            this.txtPet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPet.Name = "txtPet";
            this.txtPet.Size = new System.Drawing.Size(296, 22);
            this.txtPet.TabIndex = 63;
            // 
            // btnSelectPet
            // 
            this.btnSelectPet.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSelectPet.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelectPet.Location = new System.Drawing.Point(102, 118);
            this.btnSelectPet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectPet.Name = "btnSelectPet";
            this.btnSelectPet.Size = new System.Drawing.Size(53, 25);
            this.btnSelectPet.TabIndex = 59;
            this.btnSelectPet.Text = "Select";
            this.btnSelectPet.UseVisualStyleBackColor = false;
            this.btnSelectPet.Click += new System.EventHandler(this.btnSelectPet_Click);
            // 
            // txtOwner
            // 
            this.txtOwner.Enabled = false;
            this.txtOwner.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwner.Location = new System.Drawing.Point(192, 94);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(296, 22);
            this.txtOwner.TabIndex = 62;
            // 
            // btnSelectOwner
            // 
            this.btnSelectOwner.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSelectOwner.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectOwner.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelectOwner.Location = new System.Drawing.Point(102, 92);
            this.btnSelectOwner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectOwner.Name = "btnSelectOwner";
            this.btnSelectOwner.Size = new System.Drawing.Size(53, 25);
            this.btnSelectOwner.TabIndex = 61;
            this.btnSelectOwner.Text = "Select";
            this.btnSelectOwner.UseVisualStyleBackColor = false;
            this.btnSelectOwner.Click += new System.EventHandler(this.btnSelectOwner_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(102, 43);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 58;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(102, 69);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(200, 20);
            this.dtpTime.TabIndex = 57;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(11, 176);
            this.lblReason.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(51, 14);
            this.lblReason.TabIndex = 53;
            this.lblReason.Text = "Reason:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(432, 416);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 25);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVet.Location = new System.Drawing.Point(11, 150);
            this.lblVet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(78, 14);
            this.lblVet.TabIndex = 52;
            this.lblVet.Text = "Veterinarian:";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPet.Location = new System.Drawing.Point(11, 124);
            this.lblPet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(27, 14);
            this.lblPet.TabIndex = 51;
            this.lblPet.Text = "Pet:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(11, 44);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 14);
            this.lblDate.TabIndex = 48;
            this.lblDate.Text = "Date:";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(11, 98);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(45, 14);
            this.lblOwner.TabIndex = 50;
            this.lblOwner.Text = "Owner:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(11, 70);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 14);
            this.lblTime.TabIndex = 49;
            this.lblTime.Text = "Time:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Location = new System.Drawing.Point(364, 416);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 25);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImage = global::FINALS_CS2B_GRP4.Properties.Resources.logo;
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblogo.Location = new System.Drawing.Point(19, 408);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(58, 33);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 55;
            this.pblogo.TabStop = false;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.Location = new System.Drawing.Point(11, 18);
            this.lblAppointmentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(93, 14);
            this.lblAppointmentID.TabIndex = 48;
            this.lblAppointmentID.Text = "AppointmentID:";
            // 
            // txtAppoinmentID
            // 
            this.txtAppoinmentID.Enabled = false;
            this.txtAppoinmentID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppoinmentID.Location = new System.Drawing.Point(102, 15);
            this.txtAppoinmentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAppoinmentID.Name = "txtAppoinmentID";
            this.txtAppoinmentID.Size = new System.Drawing.Size(200, 22);
            this.txtAppoinmentID.TabIndex = 62;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(306, 18);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 14);
            this.lblStatus.TabIndex = 69;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(354, 15);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(134, 22);
            this.txtStatus.TabIndex = 62;
            // 
            // frmViewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 466);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClearVet);
            this.Controls.Add(this.btnClearPet);
            this.Controls.Add(this.btnClearOwner);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtVet);
            this.Controls.Add(this.btnSelectVet);
            this.Controls.Add(this.txtPet);
            this.Controls.Add(this.btnSelectPet);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtAppoinmentID);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.btnSelectOwner);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblVet);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.lblAppointmentID);
            this.Controls.Add(this.lblPet);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmViewAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearVet;
        private System.Windows.Forms.Button btnClearPet;
        private System.Windows.Forms.Button btnClearOwner;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtVet;
        private System.Windows.Forms.Button btnSelectVet;
        private System.Windows.Forms.TextBox txtPet;
        private System.Windows.Forms.Button btnSelectPet;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Button btnSelectOwner;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.TextBox txtAppoinmentID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
    }
}