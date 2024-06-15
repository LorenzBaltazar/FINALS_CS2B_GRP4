namespace FINALS_CS2B_GRP4
{
    partial class frmManageVet
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
            this.dgVetList = new System.Windows.Forms.DataGridView();
            this.lblVet = new System.Windows.Forms.Label();
            this.btnCreateVet = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVetList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVetList
            // 
            this.dgVetList.AllowUserToAddRows = false;
            this.dgVetList.AllowUserToDeleteRows = false;
            this.dgVetList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgVetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVetList.Location = new System.Drawing.Point(11, 72);
            this.dgVetList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgVetList.Name = "dgVetList";
            this.dgVetList.ReadOnly = true;
            this.dgVetList.RowHeadersWidth = 51;
            this.dgVetList.RowTemplate.Height = 24;
            this.dgVetList.Size = new System.Drawing.Size(508, 198);
            this.dgVetList.TabIndex = 0;
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVet.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblVet.Location = new System.Drawing.Point(191, 22);
            this.lblVet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(166, 33);
            this.lblVet.TabIndex = 1;
            this.lblVet.Text = "Veterinarians";
            // 
            // btnCreateVet
            // 
            this.btnCreateVet.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCreateVet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateVet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreateVet.Location = new System.Drawing.Point(450, 292);
            this.btnCreateVet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateVet.Name = "btnCreateVet";
            this.btnCreateVet.Size = new System.Drawing.Size(63, 28);
            this.btnCreateVet.TabIndex = 2;
            this.btnCreateVet.Text = "Create";
            this.btnCreateVet.UseVisualStyleBackColor = false;
            this.btnCreateVet.Click += new System.EventHandler(this.btnCreateVet_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnView.Location = new System.Drawing.Point(366, 292);
            this.btnView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(63, 28);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImage = global::FINALS_CS2B_GRP4.Properties.Resources.logo;
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(58, 33);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 10;
            this.pblogo.TabStop = false;
            // 
            // frmManageVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 331);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCreateVet);
            this.Controls.Add(this.lblVet);
            this.Controls.Add(this.dgVetList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmManageVet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinarians";
            this.Load += new System.EventHandler(this.frmManageVet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVetList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVetList;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.Button btnCreateVet;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PictureBox pblogo;
    }
}