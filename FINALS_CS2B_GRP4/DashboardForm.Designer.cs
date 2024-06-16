namespace FINALS_CS2B_GRP4
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnl = new System.Windows.Forms.Panel();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.lblLogout = new System.Windows.Forms.Label();
            this.picVet = new System.Windows.Forms.PictureBox();
            this.picPets = new System.Windows.Forms.PictureBox();
            this.picOwners = new System.Windows.Forms.PictureBox();
            this.picAppointment = new System.Windows.Forms.PictureBox();
            this.lblPets = new System.Windows.Forms.Label();
            this.lblOwners = new System.Windows.Forms.Label();
            this.lblVet = new System.Windows.Forms.Label();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOwners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnl.Controls.Add(this.picLogout);
            this.pnl.Controls.Add(this.lblLogout);
            this.pnl.Controls.Add(this.picVet);
            this.pnl.Controls.Add(this.picPets);
            this.pnl.Controls.Add(this.picOwners);
            this.pnl.Controls.Add(this.picAppointment);
            this.pnl.Controls.Add(this.lblPets);
            this.pnl.Controls.Add(this.lblOwners);
            this.pnl.Controls.Add(this.lblVet);
            this.pnl.Controls.Add(this.lblAppointment);
            this.pnl.Location = new System.Drawing.Point(-4, -3);
            this.pnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(201, 458);
            this.pnl.TabIndex = 0;
            // 
            // picLogout
            // 
            this.picLogout.Image = global::FINALS_CS2B_GRP4.Properties.Resources.logout;
            this.picLogout.Location = new System.Drawing.Point(117, 418);
            this.picLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(27, 28);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 9;
            this.picLogout.TabStop = false;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogout.Location = new System.Drawing.Point(143, 422);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(50, 18);
            this.lblLogout.TabIndex = 8;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogout.MouseEnter += new System.EventHandler(this.lblLogout_MouseEnter);
            this.lblLogout.MouseLeave += new System.EventHandler(this.lblLogout_MouseLeave);
            // 
            // picVet
            // 
            this.picVet.Image = ((System.Drawing.Image)(resources.GetObject("picVet.Image")));
            this.picVet.Location = new System.Drawing.Point(26, 141);
            this.picVet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picVet.Name = "picVet";
            this.picVet.Size = new System.Drawing.Size(52, 54);
            this.picVet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVet.TabIndex = 7;
            this.picVet.TabStop = false;
            // 
            // picPets
            // 
            this.picPets.Image = ((System.Drawing.Image)(resources.GetObject("picPets.Image")));
            this.picPets.Location = new System.Drawing.Point(32, 316);
            this.picPets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPets.Name = "picPets";
            this.picPets.Size = new System.Drawing.Size(39, 41);
            this.picPets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPets.TabIndex = 6;
            this.picPets.TabStop = false;
            // 
            // picOwners
            // 
            this.picOwners.Image = ((System.Drawing.Image)(resources.GetObject("picOwners.Image")));
            this.picOwners.Location = new System.Drawing.Point(32, 232);
            this.picOwners.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picOwners.Name = "picOwners";
            this.picOwners.Size = new System.Drawing.Size(39, 41);
            this.picOwners.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOwners.TabIndex = 5;
            this.picOwners.TabStop = false;
            // 
            // picAppointment
            // 
            this.picAppointment.Image = global::FINALS_CS2B_GRP4.Properties.Resources.appointment;
            this.picAppointment.Location = new System.Drawing.Point(32, 66);
            this.picAppointment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAppointment.Name = "picAppointment";
            this.picAppointment.Size = new System.Drawing.Size(39, 41);
            this.picAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAppointment.TabIndex = 1;
            this.picAppointment.TabStop = false;
            // 
            // lblPets
            // 
            this.lblPets.AutoSize = true;
            this.lblPets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPets.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPets.Location = new System.Drawing.Point(79, 328);
            this.lblPets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPets.Name = "lblPets";
            this.lblPets.Size = new System.Drawing.Size(94, 19);
            this.lblPets.TabIndex = 3;
            this.lblPets.Text = "Manage Pets";
            this.lblPets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPets.Click += new System.EventHandler(this.lblPets_Click);
            this.lblPets.MouseEnter += new System.EventHandler(this.lblPets_MouseEnter);
            this.lblPets.MouseLeave += new System.EventHandler(this.lblPets_MouseLeave);
            // 
            // lblOwners
            // 
            this.lblOwners.AutoSize = true;
            this.lblOwners.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOwners.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwners.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOwners.Location = new System.Drawing.Point(92, 234);
            this.lblOwners.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOwners.Name = "lblOwners";
            this.lblOwners.Size = new System.Drawing.Size(62, 38);
            this.lblOwners.TabIndex = 2;
            this.lblOwners.Text = "Manage\nOwners";
            this.lblOwners.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOwners.Click += new System.EventHandler(this.lblOwners_Click);
            this.lblOwners.MouseEnter += new System.EventHandler(this.lblOwners_MouseEnter);
            this.lblOwners.MouseLeave += new System.EventHandler(this.lblOwners_MouseLeave);
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVet.Location = new System.Drawing.Point(76, 150);
            this.lblVet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(95, 38);
            this.lblVet.TabIndex = 1;
            this.lblVet.Text = "Manage\nVeterinarians";
            this.lblVet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVet.Click += new System.EventHandler(this.lblVet_Click);
            this.lblVet.MouseEnter += new System.EventHandler(this.lblVet_MouseEnter);
            this.lblVet.MouseLeave += new System.EventHandler(this.lblVet_MouseLeave);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAppointment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppointment.Location = new System.Drawing.Point(75, 67);
            this.lblAppointment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(99, 38);
            this.lblAppointment.TabIndex = 0;
            this.lblAppointment.Text = "Manage\nAppointments";
            this.lblAppointment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAppointment.Click += new System.EventHandler(this.lblAppointment_Click);
            this.lblAppointment.MouseEnter += new System.EventHandler(this.lblAppointment_MouseEnter);
            this.lblAppointment.MouseLeave += new System.EventHandler(this.lblAppointment_MouseLeave);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl);
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOwners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.Label lblOwners;
        private System.Windows.Forms.Label lblPets;
        private System.Windows.Forms.PictureBox picAppointment;
        private System.Windows.Forms.PictureBox picOwners;
        private System.Windows.Forms.PictureBox picPets;
        private System.Windows.Forms.PictureBox picVet;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.PictureBox picLogout;
    }
}