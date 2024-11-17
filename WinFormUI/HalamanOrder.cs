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
        private string currentUsername;

        public HalamanOrder(Item item, string username)
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
            currentUsername = username;
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
            HalamanUtamaNew orderPage = new HalamanUtamaNew(currentUsername);
            orderPage.Show();
        }

        private async void btnPesan_Click(object sender, EventArgs e)
        {
            btnPesan.Enabled = false;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://localhost:3000");

                    // Add logging to see what's being sent
                    Console.WriteLine($"Server Key: {Environment.GetEnvironmentVariable("MIDTRANS_SERVER_KEY")}");

                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(
                            Encoding.ASCII.GetBytes($"{Environment.GetEnvironmentVariable("MIDTRANS_SERVER_KEY")}:")));

                    var payload = new
                    {
                        order_id = $"order-{Guid.NewGuid()}",
                        gross_amount = (int)(numKuantitas.Value * _item.Price),
                        customer_details = new
                        {
                            first_name = "John",
                            last_name = "Doe",
                            email = "john.doe@example.com",
                            phone = "08123456789"
                        }
                    };

                    string jsonPayload = System.Text.Json.JsonSerializer.Serialize(payload);
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    // Log the request details
                    Console.WriteLine($"Request URL: {client.BaseAddress}/api/payment/create-transaction");
                    Console.WriteLine($"Payload: {jsonPayload}");

                    HttpResponseMessage response = await client.PostAsync("/api/payment/create-transaction", content);

                    // Get the response content regardless of status code
                    var responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Response Status: {response.StatusCode}");
                    Console.WriteLine($"Response Content: {responseContent}");

                    if (response.IsSuccessStatusCode)
                    {
                        var result = System.Text.Json.JsonSerializer.Deserialize<MidtransResponse>(responseContent);

                        if (result != null && result.redirect_url != null)
                        {
                            this.Close();
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
                        MessageBox.Show($"Error: {response.StatusCode}\nDetails: {responseContent}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnPesan.Enabled = true;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numKuantitas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class MidtransResponse
    {
        public string status { get; set; }
        public string token { get; set; }
        public string redirect_url { get; set; }
    }
}
