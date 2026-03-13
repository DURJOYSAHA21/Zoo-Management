
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
    public partial class BankCrud : Form
    {
        public BankCrud()
        {
            InitializeComponent();
        }
        int UserID;
        public void SetUserID(int UserID)
        {
            this.UserID = UserID;
        }

        private void BankCrud_Load(object sender, EventArgs e)
        {
             this.LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();
        }
        private void LoadData()
        {
            var query = "SELECT * FROM Bank";
            var data = DataAccess.GetData(query);
            if (data == null)
            {
                MessageBox.Show("No data found in the Bank table.");
            }
            else
            {
                dgvBank.AutoGenerateColumns = false;
                dgvBank.DataSource = data;
                dgvBank.Refresh();
                dgvBank.ClearSelection();
            }
        }

        private void dgvBank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtBankId.Text = dgvBank.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBankName.Text = dgvBank.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSwift.Text = dgvBank.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtBankName.Text;
            string swift = txtSwift.Text;
            string query=string.Empty;
            if (name == string.Empty || swift == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            query = $"INSERT INTO Bank VALUES('{name}','1','{swift}')";
            if (DataAccess.Execute(query))
            {
                MessageBox.Show("Value inserted successfully.");
                this.LoadData();
                this.NewData();
            }
            else
            {
                MessageBox.Show("Failed to insert value.");
            }
        }
        private void NewData()
        {
            dgvBank.ClearSelection();
            txtBankId.Clear();
            txtBankName.Clear();
            txtSwift.Clear();
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            string id = txtBankId.Text;
            if (id==string.Empty)
            {
                MessageBox.Show("Please select a bank to delete.");
                return;
            }
            var result=MessageBox.Show("Are you sure you want to delete this bank?", "Confirmation",MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            var query = $"DELETE FROM Bank WHERE BankId={id}";
            if(DataAccess.Execute(query))
            {
                MessageBox.Show("Bank deleted successfully.");
                this.LoadData();
                this.NewData();
            }
            else
            {
                MessageBox.Show("Failed to delete bank.");
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            string id = txtBankId.Text;
            string name = txtBankName.Text;
            string swift = txtSwift.Text;
            string query = string.Empty;
            if(id==string.Empty||name == string.Empty || swift == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            query = $"UPDATE Bank SET BankName='{name}',IsActive='1', SwiftCode='{swift}' WHERE BankId={id}";
            if(DataAccess.Execute(query))
            {
                MessageBox.Show("Bank updated successfully.");
                this.LoadData();
                this.NewData();
            }
            else
            {
                MessageBox.Show("Failed to update bank.");
            }
        }
    }
}
