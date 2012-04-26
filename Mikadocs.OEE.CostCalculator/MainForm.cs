using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mikadocs.OEE.Repository;

namespace Mikadocs.OEE.CostCalculator
{
    public partial class MainForm : Form
    {
        private class GraphItem
        {
            private readonly string machine;
            private readonly DateTime productionDate;
            private ProductionTeam team;
            private List<ProductionStopRegistration> stopRegistrations;

            public GraphItem(string machine, DateTime productionDate, ProductionTeam team, IEnumerable<ProductionStopRegistration> stopRegistrations)
            {
                this.machine = machine;
                this.productionDate = productionDate;
                this.team = team;
                this.stopRegistrations = new List<ProductionStopRegistration>(stopRegistrations);
            }

            public string Machine
            {
                get { return machine; }
            }

            public DateTime ProductionDate
            {
                get { return productionDate; }
            }

            public ProductionTeam Team
            {
                get { return team; }
            }

            public List<ProductionStopRegistration> StopRegistrations
            {
                get { return stopRegistrations; }
            }
        }

        private interface IProjector
        {
            IEnumerable<Pair<string, long>> Project(IEnumerable<GraphItem> graphItems, ISelector selector);
        }

        private interface ISelector
        {
            long Select(GraphItem graphItem);
            string Unit { get; }
        }

        private class TimeSelector : ISelector
        {
            public long Select(GraphItem graphItem)
            {
                return (long)CalculateDowntime(graphItem).TotalMinutes;
            }

            public override string ToString()
            {
                return "Tid";
            }

            #region ISelector Members


            public string Unit
            {
                get
                {
                    return "minutter";
                }
                
            }

            #endregion
        }

        private class CostSelector : ISelector
        {
            private IDictionary<string, long> costMap = new Dictionary<string, long>();

            public CostSelector(IEnumerable<MachineConfiguration> machines)
            {
                foreach (var machine in machines)
                {
                    costMap.Add(machine.MachineName, machine.BaseCost);
                }
            }

            public long Select(GraphItem graphItem)
            {
                return (int)(CalculateDowntime(graphItem).TotalHours  * costMap[graphItem.Machine]);
            }

            public override string ToString()
            {
                return "Omkostninger";
            }

            #region ISelector Members


            public string Unit
            {
                get
                {
                    return "kroner";
                }

            }

            #endregion
        }

        private class DateProjector : IProjector
        {
            public IEnumerable<Pair<string, long>> Project(IEnumerable<GraphItem> graphItems, ISelector selector)
            {
                if (graphItems.Count() == 0)
                    return new List<Pair<string, long>>();
                DateTime start = graphItems.Min(p => p.ProductionDate);
                DateTime end = graphItems.Max(p => p.ProductionDate);

                List<Pair<string, long>> result = new List<Pair<string, long>>();

                for (DateTime s = start.Date; s <= end.Date; s = s.AddDays(1) )
                {
                    result.Add(new Pair<string, long>(s.ToShortDateString(), graphItems.Where(p => p.ProductionDate.Date.Equals(s)).Sum(q => selector.Select(q))));
                }

                return result;
            }

            public override string ToString()
            {
                return "Dato";
            }
        }

        private class MachineProjector : IProjector
        {
            #region IProjector Members

            public IEnumerable<Pair<string, long>> Project(IEnumerable<GraphItem> graphItems, ISelector selector)
            {
                if (graphItems.Count() == 0)
                    return new List<Pair<string, long>>();

                List<Pair<string, long>> result = new List<Pair<string, long>>();

                foreach (var machine in graphItems.Select(p => p.Machine).Distinct())
                {
                    result.Add(new Pair<string, long>(machine, graphItems.Where(p => p.Machine.Equals(machine)).Sum(q => selector.Select(q))));
                }

                return result;
            }

            #endregion

            public override string ToString()
            {
                return "Maskine";
            }
        }

        private class TeamProjector : IProjector
        {
            #region IProjector Members

            public IEnumerable<Pair<string, long>> Project(IEnumerable<GraphItem> graphItems, ISelector selector)
            {
                if (graphItems.Count() == 0)
                    return new List<Pair<string, long>>();

                List<Pair<string, long>> result = new List<Pair<string, long>>();

                foreach (var team in graphItems.Select(p => p.Team).Distinct())
                {
                    result.Add(new Pair<string, long>(team.Name, graphItems.Where(p => p.Team.Equals(team)).Sum(q => selector.Select(q))));
                }

                return result;
            }

            #endregion

            public override string ToString()
            {
                return "Hold";
            }
        }

