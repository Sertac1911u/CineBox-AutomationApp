using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineBoxAppV1
{
    public partial class UC_Ai_Logined : UserControl
    {
        public UC_Ai_Logined()
        {
            InitializeComponent();
        }

        private void UC_Ai_Logined_Load(object sender, EventArgs e)
        {
    
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string url= "http://31.210.43.54:3000/recommend?question=" + textbox.Text;

            try
            {
                // WebClient oluştur
                using (WebClient client = new WebClient())
                {
                    // İstek gönder ve yanıtı bir dizeye at
                    string response = client.DownloadString(url);

                    textitem.Text = response;

                }
            }
            catch (WebException ex)
            {
                // Hata durumunda konsola yazdır
                Console.WriteLine("Error:");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // İşlem tamamlandığında konsola yazdır
                textbox.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
