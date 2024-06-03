namespace CineBoxAppV1
{
    partial class UC_Ticket_Logined
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
            this.signupHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mytickets1 = new CineBoxAppV1.mytickets();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signupHeader
            // 
            this.signupHeader.AutoSize = true;
            this.signupHeader.BackColor = System.Drawing.Color.White;
            this.signupHeader.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.signupHeader.Location = new System.Drawing.Point(459, 23);
            this.signupHeader.Name = "signupHeader";
            this.signupHeader.Size = new System.Drawing.Size(205, 53);
            this.signupHeader.TabIndex = 6;
            this.signupHeader.Text = "Biletlerim";
            this.signupHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(18, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 440);
            this.panel1.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1080, 440);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // mytickets1
            // 
            this.mytickets1.BackColor = System.Drawing.Color.White;
            this.mytickets1.Location = new System.Drawing.Point(18, 102);
            this.mytickets1.Name = "mytickets1";
            this.mytickets1.Size = new System.Drawing.Size(1073, 35);
            this.mytickets1.TabIndex = 8;
            // 
            // UC_Ticket_Logined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mytickets1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signupHeader);
            this.Name = "UC_Ticket_Logined";
            this.Size = new System.Drawing.Size(1122, 630);
            this.Load += new System.EventHandler(this.UC_Ticket_Logined_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signupHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private mytickets mytickets1;
    }
}
