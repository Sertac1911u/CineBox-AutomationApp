namespace CineBoxAppV1
{
    partial class Ticket
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
            this.signupHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backHomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStaffusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // signupHeader
            // 
            this.signupHeader.AutoSize = true;
            this.signupHeader.BackColor = System.Drawing.Color.White;
            this.signupHeader.Font = new System.Drawing.Font("Segoe UI Variable Display", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupHeader.ForeColor = System.Drawing.Color.MediumPurple;
            this.signupHeader.Location = new System.Drawing.Point(447, 22);
            this.signupHeader.Name = "signupHeader";
            this.signupHeader.Size = new System.Drawing.Size(243, 63);
            this.signupHeader.TabIndex = 4;
            this.signupHeader.Text = "Biletlerim";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(38, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 672);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1119, 672);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // backHomeBtn
            // 
            this.backHomeBtn.BackColor = System.Drawing.Color.White;
            this.backHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backHomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.backHomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backHomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backHomeBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F);
            this.backHomeBtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.backHomeBtn.Location = new System.Drawing.Point(1028, 12);
            this.backHomeBtn.Name = "backHomeBtn";
            this.backHomeBtn.Size = new System.Drawing.Size(160, 40);
            this.backHomeBtn.TabIndex = 8;
            this.backHomeBtn.Text = "Geri Dön";
            this.backHomeBtn.UseVisualStyleBackColor = false;
            this.backHomeBtn.Click += new System.EventHandler(this.backHomeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblStaffusername);
            this.panel2.Location = new System.Drawing.Point(38, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 35);
            this.panel2.TabIndex = 9;
            // 
            // lblStaffusername
            // 
            this.lblStaffusername.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffusername.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStaffusername.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaffusername.ForeColor = System.Drawing.Color.White;
            this.lblStaffusername.Location = new System.Drawing.Point(0, 0);
            this.lblStaffusername.Name = "lblStaffusername";
            this.lblStaffusername.Size = new System.Drawing.Size(304, 35);
            this.lblStaffusername.TabIndex = 3;
            this.lblStaffusername.Text = "BİLET NUMARASI";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "FİLM";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(562, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "KOLTUK NO";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(743, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "SEANS TARİHİ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(924, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "SEANS SAATİ";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 845);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.backHomeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signupHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(430, 80);
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signupHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button backHomeBtn;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblStaffusername;
    }
}