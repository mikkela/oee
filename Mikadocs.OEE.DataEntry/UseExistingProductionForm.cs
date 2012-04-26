using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Mikadocs.OEE.Repository;

namespace Mikadocs.OEE.DataEntry
{
    public partial class UseExistingProductionForm : Form
    {
        public UseExistingProductionForm()
        {
            InitializeComponent();

            SetTexts();
        }

        public UseExistingProductionForm(long lastProductionId)
            : this()
        {
            txtOrderNumber.Text = LoadOrderNumber(lastProductionId);
        }

        public Production Production
        {
            get
            {
                if (!String.IsNullOrEmpty(txtOrderNumber.Text))
                    return LoadProduction(txtOrderNumber.Text);

                return null;
            }
        }
        private void SetTexts()
        {
            lblText.Text = Strings.EnterExistingOrderNumber;
            lblHeader.Text = Strings.UseExistingOrder;
        }

        private string LoadOrderNumber(long productionId)
        {
            using (RepositoryFactory factory = new RepositoryFactory())
            {
                using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
                {
                    Production p = repository.Load(productionId);
                    if (p != null)
                        return p.Order.Number;
                }
            }

            return "";
        }

        private Production LoadProduction(string orderNumber)
        {
            using (RepositoryFactory factory = new RepositoryFactory())
            {
                using (IProductionQueryRepository repository = factory.CreateProductionQueryRepository())
                {
                    return repository.LoadProduction(new OrderNumber(orderNumber));
                }
            }
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
