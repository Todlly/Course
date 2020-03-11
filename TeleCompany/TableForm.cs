using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeleCompany
{
    public partial class TableForm : Form
    {
        private OleDbDataAdapter adapter;
        private DataTable table = new DataTable();
        protected OleDbConnection connection;
        public string tableName;
        public OleDbCommand updateCommand = new OleDbCommand();
            
        public TableForm(string tableName, OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.tableName = tableName;
            UpdateTable();
            updateCommand.Connection = connection;
        }

        private void UpdateTable()
        {
            connection.Open();
            adapter = new OleDbDataAdapter("SELECT * FROM " + tableName, connection);
            connection.Close();
            adapter.Fill(table);
            tableView.DataSource = table;
            Refresh();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateQuery update = new UpdateQuery(table, this);
            update.ShowDialog();
            connection.Open();
            updateCommand.Connection = connection;
            adapter.UpdateCommand = updateCommand;
            adapter.UpdateCommand.ExecuteNonQuery();
            connection.Close();
            UpdateTable();
        }
    }
}
