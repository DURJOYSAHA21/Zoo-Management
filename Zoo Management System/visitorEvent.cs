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
    public partial class visitorEvent : Form
    {
        private int userId;
        public visitorEvent(int userId)
        {
            InitializeComponent();
            LoadEventData();
            this.userId = userId;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            visitorHome homeForm = new visitorHome(userId);
            homeForm.Show();
            this.Close();
        }
        private void LoadEventData()
        {
            string query = @"SELECT 
                            e.EventID,
                            e.EventName,
                            e.EventDate,
                            e.Location,
                            e.Description,
                            e.MaxCapacity,
                            e.TicketPrice,
                            e.CreatedDate,
                            u.FullName AS CreatedByName
                            FROM [Event] e
                            INNER JOIN [User] u ON e.CreatedBy = u.UserID
                            WHERE e.IsActive = 1
                            ORDER BY e.EventDate DESC";

            try
            {
                DataTable eventData = DataAccess.GetData(query);

                if (eventData != null && eventData.Rows.Count > 0)
                {
                    eventDataGridView.DataSource = eventData;
                }
                else
                {
                    MessageBox.Show("No active events found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message);
            }
        }
        private void eventDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
