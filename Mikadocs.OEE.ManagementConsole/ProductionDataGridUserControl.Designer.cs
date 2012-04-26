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
            this.ValidatedItemsPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionLegDataGrid = new System.Windows.Forms.DataGridView();
            this.productionLabel = new System.Windows.Forms.Label();
            this.productionLegLabel = new System.Windows.Forms.Label();
            this.productionStopRegistrationLabel = new System.Windows.Forms.Label();
            this.productionStopRegistrationGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.productionShiftDataGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producedItemsPerHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionStartDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discardedItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionLegViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionStopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productionStopViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionStopRegistrationViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionShiftViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionLegDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopRegistrationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionShiftDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionViewEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionLegViewEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopViewEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopRegistrationViewEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionShiftViewEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // centerPanel
            // 
            this.centerPanel.ColumnCount = 1;
            this.centerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerPanel.Controls.Add(this.productionDataGrid, 0, 1);
            this.centerPanel.Controls.Add(this.productionLegDataGrid, 0, 5);
            this.centerPanel.Controls.Add(this.productionLabel, 0, 0);
            this.centerPanel.Controls.Add(this.productionLegLabel, 0, 4);
            this.centerPanel.Controls.Add(this.productionStopRegistrationLabel, 0, 6);
            this.centerPanel.Controls.Add(this.productionStopRegistrationGridView, 0, 7);
            this.centerPanel.Controls.Add(this.label1, 0, 2);
            this.centerPanel.Controls.Add(this.productionShiftDataGrid, 0, 3);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.RowCount = 8;
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
            this.productionDataGrid.Location = new System.Drawing.Point(3, 26);
            this.productionDataGrid.MultiSelect = false;
            this.productionDataGrid.Name = "productionDataGrid";
            this.productionDataGrid.Size = new System.Drawing.Size(671, 108);
            this.productionDataGrid.TabIndex = 0;
            this.productionDataGrid.SelectionChanged += new System.EventHandler(this.OnProductionSelectionChanged);
            // 
            // ValidatedItemsPerHour
            // 
            this.ValidatedItemsPerHour.DataPropertyName = "ValidatedItemsPerHour";
            this.ValidatedItemsPerHour.HeaderText = "Valideret antal pr. time";
            this.ValidatedItemsPerHour.Name = "ValidatedItemsPerHour";
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
            this.productionLegDataGrid.Location = new System.Drawing.Point(3, 294);
            this.productionLegDataGrid.Name = "productionLegDataGrid";
            this.productionLegDataGrid.Size = new System.Drawing.Size(671, 108);
            this.productionLegDataGrid.TabIndex = 1;
            this.productionLegDataGrid.SelectionChanged += new System.EventHandler(this.OnProductionLegSelectionChanged);
            // 
            // productionLabel
            // 
            this.productionLabel.BackColor = System.Drawing.Color.White;
            this.productionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.productionLabel.Location = new System.Drawing.Point(3, 0);
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
            this.productionLegLabel.Location = new System.Drawing.Point(3, 271);
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
            this.productionStopRegistrationLabel.Location = new System.Drawing.Point(3, 405);
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
            this.productionStopRegistrationGridView.Location = new System.Drawing.Point(3, 428);
            this.productionStopRegistrationGridView.Name = "productionStopRegistrationGridView";
            this.productionStopRegistrationGridView.Size = new System.Drawing.Size(671, 111);
            this.productionStopRegistrationGridView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 137);
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
            this.productionShiftDataGrid.Location = new System.Drawing.Point(3, 160);
            this.productionShiftDataGrid.Name = "productionShiftDataGrid";
            this.productionShiftDataGrid.Size = new System.Drawing.Size(671, 108);
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
            ((System.ComponentModel.ISupportInitialize)(this.productionLegDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopRegistrationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionShiftDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionViewEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionLegViewEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopViewEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopRegistrationViewEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionShiftViewEntityBindingSource)).EndInit();
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
    }
}
