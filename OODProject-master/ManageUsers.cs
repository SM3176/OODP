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
    public partial class ManageUsers : Form
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
        int roleID;
        int serviceID;
        public ManageUsers()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[User] where 1=1 ";

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT * FROM [dbo].[Role] where 1=1";

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = con;
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "SELECT * FROM [dbo].[Service] where 1=1";

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
            userGridView.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            roleCombo.DataSource = dt2;
            roleCombo.DisplayMember = "roleName";
            roleCombo.ValueMember = "roleID";

            serviceComboBox.DataSource = dt3;
            serviceComboBox.DisplayMember = "serviceName";
            serviceComboBox.ValueMember = "serviceID";
            con.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            var date = datePicker.Value.Date;
            var now = datePicker.Value = System.DateTime.Now;
            int age = now.Year - date.Year;


            cmd.CommandText = "insert into [dbo].[User](userName, userDOB, userEmail, userPassword, age, roleID, serviceID) values(@name,@date,@email,@pass,@age,@role,@service)";
            cmd.Parameters.AddWithValue("@name", userTextBox.Text);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@pass", passwordTextBox.Text);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@role", roleCombo.SelectedIndex+1);
            cmd.Parameters.AddWithValue("@service", serviceComboBox.SelectedIndex + 1);
            try
            {

                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM [dbo].[User] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                userGridView.DataSource = bs;
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
            cmd.CommandText = "SELECT * FROM [dbo].[User] where 1=1 ";
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            userGridView.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            con.Close();
        }

        

        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowID = Convert.ToInt32(userGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            userTextBox.Text = userGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            datePicker.Value = DateTime.Parse(userGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            emailTextBox.Text = userGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            passwordTextBox.Text = userGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            roleID = Convert.ToInt32(userGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
            roleCombo.SelectedValue = roleID;
            serviceID = Convert.ToInt32(userGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            serviceComboBox.SelectedValue = serviceID;
        }

        private void userGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
                if (userGridView.Rows[e.RowIndex].Cells[0].Value != DBNull.Value)
                {
                    rowID = Convert.ToInt32(userGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    userTextBox.Text = userGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    datePicker.Value = DateTime.Parse(userGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    emailTextBox.Text = userGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    passwordTextBox.Text = userGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    roleCombo.SelectedValue = Convert.ToInt32(userGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
                    serviceComboBox.SelectedValue = Convert.ToInt32(userGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
                }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var date = datePicker.Value.Date;
            var now = datePicker.Value = System.DateTime.Now;
            int age = now.Year - date.Year;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [dbo].[User] set userName = @name, userDOB = @date, userEmail = @email, userPassword = @pass, serviceID = @service, roleID = @role, age = @age where userID = @id";
            cmd.Parameters.AddWithValue("@name", userTextBox.Text);
            cmd.Parameters.AddWithValue("@date", datePicker.Value.ToString());
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@pass", passwordTextBox.Text);
            cmd.Parameters.AddWithValue("@service", serviceComboBox.SelectedValue);
            cmd.Parameters.AddWithValue("@role", roleCombo.SelectedValue);
            cmd.Parameters.AddWithValue("@id", rowID);
            cmd.Parameters.AddWithValue("@age", age);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[User] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                userGridView.DataSource = bs;
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            userTextBox.Text = "";
            datePicker.Value = DateTime.Now;
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            roleCombo.SelectedValue = 0;
            serviceComboBox.SelectedValue = 0;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [dbo].[User] WHERE userID = @id";
            cmd.Parameters.AddWithValue("@id", rowID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[User] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                userGridView.DataSource = bs;
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
    }
}
