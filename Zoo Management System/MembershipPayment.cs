using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ZooManagementSystem
{
    public partial class MembershipPayment : Form
    {
        private decimal finalPrice;
        private int userId;
        private string selectedMembership;
        private string child;
        private string adult;
        private string accountHolderEmail;
        private string generatedOTP;
        private DateTime otpExpiryTime;
        private bool otpSent = false;
        private List<string> productList;

        public MembershipPayment(int userId, decimal totalPrice, decimal discount, string paymentMethod, string adult, string child, string selectedMembership)
        {
            InitializeComponent();
            selectBankcb.Items.Clear();
            //accountNoTextbox.Enabled = false;
            string query1 = "SELECT BankID, BankName FROM Bank WHERE IsActive = 1";
            DataTable dt = DataAccess.GetData(query1);
            DataRow emptyRow = dt.NewRow();

            selectBankcb.DataSource = dt;
            selectBankcb.DisplayMember = "BankName";
            selectBankcb.ValueMember = "BankID";

            selectBankcb.Text = "";
            selectBankcb.SelectedIndex = -1;

            decimal discountAmount = totalPrice * (discount / 100m);
            finalPrice = totalPrice - discountAmount;

            priceLabel.Text = $"£{totalPrice:0.00}";
            subPriceLabel.Text = $"£{totalPrice:0.00}";
            discountLabel.Text = $"{discount}%";
            totalPriceLabel.Text = $"£{finalPrice:0.00}";
            paymentMethodTextbox.Text = paymentMethod;

            this.selectedMembership = selectedMembership;
            this.child = child;
            this.adult = adult;
            this.userId = userId;

            //combo
        }
        public MembershipPayment(int userId, decimal totalAmount, string paymentMethod, List<string> productList)
        {
            InitializeComponent();
            //accountNoTextbox.Enabled = false;
            this.userId = userId;
            this.finalPrice = totalAmount;
            paymentMethodTextbox.Text = paymentMethod;
            this.productList = productList;

            string query = "SELECT BankID, BankName FROM Bank WHERE IsActive = 1";
            DataTable dt = DataAccess.GetData(query);
            selectBankcb.DataSource = dt;
            selectBankcb.DisplayMember = "BankName";
            selectBankcb.ValueMember = "BankID";
            selectBankcb.Text = "";
            selectBankcb.SelectedIndex = -1;


            subPriceLabel.Text = $"£{finalPrice:0.00}";
            string membershipQuery = $@"SELECT TOP 1 mt.Name 
                                        FROM Membership m
                                        JOIN MembershipType mt ON m.MembershipTypeID = mt.MembershipTypeID
                                        WHERE m.VisitorID = {userId} 
                                        AND m.IsActive = 1
                                        AND GETDATE() BETWEEN m.StartDate AND m.EndDate";

            DataTable membershipDt = DataAccess.GetData(membershipQuery);

            if (membershipDt.Rows.Count > 0 && membershipDt.Rows[0]["Name"].ToString() == "Gold")
            {
                decimal discountAmount = finalPrice * 0.10m;
                finalPrice -= discountAmount;
                discountLabel.Text = "10%";
            }
            else
            {
                discountLabel.Text = "0%";
            }
            priceLabel.Text = $"£{finalPrice:0.00}";
            totalPriceLabel.Text = $"£{finalPrice:0.00}";
            paymentMethodTextbox.Text = paymentMethod;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MembershipPayment_Load(object sender, EventArgs e)
        {

        }

        private void accountNoTextox_TextChanged(object sender, EventArgs e)
        {
            if (selectBankcb.SelectedItem == null)
            {
                MessageBox.Show("Please select a bank first");
                accountNoTextbox.Text = "";
                return;
            }

            string accountNo = accountNoTextbox.Text.Trim();
            if (string.IsNullOrEmpty(accountNo)) return;

            int bankId = Convert.ToInt32(selectBankcb.SelectedValue);
            string query2 = $"SELECT AccountHolderName FROM BankAccount WHERE AccountNumber = '{accountNo}' AND BankID = {bankId} AND IsActive = 1";

            DataTable dt = DataAccess.GetData(query2);

            if (dt.Rows.Count > 0)
            {
                accountHolderTextbox.Text = dt.Rows[0]["AccountHolderName"].ToString();
            }
            else
            {
                accountHolderTextbox.Text = "";
            }
        }


        private void DeductBalance(int bankId, string accountNo, decimal amount)
        {
            string updateQuery = $"UPDATE BankAccount SET Balance = Balance - {amount} WHERE BankID = {bankId} AND AccountNumber = '{accountNo}'";
            bool deductSuccess = DataAccess.Execute(updateQuery);

            if (!deductSuccess)
            {
                MessageBox.Show("Balance deduction failed");
                return;
            }

            string transactionQuery = $"INSERT INTO [Transaction] (VisitorID, PaymentMethod, TransactionDate, Amount, Status, BankID, AccountID, Description)VALUES({userId}, '{paymentMethodTextbox.Text.Replace("'", "''")}', CONVERT(date, GETDATE()), {finalPrice}, 'Completed',  {bankId}, (SELECT AccountID FROM BankAccount WHERE BankID = {bankId} AND AccountNumber = '{accountNo}'),'Membership')";

            bool transactionSuccess = DataAccess.Execute(transactionQuery);

            if (transactionSuccess)
            {
                string updateMemberQuery = $"UPDATE VisitorDetails SET IsMember = 1 WHERE VisitorID = {userId}";
                bool memberUpdated = DataAccess.Execute(updateMemberQuery);

                string membershipQuery = $@"
                                          INSERT INTO Membership 
                                          (VisitorID, MembershipTypeID, StartDate, EndDate, Adults, Children, TransactionID, IsActive)
                                          VALUES
                                          ({userId}, 
                                          (SELECT MembershipTypeID FROM MembershipType WHERE Name = '{selectedMembership}'),
                                          CONVERT(date, GETDATE()), 
                                          CONVERT(date, DATEADD(MONTH, 12, GETDATE())), 
                                          {Convert.ToInt32(adult)}, {Convert.ToInt32(child)}, 
                                          (SELECT TOP 1 TransactionID FROM [Transaction] WHERE VisitorID = {userId} ORDER BY TransactionID DESC),1)";

                bool membershipCreated = DataAccess.Execute(membershipQuery);
                if (!memberUpdated)
                {
                    MessageBox.Show("Membership status update failed");
                    return;
                }

                if (memberUpdated && membershipCreated)
                {
                    MessageBox.Show($"£{amount:0.00} deducted successfully\nMembership activated and recorded!");
                    visitorHome home = new visitorHome(userId);
                    home.Show();
                    this.Close();
                }
                else if (!membershipCreated)
                {
                    MessageBox.Show("Payment processed but membership creation failed");
                }
                else
                {
                    MessageBox.Show("Payment processed but membership status update failed");
                }
            }
            else
            {
                MessageBox.Show("Transaction record failed (balance was deducted)");
            }
        }
        private void ProcessProductPayment()
        {
            string accountNo = accountNoTextbox.Text.Trim();
            int bankId = Convert.ToInt32(selectBankcb.SelectedValue);

            string updateQuery = $"UPDATE BankAccount SET Balance = Balance - {finalPrice} WHERE BankID = {bankId} AND AccountNumber = '{accountNo}'";
            bool deductSuccess = DataAccess.Execute(updateQuery);

            if (!deductSuccess)
            {
                MessageBox.Show("Balance deduction failed");
                return;
            }

            string transactionQuery = $@"
                                        INSERT INTO [Transaction] 
                                        (VisitorID, PaymentMethod, TransactionDate, Amount, Status, BankID, AccountID, Description)
                                        VALUES
                                        ({userId}, '{paymentMethodTextbox.Text.Replace("'", "''")}', 
                                        CONVERT(date, GETDATE()), {finalPrice}, 'Completed', 
                                        {bankId}, 
                                        (SELECT AccountID FROM BankAccount WHERE BankID = {bankId} AND AccountNumber = '{accountNo}'),'Product Purchase')";

            bool transactionSuccess = DataAccess.Execute(transactionQuery);

            if (transactionSuccess)
            {
                string transactionIdQuery = $"SELECT TOP 1 TransactionID FROM [Transaction] WHERE VisitorID = {userId} ORDER BY TransactionID DESC";
                DataTable transactionDt = DataAccess.GetData(transactionIdQuery);
                int transactionId = Convert.ToInt32(transactionDt.Rows[0]["TransactionID"]);

                string getCartItemsQuery = $@"SELECT p.ProductID, p.Name, p.Price, ci.Quantity
                                              FROM CartItems ci
                                              JOIN Products p ON ci.ProductID = p.ProductID
                                              WHERE ci.CartID = (SELECT CartID FROM Cart WHERE VisitorID = {userId})";

                DataTable cartItems = DataAccess.GetData(getCartItemsQuery);

                foreach (DataRow item in cartItems.Rows)
                {
                    int productId = Convert.ToInt32(item["ProductID"]);
                    string productName = item["Name"].ToString();
                    decimal unitPrice = Convert.ToDecimal(item["Price"]);
                    int quantity = Convert.ToInt32(item["Quantity"]);

                    string orderItemQuery = $@"
                                             INSERT INTO OrderItems 
                                             (TransactionID, ProductID, Quantity, UnitPrice)
                                             VALUES
                                             ({transactionId},{productId},{quantity},{unitPrice})";

                    bool success = DataAccess.Execute(orderItemQuery);

                    if (!success)
                    {
                        MessageBox.Show($"Failed to record purchase of {productName}");
                        continue;
                    }

                    string updateStockQuery = $@"UPDATE Products 
                                                 SET StockQuantity = StockQuantity - {quantity}
                                                 WHERE ProductID = {productId}";

                    DataAccess.Execute(updateStockQuery);
                }
                ClearUserCart();
                MessageBox.Show($"£{finalPrice:0.00} deducted successfully\nProducts purchased!");
                visitorHome home = new visitorHome(userId);
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Transaction record failed");
            }

            ResetOTPState();
        }

        private void otpButton_Click(object sender, EventArgs e)
        {
            if (!otpSent)
            {
                if (string.IsNullOrEmpty(accountNoTextbox.Text) || selectBankcb.SelectedItem == null)
                {
                    MessageBox.Show("Please select bank and enter account number");
                    return;
                }

                string accountNo = accountNoTextbox.Text.Trim();
                int bankId = Convert.ToInt32(selectBankcb.SelectedValue);

                string balanceQuery = $"SELECT Balance,AccountHolderEmail FROM BankAccount WHERE AccountNumber = '{accountNo}' AND BankID = {bankId} AND IsActive = 1";
                DataTable accountDt = DataAccess.GetData(balanceQuery);

                if (accountDt.Rows.Count == 0)
                {
                    MessageBox.Show("Account not found");
                    return;
                }

                decimal currentBalance = Convert.ToDecimal(accountDt.Rows[0]["Balance"]);
                if (currentBalance < finalPrice)
                {
                    MessageBox.Show("Insufficient balance");
                    return;
                }
                accountHolderEmail = accountDt.Rows[0]["AccountHolderEmail"].ToString();

                if (SendOTPToEmail(accountHolderEmail))
                {
                    otpSent = true;
                    otpButton.Text = "Verify OTP";
                    otpButton.FillColor = Color.FromArgb(70, 159, 0);
                    confirmOtpTextbox.Enabled = true;
                    confirmOtpTextbox.Focus();
                    MessageBox.Show("OTP sent to your email. Please check and enter the OTP.");
                }
                else
                {
                    MessageBox.Show("Failed to send OTP. Please try again.");
                }
                confirmOtpTextbox.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(confirmOtpTextbox.Text))
                {
                    MessageBox.Show("Please enter the OTP");
                    return;
                }

                if (VerifyOTP(confirmOtpTextbox.Text))
                {
                    string accountNo = accountNoTextbox.Text.Trim();
                    int bankId = Convert.ToInt32(selectBankcb.SelectedValue);

                    if (this.Owner is ProductFrame)
                    {
                        if (productList != null && productList.Count > 0)
                        {
                            ProcessProductPayment();
                        }
                        else
                        {
                            MessageBox.Show("No products to process. Please add products to your cart.");
                        }
                    }
                    else
                    {
                        DeductBalance(bankId, accountNo, finalPrice);
                    }

                    otpSent = false;
                    otpButton.Text = "Send OTP";
                    confirmOtpTextbox.Enabled = false;
                    confirmOtpTextbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid OTP or OTP expired");
                }

            }

        }
        private bool SendOTPToEmail(string email)
        {
            try
            {
                Random random = new Random();
                generatedOTP = random.Next(100000, 999999).ToString();
                otpExpiryTime = DateTime.Now.AddMinutes(5);

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("octolusminologia@gmail.com", "yfpz uybx lrfo efjc"),
                    EnableSsl = true
                };


                MailMessage message = new MailMessage
                {
                    From = new MailAddress("octolusminologia@gmail.com", "London Zoo"),
                    Subject = "Your OTP for London Zoo Purchase",
                    Body = $"Your OTP for purchase is: {generatedOTP}\nThis OTP is valid for 5 minutes.",
                    IsBodyHtml = false
                };
                message.To.Add(email);

                client.Send(message);
                MessageBox.Show($"OTP sent to {email}");
                return true;
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"Email sending failed: {smtpEx.StatusCode}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }

        }
        private bool VerifyOTP(string enteredOTP)
        {
            if (string.IsNullOrEmpty(enteredOTP)) return false;
            if (enteredOTP.Length != 6) return false;
            if (!enteredOTP.All(char.IsDigit)) return false;
            if (DateTime.Now > otpExpiryTime) return false;

            return enteredOTP == generatedOTP;
        }
        private void ResetOTPState()
        {
            otpSent = false;
            otpButton.Text = "Send OTP";
            otpButton.FillColor = Color.FromArgb(94, 148, 255);
            confirmOtpTextbox.Enabled = false;
            confirmOtpTextbox.Text = "";
        }
        private void ClearUserCart()
        {
            try
            {
                string cartQuery = $"SELECT CartID FROM Cart WHERE VisitorID = {userId}";
                DataTable cartResult = DataAccess.GetData(cartQuery);

                if (cartResult.Rows.Count > 0)
                {
                    int cartId = Convert.ToInt32(cartResult.Rows[0]["CartID"]);

                    string deleteItemsQuery = $"DELETE FROM CartItems WHERE CartID = {cartId}";
                    DataAccess.Execute(deleteItemsQuery);

                    string deleteCartQuery = $"DELETE FROM Cart WHERE CartID = {cartId}";
                    DataAccess.Execute(deleteCartQuery);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error clearing cart: {ex.Message}");
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (this.Owner is ProductFrame productFrame)
            {
                productFrame.Show();
                this.Close();
            }
            else
            {
                Membership membership = new Membership(userId);
                membership.Show();
                this.Close();
            }

        }

        private void selectBankcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accountNo = accountNoTextbox.Text.Trim();
            if (string.IsNullOrEmpty(accountNo)) return;
            int bankId = Convert.ToInt32(selectBankcb.SelectedValue);
            string query2 = $"SELECT AccountHolderName FROM BankAccount WHERE AccountNumber = '{accountNo}' AND BankID = {bankId} AND IsActive = 1";

            DataTable dt = DataAccess.GetData(query2);

            if (dt.Rows.Count > 0)
            {
                accountHolderTextbox.Text = dt.Rows[0]["AccountHolderName"].ToString();
            }
            else
            {
                accountHolderTextbox.Text = "";
            }

        }
        /*private void confirmbtn_Click(object sender, EventArgs e)
{
if (!otpSent)
{
MessageBox.Show("Please send and verify OTP first");
return;
}

if (string.IsNullOrEmpty(confirmOtpTextbox.Text))
{
MessageBox.Show("Please enter the OTP");
return;
}

if (VerifyOTP(confirmOtpTextbox.Text))
{
string accountNo = accountNoTextbox.Text.Trim();
int bankId = Convert.ToInt32(selectBankcb.SelectedValue);
DeductBalance(bankId, accountNo, finalPrice);

// Reset for next transaction
otpSent = false;
otpButton.Text = "Send OTP";
confirmOtpTextbox.Enabled = false;
confirmOtpTextbox.Text = "";
}
else
{
MessageBox.Show("Invalid OTP or OTP expired");
}
}*/
    }
}
