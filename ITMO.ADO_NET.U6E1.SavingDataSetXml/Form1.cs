using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO_NET.U6E1.SavingDataSetXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FillDataSetButton_Click(object sender, EventArgs e)
        {
            CustomersAdapter.Fill(NorthwindDataSet.Customers);
            OrdersAdapter.Fill(NorthwindDataSet.Orders);
            CustomersGrid.DataSource = NorthwindDataSet.Customers;
        }

        private void SaveXmlDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                NorthwindDataSet.WriteXml("Northwind.xml");
                MessageBox.Show("Data save as xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveXmlSchemaButton_Click(object sender, EventArgs e)
        {
            try
            {
                NorthwindDataSet.WriteXmlSchema("Northwind.xsd");
                MessageBox.Show("Data save as xsd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
