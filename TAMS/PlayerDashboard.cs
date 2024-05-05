using System;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Xml;

namespace TAMS
{
    public partial class PlayerDashboard : Form
    {
        private int _userId;  // The user ID of the logged-in player

        public PlayerDashboard(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadPlayerDetails();
            updateHealthStatusBTN.Click += new EventHandler(UpdateHealthStatus_Click);
            viewAllTeamsBTN.Click += new EventHandler(ViewAllTeams_Click);
        }

        private void LoadPlayerDetails()
        {
            string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Fetch player name and health status
                    SqlCommand cmd = new SqlCommand("SELECT Username, HealthStatus FROM [User] JOIN [Player] ON [User].UserID = [Player].UserID WHERE [User].UserID = @userId", con);
                    cmd.Parameters.AddWithValue("@userId", _userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label2.Text = reader["Username"].ToString();  // Player name
                            label5.Text = reader["HealthStatus"].ToString();  // Health status
                        }
                    }

                    // Fetch team name if available
                    cmd.CommandText = "SELECT TeamName FROM [Team] JOIN [TeamPlayer] ON [Team].TeamID = [TeamPlayer].TeamID WHERE [TeamPlayer].PlayerID = @userId";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label7.Text = reader["TeamName"].ToString();  // Team name
                        }
                        else
                        {
                            label7.Text = "No team assigned";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message);
                }
            }
        }

        private void UpdateHealthStatus_Click(object sender, EventArgs e)
        {
            // Open the health status update form
            UpdateHealthStatus healthStatusForm = new UpdateHealthStatus(_userId);
            healthStatusForm.ShowDialog();
        }

        private void ViewAllTeams_Click(object sender, EventArgs e)
        {
            ViewAllTeams viewAllTeams = new ViewAllTeams();
            viewAllTeams.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterTournamentAuction registerTournamentAuction = new RegisterTournamentAuction();
            registerTournamentAuction.ShowDialog();
        }

    }
}
