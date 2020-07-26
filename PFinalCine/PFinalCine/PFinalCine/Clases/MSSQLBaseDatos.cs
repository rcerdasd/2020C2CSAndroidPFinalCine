using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Microsoft.SqlServer;

namespace PFinalCine.Clases
{
    
    
    class MSSQLBaseDatos
    {
        SqlConnection conn;
        string connString = @"Data Source=MSI\MSSQLSERVERDEV19;Initial Catalog=ProyectoC#;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //string connString = @"Data Source=MSI\MSSQLSERVERDEV19; Database=ProyectoC#; Id=rolando; Password=cucaracha11";
        public bool AgregarUsuario(string query)
        {
            conn = new SqlConnection(connString);

            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                conn.Close();
                return false;
            }
        }

    }

    
}
