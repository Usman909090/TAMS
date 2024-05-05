using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace TAMS
{
    partial class ViewAllBidHistory
    {
        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanel;
        private Label label1;

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            label1 = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            label2 = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(tableLayoutPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(4, 5, 4, 5);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(922, 607);
            mainPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.Location = new Point(16, 90);
            tableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(0, 0);
            tableLayoutPanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 40F);
            label2.Location = new Point(250, 9);
            label2.Name = "label2";
            label2.Size = new Size(451, 89);
            label2.TabIndex = 18;
            label2.Text = "All Bid History";
            // 
            // ViewAllBidsHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 607);
            Controls.Add(mainPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ViewAllBidsHistory";
            Text = "All Bid History";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Label label2;
    }
}
