using System.Linq;
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
            using (var factory = new RepositoryFactory())
            {
                var repository = factory.CreateEntityRepository();

                LoadMachineConfigurations(repository);
                LoadTeams(repository);
            }
        }

        private void LoadTeams(IEntityRepository repository)
        {
            clbTeam.Items.Clear();
            foreach (var team in repository.LoadAll<ProductionTeam>())
            {
                clbTeam.Items.Add(new TeamItem(team));
            }
        }

        private void LoadMachineConfigurations(IEntityRepository repository)
        {
            clbMachines.Items.Clear();                
            foreach (var machineConfiguration in repository.LoadAll<MachineConfiguration>())
            {
                clbMachines.Items.Add(machineConfiguration.MachineName);
            }
        }

        public ProductionQuery Query
        {
            get
            {
                var result = new ProductionQuery();

                result = result.AddDateRange(dtPeriodStart.Value, dtPeriodEnd.Value);
                result = clbMachines.CheckedItems.Cast<object>().Aggregate(result, (current, item) => current.AddMachine(item.ToString()));

                return clbTeam.CheckedItems.Cast<object>().Aggregate(result, (current, item) => current.AddTeam(((TeamItem) item).Team));
            }
        }
    }
}
