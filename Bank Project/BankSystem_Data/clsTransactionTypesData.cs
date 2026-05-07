using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BankSystem_Data
{
    public class clsTransactionTypesData
    {
        public static bool GetTransactionTypeByID(int TransactionTypeID , ref string TypeName, ref bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command =  new SqlCommand("SP_GetTransactionTypeByID" , connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                TypeName = (string)reader["TypeName"];
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


        public static bool UpdateTransactionTypeStatus(int TransactionTypeID, bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateTransactionTypeStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

                    try
                    {
                        connection.Open();

                        isFound = (command.ExecuteNonQuery() > 0);
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return isFound;
        }


        public static DataTable GetAllTransactionTypes()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllTransactionTypes", connection))
                {
                    command.CommandType= CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                dataTable.Load(reader);
                        }
                    }
                    catch(Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

                return dataTable;
        }

    }

}
