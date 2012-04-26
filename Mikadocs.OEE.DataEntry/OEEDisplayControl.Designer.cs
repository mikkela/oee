namespace Mikadocs.OEE.DataEntry
{
    partial class OEEDisplayControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.plnTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblOrderValue = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProductValue = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblStartValue = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDurationValue = new System.Windows.Forms.Label();
            this.lblProduced = new System.Windows.Forms.Label();
            this.lblProducedValue = new System.Windows.Forms.Label();
            this.lblDiscarded = new System.Windows.Forms.Label();
            this.lblDiscardedValue = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblAvailabilityValue = new System.Windows.Forms.Label();
            this.lblPerformance = new System.Windows.Forms.Label();
            this.lblPerformanceValue = new System.Windows.Forms.Label();
            this.lblQualityValue = new System.Windows.Forms.Label();
            this.lblOEE = new System.Windows.Forms.Label();
            this.lblOEEValue = new System.Windows.Forms.Label();
            this.plnCenter = new System.Windows.Forms.TableLayoutPanel();
            this.chartShift = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProduction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.plnTop.SuspendLayout();
            this.plnCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduction)).BeginInit();
            this.SuspendLayout();
            // 
            // plnTop
            // 
            this.plnTop.ColumnCount = 4;
            this.plnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.plnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.plnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.plnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.plnTop.Controls.Add(this.lblQuality, 0, 4);
            this.plnTop.Controls.Add(this.lblOrder, 0, 0);
            this.plnTop.Controls.Add(this.lblOrderValue, 1, 0);
            this.plnTop.Controls.Add(this.lblProduct, 2, 0);
            this.plnTop.Controls.Add(this.lblProductValue, 3, 0);
            this.plnTop.Controls.Add(this.lblStart, 0, 1);
            this.plnTop.Controls.Add(this.lblStartValue, 1, 1);
            this.plnTop.Controls.Add(this.lblDuration, 2, 1);
            this.plnTop.Controls.Add(this.lblDurationValue, 3, 1);
            this.plnTop.Controls.Add(this.lblProduced, 0, 2);
            this.plnTop.Controls.Add(this.lblProducedValue, 1, 2);
            this.plnTop.Controls.Add(this.lblDiscarded, 2, 2);
            this.plnTop.Controls.Add(this.lblDiscardedValue, 3, 2);
            this.plnTop.Controls.Add(this.lblAvailability, 0, 3);
            this.plnTop.Controls.Add(this.lblAvailabilityValue, 1, 3);
            this.plnTop.Controls.Add(this.lblPerformance, 2, 3);
            this.plnTop.Controls.Add(this.lblPerformanceValue, 3, 3);
            this.plnTop.Controls.Add(this.lblQualityValue, 1, 4);
            this.plnTop.Controls.Add(this.lblOEE, 2, 4);
            this.plnTop.Controls.Add(this.lblOEEValue, 3, 4);
            this.plnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plnTop.Location = new System.Drawing.Point(0, 0);
            this.plnTop.Name = "plnTop";
            this.plnTop.RowCount = 5;
            this.plnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.plnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.plnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.plnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.plnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.plnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.plnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.plnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.plnTop.Size = new System.Drawing.Size(557, 100);
            this.plnTop.TabIndex = 0;
            // 
            // lblQuality
            // 
            this.lblQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblQuality.ForeColor = System.Drawing.Color.White;
            this.lblQuality.Location = new System.Drawing.Point(3, 80);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(133, 20);
            this.lblQuality.TabIndex = 1;
            this.lblQuality.Text = ":Quality";
            this.lblQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrder
            // 
            this.lblOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblOrder.ForeColor = System.Drawing.Color.White;
            this.lblOrder.Location = new System.Drawing.Point(3, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(133, 20);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = ":Order";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderValue
            // 
            this.lblOrderValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblOrderValue.Location = new System.Drawing.Point(142, 0);
            this.lblOrderValue.Name = "lblOrderValue";
            this.lblOrderValue.Size = new System.Drawing.Size(133, 20);
            this.lblOrderValue.TabIndex = 2;
            this.lblOrderValue.Text = "order number";
            this.lblOrderValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProduct
            // 
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(281, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(133, 20);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = ":Product";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductValue
            // 
            this.lblProductValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProductValue.Location = new System.Drawing.Point(420, 0);
            this.lblProductValue.Name = "lblProductValue";
            this.lblProductValue.Size = new System.Drawing.Size(134, 20);
            this.lblProductValue.TabIndex = 4;
            this.lblProductValue.Text = "Product Number";
            this.lblProductValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStart
            // 
            this.lblStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(3, 20);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(133, 20);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = ":Start";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartValue
            // 
            this.lblStartValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblStartValue.Location = new System.Drawing.Point(142, 20);
            this.lblStartValue.Name = "lblStartValue";
            this.lblStartValue.Size = new System.Drawing.Size(133, 20);
            this.lblStartValue.TabIndex = 6;
            this.lblStartValue.Text = "start";
            this.lblStartValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDuration
            // 
            this.lblDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(281, 20);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(133, 20);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = ":End";
            // 
            // lblDurationValue
            // 
            this.lblDurationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDurationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDurationValue.Location = new System.Drawing.Point(420, 20);
            this.lblDurationValue.Name = "lblDurationValue";
            this.lblDurationValue.Size = new System.Drawing.Size(134, 20);
            this.lblDurationValue.TabIndex = 8;
            this.lblDurationValue.Text = "end";
            this.lblDurationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProduced
            // 
            this.lblProduced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduced.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProduced.ForeColor = System.Drawing.Color.White;
            this.lblProduced.Location = new System.Drawing.Point(3, 40);
            this.lblProduced.Name = "lblProduced";
            this.lblProduced.Size = new System.Drawing.Size(133, 20);
            this.lblProduced.TabIndex = 9;
            this.lblProduced.Text = ":Produced";
            this.lblProduced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProducedValue
            // 
            this.lblProducedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProducedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProducedValue.Location = new System.Drawing.Point(142, 40);
            this.lblProducedValue.Name = "lblProducedValue";
            this.lblProducedValue.Size = new System.Drawing.Size(133, 20);
            this.lblProducedValue.TabIndex = 10;
            this.lblProducedValue.Text = "producedValue";
            this.lblProducedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscarded
            // 
            this.lblDiscarded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscarded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDiscarded.ForeColor = System.Drawing.Color.White;
            this.lblDiscarded.Location = new System.Drawing.Point(281, 40);
            this.lblDiscarded.Name = "lblDiscarded";
            this.lblDiscarded.Size = new System.Drawing.Size(133, 20);
            this.lblDiscarded.TabIndex = 11;
            this.lblDiscarded.Text = "lblDiscarded";
            this.lblDiscarded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscardedValue
            // 
            this.lblDiscardedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscardedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDiscardedValue.Location = new System.Drawing.Point(420, 40);
            this.lblDiscardedValue.Name = "lblDiscardedValue";
            this.lblDiscardedValue.Size = new System.Drawing.Size(134, 20);
            this.lblDiscardedValue.TabIndex = 12;
            this.lblDiscardedValue.Text = "lblDiscardedValue";
            this.lblDiscardedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvailability
            // 
            this.lblAvailability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAvailability.ForeColor = System.Drawing.Color.White;
            this.lblAvailability.Location = new System.Drawing.Point(3, 60);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(133, 20);
            this.lblAvailability.TabIndex = 13;
            this.lblAvailability.Text = "lblAvailability";
            this.lblAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvailabilityValue
            // 
            this.lblAvailabilityValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailabilityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAvailabilityValue.Location = new System.Drawing.Point(142, 60);
            this.lblAvailabilityValue.Name = "lblAvailabilityValue";
            this.lblAvailabilityValue.Size = new System.Drawing.Size(133, 20);
            this.lblAvailabilityValue.TabIndex = 14;
            this.lblAvailabilityValue.Text = "lblAvailabilityValue";
            this.lblAvailabilityValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPerformance
            // 
            this.lblPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPerformance.ForeColor = System.Drawing.Color.White;
            this.lblPerformance.Location = new System.Drawing.Point(281, 60);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new System.Drawing.Size(133, 20);
            this.lblPerformance.TabIndex = 15;
            this.lblPerformance.Text = "lblPerformance";
            this.lblPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPerformanceValue
            // 
            this.lblPerformanceValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPerformanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPerformanceValue.Location = new System.Drawing.Point(420, 60);
            this.lblPerformanceValue.Name = "lblPerformanceValue";
            this.lblPerformanceValue.Size = new System.Drawing.Size(134, 20);
            this.lblPerformanceValue.TabIndex = 16;
            this.lblPerformanceValue.Text = "lblPerformanceValue";
            this.lblPerformanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQualityValue
            // 
            this.lblQualityValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQualityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblQualityValue.Location = new System.Drawing.Point(142, 80);
            this.lblQualityValue.Name = "lblQualityValue";
            this.lblQualityValue.Size = new System.Drawing.Size(133, 20);
            this.lblQualityValue.TabIndex = 17;
            this.lblQualityValue.Text = "label16";
            this.lblQualityValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOEE
            // 
            this.lblOEE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblOEE.ForeColor = System.Drawing.Color.White;
            this.lblOEE.Location = new System.Drawing.Point(281, 80);
            this.lblOEE.Name = "lblOEE";
            this.lblOEE.Size = new System.Drawing.Size(133, 20);
            this.lblOEE.TabIndex = 18;
            this.lblOEE.Text = "label17";
            this.lblOEE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOEEValue
            // 
            this.lblOEEValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOEEValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblOEEValue.Location = new System.Drawing.Point(420, 80);
            this.lblOEEValue.Name = "lblOEEValue";
            this.lblOEEValue.Size = new System.Drawing.Size(134, 20);
            this.lblOEEValue.TabIndex = 19;
            this.lblOEEValue.Text = "label18";
            this.lblOEEValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plnCenter
            // 
            this.plnCenter.ColumnCount = 1;
            this.plnCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plnCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.plnCenter.Controls.Add(this.chartShift, 0, 0);
            this.plnCenter.Controls.Add(this.chartProduction, 0, 1);
            this.plnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plnCenter.Location = new System.Drawing.Point(0, 100);
            this.plnCenter.Name = "plnCenter";
            this.plnCenter.RowCount = 2;
            this.plnCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.plnCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.plnCenter.Size = new System.Drawing.Size(557, 491);
            this.plnCenter.TabIndex = 1;
            // 
            // chartShift
            // 
            this.chartShift.BackColor = System.Drawing.Color.Transparent;
            this.chartShift.BorderlineColor = System.Drawing.Color.Black;
            this.chartShift.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartShift.BorderlineWidth = 2;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chartShift.ChartAreas.Add(chartArea1);
            this.chartShift.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend";
            this.chartShift.Legends.Add(legend1);
            this.chartShift.Location = new System.Drawing.Point(3, 3);
            this.chartShift.Name = "chartShift";
            series1.ChartArea = "Default";
            series1.Legend = "Legend";
            series1.Name = "Validated";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Legend = "Legend";
            series2.Name = "Minutes";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend";
            series3.Name = "Instances";
            this.chartShift.Series.Add(series1);
            this.chartShift.Series.Add(series2);
            this.chartShift.Series.Add(series3);
            this.chartShift.Size = new System.Drawing.Size(551, 239);
            this.chartShift.TabIndex = 0;
            this.chartShift.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title";
            title1.Text = "Shift";
            this.chartShift.Titles.Add(title1);
            // 
            // chartProduction
            // 
            this.chartProduction.BackColor = System.Drawing.Color.Transparent;
            this.chartProduction.BorderlineColor = System.Drawing.Color.Black;
            this.chartProduction.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartProduction.BorderlineWidth = 2;
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.AxisX.Interval = 1;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.OldLace;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "Default";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.chartProduction.ChartAreas.Add(chartArea2);
            this.chartProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartProduction.Legends.Add(legend2);
            this.chartProduction.Location = new System.Drawing.Point(3, 248);
            this.chartProduction.Name = "chartProduction";
            series4.ChartArea = "Default";
            series4.Legend = "Legend1";
            series4.Name = "Validated";
            series5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series5.ChartArea = "Default";
            series5.Legend = "Legend1";
            series5.Name = "Minutes";
            series6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series6.ChartArea = "Default";
            series6.Legend = "Legend1";
            series6.Name = "Instances";
            this.chartProduction.Series.Add(series4);
            this.chartProduction.Series.Add(series5);
            this.chartProduction.Series.Add(series6);
            this.chartProduction.Size = new System.Drawing.Size(551, 240);
            this.chartProduction.TabIndex = 1;
            this.chartProduction.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title";
            title2.Text = "Production";
            this.chartProduction.Titles.Add(title2);
            // 
            // OEEDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.plnCenter);
            this.Controls.Add(this.plnTop);
            this.Name = "OEEDisplayControl";
            this.Size = new System.Drawing.Size(557, 591);
            this.plnTop.ResumeLayout(false);
            this.plnCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel plnTop;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Label lblOrderValue;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProductValue;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblStartValue;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDurationValue;
        private System.Windows.Forms.Label lblProduced;
        private System.Windows.Forms.Label lblProducedValue;
        private System.Windows.Forms.Label lblDiscarded;
        private System.Windows.Forms.Label lblDiscardedValue;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblAvailabilityValue;
        private System.Windows.Forms.Label lblPerformance;
        private System.Windows.Forms.Label lblPerformanceValue;
        private System.Windows.Forms.Label lblQualityValue;
        private System.Windows.Forms.Label lblOEE;
        private System.Windows.Forms.Label lblOEEValue;
        private System.Windows.Forms.TableLayoutPanel plnCenter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartShift;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduction;
    }
}
