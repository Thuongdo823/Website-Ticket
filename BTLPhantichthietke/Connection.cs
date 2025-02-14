using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BTLPhantichthietke
{
    internal class Connection
    {
        private static string connection = @"Data Source=DESKTOP-45OBPIT\SQLEXPRESS;Initial Catalog=QUANLYCHUYENDI;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connection);
        }


    }
}
