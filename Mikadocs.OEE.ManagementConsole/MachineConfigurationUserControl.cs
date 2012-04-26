using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Mikadocs.OEE.Repository;

namespace Mikadocs.OEE.ManagementConsole
{
    public partial class MachineConfigurationUserControl : UserControl
    {
        private MachineConfiguration machineConfiguration;

        public MachineConfigurationUserControl()
        {
            InitializeComponent();

            dgProductionStops.AutoGenerateColumns = false;
            dgProductionStops.Columns[0].HeaderText = Strings.ProductionStop;
            dgProductionStops.Columns[1].HeaderText = Strings.Planned;
            if (!DesignMode)
                Load();
        }

        public void Save()
        {
            List<ProductionStop> ps = new List<ProductionStop>();
            foreach (ProductionStopViewEntity view in (IEnumerable<ProductionStopViewEntity>)productionStopViewEntityBindingSource.DataSource)
            {
                ps.Add(view.Entity);
            }

            machineConfiguration.AvailableProductionStops = ps;
            SaveMachineConfiguration();
        }

        public void Load()
        {
            machineConfiguration = LoadMachineConfiguration();

            List<ProductionStopViewEntity> productionStops = new List<ProductionStopViewEntity>();
            foreach (ProductionStop p in machineConfiguration.AvailableProductionStops)
            {
                if (p != null)
                    productionStops.Add(new ProductionStopViewEntity(p));
            }

            productionStopViewEntityBindingSource.DataSource = productionStops;
            
        }

        private MachineConfiguration LoadMachineConfiguration()
        {
            using (RepositoryFactory factory = new RepositoryFactory())
            {
                using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
                {
                    return new List<MachineConfiguration>(repository.LoadAll())[0];
                }
            }            
        }

        private void SaveMachineConfiguration()
        {
            using (RepositoryFactory factory = new RepositoryFactory())
            {
                using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
                {
                    foreach (ProductionStop p in machineConfiguration.AvailableProductionStops)
                    {
                        repository.Save(p);
                    }
                }
                using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
                {
                    repository.Save(machineConfiguration);        
                }
            }
        }

        private void OnMoveDown(object sender, EventArgs e)
        {
            int index = dgProductionStops.CurrentRow.Index;
            if (index == dgProductionStops.RowCount - 1)
                return;

            Swap(index, index + 1);

        }

        private void OnMoveUp(object sender, EventArgs e)
        {
            int index = dgProductionStops.CurrentRow.Index;
            if (index == 0)
                return;

            Swap(index - 1, index);
        }

        private void Swap(int index1, int index2)
        {
            List<ProductionStopViewEntity> list = new List<ProductionStopViewEntity>((IEnumerable<ProductionStopViewEntity>)productionStopViewEntityBindingSource.DataSource);

            ProductionStopViewEntity tmp = list[index2];
            list[index2] = list[index1];
            list[index1] = tmp;

            productionStopViewEntityBindingSource.DataSource = list;
        }

        private void OnAddNewStop(object sender, EventArgs e)
        {
            using (AddNewProductionStopForm form = new AddNewProductionStopForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    ProductionStop newStop = new ProductionStop(form.ProductionStopName);
                    using (RepositoryFactory factory = new RepositoryFactory())
                    {
                        using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
                        {
                            repository.Save(newStop);
                        }

                        using (var repository = factory.CreateEntityRepository<MachineConfiguration>())
                        {
                            foreach (var machine in repository.LoadAll())
                            {
                                List<ProductionStop> stops = new List<ProductionStop>(machine.AvailableProductionStops);
                                stops.Add(newStop);
                                machine.AvailableProductionStops = stops;

                                repository.Save(machine);
                            }                            
                        }                        

                        Load();
                    }
                }
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }
    }
}
