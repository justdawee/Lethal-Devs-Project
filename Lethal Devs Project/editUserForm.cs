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
    public partial class editUserForm : Form
    {
        SqlConnection conn = new SqlConnection();
        MainForm panel = new MainForm(); //üzenetek kiírásához szükséges

        private List<string> edituserlist = new List<string>();
        public editUserForm()
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

        private void processUsersList()
        {
            if (conn.checkEmptyTable("users") == false)
            {
                var users = conn.getUsersTable();

                foreach (var user in users)
                {
                    var editformat = $"{user.Id}^{user.Username}^{user.Name}^{user.Address}^{user.Birthdate}^{user.Email}^{user.Phonenumber}^{user.Regdate}^{user.Admin}";
                    edituserlist.Add(editformat);
                }
            }
        }

        private void loadUsersData()
        {
            var thirdform = FormsClass.thirdform;
            var selectedRow = edituserlist[thirdform.SelectedIndex];

            var data = selectedRow.Split('^');

            var borndate = data[4];
            var regdate = data[7];

            hiddenId.Text = data[0];
            txtboxUsername.Text = data[1];
            txtboxName.Text = data[2];
            txtboxAddress.Text = data[3];
            bornDatePicker.Value = Convert.ToDateTime(borndate);
            txtboxEmail.Text = data[5];
            txtboxPhone.Text = data[6];
            regDatePicker.Value = Convert.ToDateTime(regdate);

            var admin = Convert.ToInt32(data[8]);

            if (admin == 0)
            {
                checkboxAdminNo.Checked = true;
                checkboxAdminYes.Checked = false;
            }
            else
            {
                checkboxAdminNo.Checked = false;
                checkboxAdminYes.Checked = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var uid = hiddenId.Text;
            var username = txtboxUsername.Text;
            var name = txtboxName.Text;
            var address = txtboxAddress.Text;
            var birthdate = bornDatePicker.Value;
            var email = txtboxEmail.Text;
            var phone = txtboxPhone.Text;
            var regdate = regDatePicker.Value;
            var admin = checkAdmin();

            var command = "UPDATE users SET username = '" + username + "', name = '" + name + "', address = '" + address + "', birthdate = '" + birthdate.ToString("yyyy-MM-dd") + "', email = '" + email + "', phone = '" + phone + "', regdate = '" + regdate.ToString("yyyy-MM-dd HH:mm:ss") + "', admin = '" + admin + "' WHERE users.id = " + uid + ";";
            conn.Query(command);

            panel.ShowMessage("A jármű módosítása felkerült az adatbázisba.", "Siker");
            FormsClass.secondform.refreshVehiclesList();
            this.Close();
        }

        private void editUserForm_Load(object sender, EventArgs e)
        {
            processUsersList();
            loadUsersData();
        }

        private void checkboxAdminYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxAdminYes.Checked)
            {
                checkboxAdminNo.Checked = false;
            }
        }

        private void checkboxAdminNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxAdminNo.Checked)
            {
                checkboxAdminYes.Checked = false;
            }
        }
    }
}
