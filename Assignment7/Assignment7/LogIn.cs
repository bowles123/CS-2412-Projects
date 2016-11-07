using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class loginForm : Form
    {
        public String Username { private set; get; }
        public String Password { private set; get; }

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Username = loginTextBox.Text;
            Password = passwordTextBox.Text;

            if (Username == "Brian" && Password == "bowles")
                this.Close();
            else
            {
                incorrectLoginTextBox.Visible = true;
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }
    }
}
