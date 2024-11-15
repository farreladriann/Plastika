namespace AddProdukdanProduk
{
    partial class TambahProduk
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNamaProduk = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.tbDeskripsiProduk = new System.Windows.Forms.TextBox();
            this.btnTambahProduk = new System.Windows.Forms.Button();
            this.btnUploadFotoProduk = new System.Windows.Forms.Button();
            this.pbFotoProduk = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKuantitasProduk = new System.Windows.Forms.TextBox();
            this.lblKuantitas = new System.Windows.Forms.Label();
            this.tbFotoProduk = new System.Windows.Forms.TextBox();
            this.tbHargaProduk = new System.Windows.Forms.TextBox();
            this.lblHargaSatuan = new System.Windows.Forms.Label();
            this.lblKategoriProduk = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProduk)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.Controls.Add(this.tbNamaProduk, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnKembali, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.tbDeskripsiProduk, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTambahProduk, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnUploadFotoProduk, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pbFotoProduk, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbKuantitasProduk, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblKuantitas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbFotoProduk, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbHargaProduk, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHargaSatuan, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblKategoriProduk, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.90244F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.09756F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tbNamaProduk
            // 
            this.tbNamaProduk.Location = new System.Drawing.Point(235, 3);
            this.tbNamaProduk.Name = "tbNamaProduk";
            this.tbNamaProduk.Size = new System.Drawing.Size(184, 22);
            this.tbNamaProduk.TabIndex = 14;
            // 
            // btnKembali
            // 
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(631, 386);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(134, 52);
            this.btnKembali.TabIndex = 17;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // tbDeskripsiProduk
            // 
            this.tbDeskripsiProduk.Location = new System.Drawing.Point(235, 49);
            this.tbDeskripsiProduk.Name = "tbDeskripsiProduk";
            this.tbDeskripsiProduk.Size = new System.Drawing.Size(184, 22);
            this.tbDeskripsiProduk.TabIndex = 16;
            // 
            // btnTambahProduk
            // 
            this.btnTambahProduk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahProduk.Location = new System.Drawing.Point(467, 386);
            this.btnTambahProduk.Name = "btnTambahProduk";
            this.btnTambahProduk.Size = new System.Drawing.Size(134, 52);
            this.btnTambahProduk.TabIndex = 9;
            this.btnTambahProduk.Text = "Tambah";
            this.btnTambahProduk.UseVisualStyleBackColor = true;
            this.btnTambahProduk.Click += new System.EventHandler(this.btnTambahProduk_Click);
            // 
            // btnUploadFotoProduk
            // 
            this.btnUploadFotoProduk.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFotoProduk.Location = new System.Drawing.Point(3, 181);
            this.btnUploadFotoProduk.Name = "btnUploadFotoProduk";
            this.btnUploadFotoProduk.Size = new System.Drawing.Size(171, 41);
            this.btnUploadFotoProduk.TabIndex = 10;
            this.btnUploadFotoProduk.Text = "Upload Foto";
            this.btnUploadFotoProduk.UseVisualStyleBackColor = true;
            this.btnUploadFotoProduk.Click += new System.EventHandler(this.btnUploadFotoProduk_Click);
            // 
            // pbFotoProduk
            // 
            this.pbFotoProduk.Location = new System.Drawing.Point(235, 229);
            this.pbFotoProduk.Name = "pbFotoProduk";
            this.pbFotoProduk.Size = new System.Drawing.Size(225, 117);
            this.pbFotoProduk.TabIndex = 8;
            this.pbFotoProduk.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Deskripsi: ";
            // 
            // tbKuantitasProduk
            // 
            this.tbKuantitasProduk.Location = new System.Drawing.Point(235, 107);
            this.tbKuantitasProduk.Name = "tbKuantitasProduk";
            this.tbKuantitasProduk.Size = new System.Drawing.Size(184, 22);
            this.tbKuantitasProduk.TabIndex = 5;
            // 
            // lblKuantitas
            // 
            this.lblKuantitas.AutoSize = true;
            this.lblKuantitas.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKuantitas.Location = new System.Drawing.Point(3, 104);
            this.lblKuantitas.Name = "lblKuantitas";
            this.lblKuantitas.Size = new System.Drawing.Size(120, 31);
            this.lblKuantitas.TabIndex = 1;
            this.lblKuantitas.Text = "Kuantitas: ";
            // 
            // tbFotoProduk
            // 
            this.tbFotoProduk.Location = new System.Drawing.Point(235, 181);
            this.tbFotoProduk.Name = "tbFotoProduk";
            this.tbFotoProduk.Size = new System.Drawing.Size(225, 22);
            this.tbFotoProduk.TabIndex = 7;
            // 
            // tbHargaProduk
            // 
            this.tbHargaProduk.Location = new System.Drawing.Point(235, 142);
            this.tbHargaProduk.Name = "tbHargaProduk";
            this.tbHargaProduk.Size = new System.Drawing.Size(184, 22);
            this.tbHargaProduk.TabIndex = 6;
            // 
            // lblHargaSatuan
            // 
            this.lblHargaSatuan.AutoSize = true;
            this.lblHargaSatuan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaSatuan.Location = new System.Drawing.Point(3, 139);
            this.lblHargaSatuan.Name = "lblHargaSatuan";
            this.lblHargaSatuan.Size = new System.Drawing.Size(163, 31);
            this.lblHargaSatuan.TabIndex = 2;
            this.lblHargaSatuan.Text = "Harga Satuan: ";
            // 
            // lblKategoriProduk
            // 
            this.lblKategoriProduk.AutoSize = true;
            this.lblKategoriProduk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategoriProduk.Location = new System.Drawing.Point(3, 0);
            this.lblKategoriProduk.Name = "lblKategoriProduk";
            this.lblKategoriProduk.Size = new System.Drawing.Size(189, 31);
            this.lblKategoriProduk.TabIndex = 0;
            this.lblKategoriProduk.Text = "Kategori Produk: ";
            // 
            // TambahProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TambahProduk";
            this.Text = "TambahProducts";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbNamaProduk;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.TextBox tbDeskripsiProduk;
        private System.Windows.Forms.Button btnTambahProduk;
        private System.Windows.Forms.Button btnUploadFotoProduk;
        private System.Windows.Forms.PictureBox pbFotoProduk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKuantitasProduk;
        private System.Windows.Forms.Label lblKuantitas;
        private System.Windows.Forms.TextBox tbFotoProduk;
        private System.Windows.Forms.TextBox tbHargaProduk;
        private System.Windows.Forms.Label lblHargaSatuan;
        private System.Windows.Forms.Label lblKategoriProduk;
    }
}