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
        public OleDbCommand insertCommand = new OleDbCommand();

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
            table.Clear();
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
            updateCommand.ExecuteNonQuery();
            connection.Close();
            UpdateTable();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            switch (tableName)
            {
                case "Users":
                    AddUserForm formU = new AddUserForm(this);
                    formU.ShowDialog();
                    break;
                case "Rates":
                    AddRateForm formR = new AddRateForm(this);
                    formR.ShowDialog();
                    break;
                case "Calls":
                    AddCallForm formC = new AddCallForm(this);
                    formC.ShowDialog();
                    break;
                case "Subscriber":
                    AddSubscriberForm formS = new AddSubscriberForm(this);
                    formS.ShowDialog();
                    break;

            }


            if (insertCommand.CommandText != string.Empty)
            {
                insertCommand.Connection = connection;
                connection.Open();
                try
                {
                    insertCommand.ExecuteNonQuery();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
                UpdateTable();
                insertCommand.CommandText = string.Empty;
            }
        }
    }
}
