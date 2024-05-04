namespace TAMS
{
    partial class PlayerRegistrationForm
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
            name = new TextBox();
            email = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            password = new TextBox();
            label6 = new Label();
            healthStatus = new ComboBox();
            submitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(94, 61);
            label1.Name = "label1";
            label1.Size = new Size(472, 72);
            label1.TabIndex = 0;
            label1.Text = "Player Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(106, 147);
            label2.Name = "label2";
            label2.Size = new Size(232, 25);
            label2.TabIndex = 2;
            label2.Text = "Register yourself as a player";
            // 
            // name
            // 
            name.Location = new Point(210, 223);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(143, 23);
            name.TabIndex = 3;
            // 
            // email
            // 
            email.Location = new Point(464, 223);
            email.Margin = new Padding(3, 2, 3, 2);
            email.Name = "email";
            email.Size = new Size(143, 23);
            email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 206);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 206);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 273);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(210, 290);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Name = "password";
            password.Size = new Size(143, 23);
            password.TabIndex = 9;
            password.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 273);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 10;
            label6.Text = "Health Status";
            // 
            // healthStatus
            // 
            healthStatus.FormattingEnabled = true;
            healthStatus.Items.AddRange(new object[] { "Fit", "Unfit" });
            healthStatus.Location = new Point(464, 290);
            healthStatus.Margin = new Padding(3, 2, 3, 2);
            healthStatus.Name = "healthStatus";
            healthStatus.Size = new Size(143, 23);
            healthStatus.TabIndex = 11;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(369, 341);
            submitButton.Margin = new Padding(3, 2, 3, 2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(82, 22);
            submitButton.TabIndex = 12;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click_1;
            // 
            // PlayerRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 420);
            Controls.Add(submitButton);
            Controls.Add(healthStatus);
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
            Name = "PlayerRegistrationForm";
            Text = "s";
            Load += PlayerRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private TextBox name;
        private TextBox email;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox password;
        private Label label6;
        private ComboBox healthStatus;
        private Button submitButton;
    }
}