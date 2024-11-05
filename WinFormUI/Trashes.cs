using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddProdukdanSampah
{
    public class Trashes
    {
        
        private string trash_name;
        private string description;
        private int quantity;
        private long price;
        private byte[] trash_image;

        
        public string Trash_Name
        {
            get { return trash_name; }
            set { trash_name = value; }
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

        public byte[] Trash_Image
        {
            get { return trash_image; }
            set { trash_image = value; }
        }

        // Constructor
        public Trashes(string trash_name, string description, int quantity, long price, byte[] trash_image)
        {
            this.trash_name = trash_name;
            this.description = description;
            this.quantity = quantity;
            this.price = price;
            this.trash_name = trash_name;
        }
    }

}
