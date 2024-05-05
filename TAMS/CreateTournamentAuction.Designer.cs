using System.Windows.Forms;

namespace TAMS
{
    partial class CreateTournamentAuction
    {
        private Button btnSave;
        private TextBox txtTournamentName, txtLocation, txtAuctionName, txtDescription;
        private DateTimePicker dateTimePickerStart, dateTimePickerEnd, dateTimePickerAuctionStart, dateTimePickerAuctionEnd;
        private NumericUpDown numericDuration;

        private void InitializeComponent()
        {
            btnSave = new Button();
            txtTournamentName = new TextBox();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            txtLocation = new TextBox();
            txtAuctionName = new TextBox();
            txtDescription = new TextBox();
            dateTimePickerAuctionStart = new DateTimePicker();
            dateTimePickerAuctionEnd = new DateTimePicker();
            numericDuration = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericDuration).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(258, 401);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(259, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Tournament and Auction";
            btnSave.Click += btnSave_Click;
            // 
            // txtTournamentName
            // 
            txtTournamentName.Location = new Point(204, 30);
            txtTournamentName.Name = "txtTournamentName";
            txtTournamentName.Size = new Size(446, 27);
            txtTournamentName.TabIndex = 1;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(204, 70);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(446, 27);
            dateTimePickerStart.TabIndex = 2;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(206, 117);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(444, 27);
            dateTimePickerEnd.TabIndex = 3;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(204, 150);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(446, 27);
            txtLocation.TabIndex = 4;
            // 
            // txtAuctionName
            // 
            txtAuctionName.Location = new Point(206, 202);
            txtAuctionName.Name = "txtAuctionName";
            txtAuctionName.Size = new Size(446, 27);
            txtAuctionName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(206, 242);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(446, 27);
            txtDescription.TabIndex = 6;
            // 
            // dateTimePickerAuctionStart
            // 
            dateTimePickerAuctionStart.Location = new Point(206, 275);
            dateTimePickerAuctionStart.Name = "dateTimePickerAuctionStart";
            dateTimePickerAuctionStart.Size = new Size(446, 27);
            dateTimePickerAuctionStart.TabIndex = 7;
            // 
            // dateTimePickerAuctionEnd
            // 
            dateTimePickerAuctionEnd.Location = new Point(206, 320);
            dateTimePickerAuctionEnd.Name = "dateTimePickerAuctionEnd";
            dateTimePickerAuctionEnd.Size = new Size(446, 27);
            dateTimePickerAuctionEnd.TabIndex = 8;
            // 
            // numericDuration
            // 
            numericDuration.Location = new Point(206, 368);
            numericDuration.Name = "numericDuration";
            numericDuration.Size = new Size(446, 27);
            numericDuration.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 11;
            label1.Text = "Tournament Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 12;
            label2.Text = "Tournament Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 117);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 13;
            label3.Text = "Tournament End Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 157);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 14;
            label4.Text = "Tournament Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 205);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 15;
            label5.Text = "Auction Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 242);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 16;
            label6.Text = "Auction Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 282);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 17;
            label7.Text = "Auction Start Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 322);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 18;
            label8.Text = "Auction End Time";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 370);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 19;
            label9.Text = "Auction Duration";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(282, 7);
            label10.Name = "label10";
            label10.Size = new Size(198, 20);
            label10.TabIndex = 20;
            label10.Text = "Enter Tournament's Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(303, 180);
            label11.Name = "label11";
            label11.Size = new Size(166, 20);
            label11.TabIndex = 21;
            label11.Text = "Enter Auction's Details";
            // 
            // CreateTournamentAuction
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtTournamentName);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(txtLocation);
            Controls.Add(txtAuctionName);
            Controls.Add(txtDescription);
            Controls.Add(dateTimePickerAuctionStart);
            Controls.Add(dateTimePickerAuctionEnd);
            Controls.Add(numericDuration);
            Name = "CreateTournamentAuction";
            Text = "Create Tournament and Auction";
            ((System.ComponentModel.ISupportInitialize)numericDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
