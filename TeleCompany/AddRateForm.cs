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
    public partial class AddRateForm : Form
    {
        private TableForm parent;

        public AddRateForm(TableForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control.Text == string.Empty)
                {
                    MessageBox.Show("Fill all the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int cityCode = new int();
            double localRate = new double();
            double longRate = new double();

            if (!int.TryParse(cityCodeBox.Text, out cityCode) || !double.TryParse(localRateBox.Text, out localRate) || !double.TryParse(longRateBox.Text, out longRate))
                return;

            string cityName = cityNameBox.Text;

            OleDbCommand cmd = new OleDbCommand("INSERT INTO Rates ([CityCode], [CityName], [LocalRate], [LongDistanceRate])" + " VALUES (?, ?, ?, ?)");
            cmd.Parameters.AddWithValue("@Code", cityCode);
            cmd.Parameters.AddWithValue("@Name", cityName);
            cmd.Parameters.AddWithValue("@LocalRate", localRate);
            cmd.Parameters.AddWithValue("@LongRate", longRate);

            parent.insertCommand = cmd;
            Close();
        }
    }
}
