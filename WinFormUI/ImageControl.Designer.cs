namespace AddProdukdanSampah
{
    partial class FotoSampahControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FotoSampahControl));
            this.pbSampahCtrl = new System.Windows.Forms.PictureBox();
            this.lblNamaSampahCtrl = new System.Windows.Forms.Label();
            this.lblHargaSampahCtrl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSampahCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSampahCtrl
            // 
            this.pbSampahCtrl.Image = ((System.Drawing.Image)(resources.GetObject("pbSampahCtrl.Image")));
            this.pbSampahCtrl.Location = new System.Drawing.Point(31, 13);
            this.pbSampahCtrl.Name = "pbSampahCtrl";
            this.pbSampahCtrl.Size = new System.Drawing.Size(182, 180);
            this.pbSampahCtrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSampahCtrl.TabIndex = 0;
            this.pbSampahCtrl.TabStop = false;
            // 
            // lblNamaSampahCtrl
            // 
            this.lblNamaSampahCtrl.AutoSize = true;
            this.lblNamaSampahCtrl.Location = new System.Drawing.Point(17, 221);
            this.lblNamaSampahCtrl.Name = "lblNamaSampahCtrl";
            this.lblNamaSampahCtrl.Size = new System.Drawing.Size(98, 16);
            this.lblNamaSampahCtrl.TabIndex = 1;
            this.lblNamaSampahCtrl.Text = "Nama Sampah";
            // 
            // lblHargaSampahCtrl
            // 
            this.lblHargaSampahCtrl.AutoSize = true;
            this.lblHargaSampahCtrl.Location = new System.Drawing.Point(154, 221);
            this.lblHargaSampahCtrl.Name = "lblHargaSampahCtrl";
            this.lblHargaSampahCtrl.Size = new System.Drawing.Size(45, 16);
            this.lblHargaSampahCtrl.TabIndex = 2;
            this.lblHargaSampahCtrl.Text = "Harga";
            // 
            // FotoSampahControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHargaSampahCtrl);
            this.Controls.Add(this.lblNamaSampahCtrl);
            this.Controls.Add(this.pbSampahCtrl);
            this.Name = "FotoSampahControl";
            this.Size = new System.Drawing.Size(244, 259);
            ((System.ComponentModel.ISupportInitialize)(this.pbSampahCtrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSampahCtrl;
        private System.Windows.Forms.Label lblNamaSampahCtrl;
        private System.Windows.Forms.Label lblHargaSampahCtrl;
    }
}
