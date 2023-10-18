using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213020SignUpLoginResetPassword
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }


        string userName;
        string passWord;
        private void username_TextChanged(object sender, EventArgs e)
        {
            userName = username.Text.ToString();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            passWord = password.Text.ToString();
        }

        private void showLoginPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showLoginPasswordCheckBox.Checked)
            {
                password.PasswordChar = '\0';
                
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && password.Text == "")
            {
                MessageBox.Show("Username and Password Fields are Empty. ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username.Text == userName && password.Text == passWord)
            {
                MessageBox.Show("You are Login Successfully. ", "Login Success. ");
                string data = "\nUsername: " + userName + "\n Password: " + passWord;
                MessageBox.Show(data, "\nLogin Data ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Password or Username, Please Try Again. ", "Login Failed." , MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Text = "";
                password.Text = "";
                username.Focus();
            }
            
        }

        private void clearButtonLogin_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            signUpForm SignUp = new signUpForm();
            SignUp.Show();
            this.Hide();
        }

        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPassword = new ForgotPasswordForm();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
