
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
    public partial class OTP : Form
    {
        private string email; //confirm kora email&ID from ForgotPass1.cs
        private int userId;
        private string context;

        public OTP() { }
        public OTP(string email, int userId, string context)
        {
            InitializeComponent();
            this.email = email;
            this.userId = userId;
            this.context = context;
        }

        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            string enteredOTP = txtOTP.Text;
            if(string.IsNullOrEmpty(enteredOTP))
            {
                MessageBox.Show("Please enter the OTP.");
                return;
            }
            try
            {
                string query=$@"SELECT * FROM OTPVerification 
                                WHERE Email= '{email}' AND UserID={userId} 
                                ORDER BY SentAT DESC";
                var result = DataAccess.GetData(query);
                if(result == null || result.Rows.Count == 0)
                {
                    MessageBox.Show("No OTP found.");
                    return;
                }
                var row=result.Rows[0]; //latest otp
                string storedOTP = row["OTPCode"].ToString();
                bool isVerified = Convert.ToBoolean(row["IsVerified"]);
                DateTime expireTime = Convert.ToDateTime(row["ExpiresAt"]);

                if(isVerified)
                {
                    MessageBox.Show("OTP already used.");
                    this.Hide();
                    ForgotPass1 forgotPass1 = new ForgotPass1();
                    forgotPass1.Show();

                }
                if(DateTime.Now > expireTime)
                {
                    MessageBox.Show("OTP expired. Please request a new one.");
                    ForgotPass1 fPass1 = new ForgotPass1();
                    fPass1.Show();
                    this.Hide();
                }
                if(enteredOTP != storedOTP)
                {
                    MessageBox.Show("Invalid OTP. Please try again.");
                    ForgotPass1 fPass1 = new ForgotPass1();
                    fPass1.Show();
                    this.Hide();
                }

                string updateQuery = $@"UPDATE OTPVerification 
                                SET IsVerified = 1 
                                WHERE OTPCode = '{enteredOTP}' AND UserID = {userId}";
                DataAccess.Execute(updateQuery);
                MessageBox.Show("OTP verified successfully!");
                this.Hide();
                if (context == "SignUp")
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else if (context == "ForgotPass")
                {
                    ResetPass resetPass = new ResetPass(userId);
                    resetPass.Show();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while verifying the OTP: " + ex.Message);
            }
        }

       
    }
}
