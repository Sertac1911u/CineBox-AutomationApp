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
    public partial class SelectSeat : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV2;Integrated Security=True");

        public SelectSeat()
        {
            InitializeComponent();
        }

        private void SelectSeat_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string sorgu = "SELECT * FROM Saloons ORDER BY SaloonID ASC";
            connection.Open();
            SqlCommand command = new SqlCommand(sorgu, connection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                UC_Seat uC_Seat = new UC_Seat();
               
                flowLayoutPanel1.Controls.Add(uC_Seat);
            }
            connection.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
