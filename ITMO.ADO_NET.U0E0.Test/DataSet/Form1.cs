using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aWDataSet.Product;
            productTableAdapter.Fill(aWDataSet.Product);
        }
        private AWDataSet.ProductRow GetSelectedRow()
        {
            var SelectedProductID = dataGridView1.CurrentRow.Cells["ProductID"].Value;
            AWDataSet.ProductRow SelectedRow = aWDataSet.Product.FindByProductID((int)SelectedProductID);
            return SelectedRow;
        }

        private void btn_addRow_Click(object sender, EventArgs e)
        {
            try
            {
                AWDataSet.ProductRow row = (AWDataSet.ProductRow)aWDataSet.Product.NewRow();
                //перечень row.xxxx значений
                aWDataSet.Product.Rows.Add(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_delRow_Click(object sender, EventArgs e)
        {
            try
            {
                GetSelectedRow().Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (aWDataSet.HasChanges())
            {
                try
                {
                    int changes = aWDataSet.Product.GetChanges().Rows.Count;
                    productTableAdapter.Update(aWDataSet);
                    MessageBox.Show($"Total changes saved: {changes}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Nothing to save");
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            if (aWDataSet.HasChanges())
            {
                try
                {
                    int changes = aWDataSet.Product.GetChanges().Rows.Count;
                    MessageBox.Show($"Total changes is rejected: {changes}");
                    aWDataSet.RejectChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Nothing to reject");
        }
    }
}
