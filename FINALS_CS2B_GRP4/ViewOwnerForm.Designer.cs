namespace FINALS_CS2B_GRP4
{
    partial class frmOwnerView
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
            this.lblownerid = new System.Windows.Forms.Label();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblPnumber = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.lblPets = new System.Windows.Forms.Label();
            this.dgPetList = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPetList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblownerid
            // 
            this.lblownerid.AutoSize = true;
            this.lblownerid.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblownerid.Location = new System.Drawing.Point(27, 24);
            this.lblownerid.Name = "lblownerid";
            this.lblownerid.Size = new System.Drawing.Size(60, 14);
            this.lblownerid.TabIndex = 47;
            this.lblownerid.Text = "Owner ID:";
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Enabled = false;
            this.txtOwnerID.Location = new System.Drawing.Point(114, 21);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(71, 20);
            this.txtOwnerID.TabIndex = 46;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(353, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 27);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(425, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 27);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(114, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(377, 20);
            this.txtEmail.TabIndex = 41;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNum.Location = new System.Drawing.Point(114, 113);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(377, 20);
            this.txtPhoneNum.TabIndex = 40;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Location = new System.Drawing.Point(114, 90);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(377, 20);
            this.txtAddress.TabIndex = 39;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLName.Location = new System.Drawing.Point(114, 67);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(377, 20);
            this.txtLName.TabIndex = 38;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFName.Location = new System.Drawing.Point(114, 44);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(377, 20);
            this.txtFName.TabIndex = 37;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblemail.Location = new System.Drawing.Point(27, 139);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(41, 14);
            this.lblemail.TabIndex = 36;
            this.lblemail.Text = "Email:";
            // 
            // lblPnumber
            // 
            this.lblPnumber.AutoSize = true;
            this.lblPnumber.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblPnumber.Location = new System.Drawing.Point(27, 116);
            this.lblPnumber.Name = "lblPnumber";
            this.lblPnumber.Size = new System.Drawing.Size(90, 14);
            this.lblPnumber.TabIndex = 35;
            this.lblPnumber.Text = "Phone Number:";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbladdress.Location = new System.Drawing.Point(27, 93);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(54, 14);
            this.lbladdress.TabIndex = 34;
            this.lbladdress.Text = "Address:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblLname.Location = new System.Drawing.Point(27, 70);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(67, 14);
            this.lblLname.TabIndex = 33;
            this.lblLname.Text = "Last Name:";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblfname.Location = new System.Drawing.Point(27, 47);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(69, 14);
            this.lblfname.TabIndex = 32;
            this.lblfname.Text = "First Name:";
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblogo.Image = global::FINALS_CS2B_GRP4.Properties.Resources.logo;
            this.pblogo.Location = new System.Drawing.Point(12, 166);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(58, 33);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 42;
            this.pblogo.TabStop = false;
            // 
            // lblPets
            // 
            this.lblPets.AutoSize = true;
            this.lblPets.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblPets.Location = new System.Drawing.Point(27, 220);
            this.lblPets.Name = "lblPets";
            this.lblPets.Size = new System.Drawing.Size(33, 14);
            this.lblPets.TabIndex = 48;
            this.lblPets.Text = "Pets:";
            // 
            // dgPetList
            // 
            this.dgPetList.AllowUserToAddRows = false;
            this.dgPetList.AllowUserToDeleteRows = false;
            this.dgPetList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgPetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPetList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPetList.Location = new System.Drawing.Point(23, 249);
            this.dgPetList.Margin = new System.Windows.Forms.Padding(2);
            this.dgPetList.Name = "dgPetList";
            this.dgPetList.ReadOnly = true;
            this.dgPetList.RowHeadersWidth = 51;
            this.dgPetList.RowTemplate.Height = 24;
            this.dgPetList.Size = new System.Drawing.Size(468, 155);
            this.dgPetList.TabIndex = 49;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnView.Location = new System.Drawing.Point(381, 211);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(107, 28);
            this.btnView.TabIndex = 50;
            this.btnView.Text = "View Pet";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmOwnerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 415);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgPetList);
            this.Controls.Add(this.lblPets);
            this.Controls.Add(this.lblownerid);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblPnumber);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblfname);
            this.MaximizeBox = false;
            this.Name = "frmOwnerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Owner";
            this.Load += new System.EventHandler(this.frmOwnerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblownerid;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblPnumber;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label lblPets;
        private System.Windows.Forms.DataGridView dgPetList;
        private System.Windows.Forms.Button btnView;
    }
}