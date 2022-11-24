
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
            this.companySelection1 = new BVC_StockMarket_APP.companySelection();
            this.mainChart1 = new BVC_StockMarket_APP.MainChart();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.btnWatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companySelection1
            // 
            this.companySelection1.BackColor = System.Drawing.Color.White;
            this.companySelection1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companySelection1.Location = new System.Drawing.Point(26, 15);
            this.companySelection1.Margin = new System.Windows.Forms.Padding(6);
            this.companySelection1.Name = "companySelection1";
            this.companySelection1.selectedSymbol = null;
            this.companySelection1.Size = new System.Drawing.Size(374, 551);
            this.companySelection1.TabIndex = 0;
            // 
            // mainChart1
            // 
            this.mainChart1.Location = new System.Drawing.Point(414, 60);
            this.mainChart1.Name = "mainChart1";
            this.mainChart1.Size = new System.Drawing.Size(650, 550);
            this.mainChart1.TabIndex = 1;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(409, 15);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(70, 25);
            this.lblSymbol.TabIndex = 2;
            this.lblSymbol.Text = "label1";
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(145, 493);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(114, 42);
            this.btnWatch.TabIndex = 3;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 622);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.mainChart1);
            this.Controls.Add(this.companySelection1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companySelection companySelection1;
        private MainChart mainChart1;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Button btnWatch;
    }
}

