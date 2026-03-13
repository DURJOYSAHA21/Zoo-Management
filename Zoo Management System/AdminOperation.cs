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
    public partial class AdminOperation : Form
    {
        int UserId1;
        int userId;
        DataTable adminData;

        public AdminOperation(int userId)
        {
            InitializeComponent();
            LoadAdminData();
            this.UserId1 = userId;
            updateButton.Enabled = false;
        }

        private void LoadAdminData()
        {
            string loadQuery = @"SELECT u.UserID, u.FullName, u.Email, u.PhoneNumber, 
                                 u.Address, u.Gender, u.Dob, a.SharePercentage
                                 FROM [User] u
                                 LEFT JOIN AdminDetails a ON u.UserID = a.AdminID
                                 WHERE u.RoleID = 1";

            adminData = DataAccess.GetData(loadQuery);

            showDataGridView.DataSource = null;
            showDataGridView.AutoGenerateColumns = false;

            if (adminData != null && adminData.Rows.Count > 0)
            {
                showDataGridView.DataSource = adminData;
            }
            else
            {
                MessageBox.Show("No admin data found!");
            }
        }

        private void RefreshAdminData()
        {
            LoadAdminData();
            searchTextBox1.Text = "";
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string name = "";
            string email = "";
            string password = "";
            string phoneNo = "";
            string dob = "";
            string gender = "";
            string address = "";
            string sharePercentage = "";


            //name
            if (string.IsNullOrEmpty(name2.Text))
            {
                MessageBox.Show("Please enter a name!");
                return;
            }
            else
            {
                if (name2.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Name contains invalid characters");
                    return;
                }
                name = name2.Text;
            }
            //email
            if (string.IsNullOrEmpty(email2.Text))
            {
                MessageBox.Show("Please enter a email!");
                return;
            }
            else
            {
                if (email2.Text.Contains('@') && email2.Text.Contains(".com"))
                {
                    email = email2.Text;
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address!");
                    return;
                }

            }
            //password

            //phone number
            if (phno2.Text.Length != 11)
            {
                MessageBox.Show("Please enter a valid phone number!");
                return;
            }
            else
            {
                for (int i = 0; i < phno2.Text.Length; i++)
                {
                    if (!char.IsDigit(phno2.Text[i]))
                    {
                        MessageBox.Show("Please enter a valid phone number!");
                        return;
                    }
                }
                phoneNo = phno2.Text;
            }
            //share percentage
            if (string.IsNullOrEmpty(share1.Text))
            {
                MessageBox.Show("Please enter share percentage!");
                return;
            }
            else if (!decimal.TryParse(share1.Text, out decimal shareValue) || shareValue < 0 || shareValue > 100)
            {
                MessageBox.Show("Share percentage must be between 0 and 100!");
                return;
            }
            string totalSharesQuery = "SELECT SUM(SharePercentage) AS TotalShares FROM AdminDetails";
            DataTable sharesDt = DataAccess.GetData(totalSharesQuery);
            decimal currentTotal;
            if (sharesDt.Rows[0]["TotalShares"] != DBNull.Value)
            {
                currentTotal = Convert.ToDecimal(sharesDt.Rows[0]["TotalShares"]);
            }
            else
            {
                currentTotal = 0;
            }
            string currentAdminShareQuery = $"SELECT SharePercentage FROM AdminDetails WHERE AdminID = {userId}";
            DataTable currentAdminDt = DataAccess.GetData(currentAdminShareQuery);
            decimal currentAdminShare;
            if (currentAdminDt.Rows.Count > 0)
            {
                currentAdminShare = Convert.ToDecimal(currentAdminDt.Rows[0]["SharePercentage"]);
            }
            else
            {
                currentAdminShare = 0;
            }

            decimal newShare = Convert.ToDecimal(share1.Text);

            decimal adjustedTotal = currentTotal - currentAdminShare + newShare;

            if (adjustedTotal > 100)
            {
                decimal maxAllowed = 100 - (currentTotal - currentAdminShare);
                MessageBox.Show($"Cannot update share to {newShare}%. " + $"Current total shares: {currentTotal}% (excluding your current {currentAdminShare}%). " + $"Maximum allowed: {maxAllowed}%");
                return;
            }

            sharePercentage = share1.Text;
            //date of birth
            try
            {
                DateTime dobDate = DateTime.Parse(dob2.Text);
                dob = dobDate.ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Date Input");
                this.Close();
                return;
            }
            //gender
            if (mr2.Checked == false && fr2.Checked == false)
            {
                MessageBox.Show("Enter a gender");
                return;
            }
            else if (mr2.Checked)
            {
                gender = mr2.Text;
            }
            else
            {
                gender = fr2.Text;
            }
            //address
            if (rc2.SelectedItem == null)
            {
                MessageBox.Show("No District selected!");
                return;
            }
            if (cc2.SelectedItem == null)
            {
                MessageBox.Show("No District selected!");
                return;
            }
            if (string.IsNullOrEmpty(home2.Text))
            {
                MessageBox.Show("Please enter home address!");
                return;
            }
            address = rc2.Text + ", " + cc2.Text + ", " + home2.Text.Replace(",", "").Trim();
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address cannot be empty!");
                return;
            }

            string updateQuery = $@"UPDATE [User] SET 
                                 FullName = '{name}', 
                                 Email = '{email}', 
                                 PhoneNumber = '{phoneNo}', 
                                 Address = '{address}', 
                                 Gender = '{gender}', 
                                 Dob = '{dob}' 
                                 WHERE UserID = {userId};
        
                                 UPDATE [AdminDetails] SET SharePercentage = {sharePercentage} 
                                 WHERE AdminID = {userId}";
            bool isUpdated = DataAccess.Execute(updateQuery);

            if (isUpdated)
            {
                MessageBox.Show("Profile updated successfully!");
                RefreshAdminData();
                this.Refresh();
                updateButton.Enabled = false;
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.");
            }
        }
        private void UpdatePasswordMatchStatus()
        {
            if (string.IsNullOrEmpty(password2.Text) || string.IsNullOrEmpty(confirm2.Text))
            {
                message2.Text = "";
                return;
            }

            if (password2.Text == confirm2.Text)
            {
                message2.Text = "Matched!!";
                message2.ForeColor = Color.Green;
            }
            else
            {
                message2.Text = "Not Matched!!";
                message2.ForeColor = Color.Red;
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string name = "";
            string email = "";
            string password = "";
            string phoneNo = "";
            string dob = "";
            string gender = "";
            string address = "";
            string sharePercentage = "";

            // name validation
            if (string.IsNullOrEmpty(name2.Text))
            {
                MessageBox.Show("Please enter a name!");
                return;
            }
            else
            {
                if (name2.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Name contains invalid characters");
                    return;
                }
                name = name2.Text;
            }

            // email
            if (string.IsNullOrEmpty(email2.Text))
            {
                MessageBox.Show("Please enter a email!");
                return;
            }
            else
            {
                if (email2.Text.Contains('@') && email2.Text.Contains(".com"))
                {
                    email = email2.Text;
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address!");
                    return;
                }
            }

            // password
            if (string.IsNullOrEmpty(password2.Text) || string.IsNullOrEmpty(confirm2.Text))
            {
                MessageBox.Show("Please enter and confirm your password!");
                return;
            }
            else if (password2.Text == confirm2.Text)
            {
                if (password2.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long!");
                    return;
                }
                if (!password2.Text.Any(char.IsUpper) || !password2.Text.Any(c => !char.IsLetterOrDigit(c)))
                {
                    MessageBox.Show("Password must contain at least one uppercase letter and one special character!");
                    return;
                }
                password = password2.Text;
                message2.Text = "Matched!!";
                message2.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
                message2.Text = "Not Matched!!";
                message2.ForeColor = Color.Red;
                return;
            }

            // phone number
            if (phno2.Text.Length != 11)
            {
                MessageBox.Show("Please enter a valid phone number!");
                return;
            }
            else
            {
                for (int i = 0; i < phno2.Text.Length; i++)
                {
                    if (!char.IsDigit(phno2.Text[i]))
                    {
                        MessageBox.Show("Please enter a valid phone number!");
                        return;
                    }
                }
                phoneNo = phno2.Text;
            }

            // share percentage
            if (string.IsNullOrEmpty(share1.Text))
            {
                MessageBox.Show("Please enter share percentage!");
                return;
            }
            else if (!decimal.TryParse(share1.Text, out decimal shareValue) || shareValue < 0 || shareValue > 100)
            {
                MessageBox.Show("Share percentage must be between 0 and 100!");
                return;
            }
            string totalSharesQuery = "SELECT SUM(SharePercentage) AS TotalShares FROM AdminDetails";
            DataTable sharesDt = DataAccess.GetData(totalSharesQuery);
            decimal currentTotal = sharesDt.Rows[0]["TotalShares"] != DBNull.Value ?
                                  Convert.ToDecimal(sharesDt.Rows[0]["TotalShares"]) : 0;
            decimal newShare = Convert.ToDecimal(share1.Text);

            if (currentTotal + newShare > 100)
            {
                MessageBox.Show($"Cannot add this share. Current total shares: {currentTotal}%. Adding {newShare}% would exceed 100%.");
                return;
            }

            sharePercentage = share1.Text;

            // date of birth
            try
            {
                DateTime dobDate = DateTime.Parse(dob2.Text);
                dob = dobDate.ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Date Input");
                return;
            }

            // gender
            if (mr2.Checked == false && fr2.Checked == false)
            {
                MessageBox.Show("Enter a gender");
                return;
            }
            else if (mr2.Checked)
            {
                gender = mr2.Text;
            }
            else
            {
                gender = fr2.Text;
            }

            // address
            if (rc2.SelectedItem == null)
            {
                MessageBox.Show("No Region selected!");
                return;
            }
            if (cc2.SelectedItem == null)
            {
                MessageBox.Show("No Country selected!");
                return;
            }
            if (string.IsNullOrEmpty(home2.Text))
            {
                MessageBox.Show("Please enter home address!");
                return;
            }
            address = rc2.Text + ", " + cc2.Text + ", " + home2.Text.Replace(",", "").Trim();
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address cannot be empty!");
                return;
            }

            string insertUserQuery = $@"
                                       INSERT INTO [User] (FullName, Email, Password, PhoneNumber, Address, Gender, Dob, RoleID, JoinDate)
                                       VALUES ('{name.Replace("'", "''")}', 
                                       '{email.Replace("'", "''")}', 
                                       '{password.Replace("'", "''")}', 
                                       '{phoneNo.Replace("'", "''")}', '{address.Replace("'", "''")}', '{gender.Replace("'", "''")}', '{dob}',1,GETDATE())";

            bool userInserted = DataAccess.Execute(insertUserQuery);

            if (userInserted)
            {
                string getLastIdQuery = "SELECT TOP 1 UserID FROM [User] ORDER BY UserID DESC";
                DataTable result = DataAccess.GetData(getLastIdQuery);

                if (result.Rows.Count > 0)
                {
                    int newUserId = Convert.ToInt32(result.Rows[0]["UserID"]);

                    string insertAdminQuery = $@"
                                                INSERT INTO [AdminDetails] (AdminID, SharePercentage)
                                                VALUES ({newUserId}, {sharePercentage})";

                    bool adminInserted = DataAccess.Execute(insertAdminQuery);

                    if (adminInserted)
                    {
                        MessageBox.Show("Admin created successfully!");
                        RefreshAdminData();
                        this.Refresh();
                    }
                    else
                    {
                        // Rollback
                        string deleteQuery = $"DELETE FROM [User] WHERE UserID = {newUserId}";
                        DataAccess.Execute(deleteQuery);
                        MessageBox.Show("Failed to set share percentage! User account removed.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve new user ID!");
                }
            }
            else
            {
                MessageBox.Show("Failed to create admin user!");
            }
        }

        private void rc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cc2.Items.Clear();
            if (rc2.SelectedIndex == 0)
            {
                string[] africa = { "Nigeria", "Egypt", "South Africa", "Kenya", "Ethiopia", "Ghana", "Morocco", "Tanzania" };
                cc2.Items.AddRange(africa);
            }
            else if (rc2.SelectedIndex == 1)
            {
                string[] asia = { "Bangladesh", "China", "India", "Japan", "South Korea", "Indonesia", "Thailand", "Vietnam", "Malaysia" };
                cc2.Items.AddRange(asia);
            }
            else if (rc2.SelectedIndex == 2)
            {
                string[] europe = { "Germany", "France", "Italy", "Spain", "United Kingdom", "Netherlands", "Switzerland", "Sweden" };
                cc2.Items.AddRange(europe);
            }
            else if (rc2.SelectedIndex == 3)
            {
                string[] northAmerica = { "United States", "Canada", "Mexico", "Costa Rica", "Panama", "Cuba", "Jamaica", "Dominican Republic" };
                cc2.Items.AddRange(northAmerica);
            }
            else if (rc2.SelectedIndex == 4)
            {
                string[] southAmerica = { "Brazil", "Argentina", "Colombia", "Peru", "Chile", "Ecuador", "Venezuela", "Bolivia" };
                cc2.Items.AddRange(southAmerica);
            }
            else if (rc2.SelectedIndex == 5)
            {
                string[] oceania = { "Australia", "New Zealand", "Fiji", "Papua New Guinea", "Samoa", "Tonga", "Vanuatu", "Solomon Islands" };
                cc2.Items.AddRange(oceania);
            }
            else if (rc2.SelectedIndex == 6)
            {
                string[] middleEast = { "Saudi Arabia", "United Arab Emirates", "Qatar", "Israel", "Turkey", "Iran", "Iraq", "Jordan" };
                cc2.Items.AddRange(middleEast);
            }
            else
            {
                //MessageBox.Show("Please select a valid continent!");
                return;
            }
        }

        private void password1_TextChanged_1(object sender, EventArgs e)
        {
            UpdatePasswordMatchStatus();
        }

        private void confirm1_TextChanged_1(object sender, EventArgs e)
        {
            UpdatePasswordMatchStatus();
        }

        private void searchTextBox1_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }
        private void PerformSearch()
        {
            string searchTerm = searchTextBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataView dv = adminData.DefaultView;
                dv.RowFilter = $"FullName LIKE '%{searchTerm.Replace("'", "''")}%' OR " + $"Email LIKE '%{searchTerm.Replace("'", "''")}%' OR " + $"PhoneNumber LIKE '%{searchTerm.Replace("'", "''")}%'";
                showDataGridView.DataSource = dv.ToTable();
            }
            else
            {
                showDataGridView.DataSource = adminData;
                adminData.DefaultView.RowFilter = "";
            }
        }

        private void showDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = showDataGridView.Rows[e.RowIndex];

                userId = Convert.ToInt32(row.Cells["UserID1"].Value);

                name2.Text = row.Cells["FullName1"].Value.ToString();
                email2.Text = row.Cells["Email1"].Value.ToString();
                phno2.Text = row.Cells["PhoneNumber1"].Value.ToString();

                if (row.Cells["Dob1"].Value != DBNull.Value)
                {
                    DateTime dob = (DateTime)row.Cells["Dob1"].Value;
                    dob2.Text = dob.ToString("dddd, MMMM d, yyyy");
                }

                string gender = row.Cells["Gender1"].Value.ToString();
                mr2.Checked = (gender == "Male");
                fr2.Checked = (gender == "Female");

                string address = row.Cells["Address1"].Value.ToString();
                if (!string.IsNullOrEmpty(address))
                {
                    string[] parts = address.Split(',');
                    if (parts.Length >= 3)
                    {
                        rc2.Text = parts[0].Trim();
                        cc2.Text = parts[1].Trim();
                        home2.Text = parts[2].Trim();
                    }
                }

                if (row.Cells["SharePercentage1"].Value != DBNull.Value)
                {
                    share1.Text = row.Cells["SharePercentage1"].Value.ToString();
                }
                else
                {
                    share1.Text = "0";
                }
            }
        }
        private void ClearForm()
        {
            name2.Text = "";
            email2.Text = "";
            password2.Text = "";
            confirm2.Text = "";
            phno2.Text = "";
            share1.Text = "";
            dob2.Text = "";
            mr2.Checked = false;
            fr2.Checked = false;
            rc2.SelectedIndex = -1;
            cc2.SelectedIndex = -1;
            home2.Text = "";
            userId = 0;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (userId == 0)
            {
                MessageBox.Show("Please select an admin to delete first");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this admin?", "Confirm Delete",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string deleteChatQuery= $"DELETE FROM[Chat] WHERE SenderID = { userId } OR ReceiverID = { userId };";
                string deleteWorkscheduleQuery= $"DELETE FROM[WorkSchedule] WHERE UpdatedBy = { userId };";
                string deleteEventQuery = $"DELETE FROM Event WHERE CreatedBy = {userId};";
                string deleteAdminQuery = $"DELETE FROM AdminDetails WHERE AdminID = {userId};";
                string deleteUserQuery = $"DELETE FROM [User] WHERE UserID = {userId};";

                bool chatDeleted = DataAccess.Execute(deleteChatQuery);
                bool workScheduleDeleted = DataAccess.Execute(deleteWorkscheduleQuery);
                bool eventDeleted = DataAccess.Execute(deleteEventQuery);
                bool adminDeleted = DataAccess.Execute(deleteAdminQuery);
                bool userDeleted = DataAccess.Execute(deleteUserQuery);
                if (userId == UserId1)
                {
                    this.Close();
                }

                if (userDeleted)
                {
                    MessageBox.Show("Admin deleted successfully!");
                    ClearForm();
                    RefreshAdminData();
                }
                else
                {
                    MessageBox.Show("Failed to delete admin. Please try again.");
                }
            }
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                updateButton.Enabled = true;
                password2.Enabled = false;
                confirm2.Enabled = false;
                DataGridViewRow row = showDataGridView.Rows[e.RowIndex];

                userId = Convert.ToInt32(row.Cells["UserID1"].Value);

                name2.Text = row.Cells["FullName1"].Value.ToString();
                email2.Text = row.Cells["Email1"].Value.ToString();
                phno2.Text = row.Cells["PhoneNumber1"].Value.ToString();

                if (row.Cells["Dob1"].Value != DBNull.Value)
                {
                    DateTime dob = (DateTime)row.Cells["Dob1"].Value;
                    dob2.Text = dob.ToString("dddd, MMMM d, yyyy");
                }

                string gender = row.Cells["Gender1"].Value.ToString();
                mr2.Checked = (gender == "Male");
                fr2.Checked = (gender == "Female");

                string address = row.Cells["Address1"].Value.ToString();
                if (!string.IsNullOrEmpty(address))
                {
                    string[] parts = address.Split(',');
                    if (parts.Length >= 3)
                    {
                        rc2.Text = parts[0].Trim();
                        cc2.Text = parts[1].Trim();
                        home2.Text = parts[2].Trim();
                    }
                }

                if (row.Cells["SharePercentage1"].Value != DBNull.Value)
                {
                    share1.Text = row.Cells["SharePercentage1"].Value.ToString();
                }
                else
                {
                    share1.Text = "0";
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            password2.Enabled = true;
            confirm2.Enabled = true;
            ClearForm();
            RefreshAdminData();
            updateButton.Enabled = false;
        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            if (password2.PasswordChar == '*')
            {
                password2.PasswordChar = '\0';
            }
            else
            {
                password2.PasswordChar = '*';

            }
        }

        private void showPasswordButton1_Click(object sender, EventArgs e)
        {
            if (confirm2.PasswordChar == '*')
            {
                confirm2.PasswordChar = '\0';

            }
            else
            {
                confirm2.PasswordChar = '*';

            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            AdminPasswordChange changePasswordForm = new AdminPasswordChange(UserId1);
            changePasswordForm.Show();
            this.Hide();

        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            adminEventOperation adminEvent = new adminEventOperation(UserId1);
            adminEvent.Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.SetUserId(UserId1);
            adminHome.Show();
            this.Hide();

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
