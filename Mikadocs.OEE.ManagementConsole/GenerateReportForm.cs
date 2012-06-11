using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

using Mikadocs.OEE.Repository;

namespace Mikadocs.OEE.ManagementConsole
{
    public partial class GenerateReportForm : Form
    {
        private readonly PrintDocument _printDocument = new PrintDocument();
        
        public GenerateReportForm()
        {
            InitializeComponent();

            _printDocument.DefaultPageSettings.Landscape = true;
            _printDocument.PrintPage += OnPrintDocument;
            cbMachine.DataSource = Settings.Default.Machines;
            cbMachine.SelectedItem = null;

            cbTeam.DataSource = GetTeams();
            cbTeam.DisplayMember = "Name";
            cbTeam.SelectedItem = null;

            SetTexts();            
        }

        private void SetTexts()
        {
            txtHeader.Text = Strings.Header;
            lblPeriodStart.Text = Strings.PeriodStart;
            lblPeriodEnd.Text = Strings.PeriodEnd;
            lblProduct.Text = Strings.Product;
            lblMachine.Text = Strings.Machine;
            lblOrder.Text = Strings.Order;
        }

        private void GenerateReport()
        {
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (var factory = new RepositoryFactory())
                {

                    var repository = factory.CreateProductionQueryRepository(true);

                    ProductionQuery query = new ProductionQuery().AddDateRange(dtPeriodStart.Value,
                                                                               dtPeriodEnd.Value);
                    if (!string.IsNullOrEmpty(txtProduct.Text))
                        query = query.AddProduct(new ProductNumber(txtProduct.Text));
                    if (!string.IsNullOrEmpty(txtOrder.Text))
                        query = query.AddOrder(new OrderNumber(txtOrder.Text));
                    if (cbMachine.SelectedItem != null)
                        query = query.AddMachine(cbMachine.SelectedItem.ToString());
                    if (cbTeam.SelectedItem != null)
                        query = query.AddTeam((ProductionTeam) cbTeam.SelectedItem);

                    ShowResults(query, repository.LoadProductions(query));
                }
            } finally
            {
                Cursor.Current = cursor;
            }
        }

        private void ShowResults(ProductionQuery query, IEnumerable<Production> productions)
        {
            IEnumerable<ProductionStop> stops = GetProductionStops();

            ucReport.UpdateDisplay(query, productions, stops);
            btnPrint.Enabled = true;            
        }

        private static IEnumerable<ProductionStop> GetProductionStops()
        {
            using (var factory = new RepositoryFactory())
            {
                return factory.CreateEntityRepository().LoadAll<ProductionStop>();
            }
        }

        private static IEnumerable<ProductionTeam> GetTeams()
        {
            using (var factory = new RepositoryFactory())
            {
                return factory.CreateEntityRepository().LoadAll<ProductionTeam>();
            }
        }

        private void OnClose(object sender, EventArgs e)
        {
            Close();
        }

        private void OnPrintDocument(object sender, PrintPageEventArgs e)
        {
            ucReport.PrintTo(e.Graphics, e.MarginBounds);
        }
        
        private void OnPrint(object sender, EventArgs e)
        {
            _printDocument.Print();
        }

        private void OnGenerate(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private static void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private static void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }

    }
}
