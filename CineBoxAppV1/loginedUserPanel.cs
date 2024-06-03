using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineBoxAppV1
{
    public partial class loginedUserPanel : Form
    {
        public loginedUserPanel()
        {
            InitializeComponent();

            UC_Home home = new UC_Home();
            addUserControl(home);

        }
        public void SetUsername(string username,int userID)
        {
            usernameLabel.Text = username;
            userIdlabel.Text = userID.ToString();
            string filePath = "userID.txt";

            try
            {
                // Write the userID to the text file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(userID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user ID to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            UC_Home home = new UC_Home();
            addUserControl(home);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           UC_Ticket_Logined ticket = new UC_Ticket_Logined();
            addUserControl(ticket);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Seans_Logined seans = new UC_Seans_Logined();
            addUserControl(seans);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UC_Ai_Logined uC_Ai_Logined = new UC_Ai_Logined();
            addUserControl(uC_Ai_Logined);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    
