using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lethal_Devs_Project.MainFormTabs
{
    public partial class ThirdTab : Form
    {
        SqlConnection conn = new SqlConnection();
        MainForm panel = new MainForm();
        addUserForm userForm = new addUserForm();
        editUserForm editForm = new editUserForm();

        List<string> editlist = new List<string>();

        private int selectedIndex;

        public int SelectedIndex { get => selectedIndex; set => selectedIndex = value; }

        public ThirdTab()
        {
            InitializeComponent();
        }

        private void ThirdTab_Load(object sender, EventArgs e)
        {
            FormsClass.thirdform = this;
            refreshUsersList();
        }

        public void refreshUsersList()
        {
            if (conn.checkEmptyTable("users") == false)
            {
                listUsers.Items.Clear();
                var users = conn.getUsersTable();

                foreach (var user in users)
                {
                    var editformat = $"{user.Id}^{user.Username}^{user.Name}^{user.Address}^{user.Birthdate}^{user.Email}^{user.Regdate}";
                    var format = $"(ID: {user.Id}) [{user.Username}]: {user.Name}; {user.Address}; {user.Birthdate.ToString("yyyy-MM-dd")}; {user.Email}; Regisztrált: {user.Regdate.ToString("yyyy-MM-dd h:mm tt")}";
                    listUsers.Items.Add(format);
                    editlist.Add(editformat);
                }
                listUsers.HorizontalScrollbar = true;
            }
        }

        public void delSelectedUser()
        {
            var selected = listUsers.SelectedIndex;
            int uid;
            List<string> temp = new List<string>();

            if (conn.checkEmptyTable("users") == false)
            {
                var users = conn.getUsersTable();
                foreach (var user in users)
                {
                    var editformat = $"{user.Id}^{user.Username}^{user.Name}^{user.Address}^{user.Birthdate}^{user.Email}^{user.Regdate}";
                    temp.Add(editformat);
                }
            }

            var selectedRow = temp[selected];
            var data = selectedRow.Split('^');
            uid = Convert.ToInt32(data[0]);

            var command = "DELETE FROM users WHERE users.id = '" + uid + "'";

            conn.Query(command);
            refreshUsersList();
            panel.ShowMessage("A felhasználót töröltük az adatbázisból!", "SIKER");
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refreshUsersList();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            userForm.ShowDialog();
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            var selected = listUsers.SelectedIndex;
            if (selected == -1)
            {
                panel.ShowMessage("Előbb válassz ki egy elemet a listán!", "HIBA");
            }
            else
            {
                SelectedIndex = listUsers.SelectedIndex;
                editForm.ShowDialog();
            }
        }

        private void delUserBtn_Click(object sender, EventArgs e)
        {
            var selected = listUsers.SelectedIndex;

            if (selected == -1)
            {
                panel.ShowMessage("Előbb válassz ki egy elemet a listán!", "HIBA");
            }
            else
            {
                delSelectedUser();
            }
        }
    }
}
