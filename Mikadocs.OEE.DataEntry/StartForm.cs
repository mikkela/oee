using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mikadocs.OEE.DataEntry
{
    public partial class StartForm : Form
    {
       private class ProductionTeamComboBoxItem
        {
            private readonly ProductionTeam _productionTeam;

            public ProductionTeamComboBoxItem(ProductionTeam productionTeam)
            {
                this._productionTeam = productionTeam;
            }

            public ProductionTeam ProductionTeam
            {
                get { return _productionTeam; }
            }

            public override string ToString()
            {
                return _productionTeam.Name;
            }
        }

        public StartForm(IEnumerable<ProductionTeam> availableTeams, OrderNumber orderNumber)
        {
            InitializeComponent();

            FillInProductionTeams(availableTeams);

            SetTexts();
            txtOrder.Text = orderNumber.Number;
        }

        public OrderNumber Order
        {
            get { return new OrderNumber(txtOrder.Text);}
        }

        public DateTime Date
        {
            get
            {
                return dtStartDate.Value.Date;
            }
        }

        public ProductionTeam Team
        {
            get { return ((ProductionTeamComboBoxItem)cbTeam.SelectedItem).ProductionTeam; }
        }

        private void OnTextBoxKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FillInProductionTeams(IEnumerable<ProductionTeam> availableTeams)
        {
            var list = new List<ProductionTeamComboBoxItem>();
            foreach (ProductionTeam team in availableTeams)
            {
                list.Add(new ProductionTeamComboBoxItem(team));
            }
            cbTeam.DataSource = list;
        }

        private void SetTexts()
        {
            lblOrder.Text = Strings.Order;
            lblStartDate.Text = Strings.ProductionShiftStartDate;
            lblTeam.Text = Strings.ProductionShiftTeam;
            
            lblHeader.Text = "Start";
        }

        private void OnTextBoxEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            dtStartDate.Value = DateTime.Now.Date;
        }
        
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }

        private void OnOrderValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(txtOrder.Text))
                e.Cancel = true;
        }

    }
}
