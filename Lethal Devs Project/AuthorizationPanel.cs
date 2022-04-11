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

namespace Lethal_Devs_Project
{
    public partial class AuthorizationPanel : Form
    {
        static SqlConnection conn = new SqlConnection(); //sql csatlakozás objektum
        public AuthorizationPanel()
        {
            InitializeComponent();
        }
        private void AuthorizationPanel_Load(object sender, EventArgs e)
        {
            usernameBox.Text = Properties.Settings.Default.username;
            passwordBox.Text = Properties.Settings.Default.password;

            if (Properties.Settings.Default.rememberme == true)
            {
                rememberMeCheckBox.Checked = true;
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // kilépés a programból
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
            var _username = username;
            var _password = password;

            if (conn.AttemptLogin(_username, _password))
            {
                AdminUI admin = new AdminUI();
                admin.Show();
                this.Hide();
                ShowMessage($"Sikeres bejelentkezés!\nÜdvözöllek, {username}", "INFO");
                if (rememberMeCheckBox.Checked)
                {
                    Properties.Settings.Default.username = usernameBox.Text;
                    Properties.Settings.Default.password = passwordBox.Text;
                    Properties.Settings.Default.rememberme = true;
                    Properties.Settings.Default.Save();
                }
            }
        }//felhasználó beléptetés
        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login(usernameBox.Text, passwordBox.Text);
        }//belépés gomb event

    }

}
