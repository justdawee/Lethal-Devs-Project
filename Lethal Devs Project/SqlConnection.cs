using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lethal_Devs_Project
{
    internal class SqlConnection
    {
        AuthorizationPanel panel = new AuthorizationPanel(); //Üzenet kiíráshoz példányosítani kell a form-ot.
        LogWriter log = new LogWriter(); //log üzenetekhez szükséges objektum

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public SqlConnection()
        {
            server = "localhost";
            database = "vms_lethaldevs";
            uid = "lethaldevs";
            password = "YR*_D61xFdDPa[0X";
            string connectionString;
            connectionString = "server=" + server + ";" + "user=" + uid + ";" + "database=" +
            database + ";" + "port=3306;" + "password=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        //Szerver csatlakozási hiba
                        log.WriteLog("[MYSQL] HIBA: CSATLAKOZÁS SIKERTELEN!\n\t" + e.Message);
                        break;

                    case 1045:
                        //Hibás felhasználó vagy jelszó
                        log.WriteLog("[MYSQL] HIBA: ROSSZ FELHASZNÁLÓNÉV/JELSZÓ PÁROS!\n\t" + e.Message);
                        break;
                    default:
                        Console.WriteLine(e + "\t" + e.Number);
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                log.WriteLog("[MYSQL] HIBA: NEM SIKERÜLT BEZÁRNI A KAPCSOLATOT!\n\t" + e.Message);
                return false;
            }
        }

        public void Query(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public bool AttemptLogin(string username, string password)
        {
            string query = "SELECT * FROM users WHERE (username = '" + username + "')";

            List<string>[] LoginInfo = new List<string>[1];
            LoginInfo[0] = new List<string>();
            LoginInfo[0].Add("");

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    LoginInfo[0][0] = dataReader["password"] + "";
                }

                dataReader.Close();
                this.CloseConnection();
                if (password == LoginInfo[0][0] & LoginInfo[0][0] != "")
                {
                    Console.WriteLine(LoginInfo[0][0]);
                    return true;
                }
                else if (LoginInfo[0][0] == "")
                {
                    panel.ShowMessage("Nincs ilyen felhasználó!", "HIBA");
                }
                else
                {
                    panel.ShowMessage("Hibás felhasználónév/jelszó.", "HIBA");
                }
            }
            return false;
        }

        public bool CreateUser(string username, string password, DateTime birthdate, string address, DateTime regdate, string phonenumber, string email)
        {
            string query = "INSERT INTO users (username, password, birthdate, address, regdate, phonenumber, email) VALUES ('" + username + "','" + password + "','" + birthdate + "','" + address + "','" + regdate + "','" + phonenumber + "','" + email + "')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            return false;
        }
    }
}
