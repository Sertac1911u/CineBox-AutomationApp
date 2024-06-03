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
    public partial class Ticket : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV1;Integrated Security=True");

        public Ticket()
        {
            InitializeComponent();
        }

        private void backHomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string sorgu = "select * from Tickets ORDER BY TicketID ASC";
            connection.Open();
            SqlCommand command = new SqlCommand(sorgu, connection); 
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                mytickets mt = new mytickets();
                mt.lblticketno.Text = reader["tickedNo"].ToString();
                mt.lblticketfilm.Text = reader["MovieName"].ToString();
                mt.lblticketseatnumber.Text = reader["seatNo"].ToString();
                mt.lblticketseansdate.Text = reader["tickedDate"].ToString();
                mt.lblticketseanstime.Text = reader["tickedTime"].ToString();
            }
            connection.Close();
        }
    }
}
