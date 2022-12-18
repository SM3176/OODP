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
    public partial class ManageCountry : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        DataTable dt;
        SqlDataAdapter sda;
        SqlCommand cmd;
        int rowID;
        public ManageCountry()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ManageCountry_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Country] where 1=1 ";
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            countryGridView.DataSource = bs;
            con.Close();
        }

        private void countryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (countryGridView.Rows[e.RowIndex].Cells[0].Value != DBNull.Value)
            {
                rowID = Convert.ToInt32(countryGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                countryTextBox.Text = countryGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                
            }
        }

        private void updateCountry_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [dbo].[Country] set countryName = @name where countryID =@id";
            cmd.Parameters.AddWithValue("@name", countryTextBox.Text);
            cmd.Parameters.AddWithValue("@id", rowID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[Country] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                countryGridView.DataSource = bs;
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
            cmd.CommandText = "insert into [dbo].[Country](countryName) values(@name)";
            cmd.Parameters.AddWithValue("@name", countryTextBox.Text);
           


            try
            {

                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM [dbo].[Country] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                countryGridView.DataSource = bs;
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

        private void countryGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            rowID = Convert.ToInt32(countryGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            countryTextBox.Text = countryGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [dbo].[Country] WHERE countryID = @id";
            cmd.Parameters.AddWithValue("@id", rowID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[Country] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                countryGridView.DataSource = bs;
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
