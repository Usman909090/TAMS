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
    public partial class CaptainDashboard : Form
    {
        public CaptainDashboard()
        {
            InitForm();
        }

        private void InitForm()
        {
            this.Text = "Captain Dashboard";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CaptainDashboard";
            // Additional controls and functionalities can be added here
        }
    }
}
