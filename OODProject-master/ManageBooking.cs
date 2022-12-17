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
   
    public partial class manageBooking : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        DataTable dt;
        DataTable dt2;
        SqlDataAdapter sda;
        SqlDataAdapter sda2;
        SqlDataAdapter sda3;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        int rowID;
        int flightID;
        int userID;

        public manageBooking()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void manageBooking_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Booking] where 1=1 ";

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT * FROM [dbo].[Flight] where 1=1";

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = con;
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "SELECT * FROM [dbo].[User] where 1=1";

            DataTable dt2 = new DataTable();
            sda2 = new SqlDataAdapter(cmd2);
            sda2.Fill(dt2);

            DataTable dt3 = new DataTable();
            sda3 = new SqlDataAdapter(cmd3);
            sda3.Fill(dt3);

            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            manageGrid.DataSource = bs;
            bindingNavigator1.BindingSource = bs;

            flightCombo.DataSource = dt2;
            flightCombo.DisplayMember = "flightName";
            flightCombo.ValueMember = "flightID";
            userCombo.DataSource = dt3;
            userCombo.DisplayMember = "userName";
            userCombo.ValueMember = "userID";
            con.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var date = datePicker.Value.Date;

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [dbo].[Booking](seatNumber, date, flightID, userID) values(@seat, @date, @flight, @user)";
            cmd.Parameters.AddWithValue("@seat", seatTextBox.Text);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@flight", flightCombo.SelectedValue);
            cmd.Parameters.AddWithValue("@user", userCombo.SelectedValue);
            

            try
            {

                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM [dbo].[booking] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                manageGrid.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
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
            cmd.CommandText = "SELECT * FROM [dbo].[Booking] where 1=1 ";
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            manageGrid.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            con.Close();
        }

        private void manageGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (manageGrid.Rows[e.RowIndex].Cells[0].Value != DBNull.Value)
            {
                rowID = Convert.ToInt32(manageGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                seatTextBox.Text = manageGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                datePicker.Value = DateTime.Parse(manageGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                flightCombo.SelectedValue = Convert.ToInt32(manageGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                userCombo.SelectedValue = Convert.ToInt32(manageGrid.Rows[e.RowIndex].Cells[4].Value.ToString());

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [dbo].[Booking] WHERE bookingID = @id";
            cmd.Parameters.AddWithValue("@id", rowID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[Booking] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                manageGrid.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
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
            var date = datePicker.Value.Date;

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [dbo].[Booking] set seatNumber = @seat, bookingDate = @bDate, flightID = @flight, userID = @user where bookingID = @id";
            cmd.Parameters.AddWithValue("@seat", seatTextBox.Text);
            cmd.Parameters.AddWithValue("@bDate", date);
            cmd.Parameters.AddWithValue("@flightID", flightCombo.SelectedValue);
            cmd.Parameters.AddWithValue("@userID", userCombo.SelectedValue);
            cmd.Parameters.AddWithValue("@id", rowID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[Flight] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                manageGrid.DataSource = bs;
                bindingNavigator1.BindingSource = bs;
                con.Close();
                MessageBox.Show("Success");
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

        private void manageGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowID = Convert.ToInt32(manageGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            seatTextBox.Text = manageGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            datePicker.Value = DateTime.Parse(manageGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            flightCombo.SelectedValue = flightID;
            userCombo.SelectedValue = userID;
            

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
            seatTextBox.Text = "";            
            flightCombo.SelectedValue = 0;
            userCombo.SelectedValue = 0;
        }
    }
}
