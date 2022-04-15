using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lethal_Devs_Project
{
    internal class Users
    {
        private int id;
        private string username;
        private string password;
        private string name;
        private int admin;
        private DateTime birthdate;
        private string address;
        private DateTime regdate;
        private DateTime lastvisit;
        private string phonenumber;
        private string email;

        private static readonly Users _user = new Users();
        public static Users UserInstance
        {
            get { return _user; }
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public int Admin { get => admin; set => admin = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Regdate { get => regdate; set => regdate = value; }
        public DateTime Lastvisit { get => lastvisit; set => lastvisit = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Email { get => email; set => email = value; }
    }
}
