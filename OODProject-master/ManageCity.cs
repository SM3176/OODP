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
    public partial class ManageCity : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        DataTable dt;
        SqlDataAdapter sda;
        DataTable dt2;
        SqlDataAdapter sda2;
        SqlCommand cmd2;
        SqlCommand cmd;
        int rowID;
        int countryID;
        public ManageCity()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ManageCity_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[City] where 1=1 ";

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
            cityGridView.DataSource = bs;
            countryCombo.DataSource = dt2;
            countryCombo.DisplayMember = "country";
            countryCombo.ValueMember = "countryID";
            con.Close();
        }

        private void cityGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cityGridView.Rows[e.RowIndex].Cells[0].Value != DBNull.Value)
            {
                rowID = Convert.ToInt32(cityGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                cityNameTextBox.Text = cityGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                countryCombo.SelectedValue = Convert.ToInt32(cityGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [dbo].[City] set cityName = @name, countryID =@city where cityID =@id";
            cmd.Parameters.AddWithValue("@name", cityNameTextBox.Text);
            cmd.Parameters.AddWithValue("@city", countryCombo.SelectedValue);
            cmd.Parameters.AddWithValue("@id", rowID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[city] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                cityGridView.DataSource = bs;
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

        private void cityGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            countryID = Convert.ToInt32(cityGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            rowID = Convert.ToInt32(cityGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            cityNameTextBox.Text = cityGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            countryCombo.SelectedValue = countryID;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [dbo].[City] WHERE cityID = @id";
            cmd.Parameters.AddWithValue("@id", rowID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[City] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                cityGridView.DataSource = bs;
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [dbo].[City](cityName,countryID) values(@name,@country)";
            cmd.Parameters.AddWithValue("@name", cityNameTextBox.Text);
            cmd.Parameters.AddWithValue("@country", countryCombo.SelectedValue);


            try
            {

                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM [dbo].[City] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                cityGridView.DataSource = bs;
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
    }
}
