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
    public partial class adminEventOperation : Form
    {
        private int userId;
        private int selectedEventId = -1;
        public adminEventOperation(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadEventData();
        }
        private void LoadEventData()
        {
            string query = @"SELECT e.EventID,
                            e.EventName,
                            e.EventDate,
                            e.Location,
                            e.Description,
                            e.MaxCapacity,
                            e.TicketPrice,
                            e.IsActive,
                            e.CreatedDate,
                            u.FullName AS CreatedByName
                            FROM [Event] e
                            INNER JOIN [User] u ON e.CreatedBy = u.UserID
                            ORDER BY e.EventDate DESC, e.EventID DESC";

            try
            {
                DataTable eventData = DataAccess.GetData(query);

                if (eventData != null && eventData.Rows.Count > 0)
                {
                    eventDataGridView.DataSource = eventData;

                    eventDataGridView.DefaultCellStyle.ForeColor = Color.Black;
                    eventDataGridView.DefaultCellStyle.BackColor = Color.White;

                    foreach (DataGridViewRow row in eventDataGridView.Rows)
                    {
                        if (row.Cells["IsActive"].Value != DBNull.Value &&
                            !Convert.ToBoolean(row.Cells["IsActive"].Value))
                        {
                            row.DefaultCellStyle.ForeColor = Color.Gray;
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No events found in the system.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadEventData();
                return;
            }

            string query = $@"SELECT 
                             e.EventID,
                             e.EventName,
                             e.EventDate,
                             e.Location,
                             e.Description,
                             e.MaxCapacity,
                             e.TicketPrice,
                             e.IsActive,
                             e.CreatedDate,
                             u.FullName AS CreatedByName
                             FROM 
                             [Event] e
                             INNER JOIN [User] u ON e.CreatedBy = u.UserID
                             WHERE 
                             CONVERT(VARCHAR, e.EventID) LIKE '%{searchTerm.Replace("'", "''")}%' OR
                             e.EventName LIKE '%{searchTerm.Replace("'", "''")}%' OR
                             CONVERT(VARCHAR, e.TicketPrice) LIKE '%{searchTerm.Replace("'", "''")}%' OR
                             CONVERT(VARCHAR, e.MaxCapacity) LIKE '%{searchTerm.Replace("'", "''")}%' OR
                             e.Description LIKE '%{searchTerm.Replace("'", "''")}%' OR
                             u.FullName LIKE '%{searchTerm.Replace("'", "''")}%' OR
                             e.Location LIKE '%{searchTerm.Replace("'", "''")}%'
                             ORDER BY 
                             e.EventDate DESC, e.EventID DESC";

            try
            {
                DataTable searchResults = DataAccess.GetData(query);

                if (searchResults != null && searchResults.Rows.Count > 0)
                {
                    eventDataGridView.DataSource = searchResults;

                    eventDataGridView.DefaultCellStyle.ForeColor = Color.Black;
                    eventDataGridView.DefaultCellStyle.BackColor = Color.White;

                    foreach (DataGridViewRow row in eventDataGridView.Rows)
                    {
                        if (row.Cells["IsActive"].Value != DBNull.Value &&
                            !Convert.ToBoolean(row.Cells["IsActive"].Value))
                        {
                            row.DefaultCellStyle.ForeColor = Color.Gray;
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                        }
                    }
                }
                else
                {
                    eventDataGridView.DataSource = searchResults;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching events: " + ex.Message);
            }
        }

        private void eventName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void email1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxCapacity1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ticketPrice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ed1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void description1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (selectedEventId == -1)
            {
                MessageBox.Show("Please select an event to update first!");
                return;
            }

            if (string.IsNullOrWhiteSpace(eventName1.Text))
            {
                MessageBox.Show("Event name is required!");
                return;
            }

            if (string.IsNullOrWhiteSpace(location1.Text))
            {
                MessageBox.Show("Event location is required!");
                return;
            }

            if (string.IsNullOrWhiteSpace(description1.Text))
            {
                MessageBox.Show("Event description is required!");
                return;
            }

            if (ed1.Value < DateTime.Now)
            {
                MessageBox.Show("Event date must be in the future!");
                return;
            }

            string eventName = eventName1.Text.Trim();
            DateTime eventDate = ed1.Value;
            string location = location1.Text.Trim();
            string description = description1.Text.Trim();

            if (!int.TryParse(maxCapacity1.Text, out int maxCapacity) || maxCapacity <= 0)
            {
                MessageBox.Show("Please enter a valid maximum capacity!");
                return;
            }

            if (!decimal.TryParse(ticketPrice1.Text, out decimal ticketPrice) || ticketPrice < 0)
            {
                MessageBox.Show("Please enter a valid ticket price!");
                return;
            }

            string updateQuery = $@"UPDATE [Event] SET
                                  EventName = '{eventName.Replace("'", "''")}',
                                  EventDate = '{eventDate.ToString("yyyy-MM-dd HH:mm")}',
                                  Location = '{location.Replace("'", "''")}',
                                  Description = '{description.Replace("'", "''")}',
                                  MaxCapacity = {maxCapacity},
                                  TicketPrice = {ticketPrice}
                                  WHERE EventID = {selectedEventId}";

            bool isUpdated = DataAccess.Execute(updateQuery);

            if (isUpdated)
            {
                MessageBox.Show("Event updated successfully!");
                ClearForm();
                LoadEventData();
                selectedEventId = -1;
            }
            else
            {
                MessageBox.Show("Failed to update event.");
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(eventName1.Text))
            {
                MessageBox.Show("Event name is required!");
                return;
            }

            if (string.IsNullOrWhiteSpace(location1.Text))
            {
                MessageBox.Show("Event location is required!");
                location1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(description1.Text))
            {
                MessageBox.Show("Event description is required!");
                description1.Focus();
                return;
            }
            if (ed1.Value < DateTime.Now)
            {
                MessageBox.Show("Event date must be in the future!");
                return;
            }

            string eventName = eventName1.Text.Trim();
            DateTime eventDate = ed1.Value;
            string location = location1.Text.Trim();
            string description = description1.Text.Trim();

            if (!int.TryParse(maxCapacity1.Text, out int maxCapacity) || maxCapacity <= 0)
            {
                MessageBox.Show("Please enter a valid maximum capacity!");
                return;
            }

            if (!decimal.TryParse(ticketPrice1.Text, out decimal ticketPrice) || ticketPrice < 0)
            {
                MessageBox.Show("Please enter a valid ticket price!");
                return;
            }

            string insertQuery = $@"INSERT INTO [Event] (
                                  EventName,
                                  EventDate,
                                  Location,
                                  Description,
                                  MaxCapacity,
                                  TicketPrice,
                                  IsActive,
                                  CreatedBy
           
                                  ) VALUES (
                                  '{eventName.Replace("'", "''")}',
                                  '{eventDate.ToString("yyyy-MM-dd HH:mm")}',
                                  '{location.Replace("'", "''")}',
                                  '{description.Replace("'", "''")}',
                                   {maxCapacity},{ticketPrice},1,{userId})";

            bool isInserted = DataAccess.Execute(insertQuery);

            if (isInserted)
            {
                MessageBox.Show("Event created successfully!");
                refreshButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Failed to create event.");
            }
        }

        private void ClearForm()
        {
            eventName1.Text = "";
            location1.Text = "";
            description1.Text = "";
            maxCapacity1.Text = "";
            ticketPrice1.Text = "";
            ed1.Value = DateTime.Now.AddDays(7);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedEventId == -1)
            {
                MessageBox.Show("Please select an event to delete first!");
                return;
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this event? This cannot be undone!", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                string deleteQuery = $"DELETE FROM [Event] WHERE EventID = {selectedEventId}";
                bool isDeleted = DataAccess.Execute(deleteQuery);

                if (isDeleted)
                {
                    MessageBox.Show("Event deleted successfully!");
                    ClearForm();
                    LoadEventData();
                    selectedEventId = -1;
                }
                else
                {
                    MessageBox.Show("Failed to delete event.");
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadEventData();
            ClearForm();
            selectedEventId = -1;
        }

        private void eventDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = eventDataGridView.Rows[e.RowIndex];
                selectedEventId = Convert.ToInt32(row.Cells["EventID"].Value);

                eventName1.Text = row.Cells["eventName"].Value.ToString();
                location1.Text = row.Cells["location"].Value.ToString();
                description1.Text = row.Cells["description"].Value.ToString();
                maxCapacity1.Text = row.Cells["maxCapacity"].Value.ToString();
                ticketPrice1.Text = row.Cells["ticketPrice"].Value.ToString();

                if (DateTime.TryParse(row.Cells["eventDate"].Value.ToString(), out DateTime eventDate))
                {
                    ed1.Value = eventDate;
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchTextBox1_TextChanged(object sender, EventArgs e)
        {
            searchButton_Click(sender, e);
        }
    }
}
