
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ZooManagementSystem
{
    public partial class TransactionOTP : Form
    {
        private string enteredEmail;
        private int userId;
        private DateTime selectedDate;
        private int adultQty;
        private int childQty;
        private decimal total;
        private int visitorId;
        private int bankId;
        private int accountId;

        public TransactionOTP()
        {
            InitializeComponent();
        }
        public TransactionOTP(string enteredEmail,int visitorId, DateTime selectedDate, int adultQty, int childQty, decimal total, int userId, int bankId, int accountId)
        {
            InitializeComponent();
            this.enteredEmail = enteredEmail;
            this.userId = userId;
            this.selectedDate = selectedDate;
            this.adultQty = adultQty;
            this.childQty = childQty;
            this.total = total;
            this.visitorId = visitorId;
            this.bankId = bankId;
            this.accountId = accountId;
        }
        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {

            string enteredOTP = txtTranOTP.Text;

            if (string.IsNullOrEmpty(enteredOTP))
            {
                MessageBox.Show("Please enter the OTP.");
                return;
            }

            try
            {
                string query = $@"
                    SELECT * FROM OTPVerification 
                    WHERE Email = '{enteredEmail}' 
                    ORDER BY SentAt DESC";

                var result = DataAccess.GetData(query);

                if (result == null || result.Rows.Count == 0)
                {
                    MessageBox.Show("No OTP found.");
                    return;
                }

                DataRow row = result.Rows[0];
                string storedOtp = row["OTPCode"].ToString();
                bool isVerified = Convert.ToBoolean(row["IsVerified"]);
                DateTime expiresAt = Convert.ToDateTime(row["ExpiresAt"]);

                if (isVerified)
                {
                    MessageBox.Show("This OTP has already been used.");
                    return;
                }

                if (DateTime.Now > expiresAt)
                {
                    MessageBox.Show("OTP has expired. Please request a new one.");
                    Transaction tran = new Transaction();
                    tran.Show();
                    this.Hide();
                }

                if (enteredOTP != storedOtp)
                {
                    MessageBox.Show("Invalid OTP. Please try again.");
                    return;
                }
                string update = $@"
                    UPDATE OTPVerification 
                    SET IsVerified = 1 
                    WHERE OTPCode = '{enteredOTP}' AND UserID = {userId}";

                DataAccess.Execute(update);

                MessageBox.Show("OTP verified! Transaction confirmed.");

                string insertTransaction = $@"
                                           INSERT INTO [Transaction] 
                                           (VisitorID, PaymentMethod, TransactionDate, Amount, Status, BankID, AccountID, Description)
                                           OUTPUT INSERTED.TransactionID
                                           VALUES ({visitorId}, 'Bank','{selectedDate.Date}' , {total}, 'Success', {bankId}, {accountId}, 'Zoo Ticket Purchase')";
                DataTable tranResult =DataAccess.GetData(insertTransaction);
                if (tranResult == null || tranResult.Rows.Count == 0)
                {
                    MessageBox.Show("Transaction failed. Please try again.");
                    return;
                }
                //Ticket Table
                int transactionId = Convert.ToInt32(tranResult.Rows[0]["TransactionID"]);
                string insertTicketQuery = $@"
                                            INSERT INTO Ticket 
                                            (VisitorID, PurchaseDate, VisitDate, TotalCost, TransactionID, TransactionStatus)
                                            OUTPUT INSERTED.TicketID
                                            VALUES ({visitorId}, GETDATE(), '{selectedDate.Date}', {total}, {transactionId}, 'Confirmed')";
                DataTable ticketResult = DataAccess.GetData(insertTicketQuery);

                if (ticketResult == null || ticketResult.Rows.Count == 0)
                {
                    MessageBox.Show("Failed to insert ticket record.");
                    return;
                }

                //// TicketItem Table
                int ticketId = Convert.ToInt32(ticketResult.Rows[0]["TicketID"]);
                decimal adultPrice = 35.00m;
                decimal childPrice = 24.50m; 

                if (adultQty > 0)
                {
                    string insertAdultItem = $@"
                                             INSERT INTO TicketItem 
                                             (TicketID, TicketPriceID, Quantity, Subtotal)
                                             VALUES ({ticketId}, 1, {adultQty}, {adultQty * adultPrice})";

                    DataAccess.Execute(insertAdultItem);
                }

                if (childQty > 0)
                {
                    string insertChildItem = $@"
                                             INSERT INTO TicketItem 
                                             (TicketID, TicketPriceID, Quantity, Subtotal)
                                             VALUES ({ticketId}, 2, {childQty}, {childQty * childPrice})";

                    DataAccess.Execute(insertChildItem);
                }
                MessageBox.Show("Transaction completed successfully! Your tickets have been booked.");

                ////// Reduce Bank Balance              
                string checkBalanceQuery = $"SELECT Balance FROM BankAccount WHERE AccountID = {accountId}";
                DataTable balanceResult = DataAccess.GetData(checkBalanceQuery);

                if (balanceResult != null && balanceResult.Rows.Count > 0)
                {
                    decimal currentBalance = Convert.ToDecimal(balanceResult.Rows[0]["Balance"]);
                    if (currentBalance < total)
                    {
                        MessageBox.Show("❌ Not enough balance for this transaction.");
                        return;
                    }
                    string updateBalanceQuery = $@" UPDATE BankAccount 
                                            SET Balance = Balance - {total} WHERE AccountID = {accountId}";
                    bool updated = DataAccess.Execute(updateBalanceQuery);

                    if (!updated)
                    {
                        MessageBox.Show("⚠️ Failed to update bank balance.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("💰 Bank balance updated successfully.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during OTP verification: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visitorHome visitorHomeForm = new visitorHome(userId);
            visitorHomeForm.Show();
            this.Hide();

        }
    }
}
