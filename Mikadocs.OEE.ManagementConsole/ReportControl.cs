using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mikadocs.OEE.Repository;

namespace Mikadocs.OEE.ManagementConsole
{
    public partial class ReportControl : UserControl
    {
        private class Comparer : IEqualityComparer<Production>
        {

            #region IEqualityComparer<Production> Members

            public bool Equals(Production x, Production y)
            {
                return x.Product.Equals(y.Product);
            }

            public int GetHashCode(Production obj)
            {
                return obj.GetHashCode();
            }

            #endregion
        }

        public ReportControl()
        {
            InitializeComponent();

            SetTexts();
        }

        internal void UpdateDisplay(ProductionQuery query, IEnumerable<Production> productions, IEnumerable<ProductionStop> allProductionStops)
        {
            ClearDisplay();

            ClearChart();

            if (productions.Count() == 0)
                return;

            label2.Text = "";

            foreach (var production in productions)
            {
                foreach (var shift in production.Shifts)
                {
                    if(!label2.Text.Contains(shift.Team.Name))
                    {
                        if (label2.Text.Length > 0)
                        {
                            label2.Text += "/";
                        }
                        label2.Text += shift.Team.Name;
                    }
                }
            }

            DisplayQueryDetails(query.DateRange, productions.Select(p => p.Order).Distinct(), productions.Select(p => p.Machine).Distinct(), productions.Select(p => p.Product).Distinct(), productions.Select(p => p.Duration).Aggregate((p1, p2) => p1.Add(p2)));
            if (productions.Distinct(new Comparer()).Count() == 1)
                DisplayProducedAndValidatedPerHour(productions.Sum(p => p.ProducedItems) / productions.Sum(p => p.Duration.TotalHours), new List<Production>(productions)[0].ProducedItemsPerHour);
            else
                DisplayProducedAndValidatedPerHour(productions.Sum(p => p.ProducedItems) / productions.Sum(p => p.Duration.TotalHours), 0);
            DisplayProducedItems(productions.Sum(p => p.ProducedItems));
            DisplayDiscardedItems(productions.Sum(p => p.DiscardedItems));

            IEnumerable<FactorCalculator> calculators = productions.Select(p => new FactorCalculator(p, IsPlanned));

            double availability = FactorCalculator.ComputedWeightedAverage(calculators, c => c.Availability, p=>true);
            double performance = FactorCalculator.ComputedWeightedAverage(calculators, c => c.Performance, p=>true);
            double quality = FactorCalculator.ComputedWeightedAverage(calculators, c => c.Quality, p=>p.IsAnyProduced() );

            DisplayFactors(availability,
                           performance,
                           quality,
                           availability*performance*quality);

            DisplayStopRegistrations(productions, allProductionStops);
        }

        private bool IsPlanned(ProductionStop stop)
        {
            var s = ProductionStopRepository.ProductionStops.FirstOrDefault(p => p.Id == stop.Id);

            return s != null && s.Planned;
        }

