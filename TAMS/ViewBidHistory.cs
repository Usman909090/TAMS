using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAMS
{
    partial class ViewBidHistory : Form
    {
        public ViewBidHistory(int captainId)
        {
            InitializeComponent();
            DisplayBidHistory(captainId);
        }

        private void DisplayBidHistory(int captainId)
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();

            string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";

            string query = @"
                        SELECT a.AuctionID, b.Amount, b.BidTime, u.PlayerName
                        FROM (
                            SELECT AuctionID, Amount, BidTime, PlayerID
                            FROM Bid
                            WHERE CaptainID = @captainId
                        ) AS b
                        INNER JOIN (
                            SELECT AuctionID
                            FROM Auction
                        ) AS a ON b.AuctionID = a.AuctionID
                        INNER JOIN (
                            SELECT UserID, Username AS PlayerName
                            FROM [User]
                        ) AS u ON b.PlayerID = u.UserID
                        ORDER BY b.BidTime DESC";





            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@captainId", captainId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int rowIndex = 0;
                while (reader.Read())
                {
                    var auctionID = reader["AuctionID"].ToString();
                    var playerName = reader["PlayerName"].ToString();
                    var bidAmount = reader["Amount"].ToString();
                    var bidTime = ((DateTime)reader["BidTime"]).ToString("g");

                    if (rowIndex == 0) // Adding headers once
                    {
                        AddTableRow("Auction ID", "Player Name", "Bid Amount", "Bid Time", true);
                    }

                    // Adding data rows
                    AddTableRow(auctionID, playerName, bidAmount, bidTime, false);
                    rowIndex++;
                }
            }
        }

        private void AddTableRow(string col1, string col2, string col3, string col4, bool isHeader)
        {
            int rowNumber = tableLayoutPanel.RowCount++;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            FontStyle fontStyle = isHeader ? FontStyle.Bold : FontStyle.Regular;

            tableLayoutPanel.Controls.Add(new Label { Text = col1, AutoSize = true, Font = new Font("Segoe UI", 10F, fontStyle) }, 0, rowNumber);
            tableLayoutPanel.Controls.Add(new Label { Text = col2, AutoSize = true, Font = new Font("Segoe UI", 10F, fontStyle) }, 1, rowNumber);
            tableLayoutPanel.Controls.Add(new Label { Text = col3, AutoSize = true, Font = new Font("Segoe UI", 10F, fontStyle) }, 2, rowNumber);
            tableLayoutPanel.Controls.Add(new Label { Text = col4, AutoSize = true, Font = new Font("Segoe UI", 10F, fontStyle) }, 3, rowNumber);
        }
    }
}
