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
    public partial class Manage_Flights : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\97337\Source\Repos\OODP\OODProject-master\Database.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt;
        DataTable dt2;
        SqlDataAdapter sda;
        SqlDataAdapter sda2;
        SqlCommand cmd;
        SqlCommand cmd2;
        int rowID;
        int countryID;

        public Manage_Flights()
        {
            InitializeComponent();
        }


        private void Manage_Flights_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Flight] where 1=1 ";

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT * FROM [dbo].[Country] where 1=1";

            DataTable dt2 = new DataTable();
            sda2 = new SqlDataAdapter(cmd2);
            sda2.Fill(dt2);

            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            flightsGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            countryComboBox.DataSource = dt2;
            countryComboBox.DisplayMember = "countryName";
            countryComboBox.ValueMember = "countryID";
            con.Close();
        }

        private void flightsGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowID = Convert.ToInt32(flightsGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            airlineNameTextBox.Text = flightsGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            arrivalDateTimePicker.Value = DateTime.Parse(flightsGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            capacityTextBox.Text = flightsGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            departureDateTimePicker.Value = DateTime.Parse(flightsGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            priceTextBox.Text = flightsGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            countryComboBox.SelectedValue = Convert.ToInt32(flightsGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void addFlightBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [dbo].[Flight](airlineName, arrivalDateandTime, capacity, departureDateandTime, countryID, price) values(@airlineName,@arrivalTime,@capacity,@departureTime,@countryID,@price)";
            cmd.Parameters.AddWithValue("@airlineName", airlineNameTextBox.Text);
            cmd.Parameters.AddWithValue("@arrivalTime", arrivalDateTimePicker.Value.ToString());
            cmd.Parameters.AddWithValue("@capacity", capacityTextBox.Text);
            cmd.Parameters.AddWithValue("@departureTime", departureDateTimePicker.Value.ToString());
            cmd.Parameters.AddWithValue("@countryID", countryComboBox.SelectedValue);
            cmd.Parameters.AddWithValue("@price", priceTextBox.Text);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Success");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
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
            flightsGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            con.Close();
        }
    }
}
