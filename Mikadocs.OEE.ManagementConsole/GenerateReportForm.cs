using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
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
            _printDocument.DefaultPageSettings.Margins = new Margins(25, 25, 25, 25);
            productionFilterUserControl1.Initialize(Settings.Default.Machines.Cast<string>().ToList(), GetTeams());
            
            SetTexts();            
        }

        private void SetTexts()
        {
            txtHeader.Text = Strings.Header;            
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
                    var query = productionFilterUserControl1.Query;

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
            return ProductionStopRepository.ProductionStops;
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
