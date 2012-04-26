using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikadocs.OEE.ManagementConsole
{
    class ProductionStopRegistrationViewEntity
    {
        public static IEnumerable<ProductionStop> Stops;
        private ProductionStopRegistration entity;

        public ProductionStopRegistrationViewEntity(ProductionStopRegistration entity)
        {
            this.entity = entity;
        }

        public ProductionStopRegistration Entity
        {
            get { return entity; }
        }

        public string ProductionStop
        {
            get { return Entity.Stop.Name; }
            set { Entity.Stop = Stops.First(p => p.Name.Equals(value)); }
        }

        public string Duration
        {
            get
            {
                return string.Format("{0:D2}:{1:D2}", entity.Duration.Hours, entity.Duration.Minutes);
            }
            set
            {
                TimeSpan ts;

                if (TimeSpan.TryParse(value, out ts))
                    entity.Duration = ts;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is ProductionStopRegistrationViewEntity)
                return entity.Equals(((ProductionStopRegistrationViewEntity)obj).Entity);

            return false;
        }

        public override int GetHashCode()
        {
            return entity.GetHashCode();
        }
    }
}
