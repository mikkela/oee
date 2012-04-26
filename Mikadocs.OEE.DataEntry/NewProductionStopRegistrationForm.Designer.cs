namespace Mikadocs.OEE.DataEntry
{
    partial class NewProductionStopRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductionStopRegistrationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStopTypes = new System.Windows.Forms.ComboBox();
            this.lblStopType = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.cbStopTypes);
            this.panel1.Controls.Add(this.lblStopType);
            this.panel1.Controls.Add(this.txtDuration);
            this.panel1.Controls.Add(this.lblDuration);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.btnDecline);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 176);
            this.panel1.TabIndex = 1;
            // 
            // cbStopTypes
            // 
            this.cbStopTypes.BackColor = System.Drawing.SystemColors.Control;
            this.cbStopTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbStopTypes.FormattingEnabled = true;
            this.cbStopTypes.Location = new System.Drawing.Point(326, 90);
            this.cbStopTypes.Name = "cbStopTypes";
            this.cbStopTypes.Size = new System.Drawing.Size(214, 24);
            this.cbStopTypes.TabIndex = 4;
            // 
            // lblStopType
            // 
            this.lblStopType.AutoSize = true;
            this.lblStopType.BackColor = System.Drawing.Color.Transparent;
            this.lblStopType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopType.ForeColor = System.Drawing.Color.Transparent;
            this.lblStopType.Location = new System.Drawing.Point(13, 93);
            this.lblStopType.Name = "lblStopType";
            this.lblStopType.Size = new System.Drawing.Size(44, 16);
            this.lblStopType.TabIndex = 3;
            this.lblStopType.Text = ":Stop";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.SystemColors.Control;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(326, 56);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 23);
            this.txtDuration.TabIndex = 2;
            this.txtDuration.Text = "0";
            this.txtDuration.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateProductionStopDuration);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.Transparent;
            this.lblDuration.Location = new System.Drawing.Point(13, 59);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(70, 16);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = ":Duration";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(11, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(239, 25);
            this.lblHeader.TabIndex = 50;
            this.lblHeader.Tag = "";
            this.lblHeader.Text = ":New Production Stop";
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
            this.btnAccept.Location = new System.Drawing.Point(554, 125);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(50, 50);
            this.btnAccept.TabIndex = 5;
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
            this.btnDecline.Location = new System.Drawing.Point(554, 3);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(50, 50);
            this.btnDecline.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnDecline, "Fortryd");
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnDecline.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewProductionStopRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 176);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewProductionStopRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":NewExportReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
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
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblStopType;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.ComboBox cbStopTypes;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
        
    }
}