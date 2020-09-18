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
        public SignIn(SqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }
    }
}
