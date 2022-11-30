
namespace BVC_StockMarket_APP
{
    partial class MainChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSeries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblOverview = new System.Windows.Forms.Label();
            this.tableData = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSeries
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSeries.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSeries.Legends.Add(legend1);
            this.chartSeries.Location = new System.Drawing.Point(28, 40);
            this.chartSeries.Margin = new System.Windows.Forms.Padding(6);
            this.chartSeries.Name = "chartSeries";
            this.chartSeries.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Close";
            this.chartSeries.Series.Add(series1);
            this.chartSeries.Size = new System.Drawing.Size(594, 246);
            this.chartSeries.TabIndex = 27;
            this.chartSeries.Text = "chart1";
            // 
            // lblOverview
            // 
            this.lblOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOverview.Location = new System.Drawing.Point(28, 292);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(594, 139);
            this.lblOverview.TabIndex = 28;
            this.lblOverview.Click += new System.EventHandler(this.lblOverview_Click);
            // 
            // tableData
            // 
            this.tableData.ColumnCount = 2;
            this.tableData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableData.Location = new System.Drawing.Point(28, 435);
            this.tableData.Name = "tableData";
            this.tableData.RowCount = 2;
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableData.Size = new System.Drawing.Size(594, 194);
            this.tableData.TabIndex = 29;
            // 
            // MainChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableData);
            this.Controls.Add(this.lblOverview);
            this.Controls.Add(this.chartSeries);
            this.Name = "MainChart";
            this.Size = new System.Drawing.Size(648, 657);
            this.Load += new System.EventHandler(this.MainChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSeries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSeries;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.TableLayoutPanel tableData;
    }
}
