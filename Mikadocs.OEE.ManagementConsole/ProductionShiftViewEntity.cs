using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikadocs.OEE.ManagementConsole
{
    class ProductionShiftViewEntity
    {
        private ProductionShift entity;

        public ProductionShiftViewEntity(ProductionShift entity)
        {
            this.entity = entity;
        }

        public string Date
        {
            get { return entity.Date.ToShortDateString(); }
        }
        public string Team
        {
            get { return entity.Team.Name; }
        }

        public IEnumerable<ProductionLegViewEntity> Legs
        {
            get { return new List<ProductionLegViewEntity>(entity.ProductionLegs.Select(leg => new ProductionLegViewEntity(leg))); }
        }

        public ProductionShift Entity
        {
            get { return entity; }
        }
    }
}
