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
    public partial class UsernewPanel : Form
    {
        public UsernewPanel()
        {
            InitializeComponent();

            UC_HomeUnLogin home = new UC_HomeUnLogin();
            addUserControl(home);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_HomeUnLogin home = new UC_HomeUnLogin();
            addUserControl(home);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Ticket ticket = new UC_Ticket();
            addUserControl(ticket);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Seans seans = new UC_Seans();
            addUserControl(seans);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_Login login = new UC_Login();
            addUserControl(login);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UC_Register register = new UC_Register();
            addUserControl(register);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UC_Ai ai = new UC_Ai();
            addUserControl(ai);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            UC_AdminLogin adminLogin = new UC_AdminLogin();
            addUserControl(adminLogin);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
