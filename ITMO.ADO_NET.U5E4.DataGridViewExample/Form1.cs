using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO_NET.U5E4.DataGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. 
            //  You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            DataColumn Location = new DataColumn("Location");
            Location.Expression = "City + ',' + Country";
            northwindDataSet.Customers.Columns.Add(Location);
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn LocationColumn = new DataGridViewTextBoxColumn();
            LocationColumn.Name = "LocationColumn";
            LocationColumn.HeaderText = "Location";
            LocationColumn.DataPropertyName = "Location";
            customersDataGridView.Columns.Add(LocationColumn);
        }

        private void DeleteColumnButton_Click(object sender, EventArgs e)
        {
            try
            {
                customersDataGridView.Columns.Remove("LocationColumn");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetClickedCellButton_Click(object sender, EventArgs e)
        {
            string currentCellInfo;
            currentCellInfo = customersDataGridView.CurrentCell.Value.ToString() + Environment.NewLine;
            currentCellInfo += "Column: " + 
                customersDataGridView.CurrentCell.OwningColumn.DataPropertyName + Environment.NewLine;
            currentCellInfo += "Column Index: " + 
                customersDataGridView.CurrentCell.ColumnIndex.ToString() + Environment.NewLine;
            currentCellInfo += "Row Index: " + 
                customersDataGridView.CurrentCell.RowIndex.ToString() + Environment.NewLine;
            label1.Text = currentCellInfo;
        }

        private void customersDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (customersDataGridView.Columns[e.ColumnIndex].DataPropertyName == "ContactName")
            {
                if (e.FormattedValue.ToString() == "")
                {
                    customersDataGridView.Rows[e.RowIndex].ErrorText = "Contact name is required field";
                    e.Cancel = true;
                }
                else
                {
                    customersDataGridView.Rows[e.RowIndex].ErrorText = "";
                }
            }
        }

        private void ApplyStyleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ApplyStyleButton.Checked == true)
            {
                customersDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                customersDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
