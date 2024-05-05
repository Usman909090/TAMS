namespace TAMS
{
    partial class BidHeraldDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            enterAuctionHouseBTN = new Button();
            label8 = new Label();
            label9 = new Label();
            label3 = new Label();
            label7 = new Label();
            registerForTournamentBTN = new Button();
            viewBidHistoryBTN = new Button();
            viewAllTeamsBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(154, 9);
            label1.Name = "label1";
            label1.Size = new Size(665, 89);
            label1.TabIndex = 17;
            label1.Text = "BidHerald Dashboard";
            // 
            // enterAuctionHouseBTN
            // 
            enterAuctionHouseBTN.Location = new Point(496, 377);
            enterAuctionHouseBTN.Name = "enterAuctionHouseBTN";
            enterAuctionHouseBTN.Size = new Size(250, 85);
            enterAuctionHouseBTN.TabIndex = 48;
            enterAuctionHouseBTN.Text = "Manage Participants Requests";
            enterAuctionHouseBTN.UseVisualStyleBackColor = true;
            enterAuctionHouseBTN.Click += enterAuctionHouseBTN_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(273, 180);
            label8.Name = "label8";
            label8.Size = new Size(168, 28);
            label8.TabIndex = 45;
            label8.Text = "BidHerald Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(591, 183);
            label9.Name = "label9";
            label9.Size = new Size(67, 25);
            label9.TabIndex = 44;
            label9.Text = "Usman";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(639, 172);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(345, 112);
            label7.Name = "label7";
            label7.Size = new Size(272, 28);
            label7.TabIndex = 41;
            label7.Text = "Select what you want to do";
            // 
            // registerForTournamentBTN
            // 
            registerForTournamentBTN.Location = new Point(215, 377);
            registerForTournamentBTN.Name = "registerForTournamentBTN";
            registerForTournamentBTN.Size = new Size(250, 85);
            registerForTournamentBTN.TabIndex = 40;
            registerForTournamentBTN.Text = "Create Tournament Auction";
            registerForTournamentBTN.UseVisualStyleBackColor = true;
            registerForTournamentBTN.Click += registerForTournamentBTN_Click;
            // 
            // viewBidHistoryBTN
            // 
            viewBidHistoryBTN.Location = new Point(496, 255);
            viewBidHistoryBTN.Name = "viewBidHistoryBTN";
            viewBidHistoryBTN.Size = new Size(130, 85);
            viewBidHistoryBTN.TabIndex = 39;
            viewBidHistoryBTN.Text = "View Bid History";
            viewBidHistoryBTN.UseVisualStyleBackColor = true;
            viewBidHistoryBTN.Click += viewBidHistoryBTN_Click;
            // 
            // viewAllTeamsBTN
            // 
            viewAllTeamsBTN.Location = new Point(297, 255);
            viewAllTeamsBTN.Name = "viewAllTeamsBTN";
            viewAllTeamsBTN.Size = new Size(127, 85);
            viewAllTeamsBTN.TabIndex = 38;
            viewAllTeamsBTN.Text = "View All Teams";
            viewAllTeamsBTN.UseVisualStyleBackColor = true;
            viewAllTeamsBTN.Click += viewAllTeamsBTN_Click;
            // 
            // BidHeraldDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 560);
            Controls.Add(enterAuctionHouseBTN);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(registerForTournamentBTN);
            Controls.Add(viewBidHistoryBTN);
            Controls.Add(viewAllTeamsBTN);
            Controls.Add(label1);
            Name = "BidHeraldDashboard";
            Text = "Bid Herald Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Button enterAuctionHouseBTN;
        private Label label8;
        private Label label9;
        private Label label3;
        private Label label7;
        private Button registerForTournamentBTN;
        private Button viewBidHistoryBTN;
        private Button viewAllTeamsBTN;
    }
}
