
namespace BVC_StockMarket_APP
{
    partial class MaxChart
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
            this.panelMax = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelMax
            // 
            this.panelMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMax.Location = new System.Drawing.Point(0, 0);
            this.panelMax.Name = "panelMax";
            this.panelMax.Size = new System.Drawing.Size(569, 373);
            this.panelMax.TabIndex = 0;
            // 
            // MaxChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 373);
            this.Controls.Add(this.panelMax);
            this.Name = "MaxChart";
            this.Text = "MaxChart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMax;
    }
}