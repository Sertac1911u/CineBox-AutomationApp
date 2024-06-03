namespace CineBoxAppV1
{
    partial class staffListesi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStaffusername = new System.Windows.Forms.Label();
            this.lblStaffpass = new System.Windows.Forms.Label();
            this.lblStaffSalonId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStaffusername
            // 
            this.lblStaffusername.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStaffusername.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaffusername.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblStaffusername.Location = new System.Drawing.Point(0, 0);
            this.lblStaffusername.Name = "lblStaffusername";
            this.lblStaffusername.Size = new System.Drawing.Size(304, 32);
            this.lblStaffusername.TabIndex = 2;
            this.lblStaffusername.Text = "ladsasasasasasasasasasasabel2";
            // 
            // lblStaffpass
            // 
            this.lblStaffpass.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStaffpass.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaffpass.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblStaffpass.Location = new System.Drawing.Point(304, 0);
            this.lblStaffpass.Name = "lblStaffpass";
            this.lblStaffpass.Size = new System.Drawing.Size(304, 32);
            this.lblStaffpass.TabIndex = 3;
            this.lblStaffpass.Text = "ladsasasasasasasasasasasabel2";
            this.lblStaffpass.Click += new System.EventHandler(this.lblStaffpass_Click);
            // 
            // lblStaffSalonId
            // 
            this.lblStaffSalonId.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStaffSalonId.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaffSalonId.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblStaffSalonId.Location = new System.Drawing.Point(620, 0);
            this.lblStaffSalonId.Name = "lblStaffSalonId";
            this.lblStaffSalonId.Size = new System.Drawing.Size(195, 32);
            this.lblStaffSalonId.TabIndex = 4;
            this.lblStaffSalonId.Text = "133";
            // 
            // staffListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStaffSalonId);
            this.Controls.Add(this.lblStaffpass);
            this.Controls.Add(this.lblStaffusername);
            this.Name = "staffListesi";
            this.Size = new System.Drawing.Size(815, 32);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblStaffusername;
        public System.Windows.Forms.Label lblStaffpass;
        public System.Windows.Forms.Label lblStaffSalonId;
    }
}
