using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CineBoxAppV1
{
    public partial class MovieRegister : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True");
        Dictionary<string, int> saloonDict = new Dictionary<string, int>();

        public MovieRegister()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                private void registerFilmBtn_Click(object sender, EventArgs e)
                {
                    if (filmAdi.Text == "" || filmCategory.Text == "" || filmUrl.Text == "" || filmDescription.Text == "" || filmShowTime.Text == "")
                    {
                        MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                    }
                    else
                    {
                        DateTime selectedDate = FilmdateTimePicker.Value.Date;

                        if (selectedDate <= DateTime.Now)
                        {
                            MessageBox.Show("Geçmiş Tarihe Film Eklenemez");
                            return;
                        }

                        if (comboBox2.SelectedItem != null && saloonDict.TryGetValue(comboBox2.SelectedItem.ToString(), out int saloonID))
                        {
                            string sorgu = "INSERT INTO Movies (MovieName, MovieType, MovieImgUrl, MovieDetail, VisionDate, ShowTime, SaloonID) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
                            connection.Open();

                            SqlCommand command = new SqlCommand(sorgu, connection);
                            command.Parameters.AddWithValue("@p1", filmAdi.Text.ToUpper());
                            command.Parameters.AddWithValue("@p2", filmCategory.Text.ToUpper());
                            command.Parameters.AddWithValue("@p3", filmUrl.Text);
                            command.Parameters.AddWithValue("@p4", filmDescription.Text.ToUpper());
                            command.Parameters.AddWithValue("@p5", selectedDate);
                            command.Parameters.AddWithValue("@p6", filmShowTime.Text);
                            command.Parameters.AddWithValue("@p7", saloonID);

                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Film Kaydı Başarılı");

                            // Temizleme işlemleri
                            filmAdi.Text = "";
                            filmCategory.Text = "";
                            filmUrl.Text = "";
                            filmDescription.Text = "";
                            filmShowTime.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Lütfen geçerli bir Salon seçiniz.");
                        }
                    }
                }


        private void MovieRegister_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select * from Saloons";
            connection.Open();
            SqlCommand command2 = new SqlCommand(sorgu2, connection);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                int saloonID = reader2.GetInt32(0);
                string saloonName = reader2.GetString(1);
                comboBox2.Items.Add(saloonName);
                saloonDict[saloonName] = saloonID;
            }
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            saloonDict.Clear();
            string sorgu3 = "select * from Saloons where CinemaID = @p1";
            connection.Open();
            SqlCommand command3 = new SqlCommand(sorgu3, connection);
            command3.Parameters.AddWithValue("@p1", comboBox2.SelectedValue); // Assuming comboBox1 contains Cinema IDs
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                int saloonID = reader3.GetInt32(0);
                string saloonName = reader3.GetString(1);
                comboBox2.Items.Add(saloonName);
                saloonDict[saloonName] = saloonID;
            }
            connection.Close();
        }
    }
}
