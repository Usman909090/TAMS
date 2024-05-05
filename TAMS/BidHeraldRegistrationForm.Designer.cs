namespace TAMS
{
    partial class BidHeraldRegistrationForm
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
            label7 = new Label();
            licenseNumber = new TextBox();
            submitButton = new Button();
            label6 = new Label();
            password = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            email = new TextBox();
            name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            experianceYears = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(234, 316);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 39;
            label7.Text = "Experiance Years";
            // 
            // licenseNumber
            // 
            licenseNumber.Location = new Point(487, 274);
            licenseNumber.Margin = new Padding(3, 2, 3, 2);
            licenseNumber.Name = "licenseNumber";
            licenseNumber.Size = new Size(143, 23);
            licenseNumber.TabIndex = 38;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(395, 374);
            submitButton.Margin = new Padding(3, 2, 3, 2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(82, 22);
            submitButton.TabIndex = 37;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 256);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 36;
            label6.Text = "License Number";
            // 
            // password
            // 
            password.Location = new Point(234, 274);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Name = "password";
            password.Size = new Size(143, 23);
            password.TabIndex = 35;
            password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(234, 256);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 34;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 198);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 33;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 198);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 32;
            label3.Text = "Name";
            // 
            // email
            // 
            email.Location = new Point(487, 215);
            email.Margin = new Padding(3, 2, 3, 2);
            email.Name = "email";
            email.Size = new Size(143, 23);
            email.TabIndex = 31;
            // 
            // name
            // 
            name.Location = new Point(234, 215);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(143, 23);
            name.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(130, 140);
            label2.Name = "label2";
            label2.Size = new Size(264, 25);
            label2.TabIndex = 29;
            label2.Text = "Register yourself as a bid herald";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(117, 53);
            label1.Name = "label1";
            label1.Size = new Size(577, 72);
            label1.TabIndex = 28;
            label1.Text = "Bid Herald Registration";
            label1.Click += label1_Click;
            // 
            // experianceYears
            // 
            experianceYears.Location = new Point(234, 333);
            experianceYears.Margin = new Padding(3, 2, 3, 2);
            experianceYears.Name = "experianceYears";
            experianceYears.Size = new Size(143, 23);
            experianceYears.TabIndex = 40;
            // 
            // BidHeraldRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 420);
            Controls.Add(experianceYears);
            Controls.Add(label7);
            Controls.Add(licenseNumber);
            Controls.Add(submitButton);
            Controls.Add(label6);
            Controls.Add(password);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BidHeraldRegistrationForm";
            Text = "BidHeraldRegistrationForm";
            Load += BidHeraldRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox licenseNumber;
        private Button submitButton;
        private Label label6;
        private TextBox password;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox email;
        private TextBox name;
        private Label label2;
        private Label label1;
        private TextBox experianceYears;
    }
}