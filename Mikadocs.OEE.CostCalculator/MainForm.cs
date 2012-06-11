using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mikadocs.OEE.Repository;

namespace Mikadocs.OEE.CostCalculator
{
    public partial class MainForm : Form
    {
        private class GraphItem
        {
            private readonly string _machine;
            private readonly DateTime _productionDate;
            private readonly ProductionTeam _team;
            private readonly List<ProductionStopRegistration> _stopRegistrations;

            public GraphItem(string machine, DateTime productionDate, ProductionTeam team, IEnumerable<ProductionStopRegistration> stopRegistrations)
            {
                _machine = machine;
                _productionDate = productionDate;
                _team = team;
                _stopRegistrations = new List<ProductionStopRegistration>(stopRegistrations);
            }

            public string Machine
            {
                get { return _machine; }
            }

            public DateTime ProductionDate
            {
                get { return _productionDate; }
            }

            public ProductionTeam Team
            {
                get { return _team; }
            }

            public List<ProductionStopRegistration> StopRegistrations
            {
                get { return _stopRegistrations; }
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
            private readonly IDictionary<string, long> _costMap = new Dictionary<string, long>();

            public CostSelector(IEnumerable<MachineConfiguration> machines)
            {
                foreach (var machine in machines)
                {
                    _costMap.Add(machine.MachineName, machine.BaseCost);
                }
            }

            public long Select(GraphItem graphItem)
            {
                return (int)(CalculateDowntime(graphItem).TotalHours * _costMap[graphItem.Machine]);
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

                var result = new List<Pair<string, long>>();

                for (var s = start.Date; s <= end.Date; s = s.AddDays(1))
                {
                    DateTime s1 = s;
                    result.Add(new Pair<string, long>(s.ToShortDateString(), graphItems.Where(p => p.ProductionDate.Date.Equals(s1)).Sum(q => selector.Select(q))));
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

                return graphItems.Select(p => p.Machine).Distinct().Select(machine => new Pair<string, long>(machine, graphItems.Where(p => p.Machine.Equals(machine)).Sum(q => selector.Select(q)))).ToList();
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

                return graphItems.Select(p => p.Team).Distinct().Select(team => new Pair<string, long>(team.Name, graphItems.Where(p => p.Team.Equals(team)).Sum(q => selector.Select(q)))).ToList();
            }

            #endregion

            public override string ToString()
            {
                return "Hold";
            }
        }

        private List<GraphItem> _graphItems = new List<GraphItem>();
        private List<MachineConfiguration> _machines = new List<MachineConfiguration>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnUpdateClick(object sender, EventArgs e)
        {
            Update();
        }

        private new void Update()
        {
            _graphItems = new List<GraphItem>();

            using (var factory = new RepositoryFactory())
            {
                var repository = factory.CreateProductionQueryRepository(true);
                var query = GenerateQuery();

                foreach (var production in repository.LoadProductions(query))
                {
                    foreach (var shift in production.Shifts)
                    {
                        _graphItems.Add(new GraphItem(production.Machine, shift.ProductionStart, shift.Team,
                                                      shift.ProductionStopRegistrations));
                    }
                }
            }        

            UpdateGraph();
            UpdateStatusBox();
        }

        private void UpdateStatusBox()
        {
            var downtime = CalculateDownTime();
            var cost = CalculateCost();

            var s =
                string.Format(
                    "I henhold til de angivne kriterier har der været {0} stop. Stoppene har sammenlagt varet {1} minutter (ca. {2} dage) og har kostet {3} kr.",
                    _graphItems.Sum(g => g.StopRegistrations.Count),
                    downtime.TotalMinutes,
                    downtime.TotalDays.ToString("N1"),
                    cost);

            tbStatus.Text = s;

        }

        private long CalculateCost()
        {
            return _graphItems.Aggregate(0l, (current, graphItem) => current + (long) (_machines.Where(m => m.MachineName == graphItem.Machine).FirstOrDefault().BaseCost*CalculateDowntime(graphItem).TotalHours));
        }

        private TimeSpan CalculateDownTime()
        {
            var result = new TimeSpan();

            return _graphItems.Aggregate(result, (current, graphItem) => current + CalculateDowntime(graphItem));
        }

        private static TimeSpan CalculateDowntime(GraphItem graphItem)
        {
            var result = new TimeSpan();

            return graphItem.StopRegistrations.Aggregate(result, (current, stopRegistration) => current + stopRegistration.Duration);
        }

        private void UpdateGraph()
        {
            chart.Series[0].Points.Clear();
            var points = ((IProjector)cbCombine.SelectedItem).Project(_graphItems,
                                                                                           (ISelector)
                                                                                           cbShowType.SelectedItem);

            if (points.Count() == 0)
                return;

            var xValues = new List<string>(points.Select(p => p.First));
            var series1Values = new List<long>(points.Select(p => p.Second));
            chart.Series[0].Points.DataBindXY(xValues, series1Values);
            chart.Series[0].Name = ((ISelector)cbShowType.SelectedItem).Unit;

        }
        private ProductionQuery GenerateQuery()
        {
            return ucFilter.Query;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            ucFilter.LoadData();
            using (var factory = new RepositoryFactory())
            {
                LoadData(factory.CreateEntityRepository().LoadAll<MachineConfiguration>());
            }
        }

        private void LoadData(IEnumerable<MachineConfiguration> machines)
        {
            _machines = new List<MachineConfiguration>(machines);
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

        private void CbShowTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCombine.SelectedItem != null)
                UpdateGraph();
        }

        private void CbCombineSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbShowType.SelectedItem != null)
                UpdateGraph();
        }

        private void BtnUpdateBaseCostClick(object sender, EventArgs e)
        {
            using (var factory = new RepositoryFactory())
            {
                var repository = factory.CreateEntityRepository();
                var machines =
                    new List<MachineConfiguration>(repository.LoadAll<MachineConfiguration>());

                using (var form = new BaseCostForm())
                {
                    form.Machines = machines;
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        repository.SaveAll(machines);
                        LoadData(machines);
                    }
                }
            }
        }
    }
}