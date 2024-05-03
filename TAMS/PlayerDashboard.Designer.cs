namespace TAMS
{
    partial class PlayerDashboard
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            updateHealthStatusBTN = new Button();
            viewAllTeamsBTN = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(207, 43);
            label1.Name = "label1";
            label1.Size = new Size(555, 89);
            label1.TabIndex = 17;
            label1.Text = "Player Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(546, 206);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 18;
            label2.Text = "Usman";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(228, 203);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 19;
            label3.Text = "Player Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(228, 267);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 21;
            label4.Text = "Health Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(546, 267);
            label5.Name = "label5";
            label5.Size = new Size(28, 23);
            label5.TabIndex = 20;
            label5.Text = "Fit";
            // 
            // updateHealthStatusBTN
            // 
            updateHealthStatusBTN.Location = new Point(228, 393);
            updateHealthStatusBTN.Name = "updateHealthStatusBTN";
            updateHealthStatusBTN.Size = new Size(181, 53);
            updateHealthStatusBTN.TabIndex = 22;
            updateHealthStatusBTN.Text = "Update Health Status";
            updateHealthStatusBTN.UseVisualStyleBackColor = true;
            // 
            // viewAllTeamsBTN
            // 
            viewAllTeamsBTN.Location = new Point(496, 393);
            viewAllTeamsBTN.Name = "viewAllTeamsBTN";
            viewAllTeamsBTN.Size = new Size(181, 53);
            viewAllTeamsBTN.TabIndex = 23;
            viewAllTeamsBTN.Text = "View All Teams";
            viewAllTeamsBTN.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(228, 328);
            label6.Name = "label6";
            label6.Size = new Size(148, 28);
            label6.TabIndex = 25;
            label6.Text = "Team Selected";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(546, 328);
            label7.Name = "label7";
            label7.Size = new Size(131, 23);
            label7.TabIndex = 24;
            label7.Text = "Hashers Limited";
            // 
            // PlayerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 560);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(viewAllTeamsBTN);
            Controls.Add(updateHealthStatusBTN);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PlayerDashboard";
            Text = "Player Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button updateHealthStatusBTN;
        private Button viewAllTeamsBTN;
        private Label label6;
        private Label label7;
    }
}
