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
    public partial class UsersTableForm : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter ratesAdapter;
        private DataTable table = new DataTable();

        public UsersTableForm(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            connection.Open();
            ratesAdapter = new OleDbDataAdapter("SELECT * FROM Rates", connection);
            connection.Close();
            ratesAdapter.Fill(table);
            RatesTableView.DataSource = table;
        }
    }
}
