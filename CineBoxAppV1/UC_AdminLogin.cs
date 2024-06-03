using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineBoxAppV1
{
    public partial class UC_AdminLogin : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV1;Integrated Security=True");

        public UC_AdminLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(usernameTextbox.Text) || string.IsNullOrEmpty(passTextBox.Text))
            {
                MessageBox.Show("Lütfen Alanları Doldurun");
                return;
            }

            try
            {
                connection.Open();
                string userQuery = "SELECT * FROM Admins WHERE userName=@username and password=@password";
                SqlCommand userCommand = new SqlCommand(userQuery, connection);
                userCommand.Parameters.AddWithValue("@username", usernameTextbox.Text);
                userCommand.Parameters.AddWithValue("@password", passTextBox.Text);

                SqlDataReader userReader = userCommand.ExecuteReader();

                if(userReader.Read())
                {
                    MessageBox.Show("Giriş Başarılı");
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
                userReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            usernameTextbox.Text = "";
            passTextBox.Text = "";
            usernameTextbox.Focus();
        }
    }
}
