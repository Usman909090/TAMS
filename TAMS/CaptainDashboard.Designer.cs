namespace TAMS
{
    partial class CaptainDashboard
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
            viewAllTeamsBTN = new Button();
            viewBidHistoryBTN = new Button();
            registerForTournamentBTN = new Button();
            label7 = new Label();
            label3 = new Label();
            viewCaptainTeamBTN = new Button();
            label6 = new Label();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            enterAuctionHouseBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(602, 89);
            label1.TabIndex = 19;
            label1.Text = "Captain Dashboard";
            // 
            // viewAllTeamsBTN
            // 
            viewAllTeamsBTN.Location = new Point(184, 316);
            viewAllTeamsBTN.Name = "viewAllTeamsBTN";
            viewAllTeamsBTN.Size = new Size(127, 85);
            viewAllTeamsBTN.TabIndex = 20;
            viewAllTeamsBTN.Text = "View All Teams";
            viewAllTeamsBTN.UseVisualStyleBackColor = true;
            viewAllTeamsBTN.Click += viewAllTeamsBTN_Click;
            // 
            // viewBidHistoryBTN
            // 
            viewBidHistoryBTN.Location = new Point(652, 316);
            viewBidHistoryBTN.Name = "viewBidHistoryBTN";
            viewBidHistoryBTN.Size = new Size(130, 85);
            viewBidHistoryBTN.TabIndex = 21;
            viewBidHistoryBTN.Text = "View Bid History";
            viewBidHistoryBTN.UseVisualStyleBackColor = true;
            viewBidHistoryBTN.Click += viewBidHistoryBTN_Click;
            // 
            // registerForTournamentBTN
            // 
            registerForTournamentBTN.Location = new Point(218, 438);
            registerForTournamentBTN.Name = "registerForTournamentBTN";
            registerForTournamentBTN.Size = new Size(250, 85);
            registerForTournamentBTN.TabIndex = 22;
            registerForTournamentBTN.Text = "Register For Tournament Auction";
            registerForTournamentBTN.UseVisualStyleBackColor = true;
            registerForTournamentBTN.Click += registerForTournamentBTN_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(343, 98);
            label7.Name = "label7";
            label7.Size = new Size(272, 28);
            label7.TabIndex = 26;
            label7.Text = "Select what you want to do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(637, 158);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 27;
            // 
            // viewCaptainTeamBTN
            // 
            viewCaptainTeamBTN.Location = new Point(422, 316);
            viewCaptainTeamBTN.Name = "viewCaptainTeamBTN";
            viewCaptainTeamBTN.Size = new Size(127, 85);
            viewCaptainTeamBTN.TabIndex = 28;
            viewCaptainTeamBTN.Text = "View My Team";
            viewCaptainTeamBTN.UseVisualStyleBackColor = true;
            viewCaptainTeamBTN.Click += viewCaptainTeamBTN_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(271, 230);
            label6.Name = "label6";
            label6.Size = new Size(124, 28);
            label6.TabIndex = 35;
            label6.Text = "Team Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(589, 230);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 34;
            label2.Text = "Hashers Limited";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(271, 166);
            label8.Name = "label8";
            label8.Size = new Size(146, 28);
            label8.TabIndex = 31;
            label8.Text = "Captain Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(589, 169);
            label9.Name = "label9";
            label9.Size = new Size(67, 25);
            label9.TabIndex = 30;
            label9.Text = "Usman";
            // 
            // enterAuctionHouseBTN
            // 
            enterAuctionHouseBTN.Location = new Point(499, 438);
            enterAuctionHouseBTN.Name = "enterAuctionHouseBTN";
            enterAuctionHouseBTN.Size = new Size(250, 85);
            enterAuctionHouseBTN.TabIndex = 36;
            enterAuctionHouseBTN.Text = "Enter Auction House";
            enterAuctionHouseBTN.UseVisualStyleBackColor = true;
            enterAuctionHouseBTN.Click += enterAuctionHouseBTN_Click;
            // 
            // CaptainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 560);
            Controls.Add(enterAuctionHouseBTN);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(viewCaptainTeamBTN);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(registerForTournamentBTN);
            Controls.Add(viewBidHistoryBTN);
            Controls.Add(viewAllTeamsBTN);
            Controls.Add(label1);
            Name = "CaptainDashboard";
            Text = "Captain Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Button viewAllTeamsBTN;
        private Button viewBidHistoryBTN;
        private Button registerForTournamentBTN;
        private Label label7;
        private Label label3;
        private Button viewCaptainTeamBTN;
        private Label label6;
        private Label label2;
        private Label label8;
        private Label label9;
        private Button enterAuctionHouseBTN;
    }
}
