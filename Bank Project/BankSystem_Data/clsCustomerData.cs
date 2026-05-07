using BankSystem_Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


//clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);


namespace BankSystem_Data
{
    public class clsCustomerData
    {
        public static bool GetCustomerByID
            (
                int       CustomerID,
            ref int       PersonID , 
            ref int       CreatedByUserID,
            ref DateTime  CreatedAT,
            ref string    Notes,
            ref bool     IsBlocked
            )
        {
            bool IsFound = false;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetCustomerByID" , connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CustomerID" , CustomerID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true; 

                                PersonID         = (int)reader["PersonID"];
                                CreatedByUserID  = (int)reader["CreatedByUserID"];
                                CreatedAT        = (DateTime)reader["CreatedAT"];

                                if (reader["Notes"] != System.DBNull.Value)
                                    Notes = (string)reader["Notes"];
                                else
                                    Notes = "";
                               IsBlocked = (bool)reader["IsBlocked"];
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
     


        public static int AddNewCustomer
            (
             int PersonID,
             int CreatedByUserID,
             DateTime CreatedAT,
             string Notes,
             bool IsBlocked
            )
        {
            int?NewCustomerID = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewCustomer" , connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID",PersonID);

                    if (!string.IsNullOrEmpty(Notes))
                        command.Parameters.AddWithValue("@Notes", Notes);
                    else
                        command.Parameters.AddWithValue("@Notes", System.DBNull.Value);

                    command.Parameters.AddWithValue("@IsBlocked",IsBlocked);
                    command.Parameters.AddWithValue("@CreatedByUserID",CreatedByUserID);


                    SqlParameter Outparameter = new SqlParameter
                    {
                        ParameterName = "@NewCustomerID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output,                        
                    };
                    command.Parameters.Add(Outparameter);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        if (command.Parameters["@NewCustomerID"].Value != DBNull.Value)
                        {
                            NewCustomerID = (int)command.Parameters["@NewCustomerID"].Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return NewCustomerID?? -1;
        }
              



        public static bool UpdateCustomer
            (
             int CustomerID,
             int PersonID,
             string Notes,
             bool IsBlocked
            ) 
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    if (!string.IsNullOrEmpty(Notes))
                        command.Parameters.AddWithValue("@Notes", Notes);
                    else
                        command.Parameters.AddWithValue("@Notes", System.DBNull.Value);

                    command.Parameters.AddWithValue("@IsBlocked", IsBlocked);


                    try
                    {
                        connection.Open();

                        IsFound = (command.ExecuteNonQuery() > 0);
                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }

            }
                return IsFound;
        }



              
        public static bool DeleteCustomer(int CustomerID)
        {
           bool IsFound = false;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteCustomer", connection))
                {
                    command.CommandType= CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID" , CustomerID);

                    try
                    {
                        connection.Open();

                        IsFound =  (command.ExecuteNonQuery() > 0);
                    }
                    catch(Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
                return IsFound;
        }
              
        public static bool IsCustomerExists(int CustomerID)
        {
            bool IsFound = false;

            using(SqlConnection connection = new SqlConnection( clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CheckCustomerExistsByCustomerID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CustomerID", CustomerID);

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

        public static DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllCustomers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
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




        public static bool? IsCustomerBlocked(int customerID)
        {
            bool? isBlocked = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT isBlocked From Customers WHERE CustomerID = @CustomerID", connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && result != System.DBNull.Value)
                        {
                            isBlocked = Convert.ToBoolean(result);
                        }

                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return isBlocked;
        }

    }
}
