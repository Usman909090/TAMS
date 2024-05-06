using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAMS
{
    partial class ViewMyTeam : Form
    {
        public ViewMyTeam(int captainId)
        {
            InitializeComponent();
            DisplayMyTeam(captainId);
        }

        private void DisplayMyTeam(int captainId)
        {
            // Clear existing controls to prevent duplication
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();

            string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";

    

            // Query to fetch team names, player names, and health status
            string query = "SELECT Team.TeamName, [User].Username AS PlayerName, Player.HealthStatus " +
                           "FROM Team " +
                           "INNER JOIN Captain ON Team.TeamID = Captain.TeamManagedID " +
                           "INNER JOIN TeamPlayer ON Team.TeamID = TeamPlayer.TeamID " +
                           "INNER JOIN [User] ON TeamPlayer.PlayerID = [User].UserID " +
                           "LEFT JOIN Player ON [User].UserID = Player.UserID " +
                           "WHERE Captain.UserID = @captainId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@captainId", captainId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    string currentTeamName = "";
                    TableLayoutPanel currentPlayerTable = null;
                    int playerCounter = 0;

                    while (reader.Read())
                    {
                        string teamName = reader["TeamName"].ToString();
                        string playerName = reader["PlayerName"].ToString();
                        string healthStatus = reader["HealthStatus"].ToString();

                        // If team name changes, create a new player table
                        if (teamName != currentTeamName)
                        {
                            currentTeamName = teamName;

                            // Add team label
                            Label teamLabel = new Label();
                            teamLabel.AutoSize = true;
                            teamLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                            teamLabel.Text = teamName;
                            tableLayoutPanel.Controls.Add(teamLabel);
                            tableLayoutPanel.SetColumnSpan(teamLabel, 3); // Ensure label spans all columns

                            // Create a new player table
                            currentPlayerTable = new TableLayoutPanel();
                            currentPlayerTable.AutoSize = true;
                            currentPlayerTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                            currentPlayerTable.ColumnCount = 4; // Adjusted for health status column
                            currentPlayerTable.RowCount = 11; // One row for headers, plus one for each player
                            currentPlayerTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single; // Set cell border style
                            currentPlayerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                            currentPlayerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                            currentPlayerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                            currentPlayerTable.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Row style for headers

                            // Adding column headers
                            Label counterLabel = new Label() { Text = "Counter", AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10F, FontStyle.Bold) };
                            Label playerNameLabel = new Label() { Text = "Player Name", AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10F, FontStyle.Bold) };
                            Label healthStatusLabel = new Label() { Text = "Health Status", AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10F, FontStyle.Bold) };
                            currentPlayerTable.Controls.Add(counterLabel, 0, 0);
                            currentPlayerTable.Controls.Add(playerNameLabel, 1, 0);
                            currentPlayerTable.Controls.Add(healthStatusLabel, 2, 0);
                            // You can add more columns here if needed
                            currentPlayerTable.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Row style for headers

                            // Add player table to tableLayoutPanel
                            tableLayoutPanel.Controls.Add(currentPlayerTable);
                            tableLayoutPanel.SetColumnSpan(currentPlayerTable, 4); // Ensure table spans all columns

                            playerCounter = 0; // Reset player counter for the new team
                        }

                        playerCounter++;
                        // Add player data to the current player table
                        currentPlayerTable.Controls.Add(new Label() { Text = playerCounter.ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter }, 0, playerCounter);
                        currentPlayerTable.Controls.Add(new Label() { Text = playerName, AutoSize = true, TextAlign = ContentAlignment.MiddleCenter }, 1, playerCounter);
                        currentPlayerTable.Controls.Add(new Label() { Text = healthStatus, AutoSize = true, TextAlign = ContentAlignment.MiddleCenter }, 2, playerCounter);
                        // You can add more columns here if needed
                        currentPlayerTable.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Row style for each player
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching team and player data: " + ex.Message);
                }
            }

            // Refresh the panel to update the UI
            tableLayoutPanel.Refresh();
        }
    }
}
