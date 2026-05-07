using BankSystem_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Business
{
    public class clsCountry
    {
        // 1️⃣ Properties
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

        // 2️⃣ Public Constructor with initial values
        public clsCountry()
        {
            CountryID = -1;       // Primary Key
            CountryName = "";
            CountryCode = "";
        }


        // 3️⃣ Private Constructor with all parameters
        private clsCountry(int countryID, string countryName, string countryCode)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
            this.CountryCode = countryCode;
        }

        static public clsCountry Find(int CountryID)
        {
            string CountryName = "";
            string CountryCode = "";

            if (clsCountryData.GetCountryInfo(CountryID, ref CountryName, ref CountryCode))
                return new clsCountry(CountryID, CountryName , CountryCode);
            else
                return null;
        }

        static public clsCountry Find(string CountryName)
        {
            int CountryID = -1;
            string CountryCode = "";

            if (clsCountryData.GetCountryInfo(ref CountryID, CountryName, ref CountryCode))
                return new clsCountry(CountryID, CountryName , CountryCode);
            else
                return null;
        }

        static public DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

        static public int GetCountryIDByName(string CountryName)
        {
            return clsCountryData.GetCountryIDByName(CountryName);
        }

        static public string GetCountryNameByID(int CountryID)
        {
            return clsCountryData.GetCountryNameByID(CountryID);
        }


    }
}
