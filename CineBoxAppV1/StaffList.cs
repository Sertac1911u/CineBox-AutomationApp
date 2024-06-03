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
    public partial class StaffList : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV1;Integrated Security=True");

        public StaffList()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            flowListpanel.Controls.Clear();
            string sorgu = "select * from Staff ORDER BY StaffID ASC";
            connection.Open();
            SqlCommand command = new SqlCommand(sorgu, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                staffListesi sl = new staffListesi();
                sl.lblStaffusername.Text = reader["staffUsername"].ToString();
                sl.lblStaffpass.Text = reader["staffPassword"].ToString();
                sl.lblStaffSalonId.Text = reader["CinemaID"].ToString();
                flowListpanel.Controls.Add(sl);
            }
            connection.Close();
        }
    }
}
