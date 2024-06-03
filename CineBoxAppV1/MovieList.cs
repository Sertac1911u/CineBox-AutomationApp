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
    public partial class MovieList : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True");

        public MovieList()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MovieList_Load(object sender, EventArgs e)
        {
            flowListpanel.Controls.Clear();
            string sorgu = "select * from Movies ORDER BY MovieImgUrl ASC";
            connection.Open();
            SqlCommand command = new SqlCommand(sorgu, connection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                filmListesi fl = new filmListesi();
                fl.lblFilmAdı.Text = reader["MovieName"].ToString();
                fl.lblIdno.Text = reader["MovieID"].ToString();
                fl.lblMovieImg.ImageLocation = reader["MovieImgUrl"].ToString();
                flowListpanel.Controls.Add(fl);
            }

            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowListpanel.Controls.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Movies Where MovieName Like '%"+textBox1.Text+"%' collate Turkish_CI_AS ORDER BY MovieName ASC", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                filmListesi fl = new filmListesi();
                fl.lblFilmAdı.Text = reader["MovieName"].ToString();
                fl.lblIdno.Text = reader["MovieID"].ToString();
                fl.lblMovieImg.ImageLocation = reader["MovieImgUrl"].ToString();
                flowListpanel.Controls.Add(fl);
            }

            connection.Close();
        }
    }
}
