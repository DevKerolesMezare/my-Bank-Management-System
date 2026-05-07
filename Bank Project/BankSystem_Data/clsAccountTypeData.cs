using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Data
{
    public static class clsAccountTypeData
    {
        public static DataTable GetAllAccountTypes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAllAccountTypes", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
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

        public static bool GetAccountTypeByID(int AccountTypeID, ref string TypeName, ref bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAccountTypeByID", connection))
                {
                    command.CommandType=CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);


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

        public static bool GetAccountTypeByTypeName(ref int AccountTypeID, string TypeName, ref bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Quere = "Select  AccountTypeID, TypeName, IsActive From AccountTypes Where TypeName = @TypeName";


                using (SqlCommand command = new SqlCommand(Quere, connection))
                {
                    command.Parameters.AddWithValue("@TypeName", TypeName);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                AccountTypeID = (int)reader["AccountTypeID"];
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


        public static bool EnableDisableService(int AccountTypeID, bool Status)
        {
            int rowAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Update AccountTypes set IsActive = @Status From AccountTypes Where AccountTypeID = @AccountTypeID", connection))
                {
                    command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
                    command.Parameters.AddWithValue("@Status", Status);

                    try
                    {
                        connection.Open();
                        rowAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }

                }
            }
            return (rowAffected > 0);
        }


        public static bool UpdateAccountType(int AccountTypeID, string TypeName)
        {
            int rowAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Update AccountTypes set TypeName = @TypeName From AccountTypes Where AccountTypeID = @AccountTypeID", connection))
                {
                    command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
                    command.Parameters.AddWithValue("@TypeName", TypeName);

                    try
                    {
                        connection.Open();
                        rowAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }

                return (rowAffected > 0);
            }

        }
    }
}
