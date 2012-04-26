using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    public class ProductionStopRegistration : ValueObject
    {
        private ProductionStop stop;
        private TimeSpan duration;

        internal ProductionStopRegistration() { }
        public ProductionStopRegistration(ProductionStop stop, TimeSpan duration)
        {
            this.stop = stop;
            this.duration = duration;
        }

        public virtual ProductionStop Stop
        {
            get { return stop; }
            set { stop = value; }
        }

        public virtual TimeSpan Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
