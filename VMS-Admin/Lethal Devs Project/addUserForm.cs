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
    public partial class addUserForm : Form
    {
        SqlConnection conn = new SqlConnection();
        MainForm panel = new MainForm(); //üzenetek kiírásához szükséges

        bool usrnameclick, pwclick, nameclick, addressclick, emailclick = false;

        public addUserForm()
        {
            InitializeComponent();
        }
        private int checkAdmin()
        {
            if (checkboxAdminNo.Checked)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private void txtboxUsername_Click(object sender, EventArgs e)
        {
            if (usrnameclick == false)
            {
                txtboxUsername.Text = "";
                usrnameclick = true;
            }
        }
        private void txtboxPw_Click(object sender, EventArgs e)
        {
            if (pwclick == false)
            {
                txtboxPw.Text = "";
                pwclick = true;
            }
        }
        private void txtboxName_Click(object sender, EventArgs e)
        {
            if (nameclick == false)
            {
                txtboxName.Text = "";
                nameclick = true;
            }
        }
        private void txtboxPhone_Click(object sender, EventArgs e)
        {

        }

        private void addUserForm_Load(object sender, EventArgs e)
        {

        }

        private void checkboxAdminNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxAdminNo.Checked)
            {
                checkboxAdminYes.Checked = false;
            }
        }
        private void checkboxAdminYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxAdminYes.Checked)
            {
                checkboxAdminNo.Checked = false;
            }
        }

        private void txtboxAddress_Click(object sender, EventArgs e)
        {
            if (addressclick == false)
            {
                txtboxAddress.Text = "";
                addressclick = true;
            }
        }
        private void txtboxEmail_Click(object sender, EventArgs e)
        {
            if (emailclick == false)
            {
                txtboxEmail.Text = "";
                emailclick = true;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.CreateUser(
                txtboxUsername.Text,
                txtboxPw.Text,
                txtboxName.Text,
                bornDatePicker.Value,
                txtboxAddress.Text,
                DateTime.Now,
                txtboxPhone.Text,
                txtboxEmail.Text,
                checkAdmin()
                );

            panel.ShowMessage("A felhasználót sikeresen hozzáadtuk az adatbázishoz.", "Siker");

            txtboxUsername.Text = "MintaJanos";
            txtboxPw.Text = "MintaJelszo";
            txtboxName.Text = "MintaJanos";
            bornDatePicker.Value = DateTime.Now;
            txtboxAddress.Text = "1234 Budapest, Minta utca 12.";
            txtboxEmail.Text = "minta@gmail.com";
            txtboxPhone.Text = "06701234567";
            checkboxAdminNo.Checked = true;
            checkboxAdminYes.Checked = false;

            usrnameclick = false; pwclick = false; nameclick = false; addressclick = false; emailclick = false;

            FormsClass.thirdform.refreshUsersList();

            this.Close();
        }
    }
}
