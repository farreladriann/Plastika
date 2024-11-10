using AddProdukdanSampah;
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

namespace WinFormUI
{
    public partial class HalamanPemesanan : Form
    {
        private Trashes _trash;
        public HalamanPemesanan(Trashes trash)
        {
            InitializeComponent();
            _trash = trash;
            LoadTrashData();

            // Set maximum quantity in NumericUpDown to available stock
            numQuantity.Maximum = _trash.Quantity;
            numQuantity.Minimum = 1;
            numQuantity.ValueChanged += NumQuantity_ValueChanged;

            // Initialize total price based on default quantity (1)
            UpdateTotalPrice();
        }

        private void LoadTrashData()
        {
            lblName.Text = _trash.Trash_Name;
            lblDescription.Text = _trash.Description;
            lblStock.Text = $"{_trash.Quantity}";
            lblPrice.Text = _trash.Price.ToString("C");

            if (_trash.Trash_Image != null)
            {
                using (var ms = new MemoryStream(_trash.Trash_Image))
                {
                    picTrashImage.Image = Image.FromStream(ms);
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
            int selectedQuantity = (int)numQuantity.Value;
            decimal totalPrice = selectedQuantity * _trash.Price;
            lblTotalPrice.Text = $"{totalPrice:C}";
        }

        private async void btnPesan_Click(object sender, EventArgs e)
        {
            var orderId = "ORD12345";  // Unique order ID for the transaction
            var amount = 100000;  // Amount in the smallest currency unit (e.g., cents or smallest currency)

            var payment = new Midtrans();
            string snapToken = await payment.CreateTransaction(orderId, amount);

            if (!string.IsNullOrEmpty(snapToken))
            {
                // Open Snap payment form with the generated Snap token
                var snapForm = new SnapPaymentForm(snapToken);
                snapForm.ShowDialog(); // Open as a modal dialog
            }
            else
            {
                MessageBox.Show("Failed to initialize payment.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
