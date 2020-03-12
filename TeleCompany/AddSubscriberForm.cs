using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeleCompany
{
    public partial class AddSubscriberForm : Form
    {
        private TableForm parent;

        public AddSubscriberForm(TableForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
    }
}
