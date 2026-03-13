using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace ZooManagementSystem
{
    public partial class ResetPass : Form
    {
        private int userId;
        public ResetPass(int uid)
        {
            InitializeComponent();
            userId = uid;
        }
        private string GetPassStrength(string pass)
        {
            int score = 0;
            if (pass.Length >= 8) score++;
            if (Regex.IsMatch(pass, @"[A-Z]")) score++;
            if (Regex.IsMatch(pass, @"[a-z]")) score++;
            if (Regex.IsMatch(pass, @"[0-9]")) score++;
            if (Regex.IsMatch(pass, @"[\W_]")) score++;

            if (pass.Length < 8 || score <= 2)
                return "Weak";
            else if (score == 3 || score == 4)
                return "Medium";
            else
                return "Strong";
        }

        private void txtPassReset_TextChanged(object sender, EventArgs e)
        {
            string strength = GetPassStrength(txtPassReset.Text);
            lblStrength.Visible = true;
            if (txtPassReset.Text.Length == 0)
            {
                lblStrength.Text = "Enter Password";
                lblStrength.ForeColor = Color.Black;
                return;
            }
            else
            {
                lblStrength.Text = strength;
            }
            switch (strength)
            {
                case "Weak":
                    lblStrength.ForeColor = Color.Red;
                    break;
                case "Medium":
                    lblStrength.ForeColor = Color.Purple;
                    break;
                case "Strong":
                    lblStrength.ForeColor = Color.DarkGreen;
                    break;
            }
        }

        private void txtConPassReset_TextChanged(object sender, EventArgs e)
        {
            if (txtConPassReset.Text == "")
            {
                lblMatch.Visible = false;
                return;
            }
            if (txtPassReset.Text != txtConPassReset.Text)
            {
                lblMatch.Text = "Passwords do not match";
                lblMatch.ForeColor = Color.Red;
                lblMatch.Visible = true;
            }
            else
            {
                lblMatch.Text = "Password matched!";
                lblMatch.ForeColor = Color.DarkGreen;
                lblMatch.Visible = true;
            }
        }

        private void btnShowPass2_Click(object sender, EventArgs e)
        {
            if (txtPassReset.Text == "")
                return;
            else if (txtPassReset.UseSystemPasswordChar == false)
            {
                txtPassReset.UseSystemPasswordChar = true;
                btnShowPass2.Text = "Hide";
            }
            else
            {
                txtPassReset.UseSystemPasswordChar = false;
                btnShowPass2.Text = "Show";
            }
        }

        private void btnShowCon2_Click(object sender, EventArgs e)
        {
            if (txtConPassReset.Text == "")
            {
                return;
            }

            else if (txtConPassReset.UseSystemPasswordChar == false)
            {
                txtConPassReset.UseSystemPasswordChar = true;
                btnShowCon2.Text = "Hide";
            }
            else
            {
                txtConPassReset.UseSystemPasswordChar = false;
                btnShowCon2.Text = "Show";
            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string newPass = txtPassReset.Text;
            string conPass = txtConPassReset.Text;

            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(conPass))
            {
                MessageBox.Show("Please fill in both password fields.");
                return;
            }
            if (newPass != conPass)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            string strength = GetPassStrength(newPass);
            if (strength == "Weak" || strength == "Medium")
            {
                MessageBox.Show("Please choose a stronger password.");
                return;
            }
            try
            {
                string query = $@"UPDATE [User] 
                                  SET Password = '{newPass}' 
                                  WHERE UserID = {userId}";
                DataAccess.Execute(query);
                MessageBox.Show("Password reset successfully!");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resetting password: {ex.Message}");
            }
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {

        }
    }
}
