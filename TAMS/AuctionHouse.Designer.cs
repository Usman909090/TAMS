
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TAMS
{
    partial class AuctionHouseForm
    {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            label9 = new Label();
            button4 = new Button();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 45);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Time Elapsed:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 96);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Bid Countdown:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 212);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Player:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 271);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 3;
            label4.Text = "0$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(448, 212);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(321, 271);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 5;
            label6.Text = "Highest Bid:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(797, 474);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // button1
            // 
            button1.Location = new Point(720, 45);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(145, 31);
            button1.TabIndex = 9;
            button1.Text = "Forfeit Auction";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(720, 96);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(145, 31);
            button2.TabIndex = 10;
            button2.Text = "Withdraw Player";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(321, 407);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 11;
            button3.Text = "Raise Bid";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(448, 407);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(58, 27);
            textBox1.TabIndex = 12;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(373, 24);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 13;
            label7.Text = "Auction Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(357, 331);
            label9.Name = "label9";
            label9.Size = new Size(136, 20);
            label9.TabIndex = 14;
            label9.Text = "Auction has ended!";
            label9.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(720, 147);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(145, 31);
            button4.TabIndex = 15;
            button4.Text = "Halt Bidding";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(704, 474);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 16;
            label10.Text = "Players Left:";
            // 
            // AuctionHouseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 560);
            Controls.Add(label10);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AuctionHouseForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label7;
        private Label label9;
        private Button button4;
        private Label label10;
    }
}