namespace WinFormUI
{
    partial class HalamanOrder
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
            this.picItemImage = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numKuantitas = new System.Windows.Forms.NumericUpDown();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnPesan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKuantitas)).BeginInit();
            this.SuspendLayout();
            // 
            // picItemImage
            // 
            this.picItemImage.Location = new System.Drawing.Point(55, 43);
            this.picItemImage.Name = "picItemImage";
            this.picItemImage.Size = new System.Drawing.Size(214, 172);
            this.picItemImage.TabIndex = 0;
            this.picItemImage.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(321, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "nama item";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(321, 84);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "deskripsi item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Harga per item:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(321, 172);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(87, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Harga item";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(576, 172);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(86, 20);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kuantitas:";
            // 
            // numKuantitas
            // 
            this.numKuantitas.Location = new System.Drawing.Point(155, 270);
            this.numKuantitas.Name = "numKuantitas";
            this.numKuantitas.Size = new System.Drawing.Size(120, 26);
            this.numKuantitas.TabIndex = 8;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(409, 286);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(116, 20);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "Total price item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total harga:";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(238, 352);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(111, 49);
            this.btnKembali.TabIndex = 11;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(434, 352);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(111, 49);
            this.btnPesan.TabIndex = 12;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // HalamanOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numKuantitas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picItemImage);
            this.Name = "HalamanOrder";
            this.Text = "HalamanOrder";
            ((System.ComponentModel.ISupportInitialize)(this.picItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKuantitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picItemImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numKuantitas;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnPesan;
    }
}