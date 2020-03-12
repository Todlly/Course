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
    public partial class LoginForm : Form
    {
        protected OleDbConnection connection;
        protected OleDbDataAdapter usersAdapter;
        protected DataTable usersTable = new DataTable();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\furry\\Documents\\Coursach\\BezuglyiSergeiCalls.mdb");
            connection.Open();
            usersAdapter = new OleDbDataAdapter("SELECT * FROM Users", connection);
            usersAdapter.Fill(usersTable);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;
            string password = pswdField.Text;

            for (int i = 0; i < usersTable.Rows.Count; i++)
            {
                DataRow row = usersTable.Rows[i];
                if (row[0].ToString() == login)
                {
                    if (row[1].ToString() == password)
                    {
                        Logon(row[2].ToString());
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                        return;
                    }
                }
            }

            MessageBox.Show("Wrong login");
        }

        private void Logon(string userType)
        {
            MainMenuForm menu = new MainMenuForm(userType, this);
            menu.Show();
            Hide();
        }

        public void ClearFields()
        {
            loginField.Clear();
            pswdField.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginField.Text = "god";
            pswdField.Text = "4321";
        }
    }
}
