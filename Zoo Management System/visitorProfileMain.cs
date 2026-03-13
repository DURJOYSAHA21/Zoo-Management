using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class visitorProfileMain : Form
    {
        private int userId;
        public visitorProfileMain(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            try
            {
                string name = "";
                string email = "";
                string phoneNo = "";
                string dob = "";
                string membershipType = "";
                string gender = "";
                string address = "";


                string query1 = $"SELECT u.FullName, u.Email, u.PhoneNumber, u.Address, u.Gender, u.JoinDate, u.Dob, v.IsMember FROM [User] u LEFT JOIN VisitorDetails v ON u.UserID = v.VisitorID WHERE u.UserID = {userId};";

                DataTable visitors = DataAccess.GetData(query1);
                if (visitors == null || visitors.Rows.Count == 0)
                {
                    MessageBox.Show("No visitor found with the given ID.");
                    return;
                }
                else
                {
                    //MessageBox.Show("User Found");
                }

                name = visitors.Rows[0]["FullName"].ToString();
                email = visitors.Rows[0]["Email"].ToString();
                phoneNo = visitors.Rows[0]["PhoneNumber"].ToString();
                if (visitors.Rows[0]["Dob"] != DBNull.Value)
                {
                    DateTime dob2 = (DateTime)visitors.Rows[0]["Dob"];
                    dob = dob2.ToString("MM/dd/yyyy");
                }
                gender = visitors.Rows[0]["Gender"].ToString();
                address = visitors.Rows[0]["Address"].ToString();
                if (Convert.ToBoolean(visitors.Rows[0]["IsMember"]))
                {
                    membershipType = "True";
                }
                else
                {
                    membershipType = "False";
                }

                uid1.Text = userId.ToString();
                name1.Text = name;
                email1.Text = email;
                phno1.Text = phoneNo;
                dob1.Text = dob;
                gender1.Text = gender;
                address1.Text = address;
                membership1.Text = membershipType;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing visitor profile: " + ex.Message);
            }


        }

        private void visitorProfileMain_Load(object sender, EventArgs e)
        {



        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            visitorProfile updateProfileForm = new visitorProfile(userId);
            updateProfileForm.Show();
            this.Hide();
        }

        private void deleteBtn1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your profile? This cannot be undone!", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = $@"DELETE FROM [TicketItem] WHERE TicketID IN (SELECT TicketID FROM [Ticket] WHERE VisitorID = {userId});
                                           DELETE FROM [Ticket] WHERE VisitorID = {userId};
                                           DELETE FROM [Membership] WHERE VisitorID = {userId};
                                           DELETE FROM [OrderItems] WHERE TransactionID IN (SELECT TransactionID FROM [Transaction] WHERE VisitorID = {userId});
                                           DELETE FROM [Transaction] WHERE VisitorID = {userId};
                                           DELETE FROM [Feedback] WHERE VisitorID = {userId};
                                           DELETE FROM [VisitorDetails] WHERE VisitorID = {userId};
                                           DELETE FROM [User] WHERE UserID = {userId};";
                    bool isDeleted = DataAccess.Execute(deleteQuery);

                    if (isDeleted)
                    {
                        MessageBox.Show("Account deleted successfully.");
                        this.Close();
                        new LoginForm().Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Account.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting Account: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Deletion cancelled.");
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            visitorHome visitorHomeForm = new visitorHome(userId);
            visitorHomeForm.Show();
            this.Hide();
        }
    }
}
