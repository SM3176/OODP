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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        

        SqlConnection conn= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OODP\OODP\OODProject-master\Database.mdf;Integrated Security=True;Connect Timeout=30");
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            String name, password;

            name = userTextBox.Text;
            password = passwordTextBox.Text;

            try
            {
                String querry = "select userName, userPassword, roleID From [dbo].[User] where userName = '" + name+"' and userPassword = '"+password+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    name = userTextBox.Text;
                    password = passwordTextBox.Text;
         
                    if(dt.Rows[0].ItemArray[2].ToString() == "1")
                    {
                        AdminMain admin = new AdminMain();
                        admin.Show();
                        this.Hide();
                    }else if(dt.Rows[0].ItemArray[2].ToString() == "2")
                    {
                        TravellerMain traveller = new TravellerMain();
                        this.Hide();
                        traveller.Show();
                    }
                    else if(dt.Rows[0].ItemArray[2].ToString() == "3")
                    {
                        EmployerMain Employer = new EmployerMain();
                        this.Hide();
                        Employer.Show();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }
    }
}
