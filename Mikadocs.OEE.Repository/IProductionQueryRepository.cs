using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE.Repository
{
    public interface IProductionQueryRepository
    {
        IEnumerable<Production> LoadProductions(ProductionQuery query);

        Production LoadProduction(OrderNumber orderNumber);
    }
}
