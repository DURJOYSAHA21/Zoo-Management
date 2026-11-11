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
        // slideshow on the visitor home page: real animal photos from Resources and Photos\AnimalImages
        private readonly List<Image> imageList = new List<Image>();
        private static readonly string[] SlideImages =
        {
            "Kota-Lion-2023-1-640x480.jpg",
            "istockphoto-119356838-612x612.jpg",
            "Zebra.jpg",
            "cute-red-panda-dl4pm2ycuko8eyl0.jpg",
            "flamingo-4471367_1280.jpg",
            "hippo-3644217_1920.jpg",
        };
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
            if (imageList.Count < 2 || !Visible) return;

            currentImageIndex = (currentImageIndex + 1) % imageList.Count;

            // Use sync versions
            guna2Transition1.HideSync(guna2PictureBox1);
            guna2PictureBox1.Image = imageList[currentImageIndex];
            guna2Transition1.ShowSync(guna2PictureBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (string file in SlideImages)
            {
                Image photo = AssetPath.Load(file);
                if (photo != null) imageList.Add(FitTo(photo, guna2PictureBox1.Size));
            }

            // Display first image
            if (imageList.Count > 0)
            {
                guna2PictureBox1.Image = imageList[0];
            }
            // Set up timer
            timer1.Interval = 4000; // 4 seconds
            timer1.Start();

        }

        /// <summary>Crops a photo to the picture box's shape so the stretch mode does not distort it.</summary>
        private static Image FitTo(Image source, Size box)
        {
            double scale = Math.Max((double)box.Width / source.Width, (double)box.Height / source.Height);
            int w = Math.Min(source.Width, (int)Math.Round(box.Width / scale));
            int h = Math.Min(source.Height, (int)Math.Round(box.Height / scale));
            var crop = new Rectangle((source.Width - w) / 2, (source.Height - h) / 2, w, h);
            var result = new Bitmap(box.Width, box.Height);
            using (var g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(source, new Rectangle(Point.Empty, box), crop, GraphicsUnit.Pixel);
            }
            source.Dispose();
            return result;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            
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
