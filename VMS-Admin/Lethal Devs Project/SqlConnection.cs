using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private static int sqloperations;

        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string Uid { get => uid; set => uid = value; }
        public string Password { get => password; set => password = value; }
        public string Port { get => port; set => port = value; }
        public static int Sqloperations { get => sqloperations; set => sqloperations = value; }
        public MySqlConnection Connection { get => connection; set => connection = value; }

        public SqlConnection()
        {
            Server = Properties.Settings.Default.db_ip;
            Database = Properties.Settings.Default.db_database;
            Uid = Properties.Settings.Default.db_uid;
            Password = Properties.Settings.Default.db_password;
            Port = Properties.Settings.Default.db_port;

            string connectionString;
            connectionString = "server=" + Server + ";" + "user=" + Uid + ";" + "database=" +
            Database + ";" + "port=" + Port + ";" + "password=" + Password + ";";

            Connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                Connection.Open();
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

        public bool CloseConnection()
        {
            try
            {
                Connection.Close();
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
            if (OpenConnection())
            {
                Sqloperations++;
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public bool AttemptLogin(string username, string password)
        {
            var password_encrypted = encryption.EncryptString(password); //beírt jelszó titkosítása hogy össze lehessen hasonlítani
            int admin = 0; 

            string query = "SELECT * FROM users WHERE (username = '" + username + "')";

            List<string> LoginInfo = new List<string>();

            if (this.OpenConnection())
            {
                Sqloperations++;
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    LoginInfo.Add(dataReader["username"] + ""); //adja hozzá a listához a felhasználónevet
                    LoginInfo.Add(dataReader["password"] + ""); //adja hozzá a listához a jelszót
                    LoginInfo.Add(dataReader["admin"] + ""); //adja hozzá a listához hogy admin-e (0 > admin = igen)
                }
                dataReader.Close();
                this.CloseConnection();
                admin = Convert.ToInt32(LoginInfo[2]);
                if (LoginInfo[1] == password_encrypted && LoginInfo[0] == username && admin > 0) // ha a jelszó helyes akkor true
                {
                    return true; //helyes belépési adatok
                }
                else if (LoginInfo[0] == "") // ha üres a mező, akkor nincs ilyen felhasználó az adatbázisban
                {
                    panel.ShowMessage("Nincs ilyen felhasználó!", "HIBA");
                }
                else if (admin < 1)
                {
                    panel.ShowMessage("Nincs jogod a belépéshez!\nCsak adminoknak!", "HIBA");
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
                Sqloperations++;
                MySqlCommand cmd = new MySqlCommand(query, Connection);
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

        public void loadUserData(string user)
        {
            string[] read = new string[] {
                "id",
                "username",
                "password",
                "name",
                "admin",
                "birthdate",
                "address",
                "regdate",
                "lastvisit",
                "phonenumber",
                "email"
            };

            var userdata = getUserData(user, read);

            Users.UserInstance.Id = Convert.ToInt32(userdata[0]);
            Users.UserInstance.Username = userdata[1];
            Users.UserInstance.Password = userdata[2];
            Users.UserInstance.Name = userdata[3];
            Users.UserInstance.Admin = Convert.ToInt32(userdata[4]);
            Users.UserInstance.Birthdate = Convert.ToDateTime(userdata[5]);
            Users.UserInstance.Address = userdata[6];
            Users.UserInstance.Regdate = Convert.ToDateTime(userdata[7]);
            Users.UserInstance.Lastvisit = Convert.ToDateTime(userdata[8]);
            Users.UserInstance.Phonenumber = userdata[9];
            Users.UserInstance.Email = userdata[10];
        }

        public void CreateUser(string username, string password, string name, DateTime birthdate, string address, DateTime regdate, string phonenumber, string email, int admin)
        {
            var password_encrypted = encryption.EncryptString(password);
            string command = "INSERT INTO users (username, password, name, birthdate, address, regdate, phonenumber, email, admin) VALUES ('" + username + "','" + password_encrypted + "','" + name + "','" + birthdate.ToString("yyyy-MM-dd") + "','" + address + "','" + regdate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + phonenumber + "','" + email + "','" + admin + "')";
            Query(command);
        }

        public void AddVehicle(string owner, string type, string prodyear, string vin, string license, string color, string mileage, string engine, int ccm, string fueltype, int active)
        {
            string command = "INSERT INTO vehicles (owner, type, prodyear, vin, license, color, mileage, engine, ccm, fueltype, active) VALUES ('" + owner + "','" + type + "','" + prodyear + "','" + vin + "','" + license + "','" + color + "','" + mileage + "','" + engine + "','" + ccm + "','" + fueltype + "','" + active + "')";
            Query(command);
        }

        public bool checkEmptyTable(string table)
        {
            var query = "SELECT COUNT(*) from " + table;
            Sqloperations += 1;
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                var result = int.Parse(cmd.ExecuteScalar().ToString());
                return result == 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Váratlan hiba történt. " + ex.Message);
                return false;
            }
            finally
            { 
                CloseConnection();
            }

        }

        public List<Vehicles> getVehicleTable()
        {
            var query = "SELECT * FROM vehicles";
            List<Vehicles> vehicles = new List<Vehicles>();

            if (OpenConnection())
            {
                Sqloperations++;
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Vehicles vehicle = new Vehicles();
                    vehicle.Id = Convert.ToInt32(dataReader["vehid"]);
                    vehicle.Owner = (string)dataReader["owner"];
                    vehicle.Type = (string)dataReader["type"];
                    vehicle.Prodyear = Convert.ToInt32(dataReader["prodyear"]);
                    vehicle.Vin = (string)dataReader["vin"];
                    vehicle.License = (string)dataReader["license"];
                    vehicle.Color = (string)dataReader["color"];
                    vehicle.Mileage = (string)dataReader["mileage"];
                    vehicle.Engine = (string)dataReader["engine"];
                    vehicle.Ccm = Convert.ToInt32(dataReader["ccm"]);
                    vehicle.Fueltype = (string)dataReader["fueltype"];
                    vehicle.Added = (DateTime)dataReader["added"];
                    vehicle.Active = Convert.ToInt32(dataReader["active"]);
                    vehicles.Add(vehicle);
                }
                dataReader.Close();
                
            }
            CloseConnection();
            return vehicles;
        }

        public List<Users> getUsersTable()
        {
            var query = "SELECT * FROM users";
            List<Users> users = new List<Users>();

            if (OpenConnection())
            {
                Sqloperations++;
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Users user = new Users();
                    user.Id = Convert.ToInt32(dataReader["id"]);
                    user.Username = (string)dataReader["username"];
                    user.Password = (string)dataReader["password"];
                    user.Name = (string)dataReader["name"];
                    user.Admin = Convert.ToInt32(dataReader["admin"]);
                    user.Birthdate = (DateTime)dataReader["birthdate"];
                    user.Address = (string)dataReader["address"];
                    user.Regdate = (DateTime)dataReader["regdate"];
                    user.Phonenumber = (string)dataReader["phonenumber"];
                    user.Email = (string)dataReader["email"];
                    users.Add(user);
                }
                dataReader.Close();
            }
            CloseConnection();
            return users;
        }

        public string backupDirectory()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                var result = dialog.ShowDialog();
                return dialog.SelectedPath + "\\";
            }
        }

        public void Backup()
        {
            string constring = $"server={Server};user={Uid};pwd={Password};database={Database};convertzerodatetime=true;";
            string path = backupDirectory();
            string sqlPath = path + "SQL-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "sql";

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(sqlPath);
                        conn.Close();
                        panel.ShowMessage($"A fájlt sikeresen elmentettük a következő helyre:\n {sqlPath}", "SIKER");
                    }
                }
            }
        }
        public static int getMySqlOperations()
        {
            return Sqloperations;
        }

    }
}
