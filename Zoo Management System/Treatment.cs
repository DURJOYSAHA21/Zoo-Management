using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ZooManagementSystem
{
    public partial class Treatment : Form
    {
        public Treatment()
        {
            InitializeComponent();
        }

        int UserID;
        int AnimalID;
       
        public void SetAnimalID(int animalID)
        {
            this.AnimalID = animalID;
        }
       
       
        public void SetUserID(int UserID)
        {
            this.UserID = UserID;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAllRecord_Click(object sender, EventArgs e)
        {
           var query = "SELECT MR.RecordID, MR.AnimalID, A.Name AS AnimalName, A.Species, A.Gender, MR.TreatmentDate, MR.Treatment, MR.MedicineGiven, MR.NextVisitDate, MR.Notes, MR.Status, U.FullName AS DoctorName,MR.DoctorID FROM MedicalRecord MR JOIN Animal A ON MR.AnimalID = A.AnimalID JOIN[User] U ON MR.DoctorID = U.UserID;";
            var dt = DataAccess.GetData(query);
            if (dt == null)
            {
                return;
            }
            
            dgvAllMedicalRecord.DataSource = dt;
            dgvAllMedicalRecord.Refresh();
            dgvAllMedicalRecord.ClearSelection();
           
           

        }
        private void loadData()
        {
            txtRecordID.ReadOnly=true;
            var query = $"SELECT MR.RecordID, MR.AnimalID, A.Name AS AnimalName, A.Species, A.Gender, MR.TreatmentDate, MR.Treatment, MR.MedicineGiven, MR.NextVisitDate, MR.Notes, MR.Status, U.FullName AS DoctorName,MR.DoctorID FROM MedicalRecord MR JOIN Animal A ON MR.AnimalID = A.AnimalID JOIN [User] U ON MR.DoctorID = U.UserID WHERE MR.DoctorID = {UserID};";
            DataTable dt = DataAccess.GetData(query);
            if (dt == null)
            {
                return;
            }

            dgvAllMedicalRecord.DataSource = dt;
            dgvAllMedicalRecord.Refresh();
            dgvAllMedicalRecord.ClearSelection();

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

        private void btnYourRecord_Click(object sender, EventArgs e)
        {
            loadData();



        }
        int? recordID=null;
        private void dgvAllMedicalRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                DataGridViewRow row = dgvAllMedicalRecord.Rows[e.RowIndex];
                try
                {
                    recordID = Convert.ToInt32(row.Cells["RecordID"].Value);
                    txtRecordID.Text = recordID.ToString();

                    AnimalID = Convert.ToInt32(row.Cells["AnimalID"].Value);
                    cmbAnimal.Text = row.Cells["AnimalName"].Value.ToString();
                    cmbAnimal.SelectedValue = AnimalID;



                    dtpTreatmentDate.Value = Convert.ToDateTime(row.Cells["TreatmentDate"].Value);


                    txtTreatment.Text = row.Cells["Treatment"].Value.ToString();


                    txtMedicine.Text = row.Cells["MedicineGiven"].Value.ToString();

                    dtpTreatmentDate.Value = Convert.ToDateTime(row.Cells["NextVisitDate"].Value);
                    if (dtpNextVisitDate.Value == null)
                    {
                        dtpNextVisitDate.Value = DateTime.Now;
                    }


                    txtNotes.Text = row.Cells["Notes"].Value.ToString();

                    txtStatus.Text = row.Cells["Status"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);


                }
            }

        }

        private void SetInputsEnabled(bool enabled)
        {
          
        }

        public void Refresh()
        {
            btnYourRecord.PerformClick();
            loadData();

        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            newData();



        }


        private void btnChooseAnimal_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtRecordID.Text;
            if (string.IsNullOrEmpty(id))
            {
                try
                {
                    int animalID = Convert.ToInt32(cmbAnimal.SelectedValue);
                    DateTime treatmentDate = dtpTreatmentDate.Value;
                    if(treatmentDate < DateTime.Now)
                    {
                        MessageBox.Show("Treatment date cannot be in the past.");
                        return;
                    }
                    else
                    {
                        treatmentDate = treatmentDate.Date;
                    }

                    if (animalID <= 0)
                    {
                        MessageBox.Show("Please select a valid animal.");
                        return;
                    }

                    string treatment = txtTreatment.Text;
                    string medicine = txtMedicine.Text;
                    DateTime nextVisitDate = dtpNextVisitDate.Value;
                    if (nextVisitDate < DateTime.Now)
                    {
                        MessageBox.Show("Next visit date cannot be in the past.");
                        return;
                    }
                    else
                    {
                        nextVisitDate = nextVisitDate.Date;
                    }
                    string notes = txtNotes.Text;
                    string status = txtStatus.Text;
                    var query = $"INSERT INTO MedicalRecord (AnimalID, TreatmentDate, Treatment, MedicineGiven, NextVisitDate, Notes, Status, DoctorID) VALUES ({animalID}, '{treatmentDate}', '{treatment}', '{medicine}', '{nextVisitDate}', '{notes}', '{status}', {UserID});";
                    var result = DataAccess.Execute(query);

                    if (result == true)
                    {
                        MessageBox.Show("Record saved successfully.");
                        newData();
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save the record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    int recordId = Convert.ToInt32(id);
                    int animalID = Convert.ToInt32(cmbAnimal.SelectedValue);
                    DateTime treatmentDate = dtpTreatmentDate.Value;
                    if (treatmentDate < DateTime.Now)
                    {
                        MessageBox.Show("Treatment date cannot be in the past.");
                        return;
                    }
                    else
                    {
                        treatmentDate = treatmentDate.Date;
                    }
                    string treatment = txtTreatment.Text;
                    string medicine = txtMedicine.Text;
                    DateTime nextVisitDate = dtpNextVisitDate.Value;
                    if (nextVisitDate < DateTime.Now)
                    {
                        MessageBox.Show("Next visit date cannot be in the past.");
                        return;
                    }
                    else
                    {
                        nextVisitDate = nextVisitDate.Date;
                    }
                    string notes = txtNotes.Text;
                    string status = txtStatus.Text;
                    var query = $"UPDATE MedicalRecord SET AnimalID={animalID}, TreatmentDate='{treatmentDate}', Treatment='{treatment}', MedicineGiven='{medicine}', NextVisitDate='{nextVisitDate}', Notes='{notes}', Status='{status}' WHERE RecordID={recordId} AND DoctorID={UserID};";
                    var result = DataAccess.Execute(query);
                    if (result == true)
                    {
                        MessageBox.Show("Record updated successfully.");
                        newData();
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }




        }

        private void Treatment_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {



        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            newData();
            loadData();
            txtRecordID.ReadOnly = true;
            cmbAnimal.SelectedIndex = -1;
            dtpTreatmentDate.Value = DateTime.Now;
            txtTreatment.Clear();
            txtMedicine.Clear();
            dtpNextVisitDate.Value = DateTime.Now;
            txtNotes.Clear();
            txtStatus.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void newData()
        {
            txtRecordID.Clear();
            cmbAnimal.SelectedIndex = -1;
            dtpTreatmentDate.Value = DateTime.Now;
            txtTreatment.Clear();
            txtMedicine.Clear();
            dtpNextVisitDate.Value = DateTime.Now;
            txtNotes.Clear();
            txtStatus.Clear();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtRecordID.Text))
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }
            int recordID = Convert.ToInt32(txtRecordID.Text);
            var query2 = $"SELECT DoctorID FROM MedicalRecord WHERE RecordID = {recordID} ;";
            var dt = DataAccess.GetData(query2);
            int doctorID = int.Parse(dt.Rows[0]["DoctorID"].ToString());
            if (doctorID != UserID)
            {
                MessageBox.Show("You can only delete your own records.");
                return;
            }

           
            var query = $"DELETE FROM MedicalRecord WHERE RecordID = {recordID} And DoctorID={UserID};";
            var result = DataAccess.Execute(query);
            
            
            if (result ==true)

            {
               
                MessageBox.Show("Record deleted successfully.");
                newData();
                loadData();




            }
            else
            {
                MessageBox.Show("Failed to delete the record. Please try again.");
            }

        }

        private void Treatment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.Owner != null)
            {
                this.Owner.Show();
            }
            else
            {
               
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedItem == null)
            {
                MessageBox.Show("Please select a search criteria.");
                return;
            }
            var con=cmbSearch.SelectedItem.ToString();
            string searchText = txtSearch.Text;


            if (con == "Record ID")
            {

                if (string.IsNullOrEmpty(searchText))
                {
                    loadData(); 
                    return;
                }
                var Query= $"SELECT MR.RecordID, MR.AnimalID, A.Name AS AnimalName, A.Species, A.Gender, MR.TreatmentDate, MR.Treatment, MR.MedicineGiven, MR.NextVisitDate, MR.Notes, MR.Status, U.FullName AS DoctorName, MR.DoctorID FROM MedicalRecord MR JOIN Animal A ON MR.AnimalID = A.AnimalID JOIN [User] U ON MR.DoctorID = U.UserID WHERE CAST(MR.RecordID AS VARCHAR) LIKE '{searchText}%' ;";
                var dt = DataAccess.GetData(Query);
                if (dt == null || dt.Rows.Count == 0)
                {
                
                    return;
                }
                dgvAllMedicalRecord.DataSource = dt;
                dgvAllMedicalRecord.Refresh();
                dgvAllMedicalRecord.ClearSelection();




            }
            else if(con == "Animal Name")
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    loadData();
                    return;
                }

                var query = $"SELECT MR.RecordID, MR.AnimalID, A.Name AS AnimalName, A.Species, A.Gender, MR.TreatmentDate, MR.Treatment, MR.MedicineGiven, MR.NextVisitDate, MR.Notes, MR.Status, U.FullName AS DoctorName, MR.DoctorID FROM MedicalRecord MR JOIN Animal A ON MR.AnimalID = A.AnimalID JOIN [User] U ON MR.DoctorID = U.UserID WHERE A.Name LIKE '{searchText}%';";

                var dt = DataAccess.GetData(query);
                if (dt == null || dt.Rows.Count == 0)
                {
                    return;
                }

                dgvAllMedicalRecord.DataSource = dt;
                dgvAllMedicalRecord.Refresh();
                dgvAllMedicalRecord.ClearSelection();
            }
            

        }
    }
}
