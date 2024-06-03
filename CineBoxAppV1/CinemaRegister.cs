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
    public partial class CinemaRegister : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True");

        public CinemaRegister()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerCinemaBtn_Click(object sender, EventArgs e)
        {
            if(cinemaName.Text == "" || cinemaCity.Text == "" || cinemaDistrict.Text == "" || cinemaAdress.Text == "" || adminId.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
            else
            {
                string sorgu = "insert into Cinemas (CinemaName,CinemaCity,CinemaDistrict,CinemaAddress) VALUES (@p1,@p2,@p3,@p4)";
                connection.Open();

                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@p1", cinemaName.Text.ToUpper());
                command.Parameters.AddWithValue("@p2", cinemaCity.Text.ToUpper());
                command.Parameters.AddWithValue("@p3", cinemaDistrict.Text.ToUpper());
                command.Parameters.AddWithValue("@p4", cinemaAdress.Text.ToUpper());
                command.ExecuteNonQuery();
                
                connection.Close();
                MessageBox.Show("Sinema Eklendi");

                cinemaName.Text = "";
                cinemaCity.Text = "";
                cinemaDistrict.Text = "";
                cinemaAdress.Text = "";

            }
        }

        private void CinemaRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
