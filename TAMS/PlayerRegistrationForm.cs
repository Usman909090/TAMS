using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAMS
{
    public partial class PlayerRegistrationForm : Form
    {
        public PlayerRegistrationForm()
        {
            InitializeComponent();
            submitButton.Click += SubmitButton_Click;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(password.Text) || healthStatus.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assume connectionString is defined in your configuration or elsewhere
            string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Start a transaction
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        // Insert into User table and get the inserted UserId
                        string userInsertQuery = "INSERT INTO [User] (Username, Email, Password) OUTPUT INSERTED.UserID VALUES (@Username, @Email, @Password)";
                        SqlCommand userInsertCommand = new SqlCommand(userInsertQuery, con, transaction);
                        userInsertCommand.Parameters.AddWithValue("@Username", name.Text);
                        userInsertCommand.Parameters.AddWithValue("@Email", email.Text);
                        userInsertCommand.Parameters.AddWithValue("@Password", password.Text); // Consider hashing the password before saving

                        int userId = (int)userInsertCommand.ExecuteScalar();

                        // Insert into Player table
                        string playerInsertQuery = "INSERT INTO Player (UserID, HealthStatus) VALUES (@UserId, @HealthStatus)";
                        SqlCommand playerInsertCommand = new SqlCommand(playerInsertQuery, con, transaction);
                        playerInsertCommand.Parameters.AddWithValue("@UserId", userId);
                        playerInsertCommand.Parameters.AddWithValue("@HealthStatus", healthStatus.SelectedItem.ToString());

                        playerInsertCommand.ExecuteNonQuery();

                        // Commit transaction
                        transaction.Commit();
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction on error
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
    }
}
