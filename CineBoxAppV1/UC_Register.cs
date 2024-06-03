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
    public partial class UC_Register : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True");

        public UC_Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nametextBox.Text) ||
                string.IsNullOrEmpty(surnametextBox.Text) ||
                string.IsNullOrEmpty(epostatextBox.Text) ||
                string.IsNullOrEmpty(passtextBox.Text) ||
                string.IsNullOrEmpty(usernametextBox.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
                return;
            }

            string name = nametextBox.Text;
            string lastName = surnametextBox.Text;
            string username = usernametextBox.Text;
            string email = epostatextBox.Text;
            string password = passtextBox.Text;
            DateTime dob = datatimePicker.Value;

            string query = "INSERT INTO Users (Name, surname, username, password, dateofbirth,eMail) VALUES (@FirstName, @LastName, @Username, @UserPass, @DateOfBirth,@email)";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("@FirstName", name);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@UserPass", password);
                command.Parameters.AddWithValue("@DateOfBirth", dob);
                command.Parameters.AddWithValue("@email", email);


                int result = command.ExecuteNonQuery();

                // Check if the insert was successful
                if (result > 0)
                {
                    MessageBox.Show("Registration successful!");

                    nametextBox.Text = "";
                    surnametextBox.Text = "";
                    usernametextBox.Text = "";
                    passtextBox.Text = "";
                    epostatextBox.Text = "";
                    datatimePicker.Value = DateTime.Now;
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
