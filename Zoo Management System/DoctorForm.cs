using Guna.UI2.WinForms;
using System.Data;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;



namespace ZooManagementSystem
{
    public partial class DoctorForm : Form
    {
        int UserID;
        int AnimalID;

        public DoctorForm()
        {
            InitializeComponent();
            this.Size = new Size(800,680); 



        }

        public void SetUserID(int UserID)
        {
            this.UserID = UserID;
        }

        public void SetAnimalID(int AnimalID)
        {
            this.AnimalID = AnimalID;
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProfile();
                LoadMedicalRecords();
                LoadCheckups();
                LoadWorkSchedule();
                LoadUnreadMessages();
                LoadProfile();
               
            }
            catch (Exception ex)
            {
                Guna.UI2.WinForms.MessageDialog.Show(this, "Error loading data: " + ex.Message,
                    "Error", MessageDialogButtons.OK, MessageDialogIcon.Error);
            }

        }

        private void LoadProfile()
        {
            try
            {
                DataTable dt = DataAccess.GetData($"SELECT FULLNAME FROM [User] WHERE UserID ={UserID}");

                if (dt.Rows.Count > 0)
                {
                    string fullName = dt.Rows[0]["FULLNAME"].ToString();
                    lblWelcome.Text = "Welcome, Doctor " + fullName;
                }

                DataTable dt2 = DataAccess.GetData($"SELECT EmployeePicture From EmployeeDetails WHERE EmployeeID = {UserID}");
                if (dt2.Rows.Count > 0)
                {
                    string EmployeePicture = dt2.Rows[0]["EmployeePicture"].ToString();
                    if (!string.IsNullOrEmpty(EmployeePicture))
                    {
                        try
                        {
                            picImage.Image = Image.FromFile(EmployeePicture);
                            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (Exception ex)
                        {
                            Guna.UI2.WinForms.MessageDialog.Show(this, "Error loading image: " + ex.Message,
                                "Error", MessageDialogButtons.OK, MessageDialogIcon.Error);
                        }
                    }
                    else
                    {
                        picImage.Image = null;
                    }
                }

                LoadUnreadMessages();
            }
            catch (Exception ex)
            {
                Guna.UI2.WinForms.MessageDialog.Show(this, "Error loading data: " + ex.Message,
                    "Error", MessageDialogButtons.OK, MessageDialogIcon.Error);
            }
        }

        private void LoadUnreadMessages()
        {
            DataTable dt3 = DataAccess.GetData($"SELECT U.FullName ,C.Message FROM Chat C JOIN [User] U ON C.SenderID=U.UserID WHERE ReceiverID={UserID} AND IsRead=0 Order BY C.SentAt DESC");

            lblUnread1.Text = dt3.Rows.Count > 0 ? $"{dt3.Rows[0]["FullName"]}: {dt3.Rows[0]["Message"]}" : "No unread messages";
            lblUnread2.Text = dt3.Rows.Count > 1 ? $"{dt3.Rows[1]["FullName"]}: {dt3.Rows[1]["Message"]}" : "";
            lblUnread3.Text = dt3.Rows.Count > 2 ? $"{dt3.Rows[2]["FullName"]}: {dt3.Rows[2]["Message"]}" : "";
            lblUnread4.Text = dt3.Rows.Count > 3 ? $"{dt3.Rows[3]["FullName"]}: {dt3.Rows[3]["Message"]}" : "";
            lblUnread5.Text = dt3.Rows.Count > 4 ? $"{dt3.Rows[4]["FullName"]}: {dt3.Rows[4]["Message"]}" : "";
        }

        private void LoadMedicalRecords()
        {
            string query = $"SELECT MR.RecordID, A.AnimalID, A.Name AS AnimalName, A.Species, A.Gender, MR.TreatmentDate, MR.Treatment, MR.MedicineGiven, MR.NextVisitDate, MR.Notes, MR.Status, U.FullName AS DoctorName,MR.DoctorID FROM MedicalRecord MR JOIN Animal A ON MR.AnimalID = A.AnimalID JOIN [User] U ON MR.DoctorID = U.UserID WHERE MR.DoctorID = {UserID};";
            DataTable dt = DataAccess.GetData(query);
            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Refresh();
        }

        private void LoadCheckups()
        {
            var query = $"SELECT C.CheckupID, C.AnimalID,A.Name AS [Animal Name], A.Species AS [Species], U.FullName AS [Doctor Name], C.CheckupDate AS [Checkup Date], C.HealthCondition AS [Health Condition], C.Weight AS [Weight], C.Temperature AS [Temperature], C.HeartRate AS [Heart Rate], C.Notes AS [Notes] FROM Checkup C JOIN Animal A ON C.AnimalID = A.AnimalID JOIN [User] U ON C.DoctorID = U.UserID WHERE C.DoctorID ={UserID} ORDER BY C.CheckupDate DESC;";
            DataTable dt = DataAccess.GetData(query);
            guna2DataGridView2.AutoGenerateColumns = false; 
            guna2DataGridView2.DataSource = dt;
            guna2DataGridView2.Refresh();
        }

        private void LoadWorkSchedule()
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");
            var query = $"SELECT WS.WorkDate, WS.EmployeeID, WS.UpdatedBy, WS.Task,WS.Status, A.AnimalID, A.Name AS [AnimalName], A.Species FROM WorkSchedule WS JOIN Animal A ON WS.AnimalID = A.AnimalID WHERE WS.WorkDate = '{today}' AND WS.EmployeeID = {UserID} AND WS.Status!='Completed'";

            DataTable dt = DataAccess.GetData(query);
            guna2DataGridView3.AutoGenerateColumns = false;
            guna2DataGridView3.DataSource = dt;
            guna2DataGridView3.Refresh();
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            guna2Panel4.Visible = !guna2Panel4.Visible;
            if (guna2Panel4.Visible)
            {
                DataTable dt = DataAccess.GetData($"SELECT FULLNAME FROM [User] WHERE UserID ={UserID}");
                if (dt.Rows.Count > 0)
                {
                    lblName.Text = "DR. " + dt.Rows[0]["FULLNAME"].ToString();
                }
            }
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfileView employeeProfileView = new EmployeeProfileView(UserID);
            employeeProfileView.Show();
            this.Hide();
        }

        private void btnOpenChat_Click(object sender, EventArgs e)
        {
            ChatForm form1 = new ChatForm();
            form1.SetUserID(UserID);
            form1.Show();
            this.Hide();
        }

        private void btnAddCheckup_Click(object sender, EventArgs e)
        {
            AssignedAnimal assignedAnimal = new AssignedAnimal();
            assignedAnimal.SetUserID(UserID);
            assignedAnimal.Show();
            this.Hide();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            CheckUpDetails checkUpDetails = new CheckUpDetails();
            checkUpDetails.SetUserID(UserID);
            checkUpDetails.Show();
            this.Hide();
        }

        private void btnAddMedicalRecord_Click(object sender, EventArgs e)
        {
            AllAnimal allAnimal = new AllAnimal(this);
            allAnimal.SetUserID(UserID);
            allAnimal.Show();
            this.Hide();
        }

        private void btnViewAllAnimals_Click(object sender, EventArgs e)
        {
            AnimalHomeScreen animalHomeScreen = new AnimalHomeScreen(this);
            animalHomeScreen.SetUserID(UserID);
            animalHomeScreen.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Treatment treatment = new Treatment();
            treatment.SetUserID(UserID);
            treatment.Show();
            this.Hide();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            LoadMedicalRecords();
            LoadCheckups();
            LoadWorkSchedule();
            LoadUnreadMessages();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}