using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikadocs.OEE.ManagementConsole
{
    class ProductionViewEntity
    {
        private Production entity;

        public ProductionViewEntity(Production entity)
        {
            this.entity = entity;
        }

        public Production Entity
        {
            get { return entity; }
        }

        public virtual string Machine
        {
            get { return entity.Machine; }
            set { entity.Machine = value; }
        }

        public virtual string Product
        {
            get { return entity.Product.Number; }
            set { entity.Product = new ProductNumber(value); }
        }

        public virtual string Order
        {
            get { return entity.Order.Number; }
            set { entity.Order = new OrderNumber(value); }
        }

        public virtual long ExpectedItems
        {
            get { return entity.ExpectedItems; }
            set { entity.ExpectedItems = value; }
        }

        public virtual long ProducedItems
        {
            get { return entity.ProducedItems; }             
        }

        public virtual long ProducedItemsPerHour
        {
            get { return (long)Math.Round(entity.ProducedItems / entity.Duration.TotalHours); }
        }

        public virtual long ValidatedItemsPerHour
        {
            get { return entity.ProducedItemsPerHour; }
            set { entity.ProducedItemsPerHour = value; }
        }

        public virtual DateTime ProductionStart
        {
            get { return entity.ProductionStart; }
        }

        public virtual DateTime ProductionEnd
        {
            get { return entity.ProductionEnd; }
        }

        public IEnumerable<ProductionShiftViewEntity> Shifts
        {
            get { return new List<ProductionShiftViewEntity>(entity.Shifts.Select(shift => new ProductionShiftViewEntity(shift))); }
        }

        #region IComparable<ProductionViewEntity> Members

        public int CompareTo(ProductionViewEntity other)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
