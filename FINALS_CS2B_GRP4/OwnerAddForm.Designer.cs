namespace FINALS_CS2B_GRP4
{
    partial class frmAddOwner
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
            this.lbl = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpnumber = new System.Windows.Forms.TextBox();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.tblname = new System.Windows.Forms.TextBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblPnumber = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.SystemColors.Control;
            this.lbl.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lbl.Location = new System.Drawing.Point(169, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(271, 33);
            this.lbl.TabIndex = 29;
            this.lbl.Text = "Create New Owner";
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImage = global::FINALS_CS2B_GRP4.Properties.Resources.logo;
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblogo.Location = new System.Drawing.Point(7, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(58, 33);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 28;
            this.pblogo.TabStop = false;
            // 
            // tbemail
            // 
            this.tbemail.BackColor = System.Drawing.SystemColors.Window;
            this.tbemail.Location = new System.Drawing.Point(150, 229);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(377, 20);
            this.tbemail.TabIndex = 27;
            // 
            // tbpnumber
            // 
            this.tbpnumber.BackColor = System.Drawing.SystemColors.Window;
            this.tbpnumber.Location = new System.Drawing.Point(150, 188);
            this.tbpnumber.Name = "tbpnumber";
            this.tbpnumber.Size = new System.Drawing.Size(377, 20);
            this.tbpnumber.TabIndex = 26;
            // 
            // tbaddress
            // 
            this.tbaddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbaddress.Location = new System.Drawing.Point(150, 149);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(377, 20);
            this.tbaddress.TabIndex = 25;
            // 
            // tblname
            // 
            this.tblname.BackColor = System.Drawing.SystemColors.Window;
            this.tblname.Location = new System.Drawing.Point(150, 104);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(377, 20);
            this.tblname.TabIndex = 24;
            // 
            // tbfname
            // 
            this.tbfname.BackColor = System.Drawing.SystemColors.Window;
            this.tbfname.Location = new System.Drawing.Point(150, 66);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(377, 20);
            this.tbfname.TabIndex = 23;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnclear.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnclear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnclear.Location = new System.Drawing.Point(428, 281);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(129, 33);
            this.btnclear.TabIndex = 22;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnadd.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnadd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnadd.Location = new System.Drawing.Point(287, 281);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(129, 33);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnback.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnback.Location = new System.Drawing.Point(14, 281);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 26);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(31, 231);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 18);
            this.lblemail.TabIndex = 19;
            this.lblemail.Text = "Email:";
            // 
            // lblPnumber
            // 
            this.lblPnumber.AutoSize = true;
            this.lblPnumber.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnumber.Location = new System.Drawing.Point(31, 190);
            this.lblPnumber.Name = "lblPnumber";
            this.lblPnumber.Size = new System.Drawing.Size(109, 18);
            this.lblPnumber.TabIndex = 18;
            this.lblPnumber.Text = "Phone Number:";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(31, 151);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(63, 18);
            this.lbladdress.TabIndex = 17;
            this.lbladdress.Text = "Address:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(30, 106);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(78, 18);
            this.lblLname.TabIndex = 16;
            this.lblLname.Text = "Last Name:";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(31, 68);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(81, 18);
            this.lblfname.TabIndex = 15;
            this.lblfname.Text = "First Name:";
            // 
            // frmAddOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 326);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbpnumber);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.tblname);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblPnumber);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblfname);
            this.MaximizeBox = false;
            this.Name = "frmAddOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Owner";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpnumber;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblPnumber;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblfname;
    }
}