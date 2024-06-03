namespace CineBoxAppV1
{
    partial class staffRegister
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.staffadi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.staffpass = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.staffsaloonid = new System.Windows.Forms.TextBox();
            this.registerStaffBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(400, 536);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(521, 52);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.Text = "Geri";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 53);
            this.label1.TabIndex = 13;
            this.label1.Text = "Yetkili Kayıt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.staffadi);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Location = new System.Drawing.Point(406, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(11, 3, 3, 10);
            this.groupBox1.Size = new System.Drawing.Size(518, 61);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetkili Kullanıcı Adı";
            // 
            // staffadi
            // 
            this.staffadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffadi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.staffadi.ForeColor = System.Drawing.Color.MediumPurple;
            this.staffadi.Location = new System.Drawing.Point(11, 24);
            this.staffadi.Name = "staffadi";
            this.staffadi.Size = new System.Drawing.Size(504, 27);
            this.staffadi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.staffpass);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Location = new System.Drawing.Point(406, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(11, 3, 3, 10);
            this.groupBox2.Size = new System.Drawing.Size(518, 61);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yetkili Parola";
            // 
            // staffpass
            // 
            this.staffpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffpass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.staffpass.ForeColor = System.Drawing.Color.MediumPurple;
            this.staffpass.Location = new System.Drawing.Point(11, 24);
            this.staffpass.Name = "staffpass";
            this.staffpass.Size = new System.Drawing.Size(504, 27);
            this.staffpass.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.staffsaloonid);
            this.groupBox3.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox3.Location = new System.Drawing.Point(406, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(11, 3, 3, 10);
            this.groupBox3.Size = new System.Drawing.Size(518, 61);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yetkili Salon ID";
            // 
            // staffsaloonid
            // 
            this.staffsaloonid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffsaloonid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.staffsaloonid.ForeColor = System.Drawing.Color.MediumPurple;
            this.staffsaloonid.Location = new System.Drawing.Point(11, 24);
            this.staffsaloonid.Name = "staffsaloonid";
            this.staffsaloonid.Size = new System.Drawing.Size(504, 27);
            this.staffsaloonid.TabIndex = 0;
            // 
            // registerStaffBtn
            // 
            this.registerStaffBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.registerStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerStaffBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F);
            this.registerStaffBtn.ForeColor = System.Drawing.Color.White;
            this.registerStaffBtn.Location = new System.Drawing.Point(400, 453);
            this.registerStaffBtn.Name = "registerStaffBtn";
            this.registerStaffBtn.Size = new System.Drawing.Size(521, 52);
            this.registerStaffBtn.TabIndex = 17;
            this.registerStaffBtn.Text = "Personeli Ekle";
            this.registerStaffBtn.UseVisualStyleBackColor = false;
            this.registerStaffBtn.Click += new System.EventHandler(this.registerStaffBtn_Click);
            // 
            // staffRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 759);
            this.Controls.Add(this.registerStaffBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(225, 50);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "staffRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "staffRegister";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox staffadi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox staffpass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox staffsaloonid;
        private System.Windows.Forms.Button registerStaffBtn;
    }
}