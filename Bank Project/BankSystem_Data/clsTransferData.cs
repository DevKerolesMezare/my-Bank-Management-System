using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BankSystem_Data
{
    public class clsTransferData
    {
        public static int AddNewTransfer
            (
             int CreatedByUserID,
             decimal Amount,
             int FromAccountID,
             int ToAccountID,
             string Note,
        ref int? ReturnValue

            )
        {
            int NewTransferID = -1;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_AddNewTransfer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@Amount", Amount);
                    command.Parameters.AddWithValue("@FromAccountID", FromAccountID);
                    command.Parameters.AddWithValue("@ToAccountID", ToAccountID);

                    if(!string.IsNullOrEmpty(Note)) 
                    command.Parameters.AddWithValue("@Note", Note);
                    else
                        command.Parameters.AddWithValue("@Note", System.DBNull.Value);


                    SqlParameter outPrameter = new SqlParameter
                    {
                        ParameterName = "@NewTransferID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outPrameter);


                    SqlParameter retValue = new SqlParameter();
                    retValue.Direction = ParameterDirection.ReturnValue;

                    command.Parameters.Add(retValue);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();


                        if(outPrameter.Value != null)
                             NewTransferID = (Convert.ToInt32(outPrameter.Value));

                        ReturnValue = (Convert.ToInt32(retValue.Value));

                    }
                    catch (Exception ex)
                    {
                        clsLogException.LogException($"Exception: {ex.Message}", EventLogEntryType.Error);
                    }
                }
            }
            return NewTransferID;
        }



        public static bool GetTransferByID
        (
            int TransferID,
        ref int CreatedByUserID,
        ref int FromAccountID,
        ref int ToAccountID,
        ref decimal Amount,
        ref int TransactionTypeID,
        ref string Note,
        ref DateTime CreatedDate
        )
        {
            bool isFound = false;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetTransferByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TransferID", TransferID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                TransferID        = (int)reader["TransferID"];
                                CreatedByUserID   = (int)reader["CreatedByUserID"];
                                FromAccountID     = (int)reader["FromAccountID"];
                                ToAccountID       = (int)reader["ToAccountID"];
                                Amount            = (decimal)reader["@Amount"];
                                TransactionTypeID = (int)reader["TransactionTypeID"];

                                if (reader["Note"] != null)
                                    Note = (string)reader["Note"];
                                else
                                    Note = "";

                                CreatedDate = (DateTime)reader["CreatedDate"];
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

    }
}
