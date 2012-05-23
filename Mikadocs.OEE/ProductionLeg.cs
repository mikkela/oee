using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    public class ProductionLeg : EntityObject
    {
        private ProductionShift shift;
        private DateTime productionStart;
        private DateTime productionEnd;
        private long counterStart;
        private long counterEnd;
        private long discardedItems;
        private IList<ProductionStopRegistration> ProductionStopRegistrationList { get; set; }

        internal ProductionLeg() { }

        internal ProductionLeg(ProductionShift shift, DateTime productionStart, long counterStart)
        {
            if (counterStart < 0)
                throw new ArgumentException("The value cannot be negative", "counterStart");

            this.shift = shift;
            this.ProductionStopRegistrationList = new List<ProductionStopRegistration>();
            this.productionStart = productionStart;
            this.productionEnd = productionStart;
            this.counterStart = counterStart;
            this.counterEnd = counterStart;
            this.discardedItems = 0;
        }

        public virtual ProductionShift Shift
        {
            get { return shift; }
            set { shift = value; }
        }

        public virtual DateTime ProductionStart
        {
            get { return productionStart; }
            set { productionStart = value; }
        }

        public virtual DateTime ProductionEnd
        {
            get { return productionEnd; }
            set { productionEnd = value; }            
        }

        public virtual long CounterStart
        {
            get { return counterStart; }
            set { counterStart = value; }
        }

        public virtual long CounterEnd
        {
            get { return counterEnd; }
            set { counterEnd = value; }            
        }

        public virtual long DiscardedItems
        {
            get { return discardedItems; }
            set { discardedItems = value; }           
        }

        public virtual long ProducedItems
        {
            get
            {
                return counterEnd - counterStart;
            }
        }

        public virtual long ProducedApprovedItems
        {
            get
            {
                return ProducedItems - discardedItems;
            }
        }

        public virtual TimeSpan ProductionTime
        {
            get
            {
                return productionEnd - productionStart;
            }
        }

        public virtual IEnumerable<ProductionStopRegistration> ProductionStopRegistrations
        {
            get
            {
                return ProductionStopRegistrationList;
            }
            set
            {
                ProductionStopRegistrationList = new List<ProductionStopRegistration>(value);
            }
        }

        public virtual void AddProductionStopRegistration(ProductionStopRegistration registration)
        {
            ProductionStopRegistrationList.Add(registration);
        }

        public virtual TimeSpan ProductionStopDuration
        {
            get
            {
                TimeSpan result = TimeSpan.Zero;
                foreach (ProductionStopRegistration stopRegistration in ProductionStopRegistrationList)
                    result += stopRegistration.Duration;

                return result;
            }
        }

        public virtual void UpdateStatistics(DateTime productionEnd, long counterEnd, long discardedItems)
        {
            if (productionEnd < productionStart)
                throw new ArgumentException("The production end must be after production start", "productionEnd");
                
            if (counterEnd < 0)
                throw new ArgumentException("The value cannot be negative", "counterEnd");

            if (counterEnd < counterStart)
                throw new ArgumentException("The counter end can not be less than the counter start", "counterEnd");

            if (discardedItems < 0)
                throw new ArgumentException("The value cannot be negative", "discardedItems");

            if (discardedItems > (counterEnd - counterStart))
                throw new ArgumentException("There is discarded more units than produced", "discardedItems");

            this.productionEnd = productionEnd;
            this.counterEnd = counterEnd;
            this.discardedItems = discardedItems;            
        }

        #region IProduction Members        

        public virtual TimeSpan Duration
        {
            get { return ProductionEnd.Subtract(ProductionStart); }
        }        

        #endregion
    }
}
