using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Mikadocs.OEE.Repository;

namespace Mikadocs.OEE.ManagementConsole
{
    public partial class ProductionDataGridUserControl : UserControl
    {
        private IEnumerable<Production> _productions;
        private readonly RepositoryFactory _repositoryFactory;
        public ProductionDataGridUserControl()
        {
            InitializeComponent();
            SetTexts();
            productionStopRegistrationGridView.AutoGenerateColumns = false;
            _repositoryFactory = new RepositoryFactory();
            productionFilterUserControl1.FilterChanged += OnFilterChanged;

            productionFilterUserControl1.Initialize(Settings.Default.Machines.Cast<string>().ToList(), GetTeams());
            

            Load();
        }

        
        public void Save()
        {
            SaveProductions();            
        }

        public new void Load()
        {
            productionDataGrid.DataSource = LoadProductions();
            productionDataGrid.Refresh();
            productionStopViewEntityBindingSource.DataSource = LoadProductionStops();
            ProductionStopRegistrationViewEntity.Stops = _repositoryFactory.CreateEntityRepository().LoadAll<ProductionStop>();
        }

        public void Add()
        {
            if (productionShiftDataGrid.SelectedRows.Count > 0)
            {
                if (productionLegDataGrid.SelectedRows.Count == 1)
                {
                    var viewEntity =
                        (ProductionLegViewEntity) productionLegDataGrid.SelectedRows[0].DataBoundItem;

                    viewEntity.Entity.AddProductionStopRegistration(new ProductionStopRegistration(ProductionStopRegistrationViewEntity.Stops.First(), TimeSpan.Zero));
                    ShowProductionStopRegistrations(SelectedProductionLegViewEntity);
                }
            }
        }

        public void Delete()
        {
            bool save = true;
            var shifts = SelectedProductionViewEntity != null ? new List<ProductionShiftViewEntity>(SelectedProductionViewEntity.Shifts) : new List<ProductionShiftViewEntity>();

            if (productionShiftDataGrid.SelectedRows.Count > 0)
            {
                var legs = new List<ProductionLegViewEntity>(SelectedProductionShiftViewEntity.Legs);
                    
                if (productionLegDataGrid.SelectedRows.Count > 0)
                {
                    
                    if (productionStopRegistrationGridView.SelectedRows.Count > 0)
                    {
                        var entities =
                            new List<ProductionStopRegistrationViewEntity>(
                                SelectedProductionLegViewEntity.ProductionStopRegistrations);

                        foreach (DataGridViewRow row in productionStopRegistrationGridView.SelectedRows)
                        {
                            var viewEntity =
                                (ProductionStopRegistrationViewEntity)row.DataBoundItem;

                            entities.Remove(viewEntity);
                        }

                        SelectedProductionLegViewEntity.ProductionStopRegistrations = entities;                        
                    }
                    else
                    {
                        foreach (DataGridViewRow row in productionLegDataGrid.SelectedRows)
                        {
                            var legViewEntity = (ProductionLegViewEntity)row.DataBoundItem;

                            SelectedProductionShiftViewEntity.Entity.RemoveProductionLeg(legViewEntity.Entity);
                            legs.Remove(legViewEntity);

                        }                        
                    }                                        
                }
                else
                {
                    foreach (var leg in legs)
                    {
                        Delete(leg.Entity);
                    }
                    legs.Clear();
                }

                if (legs.Count == 0)
                {
                    shifts.Remove(SelectedProductionShiftViewEntity);
                    if (SelectedProductionViewEntity != null)
                        SelectedProductionViewEntity.Entity.RemoveProductionShift(SelectedProductionShiftViewEntity.Entity);
                    Delete(SelectedProductionShiftViewEntity.Entity);                    
                }
            }
            else
            {
                foreach (var shift in shifts)
                {
                    if (SelectedProductionViewEntity != null)
                        SelectedProductionViewEntity.Entity.RemoveProductionShift(shift.Entity);
                    Delete(shift.Entity);
                }
                shifts.Clear();
            }

            if (shifts.Count == 0)
            {
                if (SelectedProductionViewEntity != null) Delete(SelectedProductionViewEntity.Entity);
                save = false;
            }

            if (save)
                Save();
            Load();            
        }

