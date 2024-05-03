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
            teamName = new TextBox();
            label7 = new Label();
            teamStatus = new ComboBox();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Location = new Point(455, 506);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 23;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(561, 350);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 21;
            label6.Text = "Team Name";
            // 
            // password
            // 
            password.Location = new Point(271, 373);
            password.Name = "password";
            password.Size = new Size(163, 27);
            password.TabIndex = 20;
            password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 350);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 19;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 272);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 18;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 272);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 17;
            label3.Text = "Name";
            // 
            // email
            // 
            email.Location = new Point(561, 295);
            email.Name = "email";
            email.Size = new Size(163, 27);
            email.TabIndex = 16;
            // 
            // name
            // 
            name.Location = new Point(271, 295);
            name.Name = "name";
            name.Size = new Size(163, 27);
            name.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(152, 194);
            label2.Name = "label2";
            label2.Size = new Size(292, 30);
            label2.TabIndex = 14;
            label2.Text = "Register yourself as a captain";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(138, 79);
            label1.Name = "label1";
            label1.Size = new Size(633, 89);
            label1.TabIndex = 13;
            label1.Text = "Captain Registration";
            // 
            // teamName
            // 
            teamName.Location = new Point(561, 373);
            teamName.Name = "teamName";
            teamName.Size = new Size(163, 27);
            teamName.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(271, 429);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 25;
            label7.Text = "Team Status";
            // 
            // teamStatus
            // 
            teamStatus.FormattingEnabled = true;
            teamStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            teamStatus.Location = new Point(271, 452);
            teamStatus.Name = "teamStatus";
            teamStatus.Size = new Size(163, 28);
            teamStatus.TabIndex = 27;
            // 
            // CaptainRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 560);
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
            Name = "CaptainRegistrationForm";
            Text = "CaptainRegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox teamName;
        private Label label7;
        private ComboBox teamStatus;
    }
}