using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class CheckUpDetails : Form
    {
        public CheckUpDetails()
        {
            InitializeComponent();
        }

        int UserID;
        int AnimalID;
        public void SetUserID(int UserID)
        {
            this.UserID = UserID;
        }
        public void SetAnimalID(int AnimalID)
        {
            this.AnimalID = AnimalID;
        }

        private void CheckUpDetails_Load(object sender, EventArgs e)
        {

            loadData();



        }

        private void btnYourCheckups_Click(object sender, EventArgs e)
        {
            try
            {
                var query = $"SELECT C.CheckupID, C.AnimalID,A.Name AS [Animal Name], A.Species AS [Species], U.FullName AS [Doctor Name], C.CheckupDate AS [Checkup Date], C.HealthCondition AS [Health Condition], C.Weight AS [Weight], C.Temperature AS [Temperature], C.HeartRate AS [Heart Rate], C.Notes AS [Notes] FROM Checkup C JOIN Animal A ON C.AnimalID = A.AnimalID JOIN [User] U ON C.DoctorID = U.UserID WHERE C.DoctorID ={UserID} ORDER BY C.CheckupDate DESC;";
                var dt = DataAccess.GetData(query);
                if (dt == null)
                {
                    return;
                }
                

                dgvCheckupDetails.AutoGenerateColumns = false;
                dgvCheckupDetails.DataSource = dt;
               
                dgvCheckupDetails.Refresh();
                dgvCheckupDetails.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading check-up details: " + ex.Message);
                return;
            }

        }

        private void btnAllCheckup_Click(object sender, EventArgs e)
        {

            this.loadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.SetUserID(UserID);
            doctorForm.Show();
            this.Hide();
        }

        private void loadData()
        {
            try
            {
                var query = $"SELECT C.CheckupID,C.AnimalID, A.Name AS [Animal Name], A.Species AS [Species], U.FullName AS [Doctor Name], C.CheckupDate AS [Checkup Date], C.HealthCondition AS [Health Condition], C.Weight AS [Weight], C.Temperature AS [Temperature], C.HeartRate AS [Heart Rate], C.Notes AS [Notes] FROM Checkup C JOIN Animal A ON C.AnimalID = A.AnimalID JOIN [User] U ON C.DoctorID = U.UserID ORDER BY C.CheckupDate DESC;";
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

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading check-up details: " + ex.Message);
            }

        }

        private void dgvCheckupDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            btnAllCheckup.PerformClick();
            this.loadData();
            this.NewData();

        }

        private void dgvCheckupDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgvCheckupDetails.Rows[e.RowIndex];


                    int checkupID = Convert.ToInt32(selectedRow.Cells["CheckupID"].Value);

                    

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

                    int animalID = Convert.ToInt32(selectedRow.Cells["AnimalIDs"].Value);
                    string animalName = selectedRow.Cells["AnimalName"].Value.ToString();

                    cmbAnimal.SelectedText = animalName;
                    cmbAnimal.SelectedValue = animalID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting check-up record: " + ex.Message);
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewData();
            loadData();


        }

        private void NewData()
        {
            dtpCheckupDate.Value = DateTime.Now;
            cmbHealthCondition.SelectedIndex = -1; 
            txtWeight.Clear();
            txtTemperature.Clear();
            txtHeartRate.Clear();
            txtNotes.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          

            if (dgvCheckupDetails.SelectedRows.Count > 0 )
            {
                var result = MessageBox.Show("Are you sure you want to delete this check-up record?", "Confirm Delete", MessageBoxButtons.YesNo );
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dgvCheckupDetails.SelectedRows[0];
                    int checkupID = Convert.ToInt32(selectedRow.Cells["CheckupID"].Value);
                    int doctorID = Convert.ToInt32(selectedRow.Cells["DoctorID"].Value);
                   

                    string deleteMedicalQuery = $"DELETE FROM MedicalRecord WHERE CheckupID = {checkupID} AND DoctorID = {UserID}";
                    DataAccess.Execute(deleteMedicalQuery);

                   
                    string deleteCheckupQuery = $"DELETE FROM Checkup WHERE CheckupID = {checkupID} AND DoctorID = {UserID}";
                    var res=DataAccess.Execute(deleteCheckupQuery);

                    if (res==true)
                    {
                        //MessageBox.Show("Check-up record deleted successfully.");//not dlt but shows why
                        this.loadData();
                        this.NewData();
                    }
                    else
                    {
                        MessageBox.Show("Select Your check-up record.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a check-up record to delete.");
            }
        }

        private void btnChooseAnimal_Click(object sender, EventArgs e)
        {
            


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            int? id = null;
            if (dgvCheckupDetails.SelectedRows.Count > 0 && dgvCheckupDetails.SelectedRows[0].Cells["CheckupID"].Value != null)
            {
                id = Convert.ToInt32(dgvCheckupDetails.SelectedRows[0].Cells["CheckupID"].Value);
            }

            if (id == null)
            {
                try
                {
                    
                    int doctorID = UserID;
                    DateTime checkupDate = dtpCheckupDate.Value;
                    if(checkupDate < DateTime.Now.Date)
                    {
                        MessageBox.Show("Check-up date cannot be in the past.");
                        return;
                    }

                    string healthCondition = cmbHealthCondition.SelectedItem.ToString();

                    string weight = txtWeight.Text;
                    string temperature = txtTemperature.Text;
                    string heartRate = txtHeartRate.Text;
                    string notes = txtNotes.Text;
                    if (cmbAnimal.SelectedItem == null || cmbHealthCondition ==null)
                    {
                        MessageBox.Show("Please select an animal.");
                        return;
                    }
                    int animalID = Convert.ToInt32(cmbAnimal.SelectedValue);
                    if (string.IsNullOrEmpty(healthCondition) || string.IsNullOrEmpty(weight) || string.IsNullOrEmpty(temperature) || string.IsNullOrEmpty(heartRate))
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }
                    string insertQuery = $"INSERT INTO Checkup (AnimalID, DoctorID, CheckupDate, HealthCondition, Weight, Temperature, HeartRate, Notes) VALUES ({animalID}, {doctorID}, '{checkupDate}', '{healthCondition}', '{weight}', '{temperature}', '{heartRate}', '{notes}')";
                    DataAccess.Execute(insertQuery);
                    MessageBox.Show("Check-up record saved successfully.");
                    this.loadData();
                    this.NewData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving check-up record: " + ex.Message);
                }
            }
            else if (id != null)
            {
                try
                {

                    int checkupID = Convert.ToInt32(dgvCheckupDetails.SelectedRows[0].Cells["CheckupID"].Value);
                    int animalID = Convert.ToInt32(cmbAnimal.SelectedValue);
                    int doctorID = UserID;
                    DateTime checkupDate = dtpCheckupDate.Value;
                    string healthCondition = cmbHealthCondition.SelectedItem.ToString();
                    string weight = txtWeight.Text;
                    string temperature = txtTemperature.Text;
                    string heartRate = txtHeartRate.Text;
                    string notes = txtNotes.Text;
                    string updateQuery = $"UPDATE Checkup SET AnimalID = {animalID}, DoctorID = {doctorID}, CheckupDate = '{checkupDate}', HealthCondition = '{healthCondition}', Weight = '{weight}', Temperature = '{temperature}', HeartRate = '{heartRate}', Notes = '{notes}' WHERE CheckupID = {checkupID}";
                    DataAccess.Execute(updateQuery);
                    MessageBox.Show(animalID.ToString());
                    //MessageBox.Show("Check-up record updated successfully.");
                    this.loadData();
                    this.NewData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating check-up record: " + ex.Message);
                }
            }
            else
            {
                return;


            }
        }

        private void CheckUpDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
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
                string query = $"SELECT C.CheckupID, C.AnimalID, A.Name AS [Animal Name], A.Species AS [Species], U.FullName AS [Doctor Name], C.CheckupDate AS [Checkup Date], C.HealthCondition AS [Health Condition], C.Weight AS [Weight], C.Temperature AS [Temperature], C.HeartRate AS [Heart Rate], C.Notes AS [Notes] FROM Checkup C JOIN Animal A ON C.AnimalID = A.AnimalID JOIN [User] U ON C.DoctorID = U.UserID WHERE CAST(C.CheckupID AS VARCHAR) LIKE '{searchText}%' ORDER BY C.CheckupDate DESC;";
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
                string query = $"SELECT C.CheckupID, C.AnimalID, A.Name AS [Animal Name], A.Species AS [Species], U.FullName AS [Doctor Name], C.CheckupDate AS [Checkup Date], C.HealthCondition AS [Health Condition], C.Weight AS [Weight], C.Temperature AS [Temperature], C.HeartRate AS [Heart Rate], C.Notes AS [Notes] FROM Checkup C JOIN Animal A ON C.AnimalID = A.AnimalID JOIN [User] U ON C.DoctorID = U.UserID WHERE A.Name LIKE '%{searchText}%' ORDER BY C.CheckupDate DESC;";
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
            else if(con == "Doctor Name")
            {
                string query = $"SELECT C.CheckupID, C.AnimalID, A.Name AS [Animal Name], A.Species AS [Species], U.FullName AS [Doctor Name], C.CheckupDate AS [Checkup Date], C.HealthCondition AS [Health Condition], C.Weight AS [Weight], C.Temperature AS [Temperature], C.HeartRate AS [Heart Rate], C.Notes AS [Notes] FROM Checkup C JOIN Animal A ON C.AnimalID = A.AnimalID JOIN [User] U ON C.DoctorID = U.UserID WHERE U.FullName LIKE '%{searchText}%' ORDER BY C.CheckupDate DESC;";
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
