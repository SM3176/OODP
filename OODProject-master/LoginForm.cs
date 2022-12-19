using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace OODProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        
        SqlConnection conn= new SqlConnection(Program.conn);
        
        public static DataRow loggedInID;
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(userTextBox.Text != "" && passwordTextBox.Text != "")
            {
                String name, password;

                name = userTextBox.Text;
                password = passwordTextBox.Text;

                try
                {
                    String querry = "select userID, userName, userPassword, roleID From [dbo].[User] where userName = '" + name + "' and userPassword = '" + password + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        name = userTextBox.Text;
                        password = passwordTextBox.Text;

                        if (dt.Rows[0].ItemArray[3].ToString() == "1")
                        {
                            AdminMain admin = new AdminMain();
                            loggedInID = dt.Rows[0];
                            admin.Show();
                            this.Hide();
                        }
                        else if (dt.Rows[0].ItemArray[3].ToString() == "2")
                        {
                            TravellerMain traveller = new TravellerMain();
                            loggedInID = dt.Rows[0];
                            this.Hide();
                            traveller.Show();
                        }
                        else if (dt.Rows[0].ItemArray[3].ToString() == "3")
                        {
                            EmployerMain Employer = new EmployerMain();
                            loggedInID = dt.Rows[0];
                            this.Hide();
                            Employer.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong user or password");
                    }
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
            else
            {
                MessageBox.Show("Enter Values");
            }
            

        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }
    }
}
