namespace Mikadocs.OEE.CostCalculator
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbShowType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCombine = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ucFilter = new Mikadocs.OEE.CostCalculator.UCFilter();
            this.btnUpdateBaseCost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "Default";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(487, 22);
            this.chart.Name = "chart";
            series1.ChartArea = "Default";
            series1.Legend = "Legend1";
            series1.Name = "Fordeling";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(821, 466);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(12, 446);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(408, 117);
            this.tbStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vis";
            // 
            // cbShowType
            // 
            this.cbShowType.FormattingEnabled = true;
            this.cbShowType.Items.AddRange(new object[] {
            "Tid",
            "Omkostninger"});
            this.cbShowType.Location = new System.Drawing.Point(487, 512);
            this.cbShowType.Name = "cbShowType";
            this.cbShowType.Size = new System.Drawing.Size(121, 21);
            this.cbShowType.TabIndex = 4;
            this.cbShowType.SelectedIndexChanged += new System.EventHandler(this.CbShowTypeSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(821, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kombiner efter";
            // 
            // cbCombine
            // 
            this.cbCombine.FormattingEnabled = true;
            this.cbCombine.Items.AddRange(new object[] {
            "Dato",
            "Maskiner",
            "Skift"});
            this.cbCombine.Location = new System.Drawing.Point(824, 512);
            this.cbCombine.Name = "cbCombine";
            this.cbCombine.Size = new System.Drawing.Size(121, 21);
            this.cbCombine.TabIndex = 6;
            this.cbCombine.SelectedIndexChanged += new System.EventHandler(this.CbCombineSelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(345, 291);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Opdater";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
            // 
            // ucFilter
            // 
            this.ucFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucFilter.Location = new System.Drawing.Point(0, 0);
            this.ucFilter.Name = "ucFilter";
            this.ucFilter.Size = new System.Drawing.Size(435, 575);
            this.ucFilter.TabIndex = 0;
            // 
            // btnUpdateBaseCost
            // 
            this.btnUpdateBaseCost.AutoSize = true;
            this.btnUpdateBaseCost.Location = new System.Drawing.Point(1185, 540);
            this.btnUpdateBaseCost.Name = "btnUpdateBaseCost";
            this.btnUpdateBaseCost.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateBaseCost.TabIndex = 8;
            this.btnUpdateBaseCost.Text = "Opdater Omkostninger";
            this.btnUpdateBaseCost.UseVisualStyleBackColor = true;
            this.btnUpdateBaseCost.Click += new System.EventHandler(this.BtnUpdateBaseCostClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 575);
            this.Controls.Add(this.btnUpdateBaseCost);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbCombine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbShowType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.ucFilter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCFilter ucFilter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbShowType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCombine;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateBaseCost;
    }
}

