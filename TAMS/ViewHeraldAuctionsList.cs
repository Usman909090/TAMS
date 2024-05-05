using System;
using System.Windows.Forms;

namespace TAMS
{
    public partial class BidHeraldDashboard : Form
    {
        public BidHeraldDashboard()
        {
            InitializeComponent();  // This calls the auto-generated InitializeComponent
            InitForm();  // Custom initialization tasks

            // Load the auctions
            List<Auction> auctions = DBConnection.GetAuctions();

            foreach (Auction auction in auctions)
            {
                ListViewItem item = new ListViewItem(auction.ID.ToString());
                item.SubItems.Add(auction.Name);
                item.SubItems.Add(auction.Description);
                item.SubItems.Add(auction.StartTime.ToString());
                item.SubItems.Add(auction.EndTime.ToString());
                item.SubItems.Add(auction.Duration.ToString());
                item.SubItems.Add(auction.Status.ToString());

                // if there is a bid herald not assigned, 
                if (auction.BidHeraldID == -1)
                {
                    item.SubItems.Add("None");
                }

                else
                {
                    // fetch the bid herald name
                    String bidHeraldName = DBConnection.GetUserName(auction.BidHeraldID);
                    item.SubItems.Add(bidHeraldName);
                }
                listView1.Items.Add(item);
            }

        }

        private void InitForm()
        {
            this.Text = "Bid Herald Dashboard";
            this.ClientSize = new System.Drawing.Size(800, 450);
            // Other initialization code and controls can be added here
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int auctionID = int.Parse(item.Text);
                Auction auction = DBConnection.GetAuctionByID(auctionID);
                if (auction != null)
                {
                    // Display the auction details
                    columnHeader1.Text = auction.ID.ToString();
                    columnHeader2.Text = auction.Name;
                    columnHeader3.Text = auction.Description;
                    columnHeader4.Text = auction.StartTime.ToString();
                    columnHeader5.Text = auction.EndTime.ToString();
                    columnHeader6.Text = auction.Status.ToString();
                    columnHeader7.Text = auction.BidHeraldID.ToString();
                }
            }
        }

        private void BidHeraldDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
