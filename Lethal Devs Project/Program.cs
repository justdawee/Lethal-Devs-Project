using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lethal_Devs_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            MySqlConnection(@"server=localhost;userid=lethaldevs;password=secret;database=vms_lethaldevs");
        }

        static void MySqlConnection(string connection)
        {
            var mysqlcon = new MySqlConnection(connection);
            mysqlcon.Open();

            Console.WriteLine($"MySQL version : {mysqlcon.ServerVersion}");
        }
    }
}
