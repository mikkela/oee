using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

using Mikadocs.OEE.Repository;

namespace Mikadocs.OEE.DataEntry
{
    public partial class DataEntryForm : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private bool _started;
        private ProductionShift _currentShift;
        private RepositoryFactory _repositoryFactory;

        private IEnumerable<ProductionTeam> _availableTeams;
        private ProductionStatisticsValidator _currentValidator;
        private MachineConfiguration _machineConfiguration;

        private readonly PrintDocument _printDocument = new PrintDocument();

        public DataEntryForm()
        {
            InitializeComponent();

            LoadEntities();

            SetTexts();

            UpdateButtons();

            _printDocument.DefaultPageSettings.Landscape = true;
            _printDocument.DefaultPageSettings.Margins = new Margins(25, 25, 25, 25);
            _printDocument.PrintPage += OnPrintDocument;            
        }

        private void SetTexts()
        {
            txtHeader.Text = "";
            txtCopyright.Text = Strings.Copyright;
        }

        #region Event Handlers
        private void OnClose(object sender, EventArgs e)
        {
            Close();
        }
        
        private void OnNewProductionStop(object sender, EventArgs e)
        {
            AddProductionStop();
        }

        private void OnDataEntry(object sender, EventArgs e)
        {
            if (_currentShift != null)
            {
                StopDataEntry();               
            }
            else
            {
                StartDataEntry();                
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            CheckLicense();
            StartDataEntry();
        }

        private void OnPrintDocument(object sender, PrintPageEventArgs e)
        {
            PrintDocument(e.Graphics, e.MarginBounds);
        }

        private void OnPrint(object sender, EventArgs e)
        {
            _printDocument.Print();
        }

        private void OnMinimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private static void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private static void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }
        #endregion

        #region Helpers

        private void LoadEntities()
        {
            _repositoryFactory = new RepositoryFactory();

            _availableTeams = _repositoryFactory.CreateEntityRepository().LoadAll<ProductionTeam>();

            var machineConfigurations = _repositoryFactory.CreateEntityRepository().LoadAll<MachineConfiguration>();
            _machineConfiguration = machineConfigurations.Any()
                                        ? machineConfigurations.First()
                                        : new MachineConfiguration(Strings.UnknownMachine, new ProductionStop[0]);

        }

        private void StartDataEntry()
        {
            _currentShift = StartProductionShift();

            if (_currentShift == null)
            {
                if (!_started)
                    Application.Exit();
                return;
            }

            _started = true;
            LastOrder = _currentShift.Order;
            _currentValidator = new ProductionStatisticsValidator(_currentShift.CurrentLeg.ProductionStart, _currentShift.CurrentLeg.CounterStart, 0);
            UpdateHeader(_currentShift.Production);
            UpdateDisplay();
            
            UpdateButtons();
        }

        private void StopDataEntry()
        {
            if (!CloseProductionShift(_currentShift))
                return;
            UpdateDisplay();
            _currentShift = null;
            UpdateButtons();

        }

