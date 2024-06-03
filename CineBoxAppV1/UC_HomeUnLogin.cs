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
    public partial class UC_HomeUnLogin : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True");

        public UC_HomeUnLogin()
        {
            InitializeComponent();
        }

        private void UC_HomeUnLogin_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string sorgu = "select * from Movies ORDER BY MovieImgUrl ASC";
            connection.Open();
            SqlCommand command = new SqlCommand(sorgu, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                filmselecListUnLogin fl = new filmselecListUnLogin();


                string imageUrl = reader["MovieImgUrl"].ToString();
                fl.SetImage(imageUrl);
                fl.lblIdno.Text = reader["MovieID"].ToString();

                flowLayoutPanel1.Controls.Add(fl);
            }

            connection.Close();
        }
    }
}
