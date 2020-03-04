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


        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void openSubscribersTableButton_Click(object sender, EventArgs e)
        {
            SubscribersTableForm form = new SubscribersTableForm(connection);
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