        private List<GraphItem> graphItems = new List<GraphItem>();
        private List<MachineConfiguration> machines = new List<MachineConfiguration>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            graphItems = new List<GraphItem>();

            using (RepositoryFactory factory = new RepositoryFactory())
            {
                using (IProductionQueryRepository repository = factory.CreateProductionQueryRepository())
                {
                    ProductionQuery query = GenerateQuery();

                    foreach (var production in repository.LoadProductions(query))
                    {
                        foreach (var shift in production.Shifts)
                        {
                            graphItems.Add(new GraphItem(production.Machine, shift.ProductionStart, shift.Team, shift.ProductionStopRegistrations));
                        }
                    }
                }
            }

            UpdateGraph();
            UpdateStatusBox();
        }

        private void UpdateStatusBox()
        {
            TimeSpan downtime = CalculateDownTime();
            long cost = CalculateCost();

            string s =
                string.Format(
                    "I henhold til de angivne kriterier har der været {0} stop. Stoppene har sammenlagt varet {1} minutter (ca. {2} dage) og har kostet {3} kr.",
                    graphItems.Sum(g => g.StopRegistrations.Count),
                    downtime.TotalMinutes,
                    downtime.TotalDays.ToString("N1"),
                    cost);

            tbStatus.Text = s;

        }

        private long CalculateCost()
        {
            var result = 0l;

            foreach (var graphItem in graphItems)
            {
                result = result + (long) (machines.Where(m => m.MachineName == graphItem.Machine).FirstOrDefault().BaseCost * CalculateDowntime(graphItem).TotalHours);
            }

            return result;
        }

        private TimeSpan CalculateDownTime()
        {
            var result = new TimeSpan();

            foreach (var graphItem in graphItems)
            {
                result = result + CalculateDowntime(graphItem);
            }

            return result;
        }

        private static TimeSpan CalculateDowntime(GraphItem graphItem)
        {
            var result = new TimeSpan();

            foreach (var stopRegistration in graphItem.StopRegistrations)
            {
                result = result + stopRegistration.Duration;
            }
            return result;
        }

        private void UpdateGraph()
        {
            chart.Series[0].Points.Clear();
            IEnumerable<Pair<string, long>> points = ((IProjector) cbCombine.SelectedItem).Project(graphItems,
                                                                                           (ISelector)
                                                                                           cbShowType.SelectedItem);

            if (points.Count() == 0)
                return;

            List<string> xValues = new List<string>(points.Select(p => p.First));
            List<long> series1Values = new List<long>(points.Select(p => p.Second));
            chart.Series[0].Points.DataBindXY(xValues, series1Values);
            chart.Series[0].Name = ((ISelector)cbShowType.SelectedItem).Unit;
            
        }
        private ProductionQuery GenerateQuery()
        {
            return ucFilter.Query;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ucFilter.LoadData();
            using (RepositoryFactory factory = new RepositoryFactory())
            {
                using (
                    IEntityRepository<MachineConfiguration> repository =
                        factory.CreateEntityRepository<MachineConfiguration>())
                {
                    LoadData(repository.LoadAll());
                }
            }
        }

        private void LoadData(IEnumerable<MachineConfiguration> machines)
        {
            this.machines = new List<MachineConfiguration>(machines);
            cbShowType.Items.Clear();
            cbShowType.Items.Add(new TimeSelector());
            cbShowType.Items.Add(new CostSelector(machines));
            cbShowType.SelectedIndex = 0;

            cbCombine.Items.Clear();
            cbCombine.Items.Add(new DateProjector());
            cbCombine.Items.Add(new MachineProjector());
            cbCombine.Items.Add(new TeamProjector());
            cbCombine.SelectedIndex = 0;
        }

        private void cbShowType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCombine.SelectedItem != null)
                UpdateGraph();
        }

        private void cbCombine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbShowType.SelectedItem != null)
                UpdateGraph();
        }

        private void btnUpdateBaseCost_Click(object sender, EventArgs e)
        {
            using (RepositoryFactory factory = new RepositoryFactory())
            {
                using (
                    IEntityRepository<MachineConfiguration> repository =
                        factory.CreateEntityRepository<MachineConfiguration>())
                {
                    List<MachineConfiguration> machines = new List<MachineConfiguration>(repository.LoadAll());

                    using (BaseCostForm form = new BaseCostForm())
                    {
                        form.Machines = machines;
                        if (form.ShowDialog(this) == DialogResult.OK)
                        {
                            foreach (var machine in machines)
                            {
                                repository.Save(machine);
                            }
                            LoadData(machines);
                        }
                    }
                }

            }
        }
    }

    
}