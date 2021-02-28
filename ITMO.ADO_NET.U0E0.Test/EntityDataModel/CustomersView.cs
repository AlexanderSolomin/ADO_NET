using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EntityDataModel
{
    public partial class CustomersView : Form
    {
        private SimpleDBEntities customersContext;
        public CustomersView()
        {
            InitializeComponent();
        }

        private void CustomersView_Load(object sender, EventArgs e)
        {
            customersContext = new SimpleDBEntities();
            customerDataGridView.DataSource = customersContext.Customers.ToList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                customersContext.SaveChanges();
                MessageBox.Show($"Changes sucsessfully saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
