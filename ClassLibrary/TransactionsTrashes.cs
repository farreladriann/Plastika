﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class TransactionsTrashes : Transactions
    {
        public string getTransactionTrashesStatus(int idBuyer, int idSeller, int idItem)
        {
            // get status
        }

        public void newTransactionTrashes(int idBuyer, int idSeller, int idItem, int quantity, string transactionMethod)
        {
            // Buat transaksi pembelian trash baru
        }
    }
}
