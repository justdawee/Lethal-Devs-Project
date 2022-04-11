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
    public partial class AdminUI : Form
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
        public AdminUI()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//kilépés gomb

        private void AdminUI_Load(object sender, EventArgs e)
        {

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
        }
        private void btnFirst_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst);
        }
        private void btnSecond_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst); //default fül BUGFIX
            btnClickDesign(btnSecond);
        }
        private void btnSecond_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnSecond);
        }
        private void btnThird_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst); //default fül BUGFIX
            btnClickDesign(btnThird);
        }
        private void btnThird_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnThird);
        }
        private void btnFourth_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst); //default fül BUGFIX
            btnClickDesign(btnFourth);
        }
        private void btnFourth_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFourth);
        }
        private void btnBottom_Click(object sender, EventArgs e)
        {
            btnLeaveDesign(btnFirst); //default fül BUGFIX
            btnClickDesign(btnBottom);
        }
        private void btnBottom_Leave(object sender, EventArgs e)
        {
            btnLeaveDesign(btnBottom);
        }
        //UI DESIGN VÉGE
    }
}
