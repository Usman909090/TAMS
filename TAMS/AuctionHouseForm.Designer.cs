namespace TAMS
{
    partial class AuctionHouseForm
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(290, 242);
            button1.Name = "button1";
            button1.Size = new Size(70, 23);
            button1.TabIndex = 0;
            button1.Text = "Raise Bid";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 131);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Player Name";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(382, 243);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "0.0$";
            textBox1.Size = new Size(48, 23);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 187);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 5;
            label3.Text = "Highest Bid:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 426);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 6;
            label4.Text = "Players Left: 0";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 426);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 7;
            label5.Text = "Players Auctioned: 0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 29);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 8;
            label6.Text = "Time Elapsed: ";
            label6.Click += label6_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.ImageAlign = ContentAlignment.TopLeft;
            label7.Location = new Point(31, 64);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 9;
            label7.Text = "Bid Countdown: ";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(603, 21);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 10;
            button2.Text = "Stop Auction";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(603, 81);
            button3.Name = "button3";
            button3.Size = new Size(107, 23);
            button3.TabIndex = 11;
            button3.Text = "Withdraw Player";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // AuctionHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Enabled = false;
            ImeMode = ImeMode.Off;
            Name = "AuctionHouse";
            Text = "AuctionHouse";
            Load += AuctionHouse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label7;
        private Button button2;
        private Button button3;
    }
}