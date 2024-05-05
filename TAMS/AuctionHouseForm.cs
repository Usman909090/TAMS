using System.Text;

namespace TAMS
{
    public partial class AuctionHouseForm : Form
    {
        private TimeSpan elapsedTime = TimeSpan.FromSeconds(1);
        private TimeSpan countdownTime = TimeSpan.FromSeconds(30);
        private List<User> users;

        public AuctionHouseForm()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer1.Start();

            // set the placeholder bid value
            textBox1.PlaceholderText = "0$";

            users = new List<User>();
        }

        // stop all timers
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

            // disable everything else except the auction name
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;

            // show the auction end message
            label9.Visible = true;

            // disable the buttons and text box
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                label2.Text = "Time Elapsed: " + countdownTime.ToString();
                return;
            }

            countdownTime = TimeSpan.FromSeconds(30);
            label9.Text = "Bidding Ended!";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!timer2.Enabled)
            {

                timer2.Start();
            }

            else
                MessageBox.Show("A player is already being bid on!", "Error");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String newBidString = textBox1.Text;
            if (newBidString == "")
            {
                MessageBox.Show("Please enter a bid amount", "Error");
                return;
            }

            int newBid = int.Parse(newBidString);
            int currentHighestBid = int.Parse(label4.Text.Trim('$'));

            // check if the bid is higher than the current bid
            if (newBid <= currentHighestBid)
            {
                MessageBox.Show("Please enter a bid higher than " + currentHighestBid.ToString() + "$!", "Error");
                return;
            }

            // restart the countdown variable
            countdownTime = TimeSpan.FromSeconds(30);

            label4.Text = newBid.ToString() + "$";
            textBox1.PlaceholderText = (newBid + 1).ToString() + "$";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // check if only integers are entered
            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Please enter a valid number", "Error");
                textBox1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Halt Bidding" && timer2.Enabled)
            {
                timer2.Stop();

                button3.Visible = false;
                textBox1.Visible = false;

                label9.Text = "Bidding Halted!";
                label9.ForeColor = Color.Red;
                label9.Visible = true;

                button4.Text = "Resume Bidding";
            }
            else
            {
                timer2.Start();

                button3.Visible = true;
                textBox1.Visible = true;

                label9.Visible = false;

                button4.Text = "Halt Bidding";
            }
        }

        private void AuctionHouseForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
