using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using DotNetEnv;
using System.Configuration;

namespace AddProdukdanSampah
{
    public partial class TambahSampah : Form
    {
        private HalamanUtamaNew mainForm;
        private string currentUsername;
        private int currentAccountId;
        

        public TambahSampah(string username, int accountId)
        {
            InitializeComponent();
            currentUsername = username;
            currentAccountId = accountId; // Simpan id_account
            
        }

        private void btnUploadFotoSampah_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                tbFotoSampah.Text = opf.FileName;
                pbFotoSampah.Image = new Bitmap(opf.FileName);
            }
        }



        private void btnTambahSampah_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbNamaSampah.Text;
                string description = tbDeskripsiSampah.Text;
                int quantity = int.Parse(tbKuantitasSampah.Text);
                long price = long.Parse(tbHargaSampah.Text);
                byte[] imageBytes = null;

                if (pbFotoSampah.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbFotoSampah.Image.Save(ms, pbFotoSampah.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

                Trashes newTrash = new Trashes(currentAccountId, name, description, quantity, price, imageBytes);

                Trashes.InsertTrash(newTrash, currentAccountId);

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
