using System;
using System.Windows.Forms;
using System.Drawing; // Added using directive for System.Drawing

namespace TAMS
{
    partial class RegisterTournamentAuction : Form
    {
        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanel;
        private TextBox auctionIdTextBox;
        private Button submitButton;
        private Label titleLabel;

        public RegisterTournamentAuction()
        {
            InitializeComponent();
            DisplayAuctions();
        }

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            titleLabel = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            auctionIdTextBox = new TextBox();
            submitButton = new Button();
            label1 = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Controls.Add(tableLayoutPanel);
            mainPanel.Controls.Add(auctionIdTextBox);
            mainPanel.Controls.Add(submitButton);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(4, 5, 4, 5);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(922, 607);
            mainPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            titleLabel.Location = new Point(66, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(777, 67);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Register In Tournament Auction";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Location = new Point(16, 100);
            tableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(0, 0);
            tableLayoutPanel.TabIndex = 1;
            // 
            // auctionIdTextBox
            // 
            auctionIdTextBox.Location = new Point(600, 200);
            auctionIdTextBox.Name = "auctionIdTextBox";
            auctionIdTextBox.Size = new Size(150, 27);
            auctionIdTextBox.TabIndex = 2;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(768, 200);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 32);
            submitButton.TabIndex = 3;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(600, 166);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 5;
            label1.Text = "Enter auction id to register";
            // 
            // RegisterTournamentAuction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 607);
            Controls.Add(mainPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegisterTournamentAuction";
            Text = "Register Tournament Auction";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
    }
}
