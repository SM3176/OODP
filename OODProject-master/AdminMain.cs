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
using System.IO;
using System.Diagnostics;

namespace OODProject
{
    public partial class AdminMain : Form
    {
        SqlConnection con = new SqlConnection(Program.conn);
        
        
        public AdminMain()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close() ;
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void messages_Click(object sender, EventArgs e)
        {
            this.Hide();
            Messages mess = new Messages();
            mess.ShowDialog();
            this.Show();
        }

        private void manageServices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service ser = new Service();
            ser.ShowDialog();
            this.Show();
        }

        private void manageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsers user = new ManageUsers();
            user.ShowDialog();
            this.Show();
        }

        private void ManageBookings_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageBooking book = new manageBooking();
            book.ShowDialog();
            this.Show();
        }

        private void ManageFlights_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Flights fly = new Manage_Flights();
            fly.ShowDialog();
            this.Show();
        }

        private void dcmc_Click(object sender, EventArgs e)
        {
            this.Hide();
            DCMC dc = new DCMC();
            dc.ShowDialog();
            this.Show();
        }

        private void backupDB_Click(object sender, EventArgs e)
        {
            String databaseLocation = @"D:\oodp\OODP\OODProject-master\Flight.mdf";
            String backup = @"D:\backup";
            String there = @"D:\backup\Flight.mdf";
            try
            {
            
                if (!Directory.Exists(backup))
                {
                    
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(backup);
                    foreach (var process in Process.GetProcessesByName("sqlservr"))
                    {
                        process.Kill();
                    }
                    System.IO.File.Copy(databaseLocation, System.IO.Path.Combine(backup, "Flight.mdf"), true);
                    MessageBox.Show("Success");
                    System.IO.File.Copy(databaseLocation, System.IO.Path.Combine(backup, "Flight.mdf"), true);
                    MessageBox.Show("Success");
                }
                else
                {
                    if (File.Exists(there))
                    {
                        File.Delete(there);
                        foreach (var process in Process.GetProcessesByName("sqlservr"))
                        {
                            process.Kill();
                        }
                        System.IO.File.Copy(databaseLocation, System.IO.Path.Combine(backup, "Flight.mdf"), true);
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        foreach (var process in Process.GetProcessesByName("sqlservr"))
                        {
                            process.Kill();
                        }
                        System.IO.File.Copy(databaseLocation, System.IO.Path.Combine(backup, "Flight.mdf"), true);
                        MessageBox.Show("Success");
                    }
                    
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Click one more time on the database back up to confirm ");
            }
        }
    }
}
