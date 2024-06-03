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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CineBoxAppV1
{
    public partial class SaloonRegister : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True");

        public SaloonRegister()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerFilmBtn_Click(object sender, EventArgs e)
        {
            if (salonAdi.Text == "" || saloonCapacity.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
            else
            {
                // CinemaID'nin ComboBox'dan int olarak alınması
                if (int.TryParse(cinemaIDCom.SelectedItem.ToString(), out int cinemaID))
                {
                    string sorgu = "INSERT INTO Saloons (SaloonName, CinemaID, NumberOfSeat,seciliKoltuklar) VALUES (@p1, @p2, @p3,@p4)";
                    connection.Open();

                    SqlCommand command = new SqlCommand(sorgu, connection);
                    command.Parameters.AddWithValue("@p1", salonAdi.Text.ToUpper());

                    // CinemaID integer olarak ekleniyor
                    command.Parameters.AddWithValue("@p2", cinemaID);

                    command.Parameters.AddWithValue("p4", "A1");
                    // SaloonCapacity integer olarak ekleniyor
                    if (int.TryParse(saloonCapacity.Text, out int capacity))
                    {
                        command.Parameters.AddWithValue("@p3", capacity);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Salon Eklendi");

                        // Temizleme işlemleri
                        saloonCapacity.Text = "";
                        salonAdi.Text = "";
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Lütfen Geçerli Bir Kapasite Değeri Giriniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Geçerli Bir CinemaID Seçiniz.");
                }
            }
        }

        private void SaloonRegister_Load(object sender, EventArgs e)
        {
            string sorgu2 = "SELECT CinemaID, CinemaName FROM Cinemas";
            connection.Open();
            SqlCommand command2 = new SqlCommand(sorgu2, connection);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                int cinemaID = reader2.GetInt32(0); // CinemaID'yi çekiyoruz
                string saloonName = reader2.GetString(1); // SaloonName'i çekiyoruz
                cinemaIDCom.Items.Add(cinemaID); // Burada ComboBox'ın ismini düzeltin
            }
            connection.Close();
        }
    }
}
