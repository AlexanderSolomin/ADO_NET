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
        SqlConnection connection = new SqlConnection();
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

        private void btnFill_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    double total = 0;
                    string sqlDateFormat = "yyyy-MM-dd";
                    string cmdSales = $"SELECT TOP(100) SalesOrderID, OrderDate, TotalDue " +
                        $"FROM Sales.SalesOrderHeader " +
                        $"WHERE OrderDate BETWEEN '{dateTimePickerFrom.Value.ToString(sqlDateFormat)}' " +
                        $"AND '{dateTimePickerTo.Value.ToString(sqlDateFormat)}'";
                    SqlCommand cmdSql = new SqlCommand(cmdSales, connection);

                    connection.Open();
                    
                    SqlDataReader dr = cmdSql.ExecuteReader();
                    while (dr.Read())
                    {
                        ListViewItem newItem =
                            listView1.Items.Add(dr[0].ToString());
                        newItem.SubItems.Add(dr[1].ToString());
                        newItem.SubItems.Add(dr[2].ToString());
                        total += double.Parse(dr[2].ToString());
                    }
                    totalLabel.Text = "Total: " + total.ToString("f2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            //SqlDataReader dr = DBManipulate.SalesTable(connectionString, dateTimePickerFrom.Value, dateTimePickerTo.Value);
        }
    }
}
