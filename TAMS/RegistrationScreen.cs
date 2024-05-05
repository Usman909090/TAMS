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
    public partial class RegistrationScreen : Form
    {
        public RegistrationScreen()
        {
            InitializeComponent();
            // Attach event handlers to buttons
            bidHerald.Click += BidHerald_Click;
            captain.Click += Captain_Click;
            player.Click += Player_Click;
        }

        private void BidHerald_Click(object sender, EventArgs e)
        {
            // Open form to register a Bid Herald
            BidHeraldRegistrationForm bidHeraldForm = new BidHeraldRegistrationForm();
            bidHeraldForm.Show();
        }

        private void Captain_Click(object sender, EventArgs e)
        {
            // Open form to register a Captain
            CaptainRegistrationForm captainForm = new CaptainRegistrationForm();
            captainForm.Show();
        }

        private void Player_Click(object sender, EventArgs e)
        {
            // Open form to register a Player
            PlayerRegistrationForm playerForm = new PlayerRegistrationForm();
            playerForm.Show();
        }

        private void captain_Click_1(object sender, EventArgs e)
        {

        }

        private void player_Click_1(object sender, EventArgs e)
        {

        }

        private void bidHerald_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
