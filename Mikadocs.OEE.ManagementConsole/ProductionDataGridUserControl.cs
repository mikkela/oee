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
    public partial class ProductionDataGridUserControl : UserControl
    {
        private IEnumerable<Production> productions = null;
        private NewRepository repository;
        public ProductionDataGridUserControl()
        {
            InitializeComponent();
            SetTexts();
            productionStopRegistrationGridView.AutoGenerateColumns = false;
            repository = new NewRepository();

            cbMachine.DataSource = Settings.Default.Machines;
            cbMachine.SelectedItem = null;

            cbTeam.DataSource = GetTeams();
            cbTeam.DisplayMember = "Name";
            cbTeam.SelectedItem = null;

            Load();
        }

        
        public void Save()
        {
            repository.BeginTransaction();
            SaveProductions();
            repository.Commit();
        }

        public void Load()
        {
            productionDataGrid.DataSource = LoadProductions();
            productionDataGrid.Refresh();
            productionStopViewEntityBindingSource.DataSource = LoadProductionStops();
            ProductionStopRegistrationViewEntity.Stops = repository.LoadAll<ProductionStop>();
        }

        public void Add()
        {
            if (productionShiftDataGrid.SelectedRows.Count > 0)
            {
                if (productionLegDataGrid.SelectedRows.Count == 1)
                {
                    ProductionLegViewEntity viewEntity =
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
                        List<ProductionStopRegistrationViewEntity> entities =
                            new List<ProductionStopRegistrationViewEntity>(
                                SelectedProductionLegViewEntity.ProductionStopRegistrations);

                        foreach (DataGridViewRow row in productionStopRegistrationGridView.SelectedRows)
                        {
                            ProductionStopRegistrationViewEntity viewEntity =
                                (ProductionStopRegistrationViewEntity)row.DataBoundItem;

                            entities.Remove(viewEntity);
                        }

                        SelectedProductionLegViewEntity.ProductionStopRegistrations = entities;                        
                    }
                    else
                    {
                        foreach (DataGridViewRow row in productionLegDataGrid.SelectedRows)
                        {
                            ProductionLegViewEntity legViewEntity = (ProductionLegViewEntity)row.DataBoundItem;

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
                    SelectedProductionViewEntity.Entity.RemoveProductionShift(SelectedProductionShiftViewEntity.Entity);
                    Delete(SelectedProductionShiftViewEntity.Entity);                    
                }
            }
            else
            {
                foreach (var shift in shifts)
                {
                    SelectedProductionViewEntity.Entity.RemoveProductionShift(shift.Entity);
                    Delete(shift.Entity);
                }
                shifts.Clear();
            }

            if (shifts.Count == 0)
            {
                Delete(SelectedProductionViewEntity.Entity);
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
            if (viewEntity == null)
                productionShiftViewEntityBindingSource.DataSource = new ProductionShiftViewEntityBindingList(new List<ProductionShiftViewEntity>());
            else
                productionShiftViewEntityBindingSource.DataSource = new ProductionShiftViewEntityBindingList(viewEntity.Shifts);
        }

        private void OnProductionShiftSelectionChanged(object sender, EventArgs e)
        {
            ShowProductionLegs(SelectedProductionShiftViewEntity);
        }

        private void ShowProductionLegs(ProductionShiftViewEntity viewEntity)
        {
            if (viewEntity == null)
                productionLegDataGrid.DataSource = new ProductionLegViewEntityBindingList(new List<ProductionLegViewEntity>());
            else
                productionLegDataGrid.DataSource = new ProductionLegViewEntityBindingList(viewEntity.Legs);            
        }

        private void OnProductionLegSelectionChanged(object sender, EventArgs e)
        {
            ShowProductionStopRegistrations(SelectedProductionLegViewEntity);
        }       
        
        private void ShowProductionStopRegistrations(ProductionLegViewEntity viewEntity)
        {
            if (viewEntity == null)
                productionStopRegistrationGridView.DataSource =
                    new ProductionStopRegistrationViewEntityBindingList(new List<ProductionStopRegistrationViewEntity>());
            else
                productionStopRegistrationGridView.DataSource =
                    new ProductionStopRegistrationViewEntityBindingList(new List<ProductionStopRegistrationViewEntity>(viewEntity.ProductionStopRegistrations));
        }

        private void SetTexts()
        {
            productionLabel.Text = Strings.Production;
            //productionLegLabel.Text = Strings.ProductionLeg;
            productionStopRegistrationLabel.Text = Strings.ProductionStop;
        }

        private ProductionViewEntityBindingList LoadProductions()
        {
            productions = repository.LoadProductions(Query);

            return new ProductionViewEntityBindingList(productions.Select(p => new ProductionViewEntity(p)));
        }

        private ProductionStopViewEntityBindingList LoadProductionStops()
        {
            return new ProductionStopViewEntityBindingList(
               
                repository.LoadAll<ProductionStop>().Select(p => new ProductionStopViewEntity(p)));
        }

        private void SaveProductions()
        {
            if (productions == null)
                return;

            repository.Save(productions);            
        }

        private void Delete(object p)
        {
            repository.BeginTransaction();
            repository.Delete(p);
            repository.Commit();
        }          
  
        private ProductionQuery Query
        {
            get
            {
                var result = new ProductionQuery().AddDateRange(dtPeriodStart.Value, dtPeriodEnd.Value);

                if (!string.IsNullOrEmpty(txtProduct.Text))
                    result = result.AddProduct(new ProductNumber(txtProduct.Text));

                if (!string.IsNullOrEmpty(txtOrder.Text))
                    result = result.AddOrder(new OrderNumber(txtOrder.Text));

                if (cbMachine.SelectedItem != null)
                    result = result.AddMachine(cbMachine.SelectedItem.ToString());
                if (cbTeam.SelectedItem != null)
                    result = result.AddTeam((ProductionTeam)cbTeam.SelectedItem);

                return result;
            }
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            Load();
        }

        private IEnumerable<ProductionTeam> GetTeams()
        {
            using (RepositoryFactory factory = new RepositoryFactory())
            {
                using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
                {
                    return repository.LoadAll();
                }
            }
        }
    }
}
