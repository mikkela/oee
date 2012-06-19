using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mikadocs.OEE.DataEntry
{
    public partial class OEEDisplayControl : UserControl
    {
        private string productionStart;
        private string productionShiftStartDate;
        private string team;

        public OEEDisplayControl()
        {
            InitializeComponent();

            SetTexts();
            ClearDisplay();
        }

        public void UpdateDisplay(ProductionShift shift, Production production, IEnumerable<ProductionStop> allStops)
        {
            productionStart = production.ProductionStart.ToString("g", System.Globalization.CultureInfo.CurrentUICulture);
            productionShiftStartDate = shift.ProductionStart.ToShortDateString();
            ClearDisplay();

            ClearChart(chartShift);
            ClearChart(chartProduction);
            if (production == null ||
                shift == null)
                return;
            
            team = shift.Team.Name;

            DisplayOrder(production.Order);
            DisplayProduct(production.Product);
            DisplayProductionStart(shift.ProductionStart, production.ProductionStart);
            DisplayProductionTime(shift.Duration, production.Duration);
            DisplayProducedItems(shift.ProducedItems, production.ProducedItems, production.ProducedItemsPerHour);
            DisplayDiscardedItems(shift.DiscardedItems, production.DiscardedItems);
            DisplayFactors(new FactorCalculator(shift), new FactorCalculator(production));

            DisplayStopRegistrationsOnChart(chartShift, shift.ProductionStopRegistrations, allStops, production.ValidatedStartTime);
            DisplayStopRegistrationsOnChart(chartProduction, production.ProductionStopRegistrations, allStops, production.ValidatedStartTime);
        }

        internal void PrintTo(Graphics g, Rectangle bounds)
        {
            PrintHelper ph = new PrintHelper(g, bounds);

            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>("Dato", productionShiftStartDate),
                new Pair<string, string>("Hold", team)
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.Order, lblOrderValue.Text),
                new Pair<string, string>(Strings.Product, lblProductValue.Text)
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.ProductionStart, lblStartValue.Text.Split('/')[0].Trim()),
                new Pair<string, string>(Strings.ProductionTime, lblDurationValue.Text.Split('/')[0].Trim())
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>("", lblStartValue.Text.Split('/')[1].Trim()),
                new Pair<string, string>("", lblDurationValue.Text.Split('/')[1].Trim())
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.ProducedItems, lblProducedValue.Text.Split('/')[0].Trim()),
                new Pair<string, string>(Strings.DiscardedItems, lblDiscardedValue.Text.Split('/')[0].Trim())
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>("", lblProducedValue.Text.Split('/')[1].Trim()),
                new Pair<string, string>("", lblDiscardedValue.Text.Split('/')[1].Trim())
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.Availability, lblAvailabilityValue.Text),
                new Pair<string, string>(Strings.Performance, lblPerformanceValue.Text)
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.Quality, lblQualityValue.Text),
                new Pair<string, string>(Strings.OverallOEE, lblOEEValue.Text)
            });

            int chartHeight = (bounds.Height - ph.Y) / 2;

            chartShift.Printing.PrintPaint(g, new Rectangle(bounds.X, ph.Y, bounds.Width, chartHeight));
            chartProduction.Printing.PrintPaint(g, new Rectangle(bounds.X, ph.Y + chartHeight, bounds.Width, chartHeight));
            //chart.Printing.PrintPaint(g, new Rectangle(bounds.X, ph.Y, bounds.Width, bounds.Height - ph.Y));

        }

        private void SetTexts()
        {
            lblOrder.Text = Strings.Order;
            lblProduct.Text = Strings.Product;
            lblStart.Text = Strings.ProductionStart;
            lblDuration.Text = Strings.ProductionTime;
            lblProduced.Text = Strings.ProducedItems;
            lblDiscarded.Text = Strings.DiscardedItems;
            lblAvailability.Text = Strings.Availability;
            lblPerformance.Text = Strings.Performance;
            lblQuality.Text = Strings.Quality;
            lblOEE.Text = Strings.OverallOEE;

            chartProduction.Titles[0].Text = Strings.EntireProduction;
            chartShift.Titles[0].Text = Strings.CurrentShift;

            chartProduction.Series[0].Name = Strings.Validated;
            chartProduction.Series[1].Name = Strings.Minutes;
            chartProduction.Series[2].Name = Strings.Instances;

            chartShift.Series[0].Name = Strings.Validated;
            chartShift.Series[1].Name = Strings.Minutes;
            chartShift.Series[2].Name = Strings.Instances;            
        }

        private void ClearDisplay()
        {
            lblOrderValue.Text = "";
            lblProductValue.Text = "";
            lblStartValue.Text = "";
            lblDurationValue.Text = "";
            lblProducedValue.Text = "";
            lblDiscardedValue.Text = "";
            lblAvailabilityValue.Text = "";
            lblPerformanceValue.Text = "";
            lblQualityValue.Text = "";
            lblOEEValue.Text = "";
        }

        private void ClearChart(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            chart.Series[2].Points.Clear();
        }

        private void DisplayOrder(OrderNumber order)
        {
            lblOrderValue.Text = order.Number;
        }

        private void DisplayProduct(ProductNumber product)
        {
            lblProductValue.Text = product.Number;
        }

        private void DisplayProductionStart(DateTime productionStart1, DateTime productionStart2)
        {
            lblStartValue.Text = string.Format("{0} / {1}", productionStart1.ToString("g", System.Globalization.CultureInfo.CurrentUICulture), productionStart2.ToString("g", System.Globalization.CultureInfo.CurrentUICulture));
        }

        private void DisplayProductionTime(TimeSpan duration1, TimeSpan duration2)
        {
            lblDurationValue.Text = string.Format("{0} / {1}", string.Format("{0}:{1}", ((int)duration1.TotalHours).ToString(), ((int)duration1.Minutes).ToString("00")), string.Format("{0}:{1}", ((int)duration2.TotalHours).ToString(), ((int)duration2.Minutes).ToString("00")));
        }

        private void DisplayProducedItems(long producedItems1, long producedItems2, long validatedPrHour)
        {
            lblProducedValue.Text = string.Format("{0} ({2}) / {1} ({2})", producedItems1, producedItems2, validatedPrHour);
        }

        private void DisplayDiscardedItems(long discardedItems1, long discardedItems2)
        {
            lblDiscardedValue.Text = string.Format("{0} / {1}", discardedItems1, discardedItems2);
        }

        private void DisplayFactors(FactorCalculator calculator1, FactorCalculator calculator2)
        {
            lblAvailabilityValue.Text = string.Format("{0} / {1}", Format(calculator1.Availability), Format(calculator2.Availability));
            lblPerformanceValue.Text = string.Format("{0} / {1}", Format(calculator1.Performance), Format(calculator2.Performance));
            lblQualityValue.Text = string.Format("{0} / {1}", Format(calculator1.Quality), Format(calculator2.Quality));
            lblOEEValue.Text = string.Format("{0} / {1}", Format(calculator1.OEE), Format(calculator2.OEE));            
        }

        private string Format(double v)
        {
            return v.ToString("#0.##%", System.Globalization.CultureInfo.CurrentUICulture);
        }

        private void DisplayStopRegistrationsOnChart(System.Windows.Forms.DataVisualization.Charting.Chart chart, IEnumerable<ProductionStopRegistration> registrations, IEnumerable<ProductionStop> allStops, TimeSpan validatedSetupTime)
        {
            IDictionary<ProductionStop, long> stopMinutes = new Dictionary<ProductionStop, long>();
            IDictionary<ProductionStop, long> stopInstances = new Dictionary<ProductionStop, long>();
            IDictionary<ProductionStop, long> validatedMinutes = new Dictionary<ProductionStop, long>();

            foreach (ProductionStop stop in allStops)
            {
                if (stop == null)
                    continue;
                stopMinutes.Add(stop, 0);
                stopInstances.Add(stop, 0);
                validatedMinutes.Add(stop, 0);
            }

            foreach (ProductionStopRegistration registration in registrations)
            {
                stopMinutes[registration.Stop] = stopMinutes[registration.Stop] + (long)registration.Duration.TotalMinutes;
                stopInstances[registration.Stop] = stopInstances[registration.Stop] + 1;
                if (validatedMinutes[registration.Stop] == 0)
                    validatedMinutes[registration.Stop] = validatedMinutes[registration.Stop] + (registration.Stop.Name.Equals("Omstilling") ? (long)validatedSetupTime.TotalMinutes : 0);
            }

            List<string> xValues = new List<string>();
            List<long> series1Values = new List<long>();
            List<long> series2Values = new List<long>();
            List<long> series3Values = new List<long>();

            foreach (ProductionStop stop in allStops)
            {
                if (stop == null)
                    continue;
                xValues.Add(stop.Name.Substring(0, Math.Min(stop.Name.Length, 12)));
                series1Values.Add(validatedMinutes[stop]);
                series2Values.Add(stopMinutes[stop]);
                series3Values.Add(stopInstances[stop]);                
            }
            
            chart.Series[0].Points.DataBindXY(xValues, series1Values);
            chart.Series[1].Points.DataBindXY(xValues, series2Values);
            chart.Series[2].Points.DataBindXY(xValues, series3Values);
        }
    }
}
