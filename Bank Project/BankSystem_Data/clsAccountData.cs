using System;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BankSystem_Data
{
    public class clsAccountData
    {

        public static DataTable GetAccountStatement(string AccountNumber  , DateTime StartDate, DateTime EndDate)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAccountStatement", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@EndDate", EndDate);



                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader. HasRows)
                            {
                                dt.Load(reader);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }


                }
            }


            return dt;
        }



        public static int AddNewAccount
            (
            int CustomerID ,
            int CreatedByUserID, 
            int AccountTypeID,
            string AccountNumber,
            string PinCode,
            decimal AccountBalance,
            bool IsActive
            )
        {
            int NewAccountID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_AddNewAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    command.Parameters.AddWithValue("@PinCode", PinCode);
                    command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
                    command.Parameters.AddWithValue("@IsActive", IsActive);


                    SqlParameter OutParameter = new SqlParameter
                    {
                        ParameterName = "@NewAccountID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output,
                    };
                    command.Parameters.Add(OutParameter);


                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        NewAccountID = ((int)OutParameter.Value);

                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }

            }

            return NewAccountID;
        }



        public static bool CheckAccountExistsByAccountID(int AccountID)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_CheckAccountExistsByAccountID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID" , AccountID);


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

        public static bool CheckAccountExistsByAccountNumber(string AccountNumber)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_CheckAccountExistsByAccountNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);


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




        public static bool GetAccountByID
            (
             int AccountID,
         ref int      CustomerID,
         ref int      CreatedByUserID,
         ref DateTime CreatedDate,
         ref int      AccountTypeID,
         ref string   AccountNumber,
         ref string   PinCode,
         ref decimal  AccountBalance,
         ref int     UpdateByUserID,
         ref DateTime UpdateDate,
         ref bool     IsActive
            )
        {
            bool IsFound = false;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAccountByID", connection))
                {
                    command.CommandType=CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountID", AccountID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                 IsFound = true;
                                 CustomerID = (int)reader["CustomerID"];
                                 CreatedByUserID = (int)reader["CreatedByUserID"];
                                 CreatedDate  = (DateTime)reader["CreatedDate"];
                                 AccountTypeID  = (int)reader["AccountTypeID"];
                                 AccountNumber  = (string)reader["AccountNumber"];
                                 PinCode  = (string)reader["PinCode"];
                                 AccountBalance = (decimal)reader["AccountBalance"];

                                if (reader["UpdatedByUserID"] != System.DBNull.Value)
                                    UpdateByUserID = (int)reader["UpdatedByUserID"];
                                else
                                    UpdateByUserID = -1;

                                if (reader["UpdatedDate"] != System.DBNull.Value)
                                    UpdateDate = (DateTime)reader["UpdatedDate"];
                                else
                                    UpdateDate = DateTime.Now;

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
        

        public static bool GetAccountByAccountNumberAndPinCode
            (
             ref int        AccountID,
             ref int        CustomerID,
             ref int        CreatedByUserID,
             ref DateTime   CreatedDate,
             ref int        AccountTypeID,
                 string     AccountNumber,
                 string     PinCode,
             ref decimal    AccountBalance,
             ref int        UpdateByUserID,
             ref DateTime   UpdateDate,
             ref bool       IsActive

            )

        {
            bool IsFound = false;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAccountByAccountNumberAndPinCode", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    command.Parameters.AddWithValue("@PinCode", PinCode);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                AccountID = (int)reader["@AccountID"];
                                CustomerID = (int)reader["@CustomerID"];
                                CreatedByUserID = (int)reader["@CreatedByUserID"];
                                CreatedDate = (DateTime)reader["@CreatedDate"];
                                AccountTypeID = (int)reader["@AccountTypeID"];

                                AccountBalance = (int)reader["@AccountBalance"];

                                if (reader["@UpdateByUserID"] != System.DBNull.Value)
                                    UpdateByUserID = (int)reader["@UpdateByUserID"];
                                else
                                    UpdateByUserID = -1;

                                if (reader["@UpdateDate"] != System.DBNull.Value)
                                    UpdateDate = (DateTime)reader["@UpdateDate"];
                                else
                                    UpdateDate = DateTime.Now;

                                IsActive = (bool)reader["@IsActive"];
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



        public static bool GetAccountByAccountNumber
    (
     ref int AccountID,
     ref int CustomerID,
     ref int CreatedByUserID,
     ref DateTime CreatedDate,
     ref int AccountTypeID,
         string AccountNumber,
     ref string PinCode,
     ref decimal AccountBalance,
     ref int UpdateByUserID,
     ref DateTime UpdateDate,
     ref bool IsActive

    )

        {
            bool IsFound = false;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAccountByAccountNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                AccountID = (int)reader["AccountID"];
                                CustomerID = (int)reader["CustomerID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
                                AccountTypeID = (int)reader["AccountTypeID"];

                                PinCode = (string)reader["PinCode"];
                                AccountBalance = (decimal)reader["AccountBalance"];

                                if (reader["UpdatedByUserID"] != System.DBNull.Value)
                                    UpdateByUserID = (int)reader["UpdatedByUserID"];
                                else
                                    UpdateByUserID = -1;

                                if (reader["UpdatedDate"] != System.DBNull.Value)
                                    UpdateDate = (DateTime)reader["UpdatedDate"];
                                else
                                    UpdateDate = DateTime.Now;

                                IsActive = (bool)reader["IsActive"];

                                IsFound = true; 
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






        public static bool UpdateAccountDetails
            (
            int AccountID,
            int AccountTypeID,
            string AccountNumber,
            string PinCode,
            int UpdateByUserID,
            bool IsActive
            )
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateAccountDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID", AccountID);
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    command.Parameters.AddWithValue("@PinCode", PinCode);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
                    command.Parameters.AddWithValue("@UpdatedByUserID", UpdateByUserID);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }

            }
            return (rowsAffected > 0);
        }


        public static DataTable GetAllAccounts()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAllAccounts", connection))
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
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return dt;
        }





    }

}
