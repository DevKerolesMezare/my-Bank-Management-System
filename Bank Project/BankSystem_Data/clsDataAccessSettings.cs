using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Configuration;


namespace BankSystem_Data
{
    public class clsDataAccessSettings
    {

        //public static string ConnectionString = "server = .  ; Database = Bank_Management_System ; User ID = sa ; Password = sa123456";


        //public static string ConnectionString = ConfigurationManager.ConnectionStrings["Bank_Management_System"].ConnectionString;


        public static string ConnectionString = "Data Source=LENOVO; Initial Catalog=Bank_Management_System; Integrated Security=true;";
 
    }
}
