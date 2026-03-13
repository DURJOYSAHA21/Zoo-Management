
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
    public partial class MemberAdmin : Form
    {
        string vid;
        string newUserId;
        int UserID;
        public MemberAdmin()
        {
            InitializeComponent();
        }
        public void SetUserID(int UserID)
        {
            this.UserID = UserID;
        }


        private void MemberAdmin_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        public MemberAdmin(string vid)
        {
            InitializeComponent();
            this.vid = vid;
        }
        private void LoadData()
        {
            var query = $@"SELECT 
                        V.VisitorID,
                        V.IsMember,
                        M.MembershipID,
                        M.MembershipTypeID,
                        M.StartDate,
                        M.EndDate,
                        M.Adults,
                        M.Children,
                        M.TransactionID,
                        M.IsActive
                        FROM VisitorDetails V
                        JOIN Membership M ON V.VisitorID = M.VisitorID";

            var data = DataAccess.GetData(query);
            if (data == null)
            {
                MessageBox.Show("No data found.");
            }
            else
            {
                dgvMem.AutoGenerateColumns = false;
                dgvMem.DataSource = data;
                dgvMem.Refresh();
                dgvMem.ClearSelection();
            }
        }
        private void NewData()
        {
            dgvMem.ClearSelection();
            txtMemId.Clear();
            txtVIdM.Clear();
            txtMemTypeId.Clear();
            dtpStartM.Value = DateTime.Now;
            dtpEndM.Value = DateTime.Now;
            txtAdultM.Clear();
            txtChildM.Clear();
            txtTranIdM.Clear();
            rbtnYesM.Checked = false;
            rbtnNoM.Checked = false;
        }

        private void btnRefreshV_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();
        }

        private void dgvMem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMemId.Text = dgvMem.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtVIdM.Text = dgvMem.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMemTypeId.Text = dgvMem.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (dgvMem.Rows[e.RowIndex].Cells[3].Value != DBNull.Value)
                {
                    dtpStartM.Value = Convert.ToDateTime(dgvMem.Rows[e.RowIndex].Cells[3].Value);
                }
                else
                {
                    dtpStartM.Value = DateTime.Now;
                }
                if (dgvMem.Rows[e.RowIndex].Cells[4].Value != DBNull.Value)
                {
                    dtpEndM.Value = Convert.ToDateTime(dgvMem.Rows[e.RowIndex].Cells[4].Value);
                }
                else
                {
                    dtpEndM.Value = DateTime.Now;
                }
                txtAdultM.Text = dgvMem.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtChildM.Text = dgvMem.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTranIdM.Text = dgvMem.Rows[e.RowIndex].Cells[7].Value.ToString();
                string isActive = dgvMem.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (isActive == "True")
                {
                    rbtnYesM.Checked = true;
                    rbtnNoM.Checked = false;
                }
                else if (isActive == "False")
                {
                    rbtnNoM.Checked = true;
                    rbtnYesM.Checked = false;
                }
                else
                {
                    rbtnYesM.Checked = false;
                    rbtnNoM.Checked = false;
                }
            }
        }

        private void btnDltV_Click(object sender, EventArgs e)
        {
            string memid = txtMemId.Text;

            if (memid==string.Empty)
            {
                MessageBox.Show("Please select a member to delete.");
                return;
            }
            var result = MessageBox.Show("Are you sure you want to deactivate this membership?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            var query = $"UPDATE Membership SET IsActive = 0 WHERE MembershipID = {memid}";
            if (DataAccess.Execute(query))
            {
                MessageBox.Show("Membership deactivated successfully.");
                this.LoadData();
                this.NewData();
            }
            else
            {
                MessageBox.Show("Failed to deactivate membership.");
            }
        }

        private void txtSearchM_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchM.Text;
            string query;
            if (string.IsNullOrEmpty(searchText))
            {
                this.LoadData();
            }
            else
            {
                query = $@"SELECT 
                    V.VisitorID,
                    V.IsMember,
                    M.MembershipID,
                    M.MembershipTypeID,
                    M.StartDate,
                    M.EndDate,
                    M.Adults,
                    M.Children,
                    M.TransactionID,
                    M.IsActive
                  FROM VisitorDetails V 
                  JOIN Membership M ON V.VisitorID = M.VisitorID
                  WHERE M.MembershipID LIKE '%{searchText}%'";

                var data = DataAccess.GetData(query);
                dgvMem.DataSource = data;
            }
        }
        private void btnNewV_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void btnSaveM_Click(object sender, EventArgs e)
        {
            string memId = txtMemId.Text;
            string vidIn = this.vid;
            string vidUp = txtVIdM.Text;
            string memTypeId = "1";
            DateTime startDate = dtpStartM.Value;
            DateTime endDate = dtpEndM.Value;
            string adults = txtAdultM.Text;
            string child = txtChildM.Text;
            string tranIdUp = txtTranIdM.Text;
            string tranIdIn = "12";
            int isActive = 0;
            if (rbtnYesM.Checked)
            {
                isActive = 1;
            }
            else if (rbtnNoM.Checked)
            {
                isActive = 0;
            }
            if (adults == string.Empty || child == string.Empty)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            if (endDate < DateTime.Today)
            {
                MessageBox.Show("Please select a future date.");
                return;
            }
            if (memId == string.Empty)
            {
                string insert = $@"INSERT INTO Membership 
                (VisitorID, MembershipTypeID, StartDate, EndDate, Adults, Children, TransactionID, IsActive)
                VALUES({vidIn},'{memTypeId}','{startDate.Date}','{endDate.Date}',{adults},{child}, '{tranIdIn}', {isActive})";
                if (DataAccess.Execute(insert))
                {
                    MessageBox.Show("Membership added successfully.");
                    this.LoadData();
                    this.NewData();
                }
                else
                {
                    MessageBox.Show("Failed to add membership.");
                }
            }
            else
            {
               
                string updateQuery = $@"UPDATE Membership SET VisitorID ={vidUp},MembershipTypeID = '{memTypeId}',
                                     StartDate = '{startDate:yyyy-MM-dd}', EndDate = '{endDate:yyyy-MM-dd}',Adults = {adults},
                                     Children = {child},TransactionID = '{tranIdUp}', IsActive = {isActive}
                                     WHERE MembershipID = {memId}";
                if (DataAccess.Execute(updateQuery))
                {
                    MessageBox.Show("Membership updated successfully.");
                    this.LoadData();
                    this.NewData();
                }
                else
                {
                    MessageBox.Show("Failed to update membership.");
                }
            }
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
            AdminOperation adminOperation = new AdminOperation(UserID);
            adminOperation.Show();
            this.Hide();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            adminEventOperation adminEventOperation = new adminEventOperation(UserID);
            adminEventOperation.Show();
            this.Hide();
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
    }
}
            

