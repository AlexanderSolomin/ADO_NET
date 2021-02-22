using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ITMO.ADO_NET.U0E0.Test
{
    class DBManipulate
    {
        public static int ScalarMethod(string cs, string cmd)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand cmdSql = new SqlCommand(cmd, connection);
                connection.Open();
                return (int)cmdSql.ExecuteScalar();
            }
        }
        public static DataTable DTable(string cs, string cmd)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand cmdSql = new SqlCommand(cmd, connection);
                DataTable dt = new DataTable();
                connection.Open();
                dt.Load(cmdSql.ExecuteReader());
                return dt;
            }
        }
    }
}
