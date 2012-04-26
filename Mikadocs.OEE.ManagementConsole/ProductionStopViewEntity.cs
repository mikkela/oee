using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikadocs.OEE.ManagementConsole
{
    class ProductionStopViewEntity
    {
        private ProductionStop entity;

        public ProductionStopViewEntity(ProductionStop entity)
        {
            this.entity = entity;
        }

        public ProductionStop Entity
        {
            get { return entity; }
        }

        public string Name
        {
            get { return entity.Name; }
            set { entity.Name = value; }
        }

        public bool Planned
        {
            get { return entity.Planned; }
            set { entity.Planned = value; }
        }
    }
}
