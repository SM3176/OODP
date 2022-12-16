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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close() ;
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void messages_Click(object sender, EventArgs e)
        {
            this.Hide();
            Messages mess = new Messages();
            mess.ShowDialog();
            this.Show();
        }

        private void manageServices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service ser = new Service();
            ser.ShowDialog();
            this.Show();
        }

        private void manageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsers user = new ManageUsers();
            user.ShowDialog();
            this.Show();
        }

        private void ManageBookings_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageBooking book = new ManageBooking();
            book.ShowDialog();
            this.Show();
        }

        private void ManageFlights_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Flights fly = new Manage_Flights();
            fly.ShowDialog();
            this.Show();
        }

        private void dcmc_Click(object sender, EventArgs e)
        {
            this.Hide();
            DCMC dc = new DCMC();
            dc.ShowDialog();
            this.Show();
        }
    }
}
