using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineBoxAppV1
{
    public partial class filmListesi : UserControl
    {
        public filmListesi()
        {
            InitializeComponent();
        }

        private void registerFilmBtn_Click(object sender, EventArgs e)
        {
            MovieDetail movieDetail = new MovieDetail();
            movieDetail.idNo=lblIdno.Text;
            movieDetail.ShowDialog();
        }
    }
}
