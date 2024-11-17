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

        private void btnPesan_Click(object sender, EventArgs e)
        {

        }
    }
}
