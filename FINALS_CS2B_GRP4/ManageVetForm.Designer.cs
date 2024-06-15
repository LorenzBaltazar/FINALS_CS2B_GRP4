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
            ((System.ComponentModel.ISupportInitialize)(this.dgVetList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVetList
            // 
            this.dgVetList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgVetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVetList.Location = new System.Drawing.Point(52, 89);
            this.dgVetList.Name = "dgVetList";
            this.dgVetList.RowHeadersWidth = 51;
            this.dgVetList.RowTemplate.Height = 24;
            this.dgVetList.Size = new System.Drawing.Size(604, 235);
            this.dgVetList.TabIndex = 0;
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVet.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblVet.Location = new System.Drawing.Point(255, 27);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(201, 40);
            this.lblVet.TabIndex = 1;
            this.lblVet.Text = "Veterinarians";
            // 
            // btnCreateVet
            // 
            this.btnCreateVet.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCreateVet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateVet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreateVet.Location = new System.Drawing.Point(554, 346);
            this.btnCreateVet.Name = "btnCreateVet";
            this.btnCreateVet.Size = new System.Drawing.Size(84, 35);
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
            this.btnView.Location = new System.Drawing.Point(443, 346);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(84, 35);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmManageVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 407);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCreateVet);
            this.Controls.Add(this.lblVet);
            this.Controls.Add(this.dgVetList);
            this.MaximizeBox = false;
            this.Name = "frmManageVet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinarians";
            ((System.ComponentModel.ISupportInitialize)(this.dgVetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVetList;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.Button btnCreateVet;
        private System.Windows.Forms.Button btnView;
    }
}