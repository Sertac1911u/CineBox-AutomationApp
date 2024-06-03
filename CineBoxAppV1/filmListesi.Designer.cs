namespace CineBoxAppV1
{
    partial class filmListesi
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
            this.registerFilmBtn = new System.Windows.Forms.Button();
            this.lblFilmAdı = new System.Windows.Forms.Label();
            this.lblMovieImg = new System.Windows.Forms.PictureBox();
            this.lblIdno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblMovieImg)).BeginInit();
            this.SuspendLayout();
            // 
            // registerFilmBtn
            // 
            this.registerFilmBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.registerFilmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerFilmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerFilmBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F);
            this.registerFilmBtn.ForeColor = System.Drawing.Color.White;
            this.registerFilmBtn.Location = new System.Drawing.Point(23, 205);
            this.registerFilmBtn.Name = "registerFilmBtn";
            this.registerFilmBtn.Size = new System.Drawing.Size(130, 40);
            this.registerFilmBtn.TabIndex = 8;
            this.registerFilmBtn.Text = "Detay";
            this.registerFilmBtn.UseVisualStyleBackColor = false;
            this.registerFilmBtn.Click += new System.EventHandler(this.registerFilmBtn_Click);
            // 
            // lblFilmAdı
            // 
            this.lblFilmAdı.AutoSize = true;
            this.lblFilmAdı.BackColor = System.Drawing.Color.White;
            this.lblFilmAdı.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold);
            this.lblFilmAdı.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblFilmAdı.Location = new System.Drawing.Point(18, 2);
            this.lblFilmAdı.Name = "lblFilmAdı";
            this.lblFilmAdı.Size = new System.Drawing.Size(66, 27);
            this.lblFilmAdı.TabIndex = 9;
            this.lblFilmAdı.Text = "THOR";
            // 
            // lblMovieImg
            // 
            this.lblMovieImg.Location = new System.Drawing.Point(23, 34);
            this.lblMovieImg.Name = "lblMovieImg";
            this.lblMovieImg.Size = new System.Drawing.Size(130, 165);
            this.lblMovieImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblMovieImg.TabIndex = 10;
            this.lblMovieImg.TabStop = false;
            // 
            // lblIdno
            // 
            this.lblIdno.AutoSize = true;
            this.lblIdno.BackColor = System.Drawing.Color.White;
            this.lblIdno.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdno.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblIdno.Location = new System.Drawing.Point(19, 177);
            this.lblIdno.Name = "lblIdno";
            this.lblIdno.Size = new System.Drawing.Size(57, 22);
            this.lblIdno.TabIndex = 11;
            this.lblIdno.Text = "THOR";
            // 
            // filmListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblIdno);
            this.Controls.Add(this.lblMovieImg);
            this.Controls.Add(this.lblFilmAdı);
            this.Controls.Add(this.registerFilmBtn);
            this.Name = "filmListesi";
            this.Size = new System.Drawing.Size(175, 250);
            ((System.ComponentModel.ISupportInitialize)(this.lblMovieImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registerFilmBtn;
        public System.Windows.Forms.Label lblFilmAdı;
        public System.Windows.Forms.PictureBox lblMovieImg;
        public System.Windows.Forms.Label lblIdno;
    }
}
