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

namespace Lethal_Devs_Project
{
    public partial class MainForm : Form
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

        bool searchClicked = false;

        public MainForm()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public void ShowMessage(string title, string message)
        {
            MessageBox.Show(title, message);
        }//üzenetek kiíratása.
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//kilépés gomb
        private void AdminUI_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Users.UserInstance.Username;

            pnlFormLoader.Controls.Clear();
            var first_tab = FormsClass.firstform;
            first_tab.FormBorderStyle = FormBorderStyle.None;
            pnlFormLoader.Controls.Add(first_tab);
            first_tab.Show();
        }

        //UI DESIGN RÉSZLEG
        private void btnClickDesign(Button btn, PictureBox pic)
        {
            pnlNav.Height = btn.Height;
            pnlNav.Top = btn.Top;
            pnlNav.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);
            pic.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnLeaveDesign(Button btn, PictureBox pic)
        {
            btn.BackColor = Color.FromArgb(24, 30, 54);
            pic.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            btnClickDesign(btnFirst, picFirst);
            lblTitle.Text = "Főoldal";

            pnlFormLoader.Controls.Clear();
            var first_tab = FormsClass.firstform;
            first_tab.FormBorderStyle = FormBorderStyle.None;
            pnlFormLoader.Controls.Add(first_tab);
            first_tab.Show();
        }
        private void btnFirst_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst, picFirst);
        }
        private void btnSecond_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst, picFirst);
            btnClickDesign(btnSecond, picSecond);
            lblTitle.Text = "Járművek";

            var second_tab = FormsClass.secondform;
            pnlFormLoader.Controls.Clear();
            second_tab.FormBorderStyle = FormBorderStyle.None;
            pnlFormLoader.Controls.Add(second_tab);
            second_tab.Show();
        }
        private void btnSecond_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnSecond, picSecond);
        }
        private void btnThird_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst, picFirst);
            btnClickDesign(btnThird, picThird);
            lblTitle.Text = "Felhasználók";

            pnlFormLoader.Controls.Clear();
            var third_tab = FormsClass.thirdform;
            third_tab.FormBorderStyle = FormBorderStyle.None;
            pnlFormLoader.Controls.Add(third_tab);
            third_tab.Show();
        }
        private void btnThird_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnThird, picThird);
        }
        private void btnFourth_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst, picFirst);
            btnClickDesign(btnFourth, picFourth);
            lblTitle.Text = "Szerver";

            pnlFormLoader.Controls.Clear();
            var fourth_tab = FormsClass.fourthform;
            fourth_tab.FormBorderStyle = FormBorderStyle.None;
            pnlFormLoader.Controls.Add(fourth_tab);
            fourth_tab.Show();
        }
        private void btnFourth_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFourth, picFourth);
        }
        private void btnBottom_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst, picFirst);
            btnClickDesign(btnBottom, picBottom);
            lblTitle.Text = "Beállítások";

            pnlFormLoader.Controls.Clear();
            var bottom_tab = FormsClass.bottomform;
            bottom_tab.FormBorderStyle = FormBorderStyle.None;
            pnlFormLoader.Controls.Add(bottom_tab);
            bottom_tab.Show();
        }
        private void btnBottom_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnBottom, picBottom);
        }

        private void searchBar_Click(object sender, EventArgs e)
        {
            if (searchClicked == false)
            {
                searchBar.Text = "";
                searchClicked = true;
            }
        }

        //UI DESIGN VÉGE
    }
}
