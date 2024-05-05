namespace TAMS
{
    partial class LoginScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            registerBTN = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(372, 270);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(199, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(372, 345);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(199, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(419, 395);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(175, 187);
            label2.Name = "label2";
            label2.Size = new Size(511, 30);
            label2.TabIndex = 16;
            label2.Text = "Login into tournament auction management system";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(161, 72);
            label1.Name = "label1";
            label1.Size = new Size(202, 89);
            label1.TabIndex = 15;
            label1.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 245);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 17;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 320);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // registerBTN
            // 
            registerBTN.Location = new Point(828, 510);
            registerBTN.Name = "registerBTN";
            registerBTN.Size = new Size(94, 29);
            registerBTN.TabIndex = 19;
            registerBTN.Text = "Register";
            registerBTN.UseVisualStyleBackColor = true;
            registerBTN.Click += registerBTN_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 560);
            Controls.Add(registerBTN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginScreen";
            Text = "Login";
            Load += LoginScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button registerBTN;
    }
}
