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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string surname = txtsurname.Text;
            string username = txtuser.Text;
            string password = txtpass.Text;
            Users userInstance = new Users();
            List<Users> userlist = userInstance.PopulateUsers();
            bool canSignIn = false;
            Filehandler fh = new Filehandler();
            //check values

            foreach (Users item in userlist)
            {
                if (name.Length == 0 || surname.Length == 0 || username.Length == 0 || password.Length == 0)
                {
                    MessageBox.Show("Please provide information for ALL fields", "Registration unsuccessful", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                }
                else
                {
                    string userDetails = string.Format("{0}:{1}:{2}:{3}", name, surname, username, password);

                    fh.WriteData("Login.txt", userDetails);//add new user to the textfile;

                    MessageBox.Show("New user has been  registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtname.Clear();
                    txtsurname.Clear();
                    txtuser.Clear();
                    txtpass.Clear();

                }
            }
           
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
