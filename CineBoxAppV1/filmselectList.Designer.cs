namespace CineBoxAppV1
{
    partial class filmselectList
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
            this.lblMovieImg = new System.Windows.Forms.PictureBox();
            this.filmDetail = new System.Windows.Forms.Button();
            this.lblIdno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblMovieImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovieImg
            // 
            this.lblMovieImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblMovieImg.Location = new System.Drawing.Point(3, 3);
            this.lblMovieImg.Name = "lblMovieImg";
            this.lblMovieImg.Size = new System.Drawing.Size(194, 270);
            this.lblMovieImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblMovieImg.TabIndex = 16;
            this.lblMovieImg.TabStop = false;
            // 
            // filmDetail
            // 
            this.filmDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(20)))));
            this.filmDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filmDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmDetail.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F);
            this.filmDetail.ForeColor = System.Drawing.Color.White;
            this.filmDetail.Location = new System.Drawing.Point(35, 279);
            this.filmDetail.Name = "filmDetail";
            this.filmDetail.Size = new System.Drawing.Size(130, 40);
            this.filmDetail.TabIndex = 15;
            this.filmDetail.Text = "Detay";
            this.filmDetail.UseVisualStyleBackColor = false;
            this.filmDetail.Click += new System.EventHandler(this.filmDetail_Click_1);
            // 
            // lblIdno
            // 
            this.lblIdno.AutoSize = true;
            this.lblIdno.BackColor = System.Drawing.Color.White;
            this.lblIdno.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdno.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblIdno.Location = new System.Drawing.Point(31, 238);
            this.lblIdno.Name = "lblIdno";
            this.lblIdno.Size = new System.Drawing.Size(17, 22);
            this.lblIdno.TabIndex = 17;
            this.lblIdno.Text = "1";
            this.lblIdno.Visible = false;
            // 
            // filmselectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIdno);
            this.Controls.Add(this.lblMovieImg);
            this.Controls.Add(this.filmDetail);
            this.Name = "filmselectList";
            this.Size = new System.Drawing.Size(219, 341);
            ((System.ComponentModel.ISupportInitialize)(this.lblMovieImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox lblMovieImg;
        public System.Windows.Forms.Label lblIdno;
        public System.Windows.Forms.Button filmDetail;
    }
}
