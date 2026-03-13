using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ZooManagementSystem;


namespace ZooManagementSystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            toolTip1.SetToolTip(txtPass, "Must be at least 8 characters, with a capital letter and a symbol.");
        }

        private string GetPassStrength(string pass)
        {
            int score = 0;
            if (pass.Length >= 8)
            {
                score++;
            }
            if (Regex.IsMatch(pass, @"[A-Z]"))
            {
                score++; //regex--regular expression to match patterns in strings
            }
            if (Regex.IsMatch(pass, @"[a-z]"))
            {
                score++;
            }
            if (Regex.IsMatch(pass, @"[0-9]"))
            {
                score++;
            }
            if (Regex.IsMatch(pass, @"[\W_]")) 
            {
                score++; 
            }

            if (pass.Length < 8 || score <= 2)
            {
                return "Weak";
            }
            else if (score == 3 || score == 4)
            {
                return "Medium";
            }
            else
            {
                return "Strong";
            }
        }
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            string strength = GetPassStrength(txtPass.Text);
            lblStrength.Visible = true;
            if (txtPass.Text.Length == 0)
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

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConPass.Text == "")
            {
                lblMatch.Visible = false;
                return;
            }
            if (txtPass.Text != txtConPass.Text)
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            lblEmailCheck.Visible = true;
            if (email.Length == 0)
            {
                lblEmailCheck.Visible = false;
                return;
            }
            if (email.StartsWith("@") || email.EndsWith("@") || email.Contains("..") || !email.Contains("@") || !email.Contains("."))
            {
                lblEmailCheck.Text = "Invalid email format";
                lblEmailCheck.ForeColor = Color.Red;
            }
            else if (email.IndexOf("@") > email.LastIndexOf("."))
            {
                lblEmailCheck.Text = "Invalid\ncorrect formate: someone@email.com";
                lblEmailCheck.ForeColor = Color.Gray;
            }
            else
            {
                lblEmailCheck.Visible = false;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string phone = txtPhn.Text;
                string gender = rbtnMale.Checked ? "Male" : rbtnFemale.Checked ? "Female" : "";
                string password = txtPass.Text;
                string address = txtAddress.Text;

                if (name == "" || email == "" || phone == "" || gender == "" || password == "" || address == "")
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }
                if (password != txtConPass.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                string strength = GetPassStrength(password);
                if (strength == "Weak" || strength == "Medium")
                {
                    MessageBox.Show(" Please choose a stronger password.");
                    return;
                }
                if (email.StartsWith("@") || email.EndsWith("@") || email.Contains("..") || !email.Contains("@") || !email.Contains(".") || (email.IndexOf("@") > email.LastIndexOf(".")))
                {
                    MessageBox.Show("Invalid Email Formate\ncorrect formate: someone@email.com");
                }
                if (phone.Length != 11 || !phone.All(char.IsDigit))
                {
                    MessageBox.Show("Phone number must be 11 DIGITS.");
                    return;
                }

                string checkQuery = $"SELECT * FROM [User] WHERE Email = '{email}'";
                var data = DataAccess.GetData(checkQuery);

                if (data == null)
                    return;

                if (data.Rows.Count > 0)
                {
                    MessageBox.Show("This email is already registered.");
                    return;
                }

                string insertQuery = $@"
                                      INSERT INTO [User] 
                                      (FullName, Password, Email, PhoneNumber, Address, Gender, JoinDate, RoleID)
                                      OUTPUT INSERTED.UserID
                                      VALUES ('{name}', '{password}', '{email}', '{phone}', '{address}', '{gender}', GETDATE(), 3);";

                DataTable insertedUser = DataAccess.GetData(insertQuery);

                if (insertedUser == null || insertedUser.Rows.Count == 0)
                {
                    MessageBox.Show("Failed to register user.");
                    return;
                }
                int newUserId = Convert.ToInt32(insertedUser.Rows[0][0]);
                string insertVisitorQuery = $"INSERT INTO VisitorDetails(VisitorID, IsMember) VALUES ({newUserId}, 0)";

                if (DataAccess.Execute(insertVisitorQuery))
                {
                    Random rnd = new Random();
                    string otpCode = rnd.Next(100000, 999999).ToString();

                    DateTime now = DateTime.Now;
                    DateTime expiry = now.AddMinutes(5);

                    string insertOtpQuery = $@"
                                             INSERT INTO OTPVerification (OTPCode, SentAt, IsVerified, ExpiresAt, Email, UserID)
                                             VALUES ('{otpCode}', '{now}', 0, '{expiry}', '{email}', {newUserId})";

                    bool otpInserted = DataAccess.Execute(insertOtpQuery);
                    if (!otpInserted)
                    {
                        MessageBox.Show("Failed to send OTP. Try again.");
                        return;
                    }

                    try
                    {
                        string subject = "Welcome to Zoo Management!";
                        string body = $"Your OTP for sign up is: {otpCode}.  It will expire in 5 minutes.\n\nThank you for signing up! We're excited to have you.";
                        EmailHelper.SendEmail(email, subject, body);
                        MessageBox.Show("OTP sent to your email. Please check.");
                        OTP otpForm = new OTP(email, newUserId, "SignUp");
                        otpForm.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to send OTP: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Sign-up fail.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhn.Clear();
            txtPass.Clear();
            txtAddress.Clear();
            txtConPass.Clear();
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
        }

        private void txtPhn_TextChanged(object sender, EventArgs e)
        {
            string phone = txtPhn.Text;
            lblPhnCheck.Visible = true;
            if (txtPhn.TextLength == 0)
            {
                lblPhnCheck.Visible = false;
                return;
            }
            foreach (char c in phone)
            {
                if (!char.IsDigit(c))
                {
                    lblPhnCheck.Text = "Only digits allowed";
                    lblPhnCheck.ForeColor = Color.Red;
                    return;
                }
            }
            if (phone.Length != 11)
            {
                lblPhnCheck.Text = "Phone number must be 11 digits";
                lblPhnCheck.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblPhnCheck.Text = "OK✅";
                lblPhnCheck.ForeColor = Color.DarkGreen;
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
                return;
            else if(txtPass.UseSystemPasswordChar==false)
            {
                txtPass.UseSystemPasswordChar = true;
                btnShowPass.Text = "Hide";
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
                btnShowPass.Text = "Show";
            }
        }

        private void btnShowCon_Click(object sender, EventArgs e)
        {
            if (txtConPass.Text == "")
            {
                return;
            }

            else if (txtConPass.UseSystemPasswordChar==false)
            {
                txtConPass.UseSystemPasswordChar = true;
                btnShowCon.Text = "Hide";
            }
            else
            {
                txtConPass.UseSystemPasswordChar = false;
                btnShowCon.Text = "Show";
            }
        }
    }
}


