using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing; // Added using directive for System.Drawing

namespace TAMS
{
    partial class RegisterTournamentAuction : Form
    {
        private int userId;

        public RegisterTournamentAuction(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            DisplayAuctions();
        }

        private void DisplayAuctions()
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();

            string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";
            string query = "SELECT AuctionID, Name, StartTime, Status FROM Auction WHERE Status = 'Planned'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string auctionId = reader["AuctionID"].ToString();
                    string auctionName = reader["Name"].ToString();
                    string auctionDate = reader["StartTime"].ToString();
                    string auctionStatus = reader["Status"].ToString();

                    tableLayoutPanel.Controls.Add(new Label() { Text = auctionId, AutoSize = true }, 0, tableLayoutPanel.RowCount);
                    tableLayoutPanel.Controls.Add(new Label() { Text = auctionName, AutoSize = true }, 1, tableLayoutPanel.RowCount);
                    tableLayoutPanel.Controls.Add(new Label() { Text = auctionDate, AutoSize = true }, 2, tableLayoutPanel.RowCount);
                    tableLayoutPanel.Controls.Add(new Label() { Text = auctionStatus, AutoSize = true }, 3, tableLayoutPanel.RowCount);

                    tableLayoutPanel.RowCount++;
                }
                reader.Close();
            }
            tableLayoutPanel.Refresh();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string auctionId = auctionIdTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(auctionId))
            {
                string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";
                string checkQuery = "SELECT COUNT(*) FROM Auction WHERE AuctionID = @AuctionID AND Status = 'Planned'";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@AuctionID", auctionId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        string participantInsertQuery = @"
                            INSERT INTO Participants (UserID, RoleID, AuctionID, Status)
                            SELECT UR.UserID, UR.RoleID, @AuctionID, 'Pending'
                            FROM UserRoles UR
                            INNER JOIN Role R ON UR.RoleID = R.RoleID
                            WHERE UR.UserID = @UserID AND R.RoleName IN ('Captain', 'Player', 'Bid Herald')";

                        SqlCommand insertCmd = new SqlCommand(participantInsertQuery, con);
                        insertCmd.Parameters.AddWithValue("@AuctionID", auctionId);
                        insertCmd.Parameters.AddWithValue("@UserID", userId);
                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Data saved successfully.");
                        else
                            MessageBox.Show("No eligible users found or failed to save data.");
                    }
                    else
                    {
                        MessageBox.Show("Auction with the provided ID either does not exist or is not in 'Planned' status.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter an auction ID.");
            }
        }
    }
}
