namespace _213020SignUpLoginResetPassword
{
    partial class signUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButtonSignUp = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelBackToLogin = new System.Windows.Forms.Label();
            this.emailSignUp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(164, 72);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(167, 20);
            this.username.TabIndex = 2;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(164, 120);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(167, 20);
            this.password.TabIndex = 4;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Get Started";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(164, 171);
            this.confirmPassword.Multiline = true;
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(167, 20);
            this.confirmPassword.TabIndex = 7;
            this.confirmPassword.TextChanged += new System.EventHandler(this.confirmPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(229, 197);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.showPasswordCheckBox.TabIndex = 8;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // clearButtonSignUp
            // 
            this.clearButtonSignUp.BackColor = System.Drawing.SystemColors.Highlight;
            this.clearButtonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButtonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButtonSignUp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearButtonSignUp.Location = new System.Drawing.Point(162, 230);
            this.clearButtonSignUp.Name = "clearButtonSignUp";
            this.clearButtonSignUp.Size = new System.Drawing.Size(76, 33);
            this.clearButtonSignUp.TabIndex = 9;
            this.clearButtonSignUp.Text = "Clear";
            this.clearButtonSignUp.UseVisualStyleBackColor = false;
            this.clearButtonSignUp.Click += new System.EventHandler(this.clearButtonSignUp_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.signUpButton.Location = new System.Drawing.Point(256, 230);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(86, 33);
            this.signUpButton.TabIndex = 10;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Already have an Account?";
            // 
            // labelBackToLogin
            // 
            this.labelBackToLogin.AutoSize = true;
            this.labelBackToLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelBackToLogin.Location = new System.Drawing.Point(208, 303);
            this.labelBackToLogin.Name = "labelBackToLogin";
            this.labelBackToLogin.Size = new System.Drawing.Size(80, 13);
            this.labelBackToLogin.TabIndex = 12;
            this.labelBackToLogin.Text = "Back to LOGIN";
            this.labelBackToLogin.Click += new System.EventHandler(this.labelBackToLogin_Click);
            // 
            // emailSignUp
            // 
            this.emailSignUp.Location = new System.Drawing.Point(370, 72);
            this.emailSignUp.Multiline = true;
            this.emailSignUp.Name = "emailSignUp";
            this.emailSignUp.Size = new System.Drawing.Size(167, 20);
            this.emailSignUp.TabIndex = 14;
            this.emailSignUp.TextChanged += new System.EventHandler(this.emailSignUp_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 320);
            this.Controls.Add(this.emailSignUp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelBackToLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.clearButtonSignUp);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "signUpForm";
            this.Text = "Sign Up Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Button clearButtonSignUp;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelBackToLogin;
        private System.Windows.Forms.TextBox emailSignUp;
        private System.Windows.Forms.Label label6;
    }
}

