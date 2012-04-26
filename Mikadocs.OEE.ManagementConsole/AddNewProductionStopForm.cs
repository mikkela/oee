using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mikadocs.OEE.ManagementConsole
{
    public partial class AddNewProductionStopForm : Form
    {
        public AddNewProductionStopForm()
        {
            InitializeComponent();

            SetText();
        }

        public string ProductionStopName
        {
            get { return txtProductionStopName.Text; }
        }

        private void SetText()
        {
            lblHeader.Text = Strings.AddNewProductionStopHeader;
            lblText.Text = Strings.AddNewProdocutionStopText;
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
