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
    public partial class UserPanel : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV1;Integrated Security=True");

        public UserPanel()
        {
            InitializeComponent();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string sorgu = "select * from Movies ORDER BY MovieImgUrl ASC";
            connection.Open();
            SqlCommand command = new SqlCommand(sorgu, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                filmselectList fl = new filmselectList();
                fl.lblMovieImg.ImageLocation = reader["MovieImgUrl"].ToString();
                flowLayoutPanel1.Controls.Add(fl);
            }

            connection.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.ShowDialog();
        }
    }
}
