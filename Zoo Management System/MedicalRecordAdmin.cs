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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace ZooManagementSystem
{
    public partial class MedicalRecordAdmin : Form
    {
        public MedicalRecordAdmin()
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
                var query = $"SELECT MR.RecordID,A.AnimalID, A.Name AS AnimalName, A.Species, D.FullName AS DoctorName,MR.DoctorID, MR.TreatmentDate, MR.Treatment, MR.MedicineGiven, MR.NextVisitDate, MR.Status, MR.Notes FROM MedicalRecord MR JOIN Animal A ON MR.AnimalID = A.AnimalID JOIN[User] D ON MR.DoctorID = D.UserID ORDER BY MR.TreatmentDate DESC;";
                var dt = DataAccess.GetData(query);
                if (dt == null)
                {
                    return;
                }


                dgvMedicalRecord.AutoGenerateColumns = false;
                dgvMedicalRecord.DataSource = dt;

                dgvMedicalRecord.Refresh();
                dgvMedicalRecord.ClearSelection();

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
            }

        }
        private void MedicalRecordAdmin_Load(object sender, EventArgs e)
        {
            loadData();
            txtRecordID.ReadOnly = true;

        }




        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMedicalRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MedicalRecordAdmin_Load_1(object sender, EventArgs e)
        {
            loadData();
        }



        private void dgvMedicalRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicalRecord.Rows[e.RowIndex];


                int recordID = Convert.ToInt32(row.Cells["RecordID"].Value);
                txtRecordID.Text = recordID.ToString();

                int animalID = Convert.ToInt32(row.Cells["AnimalID"].Value);
                string animalName = row.Cells["AnimalName"].Value.ToString();

                cmbAnimal.Text = animalName;
                cmbAnimal.SelectedValue = animalID;



                string species = row.Cells["Species"].Value.ToString();

                int doctorID = Convert.ToInt32(row.Cells["DoctorID"].Value);
                string doctorName = row.Cells["DoctorName"].Value.ToString();
                cmbDoctorName.Text = doctorName;
                cmbDoctorName.SelectedValue = doctorID;


                DateTime treatmentDate = Convert.ToDateTime(row.Cells["TreatmentDate"].Value);
                dtpTreatmentDate.Value = treatmentDate;
                string treatment = row.Cells["Treatment"].Value.ToString();
                txtTreatment.Text = treatment;
                string medicineGiven = row.Cells["MedicineGiven"].Value.ToString();
                txtMedicine.Text = medicineGiven;
                DateTime nextVisitDate = Convert.ToDateTime(row.Cells["NextVisitDate"].Value);
                if (nextVisitDate == null)
                {
                    nextVisitDate = DateTime.Now;
                }
                dtpNextVisit.Value = nextVisitDate;
                string status = row.Cells["Status"].Value.ToString();
                txtStatus.Text = status;
                string notes = row.Cells["Notes"].Value.ToString();
                txtNotes.Text = notes;

            }
        }
        private void newData()
        {
            dgvMedicalRecord.ClearSelection();
            txtRecordID.Text = "";
            cmbAnimal.SelectedIndex = -1;
            cmbDoctorName.SelectedIndex = -1;
            dtpTreatmentDate.Value = DateTime.Now;
            txtTreatment.Text = "";
            txtMedicine.Text = "";
            dtpNextVisit.Value = DateTime.Now;
            txtStatus.Text = "";
            txtNotes.Text = "";



        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtRecordID.Text))
            {
                return;
            }
            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                int recordID = Convert.ToInt32(txtRecordID.Text);
                string query = $"DELETE FROM MedicalRecord WHERE RecordID = {recordID} ";


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

        private void btnNew_Click(object sender, EventArgs e)
        {
            newData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string recordID = txtRecordID.Text; 
            if(string.IsNullOrEmpty(recordID))
            {
                try
                {
                    int animalID = Convert.ToInt32(cmbAnimal.SelectedValue);
                    int doctorID = Convert.ToInt32(cmbDoctorName.SelectedValue);
                    DateTime treatmentDate = dtpTreatmentDate.Value;
                    if (treatmentDate < DateTime.Now.Date)
                    {
                        MessageBox.Show("Treatment date cannot be in the past.");
                        return;
                    }
                    else
                    {
                        treatmentDate = dtpTreatmentDate.Value.Date;
                    }
                    string treatment = txtTreatment.Text;
                    string medicineGiven = txtMedicine.Text;
                    
                    DateTime nextVisitDate = dtpNextVisit.Value;
                    if (nextVisitDate < DateTime.Now.Date)
                    {
                        MessageBox.Show("Next visit date cannot be in the past.");
                        return;
                    }
                    else

                    {
                        nextVisitDate = dtpNextVisit.Value.Date;
                    }

                    string status = txtStatus.Text;
                    string notes = txtNotes.Text;
                    string query = $"INSERT INTO MedicalRecord (AnimalID, TreatmentDate, Treatment, MedicineGiven, NextVisitDate, Notes, Status, DoctorID) VALUES ({animalID}, '{treatmentDate}', '{treatment}', '{medicineGiven}', '{nextVisitDate}', '{notes}', '{status}', {doctorID});";
                    if (DataAccess.Execute(query) == false)
                    {
                        MessageBox.Show("Failed to save record. Please try again.");
                        return;
                    }
                    MessageBox.Show("Record saved successfully.");
                    loadData();
                    newData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving record: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    int recordId = Convert.ToInt32(recordID);
                    int animalID = Convert.ToInt32(cmbAnimal.SelectedValue);
                    int doctorID = Convert.ToInt32(cmbDoctorName.SelectedValue);

                    DateTime treatmentDate = dtpTreatmentDate.Value;
                  
                  
                    string treatment = txtTreatment.Text;
                    string medicineGiven = txtMedicine.Text;
                    DateTime nextVisitDate = dtpNextVisit.Value;
                  
                    string status = txtStatus.Text;
                    string notes = txtNotes.Text;
                    string query = $"UPDATE MedicalRecord SET AnimalID={animalID}, DoctorID={doctorID}, TreatmentDate='{treatmentDate}', Treatment='{treatment}', MedicineGiven='{medicineGiven}', NextVisitDate='{nextVisitDate}', Status='{status}', Notes='{notes}' WHERE RecordID={recordId};";
                    if (DataAccess.Execute(query) == false)
                    {
                        MessageBox.Show("Failed to update record. Please try again.");
                        return;
                    }
                    MessageBox.Show("Record updated successfully.");
                    loadData();
                    newData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message);
                }

            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            newData();


        }

        private void btnWorkShedule_Click(object sender, EventArgs e)
        {
            WorkShedule workSheduleForm = new WorkShedule();
            workSheduleForm.SetUserID(UserID);
            workSheduleForm.Show();
            this.Hide();
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


            if (con == "Record ID")
            {

                if (string.IsNullOrEmpty(searchText))
                {
                    loadData();
                    return;
                }
                var query = $"SELECT MR.RecordID, A.AnimalID, A.Name AS AnimalName, A.Species, D.FullName AS DoctorName, MR.DoctorID, MR.TreatmentDate, MR.Treatment, MR.MedicineGiven, MR.NextVisitDate, MR.Status, MR.Notes FROM MedicalRecord MR JOIN Animal A ON MR.AnimalID = A.AnimalID JOIN [User] D ON MR.DoctorID = D.UserID WHERE CAST(MR.RecordID AS VARCHAR) LIKE '{searchText}%' ORDER BY MR.TreatmentDate DESC;";
                var dt = DataAccess.GetData(query);
                if (dt == null || dt.Rows.Count == 0)
                {

                    return;
                }
                dgvMedicalRecord.DataSource = dt;
                dgvMedicalRecord.Refresh();
                dgvMedicalRecord.ClearSelection();



            }
            else if (con == "Animal Name")
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    loadData();
                    return;
                }

                var query = $"SELECT MR.RecordID, A.AnimalID, A.Name AS AnimalName, A.Species, D.FullName AS DoctorName, MR.DoctorID, MR.TreatmentDate, MR.Treatment, MR.MedicineGiven, MR.NextVisitDate, MR.Status, MR.Notes FROM MedicalRecord MR JOIN Animal A ON MR.AnimalID = A.AnimalID JOIN [User] D ON MR.DoctorID = D.UserID WHERE A.Name LIKE '{searchText}%' ORDER BY MR.TreatmentDate DESC;";
                var dt = DataAccess.GetData(query);
                if (dt == null || dt.Rows.Count == 0)
                {
                    return;
                }

                dgvMedicalRecord.DataSource = dt;
                dgvMedicalRecord.Refresh();
                dgvMedicalRecord.ClearSelection();
            }
            else if (con == "Doctor Name")
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    loadData();
                    return;
                }

                var query = $"SELECT MR.RecordID, A.AnimalID, A.Name AS AnimalName, A.Species, D.FullName AS DoctorName, MR.DoctorID, MR.TreatmentDate, MR.Treatment, MR.MedicineGiven, MR.NextVisitDate, MR.Status, MR.Notes FROM MedicalRecord MR JOIN Animal A ON MR.AnimalID = A.AnimalID JOIN [User] D ON MR.DoctorID = D.UserID WHERE D.FullName LIKE '{searchText}%' ORDER BY MR.TreatmentDate DESC;";
                var dt = DataAccess.GetData(query);
                if (dt == null || dt.Rows.Count == 0)
                {
                    return;
                }
                dgvMedicalRecord.DataSource = dt;
                dgvMedicalRecord.Refresh();
                dgvMedicalRecord.ClearSelection();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.SetUserId(UserID);
            adminHome.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        }

        private void button1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
    
}
