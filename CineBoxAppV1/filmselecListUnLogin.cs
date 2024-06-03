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
    public partial class filmselecListUnLogin : UserControl
    {
        public filmselecListUnLogin()
        {
            InitializeComponent();
        }
        public void SetImage(string imageUrl)
        {
            lblMovieImg.Load(imageUrl);
        }

        private void filmDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Film detaylarını görmek için lütfen giriş yapın");
        }
    }
}
