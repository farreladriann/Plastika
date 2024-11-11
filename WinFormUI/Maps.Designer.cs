namespace AddProdukdanSampah
{
    partial class Maps
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
            this.wbvMaps = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wbvMaps)).BeginInit();
            this.SuspendLayout();
            // 
            // wbvMaps
            // 
            this.wbvMaps.AllowExternalDrop = true;
            this.wbvMaps.CreationProperties = null;
            this.wbvMaps.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbvMaps.Location = new System.Drawing.Point(0, 2);
            this.wbvMaps.Name = "wbvMaps";
            this.wbvMaps.Size = new System.Drawing.Size(788, 439);
            this.wbvMaps.TabIndex = 0;
            this.wbvMaps.ZoomFactor = 1D;
            // 
            // btnKembali
            // 
            this.btnKembali.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(0, 392);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(789, 50);
            this.btnKembali.TabIndex = 2;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // Maps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 442);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.wbvMaps);
            this.Name = "Maps";
            this.Text = "Maps";
            ((System.ComponentModel.ISupportInitialize)(this.wbvMaps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wbvMaps;
        private System.Windows.Forms.Button btnKembali;
    }
}