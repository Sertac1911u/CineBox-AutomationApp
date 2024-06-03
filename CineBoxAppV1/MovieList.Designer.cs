namespace CineBoxAppV1
{
    partial class MovieList
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listpanel = new System.Windows.Forms.Panel();
            this.flowListpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.listpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(542, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "Film Listesi";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(278, 628);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(719, 52);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "Geri";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(278, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 64);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(149, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Film Adı : ";
            // 
            // listpanel
            // 
            this.listpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listpanel.Controls.Add(this.flowListpanel);
            this.listpanel.Location = new System.Drawing.Point(278, 137);
            this.listpanel.Name = "listpanel";
            this.listpanel.Size = new System.Drawing.Size(719, 454);
            this.listpanel.TabIndex = 12;
            // 
            // flowListpanel
            // 
            this.flowListpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowListpanel.Location = new System.Drawing.Point(0, 0);
            this.flowListpanel.Name = "flowListpanel";
            this.flowListpanel.Size = new System.Drawing.Size(719, 454);
            this.flowListpanel.TabIndex = 0;
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listpanel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(225, 50);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MovieList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MovieList";
            this.Load += new System.EventHandler(this.MovieList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.listpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel listpanel;
        private System.Windows.Forms.FlowLayoutPanel flowListpanel;
    }
}