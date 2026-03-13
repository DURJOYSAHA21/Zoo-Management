using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class AnimalViewer : Form
    {
        public AnimalViewer(int x)
        {
            InitializeComponent();
            LoadAnimalData(x);
        }

        private void LoadAnimalData(int n)
        {
            try
            {
                string query = "SELECT * FROM Animal";
                DataTable dt = DataAccess.GetData(query);
                if (dt == null)
                {
                    labelName.Text = "Database connection failed";
                    MessageBox.Show("Could not connect to database. Please check your SQL Server connection.",
                                "Connection Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return;
                }
                if (dt.Rows.Count == 0)
                {
                    labelName.Text = "No animal found";
                    MessageBox.Show("No animal was found in the database.",
                                "Data Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    return;
                }
                labelName.Text = dt.Rows[n]["Name"].ToString();
                labelSpecies.Text = dt.Rows[n]["Species"].ToString();
                labelSName.Text = "Scientific Name:" + dt.Rows[n]["ScientificName"].ToString();
                labelZooID.Text = "Zoo ID : " + dt.Rows[n]["AnimalID"].ToString();
                pictureBoxAnimalPicture.ImageLocation =  dt.Rows[n]["ProfileImage"].ToString();
                string imagePath = dt.Rows[n]["ProfileImage"].ToString();
                /*if (!string.IsNullOrWhiteSpace(imagePath) && System.IO.File.Exists(imagePath))
                {
                    pictureBoxAnimalPicture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBoxAnimalPicture.Image = null; // or a default image
                }*/
                labelAge.Text = "Age : " + dt.Rows[n]["Age"].ToString();
                labelArrivalDate.Text = "Arrival Date : " + dt.Rows[n]["ArrivalDate"].ToString();
                labelHealthStatus.Text = "Status : " + dt.Rows[n]["Status"].ToString();
            }
            catch (Exception ex)
            {
                labelName.Text = "Error loading data";
                MessageBox.Show($"An error occurred while loading data:\n{ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void AnimalViewer_Load(object sender, EventArgs e)
        {

        }

        private void AnimalViewer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalHomeScreen animalHomeScreen = new AnimalHomeScreen();
            animalHomeScreen.Show();
            this.Hide();
        }

        private void pictureBoxAnimalPicture_Click(object sender, EventArgs e)
        {

        }
    }
}