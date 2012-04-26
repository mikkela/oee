namespace Mikadocs.OEE.ManagementConsole
{
    partial class AddNewProductionStopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewProductionStopForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.txtProductionStopName = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(2, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(239, 25);
            this.lblHeader.TabIndex = 53;
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
            this.btnAccept.Location = new System.Drawing.Point(263, 97);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(50, 50);
            this.btnAccept.TabIndex = 51;
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
            this.btnDecline.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDecline.FlatAppearance.BorderSize = 0;
            this.btnDecline.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDecline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDecline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.Location = new System.Drawing.Point(265, -1);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(50, 50);
            this.btnDecline.TabIndex = 52;
            this.toolTip.SetToolTip(this.btnDecline, "Fortryd");
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnDecline.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(7, 62);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(234, 48);
            this.lblText.TabIndex = 54;
            this.lblText.Text = "Please enter the name of the new stop";
            // 
            // txtProductionStopName
            // 
            this.txtProductionStopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionStopName.Location = new System.Drawing.Point(10, 113);
            this.txtProductionStopName.Name = "txtProductionStopName";
            this.txtProductionStopName.Size = new System.Drawing.Size(100, 22);
            this.txtProductionStopName.TabIndex = 55;
            // 
            // AddNewProductionStopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(325, 148);
            this.ControlBox = false;
            this.Controls.Add(this.txtProductionStopName);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnDecline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewProductionStopForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtProductionStopName;
        private System.Windows.Forms.ToolTip toolTip;
    }
}