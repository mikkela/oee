using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    public class ProductionTeam : EntityObject
    {
        private Guid globalId = Guid.NewGuid();
        private string name;
        
        internal ProductionTeam() { }

        public ProductionTeam(string name)
        {
            this.name = name;            
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
    }
}
