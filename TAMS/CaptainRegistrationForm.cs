using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAMS
{
    public partial class CaptainRegistrationForm : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True;";

        public CaptainRegistrationForm()
        {
            InitializeComponent();
            submitButton.Click += SubmitButton_Click;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        int teamId = CreateTeam(con, transaction);

                        int captainId = CreateCaptain(con, transaction, teamId);

                        transaction.Commit();
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Registration failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CreateTeam(SqlConnection con, SqlTransaction transaction)
        {
            string teamInsertQuery = "INSERT INTO Team (TeamName, TeamStatus) VALUES (@TeamName, @TeamStatus); SELECT SCOPE_IDENTITY();";
            SqlCommand teamInsertCommand = new SqlCommand(teamInsertQuery, con, transaction);
            teamInsertCommand.Parameters.AddWithValue("@TeamName", teamName.Text);
            teamInsertCommand.Parameters.AddWithValue("@TeamStatus", teamStatus.SelectedItem.ToString());
            return Convert.ToInt32(teamInsertCommand.ExecuteScalar());
        }

        private int CreateCaptain(SqlConnection con, SqlTransaction transaction, int teamId)
        {
            int userId = CreateUser(con, transaction);

            string captainInsertQuery = "INSERT INTO Captain (UserID, TeamManagedID) OUTPUT INSERTED.UserID VALUES (@UserId, @TeamId)";
            SqlCommand captainInsertCommand = new SqlCommand(captainInsertQuery, con, transaction);
            captainInsertCommand.Parameters.AddWithValue("@UserId", userId);
            captainInsertCommand.Parameters.AddWithValue("@TeamId", teamId);
            return (int)captainInsertCommand.ExecuteScalar();
        }

        private int CreateUser(SqlConnection con, SqlTransaction transaction)
        {
            string userInsertQuery = "INSERT INTO [User] (Username, Email, Password) OUTPUT INSERTED.UserID VALUES (@Username, @Email, @Password)";
            SqlCommand userInsertCommand = new SqlCommand(userInsertQuery, con, transaction);
            userInsertCommand.Parameters.AddWithValue("@Username", name.Text);
            userInsertCommand.Parameters.AddWithValue("@Email", email.Text);
            userInsertCommand.Parameters.AddWithValue("@Password", password.Text);
            return (int)userInsertCommand.ExecuteScalar();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(password.Text) || string.IsNullOrWhiteSpace(teamName.Text) ||
                teamStatus.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
