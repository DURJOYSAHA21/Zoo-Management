using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class Membership : Form
    {
        private int userId;
        private string selectedMembership = "Gold";
        private decimal goldPrice;
        private decimal silverPrice;
        private decimal goldChildPrice;
        private decimal silverChildPrice;
        private decimal totalPrice;
        private decimal directDebitPrice;
        public Membership(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            string query = "SELECT * FROM MembershipType";
            DataTable dt = DataAccess.GetData(query);

            LoadMembershipTypes();
        }
        private void LoadMembershipTypes()
        {
            string query = "SELECT * FROM MembershipType";
            DataTable dt = DataAccess.GetData(query);

            if (dt.Rows.Count > 0)
            {
                goldPrice = Convert.ToDecimal(dt.Rows[0]["AdultPrice"]);
                goldChildPrice = Convert.ToDecimal(dt.Rows[0]["ChildPrice"]);

                silverPrice = Convert.ToDecimal(dt.Rows[1]["AdultPrice"]);
                silverChildPrice = Convert.ToDecimal(dt.Rows[1]["ChildPrice"]);
            }
        }

        private void adPlusbt_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(adNum.Text) < 2)
            {
                int num= Convert.ToInt32(adNum.Text);
                num++;
                adNum.Text = num.ToString();
                if (Convert.ToInt32(adNum.Text) >= 2)
                {
                    adultHeading.Text = "You have reached the maximum number of adults";
                    adultHeading.ForeColor = Color.Red;
                    adPlusbt.Enabled = false;
                }
                UpdatePrices();
            }
        }

        private void cldPlusbt_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cldNum.Text) < 4)
            {
                int num = Convert.ToInt32(cldNum.Text);
                num++;
                cldNum.Text = num.ToString();
                if (Convert.ToInt32(cldNum.Text) >= 4)
                {
                    childHeading.Text = "You have reached the maximum number of children";
                    childHeading.ForeColor = Color.Red;
                    cldPlusbt.Enabled = false;
                }
                UpdatePrices();
            }
        }

        private void adMinusbt_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(adNum.Text) == 2)
            {
                adPlusbt.Enabled = true;
            }
            if (Convert.ToInt32(adNum.Text) > 0)
            {
                int num = Convert.ToInt32(adNum.Text);
                num--;
                adNum.Text = num.ToString();
                if(Convert.ToInt32(adNum.Text) < 4)
                {
                    adultHeading.Text = "Select number of adults";
                    adultHeading.ForeColor = Color.Black;
                }
                UpdatePrices();
            }
        }

        private void cdMinusbt_Click(object sender, EventArgs e)
        {
            
            if(Convert.ToInt32(cldNum.Text) == 4)
            {
                cldPlusbt.Enabled = true;
            }
            if (Convert.ToInt32(cldNum.Text) > 0)
            {
                int num = Convert.ToInt32(cldNum.Text);
                num--;
                cldNum.Text = num.ToString();
                if (Convert.ToInt32(cldNum.Text) < 4)
                {
                    childHeading.Text = "Select number of child";
                    childHeading.ForeColor = Color.Black;
                }
                UpdatePrices();
            }
        }

        private void silverbtn_Click(object sender, EventArgs e)
        {
            selectedMembership = "Silver";
            membershipCardPanel.FillColor = Color.LightGray;
            featureLabel1.Text = "•  Unlimited visits to both London Zoos for 1 year\n\n" +
                         "•  Exclusive member updates\n\n" +
                         "•  Free entry on your birthday\n\n" +
                         "•  One guest per month at 50% discount\n\n" +
                         "•  Standard event access (no priority)";
            featureLabel1.ForeColor = Color.Black;
            UpdatePrices();
        }

        private void goldbtn_Click(object sender, EventArgs e)
        {
            selectedMembership = "Gold";
            membershipCardPanel.FillColor = Color.Gold;
            featureLabel1.Text = "• Unlimited visits to both zoos for 1 year\n" +
                     "• Exclusive member updates\n" +
                     "• 10% discount in Zoo shops and restaurants\n" +
                     "• 50% off car entry at Whipsnade Zoo\n" +
                     "• Exclusive daily Hullabazoo Indoor Play sessions at Whipsnade Zoo*\n" +
                     "• Priority booking and discounts on selected events\n" +
                     "• Free off-peak parking at London Zoo*\n" +
                     "• Two free guest entries per month\n" +
                     "• Free birthday entry + 1 free meal\n" +
                     "• Early access to new exhibits\n" +
                     "• Priority response to member feedback\n" +
                     "* Subject to terms and conditions";
            featureLabel1.ForeColor = Color.DarkGreen;
            UpdatePrices();
        }

        private void Membership_Load(object sender, EventArgs e)
        {
            featureLabel1.Text = "• Unlimited visits to both zoos for 1 year\n" +
                     "• Exclusive member updates\n" +
                     "• 10% discount in Zoo shops and restaurants\n" +
                     "• 50% off car entry at Whipsnade Zoo\n" +
                     "• Exclusive daily Hullabazoo Indoor Play sessions at Whipsnade Zoo*\n" +
                     "• Priority booking and discounts on selected events\n" +
                     "• Free off-peak parking at London Zoo*\n" +
                     "• Two free guest entries per month\n" +
                     "• Free birthday entry + 1 free meal\n" +
                     "• Early access to new exhibits\n" +
                     "• Priority response to member feedback\n" +
                     "* Subject to terms and conditions";
            featureLabel1.ForeColor = Color.DarkGreen;
            directDebitbtn.Text = "Direct Debit\n"+"£" + ((Convert.ToInt32(adNum.Text) * 50 + Convert.ToInt32(cldNum.Text) * 30)-((Convert.ToInt32(adNum.Text) * 10 + Convert.ToInt32(cldNum.Text) * 5)*0.2)).ToString();
            cardbtn.Text = "Card Payment\n" + "£" + (Convert.ToInt32(adNum.Text) * 50 + Convert.ToInt32(cldNum.Text) * 30).ToString();
        }
        private void UpdatePrices()
        {
            int adults = Convert.ToInt32(adNum.Text);
            int children = Convert.ToInt32(cldNum.Text);

            decimal adultPrice = (selectedMembership == "Gold") ? goldPrice : silverPrice;
            decimal childPrice = (selectedMembership == "Gold") ? goldChildPrice : silverChildPrice;

            totalPrice = adults * adultPrice + children * childPrice;
            directDebitPrice = totalPrice * 0.8m; 

            directDebitbtn.Text = $"Direct Debit\n£{directDebitPrice:0.00}";
            cardbtn.Text = $"Card Payment\n£{totalPrice:0.00}";
        }

        private void directDebitbtn_Click(object sender, EventArgs e)
        {
            if (adNum.Text == "0" && cldNum.Text == "0")
            {
                MessageBox.Show("Please enter at least an adult or a child");
                return;
            }
            else
            {
                MembershipPayment payment = new MembershipPayment(userId, totalPrice, 20,"Direct Debit", adNum.Text, cldNum.Text, selectedMembership);
                payment.Show();
                this.Hide();
            }
        }

        private void cardbtn_Click(object sender, EventArgs e)
        {
            if (adNum.Text == "0" && cldNum.Text == "0")
            {
                MessageBox.Show("Please enter at least an adult or a child");
                return;
            }
            else 
            {
               MembershipPayment payment = new MembershipPayment(userId, totalPrice, 0,"Credit Card", adNum.Text, cldNum.Text, selectedMembership);
               payment.Show(this);
                this.Hide();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            visitorHome home = new visitorHome(userId); 
            home.Show();
            this.Close();
        }
    }
}
