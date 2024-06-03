using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CineBoxAppV1
{
    public partial class UC_Ticket_Logined : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True");

        public UC_Ticket_Logined()
        {
            InitializeComponent();
        }

        private void UC_Ticket_Logined_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            string filePath = "userID.txt";
            string userIDString = "0";
            try
            {
                // Read the contents of the file
                userIDString = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during file reading
                Console.WriteLine("Error reading user ID from file: " + ex.Message);
            }

            // Convert userIDString to integer
            int userId;
            if (!int.TryParse(userIDString, out userId))
            {
                MessageBox.Show("Invalid user ID. Please check the userID.txt file.");
                return;
            }

            string sorgu = "SELECT * FROM Tickets WHERE UserID = @userId";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@userId", userId); // Use the integer userId
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    mytickets mytickets = new mytickets();
                    mytickets.lblticketno.Text = reader["TicketNo"].ToString();
                    mytickets.lblticketfilm.Text = reader["MovieName"].ToString();
                    mytickets.lblticketseatnumber.Text = reader["SeatNo"].ToString();
                    mytickets.lblticketseansdate.Text = reader["TicketDate"].ToString();
                    mytickets.lblticketseanstime.Text = reader["TicketTime"].ToString();
                    flowLayoutPanel1.Controls.Add(mytickets);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                connection.Close();
            }
        }
    }
}
