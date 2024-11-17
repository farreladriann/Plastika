using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AddProdukdanSampah
{
    public class Item
    {
        private int id;
        private int id_role;
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
        public int Id_Role
        {
            get { return id_role; }
            set { id_role = value; }
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
        public Item (int id_role, string name, string description, int quantity, long price, byte[] image)
        {
            this.id_role = id_role;
            this.name = name;
            this.description = description;
            this.quantity = quantity;
            this.price = price;
            this.image = image;

        }
    }
}
