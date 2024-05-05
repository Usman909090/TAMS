using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAMS
{
    partial class ManageParticipantsRequests : Form
    {
        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanel;
        private Label titleLabel;

        private string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";

        public ManageParticipantsRequests()
        {
            InitializeComponent();
            DisplayParticipantRequests();
        }

        private void DisplayParticipantRequests()
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();

            string query = "SELECT UserID, RoleID, AuctionID, Status FROM Participants WHERE Status = 'Pending'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string userId = reader["UserID"].ToString();
                    string roleId = reader["RoleID"].ToString();
                    string auctionId = reader["AuctionID"].ToString();
                    string status = reader["Status"].ToString();

                    tableLayoutPanel.Controls.Add(new Label() { Text = userId, AutoSize = true }, 0, tableLayoutPanel.RowCount);
                    tableLayoutPanel.Controls.Add(new Label() { Text = roleId, AutoSize = true }, 1, tableLayoutPanel.RowCount);
                    tableLayoutPanel.Controls.Add(new Label() { Text = auctionId, AutoSize = true }, 2, tableLayoutPanel.RowCount);
                    tableLayoutPanel.Controls.Add(new Label() { Text = status, AutoSize = true }, 3, tableLayoutPanel.RowCount);
                    tableLayoutPanel.Controls.Add(new Button() { Text = "Approve", AutoSize = true }, 4, tableLayoutPanel.RowCount);
                    tableLayoutPanel.Controls.Add(new Button() { Text = "Cancel", AutoSize = true }, 5, tableLayoutPanel.RowCount);

                    // Assign event handlers to the buttons
                    tableLayoutPanel.GetControlFromPosition(4, tableLayoutPanel.RowCount).Click += (sender, e) => ApproveButton_Click(sender, e, userId, auctionId);
                    tableLayoutPanel.GetControlFromPosition(5, tableLayoutPanel.RowCount).Click += (sender, e) => CancelButton_Click(sender, e, userId, auctionId);

                    tableLayoutPanel.RowCount++; // Move to the next row
                }

                reader.Close();
            }

            tableLayoutPanel.Refresh();
        }

        private void ApproveButton_Click(object sender, EventArgs e, string userId, string auctionId)
        {
            UpdateParticipantStatus(userId, auctionId, "Approved");
            DisplayParticipantRequests();
        }

        private void CancelButton_Click(object sender, EventArgs e, string userId, string auctionId)
        {
            UpdateParticipantStatus(userId, auctionId, "Cancelled");
            DisplayParticipantRequests();
        }

        private void UpdateParticipantStatus(string userId, string auctionId, string status)
        {
            string updateQuery = "UPDATE Participants SET Status = @Status WHERE UserID = @UserID AND AuctionID = @AuctionID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@AuctionID", auctionId);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Participant status updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update participant status.");
                }
            }
        }
    }
}
