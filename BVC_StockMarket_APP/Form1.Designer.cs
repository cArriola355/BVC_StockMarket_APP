
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnDaily = new System.Windows.Forms.RadioButton();
            this.radioBtnMonthly = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxHelp = new System.Windows.Forms.PictureBox();
            this.picBoxInfo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.companySelection1 = new BVC_StockMarket_APP.companySelection();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSymbol
            // 
            this.lblSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(2, 2);
            this.lblSymbol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(0, 25);
            this.lblSymbol.TabIndex = 2;
            this.lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWatch
            // 
            this.btnWatch.BackColor = System.Drawing.Color.White;
            this.btnWatch.Location = new System.Drawing.Point(77, 322);
            this.btnWatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(57, 22);
            this.btnWatch.TabIndex = 3;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = false;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.White;
            this.panelChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChart.Location = new System.Drawing.Point(204, 41);
            this.panelChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(450, 469);
            this.panelChart.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSymbol);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(204, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 30);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioBtnDaily
            // 
            this.radioBtnDaily.AutoSize = true;
            this.radioBtnDaily.Location = new System.Drawing.Point(23, 6);
            this.radioBtnDaily.Name = "radioBtnDaily";
            this.radioBtnDaily.Size = new System.Drawing.Size(48, 17);
            this.radioBtnDaily.TabIndex = 8;
            this.radioBtnDaily.TabStop = true;
            this.radioBtnDaily.Text = "Daily";
            this.radioBtnDaily.UseVisualStyleBackColor = true;
            this.radioBtnDaily.CheckedChanged += new System.EventHandler(this.radioBtnDaily_CheckedChanged);
            // 
            // radioBtnMonthly
            // 
            this.radioBtnMonthly.AutoSize = true;
            this.radioBtnMonthly.Location = new System.Drawing.Point(23, 29);
            this.radioBtnMonthly.Name = "radioBtnMonthly";
            this.radioBtnMonthly.Size = new System.Drawing.Size(62, 17);
            this.radioBtnMonthly.TabIndex = 9;
            this.radioBtnMonthly.TabStop = true;
            this.radioBtnMonthly.Text = "Monthly";
            this.radioBtnMonthly.UseVisualStyleBackColor = true;
            this.radioBtnMonthly.CheckedChanged += new System.EventHandler(this.radioBtnMonthly_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioBtnDaily);
            this.panel2.Controls.Add(this.radioBtnMonthly);
            this.panel2.Location = new System.Drawing.Point(48, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 53);
            this.panel2.TabIndex = 10;
            // 
            // picBoxHelp
            // 
            this.picBoxHelp.Image = global::BVC_StockMarket_APP.Properties.Resources.help;
            this.picBoxHelp.Location = new System.Drawing.Point(98, 5);
            this.picBoxHelp.Name = "picBoxHelp";
            this.picBoxHelp.Size = new System.Drawing.Size(20, 20);
            this.picBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHelp.TabIndex = 11;
            this.picBoxHelp.TabStop = false;
            this.picBoxHelp.Click += new System.EventHandler(this.picBoxHelp_Click);
            // 
            // picBoxInfo
            // 
            this.picBoxInfo.Image = global::BVC_StockMarket_APP.Properties.Resources.info;
            this.picBoxInfo.Location = new System.Drawing.Point(72, 5);
            this.picBoxInfo.Name = "picBoxInfo";
            this.picBoxInfo.Size = new System.Drawing.Size(20, 20);
            this.picBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxInfo.TabIndex = 5;
            this.picBoxInfo.TabStop = false;
            this.picBoxInfo.Click += new System.EventHandler(this.picBoxInfo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(142)))), ((int)(((byte)(36)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.picBoxInfo);
            this.panel3.Controls.Add(this.picBoxHelp);
            this.panel3.Location = new System.Drawing.Point(9, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 30);
            this.panel3.TabIndex = 12;
            // 
            // companySelection1
            // 
            this.companySelection1.BackColor = System.Drawing.Color.White;
            this.companySelection1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companySelection1.Location = new System.Drawing.Point(9, 8);
            this.companySelection1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.companySelection1.Name = "companySelection1";
            this.companySelection1.selectedSymbol = null;
            this.companySelection1.Size = new System.Drawing.Size(188, 502);
            this.companySelection1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 517);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.companySelection1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private companySelection companySelection1;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.PictureBox picBoxInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnDaily;
        private System.Windows.Forms.RadioButton radioBtnMonthly;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBoxHelp;
        private System.Windows.Forms.Panel panel3;
    }
}

