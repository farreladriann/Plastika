using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using DotNetEnv;
using System.Configuration;
using AddProdukdanSampah;
using Guna.UI2.WinForms; // Added namespace

namespace AddProdukdanProduk
{
    public partial class TambahProduk : Form
    {
        private HalamanUtamaNew mainForm;
        private string currentUsername;
        private int currentAccountId;

        public TambahProduk(string username, int accountId)
        {
            InitializeComponent();
            currentUsername = username;
            currentAccountId = accountId; // Simpan id_account
            // Additional initialization if needed
        }

        private void btnUploadFotoProduk_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                tbFotoProduk.Text = opf.FileName;
                pbFotoProduk.Image = new Bitmap(opf.FileName);
            }
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbNamaProduk.Text;
                string description = tbDeskripsiProduk.Text;
                int quantity = int.Parse(tbKuantitasProduk.Text);
                long price = long.Parse(tbHargaProduk.Text);
                byte[] imageBytes = null;

                if (pbFotoProduk.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbFotoProduk.Image.Save(ms, pbFotoProduk.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

                Products newProduct = new Products(currentAccountId, name, description, quantity, price, imageBytes);

                Products.InsertProduct(newProduct, currentAccountId);

                MessageBox.Show("Data berhasil ditambahkan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!!");
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide(); // Kembali ke halaman utama
            HalamanUtamaNew halamanUtama = new HalamanUtamaNew(currentUsername);
            halamanUtama.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
