﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Users
    {
        private string name;
        private string surname;
        private string username;
        private string password;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // constructors
        public Users(string name, string surname, string username, string password)
        {
            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
        }

        public Users()
        {

        }

        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}:{3}", name, surname, username, password);
        }
    }
}
