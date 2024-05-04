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

        public static void setAuthUserID(int userId) { authUserId = userId; }
        public static int getAuthUserId() { return authUserId; }
    }
}
