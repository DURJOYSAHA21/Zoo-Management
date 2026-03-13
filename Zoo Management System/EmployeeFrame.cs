using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooManagementSystem;

namespace ZooManagementSystem
{
    
    public partial class EmployeeFrame : Form
    {
        public EmployeeFrame()
        {
            InitializeComponent();
        }

        int UserID;
        int i = 0;
        public void SetUserID(int UserID)
        {
            this.UserID = UserID;
        }
        private void EmployeeFrame_Load(object sender, EventArgs e)
        {
            var query = $"SELECT FullName FROM [User] WHERE UserID = {UserID}";
            DataTable dt = DataAccess.GetData(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                string userName = dt.Rows[0]["FullName"].ToString();
                label1.Text = $"Welcome, {userName}!";
            }
            else
            {
                label1.Text = "Welcome, User!";
            }


        }

        private void btnTaskAssigned_Click(object sender, EventArgs e)
        {
            i = 1;
            string today = DateTime.Today.ToString();
            var query3 = $"SELECT WS.WorkDate, WS.EmployeeID, WS.UpdatedBy, WS.Task,WS.Status, A.AnimalID, A.Name AS [Animal Name], A.Species FROM WorkSchedule WS JOIN Animal A ON WS.AnimalID = A.AnimalID WHERE WS.WorkDate = '{today}' AND WS.EmployeeID = {UserID}  AND WS.Status!='Completed'";

            DataTable dt3 = DataAccess.GetData(query3);
            dgvEmployeeGrid.AutoGenerateColumns = false;
            dgvEmployeeGrid.DataSource = dt3;

        }

        private void dgvEmployeeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(i==1)
            {
            }
        }

        private void btnLeaveRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAnimals_Click(object sender, EventArgs e)
        {
            AnimalHomeScreen animalHomeScreen = new AnimalHomeScreen(this);
            animalHomeScreen.SetUserID(UserID);
            this.Show();
            this.Hide();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //AddAnimal addAnimal = new AddAnimal();
            //addAnimal.ShowDialog();

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm();
            chatForm.SetUserID(UserID);
            chatForm.Show();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();

        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfileView profileView = new EmployeeProfileView(UserID);
          
            profileView.Show();
            this.Hide();
        }

        private void btnWriteReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.SetEmployeeID(UserID);
           
            report.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
