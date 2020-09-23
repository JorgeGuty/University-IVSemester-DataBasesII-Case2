using Caso_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_2.UI
{
    public partial class SucursalManagement : Form
    {
        SqlConnection connection = DBConnection.getInstance().Connection;
        String[] permiso;

        public SucursalManagement(String[] pPermiso, SucursalModel pSucursal)
        {            

            this.permiso = pPermiso;

            InitializeComponent();

            NombreSucursalLabel.Text = pSucursal.Name;
            SaldoLabel.Text = pSucursal.Balance;                        

            get_permission(this.permiso);

            Button[] buttons = { this.DeleteButton, this.SaveButton, this.TransactionsButton };

            foreach ( Button b in buttons)
            {
                if ((b.Tag != null)) // && (b.Tag.ToString() == this.permiso))
                {
                    b.Enabled = true;
                }
            }

            var checkbox = this.IsEnabledCheckBox;

            if ((checkbox.Tag != null)) //&& (checkbox.Tag.ToString() == this.permiso))
            {
                this.IsEnabledCheckBox.Enabled = true;
            }


        }

        private void get_permission(String[] permisos)
        {
            
            String[] codigos = { "69", "420", "69420", "42069" };
            this.SaveButton.Tag = null;
            this.IsEnabledCheckBox.Tag = null;
            this.DeleteButton.Tag = null;
            this.TransactionsButton.Tag = null;

            foreach (String permiso in permisos) {            
                if (permiso == codigos[1])
                {                    
                    this.SaveButton.Tag = permiso;                    
                    this.IsEnabledCheckBox.Tag = permiso;
                }
                if (permiso == codigos[2])
                {
                    this.DeleteButton.Tag = permiso;
                }
                if (permiso == codigos[3])
                {
                    this.TransactionsButton.Tag = permiso;
                }
            }            
        }
        private void SucursalManagement_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaldoLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
