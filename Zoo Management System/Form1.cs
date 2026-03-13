using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class visitorHome : Form
    {
        //private List<Image> imageList = new List<Image>();
        private int currentImageIndex = 0;
        private int userId;
        public visitorHome(int userId)
        {
            InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;
            this.userId=userId;
            CheckAndDeactivateExpiredMemberships();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            visitorProfileMain visitorProfileForm = new visitorProfileMain(userId);
            visitorProfileForm.Show();
            timer1.Stop();
           // foreach (var img in imageList) img.Dispose();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (imageList.Count == 0) return;

            //currentImageIndex = (currentImageIndex + 1) % imageList.Count;

            // Use sync versions
            //guna2Transition1.HideSync(guna2PictureBox1);
            //guna2PictureBox1.Image = imageList[currentImageIndex];
            //guna2Transition1.ShowSync(guna2PictureBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //imageList.Add(Image.FromFile("zoo1.jpg"));
           // imageList.Add(Image.FromFile("zoo2.jpg"));
            //imageList.Add(Image.FromFile("zoo3.jpg"));

            // Display first image
            //if (imageList.Count > 0)
            //{
             //   guna2PictureBox1.Image = imageList[0];
            //}
            // Set up timer
            //timer1.Interval = 5000; // 3 seconds
            //timer1.Start();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Accessibity accessibityForm = new Accessibity(userId);
            accessibityForm.Show();
            timer1.Stop();
            //foreach (var img in imageList) img.Dispose();
           // this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            GettingHere gettingHereForm = new GettingHere(userId);
            gettingHereForm.Show();
            timer1.Stop();
            //foreach (var img in imageList) img.Dispose();
            this.Hide();
        }

        private void membershipbtn_Click(object sender, EventArgs e)
        {
            string query = $"SELECT IsMember FROM VisitorDetails WHERE VisitorID = {userId}"; 
            DataTable dt = DataAccess.GetData(query);

            if (dt.Rows.Count > 0 && Convert.ToBoolean(dt.Rows[0]["IsMember"]))
            {
                MemberFrame memberFrame = new MemberFrame(userId);
                memberFrame.Show();
            }
            else
            {
                Membership membershipForm = new Membership(userId); 
                membershipForm.Show();
            }

            timer1.Stop();
            //foreach (var img in imageList) img.Dispose();
            this.Hide();

        }
        private void CheckAndDeactivateExpiredMemberships()
        {
            // Simple combined update
            string deactivateSql = @"
                                  
                                   UPDATE Membership 
                                   SET IsActive = 0 
                                   WHERE IsActive = 1 
                                   AND EndDate < GETDATE();

                                   
                                   UPDATE VisitorDetails
                                   SET IsMember = 0
                                   WHERE VisitorID IN (
                                   SELECT VisitorID 
                                   FROM Membership
                                   WHERE IsActive = 1
                                   AND EndDate < GETDATE()
                                   )
                                   AND NOT EXISTS (
                                   SELECT * 
                                   FROM Membership 
                                   WHERE VisitorID = VisitorDetails.VisitorID
                                   AND IsActive = 1
                                   AND EndDate >= GETDATE()
                                   )";

            DataAccess.Execute(deactivateSql);
        }

        private void Feedbackbtn_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(userId);
            feedback.Show();
            timer1.Stop();
            //foreach (var img in imageList) img.Dispose();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(userId);
            shop.Show();
            timer1.Stop();
            //foreach (var img in imageList) img.Dispose();
            this.Hide();
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            visitorTransactionFrame visitorTransactionFrame = new visitorTransactionFrame(userId);
            visitorTransactionFrame.Show();
            timer1.Stop();
           // foreach (var img in imageList) img.Dispose();
            this.Hide();
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            visitorEvent ve= new visitorEvent(userId);
            ve.Show();
            timer1.Stop();
            //foreach (var img in imageList) img.Dispose();
            this.Hide();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PickDateTime pickDateTime = new PickDateTime(userId,userId);
            pickDateTime.Show();
            this.Hide();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();





        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AnimalHomeScreen animalHomeScreen = new AnimalHomeScreen();
            animalHomeScreen.Show();
            timer1.Stop();
            //foreach (var img in imageList) img.Dispose();
            
        }
    }
}
