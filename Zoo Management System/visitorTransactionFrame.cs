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
    public partial class visitorTransactionFrame : Form
    {

        private int userId;
        public visitorTransactionFrame(int userId)
        {
            InitializeComponent();
            transactionDataGridView.AutoGenerateColumns = false;
            this.userId = userId;
            LoadTransactionHistory();

        }
        private void LoadTransactionHistory()
        {
            string query = $@"SELECT 
                             t.TransactionID ,
                             t.VisitorID,
                             ba.AccountNumber ,
                             t.TransactionDate ,
                             t.Amount,
                             t.PaymentMethod,
                             b.BankName ,
                             t.Description
                             FROM [Transaction] t
                             INNER JOIN BankAccount ba ON t.AccountID = ba.AccountID
                             INNER JOIN Bank b ON ba.BankID = b.BankID
                             WHERE t.VisitorID = {userId}
                             ORDER BY t.TransactionDate DESC, t.TransactionID DESC";

            DataTable transactionData = DataAccess.GetData(query);

            if (transactionData != null && transactionData.Rows.Count > 0)
            {
                transactionDataGridView.DataSource = transactionData;
            }
            else
            {
                MessageBox.Show("No transaction history found.");
            }
        }
        private void transactionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            visitorHome home = new visitorHome(userId);
            home.Show();
            this.Close();
        }
    }
}
