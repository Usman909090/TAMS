using System;
using System.Windows.Forms;
using System.Drawing;

namespace TAMS
{
    partial class ManageParticipantsRequests : Form
    {
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            titleLabel = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            mainPanel.SuspendLayout();
            SuspendLayout();

            // Main Panel
            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Controls.Add(tableLayoutPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(4, 5, 4, 5);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(922, 607);
            mainPanel.TabIndex = 0;

            // Title Label
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            titleLabel.Location = new Point(66, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(571, 67);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Manage Participants Requests";

            // TableLayoutPanel
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnCount = 6;  // Adjusted for additional columns
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel.Location = new Point(16, 90);
            tableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;  // Initialized for future dynamic rows
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel.Size = new Size(890, 500);  // Adjusted to potentially accommodate more content
            tableLayoutPanel.TabIndex = 1;

            // ManageParticipantsRequests Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 607);
            Controls.Add(mainPanel);
            Name = "ManageParticipantsRequests";
            Text = "Manage Participants Requests";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
