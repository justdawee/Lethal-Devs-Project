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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationPanel());

            //MySQL szerverhez szükséges adatok
            const string hostname = "localhost";
            const string userid = "lethaldevs";
            const string password = "YR*_D61xFdDPa[0X";
            const string database = "vms_lethaldevs";

            //Csatlakozás metódus meghívása az adatokkal.
            InitMySqlConnection($@"server={hostname};userid={userid};password={password};database={database}");
            
        }

        static void InitMySqlConnection(string connection)
        {
            var mysqlcon = new MySqlConnection(connection); //kapcsolat objektum létrehozás
            mysqlcon.Open(); //kapcsolat megnyitása a szerverrel
        }
    }
}
