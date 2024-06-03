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
    public partial class staffRegister : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=cineBoxAppV1;Integrated Security=True");
        public staffRegister()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerStaffBtn_Click(object sender, EventArgs e)
        {
            if (staffadi.Text == "" || staffpass.Text == "" || staffsaloonid.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
            else
            {
                string sorgu = "insert into Staff (staffUsername,staffPassword,CinemaID) VALUES (@p1,@p2,@p3)";
                connection.Open();

                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@p1", staffadi.Text.ToUpper());
                command.Parameters.AddWithValue("@p2", staffpass.Text.ToUpper());
                command.Parameters.AddWithValue("@p3", staffsaloonid.Text.ToUpper());

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Personel Eklendi");

                staffadi.Text = "";
                staffpass.Text = "";
                staffsaloonid.Text = "";
            }
        }
    }
}
