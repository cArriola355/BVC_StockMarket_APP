
namespace BVC_StockMarket_APP
{
    partial class companySelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(companySelection));
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.listBoxBestMatches = new System.Windows.Forms.ListBox();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.InitialImage")));
            this.picBoxLogo.Location = new System.Drawing.Point(78, 38);
            this.picBoxLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(214, 110);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(92, 221);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(172, 25);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search a symbol";
            // 
            // listBoxBestMatches
            // 
            this.listBoxBestMatches.FormattingEnabled = true;
            this.listBoxBestMatches.ItemHeight = 25;
            this.listBoxBestMatches.Location = new System.Drawing.Point(72, 298);
            this.listBoxBestMatches.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxBestMatches.Name = "listBoxBestMatches";
            this.listBoxBestMatches.Size = new System.Drawing.Size(214, 154);
            this.listBoxBestMatches.TabIndex = 11;
            this.listBoxBestMatches.SelectedIndexChanged += new System.EventHandler(this.listBoxBestMatches_SelectedIndexChanged);
            // 
            // tboxSearch
            // 
            this.tboxSearch.Location = new System.Drawing.Point(72, 250);
            this.tboxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(214, 31);
            this.tboxSearch.TabIndex = 10;
            this.tboxSearch.TextChanged += new System.EventHandler(this.tboxSearch_TextChanged);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.picBoxLogo);
            this.panelLogo.Location = new System.Drawing.Point(-2, 15);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(380, 190);
            this.panelLogo.TabIndex = 9;
            // 
            // companySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.listBoxBestMatches);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.panelLogo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "companySelection";
            this.Size = new System.Drawing.Size(374, 529);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListBox listBoxBestMatches;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Panel panelLogo;
    }
}
