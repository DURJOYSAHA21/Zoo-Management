using System;
using System.Data;
using System.Windows.Forms;

namespace ZooManagementSystem

{
    public partial class AdminAnimalOperation : Form
    {
        int UserID;
        public AdminAnimalOperation()
        {
            InitializeComponent();
            dtpArrivaldate.Value = DateTime.Today; // Initialize with today's date
        }
        public void SetUserID(int UserID)
        {
            this.UserID = UserID;
        }

        private void AdminAnimalOperation_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }

        private void LoadData()
        {
            try
            {
                var query = "SELECT * FROM Animal";
                var dt = DataAccess.GetData(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No animals found in database.", "Information",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvAnimal.AutoGenerateColumns = false;
                dgvAnimal.DataSource = dt;
                dgvAnimal.Refresh();
                dgvAnimal.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAnimal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAnimal.Rows.Count)
            {
                var row = dgvAnimal.Rows[e.RowIndex];
                txtID.Text = row.Cells["AnimalID"].Value?.ToString() ?? "";
                txtName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                txtSpecies.Text = row.Cells["Species"].Value?.ToString() ?? "";
                txtSciName.Text = row.Cells["ScientificName"].Value?.ToString() ?? "";
                txtSex.Text = row.Cells["Gender"].Value?.ToString() ?? "";
                txtAge.Text = row.Cells["Age"].Value?.ToString() ?? "";
                txtHealthStatus.Text = row.Cells["Status"].Value?.ToString() ?? "";

                if (DateTime.TryParse(row.Cells["ArrivalDate"].Value?.ToString(), out DateTime arrivalDate))
                {
                    dtpArrivaldate.Value = arrivalDate;
                }

                txtImage.Text = row.Cells["ProfileImage"].Value?.ToString() ?? "";
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            dgvAnimal.ClearSelection();
            txtID.Text = "";
            txtName.Text = "";
            txtSpecies.Text = "";
            txtSciName.Text = "";
            txtSex.Text = "";
            txtAge.Text = "";
            txtHealthStatus.Text = "";
            dtpArrivaldate.Value = DateTime.Today;
            txtImage.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please select an animal to delete!", "Warning",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to remove this animal?", "Confirmation",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string id = txtID.Text;
                    string query = $"DELETE FROM Animal WHERE AnimalID = {id}";

                    if (DataAccess.Execute(query))
                    {
                        MessageBox.Show("Animal successfully removed!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete animal.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting animal: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Name is required!", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtAge.Text, out int age))
                {
                    MessageBox.Show("Age must be a valid number!", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get values from controls
                string id = txtID.Text;
                string name = EscapeSql(txtName.Text.Trim());
                string species = EscapeSql(txtSpecies.Text.Trim());
                string sciName = EscapeSql(txtSciName.Text.Trim());
                string gender = EscapeSql(txtSex.Text.Trim());
                string status = EscapeSql(txtHealthStatus.Text.Trim());
                string image = EscapeSql(txtImage.Text.Trim());
                string formattedDate = dtpArrivaldate.Value.ToString("yyyy-MM-dd");

                string query;
                bool isInsert = string.IsNullOrEmpty(id);

                if (isInsert)
                {
                    query = $@"INSERT INTO Animal 
                             (Name, Species, ScientificName, Gender, Age, Status, ArrivalDate, ProfileImage) 
                             VALUES 
                             ('{name}', '{species}', '{sciName}', '{gender}', {age}, '{status}', '{formattedDate}', '{image}')";
                }
                else
                {
                    query = $@"UPDATE Animal SET
                             Name = '{name}',
                             Species = '{species}',
                             ScientificName = '{sciName}',
                             Gender = '{gender}',
                             Age = {age},
                             Status = '{status}',
                             ArrivalDate = '{formattedDate}',
                             ProfileImage = '{image}'
                             WHERE AnimalID = {id}";
                }

                if (DataAccess.Execute(query))
                {
                    MessageBox.Show("Operation completed successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Database operation failed!", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string EscapeSql(string value)
        {
            return string.IsNullOrEmpty(value) ? "" : value.Replace("'", "''");
        }

        private void btnWorkSchedule_Click(object sender, EventArgs e)
        {
            WorkShedule workShedule = new WorkShedule();
            workShedule.SetUserID(UserID);
            workShedule.Show();
            this.Hide();


        }

        private void btnMedicalRecord_Click(object sender, EventArgs e)
        {
            MedicalRecordAdmin medicalRecordAdmin = new MedicalRecordAdmin();
            medicalRecordAdmin.SetUserID(UserID);
            medicalRecordAdmin.Show();
            this.Hide();
        }

        private void btnCheckupDetails_Click(object sender, EventArgs e)
        {
            CheckupAdmin checkupAdmin = new CheckupAdmin();
            checkupAdmin.SetUserID(UserID);
            checkupAdmin.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.SetUserId(UserID);
            adminHome.Show();
            this.Hide();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            adminEventOperation adminEventOperation = new adminEventOperation(UserID);
            adminEventOperation.Show();


        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            BankCrud bankCrud = new BankCrud();
            bankCrud.SetUserID(UserID);
            bankCrud.Show();

        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            VisitorAdmin visitorAdmin = new VisitorAdmin();
            visitorAdmin.SetUserId(UserID);
            visitorAdmin.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            EmployeeAdmin employeeAdmin = new EmployeeAdmin();
            employeeAdmin.SetUserID(UserID);
            employeeAdmin.Show();
            this.Hide();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm();
            chatForm.SetUserID(UserID);
            chatForm.Show();
        }

        private void btnViewAnimal_Click(object sender, EventArgs e)
        {
            AdminAnimalOperation adminAnimalOperation = new AdminAnimalOperation();
            adminAnimalOperation.SetUserID(UserID);
            adminAnimalOperation.Show();
            this.Hide();
        }
    }
}