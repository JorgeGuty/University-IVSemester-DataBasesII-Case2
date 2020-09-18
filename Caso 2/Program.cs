using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Caso_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string conn_string = "Server = localhost; Database=Caso2_DBII; Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(conn_string);
            con.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.SignIn(con));
            con.Close();
        }
    }
}
