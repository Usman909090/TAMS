using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAMS
{
    public partial class CreateTournamentAuction : Form
    {
        private string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";

        public CreateTournamentAuction()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Calculate duration in minutes
            TimeSpan duration = dateTimePickerAuctionEnd.Value - dateTimePickerAuctionStart.Value;
            numericDuration.Value = (decimal)duration.TotalMinutes;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Insert Tournament
                    SqlCommand cmd = new SqlCommand("INSERT INTO Tournament (Name, StartDate, EndDate, Location) VALUES (@Name, @StartDate, @EndDate, @Location)", conn);
                    cmd.Parameters.AddWithValue("@Name", txtTournamentName.Text);
                    cmd.Parameters.AddWithValue("@StartDate", dateTimePickerStart.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dateTimePickerEnd.Value);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.ExecuteNonQuery();

                    // Insert Auction with status 'Planned' and calculated duration
                    cmd = new SqlCommand("INSERT INTO Auction (Name, Description, StartTime, EndTime, Duration, Status) VALUES (@Name, @Description, @StartTime, @EndTime, @Duration, @Status)", conn);
                    cmd.Parameters.AddWithValue("@Name", txtAuctionName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@StartTime", dateTimePickerAuctionStart.Value);
                    cmd.Parameters.AddWithValue("@EndTime", dateTimePickerAuctionEnd.Value);
                    cmd.Parameters.AddWithValue("@Duration", (int)numericDuration.Value);
                    cmd.Parameters.AddWithValue("@Status", "Planned");
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tournament and Auction created successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // Optionally, if you want to update the numericDuration automatically when Auction times change:
        private void dateTimePickerAuctionStart_ValueChanged(object sender, EventArgs e)
        {
            UpdateDuration();
        }

        private void dateTimePickerAuctionEnd_ValueChanged(object sender, EventArgs e)
        {
            UpdateDuration();
        }

        private void UpdateDuration()
        {
            if (dateTimePickerAuctionEnd.Value > dateTimePickerAuctionStart.Value)
            {
                TimeSpan duration = dateTimePickerAuctionEnd.Value - dateTimePickerAuctionStart.Value;
                numericDuration.Value = (decimal)duration.TotalMinutes;
            }
            else
            {
                numericDuration.Value = 0;
            }
        }
    }
}
