using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BankSystem_Data
{
    public class clsPersonData
    {

        public static bool GetPersonInfo
            (
             int      PersonID,
         ref string   NationalNo,
         ref string   FirstName,
         ref string   SecondName,
         ref string   ThirdName,
         ref string   LastName,
         ref DateTime DateOfBirth,
         ref short Gender,
         ref string   Address,
         ref string   Phone,
         ref string   Email,
         ref string   ImagePath,
         ref int      CountryID,
         ref bool     IsActive
            )
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read()) {
                                isFound = true;

                                NationalNo = Convert.ToString(reader["NationalNo"]);
                                FirstName =  Convert.ToString(reader["FirstName"]);
                                SecondName = Convert.ToString(reader["SecondName"]);

                                if (reader["ThirdName"] != System.DBNull.Value)
                                    ThirdName = Convert.ToString(reader["ThirdName"]);
                                else 
                                    ThirdName = "";

                                LastName =   Convert.ToString(reader["LastName"]);
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                                Gender = (short)reader["Gender"];
                                Address = Convert.ToString(reader["Address"]);
                                Phone = Convert.ToString(reader["Phone"]);

                                if(reader["Email"] != System.DBNull.Value)
                                Email = Convert.ToString(reader["Email"]);
                                else
                                    Email = "";

                                if (reader["ImagePath"] != System.DBNull.Value)
                                    ImagePath = Convert.ToString(reader["ImagePath"]);
                                else
                                    ImagePath = "";

                                CountryID = Convert.ToInt32(reader["CountryID"]); 
                                IsActive = Convert.ToBoolean(reader["IsActive"]);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException("" + ex, EventLogEntryType.Error);
                    }
                }
            }

            return isFound;
        }




        public static bool GetPersonInfo
            (
         ref int PersonID,
             string NationalNo,
         ref string FirstName,
         ref string SecondName,
         ref string ThirdName,
         ref string LastName,
         ref DateTime DateOfBirth,
         ref short Gender,
         ref string Address,
         ref string Phone,
         ref string Email,
         ref string ImagePath,
         ref int CountryID,
         ref bool IsActive
            )
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonByNationalNo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = Convert.ToInt32(reader["PersonID"]);
                                FirstName = Convert.ToString(reader["FirstName"]);
                                SecondName = Convert.ToString(reader["SecondName"]);

                                if (reader["ThirdName"] != System.DBNull.Value)
                                    ThirdName = Convert.ToString(reader["ThirdName"]);
                                else
                                    ThirdName = "";

                                LastName = Convert.ToString(reader["LastName"]);
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                                Gender = ((short)reader["Gender"]);
                                Address = Convert.ToString(reader["Address"]);
                                Phone = Convert.ToString(reader["Phone"]);

                                if (reader["Email"] != System.DBNull.Value)
                                    Email = Convert.ToString(reader["Email"]);
                                else
                                    Email = "";

                                if (reader["ImagePath"] != System.DBNull.Value)
                                    ImagePath = Convert.ToString(reader["ImagePath"]);
                                else
                                    ImagePath = "";

                                CountryID = Convert.ToInt32(reader["CountryID"]);
                                IsActive = Convert.ToBoolean(reader["IsActive"]);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return isFound;
        }



         public static int AddNewPerson
            (
             string NationalNo,
             string FirstName,
             string SecondName,
             string ThirdName,
             string LastName,
             DateTime DateOfBirth,
             short Gender,
             string Address,
             string Phone,
             string Email,
             string ImagePath,
             int CountryID
             )
        {
            int? NewPersonID = null;



            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);

                    command.Parameters.AddWithValue("@SecondName", SecondName);

                    if(!string.IsNullOrEmpty(ThirdName))
                         command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    else
                         command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);

                    if (!string.IsNullOrEmpty(Email))
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", System.DBNull.Value);

                    if (!string.IsNullOrEmpty(ImagePath))
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

                    command.Parameters.AddWithValue("@CountryID", CountryID);


                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@NewPersonID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        NewPersonID = (int)outputParam.Value;
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
        
            return NewPersonID.HasValue ? NewPersonID.Value : -1;
        }



        public static bool UpdatePerson
            (
             int    PersonID,
             string NationalNo,
             string FirstName,
             string SecondName,
             string ThirdName,
             string LastName,
             DateTime DateOfBirth,
             short Gender,
             string Address,
             string Phone,
             string Email,
             string ImagePath,
             int CountryID
            )

        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using(SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID );
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);

                    if (!string.IsNullOrEmpty(LastName))
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    else
                        command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);

                    if (!string.IsNullOrEmpty(Email))
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", System.DBNull.Value);

                    if (!string.IsNullOrEmpty(ImagePath))
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

                    command.Parameters.AddWithValue("@CountryID", CountryID);


                    try
                    {
                        connection.Open();

                        isUpdated = (command.ExecuteNonQuery() > 0); 
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }          
            }
            return isUpdated; 
        }


        static public bool DeletePerson(int PersonID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeletePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        isDeleted = (command.ExecuteNonQuery() > 0);
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return isDeleted;
        }

        public static bool IsPersonExists(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_CheckPersonExistsByPersonID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID" , PersonID);


                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(returnValue);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        isFound = (Convert.ToInt32(returnValue.Value) > 0);
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }

            }

                return isFound;
        }

        public static bool IsPersonExists(string NationalNo)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_CheckPersonExistsByNationalNo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NationalNo", NationalNo);


                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(returnValue);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        isFound = (Convert.ToInt32(returnValue.Value) > 0);
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }

            }

            return isFound;
        }


        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllPeople", connection))
                {
                    command.CommandType= CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return dt;
        }

    }
}
