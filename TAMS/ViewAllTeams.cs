

//using System;
//using System.Windows.Forms;

//namespace TAMS
//{
//    partial class ViewAllTeams : Form
//    {
//        // Constructor and InitializeComponent method remain unchanged

//        private void DisplayTeamsAndPlayers()
//        {
//            // Clear existing controls to prevent duplication
//            tableLayoutPanel.Controls.Clear();
//            tableLayoutPanel.RowStyles.Clear();

//            string[] teamNames = { "Team A", "Team B", "Team C" };
//            string[,] playerData = {
//        {"Player 1", "Player 2", "Player 3", "Player 4", "Player 5", "Player 6", "Player 7", "Player 8", "Player 9", "Player 10"},
//        {"Player 11", "Player 12", "Player 13", "Player 14", "Player 15", "Player 16", "Player 17", "Player 18", "Player 19", "Player 20"},
//        {"Player 21", "Player 22", "Player 23", "Player 24", "Player 25", "Player 26", "Player 27", "Player 28", "Player 29", "Player 30"}
//    };

//            for (int i = 0; i < teamNames.Length; i++)
//            {
//                Label teamLabel = new Label();
//                teamLabel.AutoSize = true;
//                teamLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//                teamLabel.Text = teamNames[i];
//                tableLayoutPanel.Controls.Add(teamLabel);
//                tableLayoutPanel.SetColumnSpan(teamLabel, 3);  // Ensure label spans all columns

//                TableLayoutPanel playerTable = new TableLayoutPanel();
//                playerTable.AutoSize = true;
//                playerTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
//                playerTable.ColumnCount = 3;
//                playerTable.RowCount = 11;  // One row for headers, plus one for each player
//                playerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
//                playerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
//                playerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
//                playerTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));  // Row style for headers

//                // Adding column headers
//                playerTable.Controls.Add(new Label() { Text = "Counter", AutoSize = true, TextAlign = ContentAlignment.MiddleCenter }, 0, 0);
//                playerTable.Controls.Add(new Label() { Text = "Name", AutoSize = true, TextAlign = ContentAlignment.MiddleCenter }, 1, 0);
//                playerTable.Controls.Add(new Label() { Text = "Bidding Price", AutoSize = true, TextAlign = ContentAlignment.MiddleCenter }, 2, 0);

//                for (int j = 0; j < 10; j++)  // Ensure you are looping over all 10 players
//                {
//                    int counter = j + 1;  // Correct the counter to start from 1
//                    playerTable.Controls.Add(new Label() { Text = counter.ToString(), AutoSize = true }, 0, counter);
//                    playerTable.Controls.Add(new Label() { Text = playerData[i, j], AutoSize = true }, 1, counter);
//                    playerTable.Controls.Add(new Label() { Text = (counter * 1000).ToString(), AutoSize = true }, 2, counter);
//                    playerTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));  // Row style for each player
//                }

//                tableLayoutPanel.Controls.Add(playerTable);
//                tableLayoutPanel.SetColumnSpan(playerTable, 3);  // Ensure table spans all columns
//            }

//            // Refresh the panel to update the UI
//            tableLayoutPanel.Refresh();
//        }


//    }
//}





using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAMS
{
    partial class ViewAllTeams : Form
    {
        // Constructor and InitializeComponent method remain unchanged

        private void DisplayTeamsAndPlayers()
        {
            // Clear existing controls to prevent duplication
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();

            string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";

            // Query to fetch team names, player names, and health status
            string query = "SELECT Team.TeamName, [User].Username AS PlayerName, Player.HealthStatus " +
                           "FROM Team " +
                           "INNER JOIN TeamPlayer ON Team.TeamID = TeamPlayer.TeamID " +
                           "INNER JOIN [User] ON TeamPlayer.PlayerID = [User].UserID " +
                           "LEFT JOIN Player ON [User].UserID = Player.UserID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    string currentTeamName = "";
                    TableLayoutPanel currentPlayerTable = null;
                    int playerCounter = 0;

                    while (reader.Read())
                    {
                        string teamName = reader["TeamName"].ToString();
                        string playerName = reader["PlayerName"].ToString();

                        // If team name changes, create a new player table
                        if (teamName != currentTeamName)
                        {
                            currentTeamName = teamName;

                            // Add team label
                            Label teamLabel = new Label();
                            teamLabel.AutoSize = true;
                            teamLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                            teamLabel.Text = teamName;
                            tableLayoutPanel.Controls.Add(teamLabel);
                            tableLayoutPanel.SetColumnSpan(teamLabel, 2); // Ensure label spans all columns

                            // Create a new player table
                            currentPlayerTable = new TableLayoutPanel();
                            currentPlayerTable.AutoSize = true;
                            currentPlayerTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                            currentPlayerTable.ColumnCount = 4; // Adjusted for health status column
                            currentPlayerTable.RowCount = 11; // One row for headers, plus one for each player
                            currentPlayerTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single; // Set cell border style
                            currentPlayerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                            currentPlayerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                            currentPlayerTable.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Row style for headers


                            // Adding column headers
                            Label counterLabel = new Label() { Text = "Counter", AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point) };
                            Label playerNameLabel = new Label() { Text = "Player Name", AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point) };
                    
                            currentPlayerTable.Controls.Add(counterLabel, 0, 0);
                            currentPlayerTable.Controls.Add(playerNameLabel, 1, 0);
                           
                            // You can add more columns here if needed
                            currentPlayerTable.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Row style for headers

                            // Add player table to tableLayoutPanel
                            tableLayoutPanel.Controls.Add(currentPlayerTable);
                            tableLayoutPanel.SetColumnSpan(currentPlayerTable, 4); // Ensure table spans all columns

                            playerCounter = 0; // Reset player counter for the new team
                        }

                        playerCounter++;
                        // Add player data to the current player table
                        currentPlayerTable.Controls.Add(new Label() { Text = playerCounter.ToString(), AutoSize = true }, 0, playerCounter);
                        currentPlayerTable.Controls.Add(new Label() { Text = playerName, AutoSize = true }, 1, playerCounter);
                        
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
