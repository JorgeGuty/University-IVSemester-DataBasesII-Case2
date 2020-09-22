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
            this.IsEnabledCheckBox = new System.Windows.Forms.CheckBox();
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
            this.NombreSucursalLabel.Location = new System.Drawing.Point(37, 9);
            this.NombreSucursalLabel.Name = "NombreSucursalLabel";
            this.NombreSucursalLabel.Size = new System.Drawing.Size(224, 58);
            this.NombreSucursalLabel.TabIndex = 0;
            this.NombreSucursalLabel.Text = "<Nombre sucursal>\r\n\r\n";
            this.NombreSucursalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SaldoTextLabel
            // 
            this.SaldoTextLabel.AutoSize = true;
            this.SaldoTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaldoTextLabel.Location = new System.Drawing.Point(13, 7);
            this.SaldoTextLabel.Name = "SaldoTextLabel";
            this.SaldoTextLabel.Size = new System.Drawing.Size(56, 40);
            this.SaldoTextLabel.TabIndex = 1;
            this.SaldoTextLabel.Text = "Saldo:\r\n\r\n";
            // 
            // SaldoLabel
            // 
            this.SaldoLabel.AutoSize = true;
            this.SaldoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaldoLabel.Location = new System.Drawing.Point(97, 7);
            this.SaldoLabel.Name = "SaldoLabel";
            this.SaldoLabel.Size = new System.Drawing.Size(140, 20);
            this.SaldoLabel.TabIndex = 2;
            this.SaldoLabel.Text = "<Saldo sucursal>";
            this.SaldoLabel.Click += new System.EventHandler(this.SaldoLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaldoTextLabel);
            this.panel1.Controls.Add(this.SaldoLabel);
            this.panel1.Location = new System.Drawing.Point(306, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 60);
            this.panel1.TabIndex = 0;
            // 
            // IsEnabledCheckBox
            // 
            this.IsEnabledCheckBox.AutoSize = true;
            this.IsEnabledCheckBox.Enabled = false;
            this.IsEnabledCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsEnabledCheckBox.Location = new System.Drawing.Point(82, 233);
            this.IsEnabledCheckBox.Name = "IsEnabledCheckBox";
            this.IsEnabledCheckBox.Size = new System.Drawing.Size(120, 29);
            this.IsEnabledCheckBox.TabIndex = 1;
            this.IsEnabledCheckBox.Text = "Habilitada";
            this.IsEnabledCheckBox.UseVisualStyleBackColor = true;
            this.IsEnabledCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TransactionsButton);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Location = new System.Drawing.Point(79, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 71);
            this.panel2.TabIndex = 2;
            // 
            // TransactionsButton
            // 
            this.TransactionsButton.BackColor = System.Drawing.Color.Khaki;
            this.TransactionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TransactionsButton.Enabled = false;
            this.TransactionsButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsButton.Location = new System.Drawing.Point(307, 15);
            this.TransactionsButton.Name = "TransactionsButton";
            this.TransactionsButton.Size = new System.Drawing.Size(151, 40);
            this.TransactionsButton.TabIndex = 6;
            this.TransactionsButton.Text = "Transacciones";
            this.TransactionsButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(153, 15);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(148, 40);
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
            this.SaveButton.Location = new System.Drawing.Point(3, 15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(144, 40);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Salvar";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // SucursalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 377);
            this.Controls.Add(this.IsEnabledCheckBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NombreSucursalLabel);
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
        private System.Windows.Forms.CheckBox IsEnabledCheckBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TransactionsButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
    }
}