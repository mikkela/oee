using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mikadocs.OEE.Security;

namespace Mikadocs.OEE.ManagementConsole
{
    public partial class ManageDataForm : Form
    {
        public ManageDataForm()
        {
            InitializeComponent();

            this.btnAdd.Enabled = SecurityManager.CanEditManagementConsole;
            this.btnDelete.Enabled = SecurityManager.CanEditManagementConsole;
            this.btnSave.Enabled = SecurityManager.CanEditManagementConsole;
            this.txtHeader.Text = Strings.Header;
        }

        private void OnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ucProductionDataGrid.Load();
        }

        private void OnSave(object sender, EventArgs e)
        {
            ucProductionDataGrid.Save();
        }

        private void OnDelete(object sender, EventArgs e)
        {
            ucProductionDataGrid.Delete();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }

        private void OnAdd(object sender, EventArgs e)
        {
            ucProductionDataGrid.Add();
            
        }
    }
}
