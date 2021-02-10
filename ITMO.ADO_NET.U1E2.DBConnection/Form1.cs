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
using System.Configuration;

namespace ITMO.ADO_NET.U1E2.DBConnection
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;
        //        Integrated Security=true";
        string connectionString = GetConnectionStringByName("DBConnect.NorthwindConnectionString");
        public Form1()
        {
            InitializeComponent();
            this.connection.StateChange += new StateChangeEventHandler(this.connection_StateChange);
        }
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
             ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            connectToolStripMenuItem1.Enabled =
            (e.CurrentState == ConnectionState.Closed);
            AsyncToolStripMenuItem.Enabled =
            (e.CurrentState == ConnectionState.Closed);
            disconnectToolStripMenuItem1.Enabled =
            (e.CurrentState == ConnectionState.Open);
        }
        private void connectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных " +
                    connection.Database + " выполнено успешно " + "\nСервер: " +
                    connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (SqlException XcpSQL)
            {
                foreach (SqlError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "Источник ошибки: " + se.Source,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
        private void disconnectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }
        private async void AsyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    await connection.OpenAsync();
                    MessageBox.Show("Соединение с базой данных " +
                    connection.Database + " выполнено успешно " + "\nСервер: " +
                    connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connectionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    string str = String.Format("Name = {0}\nProviderName = {1}" +
                        "\nConnectionString = {2}", cs.Name, cs.ProviderName, cs.ConnectionString);
                    MessageBox.Show(str, "Параметры подключений");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (connection)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Подключитесь к базе!");
                    return;
                }
                string cmdTxt = "SELECT COUNT(*) FROM Products";
                SqlCommand cmdSql = new SqlCommand(cmdTxt, connection);
                try
                {
                    int cmdReturn = (int)cmdSql.ExecuteScalar();
                    label1.Text = cmdReturn.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string cmdTxt = "SELECT COUNT(*) FROM Products";
            try
            {
                int cmdReturn = WorkWithDataBase.ExecuteScalarMetod(connectionString, cmdTxt);
                label2.Text = cmdReturn.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

