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
            label1.Location = new Point(107, 81);
            label1.Name = "label1";
            label1.Size = new Size(586, 89);
            label1.TabIndex = 0;
            label1.Text = "Player Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(121, 196);
            label2.Name = "label2";
            label2.Size = new Size(275, 30);
            label2.TabIndex = 2;
            label2.Text = "Register yourself as a player";
            // 
            // name
            // 
            name.Location = new Point(240, 297);
            name.Name = "name";
            name.Size = new Size(163, 27);
            name.TabIndex = 3;
            // 
            // email
            // 
            email.Location = new Point(530, 297);
            email.Name = "email";
            email.Size = new Size(163, 27);
            email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 274);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(530, 274);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 364);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // password
            // 
            password.UseSystemPasswordChar = true; // Masks the password input
            password.Location = new Point(240, 387);
            password.Name = "password";
            password.Size = new Size(163, 27);
            password.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(530, 364);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 10;
            label6.Text = "Health Status";
            // 
            // healthStatus
            // 
            healthStatus.FormattingEnabled = true;
            healthStatus.Items.AddRange(new object[] { "Fit", "Unfit" }); // Adding options to the ComboBox
            healthStatus.Location = new Point(530, 387);
            healthStatus.Name = "healthStatus";
            healthStatus.Size = new Size(163, 28);
            healthStatus.TabIndex = 11;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(422, 455);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 12;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // PlayerRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 560);
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
            Name = "PlayerRegistrationForm";
            Text = "PlayerRegistrationForm";
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