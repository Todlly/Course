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
    public partial class AddUserForm : Form
    {
        private TableForm parent;

        public AddUserForm(TableForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string login = userLoginBox.Text;
            string password = userPswdBox.Text;
            string type = userTypeBox.Text;

            if(login == string.Empty)
            {
                MessageBox.Show("Enter login", "Attention", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                return;
            }
            if(type == string.Empty)
            {
                MessageBox.Show("Choose user type", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(password == string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("You entered an empty password. Are you sure?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            OleDbCommand cmd = new OleDbCommand("INSERT INTO Users ([Username], [Password], [UserType])" + " VALUES (?, ?, ?)");
            cmd.Parameters.AddWithValue("@Username", login);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@UserType", type);

            parent.insertCommand = cmd;
            Close();
        }
    }
}
