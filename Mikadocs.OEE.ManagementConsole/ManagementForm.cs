using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Mikadocs.OEE.Repository;

namespace Mikadocs.OEE.ManagementConsole
{
    public partial class ManagementForm : Form
    {
        private RepositoryFactory _repositoryFactory;
        public ManagementForm()
        {
            _repositoryFactory = new RepositoryFactory();
            InitializeComponent();

            dgProductions.AutoGenerateColumns = false;
            SetTexts();

            LoadData();
        }

        #region Helpers

        private void SetTexts()
        {
            txtHeader.Text = Strings.Header;
            txtCopyright.Text = Strings.Copyright;
            machineDataGridViewTextBoxColumn.HeaderText = Strings.Machine;
            orderDataGridViewTextBoxColumn.HeaderText = Strings.Order;
            productDataGridViewTextBoxColumn.HeaderText = Strings.Product;
            expectedItemsDataGridViewTextBoxColumn.HeaderText = Strings.ExpectedItems;
            producedItemsPerHourDataGridViewTextBoxColumn.HeaderText = Strings.ProducedItems;
            productionStartDataGridViewTextBoxColumn.HeaderText = Strings.ProductionStart;
            productionEndDataGridViewTextBoxColumn.HeaderText = Strings.ProductionEnd;
        }

        private void LoadData()
        {
            productionViewEntityBindingSource.DataSource = RetrieveProductions();            
        }

        private IEnumerable<ProductionViewEntity> RetrieveProductions()
        {
            return
                new ProductionViewEntityBindingList(
                    _repositoryFactory.CreateEntityRepository().LoadAll<Production>().Select(p => new ProductionViewEntity(p)));
        }

        private void GenerateReport()
        {
            using (GenerateReportForm form = new GenerateReportForm())
            {
                form.ShowDialog(this);
            }
        }

        private void ManageData()
        {
            using (ManageDataForm form = new ManageDataForm())
            {
                form.ShowDialog(this);
            }
        }

        private void SetupMachine()
        {
            using (SetupMachineForm form = new SetupMachineForm())
            {
                form.ShowDialog(this);
            }
        }

        #endregion

        #region Event Handlers
        private void OnClose(object sender, EventArgs e)
        {
            this.Close();

        }

        private void OnGenerateReport(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void OnManageData(object sender, EventArgs e)
        {
            ManageData();
        }

        private void OnSetupMachine(object sender, EventArgs e)
        {
            SetupMachine();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }
        #endregion        

        private void OnMinimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
