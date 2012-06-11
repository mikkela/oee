using System;
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

        private static string LoadOrderNumber(long productionId)
        {
            using (var factory = new RepositoryFactory())
            {
                var p = factory.CreateEntityRepository().Load<Production>(productionId);
                if (p != null)
                    return p.Order.Number;
            }

            return "";
        }

        private static Production LoadProduction(string orderNumber)
        {
            using (var factory = new RepositoryFactory())
            {
                return factory.CreateProductionQueryRepository(true).LoadProduction(new OrderNumber(orderNumber));                
            }
        }

        private static void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private static void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }
    }
}
