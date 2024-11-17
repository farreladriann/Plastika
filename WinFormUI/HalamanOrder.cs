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
using System.Net.Http;
using AddProdukdanSampah;

namespace WinFormUI
{
    public partial class HalamanOrder : Form
    {
        private Item _item;

        public HalamanOrder(Item item)
        {
            InitializeComponent();
            _item = item;
            LoadItemData();

            // Set maximum quantity in NumericUpDown to available stock
            numKuantitas.Maximum = _item.Quantity;
            numKuantitas.Minimum = 1;
            numKuantitas.ValueChanged += NumQuantity_ValueChanged;

            // Initialize total price based on default quantity (1)
            UpdateTotalPrice();
        }

        private void LoadItemData()
        {
            lblName.Text = _item.Name;
            lblDescription.Text = _item.Description;
            lblStock.Text = $"{_item.Quantity}";
            lblPrice.Text = _item.Price.ToString("C");

            if (_item.Image != null)
            {
                using (var ms = new MemoryStream(_item.Image))
                {
                    picItemImage.Image = Image.FromStream(ms);
                }
            }
        }

        private void NumQuantity_ValueChanged(object sender, EventArgs e)
        {
            // Update total price whenever quantity is changed
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            int selectedQuantity = (int)numKuantitas.Value;
            decimal totalPrice = selectedQuantity * _item.Price;
            lblTotalPrice.Text = $"{totalPrice:C}";
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            HalamanUtamaNew orderPage = new HalamanUtamaNew();
            orderPage.Show();
        }

        private async void btnPesan_Click(object sender, EventArgs e)
        {
            // Disable the button to prevent multiple clicks
            btnPesan.Enabled = false;

            // Initialize HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Set the base address of the API
                    client.BaseAddress = new Uri("http://localhost:3000"); // Ganti dengan URL server backend Anda

                    // Tambahkan header Authorization
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(
                            Encoding.ASCII.GetBytes($"{Environment.GetEnvironmentVariable("MIDTRANS_SERVER_KEY")}:")));

                    // Construct the request payload
                    var payload = new
                    {
                        order_id = $"order-{Guid.NewGuid()}", // Generate a unique order ID
                        gross_amount = (int)(numKuantitas.Value * _item.Price), // Calculate total price
                        customer_details = new
                        {
                            first_name = "John",
                            last_name = "Doe",
                            email = "john.doe@example.com",
                            phone = "08123456789"
                        }
                    };

                    // Convert payload to JSON
                    string jsonPayload = System.Text.Json.JsonSerializer.Serialize(payload);
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    // Send POST request to backend
                    HttpResponseMessage response = await client.PostAsync("/api/payment/create-transaction", content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response JSON
                        var responseData = await response.Content.ReadAsStringAsync();
                        var result = System.Text.Json.JsonSerializer.Deserialize<MidtransResponse>(responseData);

                        // Open the redirect URL in the HalamanPayment form
                        if (result != null && result.redirect_url != null)
                        {
                            // Pass _item and the selected quantity to the HalamanPayment form
                            var paymentPage = new HalamanPayment(result.redirect_url, _item, (int)numKuantitas.Value);
                            paymentPage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve payment URL. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Re-enable the button
                    btnPesan.Enabled = true;
                }
            }
        }
    }

    public class MidtransResponse
    {
        public string status { get; set; }
        public string token { get; set; }
        public string redirect_url { get; set; }
    }
}
