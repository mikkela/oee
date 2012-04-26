using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE.Repository
{
    public interface IProductionQueryRepository : IDisposable
    {
        IEnumerable<Production> LoadProductions(ProductionQuery query);

        Production LoadProduction(OrderNumber orderNumber);
    }
}
