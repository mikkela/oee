using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    public class ProductionStop : EntityObject
    {
        private Guid globalId = Guid.NewGuid();
        private bool planned = false;
        private string name;
        
        internal ProductionStop() { }

        public ProductionStop(string name) : this(name, false)
        {            
        }

        public ProductionStop(string name, bool plannedStop)
        {
            this.name = name;
            this.planned = plannedStop;
        }

        public virtual Guid GlobalId
        {
            get { return globalId; }
        }

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual bool Planned
        {
            get { return planned; }
            set { planned = value; }
        }        
    }
}
