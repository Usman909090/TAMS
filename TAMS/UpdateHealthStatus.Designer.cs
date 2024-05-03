namespace TAMS
{
    partial class UpdateHealthStatus
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
            fitRadio = new RadioButton();
            unFitRadio = new RadioButton();
            label7 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(169, 88);
            label1.Name = "label1";
            label1.Size = new Size(664, 89);
            label1.TabIndex = 18;
            label1.Text = "Update Health Status";
            // 
            // fitRadio
            // 
            fitRadio.AutoSize = true;
            fitRadio.Location = new Point(195, 304);
            fitRadio.Name = "fitRadio";
            fitRadio.Size = new Size(46, 24);
            fitRadio.TabIndex = 19;
            fitRadio.TabStop = true;
            fitRadio.Text = "Fit";
            fitRadio.UseVisualStyleBackColor = true;
            // 
            // unFitRadio
            // 
            unFitRadio.AutoSize = true;
            unFitRadio.Location = new Point(195, 343);
            unFitRadio.Name = "unFitRadio";
            unFitRadio.Size = new Size(62, 24);
            unFitRadio.TabIndex = 20;
            unFitRadio.TabStop = true;
            unFitRadio.Text = "Unfit";
            unFitRadio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(186, 214);
            label7.Name = "label7";
            label7.Size = new Size(217, 23);
            label7.TabIndex = 25;
            label7.Text = "Update your health status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(186, 268);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 26;
            label2.Text = "Select Health";
            // 
            // button2
            // 
            button2.Location = new Point(186, 398);
            button2.Name = "button2";
            button2.Size = new Size(110, 37);
            button2.TabIndex = 28;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // UpdateHealthStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 560);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(unFitRadio);
            Controls.Add(fitRadio);
            Controls.Add(label1);
            Name = "UpdateHealthStatus";
            Text = "UpdateHealthStatus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton fitRadio;
        private RadioButton unFitRadio;
        private Label label7;
        private Label label2;
        private Button button2;
    }
}