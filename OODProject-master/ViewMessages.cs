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
    public partial class ViewMessages : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        DataTable dt;
        SqlDataAdapter sda;
        SqlCommand cmd;

        public ViewMessages()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ViewMessages_Load(object sender, EventArgs e)
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
    }
}