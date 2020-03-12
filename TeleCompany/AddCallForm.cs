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
    public partial class AddCallForm : Form
    {
        private TableForm parent;

        public AddCallForm(TableForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Text == string.Empty)
                {
                    MessageBox.Show("Fill all the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DataSetDateTime date = new DataSetDateTime();
            int cityCode = new int();
            int duration = new int();
            int phone = new int();

            if (!int.TryParse(subIDBox.Text, out int subID) || !DataSetDateTime.TryParse(dateBox.Text, out date) || !int.TryParse(cityCodeBox.Text, out cityCode)
                || !int.TryParse(durationBox.Text, out duration) || !int.TryParse(phoneNumberBox.Text, out phone))
                return;

            OleDbCommand cmd = new OleDbCommand("INSERT INTO Calls ([Subscriberid], [CallDate], [CityCode], [CallType], [CallDuration], [TelephoneNumber])" + "VALUES (?, ?, ?, ?, ?, ?)");
            cmd.Parameters.AddWithValue("@ID", subID);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Code", cityCode);
            cmd.Parameters.AddWithValue("@Type", callTypeBox.Text);
            cmd.Parameters.AddWithValue("@Duration", duration);
            cmd.Parameters.AddWithValue("@Number", phone);

            parent.insertCommand = cmd;
            Close();

        }
    }
}
