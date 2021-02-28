using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClass;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace CodeFirst
{
    public partial class Form1 : Form
    {
        CFContext context = new CFContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Customers.Load();
            customerDataGridView.DataSource = context.Customers.Local.ToBindingList();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    FirstName = this.firstNameTextBox.Text,
                    LastName = this.lastNameTextBox.Text,
                };
                context.Customers.Add(customer);
                context.SaveChanges();
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerDataGridView.CurrentRow == null) return;
            var customer = customerDataGridView.CurrentRow.DataBoundItem as Customer;
            if (customer == null) return;

            var custOrders = context.Orders.Where(o => o.CustomerId == customer.CustomerId).Select(o => new
            {
                Order = o.OrderId,
                Article = o.ProductId,
                Date = o.PurchaseDate
            });
            orderaDataGridView.DataSource = custOrders.ToList();
        }

        private void orderaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (orderaDataGridView.CurrentRow == null) return;
            var order = orderaDataGridView.CurrentRow.DataBoundItem as Order;
            if (order == null) return;

            var orderProd = context.Products.Where(p => p.ProductId == order.ProductId).Select(p => new
            {
                Product = p.ProductName,
                Price = p.Price
            });
            productDataGridView.DataSource = orderProd.ToList();
        }
    }
    
}
