using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lethal_Devs_Project
{
    internal class User
    {
        private int id;
        private string username;
        private string password;
        private bool admin;
        private DateTime birthdate;
        private string address;
        private DateTime regdate;
        private string phonenumber;
        private string email;

        private static readonly User _user = new User();
        public static User UserInstance
        {
            get { return _user; }
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public DateTime Regdate { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
    }
}
