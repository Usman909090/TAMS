using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAMS
{
    public partial class AuctionHouseForm : Form
    {
        private TimeSpan elapsed_time = TimeSpan.FromSeconds(0);
        private TimeSpan countdown_time = TimeSpan.FromSeconds(15);

        public AuctionHouseForm()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer2.Interval = 1000;

            timer1.Start();
            timer2.Start();

            // show the bid herald features if authenticated
            if (DBConnection.GetUserRole(DBConnection.getAuthUserId()) == Constants.ROLE_BID_HERALD)
            {
                // enable the stop auction button
                button2.Visible = true;
                button2.Enabled = true;

                // enable the withdraw next player button
                button3.Visible = true;
                button3.Enabled = true;
            }
        }

        // helper methods
        private bool hasStarted(System.Windows.Forms.Timer timer)
        {
            return timer.Enabled;
        }

        private void AuctionHouse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsed_time = elapsed_time.Add(TimeSpan.FromSeconds(1));
            label6.Text = "Time Elapsed: " + elapsed_time.ToString();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (countdown_time.Seconds == 0)
            {
                timer2.Stop();

                label7.Text = "Bid Finished!";
                label7.ForeColor = Color.Green;
                label7.BackColor = Color.Green;
                return;
            }

            countdown_time = countdown_time.Subtract(TimeSpan.FromSeconds(1));
            label7.Text = "Bid Countdown: " + countdown_time.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // stop the auction
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
