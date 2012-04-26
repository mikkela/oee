using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikadocs.OEE.ManagementConsole
{
    class ProductionLegViewEntity
    {
        private ProductionLeg entity;

        public ProductionLegViewEntity(ProductionLeg entity)
        {
            this.entity = entity;
        }

        public ProductionLeg Entity
        {
            get { return entity; }
        }        

        public DateTime ProductionStart
        {
            get { return entity.ProductionStart; }
            set { entity.ProductionStart = value; }
        }

        public DateTime ProductionEnd
        {
            get { return entity.ProductionEnd; }
            set { entity.ProductionEnd = value; }
        }

        public long CounterStart
        {
            get { return entity.CounterStart; }
            set { entity.CounterStart = value; }
        }

        public long CounterEnd
        {
            get { return entity.CounterEnd; }
            set { entity.CounterEnd = value; }
        }

        public long DiscardedItems
        {
            get { return entity.DiscardedItems; }
            set { entity.DiscardedItems = value; }
        }

        public IEnumerable<ProductionStopRegistrationViewEntity> ProductionStopRegistrations
        {
            get { return new List<ProductionStopRegistrationViewEntity>(entity.ProductionStopRegistrations.Select(stop => new ProductionStopRegistrationViewEntity(stop))); }
            set { entity.ProductionStopRegistrations = value.Select(stop => stop.Entity); }
        }
    }
}
