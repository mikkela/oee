using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    public class MachineConfiguration : EntityObject
    {
        private string machineName;
        private IList<ProductionStop> AvailableProductionStopsList { get; set; }

        internal MachineConfiguration() { }

        public MachineConfiguration(string machineName, IEnumerable<ProductionStop> availableProductionStops)
        {
            this.machineName = machineName;
            this.AvailableProductionStopsList = new List<ProductionStop>(availableProductionStops);
        }

        public virtual string MachineName
        {
            get { return machineName; }
            set { machineName = value; }
        }

        public virtual int BaseCost
        {
            get; set;
        }

        public virtual IEnumerable<ProductionStop> AvailableProductionStops
        {
            get { return AvailableProductionStopsList; }
            set { AvailableProductionStopsList = new List<ProductionStop>(value); }
        }
    }
}
