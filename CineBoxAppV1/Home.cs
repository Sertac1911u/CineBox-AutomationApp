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
    public partial class Home : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV1;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            signupPanel.Show();
        }

        public Home()
        {
            InitializeComponent();
            signupPanel.Hide();
        }


        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backHomeBtn_Click(object sender, EventArgs e)
        {
            signupPanel.Hide();

        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginusernameTextBox.Text) || string.IsNullOrEmpty(loginpassTextBox.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                connection.Open();

                // Check admin credentials
                string adminQuery = "SELECT * FROM Admins WHERE userName=@username and password=@password";
                SqlCommand adminCommand = new SqlCommand(adminQuery, connection);
                adminCommand.Parameters.AddWithValue("@username", loginusernameTextBox.Text);
                adminCommand.Parameters.AddWithValue("@password", loginpassTextBox.Text);

                SqlDataReader adminReader = adminCommand.ExecuteReader();

                if (adminReader.Read())
                {
                    // If admin credentials are correct
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                    adminReader.Close();
                    return;
                }

                adminReader.Close();

                // Check user credentials
                string userQuery = "SELECT * FROM Users WHERE username=@username and password=@password";
                SqlCommand userCommand = new SqlCommand(userQuery, connection);
                userCommand.Parameters.AddWithValue("@username", loginusernameTextBox.Text);
                userCommand.Parameters.AddWithValue("@password", loginpassTextBox.Text);

                SqlDataReader userReader = userCommand.ExecuteReader();

                if (userReader.Read())
                {
                    // If user credentials are correct
                    UserPanel userPanel = new UserPanel();
                    userPanel.Show();
                    this.Hide();
                }
                else
                {
                    // If neither admin nor user credentials are correct
                    MessageBox.Show("Login Failed");
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

            // Clear login fields
            loginusernameTextBox.Text = "";
            loginpassTextBox.Text = "";
            loginusernameTextBox.Focus();
        }




        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            passTextBox.PasswordChar = '*';
        }

        private void loginpassTextBox_TextChanged_1(object sender, EventArgs e)
        {
            loginpassTextBox.PasswordChar = '*';
        }

        private void Splash_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void loginusernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupAcceptBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(lastnameTextBox.Text) ||
                string.IsNullOrEmpty(usernameTextBox.Text) ||
                string.IsNullOrEmpty(passTextBox.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
                return;
            }

            string name = nameTextBox.Text;
            string lastName = lastnameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passTextBox.Text;
            DateTime dob = dateTimePicker1.Value;

            //sql insert command
            string query = "INSERT INTO Users (Name, surname, username, password, dateofbirth) VALUES (@FirstName, @LastName, @Username, @UserPass, @DateOfBirth)";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

              
                command.Parameters.AddWithValue("@FirstName", name);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@UserPass", password);
                command.Parameters.AddWithValue("@DateOfBirth", dob);


                int result = command.ExecuteNonQuery();

                // Check if the insert was successful
                if (result > 0)
                {
                    MessageBox.Show("Registration successful!");

                    nameTextBox.Text = "";
                    lastnameTextBox.Text = "";
                    usernameTextBox.Text = "";
                    passTextBox.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    signupPanel.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
