namespace Mikadocs.OEE.ManagementConsole
{
    partial class MachineConfigurationUserControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineConfigurationUserControl));
            this.plnProductionStops = new System.Windows.Forms.Panel();
            this.dgProductionStops = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.entityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionStopViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plnPositionButtons = new System.Windows.Forms.TableLayoutPanel();
            this.pbUp = new System.Windows.Forms.PictureBox();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.plnProductionStops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductionStops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopViewEntityBindingSource)).BeginInit();
            this.plnPositionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // plnProductionStops
            // 
            this.plnProductionStops.Controls.Add(this.dgProductionStops);
            this.plnProductionStops.Controls.Add(this.plnPositionButtons);
            this.plnProductionStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plnProductionStops.Location = new System.Drawing.Point(0, 0);
            this.plnProductionStops.Name = "plnProductionStops";
            this.plnProductionStops.Size = new System.Drawing.Size(669, 412);
            this.plnProductionStops.TabIndex = 1;
            // 
            // dgProductionStops
            // 
            this.dgProductionStops.AllowUserToAddRows = false;
            this.dgProductionStops.AllowUserToDeleteRows = false;
            this.dgProductionStops.AutoGenerateColumns = false;
            this.dgProductionStops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductionStops.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProductionStops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductionStops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.plannedDataGridViewCheckBoxColumn,
            this.entityDataGridViewTextBoxColumn});
            this.dgProductionStops.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.productionStopViewEntityBindingSource, "Entity", true));
            this.dgProductionStops.DataSource = this.productionStopViewEntityBindingSource;
            this.dgProductionStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductionStops.Location = new System.Drawing.Point(0, 0);
            this.dgProductionStops.MultiSelect = false;
            this.dgProductionStops.Name = "dgProductionStops";
            this.dgProductionStops.Size = new System.Drawing.Size(584, 412);
            this.dgProductionStops.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Produktionsstop";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // plannedDataGridViewCheckBoxColumn
            // 
            this.plannedDataGridViewCheckBoxColumn.DataPropertyName = "Planned";
            this.plannedDataGridViewCheckBoxColumn.HeaderText = "Planlagt";
            this.plannedDataGridViewCheckBoxColumn.Name = "plannedDataGridViewCheckBoxColumn";
            // 
            // entityDataGridViewTextBoxColumn
            // 
            this.entityDataGridViewTextBoxColumn.DataPropertyName = "Entity";
            this.entityDataGridViewTextBoxColumn.HeaderText = "Entity";
            this.entityDataGridViewTextBoxColumn.Name = "entityDataGridViewTextBoxColumn";
            this.entityDataGridViewTextBoxColumn.ReadOnly = true;
            this.entityDataGridViewTextBoxColumn.Visible = false;
            // 
            // productionStopViewEntityBindingSource
            // 
            this.productionStopViewEntityBindingSource.DataSource = typeof(Mikadocs.OEE.ManagementConsole.ProductionStopViewEntity);
            // 
            // plnPositionButtons
            // 
            this.plnPositionButtons.ColumnCount = 1;
            this.plnPositionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plnPositionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.plnPositionButtons.Controls.Add(this.pbUp, 0, 1);
            this.plnPositionButtons.Controls.Add(this.pbDown, 0, 2);
            this.plnPositionButtons.Controls.Add(this.pbAdd, 0, 0);
            this.plnPositionButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.plnPositionButtons.Location = new System.Drawing.Point(584, 0);
            this.plnPositionButtons.Name = "plnPositionButtons";
            this.plnPositionButtons.RowCount = 4;
            this.plnPositionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.plnPositionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.plnPositionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.plnPositionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.plnPositionButtons.Size = new System.Drawing.Size(85, 412);
            this.plnPositionButtons.TabIndex = 0;
            // 
            // pbUp
            // 
            this.pbUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUp.BackgroundImage")));
            this.pbUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUp.Location = new System.Drawing.Point(3, 159);
            this.pbUp.Name = "pbUp";
            this.pbUp.Size = new System.Drawing.Size(79, 44);
            this.pbUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUp.TabIndex = 0;
            this.pbUp.TabStop = false;
            this.toolTip.SetToolTip(this.pbUp, "Ryk op i prioritet");
            this.pbUp.Click += new System.EventHandler(this.OnMoveUp);
            this.pbUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.pbUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // pbDown
            // 
            this.pbDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbDown.BackgroundImage")));
            this.pbDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDown.Location = new System.Drawing.Point(3, 209);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(79, 44);
            this.pbDown.TabIndex = 1;
            this.pbDown.TabStop = false;
            this.toolTip.SetToolTip(this.pbDown, "Ryk ned i prioritet");
            this.pbDown.Click += new System.EventHandler(this.OnMoveDown);
            this.pbDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.pbDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // pbAdd
            // 
            this.pbAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAdd.BackgroundImage")));
            this.pbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAdd.Location = new System.Drawing.Point(3, 3);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(79, 44);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 2;
            this.pbAdd.TabStop = false;
            this.toolTip.SetToolTip(this.pbAdd, "Tilføj nyt produktionsstop");
            this.pbAdd.Click += new System.EventHandler(this.OnAddNewStop);
            this.pbAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.pbAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Entity";
            this.dataGridViewTextBoxColumn1.HeaderText = "Entity";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 109;
            // 
            // MachineConfigurationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.plnProductionStops);
            this.Name = "MachineConfigurationUserControl";
            this.Size = new System.Drawing.Size(669, 412);
            this.plnProductionStops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductionStops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionStopViewEntityBindingSource)).EndInit();
            this.plnPositionButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plnProductionStops;
        private System.Windows.Forms.TableLayoutPanel plnPositionButtons;
        private System.Windows.Forms.PictureBox pbUp;
        private System.Windows.Forms.PictureBox pbDown;
        private System.Windows.Forms.DataGridView dgProductionStops;
        private System.Windows.Forms.BindingSource productionStopViewEntityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn plannedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
