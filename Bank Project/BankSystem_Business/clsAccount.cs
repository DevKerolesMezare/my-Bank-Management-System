using BankSystem_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Business
{
    public class clsAccount
    {
       public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;



        // 1️⃣ Properties
        public int AccountID { get; set; }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CustomerID { get; set; }
        public clsCustomer CustomerInfo;
        public int AccountTypeID { get; set; }
        public clsAccountType AccountType;

        public int CreatedByUserID { get; set; }
        public clsUser CreatedUserInfo;

        public bool IsActive { get; set; }
        public int UpdatedByUserID { get; set; }
        public clsUser UpdatedUserInfo;
        public DateTime UpdatedDate { get; set; }

        // 2️⃣ Public Constructor with initial values
        public clsAccount()
        {
            Mode = enMode.AddNew;

            AccountID = -1;           // Primary Key
            AccountNumber = "";
            PinCode = "";
            AccountBalance = 0m;
            CreatedDate = DateTime.MinValue;
            CustomerID = -1;          // Foreign Key
            AccountTypeID = -1;       // Foreign Key
            CreatedByUserID = -1;     // Foreign Key
            IsActive = true;
            UpdatedByUserID = -1;     // Foreign Key
            UpdatedDate = DateTime.MinValue;
        }

        // 3️⃣ Private Constructor with all parameters
        private clsAccount(int accountID, string accountNumber, string pinCode, decimal accountBalance, DateTime createdDate,
                           int customerID, int accountTypeID, int createdByUserID, bool isActive, int updatedByUserID, DateTime updatedDate)
        {
            Mode = enMode.Update;


            this.AccountID = accountID;
            this.AccountNumber = accountNumber;
            this.PinCode = pinCode;
            this.AccountBalance = accountBalance;
            this.CreatedDate = createdDate;
            this.CustomerID = customerID;
            CustomerInfo = clsCustomer.Find(this.CustomerID);

            this.AccountTypeID = accountTypeID;
            AccountType = clsAccountType.Find(this.AccountTypeID);

            this.CreatedByUserID = createdByUserID;
            CreatedUserInfo = clsUser.Find(this.CreatedByUserID);

            this.IsActive = isActive;

            this.UpdatedByUserID = updatedByUserID;
            UpdatedUserInfo = clsUser.Find(this.UpdatedByUserID);
            this.UpdatedDate = updatedDate;
        }


        private bool _AddNewAccount()
        {
            this.AccountID = clsAccountData.AddNewAccount(this.CustomerID , this.CreatedByUserID ,this.AccountTypeID ,  this.AccountNumber , this.PinCode , this.AccountBalance = 0 , this.IsActive);
            
            return (this.AccountID != -1);
        }
        private bool _UpdateAccount()
        {
            return clsAccountData.UpdateAccountDetails(this.AccountID  , this.AccountTypeID , this.AccountNumber , this.PinCode , this.UpdatedByUserID , this.IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAccount())
                    {
                        Mode = enMode.Update;

                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateAccount();

            }

            return false;
        }


        public static DataTable GetAccountStatement(string AccountNumber , DateTime StartDate, DateTime EndDate)
        {
            return clsAccountData.GetAccountStatement(AccountNumber , StartDate, EndDate);
        }


        //public static bool DeleteAccount()
        //{

        //}

        public static clsAccount Find(string AccountNumber , string PinCode)
        {
            int AccountID      = -1;
            int CustomerID    = -1  ;
            int CreatedByUserID    = -1  ;
            DateTime   CreatedDate    = DateTime.Now;
            int AccountTypeID    = -1  ;
            decimal AccountBalance    = -1  ;
            int UpdateByUserID    = -1  ;
            DateTime   UpdateDate    = DateTime.Now  ;
            bool IsActive    = false  ;


            if (clsAccountData.GetAccountByAccountNumberAndPinCode(
               ref AccountID,
               ref CustomerID,
               ref CreatedByUserID,
               ref CreatedDate,
               ref AccountTypeID,
               AccountNumber,
               PinCode,
               ref AccountBalance,
               ref UpdateByUserID,
               ref UpdateDate,
               ref IsActive
                ))
            {
                return new clsAccount(
                    AccountID,
                    AccountNumber,
                    PinCode,
                    AccountBalance,
                    CreatedDate,
                    CustomerID,
                    AccountTypeID,
                    CreatedByUserID,
                    IsActive,
                    UpdateByUserID,
                    UpdateDate
                    );
            }
            else
                return null;
        }


        public static clsAccount Find(string AccountNumber )
        {
            int AccountID      = -1;
            int CustomerID    = -1  ;
            int CreatedByUserID    = -1  ;
            DateTime   CreatedDate    = DateTime.Now;
            int AccountTypeID    = -1  ;
            decimal AccountBalance    = -1  ;
            int UpdateByUserID    = -1  ;
            DateTime   UpdateDate    = DateTime.Now  ;
            bool IsActive    = false  ;
            string PinCode = "";


            if (clsAccountData.GetAccountByAccountNumber(
               ref AccountID,
               ref CustomerID,
               ref CreatedByUserID,
               ref CreatedDate,
               ref AccountTypeID,
               AccountNumber,
               ref PinCode,
               ref AccountBalance,
               ref UpdateByUserID,
               ref UpdateDate,
               ref IsActive
                ))
            {
                return new clsAccount(
                    AccountID,
                    AccountNumber,
                    PinCode,
                    AccountBalance,
                    CreatedDate,
                    CustomerID,
                    AccountTypeID,
                    CreatedByUserID,
                    IsActive,
                    UpdateByUserID,
                    UpdateDate
                    );
            }
            else
                return null;
        }




        public static clsAccount Find(int AccountID)
        {
            int CustomerID    = -1  ;
            int CreatedByUserID    = -1  ;
            DateTime   CreatedDate    = DateTime.Now;
            int AccountTypeID    = -1  ;
            decimal AccountBalance    = -1  ;
            int UpdateByUserID    = -1  ;
            DateTime   UpdateDate    = DateTime.Now  ;
            bool IsActive    = false  ;


            string AccountNumber = "";
            string PinCode = "";

            if (clsAccountData.GetAccountByID(
                AccountID,
               ref CustomerID,
               ref CreatedByUserID,
               ref CreatedDate,
               ref AccountTypeID,
               ref AccountNumber,
               ref PinCode,
               ref AccountBalance,
               ref UpdateByUserID,
               ref UpdateDate,
               ref IsActive
                ))
            {
                return new clsAccount(
                    AccountID,
                    AccountNumber,
                    PinCode,
                    AccountBalance,
                    CreatedDate,
                    CustomerID,
                    AccountTypeID,
                    CreatedByUserID,
                    IsActive,
                    UpdateByUserID,
                    UpdateDate
                    );
            }
            else
                return null;
        }



        public static bool IsAccountExists(string AccountNumber)
        {
            return clsAccountData.CheckAccountExistsByAccountNumber(AccountNumber);
        }
        public static bool IsAccountExists(int AccountID)
        {
            return clsAccountData.CheckAccountExistsByAccountID(AccountID);
        }


        public static DataTable GetAllAccounts()
        {
            return clsAccountData.GetAllAccounts();
        }


       public static bool IsAccountNumberUsed(string AccountNumber)
        {
            return clsAccountData.CheckAccountExistsByAccountNumber(AccountNumber);
        }

    }
}
