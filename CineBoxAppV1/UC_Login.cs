using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CineBoxAppV1
{
    public partial class UC_Login : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True");

        public UC_Login()
        {
            InitializeComponent();
        }

        public bool isLogin;
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernametextbox.Text) || string.IsNullOrEmpty(passtextBox.Text))
            {
                MessageBox.Show("Lütfen Alanları Doldurun");
                return;
            }

            try
            {
                connection.Open();
                string userQuery = "SELECT UserID FROM Users WHERE username=@username AND password=@password"; // Only select the UserID

                SqlCommand userCommand = new SqlCommand(userQuery, connection);
                userCommand.Parameters.AddWithValue("@username", usernametextbox.Text);
                userCommand.Parameters.AddWithValue("@password", passtextBox.Text);

                object result = userCommand.ExecuteScalar(); // ExecuteScalar to get a single value

                if (result != null) // Check if a result was returned
                {
                    MessageBox.Show("Giriş Başarılı");
                    isLogin = true;
                    loginedUserPanel loginedUserPanel = new loginedUserPanel();
                    loginedUserPanel.SetUsername(usernametextbox.Text,Convert.ToInt32(result));
                    loginedUserPanel.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                    isLogin = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                isLogin = false;
            }
            finally
            {
                connection.Close();
            }

            // Clear login fields
            usernametextbox.Text = "";
            passtextBox.Text = "";
            usernametextbox.Focus();
        }
    }
}
