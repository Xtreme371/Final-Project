using System;
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

        public List<Users> PopulateUsers()
        {
            List<Users> user = new List<Users>();
            Filehandler fh = new Filehandler();

            List<string> data = fh.ReadUsers("Login.txt");

            foreach (string item in data)
            {
                string[] values = item.Split(',');
                user.Add(new Users(values[0], values[1], values[2], values[3]));
            }
            return user;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}:{3}", name, surname, username, password);
        }
    }
}
