
namespace BVC_StockMarket_APP
{
    partial class Form1
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
            this.lblSymbol = new System.Windows.Forms.Label();
            this.btnWatch = new System.Windows.Forms.Button();
            this.panelChart = new System.Windows.Forms.Panel();
            this.companySelection1 = new BVC_StockMarket_APP.companySelection();
            this.SuspendLayout();
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(668, 15);
            this.lblSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(126, 46);
            this.lblSymbol.TabIndex = 2;
            this.lblSymbol.Text = "label1";
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(144, 492);
            this.btnWatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(114, 42);
            this.btnWatch.TabIndex = 3;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // panelChart
            // 
            this.panelChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChart.Location = new System.Drawing.Point(439, 78);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(648, 531);
            this.panelChart.TabIndex = 4;
            // 
            // companySelection1
            // 
            this.companySelection1.BackColor = System.Drawing.Color.White;
            this.companySelection1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companySelection1.Location = new System.Drawing.Point(26, 15);
            this.companySelection1.Margin = new System.Windows.Forms.Padding(12);
            this.companySelection1.Name = "companySelection1";
            this.companySelection1.selectedSymbol = null;
            this.companySelection1.Size = new System.Drawing.Size(374, 594);
            this.companySelection1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 663);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.companySelection1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companySelection companySelection1;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Panel panelChart;
    }
}

