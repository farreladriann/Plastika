using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Products
    {
        private int idProducts;
        private int idVendor;
        private string name;
        private string description;
        private int quantity;
        private int price;
        private byte image;

        public int IdProducts
        {
            get { return idProducts; }
        }

        public int IdVendor
        {
            get { return idVendor; }
            set { idVendor = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public byte Image
        {
            get { return image; }
            set { image = value; }
        }

        public void updateProducts(int idProducts, int quantity)
        {
            // Update quantity of a product
        }

        public void addProducts(int idProducts, string name, string description, int quantity, long price, byte image)
        {
            // Add new product to the inventory
        }
    }
}