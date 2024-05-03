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
            // BidHeraldDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 560);
            Controls.Add(label1);
            Name = "BidHeraldDashboard";
            Text = "Bid Herald Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
