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

        public SubscribersTableForm(OleDbConnection connection)
        {
            InitializeComponent();
            connection.Open();
            subscribersAdapter = new OleDbDataAdapter("SELECT * FROM Subscribers", connection);
            connection.Close();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // tableAdapter.UpdateCommand = new OleDbCommandBuilder(tableAdapter).GetUpdateCommand();
            subscribersBindingSource.EndEdit();
            subscribersTableAdapter.Update(subscribersDataSet);
            Close();
        }

        private void SubscribersTableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'subscribersDataSet.Subscribers' table. You can move, or remove it, as needed.
            this.subscribersTableAdapter.Fill(this.subscribersDataSet.Subscribers);

        }
    }
}
