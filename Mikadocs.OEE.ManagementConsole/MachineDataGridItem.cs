using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikadocs.OEE.ManagementConsole
{
    class MachineDataGridItem
    {
        private string host;
        private string machineName;
        private string latestOrder;
        private string latestProduct;
        private string productionStarted;
        
        public MachineDataGridItem(string host, string machineName, string latestOrder, string latestProduct, string productionStarted)
        {
            this.host = host;
            this.machineName = machineName;
            this.latestOrder = latestOrder;
            this.latestProduct = latestProduct;
            this.productionStarted = productionStarted;            
        }

        public string Host
        {
            get { return host; }
        }

        public string MachineName
        {
            get { return machineName; }
        }

        public string LatestOrder
        {
            get { return latestOrder; }
        }

        public string LatestProduct
        {
            get { return latestProduct; }
        }

        public string ProductionStarted
        {
            get { return productionStarted; }
        }       
    }
}
