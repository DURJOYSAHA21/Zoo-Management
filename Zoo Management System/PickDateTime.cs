
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
    public partial class PickDateTime : Form
    {
        private int visitorId; 
        private int userId; 
        DateTime selectedDate;
        int adultQty = 0;
        int childQty = 0;
        decimal total = 0.00m;
        private bool memberExists;
        int freeAdult = 0;
        int freeChild = 0;

        private void CheckMembership()
        {
            try
            {
                MessageBox.Show("Checking membership for VisitorID: " + visitorId);

                string query = $"SELECT IsMember FROM VisitorDetails WHERE VisitorID = {visitorId}";
                DataTable dt = DataAccess.GetData(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bool isMember = Convert.ToBoolean(dt.Rows[0]["IsMember"]);

                    if (isMember)
                    {
                        memberExists = true;
                        string query2 = $"SELECT * FROM Membership WHERE VisitorID = {visitorId}";
                        DataTable dt2 = DataAccess.GetData(query2);
                        if (dt2 != null && dt2.Rows.Count > 0)
                        {
                            freeAdult = Convert.ToInt32(dt2.Rows[0]["Adults"]);
                            freeChild = Convert.ToInt32(dt2.Rows[0]["Children"]);
                        }
                        else
                        {
                            freeAdult = 0;
                            freeChild = 0;
                        }
                        MessageBox.Show($"You're a member!🎉 You get {freeAdult} free adult ticket and {freeChild} free child tickets as your membership discount.");
                    }
                    else
                    {
                        memberExists = false;
                        MessageBox.Show("You are not a member.");
                    }
                }
                else
                {
                    MessageBox.Show("Visitor not found.");
                    memberExists = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Membership check failed: " + ex.Message);
            }
        }

        public PickDateTime()
        {
            InitializeComponent();
        }
        public PickDateTime(int visitorId, int userId)
        {
            InitializeComponent();
            this.visitorId = visitorId;
            this.userId = userId;
            CheckMembership();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start;
            label2.Visible = true;
            lblDateDisplay.Visible = true;
            lblDateDisplay.Text = selectedDate.ToString("dd MMMM yyyy");
            if(selectedDate < DateTime.Today)
            {
                lblDateDisplay.Visible = false;
                MessageBox.Show("Please select a future date.");
                return;
            }
            tlpTickets.Visible = true;
        }
        private void btnAdultPlus_Click(object sender, EventArgs e)
        {
            adultQty++;
            lblAdultQty.Text = adultQty.ToString();
            UpdateTotal();
        }

        private void btnAdultMinus_Click(object sender, EventArgs e)
        {
            if(adultQty > 0)
            {
                adultQty--;
                lblAdultQty.Text = adultQty.ToString();
                UpdateTotal();
            }
        }

        private void btnChildPlus_Click(object sender, EventArgs e)
        {
            childQty++;
            lblChildQty.Text = childQty.ToString();
            UpdateTotal();
        }

        private void btnChildMinus_Click(object sender, EventArgs e)
        {
            if(childQty > 0)
            {
                childQty--;
                lblChildQty.Text = childQty.ToString();
                UpdateTotal();
            }
        }
        private void UpdateTotal()
        {
            if (memberExists==true)
            {
               

                int payableAdults = Math.Max(0, adultQty - freeAdult);
                int payableChildren = Math.Max(0, childQty - freeChild); //return big num

                total = (decimal)((payableAdults * 35.00) + (payableChildren * 24.50));
            }
            else
            {
                total = (decimal)((adultQty * 35.00) + (childQty * 24.50));
            }
            lblTotal.Visible = true;
            lblTotal.Text = $"Total: ${total:F2}";
        }

        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            if (adultQty == 0 && childQty == 0)
            {
                MessageBox.Show("Select at least one ticket.");
                return;
            }
            if (selectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("Please select a valid future date.");
                return;
            }
            else
            {
                Transaction tran = new Transaction(visitorId, selectedDate, adultQty, childQty,total, userId);
                tran.Show();
                this.Hide();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            visitorHome home = new visitorHome(userId);
            home.Show();
            this.Hide();
        }
    }
}
