using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Mikadocs.OEE.Repository;
using Mikadocs.OEE.Security;

namespace Mikadocs.OEE.ManagementConsole
{
    public partial class MachineConfigurationUserControl : UserControl
    {
        private MachineConfiguration _machineConfiguration;

        public MachineConfigurationUserControl()
        {
            InitializeComponent();

            dgProductionStops.AutoGenerateColumns = false;
            dgProductionStops.Columns[0].HeaderText = Strings.ProductionStop;
            dgProductionStops.Columns[1].HeaderText = Strings.Planned;
            if (!DesignMode)
                Load();
            pbAdd.Enabled = SecurityManager.CanEditManagementConsole;
            pbDelete.Enabled = SecurityManager.CanEditManagementConsole;
            pbDown.Enabled = SecurityManager.CanEditManagementConsole;
            pbUp.Enabled = SecurityManager.CanEditManagementConsole;
        }

        public void Save()
        {
            var ps = (from view in (IEnumerable<ProductionStopViewEntity>) productionStopViewEntityBindingSource.DataSource
                      select view.Entity).ToList();

            _machineConfiguration.AvailableProductionStops = ps;
            SaveMachineConfiguration();
        }

        public new void Load()
        {
            _machineConfiguration = LoadMachineConfiguration();

            UpdateDataSource();
        }

        private void UpdateDataSource()
        {
            var productionStops = (from p in _machineConfiguration.AvailableProductionStops
                                   where p != null
                                   select new ProductionStopViewEntity(p)).ToList();

            productionStopViewEntityBindingSource.DataSource = productionStops;
        }

        private static MachineConfiguration LoadMachineConfiguration()
        {
            using (var factory = new RepositoryFactory())
            {
                var machineConfigurations = factory.CreateEntityRepository().LoadAll<MachineConfiguration>();
                return machineConfigurations.Any() ? machineConfigurations.First() : null;
            }            
        }

        private void SaveMachineConfiguration()
        {
            using (var factory = new RepositoryFactory())
            {
                var repository = factory.CreateEntityRepository();
                repository.SaveAll(_machineConfiguration.AvailableProductionStops);
                repository.Save(_machineConfiguration);
            }
        }

        private void OnMoveDown(object sender, EventArgs e)
        {
            if (dgProductionStops.CurrentRow != null)
            {
                int index = dgProductionStops.CurrentRow.Index;
                if (index == dgProductionStops.RowCount - 1)
                    return;

                Swap(index, index + 1);
            }
        }

        private void OnMoveUp(object sender, EventArgs e)
        {
            if (dgProductionStops.CurrentRow != null)
            {
                int index = dgProductionStops.CurrentRow.Index;
                if (index == 0)
                    return;

                Swap(index - 1, index);
            }
        }

        private void Swap(int index1, int index2)
        {
            var list = new List<ProductionStopViewEntity>((IEnumerable<ProductionStopViewEntity>)productionStopViewEntityBindingSource.DataSource);

            ProductionStopViewEntity tmp = list[index2];
            list[index2] = list[index1];
            list[index1] = tmp;

            productionStopViewEntityBindingSource.DataSource = list;
        }

        private void OnAddNewStop(object sender, EventArgs e)
        {
            using (var form = new AddNewProductionStopForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    var newStop = new ProductionStop(form.ProductionStopName);
                    using (var factory = new RepositoryFactory())
                    {
                        var repository = factory.CreateEntityRepository();

                        repository.Save(newStop);
                        foreach (var machine in repository.LoadAll<MachineConfiguration>())
                        {
                            var stops = new List<ProductionStop>(machine.AvailableProductionStops) {newStop};
                            machine.AvailableProductionStops = stops;

                            repository.Save(machine);
                        }
                        
                        Load();
                    }
                }
            }
        }

        private static void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private static void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }

        private void OnDeleteExistingStop(object sender, EventArgs e)
        {
            if (dgProductionStops.CurrentRow != null)
            {
                _machineConfiguration.AvailableProductionStops =
                    _machineConfiguration.AvailableProductionStops.Where(
                        p => !p.Equals((dgProductionStops.CurrentRow.DataBoundItem as ProductionStopViewEntity).Entity));
                
                UpdateDataSource();
                
            }
        }
    }
}
