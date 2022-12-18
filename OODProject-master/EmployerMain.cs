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
    public partial class EmployerMain : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        DataTable dt;
        DataTable dt2;
        SqlDataAdapter sda;
        SqlDataAdapter sda2;
        SqlCommand cmd;
        SqlCommand cmd2;

        public static EmployerMain instance;
        public static DataGridViewRow selectedRow;
        public EmployerMain()
        {
            InitializeComponent();
            this.CenterToScreen();
            instance = this;
        }


        private void message_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMessages mess = new ViewMessages();
            mess.ShowDialog();
            this.Show();

        }

        private void vFlight_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                this.Hide();
                viewFlighDetails vF = new viewFlighDetails();
                vF.ShowDialog();
                this.Show();
            }


        }

        private void vBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewBookingDetials vB = new viewBookingDetials();
            vB.ShowDialog();
            this.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void bkFlight_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                this.Hide();
                EmpUserBooking userBooking = new EmpUserBooking();
                userBooking.ShowDialog();
                this.Show();
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void EmployerMain_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            con.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = dataGridView1.Rows[e.RowIndex];
        }
    }
}