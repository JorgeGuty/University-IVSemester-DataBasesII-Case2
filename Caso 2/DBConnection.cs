using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Caso_2
{
    public class DBConnection
    {
        private string connectionString = @"Data Source=(local); Initial Catalog=Caso2_BDII; Integrated Security=True;";
        public SqlConnection Connection;
        public static DBConnection Singleton;

        private DBConnection()
        {
            Connection = new SqlConnection();
            Connection.ConnectionString = connectionString;
        }

        public static DBConnection getInstance()
        {

            if (Singleton == null) Singleton = new DBConnection();
            return Singleton ;
        }
    }
}
