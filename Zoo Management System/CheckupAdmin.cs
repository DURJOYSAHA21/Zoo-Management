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
    public partial class CheckupAdmin : Form
    {
        public CheckupAdmin()
        {
            InitializeComponent();
        }

        int UserID;
       
        public void SetUserID(int UserID)
        {
            this.UserID = UserID;
        }

        private void loadData()
        {
            try
            {
                var query = $"SELECT C.CheckupID,C.AnimalID,C.DoctorID, A.Name AS [Animal Name], A.Species AS [Species], U.FullName AS  [DoctorNames], C.CheckupDate AS [Checkup Date], C.HealthCondition AS [Health Condition], C.Weight AS [Weight], C.Temperature AS [Temperature], C.HeartRate AS [Heart Rate], C.Notes AS [Notes] FROM Checkup C JOIN Animal A ON C.AnimalID = A.AnimalID JOIN [User] U ON C.DoctorID = U.UserID ORDER BY C.CheckupDate DESC;";
                var dt = DataAccess.GetData(query);
                if (dt == null)
                {
                    return;
                }


                dgvCheckupDetails.AutoGenerateColumns = false;
                dgvCheckupDetails.DataSource = dt;

                dgvCheckupDetails.Refresh();
                dgvCheckupDetails.ClearSelection();

                var animalQuery = "SELECT AnimalID, Name FROM Animal";
                var animalDt = DataAccess.GetData(animalQuery);
                if (animalDt != null)
                {
                    cmbAnimal.DataSource = animalDt;
                    cmbAnimal.DisplayMember = "Name";
                    cmbAnimal.ValueMember = "AnimalID";
                }
                else
                {
                    return;
                }
                var doctorQuery = "SELECT U.UserID, U.FullName, E.EmployeeType FROM [User] U JOIN EmployeeDetails E ON U.UserID = E.EmployeeID WHERE U.RoleID = 2 AND E.EmployeeType = 'Doctor';";
                var doctorDt = DataAccess.GetData(doctorQuery);
                if (doctorDt != null)
                {
                    cmbDoctorName.DataSource = doctorDt;
                    cmbDoctorName.DisplayMember = "FullName";
                    cmbDoctorName.ValueMember = "UserID";
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading check-up details: " + ex.Message);
                return;
            }
            


        }

        private void CheckupAdmin_Load(object sender, EventArgs e)
        {
            loadData();
            txtCheckupID.ReadOnly=true;

        }

        private void dgvCheckupDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
                DataGridViewRow selectedRow = dgvCheckupDetails.Rows[e.RowIndex];


                int checkupID = Convert.ToInt32(selectedRow.Cells["CheckupID"].Value);
                if (checkupID > 0)
                {
                    txtCheckupID.Text = checkupID.ToString();
                }
                else
                {
                    txtCheckupID.Clear();
                }



                DateTime checkupDate = Convert.ToDateTime(selectedRow.Cells["CheckupDate"].Value);
                dtpCheckupDate.Value = checkupDate;

                string healthCondition = selectedRow.Cells["HealthCondition"].Value.ToString();
                cmbHealthCondition.SelectedItem = healthCondition;


                string weight = selectedRow.Cells["Weight"].Value.ToString();
                txtWeight.Text = weight;

                string temperature = selectedRow.Cells["Temperature"].Value.ToString();
                txtTemperature.Text = temperature;

                string heartRate = selectedRow.Cells["HeartRate"].Value.ToString();
                txtHeartRate.Text = heartRate;

                string notes = selectedRow.Cells["Notes"].Value.ToString();
                txtNotes.Text = notes;

                int animalID = Convert.ToInt32(selectedRow.Cells["AnimalID"].Value);
                string animalName = selectedRow.Cells["AnimalName"].Value.ToString();

                cmbAnimal.SelectedItem = animalName;
                cmbAnimal.SelectedValue = animalID;

                int doctorID = Convert.ToInt32(selectedRow.Cells["DoctorID"].Value);
                string doctorName = selectedRow.Cells["DoctorNames"].Value.ToString();
                cmbDoctorName.SelectedItem = doctorName;
                cmbDoctorName.SelectedValue = doctorID;
            }

        }
        
        private void newData()
        {
            txtCheckupID.Clear();
            dtpCheckupDate.Value = DateTime.Now;
            cmbHealthCondition.SelectedIndex =-1;
            txtWeight.Clear();
            txtTemperature.Clear();
            txtHeartRate.Clear();
            txtNotes.Clear();
            cmbAnimal.SelectedIndex = -1;
            cmbDoctorName.SelectedIndex = -1;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            newData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCheckupID.Text))
                {

                    int animalID = Convert.ToInt32(cmbAnimal.SelectedValue);
                    int doctorID = Convert.ToInt32(cmbDoctorName.SelectedValue);

                    DateTime checkupDate = dtpCheckupDate.Value.Date;
                    if (checkupDate < DateTime.Now.Date)
                    {
                        MessageBox.Show("Check-up date cannot be in the Past.");
                        return;
                    }

                    string healthCondition = cmbHealthCondition.SelectedItem.ToString();
                    string weight = txtWeight.Text;
                    string temperature = txtTemperature.Text;
                    string heartRate = txtHeartRate.Text;
                    string notes = txtNotes.Text;
                    if (string.IsNullOrEmpty(healthCondition) || string.IsNullOrEmpty(weight) || string.IsNullOrEmpty(temperature) || string.IsNullOrEmpty(heartRate))
                    {
                        MessageBox.Show("Please fill in all required fields.");
                        return;
                    }
                    
                   
                    
                    string query = $"INSERT INTO Checkup (AnimalID, DoctorID, CheckupDate, HealthCondition, Weight, Temperature, HeartRate, Notes) VALUES ({animalID}, {doctorID}, '{checkupDate}', '{healthCondition}', '{weight}', '{temperature}', '{heartRate}', '{notes}')";
                    
                    
                    DataAccess.Execute(query);
                    MessageBox.Show("Check-up details saved successfully.");
                    loadData();
                }
                else
                {
                    int checkupID = Convert.ToInt32(dgvCheckupDetails.SelectedRows[0].Cells["CheckupID"].Value);
                    int animalID = Convert.ToInt32(cmbAnimal.SelectedValue);
                    int doctorID = Convert.ToInt32(cmbDoctorName.SelectedValue);
                    DateTime checkupDate = dtpCheckupDate.Value;
                    string healthCondition = cmbHealthCondition.SelectedItem.ToString();
                    string weight = txtWeight.Text;
                    string temperature = txtTemperature.Text;
                    string heartRate = txtHeartRate.Text;
                    string notes = txtNotes.Text;
                    string updateQuery = $"UPDATE Checkup SET AnimalID = {animalID}, DoctorID = {doctorID}, CheckupDate = '{checkupDate}', HealthCondition = '{healthCondition}', Weight = '{weight}', Temperature = '{temperature}', HeartRate = '{heartRate}', Notes = '{notes}' WHERE CheckupID = {checkupID}";
                    DataAccess.Execute(updateQuery);
                    MessageBox.Show(animalID.ToString());
                  
                    this.loadData();
                    this.newData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving check-up details: " + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCheckupID.Text))
                {
                    MessageBox.Show("Please select a check-up record to delete.");
                    return;
                }
                int checkupID = Convert.ToInt32(txtCheckupID.Text);
                string query = $"DELETE FROM Checkup WHERE CheckupID={checkupID}";
                DataAccess.Execute(query);
                MessageBox.Show("Check-up record deleted successfully.");
                loadData();
                newData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting check-up record: " + ex.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            
            AdminHome adminForm = new AdminHome();
            adminForm.SetUserId(UserID);
            adminForm.Show();
            this.Hide();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            newData();
            dgvCheckupDetails.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedItem == null)
            {
                MessageBox.Show("Please select a search criteria.");
                return;
            }

            var con = cmbSearch.SelectedItem.ToString();
            string searchText = txtSearch.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                loadData();
                return;
            }

            if (con == "Checkup ID")
            {
                string query = $"SELECT C.CheckupID, C.AnimalID, A.Name AS [Animal Name], A.Species AS [Species], U.FullName AS [DoctorNames], C.CheckupDate AS [Checkup Date], C.HealthCondition AS [Health Condition], C.Weight AS [Weight], C.Temperature AS [Temperature], C.HeartRate AS [Heart Rate], C.Notes AS [Notes] FROM Checkup C JOIN Animal A ON C.AnimalID = A.AnimalID JOIN [User] U ON C.DoctorID = U.UserID WHERE CAST(C.CheckupID AS VARCHAR) LIKE '{searchText}%' ORDER BY C.CheckupDate DESC;";
                DataTable dt = DataAccess.GetData(query);
                if (dt == null || dt.Rows.Count == 0)
                {
                    dgvCheckupDetails.DataSource = null;
                    return;
                }

                dgvCheckupDetails.DataSource = dt;
                dgvCheckupDetails.Refresh();
                dgvCheckupDetails.ClearSelection();


            }
            else if (con == "Animal Name")
            {
                string query = $"SELECT C.CheckupID, C.AnimalID, A.Name AS [Animal Name], A.Species AS [Species], U.FullName AS [DoctorNames], C.CheckupDate AS [Checkup Date], C.HealthCondition AS [Health Condition], C.Weight AS [Weight], C.Temperature AS [Temperature], C.HeartRate AS [Heart Rate], C.Notes AS [Notes] FROM Checkup C JOIN Animal A ON C.AnimalID = A.AnimalID JOIN [User] U ON C.DoctorID = U.UserID WHERE A.Name LIKE '%{searchText}%' ORDER BY C.CheckupDate DESC;";
                DataTable dt = DataAccess.GetData(query);
                if (dt == null || dt.Rows.Count == 0)
                {
                    dgvCheckupDetails.DataSource = null;
                    return;
                }
                dgvCheckupDetails.DataSource = dt;
                dgvCheckupDetails.Refresh();
                dgvCheckupDetails.ClearSelection();
            }
            else if (con == "Doctor Name")
            {
                string query = $"SELECT C.CheckupID, C.AnimalID, A.Name AS [Animal Name], A.Species AS [Species], U.FullName AS [DoctorNames], C.CheckupDate AS [Checkup Date], C.HealthCondition AS [Health Condition], C.Weight AS [Weight], C.Temperature AS [Temperature], C.HeartRate AS [Heart Rate], C.Notes AS [Notes] FROM Checkup C JOIN Animal A ON C.AnimalID = A.AnimalID JOIN [User] U ON C.DoctorID = U.UserID WHERE U.FullName LIKE '%{searchText}%' ORDER BY C.CheckupDate DESC;";
                DataTable dt = DataAccess.GetData(query);
                if (dt == null || dt.Rows.Count == 0)
                {
                    dgvCheckupDetails.DataSource = null;
                    return;
                }
                dgvCheckupDetails.DataSource = dt;
                dgvCheckupDetails.Refresh();
                dgvCheckupDetails.ClearSelection();
            }

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
            AdminOperation adminOperation = new AdminOperation(UserID);
            adminOperation.Show();
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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCheckupDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