        private ProductionShift StartProductionShift()
        {
            using (var form = new StartForm(_availableTeams, LastOrder))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ProductionShift shift = FindExistingProductionShift(form.Order, form.Team, form.Date);

                    if (shift != null)
                        return shift;

                    return CreateNewProductionShift(form.Order, form.Team, form.Date);
                }
            }

            return null;
        }

        private ProductionShift FindExistingProductionShift(OrderNumber order, ProductionTeam team, DateTime date)
        {
            Production p = _repositoryFactory.CreateProductionQueryRepository(true).LoadProduction(order);
            return p == null
                       ? null
                       : p.Shifts.FirstOrDefault(shift => shift.Team.Equals(team) && shift.ProductionStart.Equals(date));
        }

        private ProductionShift CreateNewProductionShift(OrderNumber order, ProductionTeam team, DateTime date)
        {
            Production p = _repositoryFactory.CreateProductionQueryRepository(true).LoadProduction(order);

            using (var form = new StartShiftForm(p, date))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (p == null)
                    {
                        p =
                            SaveProduction(new Production(form.Machine, form.Product, order, form.ExpectedItems,
                                                          form.ProducedItemsPerHour, form.ValidatedSetupTime));

                        if (p == null)
                            return null;

                    }

                    SaveProduction(p);
                    var shift = p.AddProductionShift(team, form.StartTime.Date);
                    SaveShift(shift);
                    var leg = shift.AddProductionLeg(form.StartTime, form.StartCounter);
                    SaveLeg(leg);
                    SaveShift(shift);
                    SaveProduction(p);

                    return shift;
                }

                return null;
            }
        }

        private Production SaveProduction(Production p)
        {
            try
            {
                Save(p);
                return p;
            }
            catch (Exception ex)
            {
                Log.Error("An exception were caught while saving production.", ex);
                MessageForm.ShowMessage(Strings.ExceptionCaught, Strings.CouldNotCreateNewProduction);
            }

            return null;
        }

        private void SaveShift(ProductionShift shift)
        {
            try
            {
                Save(shift);                                         
            }
            catch (Exception ex)
            {
                Log.Error("An exception were caught while saving a shift.", ex);
                MessageForm.ShowMessage(Strings.ExceptionCaught, Strings.CouldNotAddProductionShift);
            }
        }

        private void SaveLeg(ProductionLeg leg)
        {
            try
            {
                Save(leg);
            }
            catch (Exception ex)
            {
                Log.Error("An exception were caught while saving a leg.", ex);
                MessageForm.ShowMessage(Strings.ExceptionCaught, Strings.CouldNotAddProductionShift);
            }
        }

        private void Save(EntityObject o)
        {
            var repository = _repositoryFactory.CreateEntityRepository();
            repository.Save(o);            
        }

        private bool CloseProductionShift(ProductionShift shift)
        {
            using (var form = new StatisticsDetailsForm(_currentValidator))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (shift != null)
                    {
                        if (form.UpdateTime > shift.ProductionStart.Add(Settings.Default.MaximumLegLength))
                        {
                            if (
                                QuestionForm.ShowQuestion(Strings.ProductionShiftWarning,
                                                          string.Format(Strings.ProductionLengthIsLong,
                                                                        Math.Floor(
                                                                            (form.UpdateTime - shift.ProductionStart).
                                                                                TotalHours))) == DialogResult.Cancel)
                            {
                                return false;
                            }
                        }
                        try
                        {
                            shift.CurrentLeg.UpdateStatistics(form.UpdateTime, form.ProductionCounter,
                                                              form.DiscardedItems);
                            SaveLeg(shift.CurrentLeg);
                            SaveShift(_currentShift);
                            _currentValidator = new ProductionStatisticsValidator(form.UpdateTime,
                                                                                  form.ProductionCounter,
                                                                                  form.DiscardedItems);
                            return true;
                        }
                        catch (Exception ex)
                        {
                            Log.Error("An exception were caught while updating production counters.", ex);
                            MessageForm.ShowMessage(Strings.ExceptionCaught, Strings.CouldNotUpdateProductionCounters);
                        }
                    }
                }
            }
            return false;
        }
        
        private void AddProductionStop()
        {
            using (var form = new NewProductionStopRegistrationForm(_currentShift.CurrentLeg, _machineConfiguration.AvailableProductionStops))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _currentShift.CurrentLeg.AddProductionStopRegistration(form.ProductionStopRegistration);
                        SaveShift(_currentShift);
                    }
                    catch (Exception ex)
                    {
                        Log.Error("An exception were caught while adding production stop.", ex);
                        MessageForm.ShowMessage(Strings.ExceptionCaught, Strings.CouldNotAddProductionStop);
                    }
                }
            }

            UpdateDisplay();
        }
        
        private void UpdateDisplay()
        {
            ucDisplay.UpdateDisplay(_currentShift, _currentShift.Production, _machineConfiguration.AvailableProductionStops);            
        }

        private void UpdateButtons()
        {
            btnAddStop.Enabled = (_currentShift != null && _currentShift.CurrentLeg != null);
            btnClose.Enabled = (_currentShift == null);
            if (_currentShift == null || _currentShift.CurrentLeg == null)
                toolTip.SetToolTip(btnDataEntry, "Ny opsamling");
            else
                toolTip.SetToolTip(btnDataEntry, "Stop opsamling");
        }

        private void UpdateHeader(Production p)
        {
            txtHeader.Text = string.Format(Strings.DataEntryHeader, p.Machine, p.Product.Number, p.Order.Number);
        }

        private void PrintDocument(Graphics g, Rectangle bounds)
        {
            ucDisplay.PrintTo(g, bounds);            
        }

        private static OrderNumber LastOrder
        {
            get { return new OrderNumber(Settings.Default.ProductionId);}
            set
            {
                Settings.Default.ProductionId = value.Number;
                Settings.Default.Save();
            }
        }
        #endregion                                

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckLicense();
        }

        private void CheckLicense()
        {
            var licenseManager = new Security.LicenseManager();
            licenseManager.RetreiveLicense(p => this.BeginInvoke(new HandleLicenseDelegate(HandleLicense), p));
        }

        private delegate void HandleLicenseDelegate(Security.License license);
        private void HandleLicense(Security.License license)
        {
            if (license.ExpireAt < DateTime.Now)
            {
                Close();
                return;
            }

            if (license.Warn)
            {
                MessageBox.Show(this,
                                "Denne applikation vil ophøre med at virke fra: " + license.ExpireAt.ToShortDateString());
            }

        }
    }
}
