using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ITMO.ADO_NET.U0E0.Test
{
    class DBManipulate
    {
        public static int ExecuteScalarMethod(string cs, string cmdTxt)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand cmdSql = new SqlCommand(cmdTxt, connection);
                connection.Open();
                return (int)cmdSql.ExecuteScalar();
            }
        }
        //public static object SalesTable(string cs, DateTime dateFrom, DateTime dateTo)
        //{
        //    using (SqlConnection connection = new SqlConnection(cs))
        //    {
        //        string sqlDateFormat = "yyyy-MM-dd";
        //        string cmdSales = $"SELECT TOP(100) SalesOrderID, OrderDate, TotalDue " +
        //            $"FROM Sales.SalesOrderHeader " +
        //            $"WHERE OrderDate BETWEEN '{dateFrom.ToString(sqlDateFormat)}' " +
        //            $"AND '{dateTo.ToString(sqlDateFormat)}'";
        //        SqlCommand cmdSql = new SqlCommand(cmdSales, connection);
        //        connection.Open();
        //        SqlDataReader dr = cmdSql.ExecuteReader();

        //        return dr;
        //    }
        //}
    }
}
