
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class ForgotPass1 : Form
    {
        public ForgotPass1()
        {
            InitializeComponent();
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string email = txtEmailFP1.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.");
                return;
            }
            try
            {
                string checkQuery = $"SELECT UserID FROM [User] WHERE Email = '{email}'";
                var result = DataAccess.GetData(checkQuery);

                if (result == null || result.Rows.Count == 0)
                {
                    MessageBox.Show("Email not found. Please enter a registered email.");
                    return;
                }
                int matchedUserId = Convert.ToInt32(result.Rows[0]["UserID"]);

                Random rnd = new Random();
                string generatedOTP = rnd.Next(100000, 999999).ToString();

                DateTime now = DateTime.Now;
                DateTime expiry = now.AddMinutes(5);

                string insertOtpQuery = $@"INSERT INTO OTPVerification (OTPCode,SentAt,IsVerified,ExpiresAt,Email,UserID)
                                            VALUES('{generatedOTP}', '{now}',0, '{expiry}','{email}', {matchedUserId})";
                if (!DataAccess.Execute(insertOtpQuery))
                {
                    MessageBox.Show("Failed to send OTP. Please try again later.");
                    return;
                }

                string subject = "Password Reset OTP";
                string body = $"Your OTP code for password reset is {generatedOTP}. It will expire in 5 minutes.";
                EmailHelper.SendEmail(email, subject, body);

                MessageBox.Show("OTP sent successfully. Check your email.");
                this.Hide();
                OTP otpForm = new OTP(email, matchedUserId,"ForgotPass");
                otpForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
