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

namespace AddProdukdanSampah
{
    public partial class HalamanUtamaNew : Form
    {
        public HalamanUtamaNew()
        {
            InitializeComponent();
            LoadData(); // Panggil LoadData di sini
        }

        private void LoadData()
        {
            var trashes = DatabaseHelper.GetTrashes(); // Ambil data sampah dari database

            if (trashes == null || trashes.Count == 0)
            {
                MessageBox.Show("Tidak ada data sampah untuk ditampilkan.", "Info");
                return;
            }

            foreach (var trash in trashes)
            {
                // Buat panel untuk setiap item
                Panel panel = new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(200, 300), // Sesuaikan ukuran panel
                    Margin = new Padding(10)
                };

                // Gambar sampah
                PictureBox pic = new PictureBox();
                if (trash.Trash_Image != null)
                {
                    using (var ms = new MemoryStream(trash.Trash_Image))
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                }
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Size = new Size(180, 180); // Sesuaikan ukuran PictureBox
                pic.Click += (s, e) => { NavigateToOrderPage(trash.Id_Trash); };
                panel.Controls.Add(pic);

                // Tambahkan nama
                Label lblName = new Label
                {
                    Text = trash.Trash_Name,
                    Location = new Point(10, 190),
                    AutoSize = true
                };
                panel.Controls.Add(lblName);

                // Tambahkan harga
                Label lblPrice = new Label
                {
                    Text = trash.Price.ToString("C"),
                    Location = new Point(10, 220),
                    AutoSize = true
                };
                panel.Controls.Add(lblPrice);

                // Tambahkan panel ke FlowLayoutPanel
                flpHalamanUtama.Controls.Add(panel);
            }
        }

        private void NavigateToOrderPage(int trashId)
        {
            // Implementasi navigasi ke halaman pemesanan
            //var orderForm = new OrderForm(trashId);
            //orderForm.Show();
        }

        private void pbMaps_Click(object sender, EventArgs e)
        {
            this.Hide();
            var maps = new Maps();
            maps.Show();
        }
    }
}
