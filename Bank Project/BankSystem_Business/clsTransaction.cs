using BankSystem_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Business
{
    public class clsTransaction
    {
      
            // 1️⃣ Properties
            public int TransactionID { get; set; }
            public decimal Amount { get; set; }
            public DateTime TransactionDate { get; set; }
            public string Note { get; set; }
            public int AccountID { get; set; }
            public int TransactionTypeID { get; set; }
            public int CreatedByUserID { get; set; }


            public int? returnCode = null;

        // 2️⃣ Public Constructor with initial values
        public clsTransaction()
            {
                TransactionID = -1;       // Primary Key
                Amount = 0m;
                TransactionDate = DateTime.MinValue;
                Note = "";
                AccountID = -1;           // Foreign Key
                TransactionTypeID = -1;   // Foreign Key
                CreatedByUserID = -1;     // Foreign Key
            }

            // 3️⃣ Private Constructor with all parameters
            private clsTransaction(int transactionID, decimal amount, DateTime transactionDate, string note,
                                   int accountID, int transactionTypeID, int createdByUserID)
            {
                this.TransactionID = transactionID;
                this.Amount = amount;
                this.TransactionDate = transactionDate;
                this.Note = note;
                this.AccountID = accountID;
                this.TransactionTypeID = transactionTypeID;
                this.CreatedByUserID = createdByUserID;
            }

        public bool AddNewTransaction()
        {
           // int? returnCode = null;
            TransactionID = clsTransactionData.AddNewTransaction(this.AccountID , this.TransactionTypeID , this.CreatedByUserID , this.Amount ,this.Note , ref this.returnCode );

             return TransactionID != -1;
        }
      

        public static DataTable GetAllTransactions()
        {
            return clsTransactionData.GetAllTransactions();
        }

    }
}
