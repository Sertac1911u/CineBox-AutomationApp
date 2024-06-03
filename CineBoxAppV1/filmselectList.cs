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
    public partial class filmselectList : UserControl
    {
        public filmselectList()
        {
            InitializeComponent();
        }

        public void SetImage(string imageUrl)
        {
            lblMovieImg.Load(imageUrl);
        }

  
        private void filmDetail_Click_1(object sender, EventArgs e)
        {
            FilmDetay_UC filmDetay = new FilmDetay_UC();
            filmDetay.idNo = lblIdno.Text;
            filmDetay.ShowDialog();
        }
    }
}
