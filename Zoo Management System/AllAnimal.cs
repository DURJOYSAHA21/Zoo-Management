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
    public partial class AllAnimal : Form
    {
        
        public AllAnimal()
        {
            InitializeComponent();

        }
        private DoctorForm doctorForm;
        private CheckUpDetails checkUpDetails;
        public AllAnimal(DoctorForm doctorForm)
        {
            InitializeComponent();
            this.doctorForm = doctorForm;
        }
        public AllAnimal(CheckUpDetails checkUpDetails)
        {
            InitializeComponent();
            this.checkUpDetails = checkUpDetails;
        }

        int UserID;
        public void SetUserID(int UserID)
        {
            this.UserID = UserID;
        }




        private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgvAnimals.Rows[e.RowIndex];
                    int animalID = Convert.ToInt32(selectedRow.Cells["AnimalID"].Value);

                    if(doctorForm != null)
                    {
                        MedicalRecordForm MedicalRecordForm = new MedicalRecordForm();
                        MedicalRecordForm.SetAnimalID(animalID);
                        MedicalRecordForm.SetUserID(UserID);
                        MedicalRecordForm.Show();

                    }
                    else if (checkUpDetails != null)
                    {
                        checkUpDetails.SetAnimalID(animalID);
                        checkUpDetails.SetUserID(UserID);
                        checkUpDetails.Show();

                    }
                    else
                    {
                        
                    }



                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        
        
        }
    

        private void AllAnimal_Load(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT AnimalID, Name, Species, Gender FROM Animal";
                DataTable dt = DataAccess.GetData(query);
                dgvAnimals.DataSource = dt;

               
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading animals: " + ex.Message);
                return;
            }

        }

        private void AllAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (doctorForm != null)
            {
                doctorForm.Show();
            }
            else if (checkUpDetails != null)
            {
                checkUpDetails.Show();
            }


        }
    }
}
