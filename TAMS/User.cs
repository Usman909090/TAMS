using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMS
{
    public class User
    {
        public int UserID { get; private set; }
        public String Username { get; private set; }
        public String Email { get; private set; }
        public String Role { get; private set; }
        public String Status { get; private set; }

        public User(int userID, String username, String email, String role, String status = )
        {
            UserID = userID;
            Username = username;
            Email = email;
            Role = role;
            Status = status;
        }
    }
}
