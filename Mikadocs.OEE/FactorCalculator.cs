using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    public class FactorCalculator
    {
        private IProduction production;
        private readonly Func<ProductionStop, bool> _isStopPlanned;

        public FactorCalculator(IProduction production, Func<ProductionStop, bool> isStopPlanned)
        {
            this.production = production;
            _isStopPlanned = isStopPlanned;
        }

        public double Availability
        {
            get
            {
                if (IsZero(PlannedProductionTimeInMinutes))
                    return 0;
                return OperatingTimeInMinutes / PlannedProductionTimeInMinutes;
            }
        }

        public double Performance
        {
            get
            {
                if (IsZero(OperatingTime))
                    return 0;

                if (IsZero(IdealRunRateAMinute))
                    return 0;

                return (TotalPieces / OperatingTimeInMinutes) / IdealRunRateAMinute;
            }
        }

        public double Quality
        {
            get
            {
                if (IsZero(TotalPieces))
                    return 0;
                return GoodPieces / TotalPieces;
            }
        }

        public double OEE
        {
            get { return Availability * Performance * Quality; }
        }

        public TimeSpan Duration
        {
            get { return production.Duration; }
        }

        public delegate double GetAverageValue(FactorCalculator factorCalculator);

        public static double ComputedWeightedAverage(IEnumerable<FactorCalculator> calculators, GetAverageValue callback)
        {
            double denominator = 0;
            double counter = 0;

            foreach (FactorCalculator factorCalculator in calculators)
            {
                counter += callback(factorCalculator)*factorCalculator.Duration.TotalMinutes;
                denominator += factorCalculator.Duration.TotalMinutes;
            }

            return (denominator > 0) ? counter/denominator : 0;
        }
        private TimeSpan PlannedProductionTime
        {
            get
            {
                TimeSpan plannedProductionTime = production.Duration;

                foreach (ProductionStopRegistration registration in production.ProductionStopRegistrations)
                {
                    if (_isStopPlanned(registration.Stop))
                        plannedProductionTime = plannedProductionTime - registration.Duration;
                }

                return plannedProductionTime;
            }
        }

        private double PlannedProductionTimeInMinutes
        {
            get { return PlannedProductionTime.TotalMinutes; }
        }

        private TimeSpan OperatingTime
        {
            get
            {
                TimeSpan operatingTime = PlannedProductionTime;

                foreach (ProductionStopRegistration registration in production.ProductionStopRegistrations)
                {
                    if (!_isStopPlanned(registration.Stop))
                        operatingTime = operatingTime - registration.Duration;
                }

                return operatingTime;
            }
        }

        private double OperatingTimeInMinutes
        {
            get { return OperatingTime.TotalMinutes; }            
        }

        private double TotalPieces
        {
            get { return production.ProducedItems; }
        }

        private double GoodPieces
        {
            get { return production.ProducedItems - production.DiscardedItems; }
        }
        private double IdealRunRateAMinute
        {
            get { return production.GetProductionForPeriod(new TimeSpan(0, 1, 0)); }
        }

        private bool IsZero(TimeSpan ts)
        {
            return ts == TimeSpan.Zero;
        }

        private bool IsZero(double d)
        {
            return d == 0;
        }
    }
}
