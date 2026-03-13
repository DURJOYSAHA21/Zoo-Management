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
    public partial class AdminHome : Form
    {
        private int UserId;

        public AdminHome()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        public void SetUserId(int userId)
        {
            this.UserId = userId;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lblCurrentDate.Text = $"Today\n{DateTime.Now.ToString("MMMM dd, yyyy")}";

            var user = DataAccess.GetData($"SELECT * FROM [User] WHERE UserID = {UserId}");
            if (user != null && user.Rows.Count > 0)
            {
                lblTitle.Text = $"Welcome Back, {user.Rows[0]["FullName"]}!";
            }

            LoadStatistics();
        }

        private void LoadStatistics()
        {
            DateTime today = DateTime.Today.Date;

            try
            {

                var visitQuery = $"SELECT COUNT(*) FROM Ticket WHERE VisitDate = '{today}'";
                DataTable visitDt = DataAccess.GetData(visitQuery);
                if (visitDt.Rows.Count > 0 && !string.IsNullOrEmpty(visitDt.Rows[0][0].ToString()))
                {
                    btnTodayVisit.Text = $"Today's Visits\r\n{visitDt.Rows[0][0]}";
                }
                else
                {
                    btnTodayVisit.Text = "Today's Visits\r\n0";
                }


                var purchaseQuery = $"SELECT COUNT(*) FROM Ticket WHERE PurchaseDate = '{today}'";
                DataTable purchaseDt = DataAccess.GetData(purchaseQuery);
                if (purchaseDt.Rows.Count > 0 && !string.IsNullOrEmpty(purchaseDt.Rows[0][0].ToString()))
                {
                    btnTodayPurchase.Text = $"Today's Purchases\r\n{purchaseDt.Rows[0][0]}";
                }
                else
                {
                    btnTodayPurchase.Text = "Today's Purchases\r\n0";
                }

                var ticketQuery = $"SELECT SUM(ti.Quantity) FROM TicketItem ti JOIN Ticket t ON ti.TicketID = t.TicketID WHERE t.PurchaseDate = '{today}'";
                DataTable ticketDt = DataAccess.GetData(ticketQuery);
                if (ticketDt.Rows.Count > 0 && !string.IsNullOrEmpty(ticketDt.Rows[0][0].ToString()))
                {
                    btnTodayTotalTicket.Text = $"Today's Tickets\r\n{ticketDt.Rows[0][0]}";
                }
                else
                {
                    btnTodayTotalTicket.Text = "Today's Tickets\r\n0";
                }

                var revenueQuery = $"SELECT SUM(TotalCost) FROM Ticket WHERE PurchaseDate = '{today}'";
                DataTable revenueDt = DataAccess.GetData(revenueQuery);
                if (revenueDt.Rows.Count > 0 && !string.IsNullOrEmpty(revenueDt.Rows[0][0].ToString()))
                {
                    btnTodayRevenue.Text = $"Today's Revenue\r\n{revenueDt.Rows[0][0]}";
                }
                else
                {
                    btnTodayRevenue.Text = "Today's Revenue\r\n0";
                }


                var doctorQuery = "SELECT COUNT(*) FROM EmployeeDetails WHERE EmployeeType = 'Doctor'";
                DataTable doctorDt = DataAccess.GetData(doctorQuery);
                if (doctorDt.Rows.Count > 0 && !string.IsNullOrEmpty(doctorDt.Rows[0][0].ToString()))
                {
                    btnTotalDoctor.Text = $"Total Doctors\r\n{doctorDt.Rows[0][0]}";
                }
                else
                {
                    btnTotalDoctor.Text = "Total Doctors\r\n0";
                }


                var staffQuery = "SELECT COUNT(*) FROM EmployeeDetails WHERE EmployeeType = 'Staff' OR EmployeeType = 'Manager'";
                DataTable staffDt = DataAccess.GetData(staffQuery);
                if (staffDt.Rows.Count > 0 && !string.IsNullOrEmpty(staffDt.Rows[0][0].ToString()))
                {
                    btnTotalStaffs.Text = $"Total Staff\r\n{staffDt.Rows[0][0]}";
                }
                else
                {
                    btnTotalStaffs.Text = "Total Staff\r\n0";
                }


                var animalQuery = "SELECT COUNT(*) FROM Animal";
                DataTable animalDt = DataAccess.GetData(animalQuery);
                if (animalDt.Rows.Count > 0 && !string.IsNullOrEmpty(animalDt.Rows[0][0].ToString()))
                {
                    btnTotalAnimal.Text = $"Total Animals\r\n{animalDt.Rows[0][0]}";
                }
                else
                {
                    btnTotalAnimal.Text = "Total Animals\r\n0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWorkSchedule_Click(object sender, EventArgs e)
        {
            WorkShedule workShedule = new WorkShedule();
            workShedule.SetUserID(UserId);
            workShedule.Show();
            this.Hide();
        }

        private void btnMedicalRecord_Click(object sender, EventArgs e)
        {
            MedicalRecordAdmin medicalRecordAdmin = new MedicalRecordAdmin();
            medicalRecordAdmin.SetUserID(UserId);
            medicalRecordAdmin.Show();
            this.Hide();
        }

        private void btnCheckupDetails_Click(object sender, EventArgs e)
        {
            CheckupAdmin checkupAdmin = new CheckupAdmin();
            checkupAdmin.SetUserID(UserId);
            checkupAdmin.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.SetUserId(UserId);
            adminHome.Show();
            this.Hide();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            adminEventOperation adminEventOperation = new adminEventOperation(UserId);
            adminEventOperation.Show();
           
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            BankCrud bankCrud = new BankCrud();
            bankCrud.SetUserID(UserId);
            bankCrud.Show();
           
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            VisitorAdmin visitorAdmin = new VisitorAdmin();
            visitorAdmin.SetUserId(UserId);
            visitorAdmin.SetVisitorId(UserId);
            visitorAdmin.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            EmployeeAdmin employeeAdmin = new EmployeeAdmin();
            employeeAdmin.SetUserID(UserId);
            employeeAdmin.SetEmployeeID(UserId);
            employeeAdmin.Show();
            this.Hide();
        }

        private void btnViewAnimal_Click(object sender, EventArgs e)
        {
            AdminAnimalOperation adminAnimalOperation = new AdminAnimalOperation();
            adminAnimalOperation.SetUserID(UserId);
            adminAnimalOperation.Show();
            this.Hide();
        }

        private void btnViewAnimals_Click(object sender, EventArgs e)
        {
            AdminAnimalOperation adminAnimalOperation = new AdminAnimalOperation();
            adminAnimalOperation.SetUserID(UserId);
            adminAnimalOperation.Show();
            this.Hide();
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            EmployeeAdmin employeeAdmin = new EmployeeAdmin();
            employeeAdmin.SetUserID(UserId);
            employeeAdmin.SetEmployeeID(UserId);
            employeeAdmin.Show();
            this.Hide();
        }

       
        private void btnVisitors_Click(object sender, EventArgs e)
        {
            VisitorAdmin visitorAdmin = new VisitorAdmin();
            visitorAdmin.SetUserId(UserId);
            visitorAdmin.SetVisitorId(UserId);
            visitorAdmin.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnViewAnimals_Click_1(object sender, EventArgs e)
        {
            AnimalHomeScreen animalHomeScreen = new AnimalHomeScreen();
            animalHomeScreen.SetUserID(UserId);
            animalHomeScreen.Show();

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loginForm.Show();
                this.Close();

            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChat_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVisitors_Click_1(object sender, EventArgs e)
        {
            AdminOperation adminOperation = new AdminOperation(UserId);
            adminOperation.Show();
            this.Hide();
        }
    }
}