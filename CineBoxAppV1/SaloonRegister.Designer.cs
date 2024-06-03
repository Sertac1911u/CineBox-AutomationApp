namespace CineBoxAppV1
{
    partial class SaloonRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salonAdi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saloonCapacity = new System.Windows.Forms.TextBox();
            this.registerFilmBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.cinemaIDCom = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "Salon Kayıt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salonAdi);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Location = new System.Drawing.Point(406, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(11, 3, 3, 10);
            this.groupBox1.Size = new System.Drawing.Size(518, 61);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon Adı";
            // 
            // salonAdi
            // 
            this.salonAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salonAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salonAdi.ForeColor = System.Drawing.Color.MediumPurple;
            this.salonAdi.Location = new System.Drawing.Point(11, 24);
            this.salonAdi.Name = "salonAdi";
            this.salonAdi.Size = new System.Drawing.Size(504, 27);
            this.salonAdi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cinemaIDCom);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Location = new System.Drawing.Point(406, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(11, 3, 3, 10);
            this.groupBox2.Size = new System.Drawing.Size(518, 82);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sinema ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saloonCapacity);
            this.groupBox3.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox3.Location = new System.Drawing.Point(403, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(11, 3, 3, 10);
            this.groupBox3.Size = new System.Drawing.Size(518, 61);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Koltuk Sayısı";
            // 
            // saloonCapacity
            // 
            this.saloonCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saloonCapacity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saloonCapacity.ForeColor = System.Drawing.Color.MediumPurple;
            this.saloonCapacity.Location = new System.Drawing.Point(11, 24);
            this.saloonCapacity.Name = "saloonCapacity";
            this.saloonCapacity.Size = new System.Drawing.Size(504, 27);
            this.saloonCapacity.TabIndex = 0;
            // 
            // registerFilmBtn
            // 
            this.registerFilmBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.registerFilmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerFilmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerFilmBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F);
            this.registerFilmBtn.ForeColor = System.Drawing.Color.White;
            this.registerFilmBtn.Location = new System.Drawing.Point(403, 476);
            this.registerFilmBtn.Name = "registerFilmBtn";
            this.registerFilmBtn.Size = new System.Drawing.Size(521, 52);
            this.registerFilmBtn.TabIndex = 9;
            this.registerFilmBtn.Text = "Salonu Kaydet";
            this.registerFilmBtn.UseVisualStyleBackColor = false;
            this.registerFilmBtn.Click += new System.EventHandler(this.registerFilmBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Crimson;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(403, 570);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(521, 52);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "İptal";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // cinemaIDCom
            // 
            this.cinemaIDCom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cinemaIDCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinemaIDCom.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.cinemaIDCom.ForeColor = System.Drawing.Color.MediumPurple;
            this.cinemaIDCom.FormattingEnabled = true;
            this.cinemaIDCom.Location = new System.Drawing.Point(11, 37);
            this.cinemaIDCom.Name = "cinemaIDCom";
            this.cinemaIDCom.Size = new System.Drawing.Size(504, 35);
            this.cinemaIDCom.TabIndex = 3;
            // 
            // SaloonRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 759);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.registerFilmBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(225, 50);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SaloonRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SaloonRegister";
            this.Load += new System.EventHandler(this.SaloonRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox salonAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox saloonCapacity;
        private System.Windows.Forms.Button registerFilmBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox cinemaIDCom;
    }
}