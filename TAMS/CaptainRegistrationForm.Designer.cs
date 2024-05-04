namespace TAMS
{
    partial class CaptainRegistrationForm
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
            password = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            email = new TextBox();
            name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            submitButton = new Button();
            label7 = new Label();
            teamStatus = new ComboBox();
            label6 = new Label();
            teamName = new TextBox();
            SuspendLayout();
            // 
            // password
            // 
            password.Location = new Point(237, 280);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Name = "password";
            password.Size = new Size(143, 23);
            password.TabIndex = 20;
            password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 262);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 19;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 204);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 18;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 204);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 17;
            label3.Text = "Name";
            // 
            // email
            // 
            email.Location = new Point(491, 221);
            email.Margin = new Padding(3, 2, 3, 2);
            email.Name = "email";
            email.Size = new Size(143, 23);
            email.TabIndex = 16;
            // 
            // name
            // 
            name.Location = new Point(237, 221);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(143, 23);
            name.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(133, 146);
            label2.Name = "label2";
            label2.Size = new Size(241, 25);
            label2.TabIndex = 14;
            label2.Text = "Register yourself as a captain";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(121, 59);
            label1.Name = "label1";
            label1.Size = new Size(510, 72);
            label1.TabIndex = 13;
            label1.Text = "Captain Registration";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(398, 380);
            submitButton.Margin = new Padding(3, 2, 3, 2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(82, 22);
            submitButton.TabIndex = 23;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(237, 322);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 25;
            label7.Text = "Team Status";
            // 
            // teamStatus
            // 
            teamStatus.FormattingEnabled = true;
            teamStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            teamStatus.Location = new Point(237, 339);
            teamStatus.Margin = new Padding(3, 2, 3, 2);
            teamStatus.Name = "teamStatus";
            teamStatus.Size = new Size(143, 23);
            teamStatus.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 262);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 21;
            label6.Text = "Team Name";
            // 
            // teamName
            // 
            teamName.Location = new Point(491, 280);
            teamName.Margin = new Padding(3, 2, 3, 2);
            teamName.Name = "teamName";
            teamName.Size = new Size(143, 23);
            teamName.TabIndex = 24;
            // 
            // CaptainRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 420);
            Controls.Add(teamStatus);
            Controls.Add(label7);
            Controls.Add(teamName);
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
            Name = "CaptainRegistrationForm";
            Text = "CaptainRegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox password;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox email;
        private TextBox name;
        private Label label2;
        private Label label1;
        private Button submitButton;
        private Label label7;
        private ComboBox teamStatus;
        private Label label6;
        private TextBox teamName;
    }
}