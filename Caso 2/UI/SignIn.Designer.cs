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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EmailTextLabel = new System.Windows.Forms.Label();
            this.PasswordTextLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 22);
            this.textBox2.TabIndex = 1;
            // 
            // EmailTextLabel
            // 
            this.EmailTextLabel.AutoSize = true;
            this.EmailTextLabel.Location = new System.Drawing.Point(12, 9);
            this.EmailTextLabel.Name = "EmailTextLabel";
            this.EmailTextLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailTextLabel.TabIndex = 2;
            this.EmailTextLabel.Text = "Email";
            // 
            // PasswordTextLabel
            // 
            this.PasswordTextLabel.AutoSize = true;
            this.PasswordTextLabel.Location = new System.Drawing.Point(12, 81);
            this.PasswordTextLabel.Name = "PasswordTextLabel";
            this.PasswordTextLabel.Size = new System.Drawing.Size(69, 17);
            this.PasswordTextLabel.TabIndex = 3;
            this.PasswordTextLabel.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SignIn
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordTextLabel);
            this.Controls.Add(this.EmailTextLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label EmailTextLabel;
        private System.Windows.Forms.Label PasswordTextLabel;
        private System.Windows.Forms.Button button1;
    }
}