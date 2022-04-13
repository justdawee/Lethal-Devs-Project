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
        LoginForm panel = new LoginForm(); //Üzenet(messagebox) kiíráshoz kell
        LogWriter log = new LogWriter(); //log üzenetekhez szükséges objektum
        Encryption encryption = new Encryption(); //jelszó titkosításhoz szükséges

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        public SqlConnection()
        {
            server = "localhost";
            database = "vms_lethaldevs";
            uid = "lethaldevs";
            password = "YR*_D61xFdDPa[0X";
            port = "3306";

            string connectionString;
            connectionString = "server=" + server + ";" + "user=" + uid + ";" + "database=" +
            database + ";" + "port=" + port + ";" + "password=" + password + ";";

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
                        panel.ShowMessage("[MYSQL] HIBA: CSATLAKOZÁS SIKERTELEN!\nNézz log-ot a részletekért.", "HIBA");
                        log.WriteLog("[MYSQL] HIBA: CSATLAKOZÁS SIKERTELEN!\n" + e.Message);
                        break;
                    case 1045:
                        //Hibás felhasználó vagy jelszó
                        panel.ShowMessage("[MYSQL] HIBA: ROSSZ FELHASZNÁLÓNÉV/JELSZÓ PÁROS!\n", "HIBA");
                        log.WriteLog("[MYSQL] HIBA: ROSSZ FELHASZNÁLÓNÉV/JELSZÓ PÁROS!\n" + e.Message);
                        break;
                    default:
                        panel.ShowMessage("[MYSQL] HIBA: " + e + "\t" + e.Number, "HIBA");
                        log.WriteLog("[MYSQL] HIBA: " + e + "\t" + e.Number);
                        break;
                }
                panel.exitApp();
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
                panel.ShowMessage("[MYSQL] HIBA: NEM SIKERÜLT BEZÁRNI A KAPCSOLATOT!\n\t" + e.Message, "HIBA");
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
            var password_encrypted = encryption.EncryptString(password);
            string query = "SELECT * FROM users WHERE (username = '" + username + "')";

            List<string>[] LoginInfo = new List<string>[1];
            LoginInfo[0] = new List<string>();
            LoginInfo[0].Add("");

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    LoginInfo[0][0] = dataReader["password"] + "";
                }
                dataReader.Close();
                this.CloseConnection();

                if (password_encrypted == LoginInfo[0][0] & LoginInfo[0][0] != "") // ha a jelszó helyes akkor true
                {
                    return true; //helyes belépési adatok
                }
                else if (LoginInfo[0][0] == "") // ha üres a mező, akkor nincs ilyen felhasználó az adatbázisban
                {
                    panel.ShowMessage("Nincs ilyen felhasználó!", "HIBA");
                }
                else
                {
                    panel.ShowMessage("Hibás felhasználónév/jelszó.", "HIBA");
                }
            }
            return false; // hibás belépési adatok
        }

        public List<string> getUserData(string username, string[] mitkeres)
        {
            var found = new List<string>();
            var query = "SELECT * FROM users WHERE (username = '" + username + "')";

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    for (int i = 0; i < mitkeres.Length; i++)
                    {
                        found.Add(dataReader[$"{mitkeres[i]}"] + "");
                    }
                }
                dataReader.Close();
                this.CloseConnection();
            }
            return found;
        }

        public void loadAllUserData(string user)
        {
            string[] read = new string[] {
                "id",
                "username",
                "password",
                "admin",
                "birthdate",
                "address",
                "regdate",
                "phonenumber",
                "email"
            };

            var userdata = getUserData(user, read);

            User.UserInstance.Id = Convert.ToInt32(userdata[0]);
            User.UserInstance.Username = userdata[1];
            User.UserInstance.Password = userdata[2];
            User.UserInstance.Admin = Convert.ToBoolean(userdata[3]);
            User.UserInstance.Birthdate = Convert.ToDateTime(userdata[4]);
            User.UserInstance.Address = userdata[5];
            User.UserInstance.Regdate = Convert.ToDateTime(userdata[6]);
            User.UserInstance.Phonenumber = userdata[7];
            User.UserInstance.Email = userdata[8];
        }

        public void CreateUser(string username, string password, DateTime birthdate, string address, DateTime regdate, string phonenumber, string email)
        {
            var password_encrypted = encryption.EncryptString(password);
            string command = "INSERT INTO users (username, password, birthdate, address, regdate, phonenumber, email) VALUES ('" + username + "','" + password_encrypted + "','" + birthdate + "','" + address + "','" + regdate + "','" + phonenumber + "','" + email + "')";
            if (this.OpenConnection())
            {
                Query(command);
            }
        }

        
    }
}
