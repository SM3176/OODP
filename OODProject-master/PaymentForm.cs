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
        SqlCommand cmd;
        Boolean hasPayed = false;
        Int32 newPaymentID;
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
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [dbo].[Payment](cardNumber, expiryDate, dateOfPurchase) output inserted.paymentID values(@card, @exp, @date)";
            cmd.Parameters.AddWithValue("@card", cardTextBox.Text);
            cmd.Parameters.AddWithValue("@exp", expireTextBox.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);

            try
            {

                con.Open();
                cmd.ExecuteNonQuery();
                newPaymentID = (Int32)cmd.ExecuteScalar();
                hasPayed = true;
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

        private void bookFlightsBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            if(hasPayed == true)
            {
                for (int i = 0; i < EmpUserBooking.userSubset.Rows.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [dbo].[Booking](bookingDate, seatNumber, flightID, userID, paymentID) values(@date, @seat, @flight, @user, @payment)";
                    cmd.Parameters.AddWithValue("@date",DateTime.Now);
                    cmd.Parameters.AddWithValue("@seat",Convert.ToInt32(EmployerMain.selectedRow.Cells[3].Value) - i);
                    cmd.Parameters.AddWithValue("@flight", EmployerMain.selectedRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@user", EmpUserBooking.userSubset.Rows[i].ItemArray[0].ToString());
                    cmd.Parameters.AddWithValue("@payment", newPaymentID);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                MessageBox.Show("Success");
            }
            con.Close();
            hasPayed = false;
        }
    }
}
