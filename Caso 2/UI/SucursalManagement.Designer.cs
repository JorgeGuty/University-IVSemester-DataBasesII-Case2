namespace Caso_2.UI
{
    partial class SucursalManagement
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
            this.NombreSucursalLabel = new System.Windows.Forms.Label();
            this.SaldoTextLabel = new System.Windows.Forms.Label();
            this.SaldoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TransactionsButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreSucursalLabel
            // 
            this.NombreSucursalLabel.AutoSize = true;
            this.NombreSucursalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreSucursalLabel.Location = new System.Drawing.Point(56, 14);
            this.NombreSucursalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreSucursalLabel.Name = "NombreSucursalLabel";
            this.NombreSucursalLabel.Size = new System.Drawing.Size(344, 84);
            this.NombreSucursalLabel.TabIndex = 0;
            this.NombreSucursalLabel.Text = "<Nombre sucursal>\r\n\r\n";
            this.NombreSucursalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SaldoTextLabel
            // 
            this.SaldoTextLabel.AutoSize = true;
            this.SaldoTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaldoTextLabel.Location = new System.Drawing.Point(20, 11);
            this.SaldoTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SaldoTextLabel.Name = "SaldoTextLabel";
            this.SaldoTextLabel.Size = new System.Drawing.Size(97, 64);
            this.SaldoTextLabel.TabIndex = 1;
            this.SaldoTextLabel.Text = "Saldo:\r\n\r\n";
            // 
            // SaldoLabel
            // 
            this.SaldoLabel.AutoSize = true;
            this.SaldoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaldoLabel.Location = new System.Drawing.Point(146, 11);
            this.SaldoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SaldoLabel.Name = "SaldoLabel";
            this.SaldoLabel.Size = new System.Drawing.Size(234, 32);
            this.SaldoLabel.TabIndex = 2;
            this.SaldoLabel.Text = "<Saldo sucursal>";
            this.SaldoLabel.Click += new System.EventHandler(this.SaldoLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaldoTextLabel);
            this.panel1.Controls.Add(this.SaldoLabel);
            this.panel1.Location = new System.Drawing.Point(459, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 94);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(123, 364);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(192, 41);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Habilitada";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TransactionsButton);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Location = new System.Drawing.Point(118, 419);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 111);
            this.panel2.TabIndex = 2;
            // 
            // TransactionsButton
            // 
            this.TransactionsButton.BackColor = System.Drawing.Color.Khaki;
            this.TransactionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TransactionsButton.Enabled = false;
            this.TransactionsButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsButton.Location = new System.Drawing.Point(460, 23);
            this.TransactionsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransactionsButton.Name = "TransactionsButton";
            this.TransactionsButton.Size = new System.Drawing.Size(226, 62);
            this.TransactionsButton.TabIndex = 6;
            this.TransactionsButton.Text = "Transacciones";
            this.TransactionsButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(230, 23);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(222, 62);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Tag = "delete";
            this.DeleteButton.Text = "Eliminar";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.YellowGreen;
            this.SaveButton.Enabled = false;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(4, 23);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(216, 62);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Salvar";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // SucursalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 589);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NombreSucursalLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SucursalManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Sucursal";
            this.Load += new System.EventHandler(this.SucursalManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreSucursalLabel;
        private System.Windows.Forms.Label SaldoTextLabel;
        private System.Windows.Forms.Label SaldoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TransactionsButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
    }
}