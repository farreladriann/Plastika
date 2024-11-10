using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AddProdukdanSampah
{
    internal class Item
    {
        private int id;
        private string name;
        private string description;
        private int quantity;
        private long price;
        private byte[] image;
        
        public int Id
        {
            get { return id; }
            set { id = value; }

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

        public long Price
        {
            get { return price; }
            set { price = value; }
        }

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }

        //Constructor
        public Item (string name, string description, int quantity, long price, byte[] image)
        {
            this.name = name;
            this.description = description;
            this.quantity = quantity;
            this.price = price;
            this.image = image;

        }
    }
}
