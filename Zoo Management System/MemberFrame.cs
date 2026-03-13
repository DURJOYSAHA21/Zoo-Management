using GMap.NET.MapProviders;
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
    public partial class MemberFrame : Form
    {
        private int userId;
        public MemberFrame(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            string query = $@"SELECT u.FullName as Purchaseholder,
                              mt.Name as MembershipType,
                              CONVERT(varchar, m.StartDate, 103) as PurchaseDate,
                              CONVERT(varchar, m.EndDate, 103) as ValidateTill,
                              DATEDIFF(day, GETDATE(), m.EndDate) as DaysRemaining,
                              m.Adults as UsableAdult,
                              m.Children as UsableChild,
                              t.Amount as TotalCost
                              FROM Membership m
                              JOIN MembershipType mt ON m.MembershipTypeID = mt.MembershipTypeID
                              JOIN [User] u ON m.VisitorID = u.UserID
                              JOIN [Transaction] t ON m.TransactionID = t.TransactionID
                              WHERE m.VisitorID = {userId} AND m.IsActive = 1 AND GETDATE() BETWEEN m.StartDate AND m.EndDate";

            DataTable dt = DataAccess.GetData(query);

            if (dt.Rows.Count > 0)
            {
                string membershipType = dt.Rows[0]["MembershipType"].ToString();
                if (membershipType == "Gold")
                {
                    memberHeadLabel.Text = "Gold Member";
                    memberHeadLabel.ForeColor = Color.Goldenrod;
                    featureLabel.Text = "• Unlimited visits to both zoos for 1 year\n" +
                                     "• Exclusive member updates\n" +
                                     "• 10% discount in Zoo shops and restaurants\n" +
                                     "• 50% off car entry at Whipsnade Zoo\n" +
                                     "• Exclusive daily Hullabazoo Indoor Play sessions *\n" +
                                     "• Priority booking and discounts on selected events\n" +
                                     "• Free off-peak parking at London Zoo*\n" +
                                     "• Two free guest entries per month\n" +
                                     "• Free birthday entry + 1 free meal\n" +
                                     "• Early access to new exhibits\n" +
                                     "• Priority response to member feedback\n" +
                                     "* Subject to terms and conditions";
                }
                else if (membershipType == "Silver")
                {
                    memberHeadLabel.Text = "Silver Member";
                    memberHeadLabel.ForeColor = Color.Silver;
                    featureLabel.Text = "• Unlimited visits to both London Zoos for 1 year\n\n" +
                                     "• Exclusive member updates\n\n" +
                                     "• Free entry on your birthday\n\n" +
                                     "• One guest per month at 50% discount\n\n" +
                                     "• Standard event access (no priority)";
                }

                pnLabel.Text = dt.Rows[0]["Purchaseholder"].ToString();
                stLabel.Text = dt.Rows[0]["MembershipType"].ToString();
                pdLabel.Text = dt.Rows[0]["PurchaseDate"].ToString();
                vtLabel.Text = dt.Rows[0]["ValidateTill"].ToString();
                drLabel.Text = dt.Rows[0]["DaysRemaining"].ToString();
                uaLabel.Text = dt.Rows[0]["UsableAdult"].ToString();
                ucLabel.Text = dt.Rows[0]["UsableChild"].ToString();
                tcLabel.Text = "£" + dt.Rows[0]["TotalCost"].ToString();
            }
            else
            {
                MessageBox.Show("No active membership found");
            }
        }

        private void featureLabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            visitorHome home = new visitorHome(userId);
            home.Show();
            this.Close();
        }
    }
}
