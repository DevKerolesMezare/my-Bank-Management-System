using BankSystem_Data;
using System.Data;


namespace BankSystem_Business
{
    public class clsAccountType
    {

        // 1️⃣ Properties
        public int AccountTypeID { get; set; }
        public string TypeName { get; set; }
        public bool IsActive { get; set; }



        // 2️⃣ Public Constructor with initial values
        public clsAccountType()
        {
            AccountTypeID = -1;   // Primary Key
            TypeName = "";
            IsActive = true;
        }



        // 3️⃣ Private Constructor with all parameters
        private clsAccountType(int accountTypeID, string typeName, bool isActive)
        {
            this.AccountTypeID = accountTypeID;
            this.TypeName = typeName;
            this.IsActive = isActive;
        }

        public static DataTable GetAllAccountTypes()
        {
            return clsAccountTypeData.GetAllAccountTypes();
        }

        public static clsAccountType Find(int AccountTypeID)
        {
            string TypeName = "";
            bool isActive = false;

            if (clsAccountTypeData.GetAccountTypeByID(AccountTypeID, ref TypeName, ref isActive))
            {
                return new clsAccountType(AccountTypeID, TypeName, isActive);
            }

            return null; 
        }

        public static clsAccountType Find(string TypeName)
        {     
            int AccountTypeID = -1;
            bool isActive = false;

            if (clsAccountTypeData.GetAccountTypeByTypeName(ref AccountTypeID,  TypeName, ref isActive))
            {
                return new clsAccountType(AccountTypeID, TypeName, isActive);
            }

            return null; 
        }

        public static bool EnableDisableService(int AccountTypeID, bool status)
        {
            return clsAccountTypeData.EnableDisableService(AccountTypeID, status);
        }      

        public bool UpdateAccountType()
        {
            return clsAccountTypeData.UpdateAccountType(this.AccountTypeID, this.TypeName);
        }



    }
}