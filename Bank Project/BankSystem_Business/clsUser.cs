using BankSystem_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Business
{
    public class clsUser
    {
        public enum enMode {AddNew = 0 ,Update = 1  };
        public enMode Mode = enMode.AddNew;

        // 1️⃣ Properties
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        // 2️⃣ Public Constructor with initial values
        public clsUser()
        {
            Mode = enMode.AddNew ;

            UserID = -1;      // Primary Key
            UserName = "";
            Password = "";
            IsActive = true;
            PersonID = -1;    // Foreign Key
        }

        // 3️⃣ Private Constructor with all parameters
        private clsUser(int userID, string userName, string password, bool isActive, int personID)
        {
            Mode = enMode.Update ;

            this.UserID = userID;
            this.UserName = userName;
            this.Password = password;
            this.IsActive = isActive;
            this.PersonID = personID;
            PersonInfo = clsPerson.Find(personID);
        }

      

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID , this.UserName , clsComputeHash.ComputeHash(this.Password) , this.IsActive);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
           return clsUserData.UpdateUser(this.UserID ,this.PersonID, this.UserName, clsComputeHash.ComputeHash(this.Password), this.IsActive);
        }

        public static bool DeleteUser(int userID)
        {
            return  clsUserData.DeleteUserByID(userID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static clsUser Find(int UserID)
        {
            int PersonID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            if(clsUserData.GetUserByID
                (UserID,
                  ref PersonID,
                  ref UserName,
                  ref Password,
                  ref IsActive
                ))
            {

                return new clsUser(UserID , UserName, Password, IsActive , PersonID);
            }
            else
                return null;
        }

        public static clsUser Find(string UserName, string password)
        {

            int UserID = -1; 
            int PersonID = -1;
            bool IsActive = false;

            if (clsUserData.GetUserByUserNameAndPassword
                ( ref UserID,
                  ref PersonID,
                      UserName,
                      clsComputeHash.ComputeHash(password),
                  ref IsActive
                ))
            {
                return new clsUser(UserID, UserName, password, IsActive, PersonID);
            }
            else
                return null;
        }

        public static bool IsUserExists(int userID)
        {
            return clsUserData.IsUserExists(userID);
        }

        public static bool IsUserExists(string UserName)
        {
            return clsUserData.IsUserExists(UserName);
        }

        public static bool isUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistForPersonID(PersonID);
        }

        public bool UpdateUserPassword(string NewPassword)
        {
            return clsUserData.UpdateUserPassword(this.UserID, clsComputeHash.ComputeHash(NewPassword));
        }

    }

}
