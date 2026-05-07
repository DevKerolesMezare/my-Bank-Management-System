using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Data
{
    public class clsTransactionData
    {

        public static int AddNewTransaction
            (
            int AccountID,
            int TransactionTypeID,
            int CreatedByUserID,
            decimal Amount,
            string Note,
            /*string Note*/

            ref int? returnCode
            )
        {
            int NewTransactionID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewTransaction", connection)) 
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID", AccountID);
                    command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@Amount", Amount);

                    if (!string.IsNullOrEmpty(Note))
                        command.Parameters.AddWithValue("@Note", Note);
                    else
                        command.Parameters.AddWithValue("@Note", System.DBNull.Value);

                    // command.Parameters.AddWithValue("@Note", (object?)Note ?? DBNull.Value);


                    SqlParameter outPrame = new SqlParameter
                    {
                        ParameterName = "@NewTransactionID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output,
                    };
                    command.Parameters.Add(outPrame);



                    SqlParameter retValue = new SqlParameter();
                    retValue.Direction = ParameterDirection.ReturnValue;

                    command.Parameters.Add(retValue);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        NewTransactionID = (Convert.ToInt32(outPrame.Value));
                        returnCode = (Convert.ToInt32(retValue.Value));

                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return NewTransactionID;
        }


        public static DataTable GetAllTransactions()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAllTransactions" , connection))
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
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }

            return dt;
        }


        public static bool GetTransactionByID
            (
            int TransactionID,
            ref int        AccountID,
            ref int        TransactionTypeID,
            ref int        CreatedByUserID,
            ref decimal    Amount,
            ref string     Note,
            ref DateTime TransactionDate
            )
        {
            bool IsFound = false;



            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SP_GetTransactionByID", connection))
                {
                    command.CommandType=CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TransactionID", TransactionID);


                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                AccountID            = (int)reader["@AccountID"];
                                TransactionTypeID    = (int)reader["@TransactionTypeID"];
                                CreatedByUserID      = (int)reader["@CreatedByUserID"];
                                Amount               = (decimal)reader["@Amount"];
                                TransactionDate      = (DateTime)reader["@TransactionDate"];
                                Note                 = (string)reader["@Note"];
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


    }
}
