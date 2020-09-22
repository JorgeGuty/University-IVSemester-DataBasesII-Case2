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
using System;
using System.Text;
using System.Security.Cryptography;
using Caso_2.Models;

namespace Caso_2.UI
{
    public partial class SignIn : Form
    {
        SqlConnection connection = DBConnection.getInstance().Connection;
        SqlCommand ExecuteLogin;
        SqlCommand ExecuteGetSucursalData;
        String permiso;
        public SignIn()
        {
           
            this.ExecuteLogin = new SqlCommand("SP_LogIn", this.connection);
            this.ExecuteLogin.CommandType = CommandType.StoredProcedure;
            this.ExecuteGetSucursalData = new SqlCommand("SP_getSucursalData", this.connection);
            this.ExecuteGetSucursalData.CommandType = CommandType.StoredProcedure;
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            String email = EmailTextBox.Text.Trim();
            String password = PasswordTextBox.Text.Trim();
            String emailPasswordConcat = email + password;
            String hashedPassword = StaticMethods.ComputeSha256Hash(emailPasswordConcat);


            ExecuteLogin.Parameters.Clear();
            ExecuteLogin.Parameters.Add("@pEmail", SqlDbType.VarChar, 100).Value = email;
            ExecuteLogin.Parameters.Add("@pPassword", SqlDbType.VarChar, 150).Value = hashedPassword;

            try
            {
                connection.Open();
                ExecuteLogin.ExecuteNonQuery();

                using (SqlDataReader reader = ExecuteLogin.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.permiso = String.Format("{0}", reader["Code"]);
                    }
                }
                connection.Close();
                Console.WriteLine(permiso);


                SucursalModel sucursalData = GetSucursalData(email);
                SucursalManagement sucursal = new SucursalManagement(this.permiso, sucursalData);
                sucursal.Show();
             
                

            }
            catch (Exception exeption)
            {
                LogInErrorLabel.Visible = true;
                LogInErrorLabel.Text = exeption.Message;
                connection.Close();
            }
        }

        private SucursalModel GetSucursalData(string pEmail)
        {
            SucursalModel sucursal = new SucursalModel();

            connection.Open();
            ExecuteGetSucursalData.Parameters.Clear();
            ExecuteGetSucursalData.Parameters.Add("@pEmail", SqlDbType.VarChar, 100).Value = pEmail;
            
            ExecuteGetSucursalData.ExecuteNonQuery();
            using (SqlDataReader reader = ExecuteGetSucursalData.ExecuteReader())
            {
                if (reader.Read())
                {
                    sucursal.Balance = Convert.ToString(reader["Balance"]);
                    sucursal.Name = Convert.ToString(reader["Name"]);
                }
            }
            connection.Close();

            return sucursal;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

