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
    public partial class parentForm : Form
    {
        String username_ = "Brian";
        String password_ = "bowles";
        loginForm newLogin = new loginForm();
        calculatorForm newCalc = new calculatorForm();

        public parentForm()
        {
            InitializeComponent();
        }

        private void parentForm_Load(object sender, EventArgs e)
        {
            newLogin.MdiParent = this;
            newCalc.MdiParent = this;
            newLogin.Show();
        }

        private void parentForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (newLogin.Username == username_ && newLogin.Password == password_)
                newCalc.Show();
        }
    }
}
