using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineBoxAppV1
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filmAddButton_Click(object sender, EventArgs e)
        {
            MovieRegister movieRegister = new MovieRegister();
            movieRegister.ShowDialog();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void saloonAddButton_Click(object sender, EventArgs e)
        {
            SaloonRegister saloonRegister = new SaloonRegister();
            saloonRegister.ShowDialog();
        }

        private void cinemaAddButton_Click(object sender, EventArgs e)
        {
            CinemaRegister cinemaRegister = new CinemaRegister();
            cinemaRegister.ShowDialog();
        }

        private void filmList_Click(object sender, EventArgs e)
        {
            MovieList movieList = new MovieList();
            movieList.ShowDialog();
        }

        private void addStaff_Click(object sender, EventArgs e)
        {
            staffRegister staffRegister = new staffRegister();
            staffRegister.ShowDialog();
        }

        private void staffList_Click(object sender, EventArgs e)
        {
            StaffList staffList = new StaffList();
            staffList.ShowDialog();
        }
    }
}
