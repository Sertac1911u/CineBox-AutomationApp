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
    public partial class MovieDetail : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True");
        public MovieDetail()
        {
            InitializeComponent();
        }
        public string idNo = "";
        private void MovieDetail_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from Movies where MovieID=@p1";
            connection.Open();
            SqlCommand command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                lblMovieImg.ImageLocation = reader["MovieImgUrl"].ToString();
                lblFilmAdi.Text = reader["MovieName"].ToString();
                lblFilmKategori.Text = reader["MovieType"].ToString();
                lblFilmTarih.Text = reader["VisionDate"].ToString();
                lblFilmSaati.Text = reader["ShowTime"].ToString();
                lblFilmSalonId.Text = reader["SaloonID"].ToString();
                lblFilmDetay.Text = reader["MovieDetail"].ToString();

            }

            connection.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
