using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAMS
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Check user credentials and get UserID
                    SqlCommand cmd = new SqlCommand(
                        "SELECT UserID FROM [User] WHERE Email=@username AND Password=@password", con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int userId = (int)result;
                        // Determine user role
                        string role = GetUserRole(userId, con);

                        this.Hide();
                        switch (role)
                        {
                            case "BidHerald":
                                new BidHeraldDashboard(userId).Show();
                                break;
                            case "Captain":
                                new CaptainDashboard(userId).Show();
                                break;
                            case "Player":
                                new PlayerDashboard(userId).Show();
                                break;
                            default:
                                MessageBox.Show("No valid role found for this user.");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message);
                }
            }
        }

        private string GetUserRole(int userId, SqlConnection con)
        {
            // Check each role table to find where the UserID is present
            string checkBidHerald = "SELECT COUNT(1) FROM [BidHerald] WHERE UserID = @userId";
            string checkCaptain = "SELECT COUNT(1) FROM [Captain] WHERE UserID = @userId";
            string checkPlayer = "SELECT COUNT(1) FROM [Player] WHERE UserID = @userId";

            SqlCommand cmd = new SqlCommand(checkBidHerald, con);
            cmd.Parameters.AddWithValue("@userId", userId);
            if ((int)cmd.ExecuteScalar() > 0)
                return "BidHerald";

            cmd.CommandText = checkCaptain;
            if ((int)cmd.ExecuteScalar() > 0)
                return "Captain";

            cmd.CommandText = checkPlayer;
            if ((int)cmd.ExecuteScalar() > 0)
                return "Player";

            return null;  // No role found
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            RegistrationScreen registrationScreen = new RegistrationScreen();
            registrationScreen.Show();
        }
    }
}
