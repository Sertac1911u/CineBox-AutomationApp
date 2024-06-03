namespace CineBoxAppV1
{
    partial class Home
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
            this.Splash = new System.Windows.Forms.Panel();
            this.UIElementPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loginpassTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginusernameTextBox = new System.Windows.Forms.TextBox();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.exitApp = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.descLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.signupPanel = new System.Windows.Forms.Panel();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.backHomeBtn = new System.Windows.Forms.Button();
            this.signupAcceptBtn = new System.Windows.Forms.Button();
            this.birthLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.signupHeader = new System.Windows.Forms.Label();
            this.UIElementPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.signupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Splash
            // 
            this.Splash.BackColor = System.Drawing.Color.MediumPurple;
            this.Splash.Dock = System.Windows.Forms.DockStyle.Left;
            this.Splash.Location = new System.Drawing.Point(0, 0);
            this.Splash.Name = "Splash";
            this.Splash.Size = new System.Drawing.Size(300, 600);
            this.Splash.TabIndex = 0;
            this.Splash.Paint += new System.Windows.Forms.PaintEventHandler(this.Splash_Paint);
            // 
            // UIElementPanel
            // 
            this.UIElementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UIElementPanel.BackColor = System.Drawing.Color.White;
            this.UIElementPanel.Controls.Add(this.groupBox2);
            this.UIElementPanel.Controls.Add(this.groupBox1);
            this.UIElementPanel.Controls.Add(this.signUpBtn);
            this.UIElementPanel.Controls.Add(this.exitApp);
            this.UIElementPanel.Controls.Add(this.loginBtn);
            this.UIElementPanel.Controls.Add(this.descLabel);
            this.UIElementPanel.Controls.Add(this.welcomeLabel);
            this.UIElementPanel.Location = new System.Drawing.Point(306, 15);
            this.UIElementPanel.Name = "UIElementPanel";
            this.UIElementPanel.Size = new System.Drawing.Size(621, 600);
            this.UIElementPanel.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loginpassTextBox);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Location = new System.Drawing.Point(165, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 75);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parola";
            // 
            // loginpassTextBox
            // 
            this.loginpassTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginpassTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F);
            this.loginpassTextBox.ForeColor = System.Drawing.Color.MediumPurple;
            this.loginpassTextBox.Location = new System.Drawing.Point(3, 37);
            this.loginpassTextBox.Multiline = true;
            this.loginpassTextBox.Name = "loginpassTextBox";
            this.loginpassTextBox.PasswordChar = '*';
            this.loginpassTextBox.Size = new System.Drawing.Size(299, 35);
            this.loginpassTextBox.TabIndex = 12;
            this.loginpassTextBox.TextChanged += new System.EventHandler(this.loginpassTextBox_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginusernameTextBox);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Location = new System.Drawing.Point(165, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 81);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email";
            // 
            // loginusernameTextBox
            // 
            this.loginusernameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginusernameTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F);
            this.loginusernameTextBox.ForeColor = System.Drawing.Color.MediumPurple;
            this.loginusernameTextBox.Location = new System.Drawing.Point(3, 43);
            this.loginusernameTextBox.Multiline = true;
            this.loginusernameTextBox.Name = "loginusernameTextBox";
            this.loginusernameTextBox.Size = new System.Drawing.Size(299, 35);
            this.loginusernameTextBox.TabIndex = 10;
            this.loginusernameTextBox.TextChanged += new System.EventHandler(this.loginusernameTextBox_TextChanged);
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.2F);
            this.signUpBtn.ForeColor = System.Drawing.Color.White;
            this.signUpBtn.Location = new System.Drawing.Point(34, 510);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(178, 44);
            this.signUpBtn.TabIndex = 4;
            this.signUpBtn.Text = "Üye Ol";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitApp
            // 
            this.exitApp.BackColor = System.Drawing.Color.White;
            this.exitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitApp.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.exitApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitApp.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.2F);
            this.exitApp.ForeColor = System.Drawing.Color.MediumPurple;
            this.exitApp.Location = new System.Drawing.Point(410, 510);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(178, 44);
            this.exitApp.TabIndex = 3;
            this.exitApp.Text = "Çıkış Yap";
            this.exitApp.UseVisualStyleBackColor = false;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.2F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(222, 363);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(178, 44);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Giriş Yap";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click_1);
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.BackColor = System.Drawing.Color.White;
            this.descLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F);
            this.descLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.descLabel.Location = new System.Drawing.Point(94, 68);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(479, 36);
            this.descLabel.TabIndex = 1;
            this.descLabel.Text = "Yapay Zeka Destekli Sinema Uygulaması";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.White;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F);
            this.welcomeLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.welcomeLabel.Location = new System.Drawing.Point(193, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(239, 53);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Hoş Geldiniz";
            // 
            // signupPanel
            // 
            this.signupPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.signupPanel.BackColor = System.Drawing.Color.White;
            this.signupPanel.Controls.Add(this.passTextBox);
            this.signupPanel.Controls.Add(this.dateTimePicker1);
            this.signupPanel.Controls.Add(this.usernameTextBox);
            this.signupPanel.Controls.Add(this.lastnameTextBox);
            this.signupPanel.Controls.Add(this.nameTextBox);
            this.signupPanel.Controls.Add(this.backHomeBtn);
            this.signupPanel.Controls.Add(this.signupAcceptBtn);
            this.signupPanel.Controls.Add(this.birthLabel);
            this.signupPanel.Controls.Add(this.passLabel);
            this.signupPanel.Controls.Add(this.usernameLabel);
            this.signupPanel.Controls.Add(this.lastnameLabel);
            this.signupPanel.Controls.Add(this.nameLabel);
            this.signupPanel.Controls.Add(this.signupHeader);
            this.signupPanel.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.4F);
            this.signupPanel.ForeColor = System.Drawing.Color.MediumPurple;
            this.signupPanel.Location = new System.Drawing.Point(309, 0);
            this.signupPanel.Name = "signupPanel";
            this.signupPanel.Size = new System.Drawing.Size(632, 600);
            this.signupPanel.TabIndex = 10;
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.4F);
            this.passTextBox.ForeColor = System.Drawing.Color.MediumPurple;
            this.passTextBox.Location = new System.Drawing.Point(28, 352);
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(363, 35);
            this.passTextBox.TabIndex = 10;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 453);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(363, 37);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.4F);
            this.usernameTextBox.ForeColor = System.Drawing.Color.MediumPurple;
            this.usernameTextBox.Location = new System.Drawing.Point(28, 253);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(363, 35);
            this.usernameTextBox.TabIndex = 11;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.4F);
            this.lastnameTextBox.ForeColor = System.Drawing.Color.MediumPurple;
            this.lastnameTextBox.Location = new System.Drawing.Point(318, 149);
            this.lastnameTextBox.Multiline = true;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(250, 35);
            this.lastnameTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.4F);
            this.nameTextBox.ForeColor = System.Drawing.Color.MediumPurple;
            this.nameTextBox.Location = new System.Drawing.Point(28, 149);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(250, 35);
            this.nameTextBox.TabIndex = 8;
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
            this.backHomeBtn.Location = new System.Drawing.Point(125, 529);
            this.backHomeBtn.Name = "backHomeBtn";
            this.backHomeBtn.Size = new System.Drawing.Size(160, 40);
            this.backHomeBtn.TabIndex = 7;
            this.backHomeBtn.Text = "Geri Dön";
            this.backHomeBtn.UseVisualStyleBackColor = false;
            this.backHomeBtn.Click += new System.EventHandler(this.backHomeBtn_Click);
            // 
            // signupAcceptBtn
            // 
            this.signupAcceptBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.signupAcceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupAcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupAcceptBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F);
            this.signupAcceptBtn.ForeColor = System.Drawing.Color.White;
            this.signupAcceptBtn.Location = new System.Drawing.Point(386, 529);
            this.signupAcceptBtn.Name = "signupAcceptBtn";
            this.signupAcceptBtn.Size = new System.Drawing.Size(160, 40);
            this.signupAcceptBtn.TabIndex = 6;
            this.signupAcceptBtn.Text = "Üye Ol";
            this.signupAcceptBtn.UseVisualStyleBackColor = false;
            this.signupAcceptBtn.Click += new System.EventHandler(this.signupAcceptBtn_Click);
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F);
            this.birthLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.birthLabel.Location = new System.Drawing.Point(22, 417);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(171, 33);
            this.birthLabel.TabIndex = 5;
            this.birthLabel.Text = "Doğum Tarihi :";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F);
            this.passLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.passLabel.Location = new System.Drawing.Point(22, 309);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(93, 33);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Parola :";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F);
            this.usernameLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.usernameLabel.Location = new System.Drawing.Point(22, 214);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(190, 33);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Kullanıcı Adınız :";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F);
            this.lastnameLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.lastnameLabel.Location = new System.Drawing.Point(312, 113);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(131, 33);
            this.lastnameLabel.TabIndex = 2;
            this.lastnameLabel.Text = "Soyadınız :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F);
            this.nameLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.nameLabel.Location = new System.Drawing.Point(22, 113);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 33);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Adınız :";
            // 
            // signupHeader
            // 
            this.signupHeader.AutoSize = true;
            this.signupHeader.BackColor = System.Drawing.Color.White;
            this.signupHeader.Font = new System.Drawing.Font("Segoe UI Variable Display", 17.4F);
            this.signupHeader.ForeColor = System.Drawing.Color.MediumPurple;
            this.signupHeader.Location = new System.Drawing.Point(173, 38);
            this.signupHeader.Name = "signupHeader";
            this.signupHeader.Size = new System.Drawing.Size(373, 38);
            this.signupHeader.TabIndex = 0;
            this.signupHeader.Text = "Üyelik Bilgilerini Doldurunuz";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.signupPanel);
            this.Controls.Add(this.UIElementPanel);
            this.Controls.Add(this.Splash);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.UIElementPanel.ResumeLayout(false);
            this.UIElementPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.signupPanel.ResumeLayout(false);
            this.signupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Splash;
        private System.Windows.Forms.Panel UIElementPanel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.Panel signupPanel;
        private System.Windows.Forms.Label signupHeader;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button backHomeBtn;
        private System.Windows.Forms.Button signupAcceptBtn;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox loginusernameTextBox;
        private System.Windows.Forms.TextBox loginpassTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

