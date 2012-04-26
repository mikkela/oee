namespace Mikadocs.OEE.ManagementConsole
{
    partial class ReportControl
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
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.oeeDetailsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.orderNumberValueLabel = new System.Windows.Forms.Label();
            this.machineLabel = new System.Windows.Forms.Label();
            this.machineValueLabel = new System.Windows.Forms.Label();
            this.periodStartLabel = new System.Windows.Forms.Label();
            this.periodStartValueLabel = new System.Windows.Forms.Label();
            this.periodEndLabel = new System.Windows.Forms.Label();
            this.periodEndValueLabel = new System.Windows.Forms.Label();
            this.productNumberLabel = new System.Windows.Forms.Label();
            this.productNumberValueLabel = new System.Windows.Forms.Label();
            this.producedPrHourLabel = new System.Windows.Forms.Label();
            this.producedPrHourValueLabel = new System.Windows.Forms.Label();
            this.producedItemsLabel = new System.Windows.Forms.Label();
            this.producedItemsValueLabel = new System.Windows.Forms.Label();
            this.discardedItemsLabel = new System.Windows.Forms.Label();
            this.discardedItemsValueLabel = new System.Windows.Forms.Label();
            this.availabilityLabel = new System.Windows.Forms.Label();
            this.availabilityValueLabel = new System.Windows.Forms.Label();
            this.performanceLabel = new System.Windows.Forms.Label();
            this.performanceValueLabel = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.qualityValueLabel = new System.Windows.Forms.Label();
            this.overallOEELabel = new System.Windows.Forms.Label();
            this.oeeOverallValueLabel = new System.Windows.Forms.Label();
            this.validatedPrHourLabel = new System.Windows.Forms.Label();
            this.validatedPrHourValueLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationValueLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.oeeDetailsPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.BorderlineColor = System.Drawing.Color.Black;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart.BorderlineWidth = 2;
            chartArea3.Area3DStyle.Inclination = 15;
            chartArea3.Area3DStyle.IsClustered = true;
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.Perspective = 10;
            chartArea3.Area3DStyle.Rotation = 10;
            chartArea3.Area3DStyle.WallWidth = 0;
            chartArea3.AxisX.Interval = 1;
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.BackColor = System.Drawing.Color.OldLace;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.Name = "Default";
            chartArea3.ShadowColor = System.Drawing.Color.Transparent;
            this.chart.ChartAreas.Add(chartArea3);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(0, 150);
            this.chart.Name = "chart";
            series7.ChartArea = "Default";
            series7.Legend = "Legend";
            series7.Name = "Validated";
            series8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series8.ChartArea = "Default";
            series8.Legend = "Legend";
            series8.Name = "Minutes";
            series9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series9.ChartArea = "Default";
            series9.IsXValueIndexed = true;
            series9.Legend = "Legend";
            series9.Name = "Instances";
            this.chart.Series.Add(series7);
            this.chart.Series.Add(series8);
            this.chart.Series.Add(series9);
            this.chart.Size = new System.Drawing.Size(835, 553);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // oeeDetailsPanel
            // 
            this.oeeDetailsPanel.ColumnCount = 4;
            this.oeeDetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.oeeDetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.oeeDetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.oeeDetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.oeeDetailsPanel.Controls.Add(this.orderNumberLabel, 0, 1);
            this.oeeDetailsPanel.Controls.Add(this.orderNumberValueLabel, 1, 1);
            this.oeeDetailsPanel.Controls.Add(this.machineLabel, 2, 1);
            this.oeeDetailsPanel.Controls.Add(this.machineValueLabel, 3, 1);
            this.oeeDetailsPanel.Controls.Add(this.periodStartLabel, 0, 2);
            this.oeeDetailsPanel.Controls.Add(this.periodStartValueLabel, 1, 2);
            this.oeeDetailsPanel.Controls.Add(this.periodEndLabel, 2, 2);
            this.oeeDetailsPanel.Controls.Add(this.periodEndValueLabel, 3, 2);
            this.oeeDetailsPanel.Controls.Add(this.productNumberLabel, 0, 3);
            this.oeeDetailsPanel.Controls.Add(this.productNumberValueLabel, 1, 3);
            this.oeeDetailsPanel.Controls.Add(this.producedPrHourLabel, 0, 4);
            this.oeeDetailsPanel.Controls.Add(this.producedPrHourValueLabel, 1, 4);
            this.oeeDetailsPanel.Controls.Add(this.producedItemsLabel, 0, 5);
            this.oeeDetailsPanel.Controls.Add(this.producedItemsValueLabel, 1, 5);
            this.oeeDetailsPanel.Controls.Add(this.discardedItemsLabel, 2, 5);
            this.oeeDetailsPanel.Controls.Add(this.discardedItemsValueLabel, 3, 5);
            this.oeeDetailsPanel.Controls.Add(this.availabilityLabel, 0, 6);
            this.oeeDetailsPanel.Controls.Add(this.availabilityValueLabel, 1, 6);
            this.oeeDetailsPanel.Controls.Add(this.performanceLabel, 2, 6);
            this.oeeDetailsPanel.Controls.Add(this.performanceValueLabel, 3, 6);
            this.oeeDetailsPanel.Controls.Add(this.qualityLabel, 0, 7);
            this.oeeDetailsPanel.Controls.Add(this.qualityValueLabel, 1, 7);
            this.oeeDetailsPanel.Controls.Add(this.overallOEELabel, 2, 7);
            this.oeeDetailsPanel.Controls.Add(this.oeeOverallValueLabel, 3, 7);
            this.oeeDetailsPanel.Controls.Add(this.validatedPrHourLabel, 2, 4);
            this.oeeDetailsPanel.Controls.Add(this.validatedPrHourValueLabel, 3, 4);
            this.oeeDetailsPanel.Controls.Add(this.durationLabel, 2, 3);
            this.oeeDetailsPanel.Controls.Add(this.durationValueLabel, 3, 3);
            this.oeeDetailsPanel.Controls.Add(this.label1, 0, 0);
            this.oeeDetailsPanel.Controls.Add(this.label2, 1, 0);
            this.oeeDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oeeDetailsPanel.Location = new System.Drawing.Point(3, 3);
            this.oeeDetailsPanel.Name = "oeeDetailsPanel";
            this.oeeDetailsPanel.RowCount = 8;
            this.oeeDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.oeeDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.oeeDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.oeeDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.oeeDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.oeeDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.oeeDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.oeeDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.oeeDetailsPanel.Size = new System.Drawing.Size(829, 144);
            this.oeeDetailsPanel.TabIndex = 0;
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.orderNumberLabel.Location = new System.Drawing.Point(3, 17);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(201, 17);
            this.orderNumberLabel.TabIndex = 0;
            this.orderNumberLabel.Text = "Ordre";
            this.orderNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderNumberValueLabel
            // 
            this.orderNumberValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderNumberValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.orderNumberValueLabel.Location = new System.Drawing.Point(210, 17);
            this.orderNumberValueLabel.Name = "orderNumberValueLabel";
            this.orderNumberValueLabel.Size = new System.Drawing.Size(201, 17);
            this.orderNumberValueLabel.TabIndex = 1;
            this.orderNumberValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // machineLabel
            // 
            this.machineLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.machineLabel.Location = new System.Drawing.Point(417, 17);
            this.machineLabel.Name = "machineLabel";
            this.machineLabel.Size = new System.Drawing.Size(201, 17);
            this.machineLabel.TabIndex = 2;
            this.machineLabel.Text = "Maskine";
            this.machineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // machineValueLabel
            // 
            this.machineValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.machineValueLabel.Location = new System.Drawing.Point(624, 17);
            this.machineValueLabel.Name = "machineValueLabel";
            this.machineValueLabel.Size = new System.Drawing.Size(202, 17);
            this.machineValueLabel.TabIndex = 3;
            this.machineValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // periodStartLabel
            // 
            this.periodStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.periodStartLabel.Location = new System.Drawing.Point(3, 34);
            this.periodStartLabel.Name = "periodStartLabel";
            this.periodStartLabel.Size = new System.Drawing.Size(201, 17);
            this.periodStartLabel.TabIndex = 4;
            this.periodStartLabel.Text = "Start";
            // 
            // periodStartValueLabel
            // 
            this.periodStartValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodStartValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.periodStartValueLabel.Location = new System.Drawing.Point(210, 34);
            this.periodStartValueLabel.Name = "periodStartValueLabel";
            this.periodStartValueLabel.Size = new System.Drawing.Size(201, 17);
            this.periodStartValueLabel.TabIndex = 5;
            this.periodStartValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // periodEndLabel
            // 
            this.periodEndLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.periodEndLabel.Location = new System.Drawing.Point(417, 34);
            this.periodEndLabel.Name = "periodEndLabel";
            this.periodEndLabel.Size = new System.Drawing.Size(201, 17);
            this.periodEndLabel.TabIndex = 6;
            this.periodEndLabel.Text = "Slut";
            this.periodEndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // periodEndValueLabel
            // 
            this.periodEndValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodEndValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.periodEndValueLabel.Location = new System.Drawing.Point(624, 34);
            this.periodEndValueLabel.Name = "periodEndValueLabel";
            this.periodEndValueLabel.Size = new System.Drawing.Size(202, 17);
            this.periodEndValueLabel.TabIndex = 7;
            this.periodEndValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNumberLabel
            // 
            this.productNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.productNumberLabel.Location = new System.Drawing.Point(3, 51);
            this.productNumberLabel.Name = "productNumberLabel";
            this.productNumberLabel.Size = new System.Drawing.Size(201, 17);
            this.productNumberLabel.TabIndex = 8;
            this.productNumberLabel.Text = "Emne";
            this.productNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNumberValueLabel
            // 
            this.productNumberValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productNumberValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.productNumberValueLabel.Location = new System.Drawing.Point(210, 51);
            this.productNumberValueLabel.Name = "productNumberValueLabel";
            this.productNumberValueLabel.Size = new System.Drawing.Size(201, 17);
            this.productNumberValueLabel.TabIndex = 9;
            this.productNumberValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // producedPrHourLabel
            // 
            this.producedPrHourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.producedPrHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.producedPrHourLabel.Location = new System.Drawing.Point(3, 68);
            this.producedPrHourLabel.Name = "producedPrHourLabel";
            this.producedPrHourLabel.Size = new System.Drawing.Size(201, 17);
            this.producedPrHourLabel.TabIndex = 10;
            this.producedPrHourLabel.Text = "Antal pr time";
            this.producedPrHourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // producedPrHourValueLabel
            // 
            this.producedPrHourValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.producedPrHourValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.producedPrHourValueLabel.Location = new System.Drawing.Point(210, 68);
            this.producedPrHourValueLabel.Name = "producedPrHourValueLabel";
            this.producedPrHourValueLabel.Size = new System.Drawing.Size(201, 17);
            this.producedPrHourValueLabel.TabIndex = 11;
            this.producedPrHourValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // producedItemsLabel
            // 
            this.producedItemsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.producedItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.producedItemsLabel.Location = new System.Drawing.Point(3, 85);
            this.producedItemsLabel.Name = "producedItemsLabel";
            this.producedItemsLabel.Size = new System.Drawing.Size(201, 18);
            this.producedItemsLabel.TabIndex = 0;
            this.producedItemsLabel.Text = ":Produced";
            this.producedItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // producedItemsValueLabel
            // 
            this.producedItemsValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.producedItemsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.producedItemsValueLabel.Location = new System.Drawing.Point(210, 85);
            this.producedItemsValueLabel.Name = "producedItemsValueLabel";
            this.producedItemsValueLabel.Size = new System.Drawing.Size(201, 18);
            this.producedItemsValueLabel.TabIndex = 1;
            this.producedItemsValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discardedItemsLabel
            // 
            this.discardedItemsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discardedItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.discardedItemsLabel.Location = new System.Drawing.Point(417, 85);
            this.discardedItemsLabel.Name = "discardedItemsLabel";
            this.discardedItemsLabel.Size = new System.Drawing.Size(201, 18);
            this.discardedItemsLabel.TabIndex = 2;
            this.discardedItemsLabel.Text = ":Discarded";
            this.discardedItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discardedItemsValueLabel
            // 
            this.discardedItemsValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discardedItemsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.discardedItemsValueLabel.Location = new System.Drawing.Point(624, 85);
            this.discardedItemsValueLabel.Name = "discardedItemsValueLabel";
            this.discardedItemsValueLabel.Size = new System.Drawing.Size(202, 18);
            this.discardedItemsValueLabel.TabIndex = 3;
            this.discardedItemsValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // availabilityLabel
            // 
            this.availabilityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.availabilityLabel.Location = new System.Drawing.Point(3, 103);
            this.availabilityLabel.Name = "availabilityLabel";
            this.availabilityLabel.Size = new System.Drawing.Size(201, 18);
            this.availabilityLabel.TabIndex = 4;
            this.availabilityLabel.Text = ":Availability";
            this.availabilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // availabilityValueLabel
            // 
            this.availabilityValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availabilityValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.availabilityValueLabel.Location = new System.Drawing.Point(210, 103);
            this.availabilityValueLabel.Name = "availabilityValueLabel";
            this.availabilityValueLabel.Size = new System.Drawing.Size(201, 18);
            this.availabilityValueLabel.TabIndex = 5;
            this.availabilityValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // performanceLabel
            // 
            this.performanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.performanceLabel.Location = new System.Drawing.Point(417, 103);
            this.performanceLabel.Name = "performanceLabel";
            this.performanceLabel.Size = new System.Drawing.Size(201, 18);
            this.performanceLabel.TabIndex = 6;
            this.performanceLabel.Text = ":Performance";
            this.performanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // performanceValueLabel
            // 
            this.performanceValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performanceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.performanceValueLabel.Location = new System.Drawing.Point(624, 103);
            this.performanceValueLabel.Name = "performanceValueLabel";
            this.performanceValueLabel.Size = new System.Drawing.Size(202, 18);
            this.performanceValueLabel.TabIndex = 7;
            this.performanceValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // qualityLabel
            // 
            this.qualityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.qualityLabel.Location = new System.Drawing.Point(3, 121);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(201, 23);
            this.qualityLabel.TabIndex = 8;
            this.qualityLabel.Text = ":Quality";
            this.qualityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // qualityValueLabel
            // 
            this.qualityValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qualityValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.qualityValueLabel.Location = new System.Drawing.Point(210, 121);
            this.qualityValueLabel.Name = "qualityValueLabel";
            this.qualityValueLabel.Size = new System.Drawing.Size(201, 23);
            this.qualityValueLabel.TabIndex = 9;
            this.qualityValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // overallOEELabel
            // 
            this.overallOEELabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overallOEELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.overallOEELabel.Location = new System.Drawing.Point(417, 121);
            this.overallOEELabel.Name = "overallOEELabel";
            this.overallOEELabel.Size = new System.Drawing.Size(201, 23);
            this.overallOEELabel.TabIndex = 10;
            this.overallOEELabel.Text = ":OEEOverall";
            this.overallOEELabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // oeeOverallValueLabel
            // 
            this.oeeOverallValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oeeOverallValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.oeeOverallValueLabel.Location = new System.Drawing.Point(624, 121);
            this.oeeOverallValueLabel.Name = "oeeOverallValueLabel";
            this.oeeOverallValueLabel.Size = new System.Drawing.Size(202, 23);
            this.oeeOverallValueLabel.TabIndex = 11;
            this.oeeOverallValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // validatedPrHourLabel
            // 
            this.validatedPrHourLabel.AutoSize = true;
            this.validatedPrHourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.validatedPrHourLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.validatedPrHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.validatedPrHourLabel.Location = new System.Drawing.Point(417, 68);
            this.validatedPrHourLabel.Name = "validatedPrHourLabel";
            this.validatedPrHourLabel.Size = new System.Drawing.Size(201, 17);
            this.validatedPrHourLabel.TabIndex = 12;
            this.validatedPrHourLabel.Text = " :Validated Number";
            this.validatedPrHourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // validatedPrHourValueLabel
            // 
            this.validatedPrHourValueLabel.AutoSize = true;
            this.validatedPrHourValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.validatedPrHourValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.validatedPrHourValueLabel.Location = new System.Drawing.Point(624, 68);
            this.validatedPrHourValueLabel.Name = "validatedPrHourValueLabel";
            this.validatedPrHourValueLabel.Size = new System.Drawing.Size(202, 17);
            this.validatedPrHourValueLabel.TabIndex = 13;
            this.validatedPrHourValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.durationLabel.Location = new System.Drawing.Point(417, 51);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(201, 17);
            this.durationLabel.TabIndex = 14;
            this.durationLabel.Text = ":Duration";
            this.durationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // durationValueLabel
            // 
            this.durationValueLabel.AutoSize = true;
            this.durationValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.durationValueLabel.Location = new System.Drawing.Point(624, 51);
            this.durationValueLabel.Name = "durationValueLabel";
            this.durationValueLabel.Size = new System.Drawing.Size(0, 17);
            this.durationValueLabel.TabIndex = 15;
            this.durationValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headerPanel
            // 
            this.headerPanel.ColumnCount = 1;
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerPanel.Controls.Add(this.oeeDetailsPanel, 0, 0);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.RowCount = 1;
            this.headerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerPanel.Size = new System.Drawing.Size(835, 150);
            this.headerPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Skift";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(210, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 17);
            this.label2.TabIndex = 17;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.chart);
            this.Controls.Add(this.headerPanel);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(835, 703);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.oeeDetailsPanel.ResumeLayout(false);
            this.oeeDetailsPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TableLayoutPanel oeeDetailsPanel;
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.Label orderNumberValueLabel;
        private System.Windows.Forms.Label machineLabel;
        private System.Windows.Forms.Label machineValueLabel;
        private System.Windows.Forms.Label productNumberLabel;
        private System.Windows.Forms.Label periodStartLabel;
        private System.Windows.Forms.Label periodStartValueLabel;
        private System.Windows.Forms.Label periodEndLabel;
        private System.Windows.Forms.Label periodEndValueLabel;        
        private System.Windows.Forms.Label productNumberValueLabel;
        private System.Windows.Forms.Label producedPrHourLabel;
        private System.Windows.Forms.Label producedPrHourValueLabel;
        private System.Windows.Forms.Label producedItemsLabel;
        private System.Windows.Forms.Label producedItemsValueLabel;
        private System.Windows.Forms.Label discardedItemsLabel;
        private System.Windows.Forms.Label discardedItemsValueLabel;
        private System.Windows.Forms.Label availabilityLabel;
        private System.Windows.Forms.Label availabilityValueLabel;
        private System.Windows.Forms.Label performanceLabel;
        private System.Windows.Forms.Label performanceValueLabel;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.Label qualityValueLabel;
        private System.Windows.Forms.Label overallOEELabel;
        private System.Windows.Forms.Label oeeOverallValueLabel;
        private System.Windows.Forms.TableLayoutPanel headerPanel;
        private System.Windows.Forms.Label validatedPrHourLabel;
        private System.Windows.Forms.Label validatedPrHourValueLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label durationValueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
