using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODProject
{
    static class Program
    {

        public static string conn = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OODP\OODProject-master\Database.mdf;Integrated Security = True; Connect Timeout = 30";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
