namespace TAMS
{
    partial class RegistrationScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            bidHerald = new Button();
            captain = new Button();
            player = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(94, 61);
            label1.Name = "label1";
            label1.Size = new Size(314, 72);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(106, 147);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 1;
            label2.Text = "Register youself as";
            label2.Click += label2_Click;
            // 
            // bidHerald
            // 
            bidHerald.Location = new Point(194, 248);
            bidHerald.Margin = new Padding(3, 2, 3, 2);
            bidHerald.Name = "bidHerald";
            bidHerald.Size = new Size(82, 22);
            bidHerald.TabIndex = 2;
            bidHerald.Text = "Bid Herald";
            bidHerald.UseVisualStyleBackColor = true;
            bidHerald.Click += bidHerald_Click_1;
            // 
            // captain
            // 
            captain.Location = new Point(353, 248);
            captain.Margin = new Padding(3, 2, 3, 2);
            captain.Name = "captain";
            captain.Size = new Size(82, 22);
            captain.TabIndex = 3;
            captain.Text = "Captain";
            captain.UseVisualStyleBackColor = true;
            captain.Click += captain_Click_1;
            // 
            // player
            // 
            player.Location = new Point(517, 248);
            player.Margin = new Padding(3, 2, 3, 2);
            player.Name = "player";
            player.Size = new Size(82, 22);
            player.TabIndex = 4;
            player.Text = "Player";
            player.UseVisualStyleBackColor = true;
            player.Click += player_Click_1;
            // 
            // RegistrationScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 420);
            Controls.Add(player);
            Controls.Add(captain);
            Controls.Add(bidHerald);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistrationScreen";
            Text = "RegistrationScreen";
            Load += RegistrationScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button bidHerald;
        private Button captain;
        private Button player;
    }
}