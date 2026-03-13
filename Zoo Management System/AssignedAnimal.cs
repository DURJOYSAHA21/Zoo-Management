using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ZooManagementSystem
{
    public partial class AssignedAnimal : Form
    {
        public AssignedAnimal()
        {
            InitializeComponent();
        }

        int UserID;
        public void SetUserID(int UserID)
        {
            this.UserID = UserID;

        }

        private void AssignedAnimal_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DataAccess.GetData($"SELECT FULLNAME FROM [User] WHERE UserID ={UserID}");

                if (dt.Rows.Count > 0)
                {
                    string fullName = dt.Rows[0]["FULLNAME"].ToString();
                    lblTitle.Text = $"Assigned Animals for {fullName}";
                }
                else
                {
                    lblTitle.Text = "Assigned Animals";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            DateTime today = DateTime.Today.Date;
            DataTable dt2 = DataAccess.GetData($"SELECT A.AnimalID, A.Name, A.Species FROM WorkSchedule WS JOIN Animal A ON WS.AnimalID = A.AnimalID WHERE WS.EmployeeID = {UserID} And Ws.WorkDate='{today}'");
            dgvAssignedAnimal.DataSource = dt2;
        }

        private void btnProccedCheckUp_Click(object sender, EventArgs e)
        {

            if (dgvAssignedAnimal.SelectedRows.Count > 0)
            {
                int animalID = Convert.ToInt32(dgvAssignedAnimal.SelectedRows[0].Cells["AnimalID"].Value);
                CheckUp checkUpForm = new CheckUp();
                checkUpForm.SetUserID(UserID);
                checkUpForm.SetAnimalID(animalID);
                checkUpForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Please select an animal to proceed with the check-up.");
            }
        }

        private void AssignedAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
