using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string usernameInput = txtuser.Text;
            string passwordInput = txtpass.Text;
            Users userInstance = new Users();
            List<Users> userlist = userInstance.PopulateUsers();
            bool canlogin = false;

            foreach (Users item in userlist)
            {
                if (item.Username == usernameInput && item.Password == passwordInput)
                {
                    canlogin = true;

                }
              else  if (canlogin==true)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username and password");
                }
                txtuser.Clear();
                txtpass.Clear();
            }
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            Registration register = new Registration();
            register.Show();
            this.Hide();
        }
    }
}
