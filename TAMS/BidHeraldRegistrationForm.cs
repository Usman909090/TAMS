﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAMS
{
    public partial class BidHeraldRegistrationForm : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True;";

        public BidHeraldRegistrationForm()
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
                int userId = CreateUser(name.Text, email.Text, password.Text);
                int bidHeraldId = CreateBidHerald(userId, licenseNumber.Text, Convert.ToInt32(experianceYears.Text));
                // Assign the role of Bid Herald to the user
                AssignBidHeraldRole(userId);

                MessageBox.Show("Bid Herald registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BidHeraldDashboard bidHeraldDashboard = new BidHeraldDashboard(userId);
                bidHeraldDashboard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bid Herald registration failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CreateUser(string username, string email, string password)
        {
            int userId = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string userInsertQuery = "INSERT INTO [User] (Username, Email, Password) OUTPUT INSERTED.UserID VALUES (@Username, @Email, @Password)";
                    SqlCommand userInsertCommand = new SqlCommand(userInsertQuery, con);
                    userInsertCommand.Parameters.AddWithValue("@Username", username);
                    userInsertCommand.Parameters.AddWithValue("@Email", email);
                    userInsertCommand.Parameters.AddWithValue("@Password", password);
                    userId = Convert.ToInt32(userInsertCommand.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating user: " + ex.Message);
            }

            return userId;
        }

        private int CreateBidHerald(int userId, string licenseNumber, int experienceYears)
        {
            int bidHeraldId = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string bidHeraldInsertQuery = "INSERT INTO BidHerald (UserID, LicenseNumber, ExperienceYears) OUTPUT INSERTED.UserID VALUES (@UserId, @LicenseNumber, @ExperienceYears)";
                    SqlCommand bidHeraldInsertCommand = new SqlCommand(bidHeraldInsertQuery, con);
                    bidHeraldInsertCommand.Parameters.AddWithValue("@UserId", userId);
                    bidHeraldInsertCommand.Parameters.AddWithValue("@LicenseNumber", licenseNumber);
                    bidHeraldInsertCommand.Parameters.AddWithValue("@ExperienceYears", experienceYears);
                    bidHeraldId = Convert.ToInt32(bidHeraldInsertCommand.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating bid herald: " + ex.Message);
            }

            return bidHeraldId;
        }

        // Add this method to your existing class
        private void AssignBidHeraldRole(int userId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string roleAssignQuery = "INSERT INTO UserRoles (UserID, RoleID) VALUES (@UserId, @RoleId)";
                SqlCommand roleAssignCommand = new SqlCommand(roleAssignQuery, con);
                roleAssignCommand.Parameters.AddWithValue("@UserId", userId);
                roleAssignCommand.Parameters.AddWithValue("@RoleId", 2); // Assuming 2 is the RoleID for Bid Herald
                roleAssignCommand.ExecuteNonQuery();
            }
        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(password.Text) || string.IsNullOrWhiteSpace(licenseNumber.Text) ||
                string.IsNullOrWhiteSpace(experianceYears.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(experianceYears.Text, out _))
            {
                MessageBox.Show("Experience Years must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
