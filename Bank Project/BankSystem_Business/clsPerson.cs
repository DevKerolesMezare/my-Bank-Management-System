using System;
using System.Data;
using BankSystem_Data;

namespace BankSystem_Business
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        // 1️⃣ Properties
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }
        public DateTime DateOfBirth { get; set; }
        public short Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public int CountryID { get; set; }
        public clsCountry CountryInfo; 

        public bool IsActive { get; set; }


       
        // 2️⃣ Public Constructor with initial values
        public clsPerson()
        {
            this.Mode = enMode.AddNew;

            this.PersonID = -1;        // Primary Key
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.MinValue;
            this.Gender = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.ImagePath = "";
            this.CountryID = -1;       // Foreign Key
            this.IsActive = true;
        }


        // 3️⃣ Private Constructor with all parameters
        private clsPerson(int personID, string nationalNo, string firstName, string secondName, string thirdName,
                          string lastName, DateTime dateOfBirth, short gender, string address, string phone,
                          string email, string imagePath, int countryID, bool isActive)
        {

            this.Mode = enMode.Update;

            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.ImagePath = imagePath;
            this.CountryID = countryID;
            this.CountryInfo = clsCountry.Find(this.CountryID);
            this.IsActive = isActive;
        }



        private bool _AddNewPerson()
        {
             this.PersonID = clsPersonData.AddNewPerson(
    this.NationalNo,
    this.FirstName,
    this.SecondName,
    this.ThirdName,
    this.LastName,
    this.DateOfBirth,
    this.Gender,
    this.Address,
    this.Phone,
    this.Email,
    this.ImagePath,
    this.CountryID   
);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(
                                                 this.PersonID,
                                                 this.NationalNo,
                                                 this.FirstName,
                                                 this.SecondName,
                                                 this.ThirdName,
                                                 this.LastName,
                                                 this.DateOfBirth,
                                                 this.Gender,
                                                 this.Address,
                                                 this.Phone,
                                                 this.Email,
                                                 this.ImagePath,
                                                 this.CountryID
                                               );
        }

        public static bool DeletePerson(int personID)
        {
            return (clsPersonData.DeletePerson(personID));
        }

        public static bool IsPersonExists(int PersonID)
        {
            return clsPersonData.IsPersonExists(PersonID);
        }

        public static bool IsPersonExists(string nationalNo)
        {
            return clsPersonData.IsPersonExists(nationalNo);
        }

        public static clsPerson Find(int PersonID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gender = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            string ImagePath = "";
            int CountryID = -1;
            bool IsActive = false;


            if (clsPersonData.GetPersonInfo
                (PersonID,
                ref NationalNo,
                ref FirstName,
                ref SecondName,
                ref ThirdName,
                ref LastName,
                ref DateOfBirth,
                ref Gender,
                ref Address,
                ref Phone,
                ref Email,
                ref ImagePath,
                ref CountryID,
                ref IsActive))
            {
                return new clsPerson(PersonID,
                     NationalNo,
                     FirstName,
                     SecondName,
                     ThirdName,
                     LastName,
                     DateOfBirth,
                     Gender,
                     Address,
                     Phone,
                     Email,
                     ImagePath,
                     CountryID,
                     IsActive
                    );
            }

            else
                return null;

        }

        public static clsPerson Find(string nationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gender = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            string ImagePath = "";
            int CountryID = -1;
            bool IsActive = false;


            if (clsPersonData.GetPersonInfo
                (
                ref PersonID,
                    nationalNo,
                ref FirstName,
                ref SecondName,
                ref ThirdName,
                ref LastName,
                ref DateOfBirth,
                ref Gender,
                ref Address,
                ref Phone,
                ref Email,
                ref ImagePath,
                ref CountryID,
                ref IsActive))
            {
                return new clsPerson(PersonID,
                     nationalNo,
                     FirstName,
                     SecondName,
                     ThirdName,
                     LastName,
                     DateOfBirth,
                     Gender,
                     Address,
                     Phone,
                     Email,
                     ImagePath,
                     CountryID,
                     IsActive
                    );
            }

            else
                return null;

        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

  
    
    }
}
