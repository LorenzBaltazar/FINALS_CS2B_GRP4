namespace FINALS_CS2B_GRP4
{
    partial class frmSelectPet
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
            this.lblPet = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgPetList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPetList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPet.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblPet.Location = new System.Drawing.Point(288, 15);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(152, 40);
            this.lblPet.TabIndex = 15;
            this.lblPet.Text = "Select Pet";
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImage = global::FINALS_CS2B_GRP4.Properties.Resources.logo;
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblogo.Location = new System.Drawing.Point(21, 16);
            this.pblogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(77, 41);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 14;
            this.pblogo.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(548, 358);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSelect.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSelect.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSelect.Location = new System.Drawing.Point(652, 358);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(97, 33);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgPetList
            // 
            this.dgPetList.AllowUserToAddRows = false;
            this.dgPetList.AllowUserToDeleteRows = false;
            this.dgPetList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgPetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPetList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPetList.Location = new System.Drawing.Point(33, 65);
            this.dgPetList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgPetList.Name = "dgPetList";
            this.dgPetList.RowHeadersWidth = 51;
            this.dgPetList.Size = new System.Drawing.Size(716, 273);
            this.dgPetList.TabIndex = 11;
            // 
            // frmSelectPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 410);
            this.Controls.Add(this.lblPet);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgPetList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSelectPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Pet";
            this.Load += new System.EventHandler(this.frmSelectPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgPetList;
    }
}