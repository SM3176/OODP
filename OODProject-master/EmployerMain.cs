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
    public partial class EmployerMain : Form
    {
        public EmployerMain()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private void message_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMessages mess = new ViewMessages();
            mess.ShowDialog();
            this.Show();
            
        }

        private void vFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewFlighDetails vF = new viewFlighDetails();
            vF.ShowDialog();
            this.Show();
            
        }

        private void vBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewBookingDetials vB = new viewBookingDetials();
            vB.ShowDialog();
            this.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void bkFlight_Click(object sender, EventArgs e)
        {
            
            
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
