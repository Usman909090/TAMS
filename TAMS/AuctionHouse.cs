using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAMS
{
    public partial class AuctionHouseForm : Form
    {
        private TimeSpan elapsedTime = TimeSpan.FromSeconds(1);
        private TimeSpan countdownTime = TimeSpan.FromSeconds(30);
        private int highestBid = 0; // Track the highest bid
        private bool auctionActive = false; // Flag to indicate if auction is active
        private string connectionString = "Data Source=DESKTOP-UTDORAK\\SQLEXPRESS; Initial Catalog=TAMS; Integrated Security=True; Encrypt=false";

        public AuctionHouseForm(int userID)
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer1.Start();

            // Initialize UI elements
            label9.Visible = false;
            button3.Enabled = false;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stop all timers and disable UI elements
            timer1.Stop();
            timer2.Stop();
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Enabled = false;

            // Update UI
            label9.Text = "Auction forfeited!";
            label9.ForeColor = Color.Red;
            label9.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
            label1.Text = "Time Elapsed: " + elapsedTime.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (countdownTime.Seconds > 0)
            {
                countdownTime = countdownTime.Subtract(TimeSpan.FromSeconds(1));
                label2.Text = "Bid Countdown: " + countdownTime.ToString();
                return;
            }

            countdownTime = TimeSpan.FromSeconds(30);
            label9.Text = "Bidding Ended!";
            EndAuction(); // Automatically end auction when timer ends
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!auctionActive)
            {
                StartAuction();
            }
            else
            {
                MessageBox.Show("Auction is already active!", "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string newBidString = textBox1.Text;
            if (string.IsNullOrEmpty(newBidString))
            {
                MessageBox.Show("Please enter a bid amount", "Error");
                return;
            }

            if (!int.TryParse(newBidString, out int newBid))
            {
                MessageBox.Show("Please enter a valid number", "Error");
                textBox1.Text = "";
                return;
            }

            if (newBid <= highestBid)
            {
                MessageBox.Show($"Please enter a bid higher than {highestBid}$!", "Error");
                return;
            }

            // Update highest bid
            highestBid = newBid;

            // Restart countdown
            countdownTime = TimeSpan.FromSeconds(30);

            label4.Text = $"{newBid}$";
            textBox1.PlaceholderText = $"{newBid + 1}$";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled)
            {
                // If bidding is active, halt it
                timer2.Stop();
                button3.Enabled = false;
                textBox1.Enabled = false;
                label9.Text = "Bidding Halted!";
                label9.ForeColor = Color.Red;
                label9.Visible = true;
                button4.Text = "Resume Bidding";
            }
            else
            {
                // Resume bidding
                timer2.Start();
                button3.Enabled = true;
                textBox1.Enabled = true;
                label9.Visible = false;
                button4.Text = "Halt Bidding";
            }
        }

        // Helper method to start the auction
        private void StartAuction()
        {
            // Reset UI elements
            highestBid = 0;
            countdownTime = TimeSpan.FromSeconds(30);
            label4.Text = "0$";
            textBox1.PlaceholderText = "1$";
            button3.Enabled = true;
            textBox1.Enabled = true;
            button2.Enabled = false;
            auctionActive = true;
            timer2.Start(); // Start countdown timer
        }

        // Helper method to end the auction
        private void EndAuction()
        {
            auctionActive = false;
            timer2.Stop();
            button3.Enabled = false;
            textBox1.Enabled = false;
            button2.Enabled = true;
        }
    }
}
