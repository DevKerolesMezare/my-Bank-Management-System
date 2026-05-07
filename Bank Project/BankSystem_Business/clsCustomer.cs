using BankSystem_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Business
{
    public class clsCustomer
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        // 1️⃣ Properties
        public int CustomerID { get; set; }
        public string Notes { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime CreatedAT { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo ;

        public int CreatedByUserID { get; set; }
        public clsUser UserInfo; 

        // 2️⃣ Public Constructor with initial values
        public clsCustomer()
        {
            Mode = enMode.AddNew;

            CustomerID = -1;       // Primary Key
            Notes = "";
            IsBlocked = false;
            CreatedAT = DateTime.MinValue;
            PersonID = -1;         // Foreign Key
            CreatedByUserID = -1;  // Foreign Key
        }


        // 3️⃣ Private Constructor with all parameters
        private clsCustomer(int customerID, string notes, bool isBlocked, DateTime createdAT, int personID, int createdByUserID)
        {
            Mode = enMode.Update;

            this.CustomerID = customerID;
            this.Notes = notes;
            this.IsBlocked = isBlocked;
            this.CreatedAT = createdAT;
            this.PersonID = personID;
            PersonInfo = clsPerson.Find(this.PersonID);

            this.CreatedByUserID = createdByUserID;
            UserInfo = clsUser.Find(this.CreatedByUserID);
        }

        private bool _AddNewCustomer()
        {
            this.CustomerID = clsCustomerData.AddNewCustomer(this.PersonID, this.CreatedByUserID, this.CreatedAT , this.Notes, this.IsBlocked);

            return (this.CustomerID != -1);
        }

        private bool _UpdateCustomer()
        {
            return clsCustomerData.UpdateCustomer(this.CustomerID, this.PersonID , this.Notes, this.IsBlocked);
        }

        public static bool DeleteCustomer(int CustomerID)
        {
            return clsCustomerData.DeleteCustomer(CustomerID);
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:                               
                    if (_AddNewCustomer())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                            return _UpdateCustomer();

                        }

            return false;
        }

        public static  clsCustomer Find(int CustomerID)
        {
            int PersonID = -1 ; 
            int CreatedByUserID = -1 ; 
            DateTime  CreatedAT = DateTime.Now ; 
            string Notes = "" ; 
            bool IsBlocked = false; 


            if
                (
                clsCustomerData.GetCustomerByID(CustomerID,
               ref  PersonID,
               ref  CreatedByUserID,
               ref  CreatedAT,
               ref  Notes,
               ref  IsBlocked
                               ))
            {
                return new clsCustomer(CustomerID, Notes, IsBlocked, CreatedAT, PersonID, CreatedByUserID);
            }
            else
                return null;

        }

        public static bool IsCustomerExists(int customerID)
        { 
            return clsCustomerData.IsCustomerExists(customerID);
        }

        public static DataTable GetAllCustomers()
        {
            return clsCustomerData.GetAllCustomers();
        }


        public static bool? IsCustomerBlocked(int CustomerID)
        {
            return clsCustomerData.IsCustomerBlocked(CustomerID);
        }
    }
}
