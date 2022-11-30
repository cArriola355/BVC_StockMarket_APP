
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.companySelection1 = new BVC_StockMarket_APP.companySelection();
            this.radioBtnDaily = new System.Windows.Forms.RadioButton();
            this.radioBtnMonthly = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btnWatch.Location = new System.Drawing.Point(77, 322);
            this.btnWatch.Margin = new System.Windows.Forms.Padding(2);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(57, 22);
            this.btnWatch.TabIndex = 3;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // panelChart
            // 
            this.panelChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChart.Location = new System.Drawing.Point(204, 41);
            this.panelChart.Margin = new System.Windows.Forms.Padding(2);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(450, 417);
            this.panelChart.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BVC_StockMarket_APP.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(18, 428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(32, 429);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
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
            // 
            // companySelection1
            // 
            this.companySelection1.BackColor = System.Drawing.Color.White;
            this.companySelection1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companySelection1.Location = new System.Drawing.Point(9, 8);
            this.companySelection1.Margin = new System.Windows.Forms.Padding(6);
            this.companySelection1.Name = "companySelection1";
            this.companySelection1.selectedSymbol = null;
            this.companySelection1.Size = new System.Drawing.Size(188, 450);
            this.companySelection1.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.companySelection1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companySelection companySelection1;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnDaily;
        private System.Windows.Forms.RadioButton radioBtnMonthly;
        private System.Windows.Forms.Panel panel2;
    }
}

