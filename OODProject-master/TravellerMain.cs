using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODProject
{
    public partial class TravellerMain : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        DataTable dt;
        SqlDataAdapter sda;
        SqlCommand cmd;

        DataTable dt2;
        SqlDataAdapter sda2;
        SqlCommand cmd2;

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

        private void bFlights_Click(object sender, EventArgs e)
        {
            if(EmployerMain.selectedRow != null)
            {
                EmpUserBooking.userSubset = new DataTable();

                EmpUserBooking.userSubset.Columns.Add("userID", typeof(string));
                EmpUserBooking.userSubset.Columns.Add("userName", typeof(string));

                EmpUserBooking.userSubset.Rows.Add(LoginForm.loggedInID.ItemArray[0].ToString(),LoginForm.loggedInID.ItemArray[1].ToString());
                this.Hide();
                PaymentForm pay = new PaymentForm();
                pay.ShowDialog();
                this.Show();
            }
        }

        private void vBookingD_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewBookingDetials bookingDetails = new viewBookingDetials();
            bookingDetails.ShowDialog();
            this.Show();
        }

        private void TravellerMain_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Flight] where 1=1 ";

            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EmployerMain.selectedRow = dataGridView1.Rows[e.RowIndex];
        }
    }
}
