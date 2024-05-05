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
            loginBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(107, 81);
            label1.Name = "label1";
            label1.Size = new Size(390, 89);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(121, 196);
            label2.Name = "label2";
            label2.Size = new Size(192, 30);
            label2.TabIndex = 1;
            label2.Text = "Register youself as";
            // 
            // bidHerald
            // 
            bidHerald.Location = new Point(222, 331);
            bidHerald.Name = "bidHerald";
            bidHerald.Size = new Size(94, 29);
            bidHerald.TabIndex = 2;
            bidHerald.Text = "Bid Herald";
            bidHerald.UseVisualStyleBackColor = true;
            // 
            // captain
            // 
            captain.Location = new Point(403, 331);
            captain.Name = "captain";
            captain.Size = new Size(94, 29);
            captain.TabIndex = 3;
            captain.Text = "Captain";
            captain.UseVisualStyleBackColor = true;
            // 
            // player
            // 
            player.Location = new Point(591, 331);
            player.Name = "player";
            player.Size = new Size(94, 29);
            player.TabIndex = 4;
            player.Text = "Player";
            player.UseVisualStyleBackColor = true;
            // 
            // loginBTN
            // 
            loginBTN.Location = new Point(843, 505);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new Size(94, 29);
            loginBTN.TabIndex = 5;
            loginBTN.Text = "Login";
            loginBTN.UseVisualStyleBackColor = true;
            loginBTN.Click += loginBTN_Click;
            // 
            // RegistrationScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 560);
            Controls.Add(loginBTN);
            Controls.Add(player);
            Controls.Add(captain);
            Controls.Add(bidHerald);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationScreen";
            Text = "RegistrationScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button bidHerald;
        private Button captain;
        private Button player;
        private Button loginBTN;
    }
}