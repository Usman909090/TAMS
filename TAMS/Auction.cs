using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMS
{
    public class Auction
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public int Duration { get; private set; }
        public string Status { get; private set; }
        public bool IsOpen { get; private set; }
        public int BidHeraldID { get; private set; }

        public Auction(int id, string name, string description, DateTime startTime, DateTime endTime, String status, int bidHeraldID = -1)
        {
            ID = id;
            Name = name;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            Duration = (int)(endTime - startTime).TotalSeconds;
            Status = status;
            BidHeraldID = bidHeraldID;
        }

        public void CloseAuction()
        {
            Status = "Completed";
        }

        public void DeclareWinner(int userID)
        {

        }

        public void updateAuction()
        {
            
        }
    }
}
