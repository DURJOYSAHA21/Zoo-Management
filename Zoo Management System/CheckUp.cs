using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZooManagementSystem
{
    public partial class CheckUp : Form
    {
        public CheckUp()
        {
            InitializeComponent();
        }
        

        int UserID;
        int AnimalID;
        int checkupID;

        public void SetUserID(int UserID)
        {
            this.UserID = UserID;

        }

        public void SetAnimalID(int AnimalID)
        {
            this.AnimalID = AnimalID;

        }
        private void CheckUp_Load(object sender, EventArgs e)
        {

            txtCHeckUpDate.Text = DateTime.Now.Date.ToString();
            txtCHeckUpDate.ReadOnly = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DateTime date;
            try
            {
                date =Convert.ToDateTime(txtCHeckUpDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }




                float weight;
                try
                {
                    weight = float.Parse(txtWeight.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid weight.");
                    return;
                }

                float temperature;
                try
                {
                    temperature = float.Parse(txtTemperature.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid temperature.");
                    return;
                }

                int heartRate;
                try
                {
                    heartRate = int.Parse(txtHeartRate.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid heart rate.");
                    return;
                }




                string HealthCondition;
                try
                {
                    HealthCondition = cmbHealthCondition.SelectedItem.ToString();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid health condition.");
                    return;
                }


                string Notes="";
                if (!string.IsNullOrEmpty(txtNotes.Text))
                {
                    Notes = txtNotes.Text.ToString();
                }
              

            

            try
            { 
                string query = $"INSERT INTO CheckUp OUTPUT INSERTED.CheckupID VALUES ({AnimalID}, {UserID},'{date}', {weight}, {temperature}, {heartRate}, '{HealthCondition}', '{Notes}')";
                DataTable dt =DataAccess.GetData(query);
                 
                if (dt.Rows.Count>0)
                {
                    checkupID = Convert.ToInt32(dt.Rows[0]["CheckupID"]);
                    DateTime today = DateTime.Today.Date;
                    string update = $"UPDATE WorkSchedule SET Status = 'Completed'WHERE EmployeeID = {UserID} AND AnimalID = {AnimalID} AND WorkDate ='{today}';";
                    DataAccess.Execute(update);
                    MessageBox.Show("Check-up details saved successfully.");
                  
                }
                else
                {
                    MessageBox.Show("Failed to save check-up details.");
                }

                var result = MessageBox.Show("Want To Write Report?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MedicalRecordForm medicalRecordForm = new MedicalRecordForm();
                    medicalRecordForm.SetUserID(UserID);
                    medicalRecordForm.SetAnimalID(AnimalID);
                    medicalRecordForm.SetCheckupDate(date);
                    medicalRecordForm.SetCheckupID(checkupID);
                    medicalRecordForm.Show();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            }
        }
    }
}
