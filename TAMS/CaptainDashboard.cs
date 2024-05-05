using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAMS
{
    public partial class CaptainDashboard : Form
    {
        private int userId;
        public CaptainDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Store the user ID passed from the login form
            DisplayCaptainDetails(); // Call a method to display captain details
        }

        private void InitForm()
        {
            this.Text = "Captain Dashboard";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CaptainDashboard";
            // Additional controls and functionalities can be added here
        }
        private void viewAllTeamsBTN_Click(object sender, EventArgs e)
        {
            // Create an instance of the ViewAllTeams form
            ViewAllTeams viewAllTeamsForm = new ViewAllTeams();

            // Show the ViewAllTeams form
            viewAllTeamsForm.Show();

            // Optionally, you can hide the current form if needed
            // this.Hide();
        }

        private void DisplayCaptainDetails()
        {
            string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";

            // Query to fetch captain's name and team name
            string query = "SELECT U.Username AS CaptainName, T.TeamName " +
                           "FROM [User] U " +
                           "JOIN Captain C ON U.UserID = C.UserID " +
                           "LEFT JOIN Team T ON C.TeamManagedID = T.TeamID " +
                           "WHERE U.UserID = @userId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Display captain's name and team name in labels
                        label9.Text = reader["CaptainName"].ToString();
                        label2.Text = reader["TeamName"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Captain details not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching captain details: " + ex.Message);
                }
            }
        }

        private void viewCaptainTeamBTN_Click(object sender, EventArgs e)
        {
            // Create an instance of the ViewAllTeams form
            ViewMyTeam viewMyTeamForm = new ViewMyTeam(userId);

            // Show the ViewAllTeams form
            viewMyTeamForm.Show();

            // Optionally, you can hide the current form if needed
            // this.Hide();
        }

        private void viewBidHistoryBTN_Click(object sender, EventArgs e)
        {
            ViewBidHistory viewBidHistory = new ViewBidHistory(userId);
            viewBidHistory.Show();
        }

        private void registerForTournamentBTN_Click(object sender, EventArgs e)
        {
            RegisterTournamentAuction registerTournamentAuction = new RegisterTournamentAuction(userId);
            registerTournamentAuction.Show();
        }

        private void enterAuctionHouseBTN_Click(object sender, EventArgs e)
        {
            AuctionHouseForm auctionHouseForm = new AuctionHouseForm(userId);
            auctionHouseForm.Show();
        }
    }
}
