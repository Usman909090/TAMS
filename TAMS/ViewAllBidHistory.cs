using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAMS
{
    partial class ViewAllBidHistory : Form
    {
        public ViewAllBidHistory()
        {
            InitializeComponent();
            DisplayAllBidHistory();
        }

        private void DisplayAllBidHistory()
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();

            string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";

            string query = @"
                SELECT Auction.AuctionID, Bid.Amount, Bid.BidTime, [User].Username AS PlayerName, [User].Username AS CaptainName
                FROM Bid
                INNER JOIN Auction ON Bid.AuctionID = Auction.AuctionID
                INNER JOIN [User] ON Bid.PlayerID = [User].UserID
                ORDER BY Bid.BidTime DESC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int rowIndex = 0;
                while (reader.Read())
                {
                    var auctionID = reader["AuctionID"].ToString();
                    var playerName = reader["PlayerName"].ToString();
                    var captainName = reader["CaptainName"].ToString();
                    var bidAmount = reader["Amount"].ToString();
                    var bidTime = ((DateTime)reader["BidTime"]).ToString("g");

                    if (rowIndex == 0) // Adding headers once
                    {
                        AddTableRow("Auction ID", "Player Name", "Captain Name", "Bid Amount", "Bid Time", true);
                    }

                    // Adding data rows
                    AddTableRow(auctionID, playerName, captainName, bidAmount, bidTime, false);
                    rowIndex++;
                }
            }
        }

        private void AddTableRow(string col1, string col2, string col3, string col4, string col5, bool isHeader)
        {
            int rowNumber = tableLayoutPanel.RowCount++;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            FontStyle fontStyle = isHeader ? FontStyle.Bold : FontStyle.Regular;

            tableLayoutPanel.Controls.Add(new Label { Text = col1, AutoSize = true, Font = DefaultFont }, 0, rowNumber);
            tableLayoutPanel.Controls.Add(new Label { Text = col2, AutoSize = true, Font = DefaultFont }, 1, rowNumber);
            tableLayoutPanel.Controls.Add(new Label { Text = col3, AutoSize = true, Font = DefaultFont }, 2, rowNumber);
            tableLayoutPanel.Controls.Add(new Label { Text = col4, AutoSize = true, Font = DefaultFont }, 3, rowNumber);
            tableLayoutPanel.Controls.Add(new Label { Text = col5, AutoSize = true, Font = DefaultFont }, 4, rowNumber);
        }
    }
}
