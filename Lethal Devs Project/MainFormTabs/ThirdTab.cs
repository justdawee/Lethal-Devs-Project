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

        Users user = new Users();
        List<string> editlist = new List<string>();

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
                    var editformat = $"{user.Id} {user.Username} {user.Name} {user.Address} {user.Birthdate} {user.Email} {user.Regdate}";
                    var format = $"(ID: {user.Id}) [{user.Username}]: {user.Name}; {user.Address}; {user.Birthdate.ToString("yyyy-MM-dd")}; {user.Email}; Regisztrált: {user.Regdate.ToString("yyyy-MM-dd h:mm tt")}";
                    listUsers.Items.Add(format);
                    editlist.Add(editformat);
                }
                listUsers.HorizontalScrollbar = true;
            }
        }
    }
}
