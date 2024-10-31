using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Transactions
    {
        private int idTransactions;
        private int idBuyer;
        private int idSeller;
        private int idItem;
        private int quantity;
        private int price;
        private string status;
        private string transactionMethod;

        public int IdTransaction
        {
            get { return idTransactions; }
            set { idTransactions = value; }
        }

        public int IdBuyer
        {
            get { return idBuyer; }
            set { idBuyer = value; }
        }

        public int IdSeller
        {
            get { return idSeller; }
            set { idSeller = value; }
        }

        public int IdItem
        {
            get { return idItem; }
            set { idItem = value; }
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

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string TransactionMethod
        {
            get { return transactionMethod; }
            set { transactionMethod = value; }
        }
    }
}
