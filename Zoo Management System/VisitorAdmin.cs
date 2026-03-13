
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZooManagementSystem
{
    public partial class VisitorAdmin : Form
    {
        public VisitorAdmin()
        {
            InitializeComponent();
        }
        int UserId;
        int VisitorId;

        public void SetUserId(int userId)
        {
            this.UserId = userId;
        }
        public void SetVisitorId(int visitorId)
        {
            this.VisitorId = visitorId;
        }
        private void VisitorAdmin_Load(object sender, EventArgs e)
        {
           this.LoadData();
        }
        private void LoadData()
        {
            var query = $@"SELECT 
                        U.UserID,
                        U.FullName,
                        U.Password,
                        U.Email,
                        U.PhoneNumber,
                        U.Address,
                        U.Gender,
                        U.JoinDate,
                        U.RoleID,
                        V.VisitorID,
                        V.IsMember
                        FROM [User] U JOIN VisitorDetails V ON U.UserID = V.VisitorID;";

            var data = DataAccess.GetData(query);
            if (data == null)
            {
                MessageBox.Show("No data found.");
            }
            else
            {
                dgvVisitor.AutoGenerateColumns = false;
                dgvVisitor.DataSource = data;
                dgvVisitor.Refresh();
                dgvVisitor.ClearSelection();
            }
        }
        private void NewData()
        {
            dgvVisitor.ClearSelection();
            txtUIdV.Clear();
            txtNameV.Clear();
            txtPhnV.Clear();
            txtEmailV.Clear();
            txtAddressV.Clear();
            txtPassV.Clear();
            txtVId.Clear();
            rbtnYesV.Checked = false;
            rbtnNoV.Checked = false;
            rbtnFemaleV.Checked = false;
            rbtnMaleV.Checked = false;
            dtpJoinDateV.Value = DateTime.Now;

        }

        private void btnRefreshV_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();
        }

        private void dgvVisitor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtUIdV.Text = dgvVisitor.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameV.Text = dgvVisitor.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPassV.Text = dgvVisitor.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmailV.Text = dgvVisitor.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhnV.Text = dgvVisitor.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAddressV.Text = dgvVisitor.Rows[e.RowIndex].Cells[5].Value.ToString();
                string gender = dgvVisitor.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (gender == "Male")
                {
                    rbtnMaleV.Checked = true;
                    rbtnFemaleV.Checked = false;
                }
                else if (gender == "Female")
                {
                    rbtnFemaleV.Checked = true;
                    rbtnMaleV.Checked = false;
                }
                else
                {
                    rbtnMaleV.Checked = false;
                    rbtnFemaleV.Checked = false;
                }
                if (dgvVisitor.Rows[e.RowIndex].Cells[7].Value != DBNull.Value)
                {
                    dtpJoinDateV.Value = Convert.ToDateTime(dgvVisitor.Rows[e.RowIndex].Cells[7].Value);
                }
                else
                {
                    dtpJoinDateV.Value = DateTime.Now;
                }
                txtVId.Text = dgvVisitor.Rows[e.RowIndex].Cells[9].Value.ToString();
                string isMember = dgvVisitor.Rows[e.RowIndex].Cells[10].Value.ToString();
                if (isMember == "True")
                {
                    rbtnYesV.Checked = true;
                    rbtnNoV.Checked = false;
                }
                else if (isMember == "False")
                {
                    rbtnNoV.Checked = true;
                    rbtnYesV.Checked = false;
                }
                else
                {
                    rbtnYesV.Checked = false;
                    rbtnNoV.Checked = false;
                }
            }
        }

        private void btnDltV_Click(object sender, EventArgs e)
        {
            string vid = txtVId.Text;
            string uid = txtUIdV.Text;
            if (vid == string.Empty || uid == string.Empty)
            {
                MessageBox.Show("Please select an Visitor's details to delete.");
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete this Visitor's details?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            var queryMembership = $"UPDATE Membership SET IsActive = 0 WHERE VisitorId = {vid}";
            var queryTicketItem = $"DELETE FROM TicketItem WHERE TicketId IN(SELECT TicketId FROM Ticket WHERE VisitorId={vid})";
            var queryTicket = $"DELETE FROM Ticket WHERE VisitorId={vid}";
            var queryTransaction = $"DELETE FROM Transaction WHERE VisitorId={vid}";
            var queryVisitor = $"DELETE FROM VisitorDetails WHERE VisitorId={vid}";
            var queryUser = $"DELETE FROM [User] WHERE UserID={uid}";

            if (DataAccess.Execute(queryMembership)&&DataAccess.Execute(queryTicketItem)&& DataAccess.Execute(queryTicket)&& DataAccess.Execute(queryTransaction)
               && DataAccess.Execute(queryVisitor)&& DataAccess.Execute(queryUser))
            {
                MessageBox.Show("Visitor's details deleted successfully.");
                this.LoadData();
                this.NewData();
            }
            else
            {
                MessageBox.Show("Failed to delete Visitor's details.");
            }
        }
        private void btnNewV_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void btnSaveV_Click(object sender, EventArgs e)
        {
            string uid = txtUIdV.Text;
            string vid = txtVId.Text;
            string name = txtNameV.Text;
            string pass = txtPassV.Text;
            string email = txtEmailV.Text;
            string phone = txtPhnV.Text;
            string address = txtAddressV.Text;
            string gender = "";
            if (rbtnMaleV.Checked) { 
                gender = "Male"; }
            else if (rbtnFemaleV.Checked) { 
                gender = "Female"; }
            else {
                gender = ""; }

            int isMember=0;
            if (rbtnYesV.Checked)
            {
                isMember = 1;
            }
            else if (rbtnNoV.Checked)
            {
                isMember = 0;
            }

            if (email.StartsWith("@") || email.EndsWith("@") || email.Contains("..") || !email.Contains("@") || !email.Contains(".") || (email.IndexOf("@") > email.LastIndexOf(".")))
            {
                MessageBox.Show("Invalid Email Formate\ncorrect formate: someone@email.com");
                return;
            }
            if (phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be 11 DIGITS.");
                return;
            }
            DateTime joinDate = dtpJoinDateV.Value;
            if (joinDate < DateTime.Today)
            {
                MessageBox.Show("Please select a future date.");
                return;
            }
            string roleId = "3";

            if (name==string.Empty|| pass==string.Empty || email == string.Empty ||
               phone==string.Empty || address==string.Empty || gender==string.Empty)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (uid==string.Empty && vid == string.Empty)
            { 
                string checkQuery = $"SELECT * FROM [User] WHERE Email = '{email}'";
                var data = DataAccess.GetData(checkQuery);

                if (data == null)
                    return;

                if (data.Rows.Count > 0)
                {
                    MessageBox.Show("This email is already registered.");
                    return;
                }

                string insertUser = $@"
            INSERT INTO [User] (FullName, Password, Email, PhoneNumber, Address, Gender, JoinDate, RoleID)
            OUTPUT INSERTED.UserID
            VALUES ('{name}', '{pass}', '{email}', '{phone}', '{address}', '{gender}', '{joinDate.Date}', {roleId});";
                
                DataTable userResult = DataAccess.GetData(insertUser);

                if (userResult == null || userResult.Rows.Count == 0)
                {
                    MessageBox.Show("Failed to save user.");
                    return;
                }
                string newUserId = userResult.Rows[0][0].ToString();

                string insertVisitor = $@"
            INSERT INTO VisitorDetails (VisitorID, IsMember)
            VALUES ({newUserId}, {isMember});";
                if (DataAccess.Execute(insertVisitor))
                {
                    MessageBox.Show("Visitor added successfully.");
                    this.LoadData();
                    this.NewData();

                    if (isMember == 1)
                    {
                        MemberAdmin memberAdmin = new MemberAdmin(newUserId);
                        memberAdmin.Show();
                        this.Hide();
                    }
                    else { return; }
                }
                else
                {
                    MessageBox.Show("Failed to add visitor details.");
                }
            }
            else
            {
                string updateUser = $@"
        UPDATE [User]
        SET FullName = '{name}',
            Password = '{pass}',
            Email = '{email}',
            PhoneNumber = '{phone}',
            Address = '{address}',
            Gender = '{gender}',
            JoinDate = '{joinDate.Date}'
        WHERE UserID = {uid};";

                string updateVisitor = $@"
        UPDATE VisitorDetails
        SET IsMember = {isMember}
        WHERE VisitorID = {vid};";

                if (DataAccess.Execute(updateUser) && DataAccess.Execute(updateVisitor))
                {
                    MessageBox.Show("Visitor updated successfully.");
                    this.LoadData();
                    this.NewData();

                    if (isMember == 1)
                    {
                        MemberAdmin memberAdmin = new MemberAdmin(vid);
                        memberAdmin.Show();
                        this.Hide();
                    }
                    else { return; }
                }
                else
                {
                    MessageBox.Show("Failed to update visitor details.");
                }
            }
        }

        private void txtSearchV_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchV.Text;
            string query;
            if (string.IsNullOrEmpty(searchText))
            {
                this.LoadData();
            }
            else
            {
                query = $@"SELECT 
                    U.UserID,
                    U.FullName,
                    U.Password,
                    U.Email,
                    U.PhoneNumber,
                    U.Address,
                    U.Gender,
                    U.JoinDate,
                    U.RoleID,
                    V.VisitorID,
                    V.IsMember
                  FROM [User] U 
                  JOIN VisitorDetails V ON U.UserID = V.VisitorID
                  WHERE U.FullName LIKE '%{searchText}%'";

                var data = DataAccess.GetData(query);
                dgvVisitor.DataSource = data;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkShedule workShedule = new WorkShedule();
            workShedule.SetUserID(UserId);
            workShedule.Show();
            this.Hide();
        }

        private void btnCheckupDetails_Click(object sender, EventArgs e)
        {
            CheckupAdmin adminCheckup = new CheckupAdmin();
            adminCheckup.SetUserID(UserId);
            adminCheckup.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicalRecordAdmin adminAdmin = new MedicalRecordAdmin();
            adminAdmin.SetUserID(UserId);
            adminAdmin.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminOperation adminOperation = new AdminOperation(UserId);
            adminOperation.Show();
            this.Hide();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            adminEventOperation eventAdmin = new adminEventOperation(UserId);

            eventAdmin.Show();

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
            visitorAdmin.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

            EmployeeAdmin staffCrud = new EmployeeAdmin();
            staffCrud.SetUserID(UserId);
            staffCrud.Show();
            this.Hide();

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm();
            chatForm.SetUserID(UserId);
            chatForm.Show();
        }

        private void btnViewAnimal_Click(object sender, EventArgs e)
        {
            AdminAnimalOperation adminAnimalOperation = new AdminAnimalOperation();
            adminAnimalOperation.SetUserID(UserId);
            adminAnimalOperation.Show();
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

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.SetUserId(UserId);
            adminHome.Show();
            this.Hide();
        }
    }
}
