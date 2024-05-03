
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
    }
}
