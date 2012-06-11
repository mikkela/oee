using System.Windows.Forms;

namespace Mikadocs.OEE.ManagementConsole
{
    partial class ManagementForm
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
                _repositoryFactory.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnSetupMachine = new System.Windows.Forms.Button();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.dgProductions = new System.Windows.Forms.DataGridView();
            this.machineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producedItemsPerHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionViewEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionFilterUserControl1 = new Mikadocs.OEE.UserControls.ProductionFilterUserControl();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlCloseButton = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.pnlToolbarRight = new System.Windows.Forms.Panel();
            this.btnManageData = new System.Windows.Forms.Button();
            this.pictureCellNotSelected = new System.Windows.Forms.PictureBox();
            this.pictureCellSelected = new System.Windows.Forms.PictureBox();
            this.pnlToolbarLeft = new System.Windows.Forms.Panel();
            this.bthMinimize = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBorder.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionViewEntityBindingSource)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlCloseButton.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlToolbarRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCellNotSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCellSelected)).BeginInit();
            this.pnlToolbarLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHeader
            // 
            this.txtHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeader.BackColor = System.Drawing.Color.White;
            this.txtHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.Location = new System.Drawing.Point(7, 15);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.ReadOnly = true;
            this.txtHeader.Size = new System.Drawing.Size(713, 30);
            this.txtHeader.TabIndex = 0;
            this.txtHeader.Text = ":Machine - :Production";
            this.txtHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.BackgroundImage")));
            this.btnGenerateReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGenerateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Location = new System.Drawing.Point(0, -3);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(76, 76);
            this.btnGenerateReport.TabIndex = 7;
            this.btnGenerateReport.Tag = "Delete";
            this.toolTip.SetToolTip(this.btnGenerateReport, "Rapporter");
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.OnGenerateReport);
            this.btnGenerateReport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnGenerateReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnSetupMachine
            // 
            this.btnSetupMachine.BackColor = System.Drawing.Color.Transparent;
            this.btnSetupMachine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetupMachine.BackgroundImage")));
            this.btnSetupMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetupMachine.FlatAppearance.BorderSize = 0;
            this.btnSetupMachine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetupMachine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetupMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetupMachine.Location = new System.Drawing.Point(190, -3);
            this.btnSetupMachine.Name = "btnSetupMachine";
            this.btnSetupMachine.Size = new System.Drawing.Size(76, 76);
            this.btnSetupMachine.TabIndex = 10;
            this.btnSetupMachine.Tag = "Sendreports";
            this.toolTip.SetToolTip(this.btnSetupMachine, "Opsætning");
            this.btnSetupMachine.UseVisualStyleBackColor = false;
            this.btnSetupMachine.Click += new System.EventHandler(this.OnSetupMachine);
            this.btnSetupMachine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnSetupMachine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.Transparent;
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Controls.Add(this.pnlDisplay);
            this.pnlBorder.Controls.Add(this.pnlTop);
            this.pnlBorder.Controls.Add(this.pnlToolbar);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(800, 482);
            this.pnlBorder.TabIndex = 15;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.dgProductions);
            this.pnlDisplay.Controls.Add(this.productionFilterUserControl1);
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 70);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(798, 335);
            this.pnlDisplay.TabIndex = 19;
            // 
            // dgProductions
            // 
            this.dgProductions.AllowUserToAddRows = false;
            this.dgProductions.AllowUserToDeleteRows = false;
            this.dgProductions.AutoGenerateColumns = false;
            this.dgProductions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.orderDataGridViewTextBoxColumn,
            this.expectedItemsDataGridViewTextBoxColumn,
            this.producedItemsPerHourDataGridViewTextBoxColumn,
            this.productionStartDataGridViewTextBoxColumn,
            this.productionEndDataGridViewTextBoxColumn});
            this.dgProductions.DataSource = this.productionViewEntityBindingSource;
            this.dgProductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProductions.Location = new System.Drawing.Point(0, 64);
            this.dgProductions.MultiSelect = false;
            this.dgProductions.Name = "dgProductions";
            this.dgProductions.ReadOnly = true;
            this.dgProductions.Size = new System.Drawing.Size(798, 271);
            this.dgProductions.TabIndex = 0;
            // 
            // machineDataGridViewTextBoxColumn
            // 
            this.machineDataGridViewTextBoxColumn.DataPropertyName = "Machine";
            this.machineDataGridViewTextBoxColumn.HeaderText = "Machine";
            this.machineDataGridViewTextBoxColumn.Name = "machineDataGridViewTextBoxColumn";
            this.machineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            this.orderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expectedItemsDataGridViewTextBoxColumn
            // 
            this.expectedItemsDataGridViewTextBoxColumn.DataPropertyName = "ExpectedItems";
            this.expectedItemsDataGridViewTextBoxColumn.HeaderText = "ExpectedItems";
            this.expectedItemsDataGridViewTextBoxColumn.Name = "expectedItemsDataGridViewTextBoxColumn";
            this.expectedItemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // producedItemsPerHourDataGridViewTextBoxColumn
            // 
            this.producedItemsPerHourDataGridViewTextBoxColumn.DataPropertyName = "ProducedItems";
            this.producedItemsPerHourDataGridViewTextBoxColumn.HeaderText = "ProducedItems";
            this.producedItemsPerHourDataGridViewTextBoxColumn.Name = "producedItemsPerHourDataGridViewTextBoxColumn";
            this.producedItemsPerHourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionStartDataGridViewTextBoxColumn
            // 
            this.productionStartDataGridViewTextBoxColumn.DataPropertyName = "ProductionStart";
            this.productionStartDataGridViewTextBoxColumn.HeaderText = "ProductionStart";
            this.productionStartDataGridViewTextBoxColumn.Name = "productionStartDataGridViewTextBoxColumn";
            this.productionStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionEndDataGridViewTextBoxColumn
            // 
            this.productionEndDataGridViewTextBoxColumn.DataPropertyName = "ProductionEnd";
            this.productionEndDataGridViewTextBoxColumn.HeaderText = "ProductionEnd";
            this.productionEndDataGridViewTextBoxColumn.Name = "productionEndDataGridViewTextBoxColumn";
            this.productionEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionViewEntityBindingSource
            // 
            this.productionViewEntityBindingSource.DataSource = typeof(Mikadocs.OEE.ManagementConsole.ProductionViewEntity);
            this.productionViewEntityBindingSource.Sort = "ProductionStart";
            // 
            // productionFilterUserControl1
            // 
            this.productionFilterUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.productionFilterUserControl1.Location = new System.Drawing.Point(0, 0);
            this.productionFilterUserControl1.Name = "productionFilterUserControl1";
            this.productionFilterUserControl1.Size = new System.Drawing.Size(798, 64);
            this.productionFilterUserControl1.TabIndex = 20;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlTopLeft);
            this.pnlTop.Controls.Add(this.pnlCloseButton);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(798, 70);
            this.pnlTop.TabIndex = 18;
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopLeft.Controls.Add(this.pnlHeader);
            this.pnlTopLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(734, 70);
            this.pnlTopLeft.TabIndex = 14;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.txtHeader);
            this.pnlHeader.Location = new System.Drawing.Point(4, 6);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pnlHeader.Size = new System.Drawing.Size(727, 58);
            this.pnlHeader.TabIndex = 19;
            // 
            // pnlCloseButton
            // 
            this.pnlCloseButton.Controls.Add(this.btnClose);
            this.pnlCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCloseButton.Location = new System.Drawing.Point(730, 0);
            this.pnlCloseButton.Name = "pnlCloseButton";
            this.pnlCloseButton.Size = new System.Drawing.Size(68, 70);
            this.pnlCloseButton.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(10, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 15;
            this.btnClose.Tag = "Delete";
            this.toolTip.SetToolTip(this.btnClose, "Luk");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnClose);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.Controls.Add(this.txtCopyright);
            this.pnlToolbar.Controls.Add(this.pnlToolbarRight);
            this.pnlToolbar.Controls.Add(this.pictureCellNotSelected);
            this.pnlToolbar.Controls.Add(this.pictureCellSelected);
            this.pnlToolbar.Controls.Add(this.pnlToolbarLeft);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 405);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(798, 75);
            this.pnlToolbar.TabIndex = 17;
            // 
            // txtCopyright
            // 
            this.txtCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtCopyright.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCopyright.Location = new System.Drawing.Point(191, 6);
            this.txtCopyright.Multiline = true;
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(326, 57);
            this.txtCopyright.TabIndex = 20;
            this.txtCopyright.Text = "Copyright";
            this.txtCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlToolbarRight
            // 
            this.pnlToolbarRight.Controls.Add(this.btnManageData);
            this.pnlToolbarRight.Controls.Add(this.btnGenerateReport);
            this.pnlToolbarRight.Controls.Add(this.btnSetupMachine);
            this.pnlToolbarRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlToolbarRight.Location = new System.Drawing.Point(523, 0);
            this.pnlToolbarRight.Name = "pnlToolbarRight";
            this.pnlToolbarRight.Size = new System.Drawing.Size(275, 75);
            this.pnlToolbarRight.TabIndex = 11;
            // 
            // btnManageData
            // 
            this.btnManageData.BackColor = System.Drawing.Color.Transparent;
            this.btnManageData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageData.BackgroundImage")));
            this.btnManageData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageData.FlatAppearance.BorderSize = 0;
            this.btnManageData.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnManageData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnManageData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnManageData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageData.Location = new System.Drawing.Point(95, -1);
            this.btnManageData.Name = "btnManageData";
            this.btnManageData.Size = new System.Drawing.Size(76, 76);
            this.btnManageData.TabIndex = 11;
            this.btnManageData.Tag = "Delete";
            this.toolTip.SetToolTip(this.btnManageData, "Dataadministration");
            this.btnManageData.UseVisualStyleBackColor = false;
            this.btnManageData.Click += new System.EventHandler(this.OnManageData);
            this.btnManageData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnManageData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // pictureCellNotSelected
            // 
            this.pictureCellNotSelected.Location = new System.Drawing.Point(264, 14);
            this.pictureCellNotSelected.Name = "pictureCellNotSelected";
            this.pictureCellNotSelected.Size = new System.Drawing.Size(50, 50);
            this.pictureCellNotSelected.TabIndex = 19;
            this.pictureCellNotSelected.TabStop = false;
            this.pictureCellNotSelected.Visible = false;
            // 
            // pictureCellSelected
            // 
            this.pictureCellSelected.Location = new System.Drawing.Point(332, 16);
            this.pictureCellSelected.Name = "pictureCellSelected";
            this.pictureCellSelected.Size = new System.Drawing.Size(50, 50);
            this.pictureCellSelected.TabIndex = 19;
            this.pictureCellSelected.TabStop = false;
            this.pictureCellSelected.Visible = false;
            // 
            // pnlToolbarLeft
            // 
            this.pnlToolbarLeft.Controls.Add(this.bthMinimize);
            this.pnlToolbarLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlToolbarLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbarLeft.Name = "pnlToolbarLeft";
            this.pnlToolbarLeft.Size = new System.Drawing.Size(211, 75);
            this.pnlToolbarLeft.TabIndex = 11;
            // 
            // bthMinimize
            // 
            this.bthMinimize.BackColor = System.Drawing.Color.Transparent;
            this.bthMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bthMinimize.BackgroundImage")));
            this.bthMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthMinimize.FlatAppearance.BorderSize = 0;
            this.bthMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bthMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bthMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthMinimize.Location = new System.Drawing.Point(0, -1);
            this.bthMinimize.Name = "bthMinimize";
            this.bthMinimize.Size = new System.Drawing.Size(76, 76);
            this.bthMinimize.TabIndex = 16;
            this.bthMinimize.Tag = "Sendreports";
            this.toolTip.SetToolTip(this.bthMinimize, "Minimer");
            this.bthMinimize.UseVisualStyleBackColor = false;
            this.bthMinimize.Click += new System.EventHandler(this.OnMinimize);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(80)))), ((int)(((byte)(83)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBorder.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionViewEntityBindingSource)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCloseButton.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlToolbarRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCellNotSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCellSelected)).EndInit();
            this.pnlToolbarLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnSetupMachine;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Panel pnlToolbarLeft;
        private System.Windows.Forms.Panel pnlToolbarRight;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlCloseButton;
        private System.Windows.Forms.Panel pnlTopLeft;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureCellSelected;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.PictureBox pictureCellNotSelected;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.DataGridView dgProductions;
        private System.Windows.Forms.Button btnManageData;
        private System.Windows.Forms.BindingSource productionViewEntityBindingSource;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producedItemsPerHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bthMinimize;
        private UserControls.ProductionFilterUserControl productionFilterUserControl1;  
    }
}