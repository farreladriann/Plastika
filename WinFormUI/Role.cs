using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI;

namespace AddProdukdanSampah
{
    public partial class Role : Form
    {
        
        public Role()
        {
            InitializeComponent();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbVendor.Checked || rbAgenSampah.Checked)
            {
                string selectedRole = rbVendor.Checked ? "Vendor Produk" : "Agen Sampah";
                Register registerForm = new Register(selectedRole);
                this.Hide();
                registerForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Silakan pilih salah satu role.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                // Set warna dan style untuk semua radio buttons
                foreach (RadioButton radioBtn in new[] { rbVendor, rbAgenSampah })
                {
                    if (radioBtn == rb && rb.Checked)
                    {
                        // Style untuk radio button yang dipilih
                        radioBtn.ForeColor = System.Drawing.Color.White;
                        radioBtn.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
                        radioBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(39, 174, 96);
                        radioBtn.Font = new Font("Segoe UI", 10.2f, FontStyle.Bold);

                        // Tambahkan ikon centang (jika menggunakan font Segoe UI)
                        radioBtn.Text = $"✓  {rb.Text.Replace("✓  ", "").Replace("◯  ", "")}";

                        // Enable tombol Next
                        btnNext.Enabled = true;
                        btnNext.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
                        btnNext.Cursor = Cursors.Hand;

                        // Efek visual saat dipilih
                        RadioButtonSelectedEffect(radioBtn);
                    }
                    else
                    {
                        // Style untuk radio button yang tidak dipilih
                        radioBtn.ForeColor = System.Drawing.Color.FromArgb(52, 86, 69);
                        radioBtn.BackColor = System.Drawing.Color.White;
                        radioBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(39, 174, 96);
                        radioBtn.Font = new Font("Segoe UI", 10.2f, FontStyle.Regular);

                        // Tambahkan ikon lingkaran kosong
                        radioBtn.Text = $"◯  {radioBtn.Text.Replace("✓  ", "").Replace("◯  ", "")}";
                    }
                }
            }
        }

        private void RadioButtonSelectedEffect(RadioButton rb)
        {
            // Animasi sederhana saat dipilih
            Timer animationTimer = new Timer();
            int pulseCount = 0;
            int originalWidth = rb.Width;
            int originalHeight = rb.Height;

            animationTimer.Interval = 50;
            animationTimer.Tick += (s, e) =>
            {
                pulseCount++;
                switch (pulseCount)
                {
                    case 1:
                        rb.Padding = new Padding(5); // Efek "shrink"
                        break;
                    case 2:
                        rb.Padding = new Padding(0); // Kembali ke ukuran normal
                        animationTimer.Stop();
                        animationTimer.Dispose();
                        break;
                }
            };
            animationTimer.Start();

            // Tambahan tooltip informasi
            string tooltipText = rb.Name == "rbVendor" ?
                "Anda akan dapat menjual produk daur ulang" :
                "Anda akan dapat mengumpulkan dan menjual sampah";

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(rb, tooltipText);
            tooltip.ShowAlways = true;
        }
    }
}
