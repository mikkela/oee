using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mikadocs.OEE.Repository;

namespace Mikadocs.OEE.CostCalculator
{
    public partial class UCFilter : UserControl
    {   
        private class TeamItem
        {
            private readonly ProductionTeam _team;

            public TeamItem(ProductionTeam team)
            {
                _team = team;
            }

            public ProductionTeam Team
            {
                get { return _team; }
            }

            public override string ToString()
            {
                return _team.Name;
            }
        }
        public UCFilter()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            using (RepositoryFactory factory = new RepositoryFactory())
            {
                clbMachines.Items.Clear();

                using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
                {
                    foreach (var machineConfiguration in repository.LoadAll())
                    {
                        clbMachines.Items.Add(machineConfiguration.MachineName);
                    }                    
                }

                clbTeam.Items.Clear();
                using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
                {
                    foreach (var team in repository.LoadAll())
                    {
                        clbTeam.Items.Add(new TeamItem(team));
                    }
                }
            }
        }
        public ProductionQuery Query
        {
            get
            {
                ProductionQuery result = new ProductionQuery();

                result = result.AddDateRange(dtPeriodStart.Value, dtPeriodEnd.Value);
                foreach (var item in clbMachines.CheckedItems)
                {
                    result = result.AddMachine(item.ToString());
                }

                foreach (var item in clbTeam.CheckedItems)
                {
                    result = result.AddTeam((item as TeamItem).Team);
                }
                return result;
            }
        }
    }
}
