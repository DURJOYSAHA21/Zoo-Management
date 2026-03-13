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
    public partial class visitorProfile : Form
    {
        private int userId;
        public visitorProfile(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            string query1 = $"SELECT FullName, Password, Email, PhoneNumber, Address, Gender, Dob FROM [User] WHERE UserID = {userId};";
            DataTable visitors = DataAccess.GetData(query1);
            if (visitors == null || visitors.Rows.Count == 0)
            {
                MessageBox.Show("No visitor found with the given ID.");
                return;
            }
            else
            {
                MessageBox.Show("User Found");
            }
            name1.Text = visitors.Rows[0]["FullName"].ToString();
            email1.Text = visitors.Rows[0]["Email"].ToString();
            password1.Text = visitors.Rows[0]["Password"].ToString();
            confirm1.Text = visitors.Rows[0]["Password"].ToString();
            phno1.Text = visitors.Rows[0]["PhoneNumber"].ToString();
            dob1.Text = ((DateTime)visitors.Rows[0]["Dob"]).ToString("MM/dd/yyyy");
            rc1.SelectedItem = visitors.Rows[0]["Address"].ToString().Split(',')[0].Trim();
            cc1.SelectedItem = visitors.Rows[0]["Address"].ToString().Split(',')[1].Trim();
            home1.Text = visitors.Rows[0]["Address"].ToString().Split(',')[2].Trim();
            string gender = visitors.Rows[0]["Gender"].ToString();
            if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                mr1.Checked = true;
            }
            else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                fr1.Checked = true;
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            visitorProfileMain visitorMainForm = new visitorProfileMain(userId);
            this.Hide();
            visitorMainForm.Show();
        }

        private void updatebt_Click(object sender, EventArgs e)
        {
            string name = "";
            string email = "";
            string password = "";
            string phoneNo = "";
            string dob = "";
            string gender = "";
            string address = "";

            //name
            if (string.IsNullOrEmpty(name1.Text))
            {
                MessageBox.Show("Please enter a name!");
                return;
            }
            else
            {
                if (name1.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Name contains invalid characters");
                    return;
                }
                name = name1.Text;
            }
            //email
            if (string.IsNullOrEmpty(email1.Text))
            {
                MessageBox.Show("Please enter a email!");
                return;
            }
            else
            {
                if (email1.Text.Contains('@') && email1.Text.Contains(".com"))
                {
                    email = email1.Text;
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address!");
                    return;
                }

            }
            //password
            if (string.IsNullOrEmpty(password1.Text) || string.IsNullOrEmpty(confirm1.Text))
            {
                MessageBox.Show("Please enter and confirm your password!");
                return;
            }
            else if (password1.Text == confirm1.Text)
            {
                if (password1.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 6 characters long!");
                    return;
                }
                if (!password1.Text.Any(char.IsUpper) || !password1.Text.Any(c => !char.IsLetterOrDigit(c)))
                {
                    MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, and one special character!");
                    return;
                }
                password = password1.Text;
                message1.Text = "Matched!!";
                message1.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
                message1.Text = "Not Matched!!";
                message1.ForeColor = Color.Red;
                return;
            }
            //phone number
            if (phno1.Text.Length != 11)
            {
                MessageBox.Show("Please enter a valid phone number!");
                return;
            }
            else
            {
                for (int i = 0; i < phno1.Text.Length; i++)
                {
                    if (!char.IsDigit(phno1.Text[i]))
                    {
                        MessageBox.Show("Please enter a valid phone number!");
                        return;
                    }
                }
                phoneNo = phno1.Text;
            }
            //date of birth
            try
            {
                DateTime dobDate = DateTime.Parse(dob1.Text);
                dob = dobDate.ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Date Input");
                this.Close();
                return;
            }
            //gender
            if (mr1.Checked == false && fr1.Checked == false)
            {
                MessageBox.Show("Enter a gender");
                return;
            }
            else if (mr1.Checked)
            {
                gender = mr1.Text;
            }
            else
            {
                gender = fr1.Text;
            }
            //address
            if (rc1.SelectedItem == null)
            {
                MessageBox.Show("No District selected!");
                return;
            }
            if (cc1.SelectedItem == null)
            {
                MessageBox.Show("No District selected!");
                return;
            }
            if (string.IsNullOrEmpty(home1.Text))
            {
                MessageBox.Show("Please enter home address!");
                return;
            }
            address = rc1.Text + ", " + cc1.Text + ", " + home1.Text;

            string updateQuery = $"UPDATE [User] SET FullName = '{name}', Email = '{email}', Password = '{password}', PhoneNumber = '{phoneNo}', Address = '{address}', Gender = '{gender}', Dob = '{dob}' WHERE UserID = {userId}";
            bool isUpdated = DataAccess.Execute(updateQuery);

            if (isUpdated)
            {
                MessageBox.Show("Profile updated successfully!");
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.");
            }

        }

        private void dc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cc1.Items.Clear();
            if (rc1.SelectedIndex == 0)
            {
                string[] africa = { "Nigeria", "Egypt", "South Africa", "Kenya", "Ethiopia", "Ghana", "Morocco", "Tanzania" };
                cc1.Items.AddRange(africa);
            }
            else if (rc1.SelectedIndex == 1)
            {
                string[] asia = { "Bangladesh", "China", "India", "Japan", "South Korea", "Indonesia", "Thailand", "Vietnam", "Malaysia" };
                cc1.Items.AddRange(asia);
            }
            else if (rc1.SelectedIndex == 2)
            {
                string[] europe = { "Germany", "France", "Italy", "Spain", "United Kingdom", "Netherlands", "Switzerland", "Sweden" };
                cc1.Items.AddRange(europe);
            }
            else if (rc1.SelectedIndex == 3)
            {
                string[] northAmerica = { "United States", "Canada", "Mexico", "Costa Rica", "Panama", "Cuba", "Jamaica", "Dominican Republic" };
                cc1.Items.AddRange(northAmerica);
            }
            else if (rc1.SelectedIndex == 4)
            {
                string[] southAmerica = { "Brazil", "Argentina", "Colombia", "Peru", "Chile", "Ecuador", "Venezuela", "Bolivia" };
                cc1.Items.AddRange(southAmerica);
            }
            else if (rc1.SelectedIndex == 5)
            {
                string[] oceania = { "Australia", "New Zealand", "Fiji", "Papua New Guinea", "Samoa", "Tonga", "Vanuatu", "Solomon Islands" };
                cc1.Items.AddRange(oceania);
            }
            else if (rc1.SelectedIndex == 6)
            {
                string[] middleEast = { "Saudi Arabia", "United Arab Emirates", "Qatar", "Israel", "Turkey", "Iran", "Iraq", "Jordan" };
                cc1.Items.AddRange(middleEast);
            }
            else
            {
                MessageBox.Show("Please select a valid continent!");
                return;
            }

        }

        private void confirm1_TextChanged(object sender, EventArgs e)
        {
            if (password1.Text == confirm1.Text)
            {
                message1.Text = "Matched!!";
                message1.ForeColor = Color.Green;
            }
            else
            {
                message1.Text = "Not Matched!!";
                message1.ForeColor = Color.Red;
            }
        }

        private void password1_TextChanged(object sender, EventArgs e)
        {
            if (password1.Text == confirm1.Text)
            {
                message1.Text = "Matched!!";
                message1.ForeColor = Color.Green;
            }
            else
            {
                message1.Text = "Not Matched!!";
                message1.ForeColor = Color.Red;
            }
        }

    }
}
