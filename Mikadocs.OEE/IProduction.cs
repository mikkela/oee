using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    public interface IProduction
    {
        OrderNumber Order { get; }
        ProductNumber Product { get; }

        DateTime ProductionStart { get; }
        TimeSpan Duration { get; }
        
        IEnumerable<ProductionStopRegistration> ProductionStopRegistrations { get; }
        long ProducedItems { get; }
        long DiscardedItems { get; }

        double GetProductionForPeriod(TimeSpan period);
    }
}
