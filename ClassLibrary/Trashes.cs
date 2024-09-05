using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Trashes
    {
        private int idTrashes;
        private int idAgent;
        private string name;
        private string description;
        private int quantity;
        private long price;
        private byte image;

        public int IdTrashes
        {
            get { return idTrashes; }
            set { idTrashes = value; }
        }

        public int IdAgent
        {
            get { return idAgent; }
            set { idAgent = value; }
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

        public void updateTrashes(int idTrashes, int quantity)
        {
            // Update the quantity of trashes in the inventory
        }

        public void addTrashes(int idTrashes, string name, string description, int quantity, long price, byte image)
        {
            // Add trashes to the inventory
        }
    }
}
