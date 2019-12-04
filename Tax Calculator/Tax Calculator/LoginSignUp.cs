using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_Calculator
{
    public partial class LoginSignUp : Form
    {

        public LoginSignUp()
        {
            InitializeComponent();
        }

        private void LoginSignUp_Load(object sender, EventArgs e)
        {
            Text = "Login";
            usernameTxtBx.GotFocus += (UsernameRemoveText);
            usernameTxtBx.LostFocus += (UsernameAddText);
            passwordTxtBx.GotFocus += (PasswordRemoveText);
            passwordTxtBx.LostFocus += (PasswordAddText);

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameRemoveText(object sender, EventArgs e)
        {
            if (usernameTxtBx.Text == "Enter your Username here")
                usernameTxtBx.Text = "";
        }

        private void UsernameAddText(object sender, EventArgs e)
        {
            if (usernameTxtBx.Text.Length == 0)
                usernameTxtBx.Text = "Enter your Username here";
        }
        private void PasswordAddText(object sender, EventArgs e)
        {
            if (passwordTxtBx.Text.Length == 0)
                passwordTxtBx.Text = "Enter your Password here";
        }
        private void PasswordRemoveText(object sender, EventArgs e)
        {
            if (passwordTxtBx.Text == "Enter your Password here")
                passwordTxtBx.Text = "";
        }
    }
}
