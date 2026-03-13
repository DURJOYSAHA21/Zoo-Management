using System;
using System.Data;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            LoadData();
        }
        int employeeID;
      
        int AnimalID;
        public void SetEmployeeID(int employeeID)
        {
            this.employeeID = employeeID;
            var user = DataAccess.GetData($"SELECT * FROM [User] WHERE UserID = {employeeID}");
            
        }
       
        private void LoadData()
        {
            try
            {
                cmbSelectAnimal.Items.Clear();

                txtboxReportDate.Text = DateTime.Today.ToString("yyyy-MM-dd");

                string query = "SELECT AnimalID, Name FROM Animal ORDER BY Name";
                DataTable dt = DataAccess.GetData(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No animals found in the database.",
                                  "Information",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    int animalId = Convert.ToInt32(row["AnimalID"]);
                    string animalName = row["Name"].ToString();

                    cmbSelectAnimal.Items.Add($"{animalId} : {animalName}");
                }
                if (cmbSelectAnimal.Items.Count > 0)
                {
                    cmbSelectAnimal.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading animals: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
        private void cmbSelectAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectAnimal.SelectedItem != null)
            {
                string selectedText = cmbSelectAnimal.SelectedItem.ToString();
                int colonIndex = selectedText.IndexOf(':');

                if (colonIndex > 0 && int.TryParse(selectedText.Substring(0, colonIndex), out int animalId))
                {
                    AnimalID = animalId;
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSelectAnimal.SelectedItem != null)
                {
                    string selectedText = cmbSelectAnimal.SelectedItem.ToString();
                    int colonIndex = selectedText.IndexOf(':');

                    if (colonIndex > 0 && int.TryParse(selectedText.Substring(0, colonIndex), out int animalId))
                    {
                        string query = $"SELECT * FROM Animal WHERE AnimalID = '{animalId}'";
                        DataTable dt = DataAccess.GetData(query);
                        txtboxID.Text = dt.Rows[0]["AnimalID"].ToString();
                        txtboxName.Text = dt.Rows[0]["Name"].ToString();
                        txtboxSpecies.Text = dt.Rows[0]["Species"].ToString();
                        txtboxSN.Text = dt.Rows[0]["ScientificName"].ToString();
                        txtboxGender.Text = dt.Rows[0]["Gender"].ToString();
                        txtboxAge.Text = dt.Rows[0]["Age"].ToString();
                        txtboxDate.Text = dt.Rows[0]["ArrivalDate"].ToString();
                        txtboxStatus.Text = dt.Rows[0]["Status"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an Animal");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading animal data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxReportDate.Text) ||
            string.IsNullOrWhiteSpace(textBoxTemp.Text) ||
            cmbAppearance.SelectedIndex == -1 ||
            cmbAppetite.SelectedIndex == -1 ||
            cmbHydration.SelectedIndex == -1 ||
            cmbEyes.SelectedIndex == -1 ||
            cmbBreathing.SelectedIndex == -1 ||
            cmbUrination.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime reportDate = DateTime.Parse(txtboxReportDate.Text);
            float temperature = float.Parse(textBoxTemp.Text);
            string appearance = cmbAppearance.SelectedItem.ToString();
            string appetite = cmbAppetite.SelectedItem.ToString();
            string hydration = cmbHydration.SelectedItem.ToString();
            string eyes = cmbEyes.SelectedItem.ToString();
            string breathing = cmbBreathing.SelectedItem.ToString();
            string urination = cmbUrination.SelectedItem.ToString();

            bool needsAttention =
                appearance.ToLower().Contains("injured") ||
                temperature > 39.5 ||
                appetite.ToLower().Contains("low") ||
                hydration.ToLower().Contains("dehydrated") ||
                eyes.ToLower().Contains("swollen") ||
                breathing.ToLower().Contains("labored") ||
                urination.ToLower().Contains("bloody");

            if (needsAttention)
            {
                MessageBox.Show("Warning: This animal may need medical attention!", "Health Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            int animalId = AnimalID;
            int employeeID = this.employeeID;
            string staffName;
            var user = DataAccess.GetData($"SELECT * FROM [User] WHERE UserID = {employeeID}");
            if (user != null)
            {
                if (user.Rows.Count > 0)
                {
                    staffName = user.Rows[0]["FullName"].ToString();
                }
                else
                {
                    staffName = "Unknown Staff";
                }
            }
            else
            {
                staffName = "Unknown Staff";
            }




            string query = $@"
            INSERT INTO StatusReport (
                AnimalID, StaffName, EmployeeID, ReportDate,
                GeneralAppearance, Temperature, Appetite,
                HydrationStatus, Eyes, Breathing, Urination
            )
            VALUES (
                {animalId}, '{staffName.Replace("'", "''")}', {employeeID}, '{reportDate:yyyy-MM-dd}',
                '{appearance.Replace("'", "''")}', {temperature}, '{appetite.Replace("'", "''")}',
                '{hydration.Replace("'", "''")}', '{eyes.Replace("'", "''")}', '{breathing.Replace("'", "''")}', '{urination.Replace("'", "''")}'
            )";

            try
            {
                DataAccess.Execute(query);
                MessageBox.Show("Report submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to submit report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            string staffName;
            var user = DataAccess.GetData($"SELECT * FROM [User] WHERE UserID = {employeeID}");
            if (user != null)
            {
                if (user.Rows.Count > 0)
                {
                    staffName = user.Rows[0]["FullName"].ToString();
                }
                else
                {
                    staffName = "Unknown Staff";
                }
            }
            else
            {
                staffName = "Unknown Staff";
            }

            labelStaffName.Text = $"Staff Name: {staffName}";
        
        }
    }
}