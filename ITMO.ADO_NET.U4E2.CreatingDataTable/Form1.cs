using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO_NET.U4E2.CreatingDataTable
{
    public partial class Form1 : Form
    {
        private DataSet dataSet;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        public Form1()
        {
            InitializeComponent();
            MakeDataTables();
        }
        private void MakeParentTable()
        {
            DataTable pTable = new DataTable("ParentTable");
            DataColumn pColumn;
            DataRow pRow;

            pColumn = new DataColumn();
            pColumn.ColumnName = "pId";
            pColumn.DataType = System.Type.GetType("System.Int32");
            pColumn.AutoIncrement = true;
            pColumn.ReadOnly = true;
            pColumn.Unique = true;
            pTable.Columns.Add(pColumn);

            pColumn = new DataColumn();
            pColumn.ColumnName = "ParentItem";
            pColumn.DataType = System.Type.GetType("System.String");
            pColumn.AutoIncrement = false;
            pColumn.Caption = "ParentItem";
            pColumn.ReadOnly = false;
            pColumn.Unique = false;
            pTable.Columns.Add(pColumn);

            pTable.Columns.Add("Total", typeof(Double));
            pTable.Columns.Add("SalesTax", typeof(Double), "Total * 0.13");

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = pTable.Columns["id"];
            pTable.PrimaryKey = PrimaryKeyColumns;

            dataSet = new DataSet();
            dataSet.Tables.Add(pTable);

            for (int i = 0; i <= 2; i++)
            {
                pRow = pTable.NewRow();
                pRow["pId"] = i;
                pRow["ParentItem"] = "ParentItem " + i;
                pRow["Total"] = 2 * i + 0.5;
                pTable.Rows.Add(pRow);
            }
        }
        private void MakeChildTable()
        {
            DataTable cTable = new DataTable("ChildTable");
            DataColumn cColumn;
            DataRow cRow;

            cColumn = new DataColumn();
            cColumn.ColumnName = "cId";
            cColumn.DataType = System.Type.GetType("System.Int32");
            cColumn.AutoIncrement = true;
            cColumn.Unique = true;
            cColumn.Caption = "ID";
            cColumn.ReadOnly = true;
            cTable.Columns.Add(cColumn);

            cColumn = new DataColumn();
            cColumn.ColumnName = "ChildItem";
            cColumn.DataType = System.Type.GetType("System.String");
            cColumn.AutoIncrement = false;
            cColumn.Caption = "ChildItem";
            cColumn.Unique = false;
            cColumn.ReadOnly = false;
            cTable.Columns.Add(cColumn);

            cColumn = new DataColumn();
            cColumn.ColumnName = "parentId";
            cColumn.DataType = System.Type.GetType("System.Int32");
            cColumn.AutoIncrement = false;
            cColumn.Caption = "ParentID";
            cColumn.Unique = false;
            cColumn.ReadOnly = false;
            cTable.Columns.Add(cColumn);

            dataSet.Tables.Add(cTable);

            for (int i = 0; i <= 4; i++)
            {
                cRow = cTable.NewRow();
                cRow["cId"] = i;
                cRow["ChildItem"] = "Item " + i;
                cRow["parentId"] = 0;
                cTable.Rows.Add(cRow);
            }

            for (int i = 0; i <= 4; i++)
            {
                cRow = cTable.NewRow();
                cRow["cId"] = i + 5;
                cRow["ChildItem"] = "Item " + i;
                cRow["parentId"] = 1;
                cTable.Rows.Add(cRow);
            }

            for (int i = 0; i <= 4; i++)
            {
                cRow = cTable.NewRow();
                cRow["cId"] = i + 10;
                cRow["ChildItem"] = "Item " + i;
                cRow["parentId"] = 2;
                cTable.Rows.Add(cRow);
            }
        }
        private void MakeDataRelation()
        {
            DataColumn pColumn = dataSet.Tables["ParentTable"].Columns["pId"];
            DataColumn cColumn = dataSet.Tables["ChildTable"].Columns["parentId"];
            DataRelation relation = new DataRelation("parentToChild", pColumn, cColumn);
            dataSet.Tables["ChildTable"].ParentRelations.Add(relation);
        }
        private void BindToDataGreed()
        {
            bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dataSet.Tables["ParentTable"];
            
            bindingSource2 = new BindingSource();
            bindingSource2.DataSource = dataSet.Tables["ChildTable"];
        }
        private void MakeDataTables()
        {
            MakeParentTable();
            MakeChildTable();
            MakeDataRelation();
            BindToDataGreed();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bindingSource1;
        }
    }
}
