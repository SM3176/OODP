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
    public partial class ManageAirpots : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        DataTable dt;
        SqlDataAdapter sda;
        DataTable dt2;
        SqlDataAdapter sda2;
        SqlCommand cmd2;
        SqlCommand cmd;
        int rowID;
        int cityID;

        public ManageAirpots()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ManageAirpots_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Airport] where 1=1 ";

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT * FROM [dbo].[City] where 1=1";

            DataTable dt2 = new DataTable();
            sda2 = new SqlDataAdapter(cmd2);
            sda2.Fill(dt2);

            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            airportGrid.DataSource = bs;
            cityNameComboBox.DataSource = dt2;
            cityNameComboBox.DisplayMember = "cityName";
            cityNameComboBox.ValueMember = "cityID";
            con.Close();
        }

        private void airportGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (airportGrid.Rows[e.RowIndex].Cells[0].Value != DBNull.Value)
            {
                rowID = Convert.ToInt32(airportGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                airNameTextBox.Text = airportGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                cityNameComboBox.SelectedValue = Convert.ToInt32(airportGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [dbo].[Airport](airportName,cityID) values(@name,@city)";
            cmd.Parameters.AddWithValue("@name", airNameTextBox.Text);
            cmd.Parameters.AddWithValue("@city", cityNameComboBox.SelectedValue);


            try
            {

                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM [dbo].[Airport] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                airportGrid.DataSource = bs;
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [dbo].[Airport] set airportName = @name, cityID =@city where airportID =@id";
            cmd.Parameters.AddWithValue("@name", airNameTextBox.Text);
            cmd.Parameters.AddWithValue("@city", cityNameComboBox.SelectedValue);
            cmd.Parameters.AddWithValue("@id", rowID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[Airport] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                airportGrid.DataSource = bs;
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

        private void airportGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cityID = Convert.ToInt32(airportGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            rowID = Convert.ToInt32(airportGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            airNameTextBox.Text = airportGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            cityNameComboBox.SelectedValue = cityID;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [dbo].[Airport] WHERE airportID = @id";
            cmd.Parameters.AddWithValue("@id", rowID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[Airport] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                airportGrid.DataSource = bs;
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
    }
}
