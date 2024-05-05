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
    public partial class PlayerDashboard : Form
    {
        public PlayerDashboard()
        {
            InitForm();
        }

        private void InitForm()
        {
            this.Text = "Player Dashboard";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "PlayerDashboard";
            // Add controls and setup for the player dashboard here
        }

        private void PlayerDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
