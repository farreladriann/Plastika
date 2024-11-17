using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace WinFormUI
{
    public class Midtrans
    {
        private static readonly string serverKey = "your-server-key";
        private static readonly string apiUrl = "https://api.sandbox.midtrans.com/v2/charge";

        public async Task<string> CreateTransaction(string orderId, long amount)
        {
            var paymentData = new
            {
                transaction_details = new
                {
                    order_id = orderId,
                    gross_amount = amount
                },
                credit_card = new
                {
                    secure = true
                }
            };

            var jsonContent = JsonConvert.SerializeObject(paymentData);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(serverKey + ":")));
                var response = await client.PostAsync(apiUrl, content);
                var result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // Deserialize response to get Snap token
                    var jsonResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                    return jsonResponse["token"];
                }
                else
                {
                    MessageBox.Show("Error: Unable to create transaction");
                    return null;
                }
            }
        }

        public async Task<string> GetTransactionStatus(string orderId)
        {
            var url = $"https://api.midtrans.com/v2/{orderId}/status";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(serverKey + ":")));
                var response = await client.GetAsync(url);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
