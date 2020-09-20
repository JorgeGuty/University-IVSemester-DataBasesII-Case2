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
        public SucursalManagement(SqlConnection con)
        {
            this.con = con;
            InitializeComponent();

            foreach (Control c in Controls)
            {
                // En ese 1==1 va el permiso, pero nunca me sirvió la conexión a la base
                if ((c.Tag != null) || (1==1))
                {
                    c.Enabled = true;
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
    }
}
