using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OODProject
{
    public partial class viewBookingDetials : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        SqlDataAdapter sda;
        SqlCommand cmd;

        public viewBookingDetials()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void viewBookingDetials_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT bookingID, bookingDate, flightID, userID, paymentID FROM [dbo].[Booking] where userID = @user";
            cmd.Parameters.AddWithValue("@user", LoginForm.loggedInID.ItemArray[0].ToString());


            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            dataGridView.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            con.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Booking] where 1=1 ";

            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            dataGridView.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            con.Close();
        }

    }  
}
