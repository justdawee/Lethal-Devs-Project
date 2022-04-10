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
                Console.WriteLine("Sikeres MySQL csatlakozás! :)");
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        //Server Conn Error
                        Console.WriteLine("Server Connection Error");
                        break;

                    case 1045:
                        //Wrong Username or Password
                        Console.WriteLine("Wrong Username or Password");
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
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool ReadDB()
        {
            string query = "SELECT * FROM users";
            List<string>[] LoginInfo = new List<string>[2];
            LoginInfo[0] = new List<string>();
            LoginInfo[1] = new List<string>();
            if (this.OpenConnection() == true)
            {
                //Console.WriteLine("Connection Opened");
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    //Console.WriteLine("Data Reader Reading...");
                    LoginInfo[0].Add(dataReader["username"] + "");
                    LoginInfo[1].Add(dataReader["password"] + "");
                }
                for (int i = 0; i < LoginInfo[0].Count; i++)
                {
                    Console.WriteLine("Username = " + LoginInfo[0][i] + "; Password = " + LoginInfo[1][i] + ";");
                }
                dataReader.Close();
                this.CloseConnection();
                return true;
            }
            return false;
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
                    Console.WriteLine("Sikeres bejelentkezés!");
                    return true;
                }
                else if (LoginInfo[0][0] == "")
                {
                    Console.WriteLine("Nincs ilyen felhasználó!");
                }
                else
                {
                    Console.WriteLine("Hibás felhasználónév/jelszó.");
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
