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

        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // kilépés a programból
        }

        public void ShowMessage(string title, string message)
        {
            MessageBox.Show(title, message);
        }

        private void showPwPic_MouseDown(object sender, MouseEventArgs e)
        {
            passwordBox.PasswordChar = '\0';
        }

        private void showPwPic_MouseUp(object sender, MouseEventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }

        private void forgotBtn_Click(object sender, EventArgs e)
        {
            LostPasswordForm lostpwform = new LostPasswordForm();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            lostpwform.ShowDialog();    //Show the New Form
            this.Close();    //Close the Old Form
        }

        public static void Login(string username, string password)
        {
            var _username = username;
            var _password = password;

            if (conn.AttemptLogin(_username, _password))
            {
                //TODO
                Console.WriteLine("Successful Login");
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login(usernameBox.Text, passwordBox.Text);
        }

    }

}
