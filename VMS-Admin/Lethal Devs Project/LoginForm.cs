using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using System.IO;
using System.Security.Cryptography;

namespace Lethal_Devs_Project
{
    public partial class LoginForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        static SqlConnection conn = new SqlConnection(); //sql csatlakozás objektum

        public LoginForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void AuthorizationPanel_Load(object sender, EventArgs e)
        {
            //mentett adatok betöltése amikor betölt a panel
            if (Properties.Settings.Default.rememberme == true)
            {
                rememberMeCheckBox.Checked = true;
                usernameBox.Text = Properties.Settings.Default.username;
                passwordBox.Text = Properties.Settings.Default.password;
            }
            else
            {
                usernameBox.Text = "";
                passwordBox.Text = "";
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
        } 
        private void exitBtn_Click(object sender, EventArgs e)
        {
            exitApp();
        }//kilépés a programból
        public void ShowMessage(string title, string message)
        {
            MessageBox.Show(title, message);
        }//üzenetek kiíratása.
        private void showPwPic_MouseDown(object sender, MouseEventArgs e)
        {
            passwordBox.PasswordChar = '\0';
        }//jelszó felfedése amíg tart a lenyomás
        private void showPwPic_MouseUp(object sender, MouseEventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }//jelszó mutatás visszaállító
        private void forgotBtn_Click(object sender, EventArgs e)
        {
            LostPasswordForm lostpwform = new LostPasswordForm();
            this.Hide();
            lostpwform.ShowDialog();
            this.Close(); 
        }//elfelejtett jelszó event
        public void Login(string username, string password)
        {
            if (conn.AttemptLogin(username, password))
            {
                if (rememberMeCheckBox.Checked)
                {
                    Properties.Settings.Default.username = usernameBox.Text;
                    Properties.Settings.Default.password = passwordBox.Text;
                    Properties.Settings.Default.rememberme = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.rememberme = false;
                    Properties.Settings.Default.Save();
                }

                ShowMessage($"Sikeres bejelentkezés!\nÜdvözöllek, {username}", "INFO"); //Üdvözlő üzenet megjelenítése.
                conn.loadUserData(username);

                var currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                conn.Query("UPDATE users SET lastvisit = '" + currentTime + "' WHERE username = '" + username + "';");

                MainForm main_form = new MainForm();
                this.ShowInTaskbar = false;
                this.Hide();
                main_form.ShowDialog();
            }
            
        }//felhasználó beléptetés
        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login(usernameBox.Text, passwordBox.Text);
        }//belépés gomb event
        public void exitApp()
        { 
            Application.Exit();
        }//program bezárás


    }

}
