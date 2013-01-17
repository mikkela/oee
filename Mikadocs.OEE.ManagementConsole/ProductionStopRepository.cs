using System.Collections.Generic;
using System.Linq;
using Mikadocs.OEE.Repository;

namespace Mikadocs.OEE.ManagementConsole
{
    static class ProductionStopRepository
    {
        private static object _lock = new object();
        private static List<ProductionStop> stops = null;

        public static IEnumerable<ProductionStop> ProductionStops
        {
            get
            {
                lock(_lock)
                {
                    if(stops == null)
                    {
                        using(var factory = new RepositoryFactory())
                        {
                            stops = factory.CreateEntityRepository().LoadAll<ProductionStop>().ToList();
                        }
                    }

                    return stops;
                }
            }
            set
            {
                lock(_lock)
                {
                    stops = new List<ProductionStop>(value);
                }
            }
        }        
    }
}
