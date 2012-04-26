namespace Mikadocs.OEE.DataEntry
{
    partial class StartShiftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartShiftForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValidatedSetupTime = new System.Windows.Forms.Label();
            this.txtValidatedSetupTime = new System.Windows.Forms.TextBox();
            this.ucStartTime = new Mikadocs.OEE.DataEntry.TimeEntryUserControl();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.cbMachines = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblExpectedItems = new System.Windows.Forms.Label();
            this.txtExpectedItems = new System.Windows.Forms.TextBox();
            this.lblProducedItemsPerHour = new System.Windows.Forms.Label();
            this.txtProducedItemsPerHour = new System.Windows.Forms.TextBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblValidatedSetupTime);
            this.panel1.Controls.Add(this.txtValidatedSetupTime);
            this.panel1.Controls.Add(this.ucStartTime);
            this.panel1.Controls.Add(this.lblStartTime);
            this.panel1.Controls.Add(this.cbMachines);
            this.panel1.Controls.Add(this.lblProduct);
            this.panel1.Controls.Add(this.txtProduct);
            this.panel1.Controls.Add(this.lblExpectedItems);
            this.panel1.Controls.Add(this.txtExpectedItems);
            this.panel1.Controls.Add(this.lblProducedItemsPerHour);
            this.panel1.Controls.Add(this.txtProducedItemsPerHour);
            this.panel1.Controls.Add(this.lblMachine);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.btnDecline);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 305);
            this.panel1.TabIndex = 1;
            // 
            // lblValidatedSetupTime
            // 
            this.lblValidatedSetupTime.AutoSize = true;
            this.lblValidatedSetupTime.BackColor = System.Drawing.Color.Transparent;
            this.lblValidatedSetupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidatedSetupTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblValidatedSetupTime.Location = new System.Drawing.Point(13, 188);
            this.lblValidatedSetupTime.Name = "lblValidatedSetupTime";
            this.lblValidatedSetupTime.Size = new System.Drawing.Size(79, 16);
            this.lblValidatedSetupTime.TabIndex = 53;
            this.lblValidatedSetupTime.Text = ":Produced";
            // 
            // txtValidatedSetupTime
            // 
            this.txtValidatedSetupTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtValidatedSetupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidatedSetupTime.Location = new System.Drawing.Point(269, 181);
            this.txtValidatedSetupTime.Name = "txtValidatedSetupTime";
            this.txtValidatedSetupTime.Size = new System.Drawing.Size(121, 23);
            this.txtValidatedSetupTime.TabIndex = 54;
            this.txtValidatedSetupTime.Text = "0";
            this.txtValidatedSetupTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBoxKeyPressed);
            // 
            // ucStartTime
            // 
            this.ucStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ucStartTime.Location = new System.Drawing.Point(269, 211);
            this.ucStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucStartTime.Name = "ucStartTime";
            this.ucStartTime.Size = new System.Drawing.Size(159, 27);
            this.ucStartTime.TabIndex = 52;
            this.ucStartTime.Value = System.TimeSpan.Parse("20:35:00");
            this.ucStartTime.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStartTime);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblStartTime.Location = new System.Drawing.Point(15, 222);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(83, 16);
            this.lblStartTime.TabIndex = 51;
            this.lblStartTime.Text = ":Start Time";
            // 
            // cbMachines
            // 
            this.cbMachines.BackColor = System.Drawing.SystemColors.Control;
            this.cbMachines.FormattingEnabled = true;
            this.cbMachines.Location = new System.Drawing.Point(269, 54);
            this.cbMachines.Name = "cbMachines";
            this.cbMachines.Size = new System.Drawing.Size(121, 21);
            this.cbMachines.TabIndex = 2;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Transparent;
            this.lblProduct.Location = new System.Drawing.Point(13, 93);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(65, 16);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = ":Product";
            // 
            // txtProduct
            // 
            this.txtProduct.BackColor = System.Drawing.SystemColors.Control;
            this.txtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(269, 93);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(121, 23);
            this.txtProduct.TabIndex = 4;
            this.txtProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBoxKeyPressed);
            this.txtProduct.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingProduct);
            // 
            // lblExpectedItems
            // 
            this.lblExpectedItems.AutoSize = true;
            this.lblExpectedItems.BackColor = System.Drawing.Color.Transparent;
            this.lblExpectedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedItems.ForeColor = System.Drawing.Color.Transparent;
            this.lblExpectedItems.Location = new System.Drawing.Point(15, 129);
            this.lblExpectedItems.Name = "lblExpectedItems";
            this.lblExpectedItems.Size = new System.Drawing.Size(77, 16);
            this.lblExpectedItems.TabIndex = 7;
            this.lblExpectedItems.Text = ":Expected";
            // 
            // txtExpectedItems
            // 
            this.txtExpectedItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtExpectedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpectedItems.Location = new System.Drawing.Point(269, 122);
            this.txtExpectedItems.Name = "txtExpectedItems";
            this.txtExpectedItems.Size = new System.Drawing.Size(121, 23);
            this.txtExpectedItems.TabIndex = 8;
            this.txtExpectedItems.Text = "0";
            this.txtExpectedItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBoxKeyPressed);
            this.txtExpectedItems.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingExpectedItems);
            // 
            // lblProducedItemsPerHour
            // 
            this.lblProducedItemsPerHour.AutoSize = true;
            this.lblProducedItemsPerHour.BackColor = System.Drawing.Color.Transparent;
            this.lblProducedItemsPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducedItemsPerHour.ForeColor = System.Drawing.Color.Transparent;
            this.lblProducedItemsPerHour.Location = new System.Drawing.Point(13, 158);
            this.lblProducedItemsPerHour.Name = "lblProducedItemsPerHour";
            this.lblProducedItemsPerHour.Size = new System.Drawing.Size(79, 16);
            this.lblProducedItemsPerHour.TabIndex = 9;
            this.lblProducedItemsPerHour.Text = ":Produced";
            // 
            // txtProducedItemsPerHour
            // 
            this.txtProducedItemsPerHour.BackColor = System.Drawing.SystemColors.Control;
            this.txtProducedItemsPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducedItemsPerHour.Location = new System.Drawing.Point(269, 151);
            this.txtProducedItemsPerHour.Name = "txtProducedItemsPerHour";
            this.txtProducedItemsPerHour.Size = new System.Drawing.Size(121, 23);
            this.txtProducedItemsPerHour.TabIndex = 10;
            this.txtProducedItemsPerHour.Text = "0";
            this.txtProducedItemsPerHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBoxKeyPressed);
            this.txtProducedItemsPerHour.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingProducedItemsPerHour);
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.BackColor = System.Drawing.Color.Transparent;
            this.lblMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachine.ForeColor = System.Drawing.Color.Transparent;
            this.lblMachine.Location = new System.Drawing.Point(13, 59);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(70, 16);
            this.lblMachine.TabIndex = 1;
            this.lblMachine.Text = ":Machine";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(11, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(64, 25);
            this.lblHeader.TabIndex = 50;
            this.lblHeader.Tag = "";
            this.lblHeader.Text = ":New";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccept.BackgroundImage")));
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Location = new System.Drawing.Point(396, 251);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(50, 50);
            this.btnAccept.TabIndex = 13;
            this.toolTip.SetToolTip(this.btnAccept, "OK");
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnAccept.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.Color.Transparent;
            this.btnDecline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecline.BackgroundImage")));
            this.btnDecline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecline.CausesValidation = false;
            this.btnDecline.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDecline.FlatAppearance.BorderSize = 0;
            this.btnDecline.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDecline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDecline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.Location = new System.Drawing.Point(396, 3);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(50, 50);
            this.btnDecline.TabIndex = 14;
            this.toolTip.SetToolTip(this.btnDecline, "Fortryd");
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnDecline.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // StartLegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(459, 305);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartLegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":NewExportReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblProducedItemsPerHour;
        private System.Windows.Forms.TextBox txtProducedItemsPerHour;
        private System.Windows.Forms.Label lblExpectedItems;
        private System.Windows.Forms.TextBox txtExpectedItems;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ComboBox cbMachines;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
        private TimeEntryUserControl ucStartTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblValidatedSetupTime;
        private System.Windows.Forms.TextBox txtValidatedSetupTime;
        
    }
}