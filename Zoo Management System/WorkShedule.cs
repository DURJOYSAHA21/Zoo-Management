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
    public partial class WorkShedule : Form
    {
        public WorkShedule()
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
                var query = $"SELECT WS.ScheduleID, WS.WorkDate,WS.EmployeeID,WS.Status,Emp.FullName AS EmployeeName, WS.Task, A.AnimalID, A.Name AS AnimalName, A.Species, Updater.FullName AS UpdatedByName FROM WorkSchedule WS JOIN [User] Emp ON WS.EmployeeID = Emp.UserID JOIN Animal A ON WS.AnimalID = A.AnimalID JOIN [User] Updater ON WS.UpdatedBy = Updater.UserID ORDER BY WS.WorkDate DESC;";
                ;
                var dt = DataAccess.GetData(query);
                if (dt == null)
                {
                    return;
                }


                dgvWorkSchedule.AutoGenerateColumns = false;
                dgvWorkSchedule.DataSource = dt;
                dgvWorkSchedule.Refresh();
                dgvWorkSchedule.ClearSelection();

                var employeeQuery = "SELECT UserID, FullName FROM [User] WHERE RoleID = 2";
                var employeeDt = DataAccess.GetData(employeeQuery);
                if (employeeDt != null)
                {
                    cmbEmployee.DataSource = employeeDt;
                    cmbEmployee.DisplayMember = "FullName";
                    cmbEmployee.ValueMember = "UserID";
                }
                else
                {
                    return;
                }

                var animalQuery = "SELECT AnimalID, Name FROM Animal";
                var animalDt = DataAccess.GetData(animalQuery);
                if (animalDt != null)
                {
                    cmbAssignAnimal.DataSource = animalDt;
                    cmbAssignAnimal.DisplayMember = "Name";
                    cmbAssignAnimal.ValueMember = "AnimalID";
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnWorkSchedule_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvWorkSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgvWorkSchedule.Rows[e.RowIndex];

                    int scheduleID = Convert.ToInt32(selectedRow.Cells["ScheduleID"].Value);
                    txtScheduleID.Text = scheduleID.ToString();

                    string workDate = selectedRow.Cells["WorkDate"].Value.ToString();
                    dtpWorkDate.Value = Convert.ToDateTime(workDate);

                    int employeeID = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);
                    string employee = selectedRow.Cells["EmployeeName"].Value.ToString();
                    cmbEmployee.Text = employee;
                    cmbEmployee.SelectedValue = employeeID;



                    int animalID = Convert.ToInt32(selectedRow.Cells["AnimalID"].Value);
                    string animalName = selectedRow.Cells["AnimalName"].Value.ToString();
                    cmbAssignAnimal.Text = animalName;
                    cmbAssignAnimal.SelectedValue = animalID;

                    string species = selectedRow.Cells["Species"].Value.ToString();

                    string updatedByName = selectedRow.Cells["UpdatedByName"].Value.ToString();


                    txtTask.Text = selectedRow.Cells["Task"].Value.ToString();
                    cmbStatus.SelectedItem = selectedRow.Cells["Status"].Value.ToString();






                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void newData()
        {
            txtScheduleID.Clear();
            dtpWorkDate.Value = DateTime.Now.Date;
            cmbEmployee.SelectedIndex = -1;
            txtTask.Clear();
            cmbAssignAnimal.SelectedIndex = -1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtScheduleID.Text))
            {
                MessageBox.Show("Please select a schedule to delete.");
                return;
            }
            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                int scheduleID = Convert.ToInt32(txtScheduleID.Text);
                string query = $"DELETE FROM WorkSchedule WHERE ScheduleID = {scheduleID}";


                if (DataAccess.Execute(query) == false)
                {
                    MessageBox.Show("Failed to delete schedule. Please try again.");
                    return;
                }
                MessageBox.Show("Schedule deleted successfully.");
                loadData();
                newData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting schedule: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtScheduleID.Text;
            if (id == string.Empty)
            {

                try
                {
                   

                    int employeeID = Convert.ToInt32(cmbEmployee.SelectedValue);
                    int animalID = Convert.ToInt32(cmbAssignAnimal.SelectedValue);
                    string task = txtTask.Text;
                    DateTime workDate = dtpWorkDate.Value.Date;
                    if (cmbEmployee.SelectedItem == null)
                    {
                        MessageBox.Show("Please select an employee.");
                        return;
                    }
                    string status =cmbStatus.SelectedItem.ToString();




                    if (employeeID <= 0 || animalID <= 0 || string.IsNullOrEmpty(task))
                    {
                        MessageBox.Show("Please fill all fields.");
                        return;
                    }
                    string query = $"INSERT INTO WorkSchedule (WorkDate, EmployeeID, AnimalID, Task, UpdatedBy,Status) VALUES ('{workDate}', {employeeID}, {animalID}, '{task}', {UserID},'{status}')";
                    if (DataAccess.Execute(query) == false)
                    {
                        MessageBox.Show("Failed to save schedule. Please try again.");
                        return;
                    }
                    MessageBox.Show("Schedule saved successfully.");
                    loadData();
                    newData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving schedule: " + ex.Message);
                }

            }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(txtScheduleID.Text))
                    {
                        MessageBox.Show("Please select a schedule to update.");
                        return;
                    }

                    int scheduleID = Convert.ToInt32(txtScheduleID.Text);
                    if (cmbEmployee.SelectedValue == null)
                    {
                        MessageBox.Show("Please select an employee.");
                        return;
                    }
                    int employeeID = Convert.ToInt32(cmbEmployee.SelectedValue);
                    if (cmbAssignAnimal.SelectedValue == null)
                    {
                        MessageBox.Show("Please select an animal.");
                        return;
                    }
                    int animalID = Convert.ToInt32(cmbAssignAnimal.SelectedValue);
                    if (string.IsNullOrEmpty(txtTask.Text))
                    {
                        MessageBox.Show("Please enter a task.");
                        return;
                    }
                    string task = txtTask.Text;
                    if (dtpWorkDate.Value == null)
                    {
                        MessageBox.Show("Please select a work date.");
                        return;
                    }
                    string status = cmbStatus.SelectedItem.ToString();
                    if(string.IsNullOrEmpty(status))
                    {
                        MessageBox.Show("Please select a status.");
                        return;
                    }
                    DateTime workDate = dtpWorkDate.Value.Date;
                    if (employeeID <= 0 || animalID <= 0 || string.IsNullOrEmpty(task))
                    {
                        MessageBox.Show("Please fill all fields.");
                        return;
                    }
                    string query = $"UPDATE WorkSchedule SET WorkDate = '{workDate}', EmployeeID = {employeeID}, AnimalID = {animalID}, Task = '{task}', UpdatedBy = {UserID},Status ='{status}' WHERE ScheduleID = {scheduleID}";
                    MessageBox.Show(query);

                    if (DataAccess.Execute(query) == false)
                    {
                        MessageBox.Show("Failed to update schedule. Please try again.");
                        return;
                    }
                    MessageBox.Show("Schedule updated successfully.");
                    loadData();
                    newData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating schedule: " + ex.Message);
                }

            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvWorkSchedule.ClearSelection();
            newData();
            loadData();
        }

        private void btnMedicalRecord_Click(object sender, EventArgs e)
        {
            MedicalRecordAdmin medicalRecordAdmin = new MedicalRecordAdmin();
            medicalRecordAdmin.SetUserID(UserID);
            medicalRecordAdmin.Show();
            this.Hide();

        }

        private void WorkShedule_Load(object sender, EventArgs e)
        {
            txtScheduleID.ReadOnly = true;
            loadData();
            dgvWorkSchedule.ClearSelection();

        }

        private void dgvWorkSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            if (con == "Schedule ID")
            {
                var query = $"SELECT WS.ScheduleID, WS.WorkDate,WS.EmployeeID,WS.Status,Emp.FullName AS EmployeeName, WS.Task, A.AnimalID, A.Name AS AnimalName, A.Species, Updater.FullName AS UpdatedByName FROM WorkSchedule WS JOIN [User] Emp ON WS.EmployeeID = Emp.UserID JOIN Animal A ON WS.AnimalID = A.AnimalID JOIN [User] Updater ON WS.UpdatedBy = Updater.UserID WHERE WS.ScheduleID LIKE '%{searchText}%' ORDER BY WS.WorkDate DESC;";
                var dt = DataAccess.GetData(query);
                if (dt != null)
                {
                    dgvWorkSchedule.DataSource = dt;
                    dgvWorkSchedule.Refresh();
                    dgvWorkSchedule.ClearSelection();
                }
                else
                {

                }
            }

            else if (con == "Animal Name")
            {
                var query = $"SELECT WS.ScheduleID, WS.WorkDate,WS.EmployeeID,WS.Status,Emp.FullName AS EmployeeName, WS.Task, A.AnimalID, A.Name AS AnimalName, A.Species, Updater.FullName AS UpdatedByName FROM WorkSchedule WS JOIN [User] Emp ON WS.EmployeeID = Emp.UserID JOIN Animal A ON WS.AnimalID = A.AnimalID JOIN [User] Updater ON WS.UpdatedBy = Updater.UserID WHERE A.Name LIKE '%{searchText}%' ORDER BY WS.WorkDate DESC;";
                var dt = DataAccess.GetData(query);
                if (dt != null)
                {
                    dgvWorkSchedule.DataSource = dt;
                    dgvWorkSchedule.Refresh();
                    dgvWorkSchedule.ClearSelection();
                }
                else
                {

                }
            }
            else if (con == "Employee Name")
            {
                var query = $"SELECT WS.ScheduleID, WS.WorkDate,WS.EmployeeID,WS.Status,Emp.FullName AS EmployeeName, WS.Task, A.AnimalID, A.Name AS AnimalName, A.Species, Updater.FullName AS UpdatedByName FROM WorkSchedule WS JOIN [User] Emp ON WS.EmployeeID = Emp.UserID JOIN Animal A ON WS.AnimalID = A.AnimalID JOIN [User] Updater ON WS.UpdatedBy = Updater.UserID WHERE Emp.FullName LIKE '%{searchText}%' ORDER BY WS.WorkDate DESC;";
                var dt = DataAccess.GetData(query);
                if (dt != null)
                {
                    dgvWorkSchedule.DataSource = dt;
                    dgvWorkSchedule.Refresh();
                    dgvWorkSchedule.ClearSelection();
                }
                else
                {

                }

            }
            else if (con == "Employee Name")
            {
                var query = $"SELECT WS.ScheduleID, WS.WorkDate,WS.EmployeeID,Emp.FullName AS EmployeeName, WS.Task, A.AnimalID, A.Name AS AnimalName, A.Species, Updater.FullName AS UpdatedByName FROM WorkSchedule WS JOIN [User] Emp ON WS.EmployeeID = Emp.UserID JOIN Animal A ON WS.AnimalID = A.AnimalID JOIN [User] Updater ON WS.UpdatedBy = Updater.UserID WHERE Emp.FullName LIKE '%{searchText}%' ORDER BY WS.WorkDate DESC;";
                var dt = DataAccess.GetData(query);
                if (dt != null)
                {
                    dgvWorkSchedule.DataSource = dt;
                    dgvWorkSchedule.Refresh();
                    dgvWorkSchedule.ClearSelection();
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Please select a valid search criteria.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.SetUserId(UserID);
            adminHome.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkShedule workShedule = new WorkShedule();
            workShedule.SetUserID(UserID);
            workShedule.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicalRecordAdmin adminAdmin = new MedicalRecordAdmin();
            adminAdmin.SetUserID(UserID);
            adminAdmin.Show();
            this.Hide();

        }

        private void btnCheckupDetails_Click(object sender, EventArgs e)
        {
            CheckupAdmin adminCheckup = new CheckupAdmin();
            adminCheckup.SetUserID(UserID);
            adminCheckup.Show();
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
            adminEventOperation eventAdmin = new adminEventOperation(UserID);
           
            eventAdmin.Show();
           

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
            EmployeeAdmin staffCrud = new EmployeeAdmin();
            staffCrud.SetUserID(UserID);
            staffCrud.Show();
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
            AnimalHomeScreen animalHomeScreen = new AnimalHomeScreen();
            animalHomeScreen.SetUserID(UserID);
            animalHomeScreen.Show();


        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.SetUserId(UserID);
            adminHome.Show();
            this.Hide();
        }
    }
}
