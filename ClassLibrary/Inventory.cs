using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Inventory
    {
        private int idInventory;
        private int idUser;
        private int idItems;
        private int quantity;

        public int IdInventory
        {
            get { return idInventory; }
            set { idInventory = value; }
        }


        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

       public int IdItems
        {
            get { return idItems; }
            set { idItems = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        
    }

}