        private ProductionViewEntity SelectedProductionViewEntity
        {
            get
            {
                ProductionViewEntity productionViewEntity = null;

                foreach (DataGridViewRow row in productionDataGrid.SelectedRows)
                {
                    productionViewEntity = (ProductionViewEntity)row.DataBoundItem;
                }

                return productionViewEntity;
            }
        }

        private ProductionShiftViewEntity SelectedProductionShiftViewEntity
        {
            get
            {
                ProductionShiftViewEntity productionShiftViewEntity = null;

                foreach (DataGridViewRow row in productionShiftDataGrid.SelectedRows)
                {
                    productionShiftViewEntity = (ProductionShiftViewEntity)row.DataBoundItem;
                }

                return productionShiftViewEntity;
            }
        }

        private ProductionLegViewEntity SelectedProductionLegViewEntity
        {
            get
            {
                ProductionLegViewEntity productionLegViewEntity = null;

                foreach (DataGridViewRow row in productionLegDataGrid.SelectedRows)
                {
                    productionLegViewEntity = (ProductionLegViewEntity) row.DataBoundItem;
                }

                return productionLegViewEntity;
            }
        }
        private void OnProductionSelectionChanged(object sender, EventArgs e)
        {

            ShowProductionShifts(SelectedProductionViewEntity);
        }

        private void ShowProductionShifts(ProductionViewEntity viewEntity)
        {
            productionShiftViewEntityBindingSource.DataSource = viewEntity == null ? new ProductionShiftViewEntityBindingList(new List<ProductionShiftViewEntity>()) : new ProductionShiftViewEntityBindingList(viewEntity.Shifts);
        }

        private void OnProductionShiftSelectionChanged(object sender, EventArgs e)
        {
            ShowProductionLegs(SelectedProductionShiftViewEntity);
        }

        private void ShowProductionLegs(ProductionShiftViewEntity viewEntity)
        {
            productionLegDataGrid.DataSource = viewEntity == null ? new ProductionLegViewEntityBindingList(new List<ProductionLegViewEntity>()) : new ProductionLegViewEntityBindingList(viewEntity.Legs);
        }

        private void OnProductionLegSelectionChanged(object sender, EventArgs e)
        {
            ShowProductionStopRegistrations(SelectedProductionLegViewEntity);
        }       
        
        private void ShowProductionStopRegistrations(ProductionLegViewEntity viewEntity)
        {
            productionStopRegistrationGridView.DataSource = viewEntity == null ? new ProductionStopRegistrationViewEntityBindingList(new List<ProductionStopRegistrationViewEntity>()) : new ProductionStopRegistrationViewEntityBindingList(new List<ProductionStopRegistrationViewEntity>(viewEntity.ProductionStopRegistrations));
        }

        private void SetTexts()
        {
            productionLabel.Text = Strings.Production;
            productionStopRegistrationLabel.Text = Strings.ProductionStop;
        }

        private ProductionViewEntityBindingList LoadProductions()
        {
            _productions = _repositoryFactory.CreateProductionQueryRepository(false).LoadProductions(productionFilterUserControl1.Query);

            return new ProductionViewEntityBindingList(_productions.Select(p => new ProductionViewEntity(p)));
        }

        private ProductionStopViewEntityBindingList LoadProductionStops()
        {
            return new ProductionStopViewEntityBindingList(
               
                _repositoryFactory.CreateEntityRepository().LoadAll<ProductionStop>().Select(p => new ProductionStopViewEntity(p)));
        }

        private void SaveProductions()
        {
            if (_productions == null)
                return;

            _repositoryFactory.CreateEntityRepository().SaveAll(_productions);            
        }

        private void Delete(EntityObject p)
        {            
            _repositoryFactory.CreateEntityRepository().Delete(p);            
        }          
  
        private void OnFilterChanged(object sender, EventArgs e)
        {
            Load();
        }

        private static IEnumerable<ProductionTeam> GetTeams()
        {
            using (var factory = new RepositoryFactory())
            {
                return factory.CreateEntityRepository().LoadAll<ProductionTeam>();
            }
        }
    }
}
