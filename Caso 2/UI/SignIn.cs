using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_2.UI
{
    public partial class SignIn : Form
    {
        SqlConnection con;
        String permiso;
        public SignIn(SqlConnection con)
        {
            this.con = con;
            this.con.Close();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_LogIn", this.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@pEmail", SqlDbType.VarChar).Value = textBox1.Text.Trim();
            cmd.Parameters.Add("@pPassword", SqlDbType.VarChar).Value = textBox2.Text.Trim();

            cmd.ExecuteNonQuery();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {                    
                    this. permiso = String.Format("{0}", reader["Codigo"]);                    
                }                
            }
            con.Close();

            // ¿DE DONDE SALE EL idUSER PARA MOSTRAR LOS DATOS DE LA SUCURSAL?

            String idUser = "1" ;
            if ( idUser != null )
            {
                SucursalManagement sucursal = new SucursalManagement(this.con, this.permiso, idUser);
                sucursal.Show();
            }
                
        }            
        
    }
}
