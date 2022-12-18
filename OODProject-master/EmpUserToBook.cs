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
    public partial class EmpUserBooking : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        DataTable dt;
        SqlDataAdapter sda;
        SqlCommand cmd;


        public static DataTable userSubset = new DataTable();

        public EmpUserBooking()
        {
            InitializeComponent();
        }

        private void EmpUserBooking_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Name = "isSelected";

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT userID, userName FROM [dbo].[User] where roleID = 2";

            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;

            dataGridView1.Columns.Add(checkBoxColumn);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            userSubset = new DataTable();

            userSubset.Columns.Add("userID", typeof(string));
            userSubset.Columns.Add("userName", typeof(string));

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(item.Cells[2].Value))
                {
                    userSubset.Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString());
                }
            }
            if (userSubset.Rows.Count > 0)
            {
                this.Hide();
                PaymentForm payForm = new PaymentForm();
                payForm.ShowDialog();
                this.Show();
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Name = "isSelected";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT userID, userName FROM [dbo].[User] where roleID = 2";

            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            BindingSource bs = new BindingSource();
            sda.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;

            dataGridView1.Columns.Add(checkBoxColumn);
        }

        private void previewBtn_Click_1(object sender, EventArgs e)
        {
            userSubset = new DataTable();

            userSubset.Columns.Add("userID", typeof(string));
            userSubset.Columns.Add("userName", typeof(string));

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(item.Cells[2].Value))
                {
                    userSubset.Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString());
                }
            }
            this.Hide();
            EmpPreviewUsers preview = new EmpPreviewUsers();
            preview.ShowDialog();
            this.Show();
        }
    }
}
