
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ZooManagementSystem
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        private int visitorId;
        private int accountId;
        private int bankId;
        private DateTime selectedDate;
        private int adultQty;
        private int childQty;
        private decimal total;
        private int userId;
        private string otpCode;
        private int matchedBankAccountID;


        public Transaction(int visitorId, DateTime selectedDate, int adultQty, int childQty, decimal total, int userId)
        {
            InitializeComponent();
            this.visitorId = visitorId;
            this.selectedDate = selectedDate;
            this.adultQty = adultQty;
            this.childQty = childQty;
            this.total = total;
            this.userId = userId;
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            string query = "SELECT BankID, BankName FROM Bank WHERE IsActive = 1";
            DataTable dt = DataAccess.GetData(query);

            DataRow newRow = dt.NewRow();
            newRow["BankID"] = 0;
            newRow["BankName"] = "Please Select a Bank To Pay";
            dt.Rows.InsertAt(newRow, 0);       //BUJHI NAAAAAAAAAAAAAAAAAAAAA

            cmbBankSelect.DisplayMember = "BankName";
            cmbBankSelect.ValueMember = "BankID";
            cmbBankSelect.DataSource = dt;
        }

        private void cmbBankSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBankSelect.SelectedIndex > 0)
            {
                grpbxAccInfo.Visible = true;
            }
            if (cmbBankSelect.Text == "City Bank")
            {
                bankId = Convert.ToInt32(cmbBankSelect.SelectedValue);
                MessageBox.Show($"You have selected {cmbBankSelect.Text} with ID: {bankId}");
            }
            else if (cmbBankSelect.Text == "Brac Bank")
            {
                bankId = Convert.ToInt32(cmbBankSelect.SelectedValue);
                MessageBox.Show($"You have selected {cmbBankSelect.Text} with ID: {bankId}");
            }
            else if (cmbBankSelect.Text == "Bank Asia")
            {
                bankId = Convert.ToInt32(cmbBankSelect.SelectedValue);
                MessageBox.Show($"You have selected {cmbBankSelect.Text} with ID: {bankId}");
            }
            else
            {
                grpbxAccInfo.Visible = false;
            }
        }

        private void txtAccountNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNo.Text)) return;

            string accNo = txtAccountNo.Text;
            int selectedBankId = Convert.ToInt32(cmbBankSelect.SelectedValue);

            if (selectedBankId == 0)
            {
                MessageBox.Show("Please select a bank first.");
                return;
            }

            string query = $@"
        SELECT AccountHolderName 
        FROM BankAccount 
        WHERE AccountNumber = '{accNo}' 
        AND BankID = {selectedBankId}";

            DataTable dt = DataAccess.GetData(query);

            if (dt != null && dt.Rows.Count == 1)
            {
                lblHolderName.Text = "Account Holder: " + dt.Rows[0]["AccountHolderName"].ToString();
                lblHolderName.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid account number for the selected bank.");
                lblHolderName.Visible = false;
            }
        }
        private void btnProceedTran_Click(object sender, EventArgs e)
        {
            string enteredEmail = txtAccEmail.Text.Trim();
            string accountNumber = txtAccountNo.Text.Trim();

            if (string.IsNullOrEmpty(enteredEmail) || string.IsNullOrEmpty(accountNumber))
            {
                MessageBox.Show("Please enter both account number and bank email.");
                return;
            }

            string query = $@"
    SELECT AccountID 
    FROM BankAccount 
    WHERE AccountNumber = '{accountNumber}' 
    AND AccountHolderEmail = '{enteredEmail}'
    AND BankID = {Convert.ToInt32(cmbBankSelect.SelectedValue)}";

            DataTable dt = DataAccess.GetData(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No matching account found for this bank, account number, and email.");
                return;
            }

            accountId = Convert.ToInt32(dt.Rows[0]["AccountID"]);
            bankId = Convert.ToInt32(cmbBankSelect.SelectedValue);
            if (bankId == 0 || accountId == 0)
            {
                MessageBox.Show("Please select a valid bank and enter a valid account number.");
                return;
            }
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No matching account found with that email and account number.");
                return;
            }
            if (dt != null && dt.Rows.Count > 0)
            {
                matchedBankAccountID = Convert.ToInt32(dt.Rows[0]["AccountID"]);
                Random rnd = new Random();
                otpCode = rnd.Next(100000, 999999).ToString();

                DateTime now = DateTime.Now;
                DateTime expiry = now.AddMinutes(5);

                string insertQuery = $@"
                INSERT INTO OTPVerification (OTPCode, SentAt, IsVerified, ExpiresAt, Email, UserID)
                VALUES ('{otpCode}', '{now}', 0, '{expiry}', '{enteredEmail}', {userId})";

                bool inserted = DataAccess.Execute(insertQuery);
                if (!inserted)
                {
                    MessageBox.Show("Failed to send OTP. Try again.");
                    return;
                }
                try
                {
                    string subject = "Transaction OTP";
                    string body = $"Your OTP for ticket purchase is: {otpCode}. It will expire in 5 minutes.";
                    EmailHelper.SendEmail(enteredEmail, subject, body);
                    MessageBox.Show("OTP sent to your bank email. Please check.");
                    TransactionOTP tranOTP = new TransactionOTP(enteredEmail, visitorId, selectedDate, adultQty, childQty, total, userId , bankId, accountId);
                    tranOTP.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to send OTP: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No matching account found with that email.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PickDateTime pickDateTime = new PickDateTime(visitorId, userId);
           
            pickDateTime.Show();
            this.Hide();
        }
    }
}

