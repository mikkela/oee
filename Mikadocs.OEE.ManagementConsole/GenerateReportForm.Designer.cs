namespace Mikadocs.OEE.ManagementConsole
{
    partial class GenerateReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReportForm));
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.ucReport = new Mikadocs.OEE.ManagementConsole.ReportControl();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlCloseButton = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.pnlToolbarRight = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlToolbarLeft = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.productionFilterUserControl1 = new Mikadocs.OEE.UserControls.ProductionFilterUserControl();
            this.pnlBorder.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlCloseButton.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlToolbarRight.SuspendLayout();
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
            this.txtHeader.Size = new System.Drawing.Size(853, 30);
            this.txtHeader.TabIndex = 0;
            this.txtHeader.Text = ":Machine - :Production";
            this.txtHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(191, -3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(76, 76);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Tag = "Sendreports";
            this.toolTip.SetToolTip(this.btnPrint, "Print");
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.OnPrint);
            this.btnPrint.MouseDown += new System.Windows.Forms.MouseEventHandler(OnMouseDown);
            this.btnPrint.MouseUp += new System.Windows.Forms.MouseEventHandler(OnMouseUp);
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
            this.pnlBorder.Size = new System.Drawing.Size(940, 482);
            this.pnlBorder.TabIndex = 15;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.ucReport);
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 70);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(938, 335);
            this.pnlDisplay.TabIndex = 19;
            // 
            // ucReport
            // 
            this.ucReport.BackColor = System.Drawing.SystemColors.Window;
            this.ucReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReport.Location = new System.Drawing.Point(0, 0);
            this.ucReport.Name = "ucReport";
            this.ucReport.Size = new System.Drawing.Size(938, 335);
            this.ucReport.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlTopLeft);
            this.pnlTop.Controls.Add(this.pnlCloseButton);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(938, 70);
            this.pnlTop.TabIndex = 18;
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopLeft.Controls.Add(this.pnlHeader);
            this.pnlTopLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(874, 70);
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
            this.pnlHeader.Size = new System.Drawing.Size(867, 58);
            this.pnlHeader.TabIndex = 19;
            // 
            // pnlCloseButton
            // 
            this.pnlCloseButton.Controls.Add(this.btnClose);
            this.pnlCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCloseButton.Location = new System.Drawing.Point(870, 0);
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
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(OnMouseDown);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(OnMouseUp);
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.Controls.Add(this.pnlToolbarRight);
            this.pnlToolbar.Controls.Add(this.pnlToolbarLeft);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 405);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(938, 75);
            this.pnlToolbar.TabIndex = 17;
            // 
            // pnlToolbarRight
            // 
            this.pnlToolbarRight.Controls.Add(this.btnGenerate);
            this.pnlToolbarRight.Controls.Add(this.btnPrint);
            this.pnlToolbarRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlToolbarRight.Location = new System.Drawing.Point(663, 0);
            this.pnlToolbarRight.Name = "pnlToolbarRight";
            this.pnlToolbarRight.Size = new System.Drawing.Size(275, 75);
            this.pnlToolbarRight.TabIndex = 11;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerate.BackgroundImage")));
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(109, -1);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(76, 76);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Tag = "Sendreports";
            this.toolTip.SetToolTip(this.btnGenerate, "Dan rapport");
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.OnGenerate);
            this.btnGenerate.MouseDown += new System.Windows.Forms.MouseEventHandler(OnMouseDown);
            this.btnGenerate.MouseUp += new System.Windows.Forms.MouseEventHandler(OnMouseUp);
            // 
            // pnlToolbarLeft
            // 
            this.pnlToolbarLeft.Controls.Add(this.productionFilterUserControl1);
            this.pnlToolbarLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlToolbarLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbarLeft.Name = "pnlToolbarLeft";
            this.pnlToolbarLeft.Size = new System.Drawing.Size(600, 75);
            this.pnlToolbarLeft.TabIndex = 11;
            // 
            // productionFilterUserControl1
            // 
            this.productionFilterUserControl1.Location = new System.Drawing.Point(-1, -3);
            this.productionFilterUserControl1.Name = "productionFilterUserControl1";
            this.productionFilterUserControl1.Size = new System.Drawing.Size(601, 79);
            this.productionFilterUserControl1.TabIndex = 0;
            // 
            // GenerateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(80)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(940, 482);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateReportForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBorder.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCloseButton.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbarRight.ResumeLayout(false);
            this.pnlToolbarLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Panel pnlToolbarLeft;
        private System.Windows.Forms.Panel pnlToolbarRight;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlCloseButton;
        private System.Windows.Forms.Panel pnlTopLeft;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Panel pnlDisplay;
        private ReportControl ucReport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ToolTip toolTip;
        private UserControls.ProductionFilterUserControl productionFilterUserControl1;  
    }
}