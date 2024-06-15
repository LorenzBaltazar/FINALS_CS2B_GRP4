namespace FINALS_CS2B_GRP4
{
    partial class frmCreateOwner
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblPnumber = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImage = global::FINALS_CS2B_GRP4.Properties.Resources.logo;
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblogo.Location = new System.Drawing.Point(12, 145);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(58, 33);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 28;
            this.pblogo.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(114, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(357, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNum.Location = new System.Drawing.Point(114, 95);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(357, 20);
            this.txtPhoneNum.TabIndex = 26;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Location = new System.Drawing.Point(114, 72);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(357, 20);
            this.txtAddress.TabIndex = 25;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLName.Location = new System.Drawing.Point(114, 49);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(357, 20);
            this.txtLName.TabIndex = 24;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFName.Location = new System.Drawing.Point(114, 26);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(357, 20);
            this.txtFName.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(394, 151);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 27);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCreate.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Location = new System.Drawing.Point(298, 151);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(77, 27);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblemail.Location = new System.Drawing.Point(20, 120);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(41, 14);
            this.lblemail.TabIndex = 19;
            this.lblemail.Text = "Email:";
            // 
            // lblPnumber
            // 
            this.lblPnumber.AutoSize = true;
            this.lblPnumber.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblPnumber.Location = new System.Drawing.Point(20, 97);
            this.lblPnumber.Name = "lblPnumber";
            this.lblPnumber.Size = new System.Drawing.Size(90, 14);
            this.lblPnumber.TabIndex = 18;
            this.lblPnumber.Text = "Phone Number:";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbladdress.Location = new System.Drawing.Point(20, 74);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(54, 14);
            this.lbladdress.TabIndex = 17;
            this.lbladdress.Text = "Address:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblLname.Location = new System.Drawing.Point(19, 51);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(67, 14);
            this.lblLname.TabIndex = 16;
            this.lblLname.Text = "Last Name:";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblfname.Location = new System.Drawing.Point(20, 28);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(69, 14);
            this.lblfname.TabIndex = 15;
            this.lblfname.Text = "First Name:";
            // 
            // frmCreateOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 190);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblPnumber);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblfname);
            this.MaximizeBox = false;
            this.Name = "frmCreateOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Owner";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblPnumber;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblfname;
    }
}