using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODProject
{
    public partial class TravellerMain : Form
    {
        public TravellerMain()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void messages_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMessages mess = new ViewMessages();
            mess.ShowDialog();
            this.Show();
        }
    }
}
