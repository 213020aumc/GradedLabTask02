namespace _213020SignUpLoginResetPassword
{
    partial class ForgotPasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailForReset = new System.Windows.Forms.TextBox();
            this.confirmNewPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.showForgotPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Your New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // emailForReset
            // 
            this.emailForReset.Location = new System.Drawing.Point(336, 91);
            this.emailForReset.Name = "emailForReset";
            this.emailForReset.Size = new System.Drawing.Size(198, 20);
            this.emailForReset.TabIndex = 4;
            // 
            // confirmNewPassword
            // 
            this.confirmNewPassword.Location = new System.Drawing.Point(336, 201);
            this.confirmNewPassword.Name = "confirmNewPassword";
            this.confirmNewPassword.PasswordChar = '*';
            this.confirmNewPassword.Size = new System.Drawing.Size(203, 20);
            this.confirmNewPassword.TabIndex = 5;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(336, 146);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(203, 20);
            this.newPassword.TabIndex = 6;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submitButton.Location = new System.Drawing.Point(336, 240);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(74, 25);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // showForgotPasswordCheckBox
            // 
            this.showForgotPasswordCheckBox.AutoSize = true;
            this.showForgotPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showForgotPasswordCheckBox.Location = new System.Drawing.Point(437, 227);
            this.showForgotPasswordCheckBox.Name = "showForgotPasswordCheckBox";
            this.showForgotPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.showForgotPasswordCheckBox.TabIndex = 8;
            this.showForgotPasswordCheckBox.Text = "Show Password";
            this.showForgotPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showForgotPasswordCheckBox.CheckedChanged += new System.EventHandler(this.forgotPasswordCheckBox_CheckedChanged);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.showForgotPasswordCheckBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.confirmNewPassword);
            this.Controls.Add(this.emailForReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPasswordForm";
            this.Text = "Forgot Password Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailForReset;
        private System.Windows.Forms.TextBox confirmNewPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.CheckBox showForgotPasswordCheckBox;
    }
}