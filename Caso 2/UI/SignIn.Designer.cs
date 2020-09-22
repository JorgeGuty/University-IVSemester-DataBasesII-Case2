namespace Caso_2.UI
{
    partial class SignIn
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
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextLabel = new System.Windows.Forms.Label();
            this.PasswordTextLabel = new System.Windows.Forms.Label();
            this.SingInButton = new System.Windows.Forms.Button();
            this.LogInErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(72, 35);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(248, 22);
            this.EmailTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(72, 131);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(248, 22);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // EmailTextLabel
            // 
            this.EmailTextLabel.AutoSize = true;
            this.EmailTextLabel.Location = new System.Drawing.Point(69, 15);
            this.EmailTextLabel.Name = "EmailTextLabel";
            this.EmailTextLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailTextLabel.TabIndex = 2;
            this.EmailTextLabel.Text = "Email";
            // 
            // PasswordTextLabel
            // 
            this.PasswordTextLabel.AutoSize = true;
            this.PasswordTextLabel.Location = new System.Drawing.Point(69, 111);
            this.PasswordTextLabel.Name = "PasswordTextLabel";
            this.PasswordTextLabel.Size = new System.Drawing.Size(69, 17);
            this.PasswordTextLabel.TabIndex = 3;
            this.PasswordTextLabel.Text = "Password";
            // 
            // SingInButton
            // 
            this.SingInButton.Location = new System.Drawing.Point(145, 303);
            this.SingInButton.Name = "SingInButton";
            this.SingInButton.Size = new System.Drawing.Size(99, 37);
            this.SingInButton.TabIndex = 4;
            this.SingInButton.Text = "Sign In";
            this.SingInButton.UseVisualStyleBackColor = true;
            this.SingInButton.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // LogInErrorLabel
            // 
            this.LogInErrorLabel.AutoSize = true;
            this.LogInErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.LogInErrorLabel.Location = new System.Drawing.Point(68, 156);
            this.LogInErrorLabel.MaximumSize = new System.Drawing.Size(248, 40);
            this.LogInErrorLabel.Name = "LogInErrorLabel";
            this.LogInErrorLabel.Size = new System.Drawing.Size(59, 20);
            this.LogInErrorLabel.TabIndex = 5;
            this.LogInErrorLabel.Text = "ERROR";
            this.LogInErrorLabel.Visible = false;
            this.LogInErrorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignIn
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 374);
            this.Controls.Add(this.LogInErrorLabel);
            this.Controls.Add(this.SingInButton);
            this.Controls.Add(this.PasswordTextLabel);
            this.Controls.Add(this.EmailTextLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label EmailTextLabel;
        private System.Windows.Forms.Label PasswordTextLabel;
        private System.Windows.Forms.Button SingInButton;
        private System.Windows.Forms.Label LogInErrorLabel;
    }
}