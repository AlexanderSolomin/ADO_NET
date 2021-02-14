using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO_NET.U4E1.DatasetDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet NorthwindDataSet1 = new NorthwindDataSet();
            NorthwindDataSetTableAdapters.CustomersTableAdapter CustomersTableAdapter1 =
                new NorthwindDataSetTableAdapters.CustomersTableAdapter();
            CustomersTableAdapter1.Fill(NorthwindDataSet1.Customers);
            foreach  (NorthwindDataSet.CustomersRow NWCustomers in NorthwindDataSet1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomers.CompanyName);
            }
        }
    }
}
