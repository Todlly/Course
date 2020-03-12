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
    public partial class UpdateQuery : Form
    {
        private TableForm parent;

        public UpdateQuery(DataTable table, TableForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            foreach(var column in table.Columns)
            {
                colBox.Items.Add(column.ToString());
                filterColBox.Items.Add(column.ToString());
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(colBox.SelectedItem != null && filterColBox.SelectedItem != null && newValueBox.Text != null && filterValueBox.Text != null)
            {
                OleDbCommand cmd = new OleDbCommand("UPDATE " + parent.tableName + " SET ? = ? WHERE ([?] = ?)");
                cmd.Parameters.AddWithValue("@OldValue", filterColBox.Text);
                cmd.Parameters.AddWithValue("@NewValue", newValueBox.Text);
                cmd.Parameters.AddWithValue("@Filter", filterColBox.Text);
                cmd.Parameters.AddWithValue("@FilterValue", filterValueBox.Text);

                parent.updateCommand = cmd;
                Close();
            }
        }
    }
}
