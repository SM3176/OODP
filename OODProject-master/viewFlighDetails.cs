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
    public partial class viewFlighDetails : Form
    {
        DataGridViewRow detailedRow = EmployerMain.selectedRow;
        public viewFlighDetails()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void viewFlighDetails_Load(object sender, EventArgs e)
        {
                flightIDTextBox.Text = detailedRow.Cells[0].Value.ToString();
                airlineNameTextBox.Text = detailedRow.Cells[1].Value.ToString();
                arrivalDateViewer.Value = DateTime.Parse(detailedRow.Cells[2].Value.ToString());
                capacityTextBox.Text = detailedRow.Cells[3].Value.ToString();
                departureDateViewer.Value = DateTime.Parse(detailedRow.Cells[4].Value.ToString());
                countryIDTextBox.Text = detailedRow.Cells[5].Value.ToString();
                priceTextBox.Text = detailedRow.Cells[6].Value.ToString();
        }
    }
}
