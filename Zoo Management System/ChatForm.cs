using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class ChatForm : Form
    {
        private int UserID;
        private int lastMessageCount = 0;

        public ChatForm()
        {
            InitializeComponent();
        }

        public void SetUserID(int userId)
        {
            UserID = userId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 second
            timer1.Enabled = true;
        }

        private void cmbEmployee_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lastMessageCount = 0;
            LoadChat();
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastMessageCount = 0;
            LoadChat();
        }

        private bool GetReceiverID(out int receiverId)
        {
            receiverId = 0;
            return lstUser.SelectedValue != null &&
                   int.TryParse(lstUser.SelectedValue.ToString(), out receiverId);
        }

        private void LoadChat()
        {
            try
            {
                if (!GetReceiverID(out int receiverId))
                    return;

                var dt = DataAccess.GetData($@"
                    SELECT SenderID, Message, ReceiverID, SentAt 
                    FROM Chat 
                    WHERE (SenderID = {UserID} AND ReceiverID = {receiverId}) 
                       OR (SenderID = {receiverId} AND ReceiverID = {UserID}) 
                    ORDER BY SentAt");

                if (dt.Rows.Count == lastMessageCount)
                    return;

                lastMessageCount = dt.Rows.Count;

                DataAccess.Execute($@"
                    UPDATE Chat 
                    SET IsRead = 1 
                    WHERE ReceiverID = {UserID} AND SenderID = {receiverId} AND IsRead = 0");

                string receiverName = DataAccess
                    .GetData($"SELECT FullName FROM [User] WHERE UserID = {receiverId}")
                    .Rows[0]["FullName"].ToString();

                rTxtChatTab.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int senderID = Convert.ToInt32(row["SenderID"]);
                    string message = row["Message"].ToString();

                    if (senderID == UserID)
                        rTxtChatTab.AppendText($"You: {message}\r\n");
                    else
                        rTxtChatTab.AppendText($"{receiverName}: {message}\r\n");
                }

                ScrollToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chat: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(message)) return;

            if (!GetReceiverID(out int receiverId))
            {
                MessageBox.Show("Please select a valid employee to chat with.");
                return;
            }

            string query = $"INSERT INTO Chat (SenderID, ReceiverID, Message) VALUES ({UserID}, {receiverId}, '{message}')";
            bool result = DataAccess.Execute(query);

            if (result)
            {
                txtInput.Clear();
                lastMessageCount = 0;
                LoadChat();
            }
            else
            {
                MessageBox.Show("Failed to send message.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText)) return;

            if (!GetReceiverID(out int receiverId)) return;

            var dt = DataAccess.GetData($@"
                SELECT SenderID, Message, ReceiverID 
                FROM Chat 
                WHERE ((SenderID = {UserID} AND ReceiverID = {receiverId}) 
                    OR (SenderID = {receiverId} AND ReceiverID = {UserID})) 
                  AND Message LIKE '%{searchText}%'
                ORDER BY SentAt");

            string receiverName = DataAccess
                .GetData($"SELECT FullName FROM [User] WHERE UserID = {receiverId}")
                .Rows[0]["FullName"].ToString();

            rTxtChatTab.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int senderID = Convert.ToInt32(row["SenderID"]);
                string message = row["Message"].ToString();
                rTxtChatTab.AppendText(senderID == UserID ? $"You: {message}\r\n" : $"{receiverName}: {message}\r\n");
            }

            ScrollToEnd();
            lastMessageCount = dt.Rows.Count;
        }

        private void ScrollToEnd()
        {
            rTxtChatTab.SelectionStart = rTxtChatTab.Text.Length;
            rTxtChatTab.ScrollToCaret();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadChat();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            LoadUsersByEmployeeType("Doctor");
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            LoadUsersByEmployeeType("Staff");
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            LoadUsersByEmployeeType("Manager");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var dt = DataAccess.GetData($"SELECT FullName, UserID FROM [User] WHERE RoleID = 1 AND UserID <> {UserID}");
            lstUser.DataSource = dt;
            lstUser.DisplayMember = "FullName";
            lstUser.ValueMember = "UserID";
        }

        private void LoadUsersByEmployeeType(string type)
        {
            var dt = DataAccess.GetData($@"
                SELECT U.FullName, U.UserID 
                FROM [User] U 
                JOIN EmployeeDetails E ON E.EmployeeID = U.UserID 
                WHERE E.EmployeeType = '{type}' AND U.UserID <> {UserID}");

            lstUser.DataSource = dt;
            lstUser.DisplayMember = "FullName";
            lstUser.ValueMember = "UserID";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Optional: release resources if needed
        }
    }
}