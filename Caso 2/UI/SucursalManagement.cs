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
        SqlConnection con;
        String permiso;
        String idUser;
        public SucursalManagement(SqlConnection con, String permiso, String idUser)
        {
            this.con = con;
            this.permiso = permiso;
            this.idUser = idUser;

            InitializeComponent();

            this.DeleteButton.Tag = "delete";
            Button[] buttons = { this.DeleteButton, this.SaveButton, this.TransactionsButton };

            foreach( Button b in buttons)
            {
                if ((b.Tag != null) && (this.permiso == "1"))
                {
                    b.Enabled = true;
                }
            }
            this.checkBox1.Tag = "ka";
            if ((this.checkBox1.Tag != null) && (this.permiso == "1"))
            {
                this.checkBox1.Enabled = true;
            }

            this.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT saldo, nombre FROM [Sucursal] WHERE idUser=@idUser", this.con);
            cmd.Parameters.AddWithValue("@idUser", this.idUser);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    String saldo = reader["saldo"].ToString();
                    String nombre = reader["nombre"].ToString();
                    this.NombreSucursalLabel.Text = nombre;
                    this.SaldoLabel.Text = saldo;
                }
            }
            this.con.Close();

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
