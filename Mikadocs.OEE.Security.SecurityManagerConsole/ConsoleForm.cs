using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mikadocs.OEE.Security.SecurityManagerConsole
{
    public partial class ConsoleForm : Form
    {
        public ConsoleForm()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            canEditManagementConsoleCheckBox.Checked = SecurityManager.CanEditManagementConsole;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SecurityManager.CanEditManagementConsole = canEditManagementConsoleCheckBox.Checked;
        }
    }
}
