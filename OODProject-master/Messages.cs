using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODProject
{
    public partial class Messages : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        DataTable dt;
        DataTable dt2;
        SqlDataAdapter sda;
        SqlDataAdapter sda2;
        SqlCommand cmd;
        SqlCommand cmd2;
        int rowID;
        int messageID;

        public Messages()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [dbo].[Message](messageTitle, messageDescription ) values(@title,@message)";
            cmd.Parameters.AddWithValue("@title", subjectTextBox.Text);
            cmd.Parameters.AddWithValue("@message", descTextBox.Text);

            try
            {

                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM [dbo].[Message] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Message sent");

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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [dbo].[Message] WHERE messageID = @id";
            cmd.Parameters.AddWithValue("@id", rowID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[Message] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                con.Close();
                MessageBox.Show("Message Deleted");

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
            cmd.CommandText = "UPDATE [dbo].[Message] set messageTitle = @title, messageDescription = @message where messageID = @id";
            cmd.Parameters.AddWithValue("@title", subjectTextBox.Text);
            cmd.Parameters.AddWithValue("@message", descTextBox.Text);
            cmd.Parameters.AddWithValue("@id", rowID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[Message] where 1=1 ";
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                BindingSource bs = new BindingSource();
                sda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                con.Close();
                MessageBox.Show("Message Updated");

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

        private void Messages_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [dbo].[Message] where 1=1 ";
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            cmd.Dispose();
            con.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != DBNull.Value)
            {
                rowID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                subjectTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();                
                descTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            rowID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            subjectTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();            
            descTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();            
        }
    }
}
