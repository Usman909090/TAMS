//using System;
//using System.Data.SqlClient;
//using System.Windows.Forms;

//namespace TeamDisplayApplication
//{
//    partial class TeamDisplayForm : Form
//    {
//        // Database connection string
//        private const string connectionString = "your_connection_string_here";

//        // Constructor and InitializeComponent method remain unchanged

//        private void DisplayTeamsAndPlayers()
//        {
//            try
//            {
//                using (SqlConnection connection = new SqlConnection(connectionString))
//                {
//                    connection.Open();

//                    string query = "SELECT TeamID, TeamName FROM Team";
//                    SqlCommand command = new SqlCommand(query, connection);

//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            int teamID = reader.GetInt32(0);
//                            string teamName = reader.GetString(1);

//                            Label teamLabel = new Label();
//                            teamLabel.AutoSize = true;
//                            teamLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//                            teamLabel.Text = teamName;

//                            TableLayoutPanel playerTable = new TableLayoutPanel();
//                            playerTable.AutoSize = true;
//                            playerTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
//                            playerTable.ColumnCount = 3;
//                            playerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
//                            playerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
//                            playerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));

//                            // Add columns to the playerTable (Counter, Name, BiddingPrice)
//                            playerTable.Controls.Add(new Label() { Text = "Counter" });
//                            playerTable.Controls.Add(new Label() { Text = "Name" });
//                            playerTable.Controls.Add(new Label() { Text = "Bidding Price" });

//                            query = "SELECT Counter, Username, Amount FROM TeamPlayer " +
//                                    "INNER JOIN User ON TeamPlayer.PlayerID = User.UserID " +
//                                    "INNER JOIN Bid ON TeamPlayer.PlayerID = Bid.PlayerID " +
//                                    "WHERE TeamPlayer.TeamID = @TeamID";
//                            SqlCommand playerCommand = new SqlCommand(query, connection);
//                            playerCommand.Parameters.AddWithValue("@TeamID", teamID);

//                            using (SqlDataReader playerReader = playerCommand.ExecuteReader())
//                            {
//                                int counter = 1;
//                                while (playerReader.Read())
//                                {
//                                    playerTable.Controls.Add(new Label() { Text = counter.ToString() });
//                                    playerTable.Controls.Add(new Label() { Text = playerReader.GetString(1) });
//                                    playerTable.Controls.Add(new Label() { Text = playerReader.GetDecimal(2).ToString() });

//                                    counter++;
//                                }
//                            }

//                            tableLayoutPanel.Controls.Add(teamLabel);
//                            tableLayoutPanel.SetColumnSpan(teamLabel, 3);
//                            tableLayoutPanel.Controls.Add(playerTable);
//                            tableLayoutPanel.SetColumnSpan(playerTable, 3);
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex.Message);
//            }
//        }
//    }
//}


using System;
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

            string[] teamNames = { "Team A", "Team B", "Team C" };
            string[,] playerData = {
        {"Player 1", "Player 2", "Player 3", "Player 4", "Player 5", "Player 6", "Player 7", "Player 8", "Player 9", "Player 10"},
        {"Player 11", "Player 12", "Player 13", "Player 14", "Player 15", "Player 16", "Player 17", "Player 18", "Player 19", "Player 20"},
        {"Player 21", "Player 22", "Player 23", "Player 24", "Player 25", "Player 26", "Player 27", "Player 28", "Player 29", "Player 30"}
    };

            for (int i = 0; i < teamNames.Length; i++)
            {
                Label teamLabel = new Label();
                teamLabel.AutoSize = true;
                teamLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                teamLabel.Text = teamNames[i];
                tableLayoutPanel.Controls.Add(teamLabel);
                tableLayoutPanel.SetColumnSpan(teamLabel, 3);  // Ensure label spans all columns

                TableLayoutPanel playerTable = new TableLayoutPanel();
                playerTable.AutoSize = true;
                playerTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                playerTable.ColumnCount = 3;
                playerTable.RowCount = 11;  // One row for headers, plus one for each player
                playerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
                playerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
                playerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
                playerTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));  // Row style for headers

                // Adding column headers
                playerTable.Controls.Add(new Label() { Text = "Counter", AutoSize = true, TextAlign = ContentAlignment.MiddleCenter }, 0, 0);
                playerTable.Controls.Add(new Label() { Text = "Name", AutoSize = true, TextAlign = ContentAlignment.MiddleCenter }, 1, 0);
                playerTable.Controls.Add(new Label() { Text = "Bidding Price", AutoSize = true, TextAlign = ContentAlignment.MiddleCenter }, 2, 0);

                for (int j = 0; j < 10; j++)  // Ensure you are looping over all 10 players
                {
                    int counter = j + 1;  // Correct the counter to start from 1
                    playerTable.Controls.Add(new Label() { Text = counter.ToString(), AutoSize = true }, 0, counter);
                    playerTable.Controls.Add(new Label() { Text = playerData[i, j], AutoSize = true }, 1, counter);
                    playerTable.Controls.Add(new Label() { Text = (counter * 1000).ToString(), AutoSize = true }, 2, counter);
                    playerTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));  // Row style for each player
                }

                tableLayoutPanel.Controls.Add(playerTable);
                tableLayoutPanel.SetColumnSpan(playerTable, 3);  // Ensure table spans all columns
            }

            // Refresh the panel to update the UI
            tableLayoutPanel.Refresh();
        }


    }
}
