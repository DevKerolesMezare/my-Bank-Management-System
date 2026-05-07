using BankSystem_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Business
{
    public class clsTransfer
    {
        // 1️⃣ Properties
        public int TransferID { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
        public int FromAccountID { get; set; }
        public int ToAccountID { get; set; }
        public int TransactionTypeID { get; set; }
        public int CreatedByUserID { get; set; }




        // 2️⃣ Public Constructor with initial values
        public clsTransfer()
        {
            TransferID = -1;           // Primary Key
            Amount = 0m;
            Note = "";
            CreatedDate = DateTime.MinValue;
            FromAccountID = -1;        // Foreign Key
            ToAccountID = -1;          // Foreign Key
            TransactionTypeID = -1;    // Foreign Key
            CreatedByUserID = -1;      // Foreign Key
        }

        // 3️⃣ Private Constructor with all parameters
        private clsTransfer(int transferID, decimal amount, string note, DateTime createdDate,
                            int fromAccountID, int toAccountID, int transactionTypeID, int createdByUserID)
        {
            this.TransferID = transferID;
            this.Amount = amount;
            this.Note = note;
            this.CreatedDate = createdDate;
            this.FromAccountID = fromAccountID;
            this.ToAccountID = toAccountID;
            this.TransactionTypeID = transactionTypeID;
            this.CreatedByUserID = createdByUserID;
        }

        public bool AddNewTransfer(ref int? returnCode)
        {
            this.TransferID = clsTransferData.AddNewTransfer(this.CreatedByUserID , this.Amount , this.FromAccountID , this.ToAccountID ,this.Note , ref returnCode);
            return TransferID  != -1;
        }


    }
}
