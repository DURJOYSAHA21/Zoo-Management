using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ZooManagementSystem;

namespace ZooManagementSystem
{
    public partial class AnimalHomeScreen : Form
    {
        private Form previousForm;
        private int UserID;
        private DataTable allAnimals;

        public AnimalHomeScreen(Form callerForm = null)
        {
            InitializeComponent();
            previousForm = callerForm;
            LoadData();
        }

        public void SetUserID(int userID) 
        { this.UserID = userID; }

        private void LoadData()
        {
            try
            {
                string query = "SELECT AnimalID, Name, Species, ProfileImage FROM Animal";
                allAnimals = DataAccess.GetData(query); // Store all data

                if (allAnimals == null || allAnimals.Rows.Count == 0)
                {
                    MessageBox.Show("No animals found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                FilterAnimals(""); // Show all animals initially
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading animals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        
private void FilterAnimals(string searchText)
{
    flowPanel.Controls.Clear();

    if (allAnimals == null) return;

    searchText = searchText.ToLower();

    foreach (DataRow row in allAnimals.Rows)
    {
        string name = row["Name"].ToString().ToLower();
        string species = row["Species"].ToString().ToLower();

        if (string.IsNullOrEmpty(searchText) ||
            name.Contains(searchText) ||
            species.Contains(searchText))
        {
            var card = CreateAnimalCard(
                Convert.ToInt32(row["AnimalID"]),
                row["Name"].ToString(),
                row["Species"].ToString(),
                row["ProfileImage"].ToString()
            );
            flowPanel.Controls.Add(card);
        }
    }

    if (flowPanel.Controls.Count == 0)
    {
        Label noResults = new Label
        {
            Text = "No matching animals found",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        flowPanel.Controls.Add(noResults);
    }
}

private Guna2Panel CreateAnimalCard(int animalId, string name, string species, string imagePath)
        {
            var card = new Guna2Panel
            {
                Width = 180,
                Height = 220,
                BorderRadius = 15,
                FillColor = Color.FromArgb(155, 193, 131),
                
               
                Margin = new Padding(10),
                Tag = animalId,
                Cursor = Cursors.Hand
            };

            var pictureBox = new Guna2PictureBox
            {
                Width = 160,
                Height = 140,
                Location = new Point(10, 10),
                BorderRadius = 10,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.White,
                Cursor = Cursors.Hand,
                Tag = animalId
            };

            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                    pictureBox.UseTransparentBackground = true;
                }
                else
                {
                    pictureBox.Image = CreateSimplePlaceholder();
                    pictureBox.UseTransparentBackground = false;
                }
            }
            catch
            {
                pictureBox.Image = CreateSimplePlaceholder();
            }

            var nameLabel = new Label
            {
                Text = name,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Bottom,
                Height = 50,
                BackColor = Color.Transparent,
                Tag = animalId 
            };

            card.Click += (s, e) => OpenAnimalViewer(animalId-1);
            pictureBox.Click += (s, e) => OpenAnimalViewer(animalId-1);
            nameLabel.Click += (s, e) => OpenAnimalViewer(animalId - 1);

            card.Controls.Add(pictureBox);
            card.Controls.Add(nameLabel);

            return card;
        }

        private Image CreateSimplePlaceholder()
        {
            var bmp = new Bitmap(160, 140);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                g.DrawString("No Image", new Font("Arial", 10), Brushes.Black, new PointF(50, 60));
            }
            return bmp;
        }

        private void OpenAnimalViewer(int animalId)
        {
            new AnimalViewer(animalId).Show();
        }

        private void AnimalHomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm?.Show();
        }

        private void flowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterAnimals(searchTextBox.Text);

        }

        private void AnimalHomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}