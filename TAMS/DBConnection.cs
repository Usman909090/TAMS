using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMS
{
    public static class DBConnection
    {
        private static int authUserId = 0;
        public static string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TAMS;Integrated Security=True";
        public static SqlConnection Connection = new SqlConnection(ConnectionString);

        public static SqlConnection GetConnection()
        {
            return Connection;
        }

        public static int GetUserRole(int userId)
        {
            Connection.Open();
            // Check each role table to find where the UserID is present
            string checkRole = "SELECT COUNT(1) FROM [UserRoles] WHERE UserID = @userId";

            SqlCommand cmd = new SqlCommand(checkRole, Connection);
            cmd.Parameters.AddWithValue("@userId", userId);

            if ((int)cmd.ExecuteScalar() == Constants.ROLE_BID_HERALD)
                return Constants.ROLE_BID_HERALD;

            else if ((int)cmd.ExecuteScalar() == Constants.ROLE_CAPTAIN)
                return Constants.ROLE_CAPTAIN;

            else if ((int)cmd.ExecuteScalar() == Constants.ROLE_TEAM_PLAYER)
                return Constants.ROLE_PLAYER;

            else if ((int)cmd.ExecuteScalar() == Constants.ROLE_PLAYER)
                return Constants.ROLE_PLAYER;

            else if ((int)cmd.ExecuteScalar() == Constants.ROLE_USER)
                return Constants.ROLE_USER;

            Connection.Close();
            return -1;  // No role found
        }

        public static List<Auction> GetAuctions()
        {
            List<Auction> auctions = new List<Auction>();

            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    Connection.Open();
                    string getAuctionsQuery = @"
                    SELECT a.AuctionID, a.Name, a.Description, a.StartTime, a.EndTime, a.Duration, a.Status, ah.BidHeraldID
                    FROM [Auction] a
                    LEFT JOIN [AuctionHerald] ah ON a.AuctionID = ah.AuctionID";

                    using (SqlCommand cmd = new SqlCommand(getAuctionsQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int auctionId = (int)reader["AuctionID"];
                                string name = (string)reader["Name"];
                                string description = (string)reader["Description"];
                                DateTime startTime = (DateTime)reader["StartTime"];
                                DateTime endTime = (DateTime)reader["EndTime"];
                                int duration = (int)reader["Duration"];
                                string status = (string)reader["Status"];
                                
                                object bidHerald = reader["BidHeraldID"];
                                int bidHeraldID = -1;                                
                                if (bidHerald != DBNull.Value)
                                {
                                    bidHeraldID = (int)bidHerald;
                                }

                                Auction auction = new Auction(auctionId, name, description, startTime, endTime, status, bidHeraldID);
                                auctions.Add(auction);
                            }
                        }
                    }
                }

                return auctions;
            }
            catch (Exception e)
            {
                // Log or handle the exception appropriately
                throw e.GetBaseException();
            }
        }

        public static String GetUserName(int userID)
        {
            try
            {
                Connection.Open();
                string getUserName = "SELECT Name FROM [Users] WHERE ID = @userID"; 
                SqlCommand cmd = new SqlCommand(getUserName, Connection);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.ExecuteNonQuery();

                string userName = (string)cmd.ExecuteScalar();
                Connection.Close();
                return userName;
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }

        public static Auction GetAuctionByID(int auctionID)
        {
            try
            {
                Connection.Open();
                string getAuction = "SELECT * FROM [Auctions] WHERE ID = @auctionID";
                SqlCommand cmd = new SqlCommand(getAuction, Connection);
                cmd.Parameters.AddWithValue(getAuction, auctionID);

                Auction auction = null;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int auctionId = (int)reader["AuctionID"];
                        String name = (string)reader["Name"];
                        String description = (string)reader["Description"];
                        DateTime startTime = (DateTime)reader["StartTime"];
                        DateTime endTime = (DateTime)reader["EndTime"];
                        int duration = (int)reader["Duration"];
                        string status = (string)reader["Status"];
                        
                        object bidHerald = reader["BidHerald"];
                        int bidHeraldID = -1;

                        if (bidHerald != null)
                        {
                            bidHeraldID = (int)bidHerald;
                        }

                        auction = new Auction(auctionId, name, description, startTime, endTime, status, bidHeraldID);
                    }
                }

                Connection.Close();
                return auction;
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }

        public static List<User> GetAllUsers()
        {
            try
            {
                // four table join
                Connection.Open();
                string getUsersQuery = @"SELECT u.UserID, u.UserName, u.Email, r.RoleName FROM [User] u LEFT JOIN UserRoles ur ON u.UserID = ur.UserID INNER JOIN Role r ON ur.RoleID = r.RoleID";
                SqlCommand cmd = new SqlCommand(getUsersQuery, Connection);

                List<User> users = new List<User>();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int userId = (int)reader["UserID"];
                        string userName = (string)reader["UserName"];
                        string email = (string)reader["Email"];
                        string role = (string)reader["RoleName"];

                        User user = new User(userId, userName, email, role);
                        users.Add(user);
                    }
                }

                return users;
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }


        public static void setAuthUserID(int userId) { authUserId = userId; }
        public static int getAuthUserId() { return authUserId; }
    }
}
