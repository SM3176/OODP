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
    public partial class DCMC : Form
    {
        public DCMC()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ManageAirportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAirpots air = new ManageAirpots();
            air.ShowDialog();
            this.Show();
        }

        private void ManageCityBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCity cit = new ManageCity();
            cit.ShowDialog();
            this.Show();
        }

        private void ManageCountryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCountry cot = new ManageCountry();
            cot.ShowDialog();
            this.Show();
        }

        private void DCMC_Load(object sender, EventArgs e)
        {

        }
    }
}
