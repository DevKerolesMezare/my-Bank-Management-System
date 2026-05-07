using BankSystem_Business;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem_UI.Global_Classes
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser = null;

        public static clsAccount CurrentAccount = null;


        public static bool RememberUsernameAndPassword(string UserName, string Password)
        {
            bool IsSaved = false;

            string keyPath = @"SOFTWARE\BMS\CurrentUser";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(keyPath))
                {
                    if (key != null)
                    {

                        key.SetValue("UserName", UserName, RegistryValueKind.String);
                        key.SetValue("Password", Password, RegistryValueKind.String);
                        IsSaved = true;
                    }
                }
            }
            catch (Exception ex)
            {
                IsSaved = false;
            }

            return IsSaved;
        }
        public static bool GetStoredCredential( ref string UserName, ref string Password)
        {
            bool IsFound = false;

            string keyPath = @"SOFTWARE\BMS\CurrentUser";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath))
                {
                    if (key != null)
                    {
                        UserName = key.GetValue("UserName").ToString();
                        Password = key.GetValue("Password").ToString();
                        IsFound = true;
                    }
                }

            }
            catch (Exception ex)
            {
                IsFound = false;
            }

            return IsFound;
        }

    }
}
