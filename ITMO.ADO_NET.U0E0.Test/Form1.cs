using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace ITMO.ADO_NET.U0E0.Test
{
    public partial class Form1 : Form
    {
        static string sqlDateFormat = "yyyy-MM-dd";
        string connectionString = GetConnectionStringByName("DBConnect.AW2016ConnectionString");
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btnFillSales_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            double total = 0;
            string cmdSales = $"SELECT TOP(100) SalesOrderID, OrderDate, TotalDue " +
                $"FROM Sales.SalesOrderHeader " +
                $"WHERE OrderDate BETWEEN '{dateTimePickerFrom.Value.ToString(sqlDateFormat)}' " +
                $"AND '{dateTimePickerTo.Value.ToString(sqlDateFormat)}'";
            try
            {
                DataTable dt = DBManipulate.DTable(connectionString, cmdSales);
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    listView1.Items.Add(item);
                    total += double.Parse(row[2].ToString());
                }
                totalLabel.Text = "Total: " + total.ToString("f2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        double total = 0;
            //        string sqlDateFormat = "yyyy-MM-dd";
            //        string cmdSales = $"SELECT TOP(100) SalesOrderID, OrderDate, TotalDue " +
            //            $"FROM Sales.SalesOrderHeader " +
            //            $"WHERE OrderDate BETWEEN '{dateTimePickerFrom.Value.ToString(sqlDateFormat)}' " +
            //            $"AND '{dateTimePickerTo.Value.ToString(sqlDateFormat)}'";
            //        SqlCommand cmdSql = new SqlCommand(cmdSales, connection);

            //        connection.Open();

            //        SqlDataReader dr = cmdSql.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            ListViewItem newItem =
            //                listView1.Items.Add(dr[0].ToString());
            //            newItem.SubItems.Add(dr[1].ToString());
            //            newItem.SubItems.Add(dr[2].ToString());
            //            total += double.Parse(dr[2].ToString());
            //        }
            //        totalLabel.Text = "Total: " + total.ToString("f2");
            //        dr.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}

        }
    }
}
