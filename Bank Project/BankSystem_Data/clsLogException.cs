using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BankSystem_Data
{
    public  class clsLogException
    {
        public static void LogException(string eMessage , EventLogEntryType entryType)
        {
            string SourceApp = "Bank_Management_System_EX";

            try
            {
                if (!EventLog.SourceExists(SourceApp))
                    EventLog.CreateEventSource(SourceApp, "Application");

                EventLog.WriteEntry(SourceApp, eMessage, entryType);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry (SourceApp , "Exepction in LogExepction Method: " + ex.Message, EventLogEntryType.Error);                   
            }

        }

    }
}
