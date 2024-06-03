namespace CineBoxAppV1
{
    partial class mytickets
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
            this.lblticketno = new System.Windows.Forms.Label();
            this.lblticketfilm = new System.Windows.Forms.Label();
            this.lblticketseatnumber = new System.Windows.Forms.Label();
            this.lblticketseansdate = new System.Windows.Forms.Label();
            this.lblticketseanstime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblticketno
            // 
            this.lblticketno.BackColor = System.Drawing.Color.Transparent;
            this.lblticketno.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblticketno.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.lblticketno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(20)))));
            this.lblticketno.Location = new System.Drawing.Point(0, 0);
            this.lblticketno.Name = "lblticketno";
            this.lblticketno.Size = new System.Drawing.Size(304, 35);
            this.lblticketno.TabIndex = 7;
            this.lblticketno.Text = "BİLET NUMARASI";
            this.lblticketno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblticketfilm
            // 
            this.lblticketfilm.BackColor = System.Drawing.Color.Transparent;
            this.lblticketfilm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblticketfilm.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.lblticketfilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(20)))));
            this.lblticketfilm.Location = new System.Drawing.Point(304, 0);
            this.lblticketfilm.Name = "lblticketfilm";
            this.lblticketfilm.Size = new System.Drawing.Size(258, 35);
            this.lblticketfilm.TabIndex = 8;
            this.lblticketfilm.Text = "FİLM";
            this.lblticketfilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblticketseatnumber
            // 
            this.lblticketseatnumber.BackColor = System.Drawing.Color.Transparent;
            this.lblticketseatnumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblticketseatnumber.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.lblticketseatnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(20)))));
            this.lblticketseatnumber.Location = new System.Drawing.Point(562, 0);
            this.lblticketseatnumber.Name = "lblticketseatnumber";
            this.lblticketseatnumber.Size = new System.Drawing.Size(181, 35);
            this.lblticketseatnumber.TabIndex = 9;
            this.lblticketseatnumber.Text = "KOLTUK NO";
            this.lblticketseatnumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblticketseansdate
            // 
            this.lblticketseansdate.BackColor = System.Drawing.Color.Transparent;
            this.lblticketseansdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblticketseansdate.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.lblticketseansdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(20)))));
            this.lblticketseansdate.Location = new System.Drawing.Point(743, 0);
            this.lblticketseansdate.Name = "lblticketseansdate";
            this.lblticketseansdate.Size = new System.Drawing.Size(181, 35);
            this.lblticketseansdate.TabIndex = 10;
            this.lblticketseansdate.Text = "SEANS TARİHİ";
            this.lblticketseansdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblticketseanstime
            // 
            this.lblticketseanstime.BackColor = System.Drawing.Color.Transparent;
            this.lblticketseanstime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblticketseanstime.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.lblticketseanstime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(20)))));
            this.lblticketseanstime.Location = new System.Drawing.Point(924, 0);
            this.lblticketseanstime.Name = "lblticketseanstime";
            this.lblticketseanstime.Size = new System.Drawing.Size(149, 35);
            this.lblticketseanstime.TabIndex = 11;
            this.lblticketseanstime.Text = "SEANS SAATİ";
            this.lblticketseanstime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mytickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblticketseanstime);
            this.Controls.Add(this.lblticketseansdate);
            this.Controls.Add(this.lblticketseatnumber);
            this.Controls.Add(this.lblticketfilm);
            this.Controls.Add(this.lblticketno);
            this.Name = "mytickets";
            this.Size = new System.Drawing.Size(1073, 35);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblticketno;
        public System.Windows.Forms.Label lblticketfilm;
        public System.Windows.Forms.Label lblticketseatnumber;
        public System.Windows.Forms.Label lblticketseansdate;
        public System.Windows.Forms.Label lblticketseanstime;
    }
}
