namespace FINALS_CS2B_GRP4
{
    partial class frmVetView
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtVetID = new System.Windows.Forms.TextBox();
            this.lblVetID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Location = new System.Drawing.Point(267, 175);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 24);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(207, 175);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 24);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(29, 51);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(69, 14);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(29, 75);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(67, 14);
            this.lblLName.TabIndex = 4;
            this.lblLName.Text = "Last Name:";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialization.Location = new System.Drawing.Point(29, 98);
            this.lblSpecialization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(87, 14);
            this.lblSpecialization.TabIndex = 5;
            this.lblSpecialization.Text = "Specialization:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(29, 122);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(90, 14);
            this.lblPhoneNum.TabIndex = 6;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(29, 145);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 14);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(126, 118);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(218, 22);
            this.txtPhoneNum.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(126, 47);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(218, 22);
            this.txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(126, 71);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(218, 22);
            this.txtLName.TabIndex = 2;
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialization.Location = new System.Drawing.Point(126, 94);
            this.txtSpecialization.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(218, 22);
            this.txtSpecialization.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(126, 141);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtVetID
            // 
            this.txtVetID.Enabled = false;
            this.txtVetID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVetID.Location = new System.Drawing.Point(126, 24);
            this.txtVetID.Margin = new System.Windows.Forms.Padding(2);
            this.txtVetID.Name = "txtVetID";
            this.txtVetID.Size = new System.Drawing.Size(218, 22);
            this.txtVetID.TabIndex = 0;
            // 
            // lblVetID
            // 
            this.lblVetID.AutoSize = true;
            this.lblVetID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVetID.Location = new System.Drawing.Point(29, 28);
            this.lblVetID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVetID.Name = "lblVetID";
            this.lblVetID.Size = new System.Drawing.Size(93, 14);
            this.lblVetID.TabIndex = 9;
            this.lblVetID.Text = "Veterinarian ID:";
            // 
            // frmVetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 218);
            this.Controls.Add(this.txtVetID);
            this.Controls.Add(this.lblVetID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSpecialization);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmVetView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Veterinarian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtVetID;
        private System.Windows.Forms.Label lblVetID;
    }
}