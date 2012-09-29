namespace Mikadocs.OEE.UserControls
{
    partial class ProductionFilterUserControl
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
            this.filterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPeriodStart = new System.Windows.Forms.DateTimePicker();
            this.dtPeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.cbMachine = new System.Windows.Forms.ComboBox();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.AutoSize = true;
            this.filterPanel.ColumnCount = 6;
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17172F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17172F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17172F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filterPanel.Controls.Add(this.label1, 0, 0);
            this.filterPanel.Controls.Add(this.label2, 0, 1);
            this.filterPanel.Controls.Add(this.label3, 2, 0);
            this.filterPanel.Controls.Add(this.label4, 2, 1);
            this.filterPanel.Controls.Add(this.label5, 4, 0);
            this.filterPanel.Controls.Add(this.label6, 4, 1);
            this.filterPanel.Controls.Add(this.dtPeriodStart, 1, 0);
            this.filterPanel.Controls.Add(this.dtPeriodEnd, 1, 1);
            this.filterPanel.Controls.Add(this.txtOrder, 3, 0);
            this.filterPanel.Controls.Add(this.txtProduct, 3, 1);
            this.filterPanel.Controls.Add(this.cbMachine, 5, 0);
            this.filterPanel.Controls.Add(this.cbTeam, 5, 1);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.RowCount = 2;
            this.filterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filterPanel.Size = new System.Drawing.Size(898, 150);
            this.filterPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slut";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(302, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 75);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ordre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(302, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 75);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produkt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(601, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 75);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maskine";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(601, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 75);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hold";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtPeriodStart
            // 
            this.dtPeriodStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPeriodStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriodStart.Location = new System.Drawing.Point(148, 3);
            this.dtPeriodStart.Name = "dtPeriodStart";
            this.dtPeriodStart.Size = new System.Drawing.Size(148, 20);
            this.dtPeriodStart.TabIndex = 6;
            this.dtPeriodStart.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // dtPeriodEnd
            // 
            this.dtPeriodEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPeriodEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriodEnd.Location = new System.Drawing.Point(148, 78);
            this.dtPeriodEnd.Name = "dtPeriodEnd";
            this.dtPeriodEnd.Size = new System.Drawing.Size(148, 20);
            this.dtPeriodEnd.TabIndex = 7;
            this.dtPeriodEnd.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // txtOrder
            // 
            this.txtOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrder.Location = new System.Drawing.Point(447, 3);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(148, 20);
            this.txtOrder.TabIndex = 8;
            this.txtOrder.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // txtProduct
            // 
            this.txtProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProduct.Location = new System.Drawing.Point(447, 78);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(148, 20);
            this.txtProduct.TabIndex = 9;
            this.txtProduct.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // cbMachine
            // 
            this.cbMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMachine.FormattingEnabled = true;
            this.cbMachine.Location = new System.Drawing.Point(746, 3);
            this.cbMachine.Name = "cbMachine";
            this.cbMachine.Size = new System.Drawing.Size(149, 21);
            this.cbMachine.TabIndex = 10;
            this.cbMachine.SelectedValueChanged += new System.EventHandler(this.OnValueChanged);
            this.cbMachine.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // cbTeam
            // 
            this.cbTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(746, 78);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(149, 21);
            this.cbTeam.TabIndex = 11;
            this.cbTeam.SelectedValueChanged += new System.EventHandler(this.OnValueChanged);
            this.cbTeam.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // ProductionFilterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterPanel);
            this.Name = "ProductionFilterUserControl";
            this.Size = new System.Drawing.Size(898, 150);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel filterPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPeriodStart;
        private System.Windows.Forms.DateTimePicker dtPeriodEnd;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ComboBox cbMachine;
        private System.Windows.Forms.ComboBox cbTeam;
    }
}
