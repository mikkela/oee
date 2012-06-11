using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mikadocs.OEE.DataEntry
{
    public partial class NewProductionStopRegistrationForm : Form
    {
        private static string productionDurationViewState = "";
        private static int productionStopViewState = -1;
        private class ProductionStopComboBoxItem
        {
            private ProductionStop productionStop;

            public ProductionStopComboBoxItem(ProductionStop productionStop)
            {
                this.productionStop = productionStop;
            }

            public ProductionStop ProductionStop
            {
                get { return productionStop; }
            }

            public override string ToString()
            {
                return productionStop.Name ?? "Mangler navn";
            }
        }

        private ProductionLeg productionLeg;

        public NewProductionStopRegistrationForm(ProductionLeg productionLeg, IEnumerable<ProductionStop> availableProductionStops)
        {
            this.productionLeg = productionLeg;

            InitializeComponent();

            SetTexts();

            FillInProductionStopTypeComboBox(availableProductionStops);

            ShowViewState();
        }

        public ProductionStopRegistration ProductionStopRegistration
        {
            get { return new ProductionStopRegistration( Stop, Duration); }
        }

        private TimeSpan Duration
        {
            get
            {
                int minutes;
                if (int.TryParse(txtDuration.Text, out minutes))
                    return new TimeSpan(0, minutes, 0);
                return TimeSpan.Zero;
            }
        }

        private ProductionStop Stop
        {
            get { return ((ProductionStopComboBoxItem)cbStopTypes.SelectedItem).ProductionStop; }
        }

        private void OnTextBoxKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OnValidateProductionStopDuration(object sender, CancelEventArgs args)
        {
            ClearErrorProvider();

            if (IsDurationWithinProductionTime(Duration))
                return;

            NotifyOfInvalidDurationLength();
            CancelEvent(args);
        }

        private bool IsAcceptableDuration(TimeSpan duration)
        {
            return 0 < duration.TotalMinutes && duration.TotalMinutes < 600;
        }

        private bool IsDurationWithinProductionTime(TimeSpan duration)
        {
            if (duration == TimeSpan.Zero)
                return false;
            return productionLeg.ProductionStopDuration.Add(duration) <= DateTime.Now.Subtract(productionLeg.ProductionStart);
        }

        private void NotifyOfInvalidDurationLength()
        {
            errorProvider.SetError(txtDuration, "Du har angivet mere stoptid end der har været produktionstid siden skiftet startede");
        }

        private void CancelEvent(CancelEventArgs args)
        {
            args.Cancel = true;
        }

        private void ClearErrorProvider()
        {
            errorProvider.Clear();
        }

        private void SetTexts()
        {
            lblDuration.Text = Strings.ProductionStopDuration;
            lblStopType.Text = Strings.ProductionStopType;
            lblHeader.Text = Strings.NewProductionStop;
        }

        private void FillInProductionStopTypeComboBox(IEnumerable<ProductionStop> availableProductionStops)
        {
            List<ProductionStopComboBoxItem> items = new List<ProductionStopComboBoxItem>();
            foreach (ProductionStop productionStop in availableProductionStops)
            {
                if (productionStop == null)
                    continue;
                items.Add(new ProductionStopComboBoxItem(productionStop));
            }

            cbStopTypes.DataSource = items;       
        }

        private void ShowViewState()
        {
            txtDuration.Text = NewProductionStopRegistrationForm.productionDurationViewState;
            if (productionStopViewState != -1)
                cbStopTypes.SelectedIndex = productionStopViewState;
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            NewProductionStopRegistrationForm.productionDurationViewState = txtDuration.Text;
            NewProductionStopRegistrationForm.productionStopViewState = cbStopTypes.SelectedIndex;
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
