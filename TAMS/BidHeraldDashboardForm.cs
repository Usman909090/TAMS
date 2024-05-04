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
        }

        private void InitForm()
        {
            this.Text = "Bid Herald Dashboard";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "BidHeraldDashboard";
            // Other initialization code and controls can be added here
        }
    }
}
