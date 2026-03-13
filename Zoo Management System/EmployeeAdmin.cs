
using System;
using System.Collections;
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

    public partial class EmployeeAdmin : Form
    {
        public EmployeeAdmin()
        {
            InitializeComponent();
        }

        int UserId;
        int EmployeeId;
        public void SetUserID(int UserId)
        {
            this.UserId = UserId;
        }
        public void SetEmployeeID(int EmployeeId)
        {
            this.EmployeeId = EmployeeId;
        }


        private void EmployeeAdmin_Load(object sender, EventArgs e)
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
                        E.EmployeeID,
                        E.EmployeeType,
                        E.Salary,
                        E.EmployeePicture
                        FROM [User] U JOIN EmployeeDetails E ON U.UserID = E.EmployeeID;";

            var data = DataAccess.GetData(query);
            if (data == null)
            {
                MessageBox.Show("No data found.");
            }
            else
            {
                dgvEmployee.AutoGenerateColumns = false;
                dgvEmployee.DataSource = data;
                dgvEmployee.Refresh();
                dgvEmployee.ClearSelection();
            }
        }
        private void NewData()
        {
            dgvEmployee.ClearSelection();
            txtUId.Clear();
            txtName.Clear();
            txtPhn.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtESalary.Clear();
            txtPass.Clear();
            txtEId.Clear();
            txtEtype.Clear();
            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;
            dtpJoinDate.Value = DateTime.Now;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUId.Text = dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPass.Text = dgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dgvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhn.Text = dgvEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAddress.Text = dgvEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                string gender = dgvEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (gender == "Male")
                {
                    rbtnMale.Checked = true;
                    rbtnFemale.Checked = false;
                }
                else if (gender == "Female")
                {
                    rbtnFemale.Checked = true;
                    rbtnMale.Checked = false;
                }
                else
                {
                    rbtnMale.Checked = false;
                    rbtnFemale.Checked = false;
                }
                if (dgvEmployee.Rows[e.RowIndex].Cells[7].Value != DBNull.Value)
                {
                    dtpJoinDate.Value = Convert.ToDateTime(dgvEmployee.Rows[e.RowIndex].Cells[7].Value);
                }
                else
                {
                    dtpJoinDate.Value = DateTime.Now;
                }
                txtEId.Text = dgvEmployee.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtEtype.Text = dgvEmployee.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtESalary.Text = dgvEmployee.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            string eid = txtEId.Text;
            string uid = txtUId.Text;
            if (eid == string.Empty || uid == string.Empty)
            {
                MessageBox.Show("Please select an employee's details to delete.");
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete this employee's details?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            var queryEmp = $"DELETE FROM EmployeeDetails WHERE EmployeeId={eid}";
            var queryUser = $"DELETE FROM [User] WHERE UserID={uid}";
            if (DataAccess.Execute(queryEmp) && DataAccess.Execute(queryUser))
            {
                MessageBox.Show("Employee's details deleted successfully.");
                this.LoadData();
                this.NewData();
            }
            else
            {
                MessageBox.Show("Failed to delete employee's details.");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string uid = txtUId.Text;
            string eid = txtEId.Text;
            string name = txtName.Text;
            string pass = txtPass.Text;
            string email = txtEmail.Text;
            string phone = txtPhn.Text;
            string address = txtAddress.Text;
            string gender = "";
            if (rbtnMale.Checked)
            {
                gender = "Male";
            }
            else if (rbtnFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "";
            }
            if (email.StartsWith("@") || email.EndsWith("@") || email.Contains("..") || !email.Contains("@") || !email.Contains(".") || (email.IndexOf("@") > email.LastIndexOf(".")))
            {
                MessageBox.Show("Invalid Email Formate\ncorrect formate: someone@email.com");
            }
            if (phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be 11 DIGITS.");
                return;
            }
            DateTime joinDate = dtpJoinDate.Value;
            string roleId = "2";
            string empType = txtEtype.Text;
            string salary = txtESalary.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(empType) || string.IsNullOrEmpty(salary))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (string.IsNullOrEmpty(uid) && string.IsNullOrEmpty(eid))
            {
                string insertUser = $@"
        INSERT INTO [User] (FullName, Password, Email, PhoneNumber, Address, Gender, JoinDate, RoleID)
        OUTPUT INSERTED.UserID
        VALUES ('{name}', '{pass}', '{email}', '{phone}', '{address}', '{gender}', '{joinDate.Date}', {roleId});";
                string checkQuery = $"SELECT * FROM [User] WHERE Email = '{email}'";
                var data = DataAccess.GetData(checkQuery);

                if (data == null)
                    return;

                if (data.Rows.Count > 0)
                {
                    MessageBox.Show("This email is already registered.");
                    return;
                }
                DataTable userResult = DataAccess.GetData(insertUser);

                if (userResult == null || userResult.Rows.Count == 0)
                {
                    MessageBox.Show("Failed to save user.");
                    return;
                }
                string newUserId = userResult.Rows[0][0].ToString();

                string insertEmp = $@"
        INSERT INTO EmployeeDetails (EmployeeID, EmployeeType, Salary)
        VALUES ({newUserId}, '{empType}', {salary});";
                if (DataAccess.Execute(insertEmp))
                {
                    MessageBox.Show("Employee added successfully.");
                    this.LoadData();
                    this.NewData();
                }
                else
                {
                    MessageBox.Show("Failed to add employee details.");
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

                string updateEmp = $@"
        UPDATE EmployeeDetails
        SET EmployeeType = '{empType}',
            Salary = {salary}
        WHERE EmployeeID = {eid};";

                if (DataAccess.Execute(updateUser) && DataAccess.Execute(updateEmp))
                {
                    MessageBox.Show("Employee updated successfully.");
                    this.LoadData();
                    this.NewData();
                }
                else
                {
                    MessageBox.Show("Failed to update employee details.");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
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
                    E.EmployeeID,
                    E.EmployeeType,
                    E.Salary,
                    E.EmployeePicture
                  FROM [User] U 
                  JOIN EmployeeDetails E ON U.UserID = E.EmployeeID
                  WHERE U.FullName LIKE '%{searchText}%'";

                var data = DataAccess.GetData(query);
                dgvEmployee.DataSource = data;
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
            AdminOperation adminOperation = new AdminOperation(UserId);
            adminOperation.Show();
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
            visitorAdmin.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            EmployeeAdmin employeeAdmin = new EmployeeAdmin();
            employeeAdmin.SetUserID(UserId);
            employeeAdmin.Show();
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
    }
}
