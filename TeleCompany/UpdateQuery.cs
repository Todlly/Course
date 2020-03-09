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
        private SubscribersTableForm parent;

        public UpdateQuery(DataTable table, SubscribersTableForm parent)
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
                parent.updateCommand = new OleDbCommand(@"UPDATE Subscribers SET @ColValue = @NewValue WHERE @Filter = @FilterValue");
                parent.updateCommand.Parameters.AddWithValue("@ColValue", colBox.Text);
                parent.updateCommand.Parameters.AddWithValue("@NewValue", newValueBox.Text);
                parent.updateCommand.Parameters.AddWithValue("@Filter", filterColBox.Text);
                parent.updateCommand.Parameters.AddWithValue("@FilterValue", filterValueBox.Text);
                Close();
            }
        }
    }
}
