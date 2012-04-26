namespace Mikadocs.OEE.DataEntry
{
    partial class DataEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEntryForm));
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.btnDataEntry = new System.Windows.Forms.Button();
            this.btnAddStop = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlCloseButton = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.pnlToolbarRight = new System.Windows.Forms.Panel();
            this.bthMinimize = new System.Windows.Forms.Button();
            this.pictureCellNotSelected = new System.Windows.Forms.PictureBox();
            this.pictureCellSelected = new System.Windows.Forms.PictureBox();
            this.pnlToolbarLeft = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ucDisplay = new Mikadocs.OEE.DataEntry.OEEDisplayControl();
            this.pnlBorder.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
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
            // btnDataEntry
            // 
            this.btnDataEntry.BackColor = System.Drawing.Color.Transparent;
            this.btnDataEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDataEntry.BackgroundImage")));
            this.btnDataEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDataEntry.FlatAppearance.BorderSize = 0;
            this.btnDataEntry.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDataEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDataEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDataEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataEntry.Location = new System.Drawing.Point(4, -3);
            this.btnDataEntry.Name = "btnDataEntry";
            this.btnDataEntry.Size = new System.Drawing.Size(76, 76);
            this.btnDataEntry.TabIndex = 6;
            this.btnDataEntry.Tag = "Neweksportreport";
            this.toolTip.SetToolTip(this.btnDataEntry, "Opdater");
            this.btnDataEntry.UseVisualStyleBackColor = false;
            this.btnDataEntry.Click += new System.EventHandler(this.OnDataEntry);
            this.btnDataEntry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnDataEntry.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnAddStop
            // 
            this.btnAddStop.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddStop.BackgroundImage")));
            this.btnAddStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStop.FlatAppearance.BorderSize = 0;
            this.btnAddStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAddStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStop.Location = new System.Drawing.Point(0, -3);
            this.btnAddStop.Name = "btnAddStop";
            this.btnAddStop.Size = new System.Drawing.Size(76, 76);
            this.btnAddStop.TabIndex = 7;
            this.btnAddStop.Tag = "Delete";
            this.toolTip.SetToolTip(this.btnAddStop, "Tilføj stop");
            this.btnAddStop.UseVisualStyleBackColor = false;
            this.btnAddStop.Click += new System.EventHandler(this.OnNewProductionStop);
            this.btnAddStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnAddStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(82, -4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(76, 76);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Tag = "Sendreports";
            this.toolTip.SetToolTip(this.btnPrint, "Print");
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.OnPrint);
            this.btnPrint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnPrint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.pnlDisplay.Controls.Add(this.ucDisplay);
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 70);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(798, 335);
            this.pnlDisplay.TabIndex = 19;
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
            this.pnlToolbarRight.Controls.Add(this.bthMinimize);
            this.pnlToolbarRight.Controls.Add(this.btnAddStop);
            this.pnlToolbarRight.Controls.Add(this.btnPrint);
            this.pnlToolbarRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlToolbarRight.Location = new System.Drawing.Point(523, 0);
            this.pnlToolbarRight.Name = "pnlToolbarRight";
            this.pnlToolbarRight.Size = new System.Drawing.Size(275, 75);
            this.pnlToolbarRight.TabIndex = 11;
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
            this.bthMinimize.Location = new System.Drawing.Point(191, -4);
            this.bthMinimize.Name = "bthMinimize";
            this.bthMinimize.Size = new System.Drawing.Size(76, 76);
            this.bthMinimize.TabIndex = 11;
            this.bthMinimize.Tag = "Sendreports";
            this.toolTip.SetToolTip(this.bthMinimize, "Minimer");
            this.bthMinimize.UseVisualStyleBackColor = false;
            this.bthMinimize.Click += new System.EventHandler(this.OnMinimize);
            this.bthMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.bthMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.pnlToolbarLeft.Controls.Add(this.btnDataEntry);
            this.pnlToolbarLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlToolbarLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbarLeft.Name = "pnlToolbarLeft";
            this.pnlToolbarLeft.Size = new System.Drawing.Size(211, 75);
            this.pnlToolbarLeft.TabIndex = 11;
            // 
            // ucDisplay
            // 
            this.ucDisplay.BackColor = System.Drawing.Color.Transparent;
            this.ucDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDisplay.Location = new System.Drawing.Point(0, 0);
            this.ucDisplay.Name = "ucDisplay";
            this.ucDisplay.Size = new System.Drawing.Size(798, 335);
            this.ucDisplay.TabIndex = 0;
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(80)))), ((int)(((byte)(83)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataEntryForm";
            this.Tag = "";
            this.Text = "Data Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnLoad);
            this.pnlBorder.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnDataEntry;
        private System.Windows.Forms.Button btnAddStop;
        private System.Windows.Forms.Button btnPrint;
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
        private OEEDisplayControl ucDisplay;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.Button bthMinimize;
        private System.Windows.Forms.ToolTip toolTip;  
    }
}