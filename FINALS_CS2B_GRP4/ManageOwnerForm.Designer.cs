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
            this.lbl = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.dgowners = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgowners)).BeginInit();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImage = global::FINALS_CS2B_GRP4.Properties.Resources.logo;
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblogo.Location = new System.Drawing.Point(7, 11);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(58, 33);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 9;
            this.pblogo.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.SystemColors.Control;
            this.lbl.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lbl.Location = new System.Drawing.Point(177, 11);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(220, 33);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "List Of Owners";
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnview.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnview.ForeColor = System.Drawing.SystemColors.Control;
            this.btnview.Location = new System.Drawing.Point(427, 279);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(130, 37);
            this.btnview.TabIndex = 7;
            this.btnview.Text = "View Owner";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btncreate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btncreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btncreate.Location = new System.Drawing.Point(16, 279);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(130, 37);
            this.btncreate.TabIndex = 6;
            this.btncreate.Text = "Create New";
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // dgowners
            // 
            this.dgowners.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgowners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgowners.Location = new System.Drawing.Point(16, 51);
            this.dgowners.Name = "dgowners";
            this.dgowners.Size = new System.Drawing.Size(541, 222);
            this.dgowners.TabIndex = 5;
            // 
            // frmManageOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 326);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.dgowners);
            this.Name = "frmManageOwner";
            this.Text = "Manage Owners";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgowners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.DataGridView dgowners;
    }
}