using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lethal_Devs_Project.MainFormTabs
{
    public partial class FourthTab : Form
    {
        MainForm panel = new MainForm();
        SqlConnection conn = new SqlConnection();
        bool windowIsOpen = true;

        public FourthTab()
        {
            InitializeComponent();
            loadCurrentMySQL();
        }

        private void FourthTab_Load(object sender, EventArgs e)
        {
            FormsClass.fourthform = this;
            runtimeUpdater();
            sqlOperationsUpdater();
            var size = getDatabaseSize().ToString();
            lblSqlSize.Text = GetBytesReadable(Convert.ToInt64(size));
        }

        private void runtimeUpdater()
        {
            Stopwatch runtimer = panel.runtimer();

            Task.Factory.StartNew(() =>
            {
                while(windowIsOpen)
                {

                    this.Invoke((MethodInvoker)delegate
                    {
                        TimeSpan ts = runtimer.Elapsed;
                        lblRuntime.Text = $"{ts.Hours}ó {ts.Minutes}p {ts.Seconds}mp";
                    });
                    Thread.Sleep(100);
                }
            });
        }

        private void sqlOperationsUpdater()
        {
            var operations = SqlConnection.getMySqlOperations();
            Task.Factory.StartNew(() =>
            {
                while (windowIsOpen)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblSqlOperations.Text = $"{SqlConnection.Sqloperations} db";
                    });
                    Thread.Sleep(100);
                }
            });
        }

        public string GetBytesReadable(long i)
        {
            // Get absolute value
            long absolute_i = (i < 0 ? -i : i);
            // Determine the suffix and readable value
            string suffix;
            double readable;
            if (absolute_i >= 0x1000000000000000) // Exabyte
            {
                suffix = "EB";
                readable = (i >> 50);
            }
            else if (absolute_i >= 0x4000000000000) // Petabyte
            {
                suffix = "PB";
                readable = (i >> 40);
            }
            else if (absolute_i >= 0x10000000000) // Terabyte
            {
                suffix = "TB";
                readable = (i >> 30);
            }
            else if (absolute_i >= 0x40000000) // Gigabyte
            {
                suffix = "GB";
                readable = (i >> 20);
            }
            else if (absolute_i >= 0x100000) // Megabyte
            {
                suffix = "MB";
                readable = (i >> 10);
            }
            else if (absolute_i >= 0x400) // Kilobyte
            {
                suffix = "KB";
                readable = i;
            }
            else
            {
                return i.ToString("0 B"); // Byte
            }
            // Divide by 1024 to get fractional value
            readable = (readable / 1024);
            // Return formatted number with suffix
            return readable.ToString("0.### ") + suffix;
        }

        private int getDatabaseSize()
        {
            var query = "SELECT SUM(ROUND(((DATA_LENGTH + INDEX_LENGTH) / 1024))) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '"+ conn.Database +"';";
            try
            {
                conn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn.Connection);
                var result = int.Parse(cmd.ExecuteScalar().ToString()) * 1024;
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Váratlan hiba történt. " + ex.Message);
                return 0;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void loadCurrentMySQL()
        {
            txtBoxIP.Text = conn.Server;
            txtBoxPort.Text = conn.Port;
            txtBoxUsername.Text = conn.Uid;
            txtBoxPassword.Text = conn.Password;
            txtBoxDatabase.Text = conn.Database;
        }

        private void saveCurrentMySQL()
        {
            conn.Server = txtBoxIP.Text;
            conn.Port = txtBoxPort.Text;
            conn.Uid = txtBoxUsername.Text;
            conn.Password = txtBoxPassword.Text;
            conn.Database = txtBoxDatabase.Text;
            if (conn.OpenConnection())
            {
                panel.ShowMessage("Sikeres csatlakozás az új adatokkal.\nAlap adatok megváltoztatva.", "SIKER");
                txtBoxIP.Text = Properties.Settings.Default.db_ip;
                txtBoxDatabase.Text = Properties.Settings.Default.db_database;
                txtBoxUsername.Text = Properties.Settings.Default.db_uid;
                txtBoxPassword.Text = Properties.Settings.Default.db_password;
                txtBoxPort.Text = Properties.Settings.Default.db_port;
            }
            else
            {
                panel.ShowMessage("Hibás csatlakozási adatok.\nAlap adatok visszaállítva.","HIBA");
                conn.Server = Properties.Settings.Default.db_ip;
                conn.Database = Properties.Settings.Default.db_database;
                conn.Uid = Properties.Settings.Default.db_uid;
                conn.Password = Properties.Settings.Default.db_password;
                conn.Port = Properties.Settings.Default.db_port;
            }
        }

        private void btnSaveMySQL_Click(object sender, EventArgs e)
        {
            if (txtBoxIP.Text == "") { panel.ShowMessage("Nem töltötted ki az IP mezőt!", "HIBA"); }
            else if (txtBoxPort.Text == "") { panel.ShowMessage("Nem töltötted ki a Port mezőt!", "HIBA"); }
            else if (txtBoxUsername.Text == "") { panel.ShowMessage("Nem töltötted ki a Felhasználónév mezőt!", "HIBA"); }
            else if (txtBoxPassword.Text == "") { panel.ShowMessage("Nem töltötted ki a Jelszó mezőt!", "HIBA"); }
            else if (txtBoxDatabase.Text == "") { panel.ShowMessage("Nem töltötted ki az Adatbázis mezőt!", "HIBA"); }
            else 
            { 
                saveCurrentMySQL();
                conn.CloseConnection();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            conn.Backup();
        }
    }
}
