using AddProdukdanSampah;
using Microsoft.Web.WebView2.Core;
using Npgsql;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class HalamanPayment : Form
    {
        private readonly string _paymentUrl;
        private readonly Item _item;
        private readonly int _quantity;

        public HalamanPayment(string paymentUrl, Item item, int quantity)
        {
            InitializeComponent();
            _paymentUrl = paymentUrl;
            _item = item;
            _quantity = quantity;

            InitializeWebView();
        }

        private void InitializeWebView()
        {
            try
            {
                webView21.Source = new Uri(_paymentUrl);

                // Attach a handler for navigation completion
                webView21.NavigationCompleted += WebView21_NavigationCompleted;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing payment page: " + ex.Message);
            }
        }

        private void WebView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            try
            {
                // Check if navigation is successful and the URL indicates success
                if (e.IsSuccess && webView21.Source?.ToString().Contains("example.com") == true)
                {
                    // Automatically handle payment success when redirected to "example.com"
                    HandlePaymentSuccess();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during navigation handling: " + ex.Message);
            }
        }

        private void HandlePaymentSuccess()
        {
            // Display a success message (optional, could be skipped for automation)
            MessageBox.Show("Pembayaran berhasil! Sistem akan memperbarui stok dan kembali ke halaman utama.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                // Update the stock in the database
                UpdateStockInDatabase();

                // Navigate back to the main page
                NavigateToHalamanUtama();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message);
            }
        }

        private void UpdateStockInDatabase()
        {
            string query = _item is Trashes
                ? "UPDATE pub_plastika.\"Trashes\" SET quantity = quantity - @quantity WHERE id_trash = @id"
                : "UPDATE pub_plastika.\"Products\" SET quantity = quantity - @quantity WHERE id_product = @id";

            using (var conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantity", _quantity);
                        cmd.Parameters.AddWithValue("@id", _item.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Database update error: " + ex.Message);
                }
            }
        }

        private void NavigateToHalamanUtama()
        {
            // Close the current form and navigate to the main page
            this.Close();
            var mainPage = new HalamanUtamaNew();
            mainPage.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Allow user to manually cancel the payment process
            var confirmClose = MessageBox.Show(
                "Apakah Anda yakin ingin membatalkan pembayaran?",
                "Konfirmasi Pembatalan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmClose == DialogResult.Yes)
            {
                this.Hide();
                HalamanUtamaNew mainPage = new HalamanUtamaNew();
                mainPage.Show();
            }
        }
    }
}
