using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSPP_ShoesSolution.source.model;

namespace TSPP_ShoesSolution.source.view
{
    public partial class LoginForm : Form
    {
        public ShoesShopUser loginUser;
        public LoginForm()
        {
            InitializeComponent();
            loginUser = new ShoesShopUser();

            passwordBox.PasswordChar = '*';
            passwordBox.MaxLength = 12;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == "")
            {
                MessageBox.Show("The login field must be filled in");
                return;
            }

            if (passwordBox.Text == "")
            {
                MessageBox.Show("The password field must be filled in");
                return;
            }

            loginUser.login = loginBox.Text;
            loginUser.password = passwordBox.Text;

            //TODO login process;
        }
    }
}
