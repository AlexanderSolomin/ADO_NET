using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ITMO.ADO_NET.U1E2.DBConnection
{
    class WorkWithDataBase
    {
        public static int ExecuteScalarMetod(string connStr, string cmdTxt)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand cmdSql = new SqlCommand(cmdTxt, connection);
                connection.Open();
                return (int)cmdSql.ExecuteScalar();
            }
        }
    }
}
