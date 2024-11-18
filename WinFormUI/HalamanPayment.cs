using AddProdukdanSampah;
using DotNetEnv;
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
        private string currentUsername;

        public HalamanPayment(string username, string paymentUrl, Item item, int quantity)
        {
            InitializeComponent();
            _paymentUrl = paymentUrl;
            _item = item;
            _quantity = quantity;
            currentUsername = username;

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
                if (e.IsSuccess && webView21.Source?.ToString().Contains("sites.google.com/mail.ugm.ac.id/plastikasuccesspayment/home") == true)
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
            MessageBox.Show("Pembayaran berhasil! Sistem akan memperbarui stok dan kembali ke halaman utama.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                UpdateStockInDatabase();
                InsertTransaction(); // Tambahkan ini untuk menyisipkan transaksi
                NavigateToHalamanUtama();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock or inserting transaction: " + ex.Message);
            }
        }

        private void InsertTransaction()
        {
            string query;
            if (_item is Trashes)
            {
                query = @"INSERT INTO pub_plastika.""Transactions_Trashes"" (id_trashes, id_account, quantity, date, price)
                  VALUES (@id, @accountId, @quantity, @date, @totalPrice)";
            }
            else // Assume _item is Products
            {
                query = @"INSERT INTO pub_plastika.""Transactions_Products"" (id_product, id_account, quantity, date, price)
                  VALUES (@id, @accountId, @quantity, @date, @totalPrice)";
            }

            decimal totalPrice = _item.Price * _quantity; // Menghitung harga total

            using (var conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _item.Id);
                    cmd.Parameters.AddWithValue("@accountId", GetAccountId(currentUsername));
                    cmd.Parameters.AddWithValue("@quantity", _quantity);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@totalPrice", totalPrice); // Menggunakan total harga

                    cmd.ExecuteNonQuery();
                }
            }
        }


        private int GetAccountId(string username)
        {
            string connString = Env.GetString("DB_URI");
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
        SELECT id_account FROM pub_plastika.""Account_Vendor"" WHERE username = @u
        UNION ALL
        SELECT id_account FROM pub_plastika.""Account_Agent"" WHERE username = @u";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("u", username);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
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
            var mainPage = new HalamanUtamaNew(currentUsername);
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
                HalamanUtamaNew mainPage = new HalamanUtamaNew(currentUsername);
                mainPage.Show();
            }
        }
    }
}