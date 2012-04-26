namespace Mikadocs.OEE.CostCalculator
{
    partial class BaseCostForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvMachines = new System.Windows.Forms.DataGridView();
            this.machineConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.machineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineConfigurationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMachines
            // 
            this.dgvMachines.AllowUserToAddRows = false;
            this.dgvMachines.AllowUserToDeleteRows = false;
            this.dgvMachines.AutoGenerateColumns = false;
            this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineNameDataGridViewTextBoxColumn,
            this.baseCostDataGridViewTextBoxColumn});
            this.dgvMachines.DataSource = this.machineConfigurationBindingSource;
            this.dgvMachines.Location = new System.Drawing.Point(12, 12);
            this.dgvMachines.Name = "dgvMachines";
            this.dgvMachines.Size = new System.Drawing.Size(465, 287);
            this.dgvMachines.TabIndex = 0;
            // 
            // machineConfigurationBindingSource
            // 
            this.machineConfigurationBindingSource.DataSource = typeof(Mikadocs.OEE.MachineConfiguration);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(401, 306);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(320, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // machineNameDataGridViewTextBoxColumn
            // 
            this.machineNameDataGridViewTextBoxColumn.DataPropertyName = "MachineName";
            this.machineNameDataGridViewTextBoxColumn.HeaderText = "Maskine";
            this.machineNameDataGridViewTextBoxColumn.Name = "machineNameDataGridViewTextBoxColumn";
            this.machineNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // baseCostDataGridViewTextBoxColumn
            // 
            this.baseCostDataGridViewTextBoxColumn.DataPropertyName = "BaseCost";
            this.baseCostDataGridViewTextBoxColumn.HeaderText = "Omkostninger pr. time";
            this.baseCostDataGridViewTextBoxColumn.Name = "baseCostDataGridViewTextBoxColumn";
            this.baseCostDataGridViewTextBoxColumn.Width = 170;
            // 
            // BaseCostForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(489, 334);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvMachines);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseCostForm";
            this.Text = "BaseCostForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineConfigurationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMachines;
        private System.Windows.Forms.BindingSource machineConfigurationBindingSource;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseCostDataGridViewTextBoxColumn;
    }
}