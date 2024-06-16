namespace FINALS_CS2B_GRP4
{
    partial class frmManagePet
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
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCreateVet = new System.Windows.Forms.Button();
            this.lblPet = new System.Windows.Forms.Label();
            this.dgPetList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPetList)).BeginInit();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImage = global::FINALS_CS2B_GRP4.Properties.Resources.logo;
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblogo.Location = new System.Drawing.Point(12, 10);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(58, 33);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 15;
            this.pblogo.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnView.Location = new System.Drawing.Point(366, 290);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(63, 28);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCreateVet
            // 
            this.btnCreateVet.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCreateVet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateVet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreateVet.Location = new System.Drawing.Point(450, 290);
            this.btnCreateVet.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateVet.Name = "btnCreateVet";
            this.btnCreateVet.Size = new System.Drawing.Size(63, 28);
            this.btnCreateVet.TabIndex = 14;
            this.btnCreateVet.Text = "Create";
            this.btnCreateVet.UseVisualStyleBackColor = false;
            this.btnCreateVet.Click += new System.EventHandler(this.btnCreatePet_Click);
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPet.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblPet.Location = new System.Drawing.Point(242, 19);
            this.lblPet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(63, 33);
            this.lblPet.TabIndex = 13;
            this.lblPet.Text = "Pets";
            // 
            // dgPetList
            // 
            this.dgPetList.AllowUserToAddRows = false;
            this.dgPetList.AllowUserToDeleteRows = false;
            this.dgPetList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgPetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPetList.Location = new System.Drawing.Point(11, 70);
            this.dgPetList.Margin = new System.Windows.Forms.Padding(2);
            this.dgPetList.Name = "dgPetList";
            this.dgPetList.ReadOnly = true;
            this.dgPetList.RowHeadersWidth = 51;
            this.dgPetList.RowTemplate.Height = 24;
            this.dgPetList.Size = new System.Drawing.Size(508, 198);
            this.dgPetList.TabIndex = 11;
            // 
            // frmManagePet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 331);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCreateVet);
            this.Controls.Add(this.lblPet);
            this.Controls.Add(this.dgPetList);
            this.Name = "frmManagePet";
            this.Text = "8";
            this.Load += new System.EventHandler(this.frmManagePet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCreateVet;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.DataGridView dgPetList;
    }
}