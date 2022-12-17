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
    public partial class RegisterForm : Form
    {
        
        public RegisterForm()
        {
            InitializeComponent();
            this.CenterToScreen();

        }
        SqlConnection conn = new SqlConnection(Program.conn);

        SqlCommand cmd = new SqlCommand();
        

        private void registerButton_Click(object sender, EventArgs e)
        {

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            var date = birthdayPicker.Value.Date;
            var now = birthdayPicker.Value = System.DateTime.Now;
            int age = now.Year - date.Year;


            cmd.CommandText = "insert into [dbo].[User](userName, userDOB, userEmail, userPassword, age, roleID) values(@name,@date,@email,@pass,@age,@role)";
            cmd.Parameters.AddWithValue("@name", userNameTextBox.Text);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@pass", passwordTextField.Text);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@role", 2);
      
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Success!!");
                
                this.Close();
                LoginForm login = new LoginForm();
                login.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }

        private void passwordTextField_TextChanged(object sender, EventArgs e)
        {
            passwordTextField.UseSystemPasswordChar = true;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
