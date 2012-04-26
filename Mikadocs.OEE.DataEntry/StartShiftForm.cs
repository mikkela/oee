using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Mikadocs.OEE.DataEntry
{
    public partial class StartShiftForm : Form
    {
        private Production production;
        private DateTime date;
        public StartShiftForm()
        {
            InitializeComponent();

            cbMachines.DataSource = Settings.Default.Machines;
            ucStartTime.Value = DateTime.Now.TimeOfDay;
            SetTexts();
        }

        public StartShiftForm(Production p, DateTime date) : this()
        {
            if (p != null)
            {
                Machine = p.Machine;
                Product = p.Product;
                ExpectedItems = p.ExpectedItems;
                ProducedItemsPerHour = p.ProducedItemsPerHour;
                ValidatedSetupTime = p.ValidatedStartTime;
                production = p;                
            }
            this.date = date;
        }

        public string Machine
        {
            get { return cbMachines.SelectedItem.ToString(); }
            private set
            {
                cbMachines.SelectedItem = value;
                cbMachines.Enabled = false;
            }
        }

        public ProductNumber Product
        {
            get { return new ProductNumber(txtProduct.Text); }
            private set
            {
                txtProduct.Text = value.Number;
                txtProduct.Enabled = false;
            }
        }

        public long ExpectedItems
        {
            get { return long.Parse(txtExpectedItems.Text); }
            private set
            {
                txtExpectedItems.Text = value.ToString();
                txtExpectedItems.Enabled = false;
            }
        }

        public long ProducedItemsPerHour
        {
            get { return long.Parse(txtProducedItemsPerHour.Text); }
            private set
            {
                txtProducedItemsPerHour.Text = value.ToString();
                txtProducedItemsPerHour.Enabled = false;
            }
        }

        public DateTime StartTime
        {
            get { return date.Add(ucStartTime.Value); }
        }

        public TimeSpan ValidatedSetupTime
        {
            get { return new TimeSpan(0, int.Parse(txtValidatedSetupTime.Text), 0); }
            private set
            {
                txtValidatedSetupTime.Text = value.TotalMinutes.ToString();
                txtValidatedSetupTime.Enabled = false;
            }

        }

        public long StartCounter
        {
            get { return 0; }
        }
        private void OnNumericTextBoxKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SetTexts()
        {
            lblMachine.Text = Strings.Machine;
            lblProduct.Text = Strings.Product;
            
            lblExpectedItems.Text = Strings.ExpectedItems;
            lblProducedItemsPerHour.Text = Strings.ProducedItemsPerHour;
            
            lblStartTime.Text = Strings.ProductionShiftStartTime;
            lblHeader.Text = "Nyt skifte";

            lblValidatedSetupTime.Text = Strings.ValidatedSetupTime;
        }

        private void OnValidatingProduct(object sender, CancelEventArgs e)
        {
            ClearErrorProvider();

            if (IsProductValid(Product))
                return;

            NotifyOfInvalidProduct();
            CancelEvent(e);
        }

        private void OnValidatingExpectedItems(object sender, CancelEventArgs e)
        {
            ClearErrorProvider();

            if (0 < ExpectedItems)
                return;

            NotifyOfInvalidExpectedItems();
            CancelEvent(e);
        }

        private void OnValidatingProducedItemsPerHour(object sender, CancelEventArgs e)
        {
            ClearErrorProvider();

            if (0 < ProducedItemsPerHour)
                return;

            NotifyOfInvalidProducedItemsPerHour();
            CancelEvent(e);
        }

        private void OnValidatingValidatedSetupTime(object sender, CancelEventArgs e)
        {
            ClearErrorProvider();

            if (TimeSpan.Zero < ValidatedSetupTime)
                return;

            NotifyOfInvalidValidatedSetupTime();
            CancelEvent(e);
        }

        private static bool IsProductValid(ProductNumber product)
        {
            return product.Number.Length > 0;
        }

        private bool IsOrderValid(OrderNumber order)
        {
            return order.Number.Length == 4;
        }

        private void NotifyOfInvalidProduct()
        {
            errorProvider.SetError(txtProduct, Strings.InvalidProduct);
        }

        private void NotifyOfInvalidExpectedItems()
        {
            errorProvider.SetError(txtExpectedItems, Strings.InvalidExpectedItems);
        }

        private void NotifyOfInvalidProducedItemsPerHour()
        {
            errorProvider.SetError(txtProducedItemsPerHour, Strings.InvalidProducedItemsPerHour);
        }

        private void NotifyOfInvalidValidatedSetupTime()
        {
            errorProvider.SetError(txtValidatedSetupTime, Strings.InvalidProducedItemsPerHour);
        }

        private void NotifyOfInvalidStartTime()
        {
            errorProvider.SetError(ucStartTime, string.Format(Strings.InvalidStartTime, production.ProductionEnd.ToString("dd-MM HH:mm"), StartTime.ToString("dd-MM HH:mm")));
        }

        private void CancelEvent(CancelEventArgs args)
        {
            args.Cancel = true;
        }

        private void ClearErrorProvider()
        {
            errorProvider.Clear();
        }

        private void OnTextBoxEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }

        private void OnValidatingStartTime(object sender, CancelEventArgs e)
        {
            ClearErrorProvider();

            if (production == null || production.ProductionEnd <= StartTime)
                return;

            bool within = false;
            foreach(ProductionShift shift in production.Shifts)
            {
                if (shift.ProductionStart < StartTime &&
                    StartTime < shift.ProductionEnd)
                {
                    within = true;
                    break;
                }
            }

            if (!within)
                return;

            NotifyOfInvalidStartTime();
            CancelEvent(e);
        }         
        
    }
}
