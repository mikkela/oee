using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    public class Production : EntityObject, IProduction
    {
        private string machine;
        private ProductNumber product;
        private OrderNumber order;
        private long expectedItems;
        private long producedItemsPerHour;
        private TimeSpan validatedStartTime;
        private IList<ProductionShift> ShiftList { get; set; }

        internal Production() { }

        public Production(string machine, ProductNumber product, OrderNumber order, long expectedItems, long producedItemsPerHour) : this(machine, product, order, expectedItems, producedItemsPerHour, TimeSpan.Zero)
        {
        }

        public Production(string machine, ProductNumber product, OrderNumber order, long expectedItems, long producedItemsPerHour, TimeSpan validatedStartTime)
        {
            if (machine == null)
                throw new ArgumentNullException("machine");

            if (product == null)
                throw new ArgumentNullException("product");

            if (order == null)
                throw new ArgumentNullException("order");

            if (expectedItems <= 0)
                throw new ArgumentException("The expected items value must be positive.", "expectedItems");

            if (producedItemsPerHour <= 0)
                throw new ArgumentException("The produced items per hour value must be positive.", "producedItemsPerHour");

            if (validatedStartTime < TimeSpan.Zero)
                throw new ArgumentException("The validated start time value must be positive.", "validatedStartTime");

            this.machine = machine;
            this.product = product;
            this.order = order;
            this.expectedItems = expectedItems;
            this.producedItemsPerHour = producedItemsPerHour;
            this.validatedStartTime = validatedStartTime;
            ShiftList = new List<ProductionShift>();
        }

        public virtual string Machine
        {
            get { return machine; }
            set { machine = value; }
        }

        public virtual ProductNumber Product
        {
            get { return product; }
            set { product = value; }
        }

        public virtual OrderNumber Order
        {
            get { return order; }
            set { order = value; }
        }

        public virtual long ExpectedItems
        {
            get { return expectedItems; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The expected items value must be positive.");
                expectedItems = value;
            }
        }

        public virtual long ProducedItemsPerHour
        {
            get { return producedItemsPerHour; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The produced items per hour value must be positive.");
                producedItemsPerHour = value;
            }
        }

        public virtual TimeSpan ValidatedStartTime
        {
            get { return validatedStartTime; }
            set { validatedStartTime = value; }
        }

        public virtual IEnumerable<ProductionShift> Shifts
        {
            get { return ShiftList; }
        }

        public virtual ProductionShift AddProductionShift(ProductionTeam team, DateTime date)
        {
            foreach (ProductionShift shift in ShiftList)
            {
                if (shift.Date.Equals(date.Date) &&
                    shift.Team.Equals(team))
                    return shift;
            }

            ProductionShift result = new ProductionShift(this, team, date);
            ShiftList.Add(result);

            return result;
        }

        public virtual void RemoveProductionShift(ProductionShift shift)
        {
            ShiftList.Remove(shift);
        }

        #region IProduction Members

        public virtual DateTime ProductionStart
        {
            get
            {
                if (ShiftList.Count == 0)
                    return DateTime.MinValue;

                DateTime result = DateTime.MaxValue;
                foreach (var leg in Shifts)
                {
                    if (leg.ProductionStart < result)
                        result = leg.ProductionStart;
                }

                return result;
            }
        }

        public virtual DateTime ProductionEnd
        {
            get
            {
                DateTime result = DateTime.MinValue;
                foreach (var leg in Shifts)
                {
                    if (leg.ProductionEnd > result)
                        result = leg.ProductionEnd;
                }

                return result;
            }
        }
        public virtual TimeSpan Duration
        {
            get
            {
                TimeSpan result = TimeSpan.Zero;

                foreach (var leg in Shifts)
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

                foreach (var leg in Shifts)
                {
                    result.AddRange(leg.ProductionStopRegistrations);
                }

                return result;
            }
        }

        public virtual long ProducedItems
        {
            get
            {
                long result = 0;

                foreach (var leg in Shifts)
                {
                    result += leg.ProducedItems;
                }

                return result;
            }
        }

        public virtual long DiscardedItems
        {
            get
            {
                long result = 0;

                foreach (var leg in Shifts)
                {
                    result += leg.DiscardedItems;
                }

                return result;
            }
        }

        public virtual double GetProductionForPeriod(TimeSpan period)
        {
            return (ProducedItemsPerHour / 60.0) / period.TotalMinutes;
        }

        #endregion
        
    }
}
