using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CineBoxAppV1
{
    public partial class FilmDetay_UC : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True");

        public FilmDetay_UC()
        {
            InitializeComponent();
        }

        public string idNo = "";
     

        private void FilmDetay_UC_Load(object sender, EventArgs e)
        {

            string sorgu = "SELECT * FROM Movies WHERE MovieID=@p1";

            connection.Open();
            SqlCommand command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                seansSelect.Items.Add(reader["SaloonID"].ToString());
                lblFilmAdi.Text = reader["MovieName"].ToString();
                filmNamelbl.Text = reader["MovieName"].ToString();
                lblMovieImg.ImageLocation = reader["MovieImgUrl"].ToString();

            }

            reader.Close();
            connection.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                guna2CheckBox2.Checked = false;
            }
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                guna2CheckBox1.Checked = false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            
            if (string.IsNullOrEmpty(seansSelect.Text))
            {
                MessageBox.Show("Please select a Saloon ID.");
                return;
            }

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True";
            string sorgu2 = "SELECT NumberOfSeat FROM Saloons WHERE SaloonID=@saloonID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command2 = new SqlCommand(sorgu2, connection);
                    command2.Parameters.AddWithValue("@saloonID", seansSelect.Text);
                    SqlDataReader reader2 = command2.ExecuteReader();

                    if (reader2.Read())
                    {
                        flowLayoutPanel1.Controls.Clear();
                        int sayi = reader2.GetInt32(0); // Get the number of seats from the reader

                        for (int i = 1; i <= sayi; i++)
                        {
                            Button btn = new Button
                            {
                                Size = new Size(50, 50),
                                FlatStyle = FlatStyle.Flat,
                                FlatAppearance = { BorderSize = 0 },
                                Font = new Font("Segoe UI Variable", 13),
                            };

                            // Determine the row and seat number
                            string row = "";
                            int seatNumber = (i - 1) % 6 + 1;  // Seat numbers from 1 to 6 in each row

                            if (i <= 6)
                            {
                                row = "A";
                            }
                            else if (i <= 12)
                            {
                                row = "B";
                            }
                            else if (i <= 18)
                            {
                                row = "C";
                            }
                            else if (i <= 24)
                            {
                                row = "D";
                            }
                            else if (i <= 30)
                            {
                                row = "E";
                            }
                            else if (i <= 36)
                            {
                                row = "F";
                            }
                            else if (i <= 42)
                            {
                                row = "G";
                            }
                            else if (i <= 48)
                            {
                                row = "H";
                            }

                            btn.Text = row + seatNumber.ToString();
                            btn.Name = row + seatNumber.ToString();
                            btn.BackColor = Color.Green; // Default color for available seats
                            btn.ForeColor = Color.FromArgb(238, 238, 238);
                            btn.Click += Btn_Click;

                            flowLayoutPanel1.Controls.Add(btn);
                        }
                    }

                    reader2.Close();
                    connection.Close();
                    seatBring(); // Fetch and update seat statuses
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void seatBring()
        {
            koltuklbl.Text = "";
            string sorgu2 = "SELECT seciliKoltuklar FROM Saloons WHERE SaloonID=@saloonID";

            connection.Open();
            SqlCommand command2 = new SqlCommand(sorgu2, connection);
            command2.Parameters.AddWithValue("@saloonID", seansSelect.Text);

            SqlDataReader reader2 = command2.ExecuteReader();

            if (reader2.Read())
            {
                koltuklbl.Text = reader2["seciliKoltuklar"].ToString();
            }

            reader2.Close();
            connection.Close();

            koltukAyırma(); // Fetch and update seat statuses based on fetched data
        }

        private void koltukAyırma()
        {
            if (string.IsNullOrEmpty(koltuklbl.Text))
                return;

            string[] selectedSeats = koltuklbl.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Button btn && selectedSeats.Contains(btn.Text))
                {
                    btn.BackColor = Color.Red;
                }
            }
        }

        private Button selectedButton = null;

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Green)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.Green; // Deselect the previously selected seat
                }
                btn.BackColor = Color.Yellow; // Mark as selected
                selectedButton = btn; // Update the selected button
                MessageBox.Show("Seçtiğiniz koltuk: " + btn.Text);
            }
            else if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.Green; // Deselect the seat
                selectedButton = null; // Clear the selected button
            }
            else if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Bu koltuk dolu veya reserve");
            }
        }

        private void seansSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatBring(); // Fetch and update seat statuses when Saloon ID changes
        }

        private void biletAl_Click(object sender, EventArgs e)
        {
            if (selectedButton == null)
            {
                MessageBox.Show("Please select a seat.");
                return;
            }

            if (string.IsNullOrEmpty(namesurnametextbox.Text))
            {
                MessageBox.Show("Please enter your name and surname.");
                return;
            }

            if (!guna2CheckBox1.Checked && !guna2CheckBox2.Checked)
            {
                MessageBox.Show("Please select a ticket type.");
                return;
            }

            string ticketType = guna2CheckBox1.Checked ? "Full" : "Student";
            string ticketNo = Guid.NewGuid().ToString().Substring(0, 10); // Generate a random 10-character ticket number
            DateTime now = DateTime.Now;

            string movieName = lblFilmAdi.Text; // Assuming this is where the movie name is stored
            string saloonID = seansSelect.Text;
            string seatNo = selectedButton.Text;

            string insertTicketQuery = @"
                INSERT INTO Tickets (SaloonID, isReserved, TicketDetail, MovieName, TicketNo, SeatNo, TicketDate, TicketTime, CustomerType, NameSurname, ProcessTime,UserID)
                VALUES (@SaloonID, @isReserved, @TicketDetail, @MovieName, @TicketNo, @SeatNo, @TicketDate, @TicketTime, @CustomerType, @NameSurname, @ProcessTime,@UserID)";

            string updateSaloonQuery = "UPDATE Saloons SET seciliKoltuklar = seciliKoltuklar +@SeatNo + ',' WHERE SaloonID = @SaloonID";

            string filePath = "userID.txt";
            string userIDString = "0";
            try
            {
                // Read the contents of the file
                userIDString = File.ReadAllText(filePath);

                // Return the contents as a string
                
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during file reading
                Console.WriteLine("Error reading user ID from file: " + ex.Message);
                // Return null or an empty string depending on your error handling logic
            }
            using (SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlCommand insertCommand = new SqlCommand(insertTicketQuery, connection);
                    insertCommand.Parameters.AddWithValue("@SaloonID", saloonID);
                    insertCommand.Parameters.AddWithValue("@isReserved", true);
                    insertCommand.Parameters.AddWithValue("@TicketDetail", $"{movieName} - {ticketType}");
                    insertCommand.Parameters.AddWithValue("@MovieName", movieName);
                    insertCommand.Parameters.AddWithValue("@TicketNo", ticketNo);
                    insertCommand.Parameters.AddWithValue("@SeatNo", seatNo);
                    insertCommand.Parameters.AddWithValue("@TicketDate", now.Date);
                    insertCommand.Parameters.AddWithValue("@TicketTime", now.TimeOfDay);
                    insertCommand.Parameters.AddWithValue("@CustomerType", ticketType);
                    insertCommand.Parameters.AddWithValue("@NameSurname", namesurnametextbox.Text);
                    insertCommand.Parameters.AddWithValue("@ProcessTime", now);
                    loginedUserPanel loginedUserPanel = new loginedUserPanel();
                    insertCommand.Parameters.AddWithValue("@UserID", Convert.ToInt32(userIDString));

                    insertCommand.ExecuteNonQuery();

                    SqlCommand updateCommand = new SqlCommand(updateSaloonQuery, connection);

                    updateCommand.Parameters.AddWithValue("@SeatNo", seatNo);
                    updateCommand.Parameters.AddWithValue("@SaloonID", saloonID);

                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("Ticket purchased successfully!");
                    selectedButton.BackColor = Color.Red; // Mark the seat as reserved
                    selectedButton = null; // Clear the selected button

                    seatBring(); // Refresh seat statuses
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