        internal void PrintTo(Graphics g, Rectangle bounds)
        {
            PrintHelper ph = new PrintHelper(g, bounds);

            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(label1.Text, label2.Text),
                new Pair<string, string>("", "")
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.Order, orderNumberValueLabel.Text),
                new Pair<string, string>(Strings.Machine, machineValueLabel.Text)
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.PeriodStart, periodStartValueLabel.Text),
                new Pair<string, string>(Strings.PeriodEnd, periodEndValueLabel.Text)
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.Product, productNumberValueLabel.Text),
                new Pair<string, string>(Strings.Duration, durationValueLabel.Text)
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.ProducedPerHour, producedPrHourValueLabel.Text),
                new Pair<string, string>(Strings.ValidatedPerHour, validatedPrHourValueLabel.Text)
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.Produced, producedItemsValueLabel.Text),
                new Pair<string, string>(Strings.Discarded, discardedItemsValueLabel.Text)
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.Availability, availabilityValueLabel.Text),
                new Pair<string, string>(Strings.Performance, performanceValueLabel.Text)
            });
            ph.DrawValues(new Pair<string, string>[] 
            { 
                new Pair<string, string>(Strings.Quality, qualityValueLabel.Text),
                new Pair<string, string>(Strings.OverallOEE, oeeOverallValueLabel.Text)
            });

            chart.Printing.PrintPaint(g, new Rectangle(bounds.X, ph.Y, bounds.Width, bounds.Height - ph.Y));

        }

        private void ClearChart()
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            chart.Series[2].Points.Clear();
        }

        private void ClearDisplay()
        {
            orderNumberValueLabel.Text = "";
            machineValueLabel.Text = "";
            periodStartValueLabel.Text = "";
            periodEndValueLabel.Text = "";
            productNumberValueLabel.Text = "";
            durationValueLabel.Text = "";
            producedPrHourValueLabel.Text = "";
            validatedPrHourValueLabel.Text = "";
            producedItemsValueLabel.Text = "";
            discardedItemsValueLabel.Text = "";
            availabilityValueLabel.Text = "";
            performanceValueLabel.Text = "";
            qualityValueLabel.Text = "";
            oeeOverallValueLabel.Text = "";
        }

        private void DisplayQueryDetails(Pair<DateTime, DateTime> dateRange, IEnumerable<OrderNumber> orders, IEnumerable<string> machines, IEnumerable<ProductNumber> products, TimeSpan duration)
        {
            
            orderNumberValueLabel.Text = (orders.Count() == 1) ? orders.First().Number : "-";
            machineValueLabel.Text = (machines.Count() == 1) ? machines.First() : "-";
            productNumberValueLabel.Text = (products.Count() == 1) ? products.First().Number : "-";
            periodStartValueLabel.Text = dateRange.First.ToShortDateString();
            periodEndValueLabel.Text = dateRange.Second.ToShortDateString();
            durationValueLabel.Text = duration.ToString();
        }

        private void DisplayProducedAndValidatedPerHour(double produced, double validated)
        {
            producedPrHourValueLabel.Text = Math.Round(produced).ToString();
            validatedPrHourValueLabel.Text = (validated > 0) ? Math.Round(validated).ToString() : "-";
        }

        private void DisplayProducedItems(long producedItems)
        {
            producedItemsValueLabel.Text = producedItems.ToString();
        }

        private void DisplayDiscardedItems(long discardedItems)
        {
            discardedItemsValueLabel.Text = discardedItems.ToString();
        }

        private void DisplayFactors(double availability, double performance, double quality, double oee)
        {
            availabilityValueLabel.Text = availability.ToString("#0.##%", System.Globalization.CultureInfo.CurrentUICulture);
            performanceValueLabel.Text = performance.ToString("#0.##%", System.Globalization.CultureInfo.CurrentUICulture);
            qualityValueLabel.Text = quality.ToString("#0.##%", System.Globalization.CultureInfo.CurrentUICulture);
            oeeOverallValueLabel.Text = oee.ToString("#0.##%", System.Globalization.CultureInfo.CurrentUICulture);
        }

        private void DisplayStopRegistrations(IEnumerable<Production> productions, IEnumerable<ProductionStop> allStops)
        {
            IDictionary<ProductionStop, long> stopMinutes = new Dictionary<ProductionStop, long>();
            IDictionary<ProductionStop, long> stopInstances = new Dictionary<ProductionStop, long>();
            IDictionary<ProductionStop, long> stopValidated = new Dictionary<ProductionStop, long>();

            foreach (ProductionStop stop in allStops)
            {
                if (stop == null)
                    continue;
                stopMinutes.Add(stop, 0);
                stopInstances.Add(stop, 0);
                stopValidated.Add(stop, 0);
            }

            foreach (IEnumerable<ProductionStopRegistration> list in productions.Select(p => p.ProductionStopRegistrations))
            {
                foreach (ProductionStopRegistration registration in list)
                {
                    if (!stopValidated.ContainsKey(registration.Stop))
                        stopValidated.Add(registration.Stop, 0);
                    if (!stopMinutes.ContainsKey(registration.Stop))
                        stopMinutes.Add(registration.Stop, 0);
                    if (!stopInstances.ContainsKey(registration.Stop))
                        stopInstances.Add(registration.Stop, 0);
                    stopValidated[registration.Stop] = (registration.Stop.Name.Equals("Omstilling") ? productions.Sum(p => (long)p.ValidatedStartTime.TotalMinutes) : 0);                
                    stopMinutes[registration.Stop] = stopMinutes[registration.Stop] + (long)registration.Duration.TotalMinutes;
                    stopInstances[registration.Stop] = stopInstances[registration.Stop] + 1;
                }
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
                series1Values.Add(stopValidated[stop]);
                series2Values.Add(stopMinutes[stop]);
                series3Values.Add(stopInstances[stop]);
            }

            chart.Series[0].Points.DataBindXY(xValues, series1Values);
            chart.Series[1].Points.DataBindXY(xValues, series2Values);
            chart.Series[2].Points.DataBindXY(xValues, series3Values);
        }

        private void SetTexts()
        {
            orderNumberLabel.Text = Strings.Order;
            machineLabel.Text = Strings.Machine;
            periodStartLabel.Text = Strings.PeriodStart;
            periodEndLabel.Text = Strings.PeriodEnd;
            productNumberLabel.Text = Strings.Product;
            durationLabel.Text = Strings.Duration;
            producedPrHourLabel.Text = Strings.ProducedPerHour;
            validatedPrHourLabel.Text = Strings.ValidatedPerHour;
            producedItemsLabel.Text = Strings.Produced;
            discardedItemsLabel.Text = Strings.Discarded;
            availabilityLabel.Text = Strings.Availability;
            performanceLabel.Text = Strings.Performance;
            qualityLabel.Text = Strings.Quality;
            overallOEELabel.Text = Strings.OverallOEE;

            chart.Series[0].Name = Strings.Validated;
            chart.Series[1].Name = Strings.Minutes;
            chart.Series[2].Name = Strings.Instances;
        }

        
    }
}
