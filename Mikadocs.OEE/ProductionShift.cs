using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    public class ProductionShift : EntityObject, IProduction
    {
        private Production production;
        private ProductionTeam team;
        private DateTime date;
        private IList<ProductionLeg> ProductionLegList { get; set; }

        internal ProductionShift() { }

        internal ProductionShift(Production production, ProductionTeam team, DateTime date)
        {
            if (production == null)
                throw new ArgumentNullException("production");

            if (team == null)
                throw new ArgumentNullException("team");

            this.ProductionLegList = new List<ProductionLeg>();
            this.production = production;
            this.team = team;
            this.date = date.Date;          
        }

        public virtual DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public virtual ProductionTeam Team
        {
            get { return team; }
            set { team = value; }
        }

        public virtual Production Production
        {
            get { return production; }
            set { production = value; }
        }

        public virtual IEnumerable<ProductionLeg> ProductionLegs
        {
            get
            {
                return ProductionLegList;
            }
            set
            {
                ProductionLegList = new List<ProductionLeg>(value);
            }
        }

        public virtual ProductionLeg AddProductionLeg(DateTime productionStart, long counterStart)
        {
            if (ProductionLegList.Count > 0 && productionStart < ProductionEnd)
                throw new ArgumentException("The leg can not start in the middle of an existing leg", "productionStart");

            ProductionLeg leg = new ProductionLeg(this, productionStart, counterStart);
            ProductionLegList.Add(leg);

            return leg;
        }

        public virtual ProductionLeg CurrentLeg
        {
            get
            {
                if (ProductionLegList.Count == 0)
                    return null;
                return ProductionLegList[ProductionLegList.Count - 1];
            }
        }

        #region IProduction Members

        public virtual OrderNumber Order
        {
            get { return production.Order; }
        }

        public virtual ProductNumber Product
        {
            get { return production.Product; }
        }

        public virtual double GetProductionForPeriod(TimeSpan period)
        {
            return production.GetProductionForPeriod(period);
        }

        public virtual DateTime ProductionStart
        {
            get
            {
                DateTime result = DateTime.MaxValue;
                foreach (var leg in ProductionLegList)
                {
                    if (leg.ProductionStart < result)
                        result = leg.ProductionStart;
                }
                return result;
            }
        }

        public virtual TimeSpan Duration
        {
            get
            {
                TimeSpan result = TimeSpan.Zero;
                foreach (var leg in ProductionLegList)
                {
                    result = result + leg.Duration;
                }
                return result;
            }
        }

        public virtual IEnumerable<ProductionStopRegistration> ProductionStopRegistrations
        {
            get
            {
                List<ProductionStopRegistration> result = new List<ProductionStopRegistration>();
                foreach (var leg in ProductionLegList)
                {
                    result.AddRange(leg.ProductionStopRegistrations);
                }

                return result;

            }
        }

        public virtual long ProducedItems
        {
            get { return SumItems(ProductionLegList, leg => leg.ProducedItems); }
        }

        public virtual long DiscardedItems
        {
            get { return SumItems(ProductionLegList, leg => leg.DiscardedItems); }
        }

        #endregion

        public virtual DateTime ProductionEnd
        {
            get
            {
                DateTime result = DateTime.MinValue;
                foreach (var leg in ProductionLegList)
                {
                    if (leg.ProductionEnd > result)
                        result = leg.ProductionEnd;
                }
                return result;
            }
        }

        public virtual void RemoveProductionLeg(ProductionLeg leg)
        {
            ProductionLegList.Remove(leg);
        }

        private delegate long SumDelegate(ProductionLeg leg);
        private long SumItems(IEnumerable<ProductionLeg> legs, SumDelegate d)
        {
            long result = 0;
            foreach (var leg in legs)
            {
                result += d(leg);
            }

            return result;
        }
    }
}
