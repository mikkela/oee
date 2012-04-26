namespace Mikadocs.OEE.DataEntry
{
    partial class TimeEntryUserControl
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
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.minutesTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel.ColumnCount = 4;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.Controls.Add(this.minutesTextBox, 2, 0);
            this.tablePanel.Controls.Add(this.hoursTextBox, 0, 0);
            this.tablePanel.Controls.Add(this.label1, 1, 0);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 0);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 1;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel.Size = new System.Drawing.Size(314, 27);
            this.tablePanel.TabIndex = 0;
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.minutesTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.minutesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.minutesTextBox.Location = new System.Drawing.Point(160, 3);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(131, 23);
            this.minutesTextBox.TabIndex = 2;
            this.minutesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTextBoxKeyPressed);
            this.minutesTextBox.Enter += new System.EventHandler(this.OnTextBoxEnter);
            this.minutesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingMinutes);
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.hoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.hoursTextBox.Location = new System.Drawing.Point(3, 3);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(131, 23);
            this.hoursTextBox.TabIndex = 0;
            this.hoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTextBoxKeyPressed);
            this.hoursTextBox.Enter += new System.EventHandler(this.OnTextBoxEnter);
            this.hoursTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingHour);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(140, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TimeEntryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel);
            this.Name = "TimeEntryUserControl";
            this.Size = new System.Drawing.Size(314, 27);
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minutesTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}
