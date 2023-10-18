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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string email = emailForReset.Text;
            string newPassWord = newPassword.Text;
            string confirmNewPassWord = confirmNewPassword.Text;

            // Add validation logic to ensure new password and confirmation match.
            if (newPassWord != confirmNewPassWord)
            {
                MessageBox.Show("New password and confirm password do not match.", "Password Reset Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Implement logic to reset the password for the user associated with the given email.
            // You may need to interact with your database or user management system to update the password.

            // After successfully resetting the password, you can display a success message.
            MessageBox.Show("Password reset successfully.", "Password Reset Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally, you can close the ForgotPasswordForm and return to the loginForm.
            this.Close();
        }

        private void forgotPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showForgotPasswordCheckBox.Checked)
            {
                newPassword.PasswordChar = '\0';
                confirmNewPassword.PasswordChar = '\0';
            }
            else
            {
                newPassword.PasswordChar = '*';
                confirmNewPassword.PasswordChar = '*';
            }
        }
    }
}
