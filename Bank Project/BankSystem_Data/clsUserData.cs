using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace BankSystem_Data
{
    public class clsUserData
    {

        //                         clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
        public static int AddNewUser
            (
                int    PersonID,
                string UserName,
                string Password,
                bool   IsActive       
            )
        {
            int? NewUserID = null ;

            using (SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);


                    command.Parameters.Add("@NewUserID" , SqlDbType.Int).Direction = ParameterDirection.Output;

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        object result = command.Parameters["@NewUserID"].Value;

                        if (result != null && result != DBNull.Value && int.TryParse(result.ToString(), out int newID))
                        {
                            NewUserID = newID;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }


            return NewUserID ?? -1 ;
        }

        static public bool DeleteUserByID(int UserID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();

                        isDeleted = (command.ExecuteNonQuery() > 0);
                    }
                    catch (Exception e)
                    {
                        clsLogException.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return isDeleted;
        }




        static public bool UpdateUser(int UserID, int PersonID, string Username, string Password, bool isActive)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", isActive);

                    try
                    {
                        connection.Open();
                        isUpdated = (command.ExecuteNonQuery() > 0);
                    }
                    catch (Exception e)
                    {
                        clsLogException.LogException($"Exception: {e.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return isUpdated;
        }



        public static bool GetUserByID
            (
                int UserID,
                ref int PersonID,
                ref string UserName,
                ref string Password,
                ref bool IsActive
            )
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetUserByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);


                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                PersonID = Convert.ToInt32(reader["PersonID"]);
                                UserName = Convert.ToString(reader["UserName"]);
                                Password = Convert.ToString(reader["Password"]);
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
            return IsFound;
        }

        public static bool GetUserByUserName
         (
              ref    int UserID,
              ref    int PersonID,
              string     UserName,
              ref    string Password,
              ref    bool IsActive
         )
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetUserByUserName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserName", UserName);


                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                UserID = Convert.ToInt32(reader["@UserID"]);
                                PersonID = Convert.ToInt32(reader["@PersonID"]);
                                Password = Convert.ToString(reader["@Password"]);
                                IsActive = Convert.ToBoolean(reader["@IsActive"]);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }

                }

            }
            return IsFound;
        }


        public static bool GetUserByUserNameAndPassword
            (
                 ref int UserID,
                 ref int PersonID,
                 string UserName,
                 string Password,
                 ref bool IsActive
             )
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetUserByUserNameAndPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                UserID = Convert.ToInt32(reader["UserID"]);
                                PersonID = Convert.ToInt32(reader["PersonID"]);
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
            return IsFound;
        }


        public static bool IsUserExists(int UserID)
        {
            bool IsFound = false;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CheckUserExistsUserID", connection))
                {
                    command.CommandType= CommandType.StoredProcedure;

                    command.Parameters.AddWithValue ("@UserID", UserID);

                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(returnValue);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        IsFound = (Convert.ToInt32(returnValue.Value)> 0);

                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return IsFound;
        }

        public static bool IsUserExists(string UserName)
        {
            bool IsFound = false;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CheckUserExistsByUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserName", UserName);

                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(returnValue);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        IsFound = (Convert.ToInt32(returnValue.Value) > 0);

                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return IsFound;
        }

        
        public static bool UpdateUserPassword(int UserID , string NewPassword)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateUserPassword", connection))
                {
                    command.CommandType= CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@NewPassword", NewPassword);

                    try
                    {
                        connection.Open();

                        IsFound = (command.ExecuteNonQuery()>0);

                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return IsFound;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


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


        public static bool IsUserExistForPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

    }

}
