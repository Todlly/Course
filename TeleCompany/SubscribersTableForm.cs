using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TeleCompany
{
    public partial class SubscribersTableForm : Form
    {
        protected OleDbDataAdapter subscribersAdapter;
        protected DataTable table = new DataTable();
        public OleDbCommand updateCommand;
        private OleDbConnection connection;

        public SubscribersTableForm(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            connection.Open();
            subscribersAdapter = new OleDbDataAdapter("SELECT * FROM Subscribers", connection);
            connection.Close();
            subscribersAdapter.Fill(table);
            SubscribersTableView.DataSource = table;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateQuery update = new UpdateQuery(table, this);
            update.ShowDialog();
            updateCommand.Connection = connection;
            connection.Open();
            updateCommand.ExecuteNonQuery();
            connection.Close();
            Refresh();
        }
    }
}
