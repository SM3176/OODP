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
    public partial class PaymentForm : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        DataTable dt;
        SqlDataAdapter sda;
        SqlCommand cmd;

        public PaymentForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into [dbo].[Payment](cardNumber, expiryDate, dateOfPurchase) values(@card, @exp, @date)";
            cmd.Parameters.AddWithValue("@card", cardTextBox.Text);
            cmd.Parameters.AddWithValue("@exp", expireTextBox.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Payment was successfull");


                this.DialogResult = DialogResult.OK;

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
