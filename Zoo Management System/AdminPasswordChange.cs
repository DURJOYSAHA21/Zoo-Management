using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class AdminPasswordChange : Form
    {
        private int userId;
        private bool isVerified = false;
        public AdminPasswordChange(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            newPassword.Enabled = false;
            confirmPassword.Enabled = false;
            okButton.Enabled = false;
        }

        private void oldpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            string oldPass = oldpassword.Text.Trim();

            if (string.IsNullOrEmpty(oldPass))
            {
                MessageBox.Show("Please enter your current password");
                return;
            }

            string query = $"SELECT Password FROM [User] WHERE UserID = {userId}";
            DataTable result = DataAccess.GetData(query);

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("User not found!");
                return;
            }

            string storedPassword = result.Rows[0]["Password"].ToString();

            if (oldPass == storedPassword)
            {
                isVerified = true;
                newPassword.Enabled = true;
                confirmPassword.Enabled = true;
                okButton.Enabled = true;
                MessageBox.Show("Verification successful! You can now change your password");
            }
            else
            {
                MessageBox.Show("Incorrect current password");
                oldpassword.Focus();
            }

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!isVerified)
            {
                MessageBox.Show("Please verify your current password first");
                return;
            }

            string newPass = newPassword.Text.Trim();
            string confirmPass = confirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please enter and confirm your new password");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("New passwords do not match");
                return;
            }

            if (newPass.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }

            if (!newPass.Any(char.IsUpper) || !newPass.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Password must contain at least one uppercase and one special character");
                return;
            }

            string updateQuery = $"UPDATE [User] SET Password = '{newPass}' WHERE UserID = {userId}";
            bool success = DataAccess.Execute(updateQuery);

            if (success)
            {
                MessageBox.Show("Password changed successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to change password. Please try again.");
            }
        }

        private void showPasswordButton2_Click(object sender, EventArgs e)
        {
            if (oldpassword.PasswordChar == '*')
            {
                oldpassword.PasswordChar = '\0';
            }
            else
            {
                oldpassword.PasswordChar = '*';
            }
        }

        private void showPasswordButton3_Click(object sender, EventArgs e)
        {
            if (newPassword.PasswordChar == '*')
            {
                newPassword.PasswordChar = '\0';
            }
            else
            {
                newPassword.PasswordChar = '*';
            }
        }

        private void showPasswordButton4_Click(object sender, EventArgs e)
        {
            if (confirmPassword.PasswordChar == '*')
            {
                confirmPassword.PasswordChar = '\0';
            }
            else
            {
                confirmPassword.PasswordChar = '*';
            }
        }
    }
}
