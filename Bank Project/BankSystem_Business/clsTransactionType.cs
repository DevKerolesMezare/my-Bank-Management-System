using BankSystem_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Business
{
    public class clsTransactionType
    {

        // 1️⃣ Properties
        public int TransactionTypeID { get; set; }
        public string TypeName { get; set; }
        public bool IsActive { get; set; }


        // 2️⃣ Public Constructor with initial values
        public clsTransactionType()
        {
            // مش محتاجه في الاصدار دا 

            TransactionTypeID = -1;   // Primary Key
            TypeName = "";
            IsActive = true;
        }


        // 3️⃣ Private Constructor with all parameters
        private clsTransactionType(int transactionTypeID, string typeName, bool isActive)
        {
            this.TransactionTypeID = transactionTypeID;
            this.TypeName = typeName;
            this.IsActive = isActive;
        }

        public static clsTransactionType Find(int TransactionTypeID)
        {
            string TypeName = "";
            bool IsActive = false;

            if (clsTransactionTypesData.GetTransactionTypeByID(TransactionTypeID , ref TypeName , ref IsActive))
            {
                return new clsTransactionType(TransactionTypeID , TypeName , IsActive);
            }
            else
            {
                return null;
            }

        }

        public static bool UpdateTransactionTypeStatus(int TransactionTypeID, bool IsActive)
        {
            return clsTransactionTypesData.UpdateTransactionTypeStatus(TransactionTypeID,IsActive);
        }

        public static DataTable GetAllTransactionTypes()
        {
            return clsTransactionTypesData.GetAllTransactionTypes();
        }
    }
}
