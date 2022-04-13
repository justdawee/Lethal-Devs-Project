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

        static LoginForm panel = new LoginForm(); //Üzenet kiíráshoz példányosítani kell a form-ot.
        static SqlConnection conn = new SqlConnection(); //sql csatlakozás objektum


        public MainForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.pnlFormLoader.Controls.Clear();
            FirstTab first_tab = new FirstTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            first_tab.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(first_tab);
            first_tab.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//kilépés gomb
        private void AdminUI_Load(object sender, EventArgs e)
        {
            lblUsername.Text = User.UserInstance.Username;
        }

        //UI DESIGN RÉSZLEG
        private void btnClickDesign(Button btn)
        {
            pnlNav.Height = btn.Height;
            pnlNav.Top = btn.Top;
            pnlNav.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnLeaveDesign(Button btn)
        {
            btn.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            btnClickDesign(btnFirst);
            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            FirstTab first_tab = new FirstTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            first_tab.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(first_tab);
            first_tab.Show();
        }
        private void btnFirst_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst);
        }
        private void btnSecond_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst); //default fül BUGFIX
            btnClickDesign(btnSecond);
            lblTitle.Text = "Second";
            this.pnlFormLoader.Controls.Clear();
            MainFormTabs.SecondTab second_tab = new MainFormTabs.SecondTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            second_tab.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(second_tab);
            second_tab.Show();
        }
        private void btnSecond_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnSecond);
        }
        private void btnThird_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst); //default fül BUGFIX
            btnClickDesign(btnThird);

            this.pnlFormLoader.Controls.Clear();
            MainFormTabs.ThirdTab third_tab = new MainFormTabs.ThirdTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            third_tab.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(third_tab);
            third_tab.Show();
        }
        private void btnThird_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnThird);
        }
        private void btnFourth_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst); //default fül BUGFIX
            btnClickDesign(btnFourth);

            this.pnlFormLoader.Controls.Clear();
            MainFormTabs.FourthTab fourth_tab = new MainFormTabs.FourthTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fourth_tab.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(fourth_tab);
            fourth_tab.Show();
        }
        private void btnFourth_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFourth);
        }
        private void btnBottom_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst); //default fül BUGFIX
            btnClickDesign(btnBottom);

            this.pnlFormLoader.Controls.Clear();
            MainFormTabs.BottomTab bottom_tab = new MainFormTabs.BottomTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            bottom_tab.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(bottom_tab);
            bottom_tab.Show();
        }
        private void btnBottom_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnBottom);
        }
        //UI DESIGN VÉGE
    }
}
