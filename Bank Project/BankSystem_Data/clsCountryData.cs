using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Data
{
    public class clsCountryData
    {
        static public bool GetCountryInfo(int CountryID, ref string CountryName, ref string CountryCode )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CountryName = (string)reader["CountryName"];
                    CountryCode = (string)reader["CountryCode"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool GetCountryInfo(ref int CountryID, string CountryName, ref string CountryCode)
        {
            bool isFound = false; 

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CountryID = (int)reader["CountryID"];
                    CountryCode = (string)reader["CountryCode"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();

            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * from Countries ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }


            return dt;
        }

        static public int GetCountryIDByName(string CountryName)
        {
            int CountryID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select CountryID from Countries where CountryName =@CountryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                    CountryID = ID;

            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }


            return CountryID;
        }

        static public string GetCountryNameByID(int CountryID)
        {
            string CountryName = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select CountryName from Countries where CountryID =@CountryID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                CountryName = result.ToString();

            }
            catch
            {
                return "";
            }
            finally
            {
                connection.Close();
            }


            return CountryName;
        }


    }
}
