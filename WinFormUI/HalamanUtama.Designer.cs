namespace AddProdukdanSampah
{
    partial class HalamanUtama
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
            this.pbHasilSampah = new System.Windows.Forms.PictureBox();
            this.lblHasilSampah = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHasilSampah)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHasilSampah
            // 
            this.pbHasilSampah.Location = new System.Drawing.Point(49, 124);
            this.pbHasilSampah.Name = "pbHasilSampah";
            this.pbHasilSampah.Size = new System.Drawing.Size(184, 159);
            this.pbHasilSampah.TabIndex = 0;
            this.pbHasilSampah.TabStop = false;
            
            // 
            // lblHasilSampah
            // 
            this.lblHasilSampah.AutoSize = true;
            this.lblHasilSampah.Location = new System.Drawing.Point(46, 299);
            this.lblHasilSampah.Name = "lblHasilSampah";
            this.lblHasilSampah.Size = new System.Drawing.Size(44, 16);
            this.lblHasilSampah.TabIndex = 1;
            this.lblHasilSampah.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Halaman Utama";
            // 
            // HalamanUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHasilSampah);
            this.Controls.Add(this.pbHasilSampah);
            this.Name = "HalamanUtama";
            this.Text = "HalamanUtama";
            ((System.ComponentModel.ISupportInitialize)(this.pbHasilSampah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHasilSampah;
        private System.Windows.Forms.Label lblHasilSampah;
        private System.Windows.Forms.Label label1;
    }
}