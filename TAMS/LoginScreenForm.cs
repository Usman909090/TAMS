using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAMS
{
    public partial class LoginScreenForm : Form
    {
        public LoginScreenForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    // Check user credentials and get UserID
                    SqlCommand cmd = new SqlCommand(
                        "SELECT UserID FROM [User] WHERE [Username]=@username AND [Password]=@password", con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = (int)result;
                        // Determine user role
                        int role = DBConnection.GetUserRole(userId);
                        if (role != Constants.ROLE_NOROLE) 
                        {
                            DBConnection.setAuthUserID(userId);
                        }

                        this.Hide();
                        switch (role)
                        {
                            case 1:
                                new BidHeraldDashboard().Show();
                                break;
                            case 2:
                                new CaptainDashboard().Show();
                                break;
                            case 3:
                                new TeamPlayerDashboard().Show();
                                break;
                            case 4:
                                new PlayerDashboard().Show();
                                break;
                            case 5:
                                new UserDashboard().Show();
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

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
