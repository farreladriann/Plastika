﻿namespace AddProdukdanSampah
{
    partial class HalamanUtamaNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanUtamaNew));
            this.flpHalamanUtama = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pbMaps = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaps)).BeginInit();
            this.SuspendLayout();
            // 
            // flpHalamanUtama
            // 
            this.flpHalamanUtama.AutoScroll = true;
            this.flpHalamanUtama.Location = new System.Drawing.Point(33, 97);
            this.flpHalamanUtama.Name = "flpHalamanUtama";
            this.flpHalamanUtama.Size = new System.Drawing.Size(733, 298);
            this.flpHalamanUtama.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(33, 34);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(211, 22);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Search";
            // 
            // pbMaps
            // 
            this.pbMaps.Image = ((System.Drawing.Image)(resources.GetObject("pbMaps.Image")));
            this.pbMaps.Location = new System.Drawing.Point(473, 34);
            this.pbMaps.Name = "pbMaps";
            this.pbMaps.Size = new System.Drawing.Size(45, 44);
            this.pbMaps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaps.TabIndex = 1;
            this.pbMaps.TabStop = false;
            this.pbMaps.Click += new System.EventHandler(this.pbMaps_Click);
            // 
            // HalamanUtamaNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbMaps);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.flpHalamanUtama);
            this.Name = "HalamanUtamaNew";
            this.Text = "HalamanUtamaNew";
            ((System.ComponentModel.ISupportInitialize)(this.pbMaps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpHalamanUtama;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox pbMaps;
    }
}