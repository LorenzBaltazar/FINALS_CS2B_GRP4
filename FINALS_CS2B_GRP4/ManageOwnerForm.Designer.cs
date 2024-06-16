namespace FINALS_CS2B_GRP4
{
    partial class frmManageOwner
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgOwnerList = new System.Windows.Forms.DataGridView();
            this.lblOwner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOwnerList)).BeginInit();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImage = global::FINALS_CS2B_GRP4.Properties.Resources.logo;
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblogo.Location = new System.Drawing.Point(9, 14);
            this.pblogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(77, 41);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 9;
            this.pblogo.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnView.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnView.ForeColor = System.Drawing.SystemColors.Control;
            this.btnView.Location = new System.Drawing.Point(507, 356);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(91, 33);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCreate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Location = new System.Drawing.Point(640, 356);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(97, 33);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgOwnerList
            // 
            this.dgOwnerList.AllowUserToAddRows = false;
            this.dgOwnerList.AllowUserToDeleteRows = false;
            this.dgOwnerList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgOwnerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOwnerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgOwnerList.Location = new System.Drawing.Point(21, 63);
            this.dgOwnerList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgOwnerList.Name = "dgOwnerList";
            this.dgOwnerList.RowHeadersWidth = 51;
            this.dgOwnerList.Size = new System.Drawing.Size(716, 273);
            this.dgOwnerList.TabIndex = 5;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblOwner.Location = new System.Drawing.Point(300, 14);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(124, 40);
            this.lblOwner.TabIndex = 10;
            this.lblOwner.Text = "Owners";
            // 
            // frmManageOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 401);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgOwnerList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManageOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owners";
            this.Load += new System.EventHandler(this.frmManageOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOwnerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgOwnerList;
        private System.Windows.Forms.Label lblOwner;
    }
}