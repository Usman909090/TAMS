using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAMS
{
    public partial class UpdateHealthStatus : Form
    {
        private int _userId;

        public UpdateHealthStatus(int userId)
        {
            InitializeComponent();
            _userId = userId;
            button2.Click += new EventHandler(UpdateHealthStatus_Click);
        }

        private void UpdateHealthStatus_Click(object sender, EventArgs e)
        {
            string healthStatus = fitRadio.Checked ? "Fit" : "Unfit";
            UpdatePlayerHealth(healthStatus);
        }

        private void UpdatePlayerHealth(string healthStatus)
        {
            string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Player SET HealthStatus = @HealthStatus WHERE UserID = @UserId", con);
                    cmd.Parameters.AddWithValue("@HealthStatus", healthStatus);
                    cmd.Parameters.AddWithValue("@UserId", _userId);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Health status updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Health status update failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message);
                }
            }
        }
    }
}
