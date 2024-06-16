namespace FINALS_CS2B_GRP4
{
    partial class frmManageAppointment
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnCreateVet = new System.Windows.Forms.Button();
            this.lblPet = new System.Windows.Forms.Label();
            this.dgAppointmentList = new System.Windows.Forms.DataGridView();
            this.pblogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnView.Location = new System.Drawing.Point(523, 281);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(63, 28);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCreateVet
            // 
            this.btnCreateVet.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCreateVet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateVet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreateVet.Location = new System.Drawing.Point(607, 281);
            this.btnCreateVet.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateVet.Name = "btnCreateVet";
            this.btnCreateVet.Size = new System.Drawing.Size(63, 28);
            this.btnCreateVet.TabIndex = 19;
            this.btnCreateVet.Text = "Create";
            this.btnCreateVet.UseVisualStyleBackColor = false;
            this.btnCreateVet.Click += new System.EventHandler(this.btnCreateAppointment_Click);
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPet.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblPet.Location = new System.Drawing.Point(259, 19);
            this.lblPet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(174, 33);
            this.lblPet.TabIndex = 18;
            this.lblPet.Text = "Appointments";
            // 
            // dgAppointmentList
            // 
            this.dgAppointmentList.AllowUserToAddRows = false;
            this.dgAppointmentList.AllowUserToDeleteRows = false;
            this.dgAppointmentList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppointmentList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgAppointmentList.Location = new System.Drawing.Point(11, 69);
            this.dgAppointmentList.Margin = new System.Windows.Forms.Padding(2);
            this.dgAppointmentList.Name = "dgAppointmentList";
            this.dgAppointmentList.ReadOnly = true;
            this.dgAppointmentList.RowHeadersWidth = 51;
            this.dgAppointmentList.RowTemplate.Height = 24;
            this.dgAppointmentList.Size = new System.Drawing.Size(659, 198);
            this.dgAppointmentList.TabIndex = 16;
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImage = global::FINALS_CS2B_GRP4.Properties.Resources.logo;
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblogo.Location = new System.Drawing.Point(12, 9);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(58, 33);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 20;
            this.pblogo.TabStop = false;
            // 
            // frmManageAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 318);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCreateVet);
            this.Controls.Add(this.lblPet);
            this.Controls.Add(this.dgAppointmentList);
            this.Name = "frmManageAppointment";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.frmManageAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCreateVet;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.DataGridView dgAppointmentList;
    }
}