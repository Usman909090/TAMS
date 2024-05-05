using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAMS
{
    public partial class BidHeraldDashboard : Form
    {
        private int userId;
        private string userName;

        public BidHeraldDashboard(int userId)
        {
            this.userId = userId;
            InitializeComponent();  // This calls the auto-generated InitializeComponent
            InitForm();  // Custom initialization tasks
            FetchUserName(); // Fetch and assign the username
        }

        private void InitForm()
        {
            this.Text = "Bid Herald Dashboard";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "BidHeraldDashboard";
            // Other initialization code and controls can be added here
        }

        private void FetchUserName()
        {
            string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";

            string query = "SELECT Username FROM [User] WHERE UserID = @UserID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", userId);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userName = result.ToString();
                        // Assign user name to label9
                        label9.Text = userName;
                    }
                    else
                    {
                        // Handle case where user does not exist
                        label9.Text = "Unknown user";
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void viewAllTeamsBTN_Click(object sender, EventArgs e)
        {
            ViewAllTeams viewAllTeams = new ViewAllTeams();
            viewAllTeams.Show();
        }

        private void viewBidHistoryBTN_Click(object sender, EventArgs e)
        {
            ViewAllBidHistory viewBidHistory = new ViewAllBidHistory();
            viewBidHistory.Show();
        }

        private void enterAuctionHouseBTN_Click(object sender, EventArgs e)
        {
            ManageParticipantsRequests manageParticipantsRequests = new ManageParticipantsRequests();
            manageParticipantsRequests.Show();
        }

        private void registerForTournamentBTN_Click(object sender, EventArgs e)
        {
            CreateTournamentAuction createTournamentAuction = new CreateTournamentAuction();
            createTournamentAuction.Show();
        }
    }
}
