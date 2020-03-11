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
    public partial class MainMenuForm : Form
    {
        protected string userType;
        private LoginForm loginForm;
        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\furry\\Documents\\Coursach\\BezuglyiSergeiCalls.mdb");

        public MainMenuForm(string userType, LoginForm loginForm)
        {
            InitializeComponent();
            this.userType = userType;
            this.loginForm = loginForm;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            loginForm.ClearFields();
            loginForm.Show();
            Close();
        }


        private void openSubscribersTableButton_Click(object sender, EventArgs e)
        {
            TableForm form = new TableForm("Subscribers", connection);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void openRatesTableButton_Click(object sender, EventArgs e)
        {
            TableForm form = new TableForm("Rates", connection);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void openCallsTableButton_Click(object sender, EventArgs e)
        {
            TableForm form = new TableForm("Calls", connection);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void openUsersTableButton_Click(object sender, EventArgs e)
        {
            TableForm form = new TableForm("Users", connection);
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
