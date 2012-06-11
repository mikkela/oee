using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mikadocs.OEE.UserControls
{
    public partial class ProductionFilterUserControl : UserControl
    {
        public event EventHandler<EventArgs> FilterChanged;

        public ProductionFilterUserControl()
        {
            InitializeComponent();
        }

        public void Initialize(IList<string> machineNames, IEnumerable<ProductionTeam> teams)
        {
            cbMachine.DataSource = machineNames;
            cbMachine.SelectedItem = null;

            cbTeam.DataSource = teams;
            cbTeam.DisplayMember = "Name";
            cbTeam.SelectedItem = null;
        }
        
        public Repository.ProductionQuery Query
        {
            get
            {
                var result = new Repository.ProductionQuery().AddDateRange(dtPeriodStart.Value, dtPeriodEnd.Value);

                if (!string.IsNullOrEmpty(txtProduct.Text))
                    result = result.AddProduct(new ProductNumber(txtProduct.Text));

                if (!string.IsNullOrEmpty(txtOrder.Text))
                    result = result.AddOrder(new OrderNumber(txtOrder.Text));

                if (cbMachine.SelectedItem != null)
                    result = result.AddMachine(cbMachine.SelectedItem.ToString());
                if (cbTeam.SelectedItem != null)
                    result = result.AddTeam((ProductionTeam)cbTeam.SelectedItem);

                return result;
            }
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            if (FilterChanged != null)
                FilterChanged(this, EventArgs.Empty);
        }

    }
}
