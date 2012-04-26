namespace Mikadocs.OEE.CostCalculator
{
    partial class UCFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtPeriodStart = new System.Windows.Forms.DateTimePicker();
            this.dtPeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbMachines = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clbTeam = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            // 
            // dtPeriodStart
            // 
            this.dtPeriodStart.Location = new System.Drawing.Point(6, 35);
            this.dtPeriodStart.Name = "dtPeriodStart";
            this.dtPeriodStart.Size = new System.Drawing.Size(200, 20);
            this.dtPeriodStart.TabIndex = 1;
            // 
            // dtPeriodEnd
            // 
            this.dtPeriodEnd.Location = new System.Drawing.Point(225, 35);
            this.dtPeriodEnd.Name = "dtPeriodEnd";
            this.dtPeriodEnd.Size = new System.Drawing.Size(200, 20);
            this.dtPeriodEnd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maskiner";
            // 
            // clbMachines
            // 
            this.clbMachines.FormattingEnabled = true;
            this.clbMachines.Location = new System.Drawing.Point(6, 88);
            this.clbMachines.Name = "clbMachines";
            this.clbMachines.Size = new System.Drawing.Size(200, 169);
            this.clbMachines.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Skift";
            // 
            // clbTeam
            // 
            this.clbTeam.FormattingEnabled = true;
            this.clbTeam.Location = new System.Drawing.Point(225, 88);
            this.clbTeam.Name = "clbTeam";
            this.clbTeam.Size = new System.Drawing.Size(200, 169);
            this.clbTeam.TabIndex = 7;
            // 
            // UCFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clbTeam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clbMachines);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtPeriodEnd);
            this.Controls.Add(this.dtPeriodStart);
            this.Controls.Add(this.label1);
            this.Name = "UCFilter";
            this.Size = new System.Drawing.Size(435, 269);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPeriodStart;
        private System.Windows.Forms.DateTimePicker dtPeriodEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbMachines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbTeam;
    }
}
