using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lethal_Devs_Project
{
    public partial class AuthorizationPanel : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public AuthorizationPanel()
        {
            InitializeComponent();
        }

        private void AuthorizationPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; 
            start_point = new Point(e.X, e.Y);
        }

        private void AuthorizationPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void AuthorizationPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // kilépés a programból
        }

        private void showPwPic_MouseDown(object sender, MouseEventArgs e)
        {
            passwordBox.PasswordChar = '\u0000'; //amíg a balklikk lenyomva marad, eltűnik a jelszóról a titkosítás.
        }

        private void showPwPic_MouseUp(object sender, MouseEventArgs e)
        {
            passwordBox.PasswordChar = '*'; //ha már nem nyomjuk a balklikket akkor tegye vissza a titkosítást.
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void forgotBtn_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
