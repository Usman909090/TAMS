using System;
using System.Windows.Forms;

namespace TAMS
{
    partial class ViewAllTeams : Form
    {
        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanel;

        public ViewAllTeams()
        {
            InitializeComponent();
            DisplayTeamsAndPlayers();
        }

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            label1 = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(tableLayoutPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(4, 5, 4, 5);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(922, 607);
            mainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel.Location = new Point(16, 77);
            tableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(0, 0);
            tableLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(260, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 70);
            label1.TabIndex = 18;
            label1.Text = "Team Details";
            // 
            // ViewAllTeams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 607);
            Controls.Add(mainPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ViewAllTeams";
            Text = "Team Display";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
    }
}
