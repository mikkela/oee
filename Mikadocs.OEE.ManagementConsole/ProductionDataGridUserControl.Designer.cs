namespace Mikadocs.OEE.ManagementConsole
{
    partial class ProductionDataGridUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing)
                repository.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.centerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.productionDataGrid = new System.Windows.Forms.DataGridView();
            this.machineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producedItemsPerHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidatedItemsPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionLegDataGrid = new System.Windows.Forms.DataGridView();
            this.productionStartDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discardedItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionLegViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionLabel = new System.Windows.Forms.Label();
            this.productionLegLabel = new System.Windows.Forms.Label();
            this.productionStopRegistrationLabel = new System.Windows.Forms.Label();
            this.productionStopRegistrationGridView = new System.Windows.Forms.DataGridView();
            this.productionStopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productionStopViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionStopRegistrationViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.productionShiftDataGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionShiftViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblPeriodStart = new System.Windows.Forms.Label();
            this.lblPeriodEnd = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.dtPeriodStart = new System.Windows.Forms.DateTimePicker();
            this.dtPeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.cbMachine = new System.Windows.Forms.ComboBox();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionViewEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionLegDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionLegViewEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopRegistrationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopViewEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopRegistrationViewEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionShiftDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionShiftViewEntityBindingSource)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // centerPanel
            // 
            this.centerPanel.ColumnCount = 1;
            this.centerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerPanel.Controls.Add(this.productionDataGrid, 0, 2);
            this.centerPanel.Controls.Add(this.productionLegDataGrid, 0, 6);
            this.centerPanel.Controls.Add(this.productionLabel, 0, 1);
            this.centerPanel.Controls.Add(this.productionLegLabel, 0, 5);
            this.centerPanel.Controls.Add(this.productionStopRegistrationLabel, 0, 7);
            this.centerPanel.Controls.Add(this.productionStopRegistrationGridView, 0, 8);
            this.centerPanel.Controls.Add(this.label1, 0, 3);
            this.centerPanel.Controls.Add(this.productionShiftDataGrid, 0, 4);
            this.centerPanel.Controls.Add(this.filterPanel, 0, 0);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.RowCount = 9;
            this.centerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.centerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.centerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.centerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.centerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.centerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.centerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.centerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.centerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.centerPanel.Size = new System.Drawing.Size(677, 542);
            this.centerPanel.TabIndex = 1;
            // 
            // productionDataGrid
            // 
            this.productionDataGrid.AllowUserToAddRows = false;
            this.productionDataGrid.AllowUserToDeleteRows = false;
            this.productionDataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productionDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.orderDataGridViewTextBoxColumn,
            this.expectedItemsDataGridViewTextBoxColumn,
            this.producedItemsPerHourDataGridViewTextBoxColumn,
            this.ValidatedItemsPerHour,
            this.productionStartDataGridViewTextBoxColumn});
            this.productionDataGrid.DataSource = this.productionViewEntityBindingSource;
            this.productionDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionDataGrid.Location = new System.Drawing.Point(3, 101);
            this.productionDataGrid.MultiSelect = false;
            this.productionDataGrid.Name = "productionDataGrid";
            this.productionDataGrid.Size = new System.Drawing.Size(671, 90);
            this.productionDataGrid.TabIndex = 0;
            this.productionDataGrid.SelectionChanged += new System.EventHandler(this.OnProductionSelectionChanged);
            // 
            // machineDataGridViewTextBoxColumn
            // 
            this.machineDataGridViewTextBoxColumn.DataPropertyName = "Machine";
            this.machineDataGridViewTextBoxColumn.HeaderText = "Maskine";
            this.machineDataGridViewTextBoxColumn.Name = "machineDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Produkt";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Ordre";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            // 
            // expectedItemsDataGridViewTextBoxColumn
            // 
            this.expectedItemsDataGridViewTextBoxColumn.DataPropertyName = "ExpectedItems";
            this.expectedItemsDataGridViewTextBoxColumn.HeaderText = "Planlagt Antal";
            this.expectedItemsDataGridViewTextBoxColumn.Name = "expectedItemsDataGridViewTextBoxColumn";
            // 
            // producedItemsPerHourDataGridViewTextBoxColumn
            // 
            this.producedItemsPerHourDataGridViewTextBoxColumn.DataPropertyName = "ProducedItemsPerHour";
            this.producedItemsPerHourDataGridViewTextBoxColumn.HeaderText = "Antal pr. time";
            this.producedItemsPerHourDataGridViewTextBoxColumn.Name = "producedItemsPerHourDataGridViewTextBoxColumn";
            this.producedItemsPerHourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ValidatedItemsPerHour
            // 
            this.ValidatedItemsPerHour.DataPropertyName = "ValidatedItemsPerHour";
            this.ValidatedItemsPerHour.HeaderText = "Valideret antal pr. time";
            this.ValidatedItemsPerHour.Name = "ValidatedItemsPerHour";
            // 
            // productionStartDataGridViewTextBoxColumn
            // 
            this.productionStartDataGridViewTextBoxColumn.DataPropertyName = "ProductionStart";
            this.productionStartDataGridViewTextBoxColumn.HeaderText = "Start";
            this.productionStartDataGridViewTextBoxColumn.Name = "productionStartDataGridViewTextBoxColumn";
            this.productionStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionViewEntityBindingSource
            // 
            this.productionViewEntityBindingSource.DataSource = typeof(Mikadocs.OEE.ManagementConsole.ProductionViewEntity);
            // 
            // productionLegDataGrid
            // 
            this.productionLegDataGrid.AllowUserToAddRows = false;
            this.productionLegDataGrid.AllowUserToDeleteRows = false;
            this.productionLegDataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productionLegDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productionLegDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionLegDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productionStartDataGridViewTextBoxColumn1,
            this.productionEndDataGridViewTextBoxColumn,
            this.counterStartDataGridViewTextBoxColumn,
            this.counterEndDataGridViewTextBoxColumn,
            this.discardedItemsDataGridViewTextBoxColumn});
            this.productionLegDataGrid.DataSource = this.productionLegViewEntityBindingSource;
            this.productionLegDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionLegDataGrid.Location = new System.Drawing.Point(3, 333);
            this.productionLegDataGrid.Name = "productionLegDataGrid";
            this.productionLegDataGrid.Size = new System.Drawing.Size(671, 90);
            this.productionLegDataGrid.TabIndex = 1;
            this.productionLegDataGrid.SelectionChanged += new System.EventHandler(this.OnProductionLegSelectionChanged);
            // 
            // productionStartDataGridViewTextBoxColumn1
            // 
            this.productionStartDataGridViewTextBoxColumn1.DataPropertyName = "ProductionStart";
            this.productionStartDataGridViewTextBoxColumn1.HeaderText = "Start";
            this.productionStartDataGridViewTextBoxColumn1.Name = "productionStartDataGridViewTextBoxColumn1";
            // 
            // productionEndDataGridViewTextBoxColumn
            // 
            this.productionEndDataGridViewTextBoxColumn.DataPropertyName = "ProductionEnd";
            this.productionEndDataGridViewTextBoxColumn.HeaderText = "Slut";
            this.productionEndDataGridViewTextBoxColumn.Name = "productionEndDataGridViewTextBoxColumn";
            // 
            // counterStartDataGridViewTextBoxColumn
            // 
            this.counterStartDataGridViewTextBoxColumn.DataPropertyName = "CounterStart";
            this.counterStartDataGridViewTextBoxColumn.HeaderText = "Tæller Start";
            this.counterStartDataGridViewTextBoxColumn.Name = "counterStartDataGridViewTextBoxColumn";
            // 
            // counterEndDataGridViewTextBoxColumn
            // 
            this.counterEndDataGridViewTextBoxColumn.DataPropertyName = "CounterEnd";
            this.counterEndDataGridViewTextBoxColumn.HeaderText = "Tæller Slut";
            this.counterEndDataGridViewTextBoxColumn.Name = "counterEndDataGridViewTextBoxColumn";
            // 
            // discardedItemsDataGridViewTextBoxColumn
            // 
            this.discardedItemsDataGridViewTextBoxColumn.DataPropertyName = "DiscardedItems";
            this.discardedItemsDataGridViewTextBoxColumn.HeaderText = "Kasseret Antal";
            this.discardedItemsDataGridViewTextBoxColumn.Name = "discardedItemsDataGridViewTextBoxColumn";
            // 
            // productionLegViewEntityBindingSource
            // 
            this.productionLegViewEntityBindingSource.DataSource = typeof(Mikadocs.OEE.ManagementConsole.ProductionLegViewEntity);
            // 
            // productionLabel
            // 
            this.productionLabel.BackColor = System.Drawing.Color.White;
            this.productionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.productionLabel.Location = new System.Drawing.Point(3, 75);
            this.productionLabel.Name = "productionLabel";
            this.productionLabel.Size = new System.Drawing.Size(671, 23);
            this.productionLabel.TabIndex = 2;
            this.productionLabel.Text = ":Production";
            // 
            // productionLegLabel
            // 
            this.productionLegLabel.AutoSize = true;
            this.productionLegLabel.BackColor = System.Drawing.Color.White;
            this.productionLegLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionLegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.productionLegLabel.Location = new System.Drawing.Point(3, 310);
            this.productionLegLabel.Name = "productionLegLabel";
            this.productionLegLabel.Size = new System.Drawing.Size(671, 20);
            this.productionLegLabel.TabIndex = 3;
            this.productionLegLabel.Text = "Intervaller";
            // 
            // productionStopRegistrationLabel
            // 
            this.productionStopRegistrationLabel.AutoSize = true;
            this.productionStopRegistrationLabel.BackColor = System.Drawing.Color.White;
            this.productionStopRegistrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionStopRegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.productionStopRegistrationLabel.Location = new System.Drawing.Point(3, 426);
            this.productionStopRegistrationLabel.Name = "productionStopRegistrationLabel";
            this.productionStopRegistrationLabel.Size = new System.Drawing.Size(671, 20);
            this.productionStopRegistrationLabel.TabIndex = 4;
            this.productionStopRegistrationLabel.Text = ":ProductionStop";
            // 
            // productionStopRegistrationGridView
            // 
            this.productionStopRegistrationGridView.AllowUserToAddRows = false;
            this.productionStopRegistrationGridView.AllowUserToDeleteRows = false;
            this.productionStopRegistrationGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productionStopRegistrationGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productionStopRegistrationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionStopRegistrationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productionStopDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.productionStopRegistrationGridView.DataSource = this.productionStopRegistrationViewEntityBindingSource;
            this.productionStopRegistrationGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionStopRegistrationGridView.Location = new System.Drawing.Point(3, 449);
            this.productionStopRegistrationGridView.Name = "productionStopRegistrationGridView";
            this.productionStopRegistrationGridView.Size = new System.Drawing.Size(671, 90);
            this.productionStopRegistrationGridView.TabIndex = 5;
            // 
            // productionStopDataGridViewTextBoxColumn
            // 
            this.productionStopDataGridViewTextBoxColumn.DataPropertyName = "ProductionStop";
            this.productionStopDataGridViewTextBoxColumn.DataSource = this.productionStopViewEntityBindingSource;
            this.productionStopDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.productionStopDataGridViewTextBoxColumn.HeaderText = "Stop";
            this.productionStopDataGridViewTextBoxColumn.Name = "productionStopDataGridViewTextBoxColumn";
            this.productionStopDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productionStopDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productionStopDataGridViewTextBoxColumn.ValueMember = "Name";
            // 
            // productionStopViewEntityBindingSource
            // 
            this.productionStopViewEntityBindingSource.DataSource = typeof(Mikadocs.OEE.ManagementConsole.ProductionStopViewEntity);
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Varighed";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // productionStopRegistrationViewEntityBindingSource
            // 
            this.productionStopRegistrationViewEntityBindingSource.DataSource = typeof(Mikadocs.OEE.ManagementConsole.ProductionStopRegistrationViewEntity);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Skift";
            // 
            // productionShiftDataGrid
            // 
            this.productionShiftDataGrid.AllowUserToAddRows = false;
            this.productionShiftDataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productionShiftDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productionShiftDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionShiftDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.dataGridViewTextBoxColumn1});
            this.productionShiftDataGrid.DataSource = this.productionShiftViewEntityBindingSource;
            this.productionShiftDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionShiftDataGrid.Location = new System.Drawing.Point(3, 217);
            this.productionShiftDataGrid.Name = "productionShiftDataGrid";
            this.productionShiftDataGrid.Size = new System.Drawing.Size(671, 90);
            this.productionShiftDataGrid.TabIndex = 7;
            this.productionShiftDataGrid.SelectionChanged += new System.EventHandler(this.OnProductionShiftSelectionChanged);
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Dato";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn1.HeaderText = "Hold";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productionShiftViewEntityBindingSource
            // 
            this.productionShiftViewEntityBindingSource.AllowNew = false;
            this.productionShiftViewEntityBindingSource.DataSource = typeof(Mikadocs.OEE.ManagementConsole.ProductionShiftViewEntity);
            // 
            // filterPanel
            // 
            this.filterPanel.ColumnCount = 6;
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.filterPanel.Controls.Add(this.lblPeriodStart, 0, 0);
            this.filterPanel.Controls.Add(this.lblPeriodEnd, 0, 1);
            this.filterPanel.Controls.Add(this.lblOrder, 2, 0);
            this.filterPanel.Controls.Add(this.lblProduct, 2, 1);
            this.filterPanel.Controls.Add(this.lblMachine, 4, 0);
            this.filterPanel.Controls.Add(this.lblTeam, 4, 1);
            this.filterPanel.Controls.Add(this.dtPeriodStart, 1, 0);
            this.filterPanel.Controls.Add(this.dtPeriodEnd, 1, 1);
            this.filterPanel.Controls.Add(this.txtOrder, 3, 0);
            this.filterPanel.Controls.Add(this.txtProduct, 3, 1);
            this.filterPanel.Controls.Add(this.cbMachine, 5, 0);
            this.filterPanel.Controls.Add(this.cbTeam, 5, 1);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.filterPanel.Location = new System.Drawing.Point(3, 3);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.RowCount = 2;
            this.filterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filterPanel.Size = new System.Drawing.Size(671, 69);
            this.filterPanel.TabIndex = 8;
            // 
            // lblPeriodStart
            // 
            this.lblPeriodStart.AutoSize = true;
            this.lblPeriodStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPeriodStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPeriodStart.ForeColor = System.Drawing.Color.White;
            this.lblPeriodStart.Location = new System.Drawing.Point(3, 0);
            this.lblPeriodStart.Name = "lblPeriodStart";
            this.lblPeriodStart.Size = new System.Drawing.Size(105, 34);
            this.lblPeriodStart.TabIndex = 0;
            this.lblPeriodStart.Text = "PeriodStart";
            this.lblPeriodStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPeriodEnd
            // 
            this.lblPeriodEnd.AutoSize = true;
            this.lblPeriodEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPeriodEnd.ForeColor = System.Drawing.Color.White;
            this.lblPeriodEnd.Location = new System.Drawing.Point(3, 34);
            this.lblPeriodEnd.Name = "lblPeriodEnd";
            this.lblPeriodEnd.Size = new System.Drawing.Size(105, 35);
            this.lblPeriodEnd.TabIndex = 1;
            this.lblPeriodEnd.Text = "PeriodEnd";
            this.lblPeriodEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrder.ForeColor = System.Drawing.Color.White;
            this.lblOrder.Location = new System.Drawing.Point(225, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(105, 34);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Order";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(225, 34);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(105, 35);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMachine.ForeColor = System.Drawing.Color.White;
            this.lblMachine.Location = new System.Drawing.Point(447, 0);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(105, 34);
            this.lblMachine.TabIndex = 4;
            this.lblMachine.Text = "Machine";
            this.lblMachine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeam.ForeColor = System.Drawing.Color.White;
            this.lblTeam.Location = new System.Drawing.Point(447, 34);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(105, 35);
            this.lblTeam.TabIndex = 5;
            this.lblTeam.Text = "Team";
            this.lblTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtPeriodStart
            // 
            this.dtPeriodStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPeriodStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriodStart.Location = new System.Drawing.Point(114, 3);
            this.dtPeriodStart.Name = "dtPeriodStart";
            this.dtPeriodStart.Size = new System.Drawing.Size(105, 26);
            this.dtPeriodStart.TabIndex = 6;
            this.dtPeriodStart.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // dtPeriodEnd
            // 
            this.dtPeriodEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPeriodEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriodEnd.Location = new System.Drawing.Point(114, 37);
            this.dtPeriodEnd.Name = "dtPeriodEnd";
            this.dtPeriodEnd.Size = new System.Drawing.Size(105, 26);
            this.dtPeriodEnd.TabIndex = 7;
            this.dtPeriodEnd.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // txtOrder
            // 
            this.txtOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrder.Location = new System.Drawing.Point(336, 3);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(105, 26);
            this.txtOrder.TabIndex = 8;
            this.txtOrder.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // txtProduct
            // 
            this.txtProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProduct.Location = new System.Drawing.Point(336, 37);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(105, 26);
            this.txtProduct.TabIndex = 9;
            this.txtProduct.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // cbMachine
            // 
            this.cbMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMachine.FormattingEnabled = true;
            this.cbMachine.Location = new System.Drawing.Point(558, 3);
            this.cbMachine.Name = "cbMachine";
            this.cbMachine.Size = new System.Drawing.Size(110, 28);
            this.cbMachine.TabIndex = 10;
            this.cbMachine.SelectedValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // cbTeam
            // 
            this.cbTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(558, 37);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(110, 28);
            this.cbTeam.TabIndex = 11;
            this.cbTeam.SelectedValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // ProductionDataGridUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.centerPanel);
            this.Name = "ProductionDataGridUserControl";
            this.Size = new System.Drawing.Size(677, 542);
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionViewEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionLegDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionLegViewEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopRegistrationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopViewEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopRegistrationViewEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionShiftDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionShiftViewEntityBindingSource)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel centerPanel;
        private System.Windows.Forms.DataGridView productionDataGrid;
        private System.Windows.Forms.DataGridView productionLegDataGrid;
        private System.Windows.Forms.BindingSource productionViewEntityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionStartDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discardedItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productionLegViewEntityBindingSource;
        private System.Windows.Forms.Label productionLabel;
        private System.Windows.Forms.Label productionLegLabel;
        private System.Windows.Forms.Label productionStopRegistrationLabel;
        private System.Windows.Forms.DataGridView productionStopRegistrationGridView;
        private System.Windows.Forms.BindingSource productionStopRegistrationViewEntityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producedItemsPerHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidatedItemsPerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productionShiftViewEntityBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productionShiftDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource productionStopViewEntityBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn productionStopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel filterPanel;
        private System.Windows.Forms.Label lblPeriodStart;
        private System.Windows.Forms.Label lblPeriodEnd;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.DateTimePicker dtPeriodStart;
        private System.Windows.Forms.DateTimePicker dtPeriodEnd;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ComboBox cbMachine;
        private System.Windows.Forms.ComboBox cbTeam;
    }
}
