namespace Mikadocs.OEE.DataEntry
{
    partial class StatisticsDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsDetailsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.lblUpdateTime = new System.Windows.Forms.Label();
            this.lblProductionCounter = new System.Windows.Forms.Label();
            this.txtProductionCounter = new System.Windows.Forms.TextBox();
            this.lblDiscarded = new System.Windows.Forms.Label();
            this.txtDiscarded = new System.Windows.Forms.TextBox();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ucUpdateTime = new Mikadocs.OEE.DataEntry.TimeEntryUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ucUpdateTime);
            this.panel1.Controls.Add(this.dtUpdateDate);
            this.panel1.Controls.Add(this.lblUpdateTime);
            this.panel1.Controls.Add(this.lblProductionCounter);
            this.panel1.Controls.Add(this.txtProductionCounter);
            this.panel1.Controls.Add(this.lblDiscarded);
            this.panel1.Controls.Add(this.txtDiscarded);
            this.panel1.Controls.Add(this.lblUpdateDate);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.btnDecline);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 251);
            this.panel1.TabIndex = 1;
            // 
            // dtUpdateDate
            // 
            this.dtUpdateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dtUpdateDate.Location = new System.Drawing.Point(260, 56);
            this.dtUpdateDate.Name = "dtUpdateDate";
            this.dtUpdateDate.Size = new System.Drawing.Size(159, 23);
            this.dtUpdateDate.TabIndex = 2;
            // 
            // lblUpdateTime
            // 
            this.lblUpdateTime.AutoSize = true;
            this.lblUpdateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblUpdateTime.Location = new System.Drawing.Point(13, 93);
            this.lblUpdateTime.Name = "lblUpdateTime";
            this.lblUpdateTime.Size = new System.Drawing.Size(65, 16);
            this.lblUpdateTime.TabIndex = 3;
            this.lblUpdateTime.Text = ":Product";
            // 
            // lblProductionCounter
            // 
            this.lblProductionCounter.AutoSize = true;
            this.lblProductionCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionCounter.ForeColor = System.Drawing.Color.Transparent;
            this.lblProductionCounter.Location = new System.Drawing.Point(13, 127);
            this.lblProductionCounter.Name = "lblProductionCounter";
            this.lblProductionCounter.Size = new System.Drawing.Size(65, 16);
            this.lblProductionCounter.TabIndex = 5;
            this.lblProductionCounter.Text = ":Counter";
            // 
            // txtProductionCounter
            // 
            this.txtProductionCounter.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductionCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionCounter.Location = new System.Drawing.Point(260, 124);
            this.txtProductionCounter.Name = "txtProductionCounter";
            this.txtProductionCounter.Size = new System.Drawing.Size(100, 23);
            this.txtProductionCounter.TabIndex = 6;
            this.txtProductionCounter.Text = "0";
            this.txtProductionCounter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTextBoxKeyPressed);
            this.txtProductionCounter.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingProductionCounter);
            // 
            // lblDiscarded
            // 
            this.lblDiscarded.AutoSize = true;
            this.lblDiscarded.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscarded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscarded.ForeColor = System.Drawing.Color.Transparent;
            this.lblDiscarded.Location = new System.Drawing.Point(13, 161);
            this.lblDiscarded.Name = "lblDiscarded";
            this.lblDiscarded.Size = new System.Drawing.Size(83, 16);
            this.lblDiscarded.TabIndex = 7;
            this.lblDiscarded.Text = "Kasserede";
            // 
            // txtDiscarded
            // 
            this.txtDiscarded.BackColor = System.Drawing.SystemColors.Control;
            this.txtDiscarded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscarded.Location = new System.Drawing.Point(260, 158);
            this.txtDiscarded.Name = "txtDiscarded";
            this.txtDiscarded.Size = new System.Drawing.Size(100, 23);
            this.txtDiscarded.TabIndex = 8;
            this.txtDiscarded.Text = "0";
            this.txtDiscarded.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTextBoxKeyPressed);
            this.txtDiscarded.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingDiscardedItems);
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.AutoSize = true;
            this.lblUpdateDate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDate.ForeColor = System.Drawing.Color.Transparent;
            this.lblUpdateDate.Location = new System.Drawing.Point(13, 59);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(63, 16);
            this.lblUpdateDate.TabIndex = 1;
            this.lblUpdateDate.Text = ":Update";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(11, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(94, 25);
            this.lblHeader.TabIndex = 50;
            this.lblHeader.Tag = "";
            this.lblHeader.Text = ":Update";
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
            this.btnAccept.Location = new System.Drawing.Point(425, 193);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(50, 50);
            this.btnAccept.TabIndex = 11;
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
            this.btnDecline.Location = new System.Drawing.Point(425, 3);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(50, 50);
            this.btnDecline.TabIndex = 12;
            this.toolTip.SetToolTip(this.btnDecline, "Fortryd");
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnDecline.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ucUpdateTime
            // 
            this.ucUpdateTime.Location = new System.Drawing.Point(260, 85);
            this.ucUpdateTime.Name = "ucUpdateTime";
            this.ucUpdateTime.Size = new System.Drawing.Size(159, 27);
            this.ucUpdateTime.TabIndex = 4;
            this.ucUpdateTime.Value = System.TimeSpan.Parse("20:51:00");
            // 
            // StatisticsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(488, 251);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":NewExportReport";
            this.Load += new System.EventHandler(this.OnLoad);
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
        private System.Windows.Forms.Label lblUpdateDate;
        private System.Windows.Forms.Label lblDiscarded;
        private System.Windows.Forms.TextBox txtDiscarded;
        private System.Windows.Forms.Label lblProductionCounter;
        private System.Windows.Forms.TextBox txtProductionCounter;
        private System.Windows.Forms.Label lblUpdateTime;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dtUpdateDate;
        private TimeEntryUserControl ucUpdateTime;
        private System.Windows.Forms.ToolTip toolTip;
        
    }
}