using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Mikadocs.OEE.Repository;
using Mikadocs.OEE.Security;

namespace Mikadocs.OEE.ManagementConsole
{
    public partial class SetupMachineForm : Form
    {
        public SetupMachineForm()
        {
            InitializeComponent();

            this.txtHeader.Text = Strings.Header;
            btnSave.Enabled = SecurityManager.CanEditManagementConsole;
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (!DesignMode)
                ucMachineConfiguration.Save();
        }

        private void OnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (!DesignMode)
                ucMachineConfiguration.Load();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }
    }
}
