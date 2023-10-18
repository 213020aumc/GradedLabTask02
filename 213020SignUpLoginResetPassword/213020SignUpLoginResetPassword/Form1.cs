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
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }
        string userName;
        string pass;
        string confirmPass;
        string email;

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if(username.Text == "" && emailSignUp.Text == "" && password.Text == "" && confirmPassword.Text == "")
            {
                MessageBox.Show("Fields are Empty. ", "Registeration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Text = "";
                emailSignUp.Text = "";
                password.Text = "";
                confirmPassword.Text = "";
                username.Focus();
            }
            else if (username.Text == "")
            {
                    MessageBox.Show("Username Field is Empty. ", "Registeration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Text = "";
                    username.Focus();
            }
            else if(emailSignUp.Text == "")
            {
                    MessageBox.Show("Email Field is Empty. ", "Registeration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailSignUp.Text = "";
                    emailSignUp.Focus();
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Password Field is Empty. ", "Registeration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Text = "";
                password.Focus();
            }
            else if (confirmPassword.Text == "")
            {
                    MessageBox.Show("Confirm Password Field is Empty. ", "Registeration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    confirmPassword.Text = "";
                    confirmPassword.Focus();
            }
            else if (password.Text != confirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password does not matach, Please re-enter the Password. ", "Registeration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Text = "";
                confirmPassword.Text = "";
                password.Focus();
            }
            else if(username.Text == userName && emailSignUp.Text == email && password.Text == pass  && confirmPassword.Text == confirmPass )
            {
                MessageBox.Show("Your account has been Successfully Created. ", "Registeration Success. ");
                string data = "User: " + username + "\nPassword: " + pass + " " + "\nEmail:" + email + " ";
                MessageBox.Show(data, "SignUp Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                loginForm login = new loginForm();
                login.Show();
            }
            
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            userName = username.Text.ToString();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            pass = password.Text.ToString();
        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {
            confirmPass = confirmPassword.Text.ToString();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(showPasswordCheckBox.Checked)
            {
                password.PasswordChar = '\0';
                confirmPassword.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
                confirmPassword.PasswordChar = '*';
            }
        }

        private void clearButtonSignUp_Click(object sender, EventArgs e)
        {
            username.Text = "";
            emailSignUp.Text = "";
            password.Text = "";
            confirmPassword.Text = "";
            username.Focus();
        }

        private void labelBackToLogin_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void emailSignUp_TextChanged(object sender, EventArgs e)
        {
            email = emailSignUp.Text.ToString();
        }
    }
}
