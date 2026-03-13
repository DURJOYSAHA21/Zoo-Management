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
    public partial class Feedback : Form
    {
        private int userId;
        int excellentCount = 0;
        int veryGoodCount = 0;
        int averageCount = 0;
        int poorCount = 0;
        int terribleCount = 0;
        public Feedback(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            //progress bars
            progressExcellent.Maximum = 100;
            progressVeryGood.Maximum = 100;
            progressAverage.Maximum = 100;
            progressPoor.Maximum = 100;
            progressTerrible.Maximum = 100;

            //colors
            progressExcellent.ProgressColor = Color.Green;
            progressVeryGood.ProgressColor = Color.LightGreen;
            progressAverage.ProgressColor = Color.Orange;
            progressPoor.ProgressColor = Color.OrangeRed;
            progressTerrible.ProgressColor = Color.Red;
            ShowReviewGridView.AutoGenerateColumns = false;
            LoadRatingsFromDatabase();
            LoadFeedbackData();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string feedbackText = feedbackTextBox1.Text;
            int rating = GetSelectedRating();

            if (string.IsNullOrWhiteSpace(feedbackText))
            {
                MessageBox.Show("Please enter your feedback text");
                return;
            }

            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Please select a valid rating");
                return;
            }

            string query = $@"
                            INSERT INTO Feedback (VisitorID, Message, Rating, DateSubmitted)
                            VALUES ({userId}, '{feedbackText.Replace("'", "''")}', {rating}, GETDATE())";

            try
            {
                DataAccess.Execute(query);

                int totalRatings = excellentCount + veryGoodCount + averageCount + poorCount + terribleCount + 1;

                switch (rating)
                {
                    case 5: excellentCount++; break;
                    case 4: veryGoodCount++; break;
                    case 3: averageCount++; break;
                    case 2: poorCount++; break;
                    case 1: terribleCount++; break;
                }

                UpdateRatingDisplay();
                MessageBox.Show("Thank you for your feedback!");
                ShowReviewGridView.Refresh();
                feedbackTextBox1.Text = "";
                guna2RatingStar1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving feedback: " + ex.Message);
            }
            LoadFeedbackData();
        }
        private int GetSelectedRating()
        {
            return (int)guna2RatingStar1.Value;
        }
        private void LoadRatingsFromDatabase()
        {
            string query = "SELECT Rating FROM Feedback";
            DataTable dt = DataAccess.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                int rating = Convert.ToInt32(row["Rating"]);
                switch (rating)
                {
                    case 5: excellentCount++; break;
                    case 4: veryGoodCount++; break;
                    case 3: averageCount++; break;
                    case 2: poorCount++; break;
                    case 1: terribleCount++; break;
                }
            }

            UpdateRatingDisplay();
        }
        private void UpdateRatingDisplay()
        {
            int totalRatings = excellentCount + veryGoodCount + averageCount + poorCount + terribleCount;

            if (totalRatings > 0)
            {
                progressExcellent.Value = (int)((double)excellentCount / totalRatings * 100);
                progressVeryGood.Value = (int)((double)veryGoodCount / totalRatings * 100);
                progressAverage.Value = (int)((double)averageCount / totalRatings * 100);
                progressPoor.Value = (int)((double)poorCount / totalRatings * 100);
                progressTerrible.Value = (int)((double)terribleCount / totalRatings * 100);

                ExcellentNum.Text = excellentCount.ToString();
                veryGoodNum.Text = veryGoodCount.ToString();
                averageNum.Text = averageCount.ToString();
                poorNum.Text = poorCount.ToString();
                teribbleNum.Text = terribleCount.ToString();
            }
        }
        private void LoadFeedbackData()
        {
            string query = $@"SELECT 
                            f.FeedbackID,
                            u.FullName as SenderName,
                            f.Message,
                            f.Rating,
                            CONVERT(varchar, f.DateSubmitted, 103) as SubmissionDate
                            FROM Feedback f
                            JOIN [User] u ON f.VisitorID = u.UserID
                            ORDER BY f.DateSubmitted DESC, f.FeedbackID DESC";
            try
            {
                DataTable dt = DataAccess.GetData(query);
                ShowReviewGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message);
            }
            foreach (DataGridViewRow row in ShowReviewGridView.Rows)
            {
                if (row.Cells["Message"] != null)
                    row.Cells["Message"].Style.BackColor = Color.Empty;
                if (row.Cells["FullName"] != null)
                    row.Cells["FullName"].Style.BackColor = Color.Empty;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadFeedbackData();
            }
            else
            {
                SearchFeedback(searchText);
            }

        }
        private void SearchFeedback(string searchTerm)
        {
            string query = $@"SELECT 
                              f.FeedbackID,
                              u.FullName as SenderName,
                              f.Message,
                              f.Rating,
                              CONVERT(varchar, f.DateSubmitted, 103) as SubmissionDate
                              FROM Feedback f
                              JOIN [User] u ON f.VisitorID = u.UserID
                              WHERE u.FullName LIKE '%{searchTerm.Replace("'", "''")}%' 
                              OR f.Message LIKE '%{searchTerm.Replace("'", "''")}%'
                              ORDER BY f.DateSubmitted DESC, f.FeedbackID DESC";

            try
            {
                DataTable dt = DataAccess.GetData(query);
                ShowReviewGridView.DataSource = dt;
                HighlightMatches(searchTerm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching feedback: " + ex.Message);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim();

            if (searchText.Length > 2)
            {
                SearchFeedback(searchText);
                foreach (DataGridViewRow row in ShowReviewGridView.Rows)
                {
                    row.Cells["Message"].Style.BackColor = Color.Empty;
                    row.Cells["FullName"].Style.BackColor = Color.Empty;
                }
            }
            else if (string.IsNullOrEmpty(searchText))
            {
                LoadFeedbackData();
            }
        }
        private void HighlightMatches(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) return;

            foreach (DataGridViewRow row in ShowReviewGridView.Rows)
            {
                if (row.Cells["Message"].Value != null)
                {
                    string message = row.Cells["Message"].Value.ToString();
                    row.Cells["Message"].Style.BackColor = message.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ? Color.Yellow : Color.Empty;
                }

                if (row.Cells["FullName"].Value != null)
                {
                    string name = row.Cells["FullName"].Value.ToString();
                    row.Cells["FullName"].Style.BackColor = name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ? Color.Yellow : Color.Empty;
                }
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
