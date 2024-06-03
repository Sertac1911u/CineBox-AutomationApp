namespace CineBoxAppV1
{
    partial class MovieRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filmAdi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filmCategory = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.filmUrl = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filmDescription = new System.Windows.Forms.TextBox();
            this.registerFilmBtn = new System.Windows.Forms.Button();
            this.filmDate = new System.Windows.Forms.GroupBox();
            this.FilmdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.filmTime = new System.Windows.Forms.GroupBox();
            this.filmShowTime = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.filmDate.SuspendLayout();
            this.filmTime.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 30);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Film Kayıt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filmAdi);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Location = new System.Drawing.Point(30, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(11, 3, 3, 10);
            this.groupBox1.Size = new System.Drawing.Size(518, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Adı";
            // 
            // filmAdi
            // 
            this.filmAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filmAdi.ForeColor = System.Drawing.Color.MediumPurple;
            this.filmAdi.Location = new System.Drawing.Point(11, 24);
            this.filmAdi.Name = "filmAdi";
            this.filmAdi.Size = new System.Drawing.Size(504, 27);
            this.filmAdi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filmCategory);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Location = new System.Drawing.Point(30, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.groupBox2.Size = new System.Drawing.Size(518, 74);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Film Kategori";
            // 
            // filmCategory
            // 
            this.filmCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filmCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmCategory.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.filmCategory.ForeColor = System.Drawing.Color.MediumPurple;
            this.filmCategory.FormattingEnabled = true;
            this.filmCategory.Items.AddRange(new object[] {
            "Gerilim",
            "Korku",
            "Romantik"});
            this.filmCategory.Location = new System.Drawing.Point(10, 29);
            this.filmCategory.Name = "filmCategory";
            this.filmCategory.Size = new System.Drawing.Size(505, 35);
            this.filmCategory.TabIndex = 0;
            this.filmCategory.Text = "Gerilim";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filmUrl);
            this.groupBox3.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox3.Location = new System.Drawing.Point(30, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(13, 3, 3, 13);
            this.groupBox3.Size = new System.Drawing.Size(518, 65);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Film Fotoğraf URL";
            // 
            // filmUrl
            // 
            this.filmUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmUrl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filmUrl.ForeColor = System.Drawing.Color.MediumPurple;
            this.filmUrl.Location = new System.Drawing.Point(13, 25);
            this.filmUrl.Name = "filmUrl";
            this.filmUrl.Size = new System.Drawing.Size(502, 27);
            this.filmUrl.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.filmDescription);
            this.groupBox4.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox4.Location = new System.Drawing.Point(597, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.groupBox4.Size = new System.Drawing.Size(674, 267);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Film Detayı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(510, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "(max 100 karakter)";
            // 
            // filmDescription
            // 
            this.filmDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmDescription.ForeColor = System.Drawing.Color.MediumPurple;
            this.filmDescription.Location = new System.Drawing.Point(10, 30);
            this.filmDescription.Multiline = true;
            this.filmDescription.Name = "filmDescription";
            this.filmDescription.Size = new System.Drawing.Size(661, 227);
            this.filmDescription.TabIndex = 1;
            // 
            // registerFilmBtn
            // 
            this.registerFilmBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.registerFilmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerFilmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerFilmBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F);
            this.registerFilmBtn.ForeColor = System.Drawing.Color.White;
            this.registerFilmBtn.Location = new System.Drawing.Point(597, 609);
            this.registerFilmBtn.Name = "registerFilmBtn";
            this.registerFilmBtn.Size = new System.Drawing.Size(674, 52);
            this.registerFilmBtn.TabIndex = 7;
            this.registerFilmBtn.Text = "Filmi Kaydet";
            this.registerFilmBtn.UseVisualStyleBackColor = false;
            this.registerFilmBtn.Click += new System.EventHandler(this.registerFilmBtn_Click);
            // 
            // filmDate
            // 
            this.filmDate.Controls.Add(this.FilmdateTimePicker);
            this.filmDate.ForeColor = System.Drawing.Color.MediumPurple;
            this.filmDate.Location = new System.Drawing.Point(23, 405);
            this.filmDate.Name = "filmDate";
            this.filmDate.Padding = new System.Windows.Forms.Padding(13, 3, 3, 13);
            this.filmDate.Size = new System.Drawing.Size(518, 84);
            this.filmDate.TabIndex = 4;
            this.filmDate.TabStop = false;
            this.filmDate.Text = "Film Gösterim Tarihi";
            // 
            // FilmdateTimePicker
            // 
            this.FilmdateTimePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FilmdateTimePicker.Location = new System.Drawing.Point(13, 37);
            this.FilmdateTimePicker.Name = "FilmdateTimePicker";
            this.FilmdateTimePicker.Size = new System.Drawing.Size(502, 34);
            this.FilmdateTimePicker.TabIndex = 0;
            // 
            // filmTime
            // 
            this.filmTime.Controls.Add(this.filmShowTime);
            this.filmTime.ForeColor = System.Drawing.Color.MediumPurple;
            this.filmTime.Location = new System.Drawing.Point(23, 512);
            this.filmTime.Name = "filmTime";
            this.filmTime.Padding = new System.Windows.Forms.Padding(13, 3, 3, 13);
            this.filmTime.Size = new System.Drawing.Size(518, 65);
            this.filmTime.TabIndex = 4;
            this.filmTime.TabStop = false;
            this.filmTime.Text = "Film Gösterim Saati";
            // 
            // filmShowTime
            // 
            this.filmShowTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmShowTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filmShowTime.ForeColor = System.Drawing.Color.MediumPurple;
            this.filmShowTime.Location = new System.Drawing.Point(13, 25);
            this.filmShowTime.Name = "filmShowTime";
            this.filmShowTime.Size = new System.Drawing.Size(502, 27);
            this.filmShowTime.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Crimson;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(597, 673);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(674, 52);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "İptal";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox6.Location = new System.Drawing.Point(600, 495);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.groupBox6.Size = new System.Drawing.Size(671, 74);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Salon ID";
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox2.ForeColor = System.Drawing.Color.MediumPurple;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(658, 35);
            this.comboBox2.TabIndex = 2;
            // 
            // MovieRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 759);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmTime);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.filmDate);
            this.Controls.Add(this.registerFilmBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(225, 50);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MovieRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MovieRegister";
            this.Load += new System.EventHandler(this.MovieRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.filmDate.ResumeLayout(false);
            this.filmTime.ResumeLayout(false);
            this.filmTime.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox filmAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button registerFilmBtn;
        private System.Windows.Forms.ComboBox filmCategory;
        private System.Windows.Forms.TextBox filmDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filmUrl;
        private System.Windows.Forms.GroupBox filmDate;
        private System.Windows.Forms.DateTimePicker FilmdateTimePicker;
        private System.Windows.Forms.GroupBox filmTime;
        private System.Windows.Forms.TextBox filmShowTime;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}