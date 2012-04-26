using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE.DataEntry
{
    public class ProductionStatisticsValidator
    {
        private DateTime lastUpdateTime;
        private long lastProductionCounter;
        private long lastDiscardedItems;
        
        public ProductionStatisticsValidator(DateTime lastUpdateTime, long lastProductionCounter, long lastDiscardedItems)
        {
            this.lastUpdateTime = lastUpdateTime;
            this.lastProductionCounter = lastProductionCounter;
            this.lastDiscardedItems = lastDiscardedItems;
        }

        public DateTime LastUpdateTime
        {
            get { return lastUpdateTime; }
        }

        public long LastProductionCounter
        {
            get { return lastProductionCounter; }
        }

        public long LastDiscardedItems
        {
            get { return lastDiscardedItems; }
        }

        public bool ValidateUpdateTime(DateTime value)
        {
            return lastUpdateTime <= value &&
                value <= lastUpdateTime.AddHours(8);
        }

        public bool ValidateProductionCounter(long value)
        {
            return lastProductionCounter <= value;
        }

        public bool ValidateDiscardedItems(long value)
        {
            return lastDiscardedItems <= value;
        }
    }
}
